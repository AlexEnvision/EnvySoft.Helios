using System;
using AForge.Controls;
using AForge.Video.DirectShow;
using NLog;

namespace Envysoft.Helios.Camera
{
    public class GenericUsbCamera : ICamera, IDisposable
    {
        private readonly Logger _log;

        //Поля под видеозапись, буфер видеозаписи камеры
        // ReSharper disable once ArrangeTypeMemberModifiers
        FilterInfoCollection _videoDevices;

        private VideoCaptureDevice _videoSource;

        public VideoCaptureDevice VideoSource => _videoSource;

        public GenericUsbCamera()
        {
            CameraInitialisation();
        }

        public GenericUsbCamera( Logger log)
        {
            _log = log;
            CameraInitialisation();
        }

        public void CameraInitialisation()
        {
            _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            _videoSource = new VideoCaptureDevice(_videoDevices[0].MonikerString);
        }

        public void Start()
        {
            try
            {
                _videoSource.Start();
            }
            catch (Exception ex)
            {
                _log?.Error(ex);
            }
        }

        public void Dispose()
        {
            if (_videoSource != null && _videoSource.IsRunning)
            {
                _videoSource.Stop();
                _videoSource = null;
            }
        }
    }
}

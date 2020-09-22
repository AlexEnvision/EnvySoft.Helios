using System.Drawing;

namespace Envysoft.Helios.Camera
{
    public class CameraFrameByte: ICameraFrame
    {
        readonly byte[] _byteBitmap;

        public CameraFrameByte(byte[] buffer) { this._byteBitmap = buffer; }

        public Bitmap GetBitmap()
        {
            throw new System.NotImplementedException();
        }

        public byte[] GetBuffer()
        {
            return _byteBitmap;
        }

    }
}

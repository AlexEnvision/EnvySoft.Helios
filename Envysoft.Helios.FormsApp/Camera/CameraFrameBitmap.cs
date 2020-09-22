using System.Drawing;

namespace Envysoft.Helios.Camera
{
    public class CameraFrameBitmap : ICameraFrame
    {
        readonly Bitmap _bitmap;

        public CameraFrameBitmap(Bitmap bmp) { _bitmap = bmp; }

        public Bitmap GetBitmap()
        {
            return _bitmap;
        }

        public byte[] GetBuffer()
        {
            return new byte[]{};
        }
    }
}

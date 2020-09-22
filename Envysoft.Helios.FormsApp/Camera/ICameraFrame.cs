using System.Drawing;

namespace Envysoft.Helios.Camera
{
    public interface ICameraFrame
    {
        Bitmap GetBitmap();
        byte[] GetBuffer();
    }
}

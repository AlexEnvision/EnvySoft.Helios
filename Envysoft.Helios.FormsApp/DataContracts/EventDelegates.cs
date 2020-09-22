using System.Drawing;
using Envysoft.Helios.Camera;

namespace Envysoft.Helios.DataContracts
{
    /// <summary>
    /// Делегат поиска подходящего изображения
    /// </summary>
    public delegate void ImageFoundDel();

    /// <summary>
    /// Делегат нахождения темплейта
    /// </summary>
    public delegate void TemplateFoundDel();

    /// <summary>
    /// Делегат изменения размера буфера с изображениями
    /// </summary>
    public delegate void BufferSizeChangedDel();

    /// <summary>
    /// Делегат найденного объекта
    /// </summary>
    public delegate void FoundedObjectDel();

    /// <summary>
    /// Делегат следующего кадра
    /// </summary>
    public delegate void NextFrameDel(CameraFrameBitmap bitmap);
}

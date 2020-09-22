using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Envysoft.Helios.Camera;
using Envysoft.Helios.ConvolutionFilter.Base;
using Envysoft.Helios.ConvolutionFilter;
using Envysoft.Helios.ConvolutionFilter.BlurFilter;
using Envysoft.Helios.ConvolutionFilter.SharpenFilter;
using NLog;

namespace Envysoft.Helios
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Границы масштабирования кадра
        /// </summary>
        private Rectangle _zoomBorder;

        private readonly Logger _log = LogManager.GetCurrentClassLogger();

        private readonly List<ConvolutionFilterBase> _filterList;

        /// <summary>
        /// Значение трэкбара
        /// </summary>
        private int _val;

        private GenericUsbCamera _usbCamera;

        public MainForm()
        {
            InitializeComponent();
            _filterList = new List<ConvolutionFilterBase> {
                new EdgeDetectionFilter(),
                new Sharpen3x3FactorFilter(),
                new Blur3x3Filter()
            };
        }

        /// <summary>
        /// Перехват кадра с камеры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="image"></param>
        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            try
            {
                if (rbRotate90FlipNone.Checked) image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                if (rbRotate180FlipNone.Checked) image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                if (rbRotate270FlipNone.Checked) image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                if (rbRotateNoneFlipX.Checked) image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                if (rbRotateNoneFlipY.Checked) image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                if (rbRotateNoneFlipXY.Checked) image.RotateFlip(RotateFlipType.RotateNoneFlipXY);
                
                //Масштабирование изображения, если указано
               
                if (_val > 1)
                { 
                    ZoomingCamera(_val, image);
                }
                else
                    pictureBox1.Image = image;              
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                MessageBox.Show(@"Проверьте камеру" + ex.Message);
            }
        }

        /// <summary>
        /// Получение кадра с видеокамеры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startCamera_Click(object sender, EventArgs e)
        {
            try
            {
                _usbCamera = new GenericUsbCamera(_log);
                videoSourcePlayer1.VideoSource = _usbCamera.VideoSource;
                _usbCamera.Start();
            }
            catch (ArgumentOutOfRangeException aex)
            {
                _log.Error(aex);
                MessageBox.Show(@"Нет подключенных устройств. " + @"Подключите устройство и попробуйте снова", @"Нет подключенных камер", MessageBoxButtons.OK, MessageBoxIcon.Stop,
                    MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                MessageBox.Show(@"Подключите устройство" + ex.Message, @"Подключите подключите устройство", MessageBoxButtons.OK, MessageBoxIcon.Stop,
                    MessageBoxDefaultButton.Button2);
            }
        }

        /// <summary>
        /// Измение масштаба изображения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomTrackBar_Scroll(object sender, EventArgs e)
        {
            ZoomTrackBar.Invoke((MethodInvoker)delegate
            {
                try
                {
                    _val = ZoomTrackBar.Value;
                }
                catch
                {
                    // ignored
                }
            });

            if (_usbCamera == null)
            {
                var source = pictureBox1.Image as Bitmap;
                Zooming(source);
            }
        }

        /// <summary>
        /// Метод масштабирования
        /// </summary>
        /// <param name="source"></param>
        private void Zooming(Bitmap source)
        {
            int w = Convert.ToInt32(pictureBox1.Image.Width * ((100 - ZoomTrackBar.Value) / 100.0));
            int h = Convert.ToInt32(pictureBox1.Image.Height * ((100 - ZoomTrackBar.Value) / 100.0));
            _zoomBorder = new Rectangle(Convert.ToInt32((pictureBox1.Image.Width - w) / 2), Convert.ToInt32((pictureBox1.Image.Height - h) / 2), w, h);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = source.Copy(_zoomBorder);
        }

        private void ZoomingCamera(int trackbarValue, Image im)
        {
            int w = Convert.ToInt32(im.Width * ((100 - trackbarValue) / 100.0));
            int h = Convert.ToInt32(im.Height * ((100 - trackbarValue) / 100.0));
            _zoomBorder = new Rectangle(Convert.ToInt32((im.Width - w) / 2), Convert.ToInt32((im.Height - h) / 2), w, h); 
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            var source = (im as Bitmap).Copy(_zoomBorder);

            if (cbUpSharpen.Checked)
            {
                cbAntialasing.Invoke((MethodInvoker)delegate { try { cbAntialasing.Enabled = true; }
                    catch
                    {
                        // ignored
                    }
                });
                if (cbAntialasing.Checked)
                {
                    source = source.ConvolutionFilter(_filterList[1]);
                    pictureBox1.Image = source.ConvolutionFilter(_filterList[2]);
                }
                else
                {
                    var filter = _filterList[1];
                    pictureBox1.Image = source.ConvolutionFilter(filter);
                }
            }
            else
            {
                cbAntialasing.Invoke((MethodInvoker)delegate { try { cbAntialasing.Enabled = false; }
                    catch
                    {
                        // ignored
                    }
                });
                pictureBox1.Image = source; 
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_usbCamera != null && _usbCamera.VideoSource.IsRunning)
            {
                videoSourcePlayer1.Stop();
                _usbCamera.Dispose();
                _usbCamera = null;
                videoSourcePlayer1 = null;
            }
        }

        private void cbUpSharpen_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbAntialasing_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}

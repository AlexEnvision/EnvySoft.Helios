using System.Collections.Generic;
using System.Drawing;

namespace Envysoft.Helios.DataContracts.Bufferization
{
    public class BitmapBuffer
    {
        public bool EnableFrameRate;

        private readonly List<Frame> _images = new List<Frame>();

        public static BitmapBuffer CreateBitmapBuffer { get; } = new BitmapBuffer();

        private BitmapBuffer()
        {
            IsFull = false;
        }

        public int Delay { get; set; }

        public bool IsFull { get; private set; }

        public bool IsEmpty { get; private set; }

        public int Size => _images.Count;

        //событие  
        public event BufferSizeChangedDel SizeChangedEvent;

        public void Push(Frame frameBitmap)
        {
            if (frameBitmap == null) return;

            if (_images.Count < Delay)
            {
                _images.Add(frameBitmap);
                IsEmpty = false;
            }
            else
            {
                IsFull = true;
                //генерирование события  
                SizeChangedEvent?.Invoke();
            }
        }

        //public Bitmap Pull(int index)
        //{
        //    Frame temp = null;
        //    if (_images[0].Index == index && _images.Count > 0)
        //    {
        //        temp = _images[0];
        //        _images.RemoveAt(0);
        //        IsFull = false;
        //        //генерирование события  
        //        if (SizeChangedEvent != null)
        //            SizeChangedEvent();
        //    }
        //    if (temp != null) return temp.Store;
        //    return null;
        //}

        public Bitmap Pull(int index)
        {
            Frame temp = null;
            if (_images.Count > 0)
            {
                temp = _images[index];
                _images.RemoveAt(index);
                IsFull = false;
                //генерирование события  
                SizeChangedEvent?.Invoke();
            }
            if (temp != null) return temp.Store;
            return null;
        }

        public Frame Pull()
        {
            Frame temp = null;
            if (_images.Count > 0)
            {
                temp = _images[0];
                _images.RemoveAt(0);
                IsFull = false;
                //генерирование события  
                if (SizeChangedEvent != null)
                    SizeChangedEvent();
            }
            else
            {
                IsEmpty = true;
            }
            if (temp == null)
                return null;
            return temp;
        }

        public void Clear()
        {
            _images.Clear();
        }

        public void Dispose()
        {
        }
    }
}
using System.Drawing;

namespace Envysoft.Helios.DataContracts.Bufferization
{
    public class Frame
    {
        public Frame(Bitmap source, int index)
        {
            Store = source;
            Index = index;
        }

        public int Index { get; set; }
        public Bitmap Store { get; set; }
    }
}
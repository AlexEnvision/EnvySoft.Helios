namespace Envysoft.Helios.DataContracts.Bufferization
{
    /// <summary>
    /// Ограничение по частоте кадров
    /// </summary>
    public enum FrameRate
    {
        AUTO = 0,
        FPS_24 = 42,
        FPS_25 = 40,
        FPS_30 = 33,
        FPS_50 = 20,
        FPS_60 = 17,
    }

    public class FrameRater
    {
        int CurrentFPS { get; set; }

        private bool isauto = false;
        private int FrameDelay; 

        public void Auto()
        {
            isauto = true; 
        }

        public void SET_24()
        {
            FrameDelay = 42;
            isauto = false;
        }
        public void SET_25()
        {
            FrameDelay = 40;
            isauto = false;
        }
        public void SET_30()
        {
            FrameDelay = 33;
            isauto = false;
        }
        public void SET_50()
        {
            FrameDelay = 20;
            isauto = false;
        }
        public void SET_60()
        {
            FrameDelay = 17;
            isauto = false;
        }

        public void Rated()
        {
            System.Threading.Thread.Sleep(FrameDelay);
        }      
    }
}

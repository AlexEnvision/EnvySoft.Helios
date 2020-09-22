namespace Envysoft.Helios.ConvolutionFilter.Base
{
    public abstract class ConvolutionFilterBase
    {
        public abstract string FilterName { get; }

        public abstract double Factor { get; }

        public abstract double Bias { get; }

        public abstract double[,] FilterMatrix { get; }
    }
}
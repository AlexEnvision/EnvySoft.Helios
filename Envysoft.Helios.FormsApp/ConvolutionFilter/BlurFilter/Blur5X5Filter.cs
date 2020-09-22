using Envysoft.Helios.ConvolutionFilter;
using Envysoft.Helios.ConvolutionFilter.Base;

namespace Envysoft.Helios.ConvolutionFilter.BlurFilter
{
    public class Blur5X5Filter : ConvolutionFilterBase
    {
        public override string FilterName => "Blur5x5Filter";

        public override double Factor { get; } = 1.0 / 13.0;

        public override double Bias { get; } = 0.0;

        public override double[,] FilterMatrix { get; } =
        {
            {0, 0, 1, 0, 0},
            {0, 1, 1, 1, 0},
            {1, 1, 1, 1, 1},
            {0, 1, 1, 1, 0},
            {0, 0, 1, 0, 0}
        };
    }
}
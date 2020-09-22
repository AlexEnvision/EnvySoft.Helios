using Envysoft.Helios.ConvolutionFilter;
using Envysoft.Helios.ConvolutionFilter.Base;

namespace Envysoft.Helios.ConvolutionFilter.BlurFilter
{
    public class Blur3x3Filter : ConvolutionFilterBase
    {
        public override string FilterName => "Blur3x3Filter";

        public override double Factor { get; } = 1.0;

        public override double Bias { get; } = 0.0;

        public override double[,] FilterMatrix { get; } =
        {
            {0.0, 0.2, 0.0},
            {0.2, 0.2, 0.2},
            {0.0, 0.2, 0.2}
        };
    }
}
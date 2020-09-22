using Envysoft.Helios.ConvolutionFilter;
using Envysoft.Helios.ConvolutionFilter.Base;

namespace Envysoft.Helios.ConvolutionFilter.BlurFilter
{
    public class Gaussian5X5BlurFilter : ConvolutionFilterBase
    {
        public override string FilterName => "Gaussian5x5BlurFilter";

        public override double Factor { get; } = 1.0 / 159.0;

        public override double Bias { get; } = 0.0;

        public override double[,] FilterMatrix { get; } =
        {
            {2, 04, 05, 04, 2},
            {4, 09, 12, 09, 4},
            {5, 12, 15, 12, 5},
            {4, 09, 12, 09, 4},
            {2, 04, 05, 04, 2}
        };
    }
}
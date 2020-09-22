using Envysoft.Helios.ConvolutionFilter;
using Envysoft.Helios.ConvolutionFilter.Base;

namespace Envysoft.Helios.ConvolutionFilter.BlurFilter
{
    public class Gaussian3X3BlurFilter : ConvolutionFilterBase
    {
        public override string FilterName => "Gaussian3x3BlurFilter";

        public override double Factor { get; } = 1.0 / 16.0;

        public override double Bias { get; } = 0.0;

        public override double[,] FilterMatrix { get; } =
        {
            {1, 2, 1},
            {2, 4, 2},
            {1, 2, 1}
        };
    }
}
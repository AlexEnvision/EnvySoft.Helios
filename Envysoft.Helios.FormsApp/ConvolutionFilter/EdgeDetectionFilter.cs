using Envysoft.Helios.ConvolutionFilter;
using Envysoft.Helios.ConvolutionFilter.Base;

namespace Envysoft.Helios.ConvolutionFilter
{
    public class EdgeDetectionFilter : ConvolutionFilterBase
    {
        public override string FilterName => "EdgeDetectionFilter";
        public override double Factor { get; } = 1.0;

        public override double Bias { get; } = 0.0;

        public override double[,] FilterMatrix { get; } =
        {
            {-1, -1, -1},
            {-1, 8, -1},
            {-1, -1, -1}
        };
    }
}
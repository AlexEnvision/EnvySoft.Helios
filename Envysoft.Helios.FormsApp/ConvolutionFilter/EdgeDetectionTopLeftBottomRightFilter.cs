using Envysoft.Helios.ConvolutionFilter;
using Envysoft.Helios.ConvolutionFilter.Base;

namespace Envysoft.Helios.ConvolutionFilter
{
    public class EdgeDetectionTopLeftBottomRightFilter : ConvolutionFilterBase
    {
        public override string FilterName => "EdgeDetectionTopLeftBottomRightFilter";

        public override double Factor { get; } = 1.0;

        public override double Bias { get; } = 0.0;

        public override double[,] FilterMatrix { get; } =
        {
            {-5, 0, 0},
            {0, 0, 0},
            {0, 0, 5}
        };
    }
}
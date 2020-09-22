using Envysoft.Helios.ConvolutionFilter;
using Envysoft.Helios.ConvolutionFilter.Base;

namespace Envysoft.Helios.ConvolutionFilter
{
    public class HorizontalEdgeDetectionFilter : ConvolutionFilterBase
    {
        public override string FilterName => "HorizontalEdgeDetectionFilter";

        public override double Factor { get; } = 1.0;

        public override double Bias { get; } = 0.0;

        public override double[,] FilterMatrix { get; } =
        {
            {0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0},
            {-1, -1, 2, 0, 0},
            {0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0}
        };
    }
}
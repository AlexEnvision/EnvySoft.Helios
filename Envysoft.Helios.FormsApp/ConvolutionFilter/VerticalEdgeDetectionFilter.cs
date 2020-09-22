using Envysoft.Helios.ConvolutionFilter;
using Envysoft.Helios.ConvolutionFilter.Base;

namespace Envysoft.Helios.ConvolutionFilter
{
    public class VerticalEdgeDetectionFilter : ConvolutionFilterBase
    {
        public override string FilterName => "VerticalEdgeDetectionFilter";

        public override double Factor { get; } = 1.0;

        public override double Bias { get; } = 0.0;

        public override double[,] FilterMatrix { get; } =
        {
            {0, 0, -1, 0, 0},
            {0, 0, -1, 0, 0},
            {0, 0, 4, 0, 0},
            {0, 0, -1, 0, 0},
            {0, 0, -1, 0, 0}
        };
    }
}
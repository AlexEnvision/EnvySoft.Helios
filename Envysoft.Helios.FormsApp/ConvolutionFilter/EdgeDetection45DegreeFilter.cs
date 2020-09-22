using Envysoft.Helios.ConvolutionFilter;
using Envysoft.Helios.ConvolutionFilter.Base;

namespace Envysoft.Helios.ConvolutionFilter
{
    public class EdgeDetection45DegreeFilter : ConvolutionFilterBase
    {
        public override string FilterName => "EdgeDetection45DegreeFilter";

        public override double Factor { get; } = 1.0;

        public override double Bias { get; } = 0.0;

        public override double[,] FilterMatrix { get; } =
        {
            {-1, 0, 0, 0, 0},
            {0, -2, 0, 0, 0},
            {0, 0, 6, 0, 0},
            {0, 0, 0, -2, 0},
            {0, 0, 0, 0, -1}
        };
    }
}
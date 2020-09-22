using Envysoft.Helios.ConvolutionFilter;
using Envysoft.Helios.ConvolutionFilter.Base;

namespace Envysoft.Helios.ConvolutionFilter.BlurFilter
{
    public class MotionBlurFilter : ConvolutionFilterBase
    {
        public override string FilterName => "MotionBlurFilter";

        public override double Factor { get; } = 1.0 / 18.0;

        public override double Bias { get; } = 0.0;

        public override double[,] FilterMatrix { get; } =
        {
            {1, 0, 0, 0, 0, 0, 0, 0, 1},
            {0, 1, 0, 0, 0, 0, 0, 1, 0},
            {0, 0, 1, 0, 0, 0, 1, 0, 0},
            {0, 0, 0, 1, 0, 1, 0, 0, 0},
            {0, 0, 0, 0, 1, 0, 0, 0, 0},
            {0, 0, 0, 1, 0, 1, 0, 0, 0},
            {0, 0, 1, 0, 0, 0, 1, 0, 0},
            {0, 1, 0, 0, 0, 0, 0, 1, 0},
            {1, 0, 0, 0, 0, 0, 0, 0, 1}
        };
    }
}
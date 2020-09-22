using Envysoft.Helios.ConvolutionFilter;
using Envysoft.Helios.ConvolutionFilter.Base;

namespace Envysoft.Helios.ConvolutionFilter.SharpenFilter
{
    public class SharpenFilter : ConvolutionFilterBase
    {
        public override string FilterName => "SharpenFilter";

        public override double Factor { get; } = 1.0;

        public override double Bias { get; } = 0.0;

        public override double[,] FilterMatrix { get; } =
        {
            {-1, -1, -1},
            {-1, 9, -1},
            {-1, -1, -1}
        };
    }

    public class Sharpen3x3Filter : ConvolutionFilterBase
    {
        public override string FilterName => "Sharpen3x3Filter";

        public override double Factor { get; } = 1.0;

        public override double Bias { get; } = 0.0;

        public override double[,] FilterMatrix { get; } =
        {
            {0, -1, 0},
            {-1, 5, -1},
            {0, -1, 0}
        };
    }

    public class Sharpen3x3FactorFilter : ConvolutionFilterBase
    {
        public override string FilterName => "Sharpen3x3FactorFilter";

        public override double Factor { get; } = 1.0 / 3.0;

        public override double Bias { get; } = 0.0;

        public override double[,] FilterMatrix { get; } =
        {
            {0, -2, 0},
            {-2, 11, -2},
            {0, -2, 0}
        };
    }

    public class Sharpen5x5Filter : ConvolutionFilterBase
    {
        public override string FilterName => "Sharpen5x5Filter";

        public override double Factor { get; } = 1.0 / 8.0;

        public override double Bias { get; } = 0.0;

        public override double[,] FilterMatrix { get; } =
        {
            {-1, -1, -1, -1, -1},
            {-1, 2, 2, 2, -1},
            {-1, 2, 8, 2, 1},
            {-1, 2, 2, 2, -1},
            {-1, -1, -1, -1, -1}
        };
    }

    public class IntenseSharpenFilter : ConvolutionFilterBase
    {
        public override string FilterName => "IntenseSharpenFilter";

        public override double Factor { get; } = 1.0;

        public override double Bias { get; } = 0.0;

        public override double[,] FilterMatrix { get; } =
        {
            {1, 1, 1},
            {1, -7, 1},
            {1, 1, 1}
        };
    }
}
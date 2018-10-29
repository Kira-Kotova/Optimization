using System;

namespace Functions
{
    public class DataProvider
    {
        private double k;
        private double t;
        private double i;
        private double min;
        private double max;
        private double j = Math.Pow(-1, 1/2.0);

        public double K
        {
            get => k;
            set
            {
                k = value;
            }
        }
        
        public double T
        {
            get => t;
            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentException($"{nameof(value)} is null");
                t = value;
            }
        }
        
        public double I
        {
            get => i;
            set
            {
                i = value;
            }
        }
        
        public double J => j;

        public double Min
        {
            get => min;
            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentException($"{nameof(value)} is null");
                min = value;
            }
        }

        public double Max
        {
            get => max;
            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentException($"{nameof(value)} is null");
                max = value;
            }
        }
        public DataProvider(double t,double min, double max, double i = double.NaN, double k = double.NaN)
        {
            T = t;
            I = i;
            K = k;
            Min = min;
            Max = max;
        }
    }
}

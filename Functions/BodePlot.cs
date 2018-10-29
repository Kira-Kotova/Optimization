using System.Windows.Forms.DataVisualization.Charting;
using static System.Math;

namespace Functions
{
    class BodePlot : AbstractFunc //лачх
    {
        public BodePlot(DataProvider data) : base(data)
        {
        }

        public override void Draw(Chart chart)
        {
            double Y;
            for (double w = 0; w <= 50; w += 0.01)
            {
                Y = 20 * Log(DataInfo.K);
                if (w <= (1 / DataInfo.T))
                    Y -= 40 * Log(DataInfo.T * w);
            }
        }
    }
}

using System.Windows.Forms.DataVisualization.Charting;
using static System.Math;

namespace Functions
{
    class PhaseResponse : AbstractFunc //ФЧХ
    {
        public PhaseResponse(DataProvider data) : base(data)
        {
        }

        public override void Draw(Chart chart)
        {
            double Y;
            for (double w = 0; w <= 50; w += 0.01)
            {
                Y = -Atan((2 * DataInfo.T * DataInfo.I * w) / (1 - Pow(DataInfo.T, 2) * Pow(w, 2)));
                if (w > (1 / DataInfo.T))
                    Y += -PI;
                
            }
        }
    }
}

using System.Windows.Forms.DataVisualization.Charting;
using static System.Math;

namespace Functions
{
    public class FrequencyResponse : AbstractFunc //АЧХ
    {
        public FrequencyResponse(DataProvider data) : base(data)
        {
        }
        
        public override void Draw(Chart chart)
        {
            double Y;
            double X;
            chart.ChartAreas[0].AxisX.ScaleView.Zoom(DataInfo.Min, DataInfo.Max);
            chart.ChartAreas[0].AxisY.ScaleView.Zoom(-5, 5);
            chart.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

            for (double w = 0; w <= 50; w += 0.01)
            {
                Y = DataInfo.K / Sqrt(Pow(1 - Pow(DataInfo.T, 2) * Pow(w, 2), 2) + 4 * Pow(DataInfo.I, 2) * Pow(DataInfo.T, 2) * Pow(w, 2));
                X = w;

                chart.Series[0].Points.AddXY(X, Y);

            }
            
        }
    }
}

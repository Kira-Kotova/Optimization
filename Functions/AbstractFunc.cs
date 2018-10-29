using System.Windows.Forms.DataVisualization.Charting;

namespace Functions
{
    public enum FuncType
    {
        FrequencyResponse, //АЧХ
        PhaseResponse, //ФЧХ
        BodePlot //ЛАЧХ
    }
    
    public abstract class AbstractFunc
    {
        public DataProvider DataInfo;
        
        public AbstractFunc(DataProvider data) => DataInfo = data;

        public AbstractFunc(AbstractFunc func) => DataInfo = func.DataInfo;

        public abstract void Draw(Chart chart);
    }
}

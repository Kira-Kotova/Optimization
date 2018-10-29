using Functions;
using System;
using System.Windows.Forms;


namespace Optimization
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
            DrawButton.Enabled = false;
            KValue.Enabled = false;
            TValue.Enabled = false;
            IValue.Enabled = false;
            MinValue.Enabled = false;
            MaxValue.Enabled = false;
        }

        private FuncType Type;

        private DataProvider DataInfo;

        private AbstractFunc GetFunc(FuncType type)
        {
            AbstractFunc func;
            switch (type)
            {
                case FuncType.FrequencyResponse:
                    func = new FrequencyResponse(DataInfo);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }
            return func;
        }

        
        private void DrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                var T = double.Parse(TValue.Text);
                var I = double.Parse(IValue.Text);
                var K = double.Parse(KValue.Text);
                var Min = double.Parse(MinValue.Text);
                var Max = double.Parse(MaxValue.Text);
                DataInfo = new DataProvider(T, Min, Max, I, K);
                var func = GetFunc(Type);
                func.Draw(MainChart);

            }
            catch { throw new ArgumentException(); }
        }

        //Ввод только чисел
        private void Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && (ch != '.' || KValue.Text.Contains(".")))
                e.Handled = true;

        }

        //Выбор функции
        private void BoxWithFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TValue.Enabled = true;
            MinValue.Enabled = true;
            MaxValue.Enabled = true;

            var selected = BoxWithFunc.SelectedIndex;
            switch (selected)
            {
                case 0:
                    Type = FuncType.FrequencyResponse;//ачх
                    break;
                case 1:
                    Type = FuncType.PhaseResponse;//фчх
                    KValue.Enabled = true;
                    break;
                case 2:
                    Type = FuncType.BodePlot;//лачх
                    IValue.Enabled = true;
                    break;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            KValue.Text = string.Empty;
            TValue.Text = string.Empty;
            IValue.Text = string.Empty;
            MinValue.Text = string.Empty;
            MaxValue.Text = string.Empty;
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
            DrawButton.Enabled = true;
        }
    }
}

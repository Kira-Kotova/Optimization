namespace Optimization
{
    partial class Chart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BoxWithFunc = new System.Windows.Forms.ComboBox();
            this.K = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.I = new System.Windows.Forms.Label();
            this.KValue = new System.Windows.Forms.TextBox();
            this.TValue = new System.Windows.Forms.TextBox();
            this.IValue = new System.Windows.Forms.TextBox();
            this.MinValue = new System.Windows.Forms.TextBox();
            this.DrawButton = new System.Windows.Forms.Button();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Min = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.MaxValue = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxWithFunc
            // 
            this.BoxWithFunc.FormattingEnabled = true;
            this.BoxWithFunc.Items.AddRange(new object[] {
            "АЧХ",
            "ЛАЧХ",
            "ФЧХ"});
            this.BoxWithFunc.Location = new System.Drawing.Point(20, 20);
            this.BoxWithFunc.Name = "BoxWithFunc";
            this.BoxWithFunc.Size = new System.Drawing.Size(150, 21);
            this.BoxWithFunc.TabIndex = 0;
            this.BoxWithFunc.Text = "Выбор функции";
            this.BoxWithFunc.SelectedIndexChanged += new System.EventHandler(this.BoxWithFunc_SelectedIndexChanged);
            // 
            // K
            // 
            this.K.Location = new System.Drawing.Point(20, 60);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(40, 22);
            this.K.TabIndex = 7;
            this.K.Text = "K :=";
            this.K.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(20, 100);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(40, 22);
            this.T.TabIndex = 8;
            this.T.Text = "T :=";
            this.T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // I
            // 
            this.I.Location = new System.Drawing.Point(20, 140);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(40, 22);
            this.I.TabIndex = 9;
            this.I.Text = "I :=";
            this.I.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KValue
            // 
            this.KValue.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.KValue.Location = new System.Drawing.Point(70, 60);
            this.KValue.Name = "KValue";
            this.KValue.Size = new System.Drawing.Size(100, 20);
            this.KValue.TabIndex = 1;
            this.KValue.TextChanged += new System.EventHandler(this.Value_TextChanged);
            this.KValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value_KeyPress);
            // 
            // TValue
            // 
            this.TValue.Location = new System.Drawing.Point(70, 100);
            this.TValue.Name = "TValue";
            this.TValue.Size = new System.Drawing.Size(100, 20);
            this.TValue.TabIndex = 2;
            this.TValue.TextChanged += new System.EventHandler(this.Value_TextChanged);
            this.TValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value_KeyPress);
            // 
            // IValue
            // 
            this.IValue.Location = new System.Drawing.Point(70, 140);
            this.IValue.Name = "IValue";
            this.IValue.Size = new System.Drawing.Size(100, 20);
            this.IValue.TabIndex = 3;
            this.IValue.TextChanged += new System.EventHandler(this.Value_TextChanged);
            this.IValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value_KeyPress);
            // 
            // MinValue
            // 
            this.MinValue.Location = new System.Drawing.Point(50, 180);
            this.MinValue.Name = "MinValue";
            this.MinValue.Size = new System.Drawing.Size(40, 20);
            this.MinValue.TabIndex = 4;
            this.MinValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value_KeyPress);
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(20, 220);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(150, 22);
            this.DrawButton.TabIndex = 6;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // MainChart
            // 
            chartArea1.Name = "ChartArea";
            this.MainChart.ChartAreas.Add(chartArea1);
            this.MainChart.Location = new System.Drawing.Point(200, 20);
            this.MainChart.Name = "MainChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend";
            series1.Name = "Series";
            this.MainChart.Series.Add(series1);
            this.MainChart.Size = new System.Drawing.Size(657, 411);
            this.MainChart.TabIndex = 0;
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(20, 180);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(30, 22);
            this.Min.TabIndex = 12;
            this.Min.Text = "Min:";
            this.Min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(100, 180);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(30, 22);
            this.Max.TabIndex = 8;
            this.Max.Text = "Max:";
            this.Max.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaxValue
            // 
            this.MaxValue.Location = new System.Drawing.Point(130, 180);
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.Size = new System.Drawing.Size(40, 20);
            this.MaxValue.TabIndex = 5;
            this.MaxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value_KeyPress);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(20, 260);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(150, 22);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Plots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 456);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.MaxValue);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.MainChart);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.KValue);
            this.Controls.Add(this.TValue);
            this.Controls.Add(this.IValue);
            this.Controls.Add(this.MinValue);
            this.Controls.Add(this.K);
            this.Controls.Add(this.T);
            this.Controls.Add(this.I);
            this.Controls.Add(this.BoxWithFunc);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Plots";
            this.Text = "Plots";
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BoxWithFunc;
        private System.Windows.Forms.Label K;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.Label I;
        private System.Windows.Forms.TextBox KValue;
        private System.Windows.Forms.TextBox TValue;
        private System.Windows.Forms.TextBox IValue;
        private System.Windows.Forms.TextBox MinValue;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.TextBox MaxValue;
        private System.Windows.Forms.Button Reset;
    }
}


namespace GeneradorFunciones
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.signalsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBarFrequency = new System.Windows.Forms.TrackBar();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblAmplitude = new System.Windows.Forms.Label();
            this.trackBarAmplittude = new System.Windows.Forms.TrackBar();
            this.lblOffset = new System.Windows.Forms.Label();
            this.trackBarOffset = new System.Windows.Forms.TrackBar();
            this.lblSimetry = new System.Windows.Forms.Label();
            this.trackBarSimetry = new System.Windows.Forms.TrackBar();
            this.btnSquareSignal = new System.Windows.Forms.Button();
            this.btnSignalTriangular = new System.Windows.Forms.Button();
            this.btnSignalSenoidal = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.signalsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmplittude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSimetry)).BeginInit();
            this.SuspendLayout();
            // 
            // signalsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.signalsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.signalsChart.Legends.Add(legend1);
            this.signalsChart.Location = new System.Drawing.Point(1, -1);
            this.signalsChart.Name = "signalsChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Signal";
            this.signalsChart.Series.Add(series1);
            this.signalsChart.Size = new System.Drawing.Size(507, 510);
            this.signalsChart.TabIndex = 0;
            this.signalsChart.Text = "chart1";
            // 
            // trackBarFrequency
            // 
            this.trackBarFrequency.Location = new System.Drawing.Point(531, 213);
            this.trackBarFrequency.Name = "trackBarFrequency";
            this.trackBarFrequency.Size = new System.Drawing.Size(294, 45);
            this.trackBarFrequency.TabIndex = 1;
            this.trackBarFrequency.ValueChanged += new System.EventHandler(this.trackBarFrequency_ValueChanged);
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequency.Location = new System.Drawing.Point(527, 180);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(124, 20);
            this.lblFrequency.TabIndex = 2;
            this.lblFrequency.Text = "FRECUENCIA";
            // 
            // lblAmplitude
            // 
            this.lblAmplitude.AutoSize = true;
            this.lblAmplitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmplitude.Location = new System.Drawing.Point(527, 259);
            this.lblAmplitude.Name = "lblAmplitude";
            this.lblAmplitude.Size = new System.Drawing.Size(98, 20);
            this.lblAmplitude.TabIndex = 4;
            this.lblAmplitude.Text = "AMPLITUD";
            // 
            // trackBarAmplittude
            // 
            this.trackBarAmplittude.Location = new System.Drawing.Point(531, 292);
            this.trackBarAmplittude.Name = "trackBarAmplittude";
            this.trackBarAmplittude.Size = new System.Drawing.Size(294, 45);
            this.trackBarAmplittude.TabIndex = 3;
            this.trackBarAmplittude.ValueChanged += new System.EventHandler(this.trackBarAmplittude_ValueChanged);
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffset.Location = new System.Drawing.Point(527, 343);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(78, 20);
            this.lblOffset.TabIndex = 6;
            this.lblOffset.Text = "OFFSET";
            // 
            // trackBarOffset
            // 
            this.trackBarOffset.Location = new System.Drawing.Point(531, 376);
            this.trackBarOffset.Name = "trackBarOffset";
            this.trackBarOffset.Size = new System.Drawing.Size(294, 45);
            this.trackBarOffset.TabIndex = 5;
            this.trackBarOffset.ValueChanged += new System.EventHandler(this.trackBarOffset_ValueChanged);
            // 
            // lblSimetry
            // 
            this.lblSimetry.AutoSize = true;
            this.lblSimetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimetry.Location = new System.Drawing.Point(527, 417);
            this.lblSimetry.Name = "lblSimetry";
            this.lblSimetry.Size = new System.Drawing.Size(188, 20);
            this.lblSimetry.TabIndex = 8;
            this.lblSimetry.Text = "CICLO DE SERVICIO ";
            // 
            // trackBarSimetry
            // 
            this.trackBarSimetry.Location = new System.Drawing.Point(531, 450);
            this.trackBarSimetry.Name = "trackBarSimetry";
            this.trackBarSimetry.Size = new System.Drawing.Size(294, 45);
            this.trackBarSimetry.TabIndex = 7;
            this.trackBarSimetry.ValueChanged += new System.EventHandler(this.trackBarSimetry_ValueChanged);
            // 
            // btnSquareSignal
            // 
            this.btnSquareSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareSignal.Location = new System.Drawing.Point(531, 45);
            this.btnSquareSignal.Name = "btnSquareSignal";
            this.btnSquareSignal.Size = new System.Drawing.Size(120, 23);
            this.btnSquareSignal.TabIndex = 9;
            this.btnSquareSignal.Text = "CUADRADA";
            this.btnSquareSignal.UseVisualStyleBackColor = true;
            this.btnSquareSignal.Click += new System.EventHandler(this.btnSquareSignal_Click);
            // 
            // btnSignalTriangular
            // 
            this.btnSignalTriangular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignalTriangular.Location = new System.Drawing.Point(531, 74);
            this.btnSignalTriangular.Name = "btnSignalTriangular";
            this.btnSignalTriangular.Size = new System.Drawing.Size(120, 23);
            this.btnSignalTriangular.TabIndex = 10;
            this.btnSignalTriangular.Text = "TRIANGULAR";
            this.btnSignalTriangular.UseVisualStyleBackColor = true;
            this.btnSignalTriangular.Click += new System.EventHandler(this.btnSignalTriangular_Click);
            // 
            // btnSignalSenoidal
            // 
            this.btnSignalSenoidal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignalSenoidal.Location = new System.Drawing.Point(531, 103);
            this.btnSignalSenoidal.Name = "btnSignalSenoidal";
            this.btnSignalSenoidal.Size = new System.Drawing.Size(120, 23);
            this.btnSignalSenoidal.TabIndex = 11;
            this.btnSignalSenoidal.Text = "SENOIDAL";
            this.btnSignalSenoidal.UseVisualStyleBackColor = true;
            this.btnSignalSenoidal.Click += new System.EventHandler(this.btnSignalSenoidal_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(707, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 39);
            this.button4.TabIndex = 12;
            this.button4.Text = "Conectar Puerto Serial";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(707, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 36);
            this.button5.TabIndex = 13;
            this.button5.Text = "Desconectar Puerto Serial";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 508);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSignalSenoidal);
            this.Controls.Add(this.btnSignalTriangular);
            this.Controls.Add(this.btnSquareSignal);
            this.Controls.Add(this.lblSimetry);
            this.Controls.Add(this.trackBarSimetry);
            this.Controls.Add(this.lblOffset);
            this.Controls.Add(this.trackBarOffset);
            this.Controls.Add(this.lblAmplitude);
            this.Controls.Add(this.trackBarAmplittude);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.trackBarFrequency);
            this.Controls.Add(this.signalsChart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.signalsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmplittude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSimetry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart signalsChart;
        private System.Windows.Forms.TrackBar trackBarFrequency;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblAmplitude;
        private System.Windows.Forms.TrackBar trackBarAmplittude;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.TrackBar trackBarOffset;
        private System.Windows.Forms.Label lblSimetry;
        private System.Windows.Forms.TrackBar trackBarSimetry;
        private System.Windows.Forms.Button btnSquareSignal;
        private System.Windows.Forms.Button btnSignalTriangular;
        private System.Windows.Forms.Button btnSignalSenoidal;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}


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
            this.components = new System.ComponentModel.Container();
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
            this.btnConnectSerial = new System.Windows.Forms.Button();
            this.btnDisconnectSerial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSerialStatus = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.buttonHertz = new System.Windows.Forms.Button();
            this.btnKiloHertz = new System.Windows.Forms.Button();
            this.btnMegaHertz = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
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
            this.signalsChart.Location = new System.Drawing.Point(-3, 359);
            this.signalsChart.Name = "signalsChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Purple;
            series1.Legend = "Legend1";
            series1.Name = "Signal";
            this.signalsChart.Series.Add(series1);
            this.signalsChart.Size = new System.Drawing.Size(928, 308);
            this.signalsChart.TabIndex = 0;
            this.signalsChart.Text = "chart1";
            // 
            // trackBarFrequency
            // 
            this.trackBarFrequency.Location = new System.Drawing.Point(531, 213);
            this.trackBarFrequency.Maximum = 1000000;
            this.trackBarFrequency.Name = "trackBarFrequency";
            this.trackBarFrequency.Size = new System.Drawing.Size(294, 45);
            this.trackBarFrequency.TabIndex = 1;
            this.trackBarFrequency.ValueChanged += new System.EventHandler(this.trackBarFrequency_ValueChanged);
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequency.ForeColor = System.Drawing.Color.Purple;
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
            this.lblAmplitude.ForeColor = System.Drawing.Color.Purple;
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
            this.lblOffset.ForeColor = System.Drawing.Color.Purple;
            this.lblOffset.Location = new System.Drawing.Point(169, 174);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(78, 20);
            this.lblOffset.TabIndex = 6;
            this.lblOffset.Text = "OFFSET";
            // 
            // trackBarOffset
            // 
            this.trackBarOffset.Location = new System.Drawing.Point(173, 207);
            this.trackBarOffset.Name = "trackBarOffset";
            this.trackBarOffset.Size = new System.Drawing.Size(294, 45);
            this.trackBarOffset.TabIndex = 5;
            this.trackBarOffset.ValueChanged += new System.EventHandler(this.trackBarOffset_ValueChanged);
            // 
            // lblSimetry
            // 
            this.lblSimetry.AutoSize = true;
            this.lblSimetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimetry.ForeColor = System.Drawing.Color.Purple;
            this.lblSimetry.Location = new System.Drawing.Point(169, 248);
            this.lblSimetry.Name = "lblSimetry";
            this.lblSimetry.Size = new System.Drawing.Size(188, 20);
            this.lblSimetry.TabIndex = 8;
            this.lblSimetry.Text = "CICLO DE SERVICIO ";
            // 
            // trackBarSimetry
            // 
            this.trackBarSimetry.Location = new System.Drawing.Point(173, 281);
            this.trackBarSimetry.Name = "trackBarSimetry";
            this.trackBarSimetry.Size = new System.Drawing.Size(294, 45);
            this.trackBarSimetry.TabIndex = 7;
            this.trackBarSimetry.ValueChanged += new System.EventHandler(this.trackBarSimetry_ValueChanged);
            // 
            // btnSquareSignal
            // 
            this.btnSquareSignal.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSquareSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareSignal.ForeColor = System.Drawing.Color.White;
            this.btnSquareSignal.Location = new System.Drawing.Point(12, 213);
            this.btnSquareSignal.Name = "btnSquareSignal";
            this.btnSquareSignal.Size = new System.Drawing.Size(120, 23);
            this.btnSquareSignal.TabIndex = 9;
            this.btnSquareSignal.Text = "CUADRADA";
            this.btnSquareSignal.UseVisualStyleBackColor = false;
            this.btnSquareSignal.Click += new System.EventHandler(this.btnSquareSignal_Click);
            // 
            // btnSignalTriangular
            // 
            this.btnSignalTriangular.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSignalTriangular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignalTriangular.ForeColor = System.Drawing.Color.White;
            this.btnSignalTriangular.Location = new System.Drawing.Point(12, 242);
            this.btnSignalTriangular.Name = "btnSignalTriangular";
            this.btnSignalTriangular.Size = new System.Drawing.Size(120, 23);
            this.btnSignalTriangular.TabIndex = 10;
            this.btnSignalTriangular.Text = "TRIANGULAR";
            this.btnSignalTriangular.UseVisualStyleBackColor = false;
            this.btnSignalTriangular.Click += new System.EventHandler(this.btnSignalTriangular_Click);
            // 
            // btnSignalSenoidal
            // 
            this.btnSignalSenoidal.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSignalSenoidal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignalSenoidal.ForeColor = System.Drawing.Color.White;
            this.btnSignalSenoidal.Location = new System.Drawing.Point(12, 274);
            this.btnSignalSenoidal.Name = "btnSignalSenoidal";
            this.btnSignalSenoidal.Size = new System.Drawing.Size(120, 23);
            this.btnSignalSenoidal.TabIndex = 11;
            this.btnSignalSenoidal.Text = "SENOIDAL";
            this.btnSignalSenoidal.UseVisualStyleBackColor = false;
            this.btnSignalSenoidal.Click += new System.EventHandler(this.btnSignalSenoidal_Click);
            // 
            // btnConnectSerial
            // 
            this.btnConnectSerial.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConnectSerial.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectSerial.ForeColor = System.Drawing.Color.White;
            this.btnConnectSerial.Location = new System.Drawing.Point(551, 24);
            this.btnConnectSerial.Name = "btnConnectSerial";
            this.btnConnectSerial.Size = new System.Drawing.Size(185, 39);
            this.btnConnectSerial.TabIndex = 12;
            this.btnConnectSerial.Text = "Conectar Serial";
            this.btnConnectSerial.UseVisualStyleBackColor = false;
            this.btnConnectSerial.Click += new System.EventHandler(this.btnConnectSerial_Click);
            // 
            // btnDisconnectSerial
            // 
            this.btnDisconnectSerial.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDisconnectSerial.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnectSerial.ForeColor = System.Drawing.Color.White;
            this.btnDisconnectSerial.Location = new System.Drawing.Point(551, 82);
            this.btnDisconnectSerial.Name = "btnDisconnectSerial";
            this.btnDisconnectSerial.Size = new System.Drawing.Size(206, 36);
            this.btnDisconnectSerial.TabIndex = 13;
            this.btnDisconnectSerial.Text = "Desconectar Serial";
            this.btnDisconnectSerial.UseVisualStyleBackColor = false;
            this.btnDisconnectSerial.Click += new System.EventHandler(this.btnDisconnectSerial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Serial:";
            // 
            // lblSerialStatus
            // 
            this.lblSerialStatus.AutoSize = true;
            this.lblSerialStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblSerialStatus.Location = new System.Drawing.Point(384, 82);
            this.lblSerialStatus.Name = "lblSerialStatus";
            this.lblSerialStatus.Size = new System.Drawing.Size(108, 16);
            this.lblSerialStatus.TabIndex = 15;
            this.lblSerialStatus.Text = "Desconectado";
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeColor.ForeColor = System.Drawing.Color.Teal;
            this.btnChangeColor.Location = new System.Drawing.Point(12, 176);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(120, 30);
            this.btnChangeColor.TabIndex = 16;
            this.btnChangeColor.Text = "Cambiar color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // buttonHertz
            // 
            this.buttonHertz.Location = new System.Drawing.Point(365, 330);
            this.buttonHertz.Name = "buttonHertz";
            this.buttonHertz.Size = new System.Drawing.Size(75, 23);
            this.buttonHertz.TabIndex = 17;
            this.buttonHertz.Text = "Hertz";
            this.buttonHertz.UseVisualStyleBackColor = true;
            this.buttonHertz.Click += new System.EventHandler(this.buttonHertz_Click);
            // 
            // btnKiloHertz
            // 
            this.btnKiloHertz.Location = new System.Drawing.Point(463, 330);
            this.btnKiloHertz.Name = "btnKiloHertz";
            this.btnKiloHertz.Size = new System.Drawing.Size(75, 23);
            this.btnKiloHertz.TabIndex = 18;
            this.btnKiloHertz.Text = "KiloHertz";
            this.btnKiloHertz.UseVisualStyleBackColor = true;
            this.btnKiloHertz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnKiloHertz_MouseClick);
            // 
            // btnMegaHertz
            // 
            this.btnMegaHertz.Location = new System.Drawing.Point(562, 330);
            this.btnMegaHertz.Name = "btnMegaHertz";
            this.btnMegaHertz.Size = new System.Drawing.Size(75, 23);
            this.btnMegaHertz.TabIndex = 19;
            this.btnMegaHertz.Text = "MegaHertz";
            this.btnMegaHertz.UseVisualStyleBackColor = true;
            this.btnMegaHertz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMegaHertz_MouseClick);
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM3";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 662);
            this.Controls.Add(this.btnMegaHertz);
            this.Controls.Add(this.btnKiloHertz);
            this.Controls.Add(this.buttonHertz);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.lblSerialStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisconnectSerial);
            this.Controls.Add(this.btnConnectSerial);
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
        private System.Windows.Forms.Button btnConnectSerial;
        private System.Windows.Forms.Button btnDisconnectSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSerialStatus;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button buttonHertz;
        private System.Windows.Forms.Button btnKiloHertz;
        private System.Windows.Forms.Button btnMegaHertz;
        private System.IO.Ports.SerialPort serialPort;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GeneradorFunciones
{
    public partial class Form1 : Form
    {

        // Enum to select the type of signal
        public enum SignalType
        {
            SQUARE,
            TRIANGULAR,
            SINUSOIDAL
        }

        private SignalType signalType;

        public Form1()
        {
            InitializeComponent();
        }

        private void InicializarGrafica()
        {
            signalsChart.Series.Clear(); // Limpiar series existentes
            Series serie = new Series("Signal");
            serie.ChartType = SeriesChartType.Line;
            serie.Color = System.Drawing.Color.Yellow;
            signalsChart.Series.Add(serie);
        }

        private void GenerarSenalCuadrada(double frecuencia, double amplitud, double offset, double cicloTrabajo)
        {
            signalsChart.Series["Signal"].Points.Clear();
            int puntos = 100; // Cantidad de puntos en la gráfica
            double periodo = puntos / frecuencia;

            for (int x = 0; x < puntos; x++)
            {
                double tiempo = x % periodo;
                double y = (tiempo < periodo * cicloTrabajo) ? amplitud : -amplitud;
                y += offset;
                signalsChart.Series["Signal"].Points.AddXY(x, y);
            }

            this.signalType = SignalType.SQUARE;
        }

        private void GenerarSenalTriangular(double frecuencia, double amplitud, double offset, double simetria)
        {
            signalsChart.Series["Signal"].Points.Clear();
            int puntos = 100;
            double periodo = puntos / frecuencia;

            for (int x = 0; x < puntos; x++)
            {
                double tiempo = x % periodo;
                double y = (tiempo < periodo * simetria) ? (2 * amplitud * tiempo / (periodo * simetria)) - amplitud :
                                                           (-2 * amplitud * (tiempo - periodo * simetria) / (periodo * (1 - simetria))) + amplitud;
                y += offset;
                signalsChart.Series["Signal"].Points.AddXY(x, y);
            }

            this.signalType = SignalType.TRIANGULAR;
        }

        private void GenerarSenalSenoidal(double frecuencia, double amplitud, double offset)
        {
            signalsChart.Series["Signal"].Points.Clear();
            int puntos = 100;
            double periodo = puntos / frecuencia;

            for (int x = 0; x < puntos; x++)
            {
                double y = amplitud * Math.Sin(2 * Math.PI * frecuencia * x / puntos) + offset;
                signalsChart.Series["Signal"].Points.AddXY(x, y);
            }

            this.signalType = SignalType.SINUSOIDAL;
        }

        private void btnSquareSignal_Click(object sender, EventArgs e)
        {
            GenerarSenalCuadrada(trackBarFrequency.Value, trackBarAmplittude.Value, trackBarOffset.Value, trackBarSimetry.Value);
        }

        private void btnSignalTriangular_Click(object sender, EventArgs e)
        {
            GenerarSenalTriangular(trackBarFrequency.Value, trackBarAmplittude.Value, trackBarOffset.Value, trackBarSimetry.Value);
        }

        private void btnSignalSenoidal_Click(object sender, EventArgs e)
        {
            GenerarSenalSenoidal(trackBarFrequency.Value, trackBarAmplittude.Value, trackBarOffset.Value);
        }

        private void trackBarFrequency_ValueChanged(object sender, EventArgs e)
        {

            lblFrequency.Text = "FRECUENCIA: " + trackBarFrequency.Value + " Hz";
            if (this.signalType == SignalType.SQUARE)
            {
                GenerarSenalCuadrada(trackBarFrequency.Value, trackBarAmplittude.Value, trackBarOffset.Value, trackBarSimetry.Value);
            }
            else if (this.signalType == SignalType.TRIANGULAR)
            {
                GenerarSenalTriangular(trackBarFrequency.Value, trackBarAmplittude.Value, trackBarOffset.Value, trackBarSimetry.Value);
            }
            else if (this.signalType == SignalType.SINUSOIDAL)
            {
                GenerarSenalSenoidal(trackBarFrequency.Value, trackBarAmplittude.Value, trackBarOffset.Value);
            }

        }

        private void trackBarAmplittude_ValueChanged(object sender, EventArgs e)
        {

            lblAmplitude.Text = "AMPLITUD: " + trackBarAmplittude.Value + " V";
            if (this.signalType == SignalType.SQUARE)
            {
                GenerarSenalCuadrada(trackBarFrequency.Value, trackBarAmplittude.Value, trackBarOffset.Value, trackBarSimetry.Value);
            }
            else if (this.signalType == SignalType.TRIANGULAR)
            {
                GenerarSenalTriangular(trackBarFrequency.Value, trackBarAmplittude.Value, trackBarOffset.Value, trackBarSimetry.Value);
            }
            else if (this.signalType == SignalType.SINUSOIDAL)
            {
                GenerarSenalSenoidal(trackBarFrequency.Value, trackBarAmplittude.Value, trackBarOffset.Value);
            }

        }

        private void trackBarOffset_ValueChanged(object sender, EventArgs e)
        {

            lblOffset.Text = "OFFSET: " + trackBarOffset.Value + " V";
            if (this.signalType == SignalType.SQUARE)
            {
                GenerarSenalCuadrada(trackBarFrequency.Value, trackBarAmplittude.Value, trackBarOffset.Value, trackBarSimetry.Value);
            }
            else if (this.signalType == SignalType.TRIANGULAR)
            {
                GenerarSenalTriangular(trackBarFrequency.Value, trackBarAmplittude.Value, trackBarOffset.Value, trackBarSimetry.Value);
            }
            else if (this.signalType == SignalType.SINUSOIDAL)
            {
                GenerarSenalSenoidal(trackBarFrequency.Value, trackBarAmplittude.Value, trackBarOffset.Value);
            }

        }

        private void trackBarSimetry_ValueChanged(object sender, EventArgs e)
        {

            lblSimetry.Text = "SIMETRÍA: " + trackBarSimetry.Value + "%";
            if (this.signalType == SignalType.SQUARE)
            {
                GenerarSenalCuadrada(trackBarFrequency.Value, trackBarAmplittude.Value, trackBarOffset.Value, trackBarSimetry.Value);
            }
            else if (this.signalType == SignalType.TRIANGULAR)
            {
                GenerarSenalTriangular(trackBarFrequency.Value, trackBarAmplittude.Value, trackBarOffset.Value, trackBarSimetry.Value);
            }
            else if (this.signalType == SignalType.SINUSOIDAL)
            {
                GenerarSenalSenoidal(trackBarFrequency.Value, trackBarAmplittude.Value, trackBarOffset.Value);
            }

        }
    }
}

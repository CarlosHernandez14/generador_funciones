using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace GeneradorFunciones
{
    public partial class Form1 : Form
    {

        // Serial port declaration
        // private SerialPort serialPort = new SerialPort("COM3", 9600);
        private bool isConnected = false;
        private FrequencyRange frequencyRange = FrequencyRange.HZ;
        private int xIndex = 0; // Para llevar la cuenta de la muestra en el eje X

        // Enum to select the type of signal
        public enum SignalType
        {
            SQUARE,
            TRIANGULAR,
            SINUSOIDAL
        }

        // Enum to select the range of the frequency
        public enum FrequencyRange
        {
            HZ,
            KHZ,
            MHZ
        }

        private SignalType signalType;

        public Form1()
        {
            InitializeComponent();
            InicializarGrafica();
        }

        private void InicializarGrafica()
        {

            // Inicializar rango de frecuencia en base a FrequencyRange
            trackBarFrequency.Minimum = 1;
            // En caso de que se seleccione MHz, se limita 1000
            if (frequencyRange == FrequencyRange.HZ)
            {
                trackBarFrequency.Maximum = 1000;
            }
            else if (frequencyRange == FrequencyRange.KHZ)
            {
                trackBarFrequency.Maximum = 1000;
            }
            else if (frequencyRange == FrequencyRange.MHZ)
            {
                trackBarFrequency.Maximum = 1000000;
            }
        }

        private void GenerarSenalCuadrada(double frecuencia, double amplitud, double offset, double cicloTrabajo)
        {
            signalsChart.Series["Signal"].Points.Clear();

            int puntos = 100;  // Cantidad de puntos en la gráfica
            double periodo = puntos / frecuencia; // Duración de un ciclo completo

            for (int x = 0; x < puntos; x++)
            {
                double tiempo = x % periodo; // Calcula en qué parte del ciclo estamos
                double y = (tiempo < periodo * (cicloTrabajo / 10.0)) ? amplitud : -amplitud; // Aplicar ciclo de trabajo
                y += offset; // Aplicar el offset

                signalsChart.Series["Signal"].Points.AddXY(x, y);
            }

            // 🔹 Ajustar escala del eje Y
            signalsChart.ChartAreas[0].AxisY.Minimum = -amplitud + offset - 1;
            signalsChart.ChartAreas[0].AxisY.Maximum = amplitud + offset + 1;

            this.signalType = SignalType.SQUARE;
        }

        private void AgregarDatoAlChart(double valor)
        {
            // Añadir punto (xIndex, valor)
            signalsChart.Series["Signal"].Points.AddXY(xIndex, valor);
            xIndex++;

            // Opcional: mantener un número limitado de puntos para no sobrecargar la gráfica
            if (signalsChart.Series["Signal"].Points.Count > 200)
            {
                signalsChart.Series["Signal"].Points.RemoveAt(0);
            }

            // Opcional: mover el eje X para que simule un desplazamiento (scroll)
            signalsChart.ChartAreas[0].AxisX.Minimum = xIndex - 200;
            signalsChart.ChartAreas[0].AxisX.Maximum = xIndex;
        }

        private void GenerarSenalTriangular(double frecuencia, double amplitud, double offset, double simetria)
        {
            signalsChart.Series["Signal"].Points.Clear();
            int puntos = 100;  // Cantidad de puntos en la gráfica
            double periodo = puntos / frecuencia; // Duración de un ciclo completo

            double simetriaEscalada = simetria / 10.0; // Ajuste del TrackBar (0 a 10 → 0.0 a 1.0)

            for (int x = 0; x < puntos; x++)
            {
                double tiempo = x % periodo;
                double y;

                if (tiempo < periodo * simetriaEscalada)
                {
                    y = (2 * amplitud * tiempo / (periodo * simetriaEscalada)) - amplitud;
                }
                else
                {
                    y = (-2 * amplitud * (tiempo - periodo * simetriaEscalada) / (periodo * (1 - simetriaEscalada))) + amplitud;
                }

                y += offset;
                signalsChart.Series["Signal"].Points.AddXY(x, y);
            }

            // 🔹 Ajustar escala del eje Y
            signalsChart.ChartAreas[0].AxisY.Minimum = -amplitud + offset - 1;
            signalsChart.ChartAreas[0].AxisY.Maximum = amplitud + offset + 1;

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

            double frecuencia = trackBarFrequency.Value; // Se toma el valor directo

            // 🔹 Conversión para mostrar Hz, kHz o MHz
            string unidad;
            double frecuenciaMostrada;

            if (frecuencia >= 1_000_000)
            {
                frecuenciaMostrada = frecuencia / 1_000_000.0;
                unidad = "MHz";
            }
            else if (frecuencia >= 1_000)
            {
                frecuenciaMostrada = frecuencia / 1_000.0;
                unidad = "kHz";
            }
            else
            {
                frecuenciaMostrada = frecuencia;
                unidad = "Hz";
            }

            lblFrequency.Text = $"FRECUENCIA: {frecuenciaMostrada:0.##} {unidad}";

            // Actualizar la señal según el tipo seleccionado
            if (this.signalType == SignalType.SQUARE)
            {
                GenerarSenalCuadrada(frecuencia, trackBarAmplittude.Value, trackBarOffset.Value, trackBarSimetry.Value);
            }
            else if (this.signalType == SignalType.TRIANGULAR)
            {
                GenerarSenalTriangular(frecuencia, trackBarAmplittude.Value, trackBarOffset.Value, trackBarSimetry.Value);
            }
            else if (this.signalType == SignalType.SINUSOIDAL)
            {
                GenerarSenalSenoidal(frecuencia, trackBarAmplittude.Value, trackBarOffset.Value);
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

            lblSimetry.Text = "SIMETRÍA: " + trackBarSimetry.Value * 10 + "%";
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

        private void btnConnectSerial_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                    isConnected = true;
                    // Set  the lbl to Connected
                    lblSerialStatus.Text = "Conectado";


                    // Limpiar la serie
                    signalsChart.Series["Signal"].Points.Clear();

                    // Reiniciar xIndex
                    xIndex = 0;

                    // Forzar que los ejes se recalculen automáticamente
                    signalsChart.ChartAreas[0].AxisX.Minimum = double.NaN;
                    signalsChart.ChartAreas[0].AxisX.Maximum = double.NaN;
                    signalsChart.ChartAreas[0].AxisY.Minimum = double.NaN;
                    signalsChart.ChartAreas[0].AxisY.Maximum = double.NaN;
                    signalsChart.ChartAreas[0].RecalculateAxesScale();


                    MessageBox.Show("Conectado al puerto serial.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void btnDisconnectSerial_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                isConnected = false;
                // Set  the lbl to Disconnected
                lblSerialStatus.Text = "Desconectado";

                // Limpiar la serie
                signalsChart.Series["Signal"].Points.Clear();

                // 🔹 Reiniciar xIndex
                xIndex = 0;

                // 🔹 Opción 1: Forzar que los ejes se recalculen automáticamente
                signalsChart.ChartAreas[0].AxisX.Minimum = double.NaN;
                signalsChart.ChartAreas[0].AxisX.Maximum = double.NaN;
                signalsChart.ChartAreas[0].AxisY.Minimum = double.NaN;
                signalsChart.ChartAreas[0].AxisY.Maximum = double.NaN;
                signalsChart.ChartAreas[0].RecalculateAxesScale();

                MessageBox.Show("Desconectado del puerto serial.");
            }
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                signalsChart.Series["Signal"].Color = colorDialog1.Color;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonHertz_Click(object sender, EventArgs e)
        {
            frequencyRange = FrequencyRange.HZ;
            InicializarGrafica();
        }

        private void btnKiloHertz_MouseClick(object sender, MouseEventArgs e)
        {
            frequencyRange = FrequencyRange.KHZ;
            InicializarGrafica();
        }

        private void btnMegaHertz_MouseClick(object sender, MouseEventArgs e)
        {
            frequencyRange = FrequencyRange.MHZ;
            InicializarGrafica();
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Lee la línea enviada desde Arduino
                string data = serialPort.ReadLine();

                // Convierte a número (puede ser double, float, etc.)
                double valor = Convert.ToDouble(data);

                // Para actualizar la UI (Chart) desde un hilo secundario,
                // debes usar 'Invoke' o 'BeginInvoke'.
                this.Invoke(new Action(() =>
                {
                    // Agrega el valor al Chart
                    AgregarDatoAlChart(valor);
                }));
            }
            catch (Exception ex)
            {
                // Manejo de errores de parseo u otros
                Console.WriteLine("Error recibiendo datos: " + ex.Message);
            }
        }
    }
}

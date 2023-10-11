using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace T3_MC_1093222 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Validar las entradas de usuario
            if (!int.TryParse(textBoxN.Text, out int n) || n <= 0)
            {
                richTextBoxResult.Text = "N debe ser un número entero mayor que 0.";
                return;
            }

            if (!int.TryParse(textBoxX.Text, out int x))
            {
                richTextBoxResult.Text = "x debe ser un número entero.";
                return;
            }

            if (!int.TryParse(textBoxA.Text, out int a))
            {
                richTextBoxResult.Text = "a debe ser un número entero.";
                return;
            }

            // Calcular las series
            double seriesA = CalculateSeriesA(n);
            double seriesB = CalculateSeriesB(n);
            double seriesC = CalculateSeriesC(x, a, n);

            // Mostrar resultados
            richTextBoxResult.Text = $"Serie A: {seriesA}\nSerie B: {seriesB}\nSerie C: {seriesC}";
        }

        private double CalculateSeriesA(int n)
        {
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += 1.0 / i;
            }
            return result;
        }

        private double CalculateSeriesB(int n)
        {
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += 1.0 / Math.Pow(2, i);
            }
            return result;
        }

        private double CalculateSeriesC(int x, int a, int n)
        {
            double result = 0;
            for (int k = 0; k <= n; k++)
            {
                result += (x * Math.Pow(a, n - k)) / n;
            }
            return result;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

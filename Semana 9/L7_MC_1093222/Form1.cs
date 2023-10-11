namespace L7_MC_1093222_
{
    public partial class Form1 : Form
    {
        private int n;
        private object Label3;

        public object TextBox1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                try
                {
                    int n = int.Parse(TextBox1.Text);

                    if (n <= 0)
                    {
                        MessageBox.Show("El número debe ser mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Label3.Text = "Serie de Fibonacci:";
                        string fibonacciSeries = CalculateFibonacciSeries(n);
                        Label2.Text = fibonacciSeries;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Entrada inválida. Ingrese un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private string CalculateFibonacciSeries(int n)
            {
                int a = 0;
                int b = 1;
                string series = a.ToString() + ", " + b.ToString();

                while (n > 2)
                {
                    int next = a + b;
                    series += ", " + next.ToString();
                    a = b;
                    b = next;
                    n--;
                }

                return series;
            }

        }
    }

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double RecursivePower(double x, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return x;
            return x * RecursivePower(x, n - 1);
        }

        private void btnCalculatedPower_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBase.Text, out double x) &&
             int.TryParse(txtExponent.Text, out int n) && n >= 0)
            {
                double result = RecursivePower(x, n);
                lblPowerResult.Text = $"{x}^{n} = {result}";
            }
            else
            {
                MessageBox.Show("Invalid input. Base must be a number, exponent ≥ 0");
            }
        }
    }
}

namespace Task5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] bubbleSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Swap numbers[j] and numbers[j+1]
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4, 9, 8, 7, 0 };
            listBoxResults.DataSource = numbers.ToList();
            Application.DoEvents();
            System.Threading.Thread.Sleep(2000);
            int[] sortedNumbers = bubbleSort(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }
    }
}

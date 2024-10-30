namespace DZTask2Forms
{
    public partial class FrmTasks : Form
    {
        public FrmTasks()
        {
            InitializeComponent();
            clearLbls();


        }

        private void clearLbls()
        {
            lblResult.Text = string.Empty;
            lblFactResult.Text = string.Empty;
            lblArraySum.Text = string.Empty;
            lblSumA.Text = string.Empty;
            lblSortedArray.Text = string.Empty;
            lblUnsortedArray.Text = string.Empty;
        }
        private string CalculateSeries(double x, double precision)
        {
            double sum = x;
            double term = x;
            int n = 1;

            while (true)
            {
                double nextTerm = x / (n + 1);
                if (Math.Abs(nextTerm - term) < precision)
                {
                    break;
                }
                sum += nextTerm;
                term = nextTerm;
                n++;

            }

            return $"sum = {sum}, num of steps = {n}";
        }

        private string CalculateFactorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers");

            else if (n == 0 || n == 1)
                return "1";
            else
            {
                long result = 1;
                for (int i = 2; i <= n; i++)
                    result *= i;

                return $"!{n} = {result}";
            }
        }



        private void btnCalcSum_Click(object sender, EventArgs e)
        {
            clearLbls();

            double x;
            double precision;

            if (Double.TryParse(tbX.Text, out x) &&
                Double.TryParse(tbPrecision.Text, out precision))
                lblResult.Text = CalculateSeries(x, precision);
            else
                MessageBox.Show("Некорректные данные");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearLbls();

            int num;
            if (int.TryParse(tbFact.Text, out num))
                lblFactResult.Text = CalculateFactorial(num);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clearLbls();

            string text = tbArray.Text;
            string[] numbers = text.Split(' ');
            int[] array = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!int.TryParse(numbers[i], out array[i]))
                    return;
            }

            lblArraySum.Text = $"Сумма массива = {array.Sum()}";

        }

        private void btnParseString_Click(object sender, EventArgs e)
        {
            clearLbls();

            int countA = tbStringToParse.Text.Count(c => c == 'а');
            lblSumA.Text = $"Букв а в строке {countA}";
        }

        public int[] Array;
        private void btnGenArray_Click(object sender, EventArgs e)
        {
            clearLbls();
            Array = null;

            int count;
            int max;
            int min;

            if (int.TryParse(tbCount.Text, out count) &&
                int.TryParse(tbMax.Text, out max) &&
                int.TryParse(tbMin.Text, out min))
            {
                Random random = new Random();
                Array = new int[count];

                for (int i = 0; i < count; i++)
                {
                    Array[i] = random.Next(min, max + 1);
                }

            }
            else
                MessageBox.Show("Некорректные данные");

            foreach (int num in Array)
                lblUnsortedArray.Text += num + " ";

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (Array == null)
                return;
            System.Array.Sort(Array);
            foreach (int num in Array)
                lblSortedArray.Text += num + " ";


        }
    }
}

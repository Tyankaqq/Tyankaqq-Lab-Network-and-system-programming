namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            lstFibonacci.Items.Clear();
            lblStatus.Text = "�����������...";

            if (int.TryParse(txtLimit.Text, out int limit) && limit >= 0)
            {
                var fibonacciNumbers = await Task.Run(() => CalculateFibonacci(limit));
                foreach (var number in fibonacciNumbers)
                {
                    lstFibonacci.Items.Add(number);
                }
                lblStatus.Text = "������!";
            }
            else
            {
                MessageBox.Show("����������, ������� ���������� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "������!";
            }
        }

        private List<int> CalculateFibonacci(int limit)
        {
            List<int> numbers = new List<int>();
            int a = 0, b = 1;

            while (a <= limit)
            {
                numbers.Add(a);
                int next = a + b;
                a = b;
                b = next;
            }

            return numbers;
        }
    }
}

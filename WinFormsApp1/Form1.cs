namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double result;
        int option;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double num_1 = double.Parse(Num1.Text);
            double num_2 = double.Parse(Num2.Text);
            switch (comboSelect.SelectedIndex)
            {
                case 0:
                    result = num_1 + num_2;
                    break;
                case 1:
                    result = num_1 - num_2;
                    break;
                case 2:
                    result = num_1 / num_2;
                    break;
                case 3:
                    result = num_1 * num_2; 
                    break;
            }
            result = Math.Round(result,2);
            NumR.Text = result.ToString();
        }
    }
}

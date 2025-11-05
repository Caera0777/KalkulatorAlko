using System;
using System.Windows.Forms;

namespace kalkulatorAlko
{
    public partial class Form1 : Form
    {
        private Calculator calculator = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double capacity = double.Parse(textBoxCapacity.Text);
                double percentage = double.Parse(textBoxPercentage.Text);
                int quantity = int.Parse(textBoxQuantity.Text);

                double totalVolume = calculator.CalculateTotalVolume(capacity, quantity);
                double pureSubstance = calculator.CalculatePureSubstance(capacity, percentage, quantity);

                labelResultVolume.Text = $"{totalVolume:F2} ml";
                labelResultSubstance.Text = $"{pureSubstance:F2} ml";
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadź poprawne dane liczbowe!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}}

namespace kalkulatorAlko
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.TextBox textBoxPercentage;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelTotalVolume;
        private System.Windows.Forms.Label labelPureSubstance;
        private System.Windows.Forms.Label labelResultVolume;
        private System.Windows.Forms.Label labelResultSubstance;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.textBoxPercentage = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelTotalVolume = new System.Windows.Forms.Label();
            this.labelPureSubstance = new System.Windows.Forms.Label();
            this.labelResultVolume = new System.Windows.Forms.Label();
            this.labelResultSubstance = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // labelCapacity
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(30, 30);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(120, 20);
            this.labelCapacity.Text = "Pojemność (ml):";

            // textBoxCapacity
            this.textBoxCapacity.Location = new System.Drawing.Point(180, 27);
            this.textBoxCapacity.Size = new System.Drawing.Size(150, 26);

            // labelPercentage
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.Location = new System.Drawing.Point(30, 70);
            this.labelPercentage.Text = "Zawartość (%):";

            // textBoxPercentage
            this.textBoxPercentage.Location = new System.Drawing.Point(180, 67);
            this.textBoxPercentage.Size = new System.Drawing.Size(150, 26);

            // labelQuantity
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(30, 110);
            this.labelQuantity.Text = "Liczba naczyń:";

            // textBoxQuantity
            this.textBoxQuantity.Location = new System.Drawing.Point(180, 107);
            this.textBoxQuantity.Size = new System.Drawing.Size(150, 26);

            // buttonCalculate
            this.buttonCalculate.Location = new System.Drawing.Point(100, 160);
            this.buttonCalculate.Size = new System.Drawing.Size(180, 40);
            this.buttonCalculate.Text = "Oblicz";
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);

            // labelTotalVolume
            this.labelTotalVolume.AutoSize = true;
            this.labelTotalVolume.Location = new System.Drawing.Point(30, 220);
            this.labelTotalVolume.Text = "Łączna objętość:";

            // labelResultVolume
            this.labelResultVolume.AutoSize = true;
            this.labelResultVolume.Location = new System.Drawing.Point(180, 220);
            this.labelResultVolume.Text = "---";

            // labelPureSubstance
            this.labelPureSubstance.AutoSize = true;
            this.labelPureSubstance.Location = new System.Drawing.Point(30, 250);
            this.labelPureSubstance.Text = "Czysta substancja:";

            // labelResultSubstance
            this.labelResultSubstance.AutoSize = true;
            this.labelResultSubstance.Location = new System.Drawing.Point(180, 250);
            this.labelResultSubstance.Text = "---";

            // Form1
            this.ClientSize = new System.Drawing.Size(380, 320);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.textBoxPercentage);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelTotalVolume);
            this.Controls.Add(this.labelResultVolume);
            this.Controls.Add(this.labelPureSubstance);
            this.Controls.Add(this.labelResultSubstance);
            this.Text = "Kalkulator Alko";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLiczbaA = new System.Windows.Forms.Label();
            this.labelLiczbaB = new System.Windows.Forms.Label();
            this.comboBoxOperacja = new System.Windows.Forms.ComboBox();
            this.textBoxLiczbaA = new System.Windows.Forms.TextBox();
            this.textBoxLiczbaB = new System.Windows.Forms.TextBox();
            this.labelWynik = new System.Windows.Forms.Label();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLiczbaA
            // 
            this.labelLiczbaA.AutoSize = true;
            this.labelLiczbaA.Location = new System.Drawing.Point(55, 50);
            this.labelLiczbaA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLiczbaA.Name = "labelLiczbaA";
            this.labelLiczbaA.Size = new System.Drawing.Size(61, 17);
            this.labelLiczbaA.TabIndex = 0;
            this.labelLiczbaA.Text = "liczba A:";
            // 
            // labelLiczbaB
            // 
            this.labelLiczbaB.AutoSize = true;
            this.labelLiczbaB.Location = new System.Drawing.Point(297, 50);
            this.labelLiczbaB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLiczbaB.Name = "labelLiczbaB";
            this.labelLiczbaB.Size = new System.Drawing.Size(61, 17);
            this.labelLiczbaB.TabIndex = 1;
            this.labelLiczbaB.Text = "liczba B:";
            // 
            // comboBoxOperacja
            // 
            this.comboBoxOperacja.FormattingEnabled = true;
            this.comboBoxOperacja.Items.AddRange(new object[] {
            "dodawanie",
            "odejmowanie",
            "mnożenie ",
            "dzielenie"});
            this.comboBoxOperacja.Location = new System.Drawing.Point(129, 70);
            this.comboBoxOperacja.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOperacja.Name = "comboBoxOperacja";
            this.comboBoxOperacja.Size = new System.Drawing.Size(160, 24);
            this.comboBoxOperacja.TabIndex = 2;
            this.comboBoxOperacja.Text = "Operacja";
            // 
            // textBoxLiczbaA
            // 
            this.textBoxLiczbaA.Location = new System.Drawing.Point(59, 70);
            this.textBoxLiczbaA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLiczbaA.Name = "textBoxLiczbaA";
            this.textBoxLiczbaA.Size = new System.Drawing.Size(57, 22);
            this.textBoxLiczbaA.TabIndex = 3;
            // 
            // textBoxLiczbaB
            // 
            this.textBoxLiczbaB.Location = new System.Drawing.Point(299, 70);
            this.textBoxLiczbaB.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLiczbaB.Name = "textBoxLiczbaB";
            this.textBoxLiczbaB.Size = new System.Drawing.Size(57, 22);
            this.textBoxLiczbaB.TabIndex = 4;
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Location = new System.Drawing.Point(365, 74);
            this.labelWynik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(16, 17);
            this.labelWynik.TabIndex = 5;
            this.labelWynik.Text = "=";
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Location = new System.Drawing.Point(156, 122);
            this.buttonOblicz.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.Size = new System.Drawing.Size(100, 28);
            this.buttonOblicz.TabIndex = 6;
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 549);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.textBoxLiczbaB);
            this.Controls.Add(this.textBoxLiczbaA);
            this.Controls.Add(this.comboBoxOperacja);
            this.Controls.Add(this.labelLiczbaB);
            this.Controls.Add(this.labelLiczbaA);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLiczbaA;
        private System.Windows.Forms.Label labelLiczbaB;
        private System.Windows.Forms.ComboBox comboBoxOperacja;
        private System.Windows.Forms.TextBox textBoxLiczbaA;
        private System.Windows.Forms.TextBox textBoxLiczbaB;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.Button buttonOblicz;
    }
}


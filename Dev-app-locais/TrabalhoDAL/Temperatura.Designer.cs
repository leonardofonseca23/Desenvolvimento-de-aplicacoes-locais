namespace TrabalhoDAL
{
    partial class Temperatura
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
            btnConverter = new Button();
            label1 = new Label();
            rbK = new RadioButton();
            rbF = new RadioButton();
            txtTemperatura = new TextBox();
            SuspendLayout();
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(81, 145);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 0;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 73);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Temperatura em °C";
            // 
            // rbK
            // 
            rbK.AutoSize = true;
            rbK.Location = new Point(151, 120);
            rbK.Name = "rbK";
            rbK.Size = new Size(57, 19);
            rbK.TabIndex = 2;
            rbK.Text = "Kelvin";
            rbK.UseVisualStyleBackColor = true;
            // 
            // rbF
            // 
            rbF.AutoSize = true;
            rbF.Checked = true;
            rbF.Location = new Point(37, 120);
            rbF.Name = "rbF";
            rbF.Size = new Size(81, 19);
            rbF.TabIndex = 3;
            rbF.TabStop = true;
            rbF.Text = "Fahrenheit";
            rbF.UseVisualStyleBackColor = true;
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(71, 91);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(100, 23);
            txtTemperatura.TabIndex = 4;
            // 
            // Temperatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 251);
            Controls.Add(txtTemperatura);
            Controls.Add(rbF);
            Controls.Add(rbK);
            Controls.Add(label1);
            Controls.Add(btnConverter);
            Name = "Temperatura";
            Text = "Temperatura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConverter;
        private Label label1;
        private RadioButton rbK;
        private RadioButton rbF;
        private TextBox txtTemperatura;
    }
}
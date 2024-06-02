namespace TrabalhoDAL
{
    partial class Idade
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
            dtpIdade = new DateTimePicker();
            btnIdade = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // dtpIdade
            // 
            dtpIdade.Location = new Point(21, 110);
            dtpIdade.Name = "dtpIdade";
            dtpIdade.Size = new Size(200, 23);
            dtpIdade.TabIndex = 0;
            dtpIdade.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnIdade
            // 
            btnIdade.Location = new Point(82, 139);
            btnIdade.Name = "btnIdade";
            btnIdade.Size = new Size(75, 23);
            btnIdade.TabIndex = 1;
            btnIdade.Text = "Confirmar";
            btnIdade.UseVisualStyleBackColor = true;
            btnIdade.Click += btnIdade_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 92);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 2;
            label1.Text = "Digite sua data de aniversário:";
            // 
            // Idade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 251);
            Controls.Add(label1);
            Controls.Add(btnIdade);
            Controls.Add(dtpIdade);
            Name = "Idade";
            Text = "Idade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpIdade;
        private Button btnIdade;
        private Label label1;
    }
}
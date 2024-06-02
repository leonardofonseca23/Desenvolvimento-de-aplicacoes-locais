namespace TrabalhoDAL
{
    partial class Tempo
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
            btnTempo = new Button();
            label1 = new Label();
            txtTempo = new TextBox();
            SuspendLayout();
            // 
            // btnTempo
            // 
            btnTempo.Location = new Point(82, 143);
            btnTempo.Name = "btnTempo";
            btnTempo.Size = new Size(75, 23);
            btnTempo.TabIndex = 0;
            btnTempo.Text = "Confirmar";
            btnTempo.UseVisualStyleBackColor = true;
            btnTempo.Click += btnTempo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 96);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "Digite os segundos:";
            label1.Click += label1_Click;
            // 
            // txtTempo
            // 
            txtTempo.Location = new Point(70, 114);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(100, 23);
            txtTempo.TabIndex = 2;
            txtTempo.TextChanged += textBox1_TextChanged;
            // 
            // Tempo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 251);
            Controls.Add(txtTempo);
            Controls.Add(label1);
            Controls.Add(btnTempo);
            Name = "Tempo";
            Text = "Tempo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTempo;
        private Label label1;
        private TextBox txtTempo;
    }
}
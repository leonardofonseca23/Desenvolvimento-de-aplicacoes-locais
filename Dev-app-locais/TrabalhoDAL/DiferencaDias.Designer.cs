namespace TrabalhoDAL;

partial class DiferencaDias
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
        dtp1 = new DateTimePicker();
        dtp2 = new DateTimePicker();
        btnConfirmar = new Button();
        label1 = new Label();
        SuspendLayout();
        // 
        // dtp1
        // 
        dtp1.Location = new Point(22, 94);
        dtp1.Name = "dtp1";
        dtp1.Size = new Size(200, 23);
        dtp1.TabIndex = 0;
        // 
        // dtp2
        // 
        dtp2.Location = new Point(22, 141);
        dtp2.Name = "dtp2";
        dtp2.Size = new Size(200, 23);
        dtp2.TabIndex = 1;
        // 
        // btnConfirmar
        // 
        btnConfirmar.Location = new Point(79, 170);
        btnConfirmar.Name = "btnConfirmar";
        btnConfirmar.Size = new Size(75, 23);
        btnConfirmar.TabIndex = 2;
        btnConfirmar.Text = "Confirmar";
        btnConfirmar.UseVisualStyleBackColor = true;
        btnConfirmar.Click += btnConfirmar_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(52, 44);
        label1.Name = "label1";
        label1.Size = new Size(139, 30);
        label1.TabIndex = 3;
        label1.Text = "Coloque as datas para \r\nsaber a diferença de dias.";
        // 
        // DiferencaDias
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(244, 251);
        Controls.Add(label1);
        Controls.Add(btnConfirmar);
        Controls.Add(dtp2);
        Controls.Add(dtp1);
        Name = "DiferencaDias";
        Text = "DiferencaDias";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DateTimePicker dtp1;
    private DateTimePicker dtp2;
    private Button btnConfirmar;
    private Label label1;
}
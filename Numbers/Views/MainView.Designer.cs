namespace Numbers.Views;

partial class MainView
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        txtNumber = new AntdUI.Input();
        label1 = new AntdUI.Label();
        label2 = new AntdUI.Label();
        CheckStatus = new AntdUI.Label();
        SuspendLayout();
        // 
        // txtNumber
        // 
        txtNumber.Location = new System.Drawing.Point(57, 76);
        txtNumber.Name = "txtNumber";
        txtNumber.Size = new System.Drawing.Size(528, 44);
        txtNumber.TabIndex = 0;
        txtNumber.Text = "input1";
        txtNumber.TextChanged += input_TextChanged;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(66, 34);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(142, 36);
        label1.TabIndex = 1;
        label1.Text = "label1";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(66, 142);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(518, 43);
        label2.TabIndex = 2;
        label2.Text = "label2";
        // 
        // CheckStatus
        // 
        CheckStatus.Location = new System.Drawing.Point(66, 191);
        CheckStatus.Name = "CheckStatus";
        CheckStatus.Size = new System.Drawing.Size(518, 43);
        CheckStatus.TabIndex = 3;
        CheckStatus.Text = "label3";
        // 
        // MainView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(CheckStatus);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtNumber);
        Text = "Numbers";
        ResumeLayout(false);
    }

    private AntdUI.Input txtNumber;
    private AntdUI.Label label1;
    private AntdUI.Label label2;
    private AntdUI.Label CheckStatus;

    #endregion
}
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
        inputLabel = new AntdUI.Label();
        statusLabel = new AntdUI.Label();
        CheckStatus = new AntdUI.Label();
        SuspendLayout();
        // 
        // txtNumber
        // 
        txtNumber.AllowClear = true;
        txtNumber.Font = new Font("Segoe UI", 11F);
        txtNumber.Location = new Point(60, 120);
        txtNumber.Name = "txtNumber";
        txtNumber.PlaceholderText = "Ví dụ: 12345";
        txtNumber.Radius = 8;
        txtNumber.Size = new Size(680, 44);
        txtNumber.TabIndex = 1;
        txtNumber.TextChanged += input_TextChanged;
        // 
        // inputLabel
        // 
        inputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        inputLabel.ForeColor = Color.FromArgb(38, 38, 38);
        inputLabel.Location = new Point(60, 80);
        inputLabel.Name = "inputLabel";
        inputLabel.Size = new Size(680, 32);
        inputLabel.TabIndex = 0;
        inputLabel.Text = "Nhập số:";
        // 
        // statusLabel
        // 
        statusLabel.Font = new Font("Segoe UI", 10F);
        statusLabel.ForeColor = Color.FromArgb(140, 140, 140);
        statusLabel.Location = new Point(60, 200);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(680, 32);
        statusLabel.TabIndex = 2;
        statusLabel.Text = "Kết quả kiểm tra:";
        // 
        // CheckStatus
        // 
        CheckStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        CheckStatus.ForeColor = Color.FromArgb(38, 38, 38);
        CheckStatus.Location = new Point(60, 236);
        CheckStatus.Name = "CheckStatus";
        CheckStatus.Size = new Size(680, 44);
        CheckStatus.TabIndex = 3;
        // 
        // MainView
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(800, 450);
        Controls.Add(CheckStatus);
        Controls.Add(statusLabel);
        Controls.Add(inputLabel);
        Controls.Add(txtNumber);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainView";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Numbers";
        ResumeLayout(false);
    }

    private AntdUI.Input txtNumber;
    private AntdUI.Label inputLabel;
    private AntdUI.Label statusLabel;
    private AntdUI.Label CheckStatus;

    #endregion
}
namespace SimpleParser.WinFormsApp
{
  partial class MainForm
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
      this.input = new System.Windows.Forms.TextBox();
      this.runButton = new System.Windows.Forms.Button();
      this.variables = new System.Windows.Forms.ListView();
      this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
      this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.errors = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // input
      // 
      this.input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.input.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.input.Location = new System.Drawing.Point(12, 47);
      this.input.Multiline = true;
      this.input.Name = "input";
      this.input.Size = new System.Drawing.Size(492, 235);
      this.input.TabIndex = 0;
      this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
      // 
      // runButton
      // 
      this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.runButton.Location = new System.Drawing.Point(690, 402);
      this.runButton.Name = "runButton";
      this.runButton.Size = new System.Drawing.Size(75, 23);
      this.runButton.TabIndex = 1;
      this.runButton.Text = "Execute";
      this.runButton.UseVisualStyleBackColor = true;
      this.runButton.Click += new System.EventHandler(this.runButton_Click);
      // 
      // variables
      // 
      this.variables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.variables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
      this.variables.Location = new System.Drawing.Point(510, 47);
      this.variables.Name = "variables";
      this.variables.Size = new System.Drawing.Size(255, 235);
      this.variables.TabIndex = 2;
      this.variables.UseCompatibleStateImageBehavior = false;
      this.variables.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Name";
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Value";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 26);
      this.label1.TabIndex = 3;
      this.label1.Text = "Program";
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(505, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(112, 26);
      this.label2.TabIndex = 4;
      this.label2.Text = "Variables";
      // 
      // errors
      // 
      this.errors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.errors.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.errors.Location = new System.Drawing.Point(12, 324);
      this.errors.Multiline = true;
      this.errors.Name = "errors";
      this.errors.ReadOnly = true;
      this.errors.Size = new System.Drawing.Size(672, 101);
      this.errors.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(12, 292);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(119, 26);
      this.label3.TabIndex = 6;
      this.label3.Text = "Messages";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(779, 437);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.errors);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.variables);
      this.Controls.Add(this.runButton);
      this.Controls.Add(this.input);
      this.Name = "MainForm";
      this.Text = "Simple statement evaluator";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox input;
    private System.Windows.Forms.Button runButton;
    private System.Windows.Forms.ListView variables;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox errors;
    private System.Windows.Forms.Label label3;
  }
}
namespace WindowsFormsApp
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Options = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IrresponsiveFormPanel = new System.Windows.Forms.Panel();
            this.Button = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.IrresponsiveFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Options
            // 
            this.Options.FormattingEnabled = true;
            this.Options.Items.AddRange(new object[] {
            "Irresponsive Form Example",
            "Responsive Form Example 1",
            "Responsive Form Example 2"});
            this.Options.Location = new System.Drawing.Point(12, 12);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(121, 23);
            this.Options.TabIndex = 0;
            this.Options.SelectedIndexChanged += new System.EventHandler(this.Options_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IrresponsiveFormPanel);
            this.panel1.Location = new System.Drawing.Point(13, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 396);
            this.panel1.TabIndex = 1;
            // 
            // IrresponsiveFormPanel
            // 
            this.IrresponsiveFormPanel.Controls.Add(this.Button);
            this.IrresponsiveFormPanel.Controls.Add(this.Result);
            this.IrresponsiveFormPanel.Controls.Add(this.Information);
            this.IrresponsiveFormPanel.Location = new System.Drawing.Point(13, 24);
            this.IrresponsiveFormPanel.Name = "IrresponsiveFormPanel";
            this.IrresponsiveFormPanel.Size = new System.Drawing.Size(762, 321);
            this.IrresponsiveFormPanel.TabIndex = 0;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(298, 130);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(91, 23);
            this.Button.TabIndex = 1;
            this.Button.Text = "Click Me!";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Irresponsive_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(20, 240);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(39, 15);
            this.Result.TabIndex = 0;
            this.Result.Text = "Result";
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Location = new System.Drawing.Point(20, 37);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(70, 15);
            this.Information.TabIndex = 0;
            this.Information.Text = "Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Options);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.IrresponsiveFormPanel.ResumeLayout(false);
            this.IrresponsiveFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Options;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel IrresponsiveFormPanel;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Button Button;
    }
}


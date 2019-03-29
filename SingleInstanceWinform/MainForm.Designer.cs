namespace SingleInstanceWinform
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
            this.LaunchWithArg = new System.Windows.Forms.Button();
            this.LaunchNoArg = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.ArgBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LaunchWithArg
            // 
            this.LaunchWithArg.Location = new System.Drawing.Point(12, 12);
            this.LaunchWithArg.Name = "LaunchWithArg";
            this.LaunchWithArg.Size = new System.Drawing.Size(160, 23);
            this.LaunchWithArg.TabIndex = 0;
            this.LaunchWithArg.Text = "Launch With Args";
            this.LaunchWithArg.UseVisualStyleBackColor = true;
            this.LaunchWithArg.Click += new System.EventHandler(this.LaunchWithArg_Click);
            // 
            // LaunchNoArg
            // 
            this.LaunchNoArg.Location = new System.Drawing.Point(12, 41);
            this.LaunchNoArg.Name = "LaunchNoArg";
            this.LaunchNoArg.Size = new System.Drawing.Size(160, 23);
            this.LaunchNoArg.TabIndex = 1;
            this.LaunchNoArg.Text = "Launch Without Args";
            this.LaunchNoArg.UseVisualStyleBackColor = true;
            this.LaunchNoArg.Click += new System.EventHandler(this.LaunchNoArg_Click);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(12, 70);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(381, 277);
            this.LogBox.TabIndex = 2;
            // 
            // ArgBox
            // 
            this.ArgBox.Location = new System.Drawing.Point(178, 14);
            this.ArgBox.Name = "ArgBox";
            this.ArgBox.Size = new System.Drawing.Size(172, 20);
            this.ArgBox.TabIndex = 3;
            this.ArgBox.Text = "\"test arg 1\" arg2 arg3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Copy EXE path to Paste in CMD:";
            // 
            // CmdBox
            // 
            this.CmdBox.Location = new System.Drawing.Point(177, 353);
            this.CmdBox.Name = "CmdBox";
            this.CmdBox.ReadOnly = true;
            this.CmdBox.Size = new System.Drawing.Size(216, 20);
            this.CmdBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 385);
            this.Controls.Add(this.CmdBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArgBox);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.LaunchNoArg);
            this.Controls.Add(this.LaunchWithArg);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LaunchWithArg;
        private System.Windows.Forms.Button LaunchNoArg;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.TextBox ArgBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CmdBox;
    }
}


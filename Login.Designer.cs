namespace midterm2
{
    partial class Login
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
            this.Logintxt = new System.Windows.Forms.Label();
            this.CustomerNumbertxt = new System.Windows.Forms.Label();
            this.Pintxt = new System.Windows.Forms.Label();
            this.CustomerNumbertxb = new System.Windows.Forms.TextBox();
            this.Pintxb = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logintxt
            // 
            this.Logintxt.AutoSize = true;
            this.Logintxt.Location = new System.Drawing.Point(342, 124);
            this.Logintxt.Name = "Logintxt";
            this.Logintxt.Size = new System.Drawing.Size(52, 20);
            this.Logintxt.TabIndex = 0;
            this.Logintxt.Text = "Login:";
            // 
            // CustomerNumbertxt
            // 
            this.CustomerNumbertxt.AutoSize = true;
            this.CustomerNumbertxt.Location = new System.Drawing.Point(226, 167);
            this.CustomerNumbertxt.Name = "CustomerNumbertxt";
            this.CustomerNumbertxt.Size = new System.Drawing.Size(112, 20);
            this.CustomerNumbertxt.TabIndex = 1;
            this.CustomerNumbertxt.Text = "Login Number:";
            // 
            // Pintxt
            // 
            this.Pintxt.AutoSize = true;
            this.Pintxt.Location = new System.Drawing.Point(303, 209);
            this.Pintxt.Name = "Pintxt";
            this.Pintxt.Size = new System.Drawing.Size(35, 20);
            this.Pintxt.TabIndex = 2;
            this.Pintxt.Text = "Pin:";
            // 
            // CustomerNumbertxb
            // 
            this.CustomerNumbertxb.Location = new System.Drawing.Point(344, 164);
            this.CustomerNumbertxb.Name = "CustomerNumbertxb";
            this.CustomerNumbertxb.Size = new System.Drawing.Size(100, 26);
            this.CustomerNumbertxb.TabIndex = 3;
            // 
            // Pintxb
            // 
            this.Pintxb.Location = new System.Drawing.Point(344, 206);
            this.Pintxb.Name = "Pintxb";
            this.Pintxb.Size = new System.Drawing.Size(100, 26);
            this.Pintxb.TabIndex = 4;
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(346, 238);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 32);
            this.Loginbtn.TabIndex = 5;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Pintxb);
            this.Controls.Add(this.CustomerNumbertxb);
            this.Controls.Add(this.Pintxt);
            this.Controls.Add(this.CustomerNumbertxt);
            this.Controls.Add(this.Logintxt);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Logintxt;
        private System.Windows.Forms.Label CustomerNumbertxt;
        private System.Windows.Forms.Label Pintxt;
        private System.Windows.Forms.TextBox CustomerNumbertxb;
        private System.Windows.Forms.TextBox Pintxb;
        private System.Windows.Forms.Button Loginbtn;
    }
}


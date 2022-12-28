namespace DBProject
{
    partial class MainMenu
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
            this.Register = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Register.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.Register, true);
            this.Register.Location = new System.Drawing.Point(3, 3);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(800, 55);
            this.Register.TabIndex = 0;
            this.Register.Text = "Register - Customer";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Register);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 429);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.button1, true);
            this.button1.Location = new System.Drawing.Point(3, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Join Us - Shop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.button2, true);
            this.button2.Location = new System.Drawing.Point(3, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(800, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Shop - Provide Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.button3, true);
            this.button3.Location = new System.Drawing.Point(3, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(800, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "Customer - Purchase";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.button4, true);
            this.button4.Location = new System.Drawing.Point(3, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(800, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "View All Customer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.button5, true);
            this.button5.Location = new System.Drawing.Point(3, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(800, 55);
            this.button5.TabIndex = 5;
            this.button5.Text = "View All Shops";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.button6, true);
            this.button6.Location = new System.Drawing.Point(3, 369);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(800, 55);
            this.button6.TabIndex = 6;
            this.button6.Text = "View All Items";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Register;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
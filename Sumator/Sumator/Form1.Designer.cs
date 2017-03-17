namespace Sumator
{
    partial class Form1
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
            this.in1 = new System.Windows.Forms.TextBox();
            this.in2 = new System.Windows.Forms.TextBox();
            this.out1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.out2 = new System.Windows.Forms.TextBox();
            this.in22 = new System.Windows.Forms.TextBox();
            this.in21 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // in1
            // 
            this.in1.Location = new System.Drawing.Point(133, 23);
            this.in1.Margin = new System.Windows.Forms.Padding(5);
            this.in1.MaxLength = 4;
            this.in1.Name = "in1";
            this.in1.Size = new System.Drawing.Size(81, 26);
            this.in1.TabIndex = 0;
            this.in1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.in1.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // in2
            // 
            this.in2.Location = new System.Drawing.Point(133, 63);
            this.in2.Margin = new System.Windows.Forms.Padding(5);
            this.in2.MaxLength = 4;
            this.in2.Name = "in2";
            this.in2.Size = new System.Drawing.Size(81, 26);
            this.in2.TabIndex = 1;
            this.in2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.in2.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // out1
            // 
            this.out1.Location = new System.Drawing.Point(133, 129);
            this.out1.Margin = new System.Windows.Forms.Padding(5);
            this.out1.Name = "out1";
            this.out1.ReadOnly = true;
            this.out1.Size = new System.Drawing.Size(81, 26);
            this.out1.TabIndex = 2;
            this.out1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 194);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output";
            // 
            // out2
            // 
            this.out2.Location = new System.Drawing.Point(224, 129);
            this.out2.Margin = new System.Windows.Forms.Padding(5);
            this.out2.Name = "out2";
            this.out2.ReadOnly = true;
            this.out2.Size = new System.Drawing.Size(81, 26);
            this.out2.TabIndex = 9;
            this.out2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // in22
            // 
            this.in22.Location = new System.Drawing.Point(224, 63);
            this.in22.Margin = new System.Windows.Forms.Padding(5);
            this.in22.MaxLength = 2;
            this.in22.Name = "in22";
            this.in22.Size = new System.Drawing.Size(81, 26);
            this.in22.TabIndex = 8;
            this.in22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.in22.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // in21
            // 
            this.in21.Location = new System.Drawing.Point(224, 23);
            this.in21.Margin = new System.Windows.Forms.Padding(5);
            this.in21.MaxLength = 2;
            this.in21.Name = "in21";
            this.in21.Size = new System.Drawing.Size(81, 26);
            this.in21.TabIndex = 7;
            this.in21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.in21.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 254);
            this.Controls.Add(this.out2);
            this.Controls.Add(this.in22);
            this.Controls.Add(this.in21);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.out1);
            this.Controls.Add(this.in2);
            this.Controls.Add(this.in1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox in1;
        private System.Windows.Forms.TextBox in2;
        private System.Windows.Forms.TextBox out1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox out2;
        private System.Windows.Forms.TextBox in22;
        private System.Windows.Forms.TextBox in21;
    }
}


namespace ConcreteCalculate
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxBags = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(75, 172);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(156, 172);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(140, 23);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Calculate Concrete Cost";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(113, 111);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 3;
            this.textBoxWidth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(246, 111);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxLength.TabIndex = 4;
            this.textBoxLength.TextChanged += new System.EventHandler(this.textBoxLength_TextChanged);
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(246, 264);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.ReadOnly = true;
            this.textBoxVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxVolume.TabIndex = 5;
            this.textBoxVolume.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(113, 264);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 6;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(113, 312);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.ReadOnly = true;
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 8;
            this.textBoxWeight.TextChanged += new System.EventHandler(this.textBoxWeight_TextChanged);
            // 
            // textBoxBags
            // 
            this.textBoxBags.Location = new System.Drawing.Point(246, 312);
            this.textBoxBags.Name = "textBoxBags";
            this.textBoxBags.ReadOnly = true;
            this.textBoxBags.Size = new System.Drawing.Size(100, 20);
            this.textBoxBags.TabIndex = 7;
            this.textBoxBags.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Width (m)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Length (m)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cost";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Weight (kg)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Volume";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bags";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(194, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Input";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.Location = new System.Drawing.Point(185, 224);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(83, 25);
            this.Results.TabIndex = 17;
            this.Results.Text = "Results";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(302, 172);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(366, 275);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(78, 50);
            this.buttonHelp.TabIndex = 19;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Driveway Concrete Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 346);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxBags);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxBags;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label label7;
    }
}


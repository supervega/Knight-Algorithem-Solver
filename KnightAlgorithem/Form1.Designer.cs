namespace KnightAlgorithem
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Solvebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sizetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Solve2btn = new System.Windows.Forms.Button();
            this.Thinklbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Solvebtn
            // 
            this.Solvebtn.Location = new System.Drawing.Point(69, 105);
            this.Solvebtn.Name = "Solvebtn";
            this.Solvebtn.Size = new System.Drawing.Size(75, 23);
            this.Solvebtn.TabIndex = 2;
            this.Solvebtn.Text = "Solve";
            this.Solvebtn.UseVisualStyleBackColor = true;
            this.Solvebtn.Click += new System.EventHandler(this.Solvebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Row :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clolumns :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(204, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 390);
            this.panel1.TabIndex = 5;
            // 
            // Sizetxt
            // 
            this.Sizetxt.Location = new System.Drawing.Point(88, 30);
            this.Sizetxt.Name = "Sizetxt";
            this.Sizetxt.Size = new System.Drawing.Size(68, 20);
            this.Sizetxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Size :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Solvebtn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 146);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initial Information";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 383);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(166, 19);
            this.progressBar1.TabIndex = 9;
            // 
            // Solve2btn
            // 
            this.Solve2btn.Location = new System.Drawing.Point(12, 248);
            this.Solve2btn.Name = "Solve2btn";
            this.Solve2btn.Size = new System.Drawing.Size(166, 23);
            this.Solve2btn.TabIndex = 5;
            this.Solve2btn.Text = "Inputs Can be Solved With";
            this.Solve2btn.UseVisualStyleBackColor = true;
            this.Solve2btn.Click += new System.EventHandler(this.Solve2btn_Click);
            // 
            // Thinklbl
            // 
            this.Thinklbl.AutoSize = true;
            this.Thinklbl.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Thinklbl.Location = new System.Drawing.Point(47, 300);
            this.Thinklbl.Name = "Thinklbl";
            this.Thinklbl.Size = new System.Drawing.Size(0, 29);
            this.Thinklbl.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 414);
            this.Controls.Add(this.Thinklbl);
            this.Controls.Add(this.Solve2btn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sizetxt);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Algorithem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Solvebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Sizetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Solve2btn;
        private System.Windows.Forms.Label Thinklbl;
    }
}


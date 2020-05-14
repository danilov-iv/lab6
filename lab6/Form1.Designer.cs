namespace WindowsFormsApp2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Eq = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Eq, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.CE, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Num0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Dot, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Div, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Num1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Num2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Num3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Mult, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Num4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Num5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Sub, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Num7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Num8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Num9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Add, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Num6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Display, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 353);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Eq
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Eq, 4);
            this.Eq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Eq.Location = new System.Drawing.Point(3, 293);
            this.Eq.Name = "Eq";
            this.Eq.Size = new System.Drawing.Size(285, 57);
            this.Eq.TabIndex = 0;
            this.Eq.Text = "=";
            this.Eq.UseVisualStyleBackColor = true;
            this.Eq.Click += new System.EventHandler(this.Eq_Click);
            // 
            // CE
            // 
            this.CE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CE.Location = new System.Drawing.Point(3, 235);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(66, 52);
            this.CE.TabIndex = 1;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // Num0
            // 
            this.Num0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num0.Location = new System.Drawing.Point(75, 235);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(66, 52);
            this.Num0.TabIndex = 2;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Dot
            // 
            this.Dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dot.Location = new System.Drawing.Point(147, 235);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(66, 52);
            this.Dot.TabIndex = 3;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Div
            // 
            this.Div.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Div.Location = new System.Drawing.Point(219, 235);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(69, 52);
            this.Div.TabIndex = 4;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Num1
            // 
            this.Num1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num1.Location = new System.Drawing.Point(3, 177);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(66, 52);
            this.Num1.TabIndex = 5;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = true;
            this.Num1.Click += new System.EventHandler(this.Num1_Click);

            // 
            // Num2
            // 
            this.Num2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num2.Location = new System.Drawing.Point(75, 177);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(66, 52);
            this.Num2.TabIndex = 6;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = true;
            this.Num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // Num3
            // 
            this.Num3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num3.Location = new System.Drawing.Point(147, 177);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(66, 52);
            this.Num3.TabIndex = 7;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = true;
            this.Num3.Click += new System.EventHandler(this.Num3_Click);
            // 
            // Mult
            // 
            this.Mult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mult.Location = new System.Drawing.Point(219, 177);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(69, 52);
            this.Mult.TabIndex = 8;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);

            // 
            // Num4
            // 
            this.Num4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num4.Location = new System.Drawing.Point(3, 119);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(66, 52);
            this.Num4.TabIndex = 9;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = true;
            this.Num4.Click += new System.EventHandler(this.Num4_Click);
            // 
            // Num5
            // 
            this.Num5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num5.Location = new System.Drawing.Point(75, 119);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(66, 52);
            this.Num5.TabIndex = 10;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = true;
            this.Num5.Click += new System.EventHandler(this.Num5_Click);
            // 
            // Sub
            // 
            this.Sub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sub.Location = new System.Drawing.Point(219, 119);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(69, 52);
            this.Sub.TabIndex = 12;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Num7
            // 
            this.Num7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num7.Location = new System.Drawing.Point(3, 61);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(66, 52);
            this.Num7.TabIndex = 13;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = true;
            this.Num7.Click += new System.EventHandler(this.Num7_Click);
            // 
            // Num8
            // 
            this.Num8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num8.Location = new System.Drawing.Point(75, 61);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(66, 52);
            this.Num8.TabIndex = 14;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = true;
            this.Num8.Click += new System.EventHandler(this.Num8_Click);
            // 
            // Num9
            // 
            this.Num9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num9.Location = new System.Drawing.Point(147, 61);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(66, 52);
            this.Num9.TabIndex = 15;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = true;
            this.Num9.Click += new System.EventHandler(this.Num9_Click);
            // 
            // Add
            // 
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Location = new System.Drawing.Point(219, 61);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(69, 52);
            this.Add.TabIndex = 16;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Num6
            // 
            this.Num6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num6.Location = new System.Drawing.Point(147, 119);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(66, 52);
            this.Num6.TabIndex = 11;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = true;
            this.Num6.Click += new System.EventHandler(this.Num6_Click);
            // 
            // Display
            // 
            this.Display.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.Display, 4);
            this.Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(0, 0);
            this.Display.Margin = new System.Windows.Forms.Padding(0);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(291, 58);
            this.Display.TabIndex = 17;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 353);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 600);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPreview = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Eq;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Display;
    }
}


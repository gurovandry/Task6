namespace Task6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.output = new System.Windows.Forms.TextBox();
            this.but7 = new System.Windows.Forms.Button();
            this.but_eq = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.plus_but = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.min_but = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.mult_but = new System.Windows.Forms.Button();
            this.ce_but = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.but_dot = new System.Windows.Forms.Button();
            this.dev_but = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.output, 4);
            this.output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output.Location = new System.Drawing.Point(3, 3);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(426, 104);
            this.output.TabIndex = 0;
            // 
            // but7
            // 
            this.but7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but7.Location = new System.Drawing.Point(3, 113);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(80, 76);
            this.but7.TabIndex = 2;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            this.but7.Click += new System.EventHandler(this.but7_Click);
            // 
            // but_eq
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.but_eq, 4);
            this.but_eq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_eq.Location = new System.Drawing.Point(3, 441);
            this.but_eq.Name = "but_eq";
            this.but_eq.Size = new System.Drawing.Size(426, 109);
            this.but_eq.TabIndex = 1;
            this.but_eq.Text = "=";
            this.but_eq.UseVisualStyleBackColor = true;
            this.but_eq.Click += new System.EventHandler(this.but_eq_Click);
            // 
            // but8
            // 
            this.but8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but8.Location = new System.Drawing.Point(89, 113);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(80, 76);
            this.but8.TabIndex = 3;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            this.but8.Click += new System.EventHandler(this.but8_Click);
            // 
            // but9
            // 
            this.but9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but9.Location = new System.Drawing.Point(175, 113);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(80, 76);
            this.but9.TabIndex = 4;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            this.but9.Click += new System.EventHandler(this.but9_Click);
            // 
            // plus_but
            // 
            this.plus_but.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plus_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus_but.Location = new System.Drawing.Point(261, 113);
            this.plus_but.Name = "plus_but";
            this.plus_but.Size = new System.Drawing.Size(168, 76);
            this.plus_but.TabIndex = 5;
            this.plus_but.Text = "+";
            this.plus_but.UseVisualStyleBackColor = true;
            this.plus_but.Click += new System.EventHandler(this.plus_but_Click);
            // 
            // but4
            // 
            this.but4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but4.Location = new System.Drawing.Point(3, 195);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(80, 76);
            this.but4.TabIndex = 6;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.but4_Click);
            // 
            // but5
            // 
            this.but5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but5.Location = new System.Drawing.Point(89, 195);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(80, 76);
            this.but5.TabIndex = 7;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            this.but5.Click += new System.EventHandler(this.but5_Click);
            // 
            // but6
            // 
            this.but6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but6.Location = new System.Drawing.Point(175, 195);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(80, 76);
            this.but6.TabIndex = 8;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = true;
            this.but6.Click += new System.EventHandler(this.but6_Click);
            // 
            // min_but
            // 
            this.min_but.Dock = System.Windows.Forms.DockStyle.Fill;
            this.min_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min_but.Location = new System.Drawing.Point(261, 195);
            this.min_but.Name = "min_but";
            this.min_but.Size = new System.Drawing.Size(168, 76);
            this.min_but.TabIndex = 9;
            this.min_but.Text = "-";
            this.min_but.UseVisualStyleBackColor = true;
            this.min_but.Click += new System.EventHandler(this.min_but_Click);
            // 
            // but1
            // 
            this.but1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but1.Location = new System.Drawing.Point(3, 277);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(80, 76);
            this.but1.TabIndex = 10;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // but2
            // 
            this.but2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but2.Location = new System.Drawing.Point(89, 277);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(80, 76);
            this.but2.TabIndex = 11;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but3
            // 
            this.but3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but3.Location = new System.Drawing.Point(175, 277);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(80, 76);
            this.but3.TabIndex = 12;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // mult_but
            // 
            this.mult_but.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mult_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mult_but.Location = new System.Drawing.Point(261, 277);
            this.mult_but.Name = "mult_but";
            this.mult_but.Size = new System.Drawing.Size(168, 76);
            this.mult_but.TabIndex = 13;
            this.mult_but.Text = "*";
            this.mult_but.UseVisualStyleBackColor = true;
            this.mult_but.Click += new System.EventHandler(this.mult_but_Click);
            // 
            // ce_but
            // 
            this.ce_but.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ce_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ce_but.Location = new System.Drawing.Point(3, 359);
            this.ce_but.Name = "ce_but";
            this.ce_but.Size = new System.Drawing.Size(80, 76);
            this.ce_but.TabIndex = 14;
            this.ce_but.Text = "CE";
            this.ce_but.UseVisualStyleBackColor = true;
            this.ce_but.Click += new System.EventHandler(this.ce_but_Click);
            // 
            // but0
            // 
            this.but0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but0.Location = new System.Drawing.Point(89, 359);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(80, 76);
            this.but0.TabIndex = 15;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = true;
            this.but0.Click += new System.EventHandler(this.but0_Click);
            // 
            // but_dot
            // 
            this.but_dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_dot.Location = new System.Drawing.Point(175, 359);
            this.but_dot.Name = "but_dot";
            this.but_dot.Size = new System.Drawing.Size(80, 76);
            this.but_dot.TabIndex = 16;
            this.but_dot.Text = ".";
            this.but_dot.UseVisualStyleBackColor = true;
            this.but_dot.Click += new System.EventHandler(this.but_dot_Click);
            // 
            // dev_but
            // 
            this.dev_but.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dev_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dev_but.Location = new System.Drawing.Point(261, 359);
            this.dev_but.Name = "dev_but";
            this.dev_but.Size = new System.Drawing.Size(168, 76);
            this.dev_but.TabIndex = 17;
            this.dev_but.Text = "/";
            this.dev_but.UseVisualStyleBackColor = true;
            this.dev_but.Click += new System.EventHandler(this.dev_but_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.dev_but, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.but_dot, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.but0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ce_but, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.mult_but, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.but3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.but2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.but1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.min_but, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.but6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.but5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.but4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.plus_but, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.but9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.but8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.but_eq, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.but7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.output, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 553);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(675, 900);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button dev_but;
        private System.Windows.Forms.Button but_dot;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.Button ce_but;
        private System.Windows.Forms.Button mult_but;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button min_but;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button plus_but;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but_eq;
        private System.Windows.Forms.Button but7;
    }
}


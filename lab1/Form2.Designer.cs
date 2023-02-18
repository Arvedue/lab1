namespace lab1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblArray = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(137, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 165);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(7, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(4, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 100);
            this.label3.TabIndex = 1;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Задание 1";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(137, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 150);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(7, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Удалить в массиве последнюю группу из двух \r\nподряд идущих положительных чисел. \r" +
    "\nЕсли удаление элементов невозможно, \r\nвыдать об этом сообщение.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Задание 2";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.txtNum);
            this.panel3.Controls.Add(this.lblNum);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(572, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 177);
            this.panel3.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(125, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Выполнить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(4, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(425, 80);
            this.label5.TabIndex = 1;
            this.label5.Text = "Вставить после последнего отрицательного \r\nэлемента в массиве два элемента, равны" +
    "х \r\nзаданному значению. Если вставка элементов \r\nневозможна, выдать об этом сооб" +
    "щение.\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Задание 3";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(572, 258);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 115);
            this.panel4.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(7, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 30);
            this.button4.TabIndex = 2;
            this.button4.Text = "Выполнить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(4, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(426, 40);
            this.label7.TabIndex = 1;
            this.label7.Text = "Проверить, есть ли в массиве положительные \r\nэлементы.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Задание 4";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.lblArray);
            this.groupBox1.Location = new System.Drawing.Point(191, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 183);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результаты выполнения";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblResult.Location = new System.Drawing.Point(6, 83);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(129, 25);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Результаты";
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblArray.Location = new System.Drawing.Point(6, 43);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(88, 25);
            this.lblArray.TabIndex = 1;
            this.lblArray.Text = "Массив";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblNum.Location = new System.Drawing.Point(7, 107);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(355, 18);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Введите занчение, которое хотите вставить:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(10, 133);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 32);
            this.txtNum.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1062, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
    }
}
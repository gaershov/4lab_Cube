namespace _4lab_Cube
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.RotateSpeedComboBox = new System.Windows.Forms.ComboBox();
            this.ScaleComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MoveComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.RotateButton1 = new System.Windows.Forms.Button();
            this.RotateButton2 = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.SizeTimer = new System.Windows.Forms.Timer(this.components);
            this.RotateTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Скорость Поворота:";
            // 
            // RotateSpeedComboBox
            // 
            this.RotateSpeedComboBox.FormattingEnabled = true;
            this.RotateSpeedComboBox.Items.AddRange(new object[] {
            "5",
            "10",
            "30",
            "60"});
            this.RotateSpeedComboBox.Location = new System.Drawing.Point(46, 362);
            this.RotateSpeedComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.RotateSpeedComboBox.Name = "RotateSpeedComboBox";
            this.RotateSpeedComboBox.Size = new System.Drawing.Size(94, 21);
            this.RotateSpeedComboBox.TabIndex = 10;
            // 
            // ScaleComboBox
            // 
            this.ScaleComboBox.FormattingEnabled = true;
            this.ScaleComboBox.Items.AddRange(new object[] {
            "1,01",
            "1,05",
            "1,1",
            "1,5",
            "2"});
            this.ScaleComboBox.Location = new System.Drawing.Point(46, 444);
            this.ScaleComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ScaleComboBox.Name = "ScaleComboBox";
            this.ScaleComboBox.Size = new System.Drawing.Size(94, 21);
            this.ScaleComboBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 385);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Скорость Сдвига:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 425);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Скорость Масштаба:";
            // 
            // MoveComboBox
            // 
            this.MoveComboBox.FormattingEnabled = true;
            this.MoveComboBox.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "50",
            "100"});
            this.MoveComboBox.Location = new System.Drawing.Point(46, 403);
            this.MoveComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.MoveComboBox.Name = "MoveComboBox";
            this.MoveComboBox.Size = new System.Drawing.Size(94, 21);
            this.MoveComboBox.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RotateSpeedComboBox);
            this.panel1.Controls.Add(this.ViewButton);
            this.panel1.Controls.Add(this.ScaleComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CheckedListBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MoveComboBox);
            this.panel1.Controls.Add(this.ComboBox1);
            this.panel1.Controls.Add(this.RotateButton1);
            this.panel1.Controls.Add(this.RotateButton2);
            this.panel1.Controls.Add(this.LeftButton);
            this.panel1.Controls.Add(this.RightButton);
            this.panel1.Controls.Add(this.PlusButton);
            this.panel1.Controls.Add(this.MinusButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(746, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 669);
            this.panel1.TabIndex = 18;
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewButton.Location = new System.Drawing.Point(2, 608);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(2);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(164, 49);
            this.ViewButton.TabIndex = 11;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewButton_MouseDown);
            this.ViewButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewButton_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(28, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Выберите оси:";
            // 
            // CheckedListBox
            // 
            this.CheckedListBox.FormattingEnabled = true;
            this.CheckedListBox.Items.AddRange(new object[] {
            "Ox",
            "Oy",
            "Oz"});
            this.CheckedListBox.Location = new System.Drawing.Point(14, 129);
            this.CheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.CheckedListBox.Name = "CheckedListBox";
            this.CheckedListBox.Size = new System.Drawing.Size(126, 49);
            this.CheckedListBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите ось:";
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Ox",
            "Oy",
            "Oz"});
            this.ComboBox1.Location = new System.Drawing.Point(14, 26);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(126, 21);
            this.ComboBox1.TabIndex = 3;
            // 
            // RotateButton1
            // 
            this.RotateButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RotateButton1.Location = new System.Drawing.Point(14, 51);
            this.RotateButton1.Margin = new System.Windows.Forms.Padding(2);
            this.RotateButton1.Name = "RotateButton1";
            this.RotateButton1.Size = new System.Drawing.Size(44, 49);
            this.RotateButton1.TabIndex = 2;
            this.RotateButton1.Text = "↻";
            this.RotateButton1.UseVisualStyleBackColor = true;
            this.RotateButton1.Click += new System.EventHandler(this.RotateButton1_Click);
            this.RotateButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateButton1_MouseDown);
            this.RotateButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RotateButton1_MouseUp);
            // 
            // RotateButton2
            // 
            this.RotateButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RotateButton2.Location = new System.Drawing.Point(64, 51);
            this.RotateButton2.Margin = new System.Windows.Forms.Padding(2);
            this.RotateButton2.Name = "RotateButton2";
            this.RotateButton2.Size = new System.Drawing.Size(44, 49);
            this.RotateButton2.TabIndex = 1;
            this.RotateButton2.Text = "↺";
            this.RotateButton2.UseVisualStyleBackColor = true;
            this.RotateButton2.Click += new System.EventHandler(this.Rotate_Click);
            this.RotateButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateButton2_MouseDown);
            this.RotateButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RotateButton1_MouseUp);
            // 
            // LeftButton
            // 
            this.LeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftButton.Location = new System.Drawing.Point(14, 185);
            this.LeftButton.Margin = new System.Windows.Forms.Padding(2);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(44, 49);
            this.LeftButton.TabIndex = 5;
            this.LeftButton.Text = "←";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            this.LeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftButton_MouseDown);
            this.LeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftButton_MouseUp);
            // 
            // RightButton
            // 
            this.RightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightButton.Location = new System.Drawing.Point(71, 185);
            this.RightButton.Margin = new System.Windows.Forms.Padding(2);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(44, 49);
            this.RightButton.TabIndex = 6;
            this.RightButton.Text = "→";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            this.RightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightButton_MouseDown);
            this.RightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightButton_MouseUp);
            // 
            // PlusButton
            // 
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusButton.Location = new System.Drawing.Point(14, 238);
            this.PlusButton.Margin = new System.Windows.Forms.Padding(2);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(44, 49);
            this.PlusButton.TabIndex = 8;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            this.PlusButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlusButton_MouseDown);
            this.PlusButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlusButton_MouseUp);
            // 
            // MinusButton
            // 
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusButton.Location = new System.Drawing.Point(71, 238);
            this.MinusButton.Margin = new System.Windows.Forms.Padding(2);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(44, 49);
            this.MinusButton.TabIndex = 7;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            this.MinusButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinusButton_MouseDown);
            this.MinusButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MinusButton_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(916, 669);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // MoveTimer
            // 
            this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);
            // 
            // SizeTimer
            // 
            this.SizeTimer.Tick += new System.EventHandler(this.SizeTimer_Tick);
            // 
            // RotateTimer
            // 
            this.RotateTimer.Tick += new System.EventHandler(this.RotateTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 669);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RotateSpeedComboBox;
        private System.Windows.Forms.ComboBox ScaleComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MoveComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox CheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.Button RotateButton1;
        private System.Windows.Forms.Button RotateButton2;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.Timer SizeTimer;
        private System.Windows.Forms.Timer RotateTimer;
    }
}


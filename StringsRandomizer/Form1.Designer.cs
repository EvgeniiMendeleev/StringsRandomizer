namespace StringsRandomizer
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
            this.button1 = new System.Windows.Forms.Button();
            this.stateOfSystem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFiles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericCountOfOutputFiles = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountOfOutputFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить строки из файлов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadFromInputFiles);
            // 
            // stateOfSystem
            // 
            this.stateOfSystem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stateOfSystem.Location = new System.Drawing.Point(161, 17);
            this.stateOfSystem.Name = "stateOfSystem";
            this.stateOfSystem.ReadOnly = true;
            this.stateOfSystem.Size = new System.Drawing.Size(512, 22);
            this.stateOfSystem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Состояние системы:";
            // 
            // comboBoxFiles
            // 
            this.comboBoxFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiles.FormattingEnabled = true;
            this.comboBoxFiles.Location = new System.Drawing.Point(195, 101);
            this.comboBoxFiles.Name = "comboBoxFiles";
            this.comboBoxFiles.Size = new System.Drawing.Size(237, 24);
            this.comboBoxFiles.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сгенерировать из файла:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(429, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Сбросить загруженные данные";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeleteAllLoadedDatas);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество выходных файлов:";
            // 
            // numericCountOfOutputFiles
            // 
            this.numericCountOfOutputFiles.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericCountOfOutputFiles.Location = new System.Drawing.Point(15, 159);
            this.numericCountOfOutputFiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCountOfOutputFiles.Name = "numericCountOfOutputFiles";
            this.numericCountOfOutputFiles.ReadOnly = true;
            this.numericCountOfOutputFiles.Size = new System.Drawing.Size(208, 22);
            this.numericCountOfOutputFiles.TabIndex = 8;
            this.numericCountOfOutputFiles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "Сгенерировать результат";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GenerateResult);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 263);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.numericCountOfOutputFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stateOfSystem);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Рандомайзер строк v2.0";
            ((System.ComponentModel.ISupportInitialize)(this.numericCountOfOutputFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox stateOfSystem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericCountOfOutputFiles;
        private System.Windows.Forms.Button button4;
    }
}


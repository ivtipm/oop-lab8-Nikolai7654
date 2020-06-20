namespace ComplexCalculator
{
    partial class MainForm
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
            this.LeftNumber = new System.Windows.Forms.TextBox();
            this.RightNumber = new System.Windows.Forms.TextBox();
            this.ActionList = new System.Windows.Forms.ComboBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultText = new System.Windows.Forms.Label();
            this.LeftNumberText = new System.Windows.Forms.Label();
            this.RightNumberText = new System.Windows.Forms.Label();
            this.ActionText = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ModuleText = new System.Windows.Forms.Label();
            this.ArgumentText = new System.Windows.Forms.Label();
            this.ModuleLabel = new System.Windows.Forms.Label();
            this.ArgumentLabel = new System.Windows.Forms.Label();
            this.LeftNumModuleText = new System.Windows.Forms.Label();
            this.RightNumModuleText = new System.Windows.Forms.Label();
            this.RightNumArgText = new System.Windows.Forms.Label();
            this.LeftNumModuleLabel = new System.Windows.Forms.Label();
            this.LeftNumArgLabel = new System.Windows.Forms.Label();
            this.RightNumModuleLabel = new System.Windows.Forms.Label();
            this.RightNumArgLabel = new System.Windows.Forms.Label();
            this.LeftNumArgText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LeftNumber
            // 
            this.LeftNumber.Location = new System.Drawing.Point(85, 62);
            this.LeftNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LeftNumber.Name = "LeftNumber";
            this.LeftNumber.Size = new System.Drawing.Size(155, 22);
            this.LeftNumber.TabIndex = 0;
            // 
            // RightNumber
            // 
            this.RightNumber.Location = new System.Drawing.Point(337, 62);
            this.RightNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RightNumber.Name = "RightNumber";
            this.RightNumber.Size = new System.Drawing.Size(155, 22);
            this.RightNumber.TabIndex = 1;
            // 
            // ActionList
            // 
            this.ActionList.FormattingEnabled = true;
            this.ActionList.Items.AddRange(new object[] {
            "Сложить",
            "Вычесть",
            "Умножить",
            "Поделить"});
            this.ActionList.Location = new System.Drawing.Point(248, 60);
            this.ActionList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ActionList.Name = "ActionList";
            this.ActionList.Size = new System.Drawing.Size(80, 24);
            this.ActionList.TabIndex = 2;
            this.ActionList.Text = "Сложить";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(79, 127);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(161, 28);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "РАССЧИТАТЬ";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultText
            // 
            this.ResultText.AutoSize = true;
            this.ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultText.Location = new System.Drawing.Point(83, 174);
            this.ResultText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(117, 25);
            this.ResultText.TabIndex = 4;
            this.ResultText.Text = "Результат:";
            // 
            // LeftNumberText
            // 
            this.LeftNumberText.AutoSize = true;
            this.LeftNumberText.Location = new System.Drawing.Point(85, 38);
            this.LeftNumberText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LeftNumberText.Name = "LeftNumberText";
            this.LeftNumberText.Size = new System.Drawing.Size(61, 17);
            this.LeftNumberText.TabIndex = 5;
            this.LeftNumberText.Text = "Число 1";
            // 
            // RightNumberText
            // 
            this.RightNumberText.AutoSize = true;
            this.RightNumberText.Location = new System.Drawing.Point(350, 41);
            this.RightNumberText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RightNumberText.Name = "RightNumberText";
            this.RightNumberText.Size = new System.Drawing.Size(61, 17);
            this.RightNumberText.TabIndex = 6;
            this.RightNumberText.Text = "Число 2";
            // 
            // ActionText
            // 
            this.ActionText.AutoSize = true;
            this.ActionText.Location = new System.Drawing.Point(245, 39);
            this.ActionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActionText.Name = "ActionText";
            this.ActionText.Size = new System.Drawing.Size(75, 17);
            this.ActionText.TabIndex = 7;
            this.ActionText.Text = "Операция";
            // 
            // ResultLabel
            // 
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(75, 212);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(202, 28);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModuleText
            // 
            this.ModuleText.AutoSize = true;
            this.ModuleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModuleText.Location = new System.Drawing.Point(16, 274);
            this.ModuleText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModuleText.Name = "ModuleText";
            this.ModuleText.Size = new System.Drawing.Size(88, 25);
            this.ModuleText.TabIndex = 9;
            this.ModuleText.Text = "Модуль:";
            // 
            // ArgumentText
            // 
            this.ArgumentText.AutoSize = true;
            this.ArgumentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArgumentText.Location = new System.Drawing.Point(243, 272);
            this.ArgumentText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArgumentText.Name = "ArgumentText";
            this.ArgumentText.Size = new System.Drawing.Size(110, 25);
            this.ArgumentText.TabIndex = 10;
            this.ArgumentText.Text = "Аргумент:";
            // 
            // ModuleLabel
            // 
            this.ModuleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModuleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModuleLabel.Location = new System.Drawing.Point(120, 274);
            this.ModuleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModuleLabel.Name = "ModuleLabel";
            this.ModuleLabel.Size = new System.Drawing.Size(120, 28);
            this.ModuleLabel.TabIndex = 11;
            this.ModuleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArgumentLabel
            // 
            this.ArgumentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArgumentLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArgumentLabel.Location = new System.Drawing.Point(363, 274);
            this.ArgumentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArgumentLabel.Name = "ArgumentLabel";
            this.ArgumentLabel.Size = new System.Drawing.Size(78, 28);
            this.ArgumentLabel.TabIndex = 12;
            this.ArgumentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftNumModuleText
            // 
            this.LeftNumModuleText.AutoSize = true;
            this.LeftNumModuleText.Location = new System.Drawing.Point(85, 90);
            this.LeftNumModuleText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LeftNumModuleText.Name = "LeftNumModuleText";
            this.LeftNumModuleText.Size = new System.Drawing.Size(61, 17);
            this.LeftNumModuleText.TabIndex = 13;
            this.LeftNumModuleText.Text = "Модуль:";
            // 
            // RightNumModuleText
            // 
            this.RightNumModuleText.AutoSize = true;
            this.RightNumModuleText.Location = new System.Drawing.Point(364, 90);
            this.RightNumModuleText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RightNumModuleText.Name = "RightNumModuleText";
            this.RightNumModuleText.Size = new System.Drawing.Size(61, 17);
            this.RightNumModuleText.TabIndex = 14;
            this.RightNumModuleText.Text = "Модуль:";
            // 
            // RightNumArgText
            // 
            this.RightNumArgText.AutoSize = true;
            this.RightNumArgText.Location = new System.Drawing.Point(364, 107);
            this.RightNumArgText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RightNumArgText.Name = "RightNumArgText";
            this.RightNumArgText.Size = new System.Drawing.Size(73, 17);
            this.RightNumArgText.TabIndex = 16;
            this.RightNumArgText.Text = "Аргумент:";
            // 
            // LeftNumModuleLabel
            // 
            this.LeftNumModuleLabel.Location = new System.Drawing.Point(157, 90);
            this.LeftNumModuleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LeftNumModuleLabel.Name = "LeftNumModuleLabel";
            this.LeftNumModuleLabel.Size = new System.Drawing.Size(97, 16);
            this.LeftNumModuleLabel.TabIndex = 17;
            // 
            // LeftNumArgLabel
            // 
            this.LeftNumArgLabel.Location = new System.Drawing.Point(171, 106);
            this.LeftNumArgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LeftNumArgLabel.Name = "LeftNumArgLabel";
            this.LeftNumArgLabel.Size = new System.Drawing.Size(84, 16);
            this.LeftNumArgLabel.TabIndex = 18;
            // 
            // RightNumModuleLabel
            // 
            this.RightNumModuleLabel.Location = new System.Drawing.Point(445, 91);
            this.RightNumModuleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RightNumModuleLabel.Name = "RightNumModuleLabel";
            this.RightNumModuleLabel.Size = new System.Drawing.Size(84, 16);
            this.RightNumModuleLabel.TabIndex = 19;
            // 
            // RightNumArgLabel
            // 
            this.RightNumArgLabel.Location = new System.Drawing.Point(445, 108);
            this.RightNumArgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RightNumArgLabel.Name = "RightNumArgLabel";
            this.RightNumArgLabel.Size = new System.Drawing.Size(84, 16);
            this.RightNumArgLabel.TabIndex = 20;
            // 
            // LeftNumArgText
            // 
            this.LeftNumArgText.AutoSize = true;
            this.LeftNumArgText.Location = new System.Drawing.Point(85, 106);
            this.LeftNumArgText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LeftNumArgText.Name = "LeftNumArgText";
            this.LeftNumArgText.Size = new System.Drawing.Size(73, 17);
            this.LeftNumArgText.TabIndex = 15;
            this.LeftNumArgText.Text = "Аргумент:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(535, 332);
            this.Controls.Add(this.RightNumArgLabel);
            this.Controls.Add(this.RightNumModuleLabel);
            this.Controls.Add(this.LeftNumArgLabel);
            this.Controls.Add(this.LeftNumModuleLabel);
            this.Controls.Add(this.RightNumArgText);
            this.Controls.Add(this.LeftNumArgText);
            this.Controls.Add(this.RightNumModuleText);
            this.Controls.Add(this.LeftNumModuleText);
            this.Controls.Add(this.ArgumentLabel);
            this.Controls.Add(this.ModuleLabel);
            this.Controls.Add(this.ArgumentText);
            this.Controls.Add(this.ModuleText);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ActionText);
            this.Controls.Add(this.RightNumberText);
            this.Controls.Add(this.LeftNumberText);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ActionList);
            this.Controls.Add(this.RightNumber);
            this.Controls.Add(this.LeftNumber);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "ComplexCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LeftNumber;
        private System.Windows.Forms.TextBox RightNumber;
        private System.Windows.Forms.ComboBox ActionList;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label ResultText;
        private System.Windows.Forms.Label LeftNumberText;
        private System.Windows.Forms.Label RightNumberText;
        private System.Windows.Forms.Label ActionText;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label ModuleText;
        private System.Windows.Forms.Label ArgumentText;
        private System.Windows.Forms.Label ModuleLabel;
        private System.Windows.Forms.Label ArgumentLabel;
        private System.Windows.Forms.Label LeftNumModuleText;
        private System.Windows.Forms.Label RightNumModuleText;
        private System.Windows.Forms.Label RightNumArgText;
        private System.Windows.Forms.Label LeftNumModuleLabel;
        private System.Windows.Forms.Label LeftNumArgLabel;
        private System.Windows.Forms.Label RightNumModuleLabel;
        private System.Windows.Forms.Label RightNumArgLabel;
        private System.Windows.Forms.Label LeftNumArgText;
    }
}


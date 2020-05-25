namespace Lesson7_task2_GuessNumber
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnUserInput = new System.Windows.Forms.Button();
            this.lblCompAnswer = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblTryCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.Location = new System.Drawing.Point(24, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(221, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Угадайте число от 1 до 100";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(83, 65);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 33);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumber.Location = new System.Drawing.Point(60, 162);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(140, 26);
            this.tbNumber.TabIndex = 2;
            this.tbNumber.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2.Location = new System.Drawing.Point(67, 138);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(125, 20);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Введите число";
            // 
            // btnUserInput
            // 
            this.btnUserInput.Enabled = false;
            this.btnUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUserInput.Location = new System.Drawing.Point(83, 212);
            this.btnUserInput.Name = "btnUserInput";
            this.btnUserInput.Size = new System.Drawing.Size(94, 33);
            this.btnUserInput.TabIndex = 4;
            this.btnUserInput.Text = "Ввести";
            this.btnUserInput.UseVisualStyleBackColor = true;
            this.btnUserInput.Click += new System.EventHandler(this.btnUserInput_Click);
            // 
            // lblCompAnswer
            // 
            this.lblCompAnswer.AutoSize = true;
            this.lblCompAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompAnswer.Location = new System.Drawing.Point(24, 263);
            this.lblCompAnswer.Name = "lblCompAnswer";
            this.lblCompAnswer.Size = new System.Drawing.Size(213, 20);
            this.lblCompAnswer.TabIndex = 5;
            this.lblCompAnswer.Text = "Загаданное число больше";
            this.lblCompAnswer.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3.Location = new System.Drawing.Point(278, 138);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(125, 20);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Число попыток";
            // 
            // lblTryCounter
            // 
            this.lblTryCounter.AutoSize = true;
            this.lblTryCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTryCounter.Location = new System.Drawing.Point(308, 162);
            this.lblTryCounter.Name = "lblTryCounter";
            this.lblTryCounter.Size = new System.Drawing.Size(64, 46);
            this.lblTryCounter.TabIndex = 7;
            this.lblTryCounter.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 333);
            this.Controls.Add(this.lblTryCounter);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblCompAnswer);
            this.Controls.Add(this.btnUserInput);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnUserInput;
        private System.Windows.Forms.Label lblCompAnswer;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblTryCounter;
    }
}


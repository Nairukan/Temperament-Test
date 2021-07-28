namespace FirstTry
{
    partial class Test
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
            this.AnswerBox = new System.Windows.Forms.GroupBox();
            this.Answer1 = new System.Windows.Forms.RadioButton();
            this.Answer2 = new System.Windows.Forms.RadioButton();
            this.Answer3 = new System.Windows.Forms.RadioButton();
            this.Answer4 = new System.Windows.Forms.RadioButton();
            this.snoButton = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Label();
            this.exButton = new System.Windows.Forms.Button();
            this.seText = new System.Windows.Forms.Label();
            this.AnswerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnswerBox
            // 
            this.AnswerBox.Controls.Add(this.Answer1);
            this.AnswerBox.Controls.Add(this.Answer2);
            this.AnswerBox.Controls.Add(this.Answer3);
            this.AnswerBox.Controls.Add(this.Answer4);
            this.AnswerBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerBox.Location = new System.Drawing.Point(40, 85);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(800, 310);
            this.AnswerBox.TabIndex = 0;
            this.AnswerBox.TabStop = false;
            this.AnswerBox.Visible = false;
            // 
            // Answer1
            // 
            this.Answer1.AutoEllipsis = true;
            this.Answer1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Answer1.Location = new System.Drawing.Point(5, 15);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(789, 70);
            this.Answer1.TabIndex = 0;
            this.Answer1.TabStop = true;
            this.Answer1.Text = "radioButton1";
            this.Answer1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Answer1.UseVisualStyleBackColor = true;
            // 
            // Answer2
            // 
            this.Answer2.AutoEllipsis = true;
            this.Answer2.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Answer2.Location = new System.Drawing.Point(5, 85);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(789, 70);
            this.Answer2.TabIndex = 1;
            this.Answer2.TabStop = true;
            this.Answer2.Text = "radioButton2";
            this.Answer2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Answer2.UseVisualStyleBackColor = true;
            // 
            // Answer3
            // 
            this.Answer3.AutoEllipsis = true;
            this.Answer3.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Answer3.Location = new System.Drawing.Point(5, 155);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(789, 70);
            this.Answer3.TabIndex = 2;
            this.Answer3.TabStop = true;
            this.Answer3.Text = "radioButton3";
            this.Answer3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Answer3.UseVisualStyleBackColor = true;
            // 
            // Answer4
            // 
            this.Answer4.AutoEllipsis = true;
            this.Answer4.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Answer4.Location = new System.Drawing.Point(5, 225);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(789, 70);
            this.Answer4.TabIndex = 3;
            this.Answer4.TabStop = true;
            this.Answer4.Text = "radioButton4";
            this.Answer4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Answer4.UseVisualStyleBackColor = true;
            // 
            // snoButton
            // 
            this.snoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.snoButton.Location = new System.Drawing.Point(387, 405);
            this.snoButton.Name = "snoButton";
            this.snoButton.Size = new System.Drawing.Size(126, 35);
            this.snoButton.TabIndex = 1;
            this.snoButton.Text = "Начать";
            this.snoButton.UseVisualStyleBackColor = true;
            this.snoButton.Click += new System.EventHandler(this.snoButton_Click);
            // 
            // Question
            // 
            this.Question.AutoEllipsis = true;
            this.Question.Location = new System.Drawing.Point(50, 30);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(774, 52);
            this.Question.TabIndex = 2;
            this.Question.Text = "Question";
            this.Question.Visible = false;
            // 
            // exButton
            // 
            this.exButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exButton.Location = new System.Drawing.Point(387, 405);
            this.exButton.Name = "exButton";
            this.exButton.Size = new System.Drawing.Size(126, 35);
            this.exButton.TabIndex = 3;
            this.exButton.Text = "Завершить";
            this.exButton.UseVisualStyleBackColor = true;
            this.exButton.Visible = false;
            this.exButton.Click += new System.EventHandler(this.exButton_Click);
            // 
            // seText
            // 
            this.seText.AutoEllipsis = true;
            this.seText.Location = new System.Drawing.Point(50, 30);
            this.seText.Name = "seText";
            this.seText.Size = new System.Drawing.Size(774, 365);
            this.seText.TabIndex = 4;
            this.seText.Text = "Description";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.seText);
            this.Controls.Add(this.exButton);
            this.Controls.Add(this.snoButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Test";
            this.Text = "Form1";
            this.AnswerBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AnswerBox;
        private System.Windows.Forms.RadioButton Answer4;
        private System.Windows.Forms.RadioButton Answer3;
        private System.Windows.Forms.RadioButton Answer2;
        private System.Windows.Forms.RadioButton Answer1;
        private System.Windows.Forms.Button snoButton;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button exButton;
        private System.Windows.Forms.Label seText;
    }
}


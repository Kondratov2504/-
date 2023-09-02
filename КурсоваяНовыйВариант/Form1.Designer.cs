namespace КурсоваяНовыйВариант
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
            this.classButton = new System.Windows.Forms.Button();
            this.teacherButton = new System.Windows.Forms.Button();
            this.studentsButton = new System.Windows.Forms.Button();
            this.subjectButton = new System.Windows.Forms.Button();
            this.lessonButton = new System.Windows.Forms.Button();
            this.studentAchievementButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classButton
            // 
            this.classButton.Location = new System.Drawing.Point(46, 32);
            this.classButton.Name = "classButton";
            this.classButton.Size = new System.Drawing.Size(159, 143);
            this.classButton.TabIndex = 0;
            this.classButton.Text = "Class";
            this.classButton.UseVisualStyleBackColor = true;
            this.classButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // teacherButton
            // 
            this.teacherButton.Location = new System.Drawing.Point(234, 32);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Size = new System.Drawing.Size(159, 143);
            this.teacherButton.TabIndex = 1;
            this.teacherButton.Text = "Teacher";
            this.teacherButton.UseVisualStyleBackColor = true;
            this.teacherButton.Click += new System.EventHandler(this.teacherButton_Click);
            // 
            // studentsButton
            // 
            this.studentsButton.Location = new System.Drawing.Point(410, 32);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(159, 143);
            this.studentsButton.TabIndex = 2;
            this.studentsButton.Text = "Students";
            this.studentsButton.UseVisualStyleBackColor = true;
            this.studentsButton.Click += new System.EventHandler(this.studentsButton_Click);
            // 
            // subjectButton
            // 
            this.subjectButton.Location = new System.Drawing.Point(587, 32);
            this.subjectButton.Name = "subjectButton";
            this.subjectButton.Size = new System.Drawing.Size(159, 143);
            this.subjectButton.TabIndex = 3;
            this.subjectButton.Text = "Subject";
            this.subjectButton.UseVisualStyleBackColor = true;
            this.subjectButton.Click += new System.EventHandler(this.subjectButton_Click);
            // 
            // lessonButton
            // 
            this.lessonButton.Location = new System.Drawing.Point(116, 270);
            this.lessonButton.Name = "lessonButton";
            this.lessonButton.Size = new System.Drawing.Size(185, 111);
            this.lessonButton.TabIndex = 4;
            this.lessonButton.Text = "Lesson";
            this.lessonButton.UseVisualStyleBackColor = true;
            this.lessonButton.Click += new System.EventHandler(this.lessonButton_Click);
            // 
            // studentAchievementButton
            // 
            this.studentAchievementButton.Location = new System.Drawing.Point(468, 270);
            this.studentAchievementButton.Name = "studentAchievementButton";
            this.studentAchievementButton.Size = new System.Drawing.Size(185, 111);
            this.studentAchievementButton.TabIndex = 5;
            this.studentAchievementButton.Text = "StudentAchievement";
            this.studentAchievementButton.UseVisualStyleBackColor = true;
            this.studentAchievementButton.Click += new System.EventHandler(this.studentAchievementButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentAchievementButton);
            this.Controls.Add(this.lessonButton);
            this.Controls.Add(this.subjectButton);
            this.Controls.Add(this.studentsButton);
            this.Controls.Add(this.teacherButton);
            this.Controls.Add(this.classButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button classButton;
        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button subjectButton;
        private System.Windows.Forms.Button lessonButton;
        private System.Windows.Forms.Button studentAchievementButton;
    }
}


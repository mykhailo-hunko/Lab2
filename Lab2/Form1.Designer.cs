namespace Lab2
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
            this.university = new System.Windows.Forms.Label();
            this.deleteUniv = new System.Windows.Forms.Button();
            this.addTeach = new System.Windows.Forms.Button();
            this.addStud = new System.Windows.Forms.Button();
            this.addLab = new System.Windows.Forms.Button();
            this.addLec = new System.Windows.Forms.Button();
            this.deleteTeach = new System.Windows.Forms.Button();
            this.deleteStud = new System.Windows.Forms.Button();
            this.faculText = new System.Windows.Forms.Label();
            this.labText = new System.Windows.Forms.Label();
            this.lecText = new System.Windows.Forms.Label();
            this.studentAmountText = new System.Windows.Forms.Label();
            this.teachersText = new System.Windows.Forms.Label();
            this.laborantText = new System.Windows.Forms.Label();
            this.dropFacul = new System.Windows.Forms.ComboBox();
            this.dropUniv = new System.Windows.Forms.ComboBox();
            this.dropStud = new System.Windows.Forms.ComboBox();
            this.dropTeach = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // university
            // 
            this.university.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.university.Location = new System.Drawing.Point(155, 20);
            this.university.Name = "university";
            this.university.Size = new System.Drawing.Size(138, 34);
            this.university.TabIndex = 0;
            this.university.Text = "Университет:";
            this.university.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteUniv
            // 
            this.deleteUniv.Location = new System.Drawing.Point(562, 30);
            this.deleteUniv.Name = "deleteUniv";
            this.deleteUniv.Size = new System.Drawing.Size(75, 23);
            this.deleteUniv.TabIndex = 1;
            this.deleteUniv.Text = "Удалить";
            this.deleteUniv.UseVisualStyleBackColor = true;
            this.deleteUniv.Click += new System.EventHandler(this.deleteUniv_Click);
            // 
            // addTeach
            // 
            this.addTeach.Location = new System.Drawing.Point(367, 248);
            this.addTeach.Name = "addTeach";
            this.addTeach.Size = new System.Drawing.Size(75, 23);
            this.addTeach.TabIndex = 3;
            this.addTeach.Text = "Нанять";
            this.addTeach.UseVisualStyleBackColor = true;
            // 
            // addStud
            // 
            this.addStud.Location = new System.Drawing.Point(367, 206);
            this.addStud.Name = "addStud";
            this.addStud.Size = new System.Drawing.Size(75, 23);
            this.addStud.TabIndex = 4;
            this.addStud.Text = "Зачислить";
            this.addStud.UseVisualStyleBackColor = true;
            // 
            // addLab
            // 
            this.addLab.Location = new System.Drawing.Point(367, 117);
            this.addLab.Name = "addLab";
            this.addLab.Size = new System.Drawing.Size(75, 23);
            this.addLab.TabIndex = 5;
            this.addLab.Text = "Добавить";
            this.addLab.UseVisualStyleBackColor = true;
            // 
            // addLec
            // 
            this.addLec.Location = new System.Drawing.Point(367, 161);
            this.addLec.Name = "addLec";
            this.addLec.Size = new System.Drawing.Size(75, 23);
            this.addLec.TabIndex = 6;
            this.addLec.Text = "Добавить";
            this.addLec.UseVisualStyleBackColor = true;
            // 
            // deleteTeach
            // 
            this.deleteTeach.Location = new System.Drawing.Point(480, 249);
            this.deleteTeach.Name = "deleteTeach";
            this.deleteTeach.Size = new System.Drawing.Size(75, 23);
            this.deleteTeach.TabIndex = 7;
            this.deleteTeach.Text = "Уволить";
            this.deleteTeach.UseVisualStyleBackColor = true;
            // 
            // deleteStud
            // 
            this.deleteStud.Location = new System.Drawing.Point(480, 207);
            this.deleteStud.Name = "deleteStud";
            this.deleteStud.Size = new System.Drawing.Size(75, 23);
            this.deleteStud.TabIndex = 8;
            this.deleteStud.Text = "Отчислить";
            this.deleteStud.UseVisualStyleBackColor = true;
            // 
            // faculText
            // 
            this.faculText.AutoSize = true;
            this.faculText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.faculText.Location = new System.Drawing.Point(28, 79);
            this.faculText.Name = "faculText";
            this.faculText.Size = new System.Drawing.Size(104, 18);
            this.faculText.TabIndex = 9;
            this.faculText.Text = "Факультетов:";
            // 
            // labText
            // 
            this.labText.AutoSize = true;
            this.labText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labText.Location = new System.Drawing.Point(28, 122);
            this.labText.Name = "labText";
            this.labText.Size = new System.Drawing.Size(105, 18);
            this.labText.TabIndex = 10;
            this.labText.Text = "Лабораторий:";
            // 
            // lecText
            // 
            this.lecText.AutoSize = true;
            this.lecText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lecText.Location = new System.Drawing.Point(28, 166);
            this.lecText.Name = "lecText";
            this.lecText.Size = new System.Drawing.Size(110, 18);
            this.lecText.TabIndex = 11;
            this.lecText.Text = "ЛК-аудиторий:";
            // 
            // studentAmountText
            // 
            this.studentAmountText.AutoSize = true;
            this.studentAmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentAmountText.Location = new System.Drawing.Point(28, 207);
            this.studentAmountText.Name = "studentAmountText";
            this.studentAmountText.Size = new System.Drawing.Size(80, 18);
            this.studentAmountText.TabIndex = 12;
            this.studentAmountText.Text = "Студенты:";
            // 
            // teachersText
            // 
            this.teachersText.AutoSize = true;
            this.teachersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachersText.Location = new System.Drawing.Point(31, 249);
            this.teachersText.Name = "teachersText";
            this.teachersText.Size = new System.Drawing.Size(121, 18);
            this.teachersText.TabIndex = 13;
            this.teachersText.Text = "Преподаватели:";
            // 
            // laborantText
            // 
            this.laborantText.AutoSize = true;
            this.laborantText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laborantText.Location = new System.Drawing.Point(31, 294);
            this.laborantText.Name = "laborantText";
            this.laborantText.Size = new System.Drawing.Size(131, 18);
            this.laborantText.TabIndex = 14;
            this.laborantText.Text = "Количество УВП:";
            // 
            // dropFacul
            // 
            this.dropFacul.AllowDrop = true;
            this.dropFacul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropFacul.FormattingEnabled = true;
            this.dropFacul.Location = new System.Drawing.Point(172, 76);
            this.dropFacul.Name = "dropFacul";
            this.dropFacul.Size = new System.Drawing.Size(121, 21);
            this.dropFacul.TabIndex = 15;
            // 
            // dropUniv
            // 
            this.dropUniv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropUniv.FormattingEnabled = true;
            this.dropUniv.Location = new System.Drawing.Point(321, 30);
            this.dropUniv.Name = "dropUniv";
            this.dropUniv.Size = new System.Drawing.Size(121, 21);
            this.dropUniv.TabIndex = 16;
            this.dropUniv.SelectedIndexChanged += new System.EventHandler(this.dropUniv_SelectedIndexChanged);
            // 
            // dropStud
            // 
            this.dropStud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropStud.FormattingEnabled = true;
            this.dropStud.Location = new System.Drawing.Point(172, 204);
            this.dropStud.Name = "dropStud";
            this.dropStud.Size = new System.Drawing.Size(121, 21);
            this.dropStud.TabIndex = 17;
            // 
            // dropTeach
            // 
            this.dropTeach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropTeach.FormattingEnabled = true;
            this.dropTeach.Location = new System.Drawing.Point(172, 245);
            this.dropTeach.Name = "dropTeach";
            this.dropTeach.Size = new System.Drawing.Size(121, 21);
            this.dropTeach.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 367);
            this.Controls.Add(this.dropTeach);
            this.Controls.Add(this.dropStud);
            this.Controls.Add(this.dropUniv);
            this.Controls.Add(this.dropFacul);
            this.Controls.Add(this.laborantText);
            this.Controls.Add(this.teachersText);
            this.Controls.Add(this.studentAmountText);
            this.Controls.Add(this.lecText);
            this.Controls.Add(this.labText);
            this.Controls.Add(this.faculText);
            this.Controls.Add(this.deleteStud);
            this.Controls.Add(this.deleteTeach);
            this.Controls.Add(this.addLec);
            this.Controls.Add(this.addLab);
            this.Controls.Add(this.addStud);
            this.Controls.Add(this.addTeach);
            this.Controls.Add(this.deleteUniv);
            this.Controls.Add(this.university);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label university;
        private System.Windows.Forms.Button deleteUniv;
        private System.Windows.Forms.Button addTeach;
        private System.Windows.Forms.Button addStud;
        private System.Windows.Forms.Button addLab;
        private System.Windows.Forms.Button addLec;
        private System.Windows.Forms.Button deleteTeach;
        private System.Windows.Forms.Button deleteStud;
        private System.Windows.Forms.Label faculText;
        private System.Windows.Forms.Label labText;
        private System.Windows.Forms.Label lecText;
        private System.Windows.Forms.Label studentAmountText;
        private System.Windows.Forms.Label teachersText;
        private System.Windows.Forms.Label laborantText;
        private System.Windows.Forms.ComboBox dropFacul;
        private System.Windows.Forms.ComboBox dropUniv;
        private System.Windows.Forms.ComboBox dropStud;
        private System.Windows.Forms.ComboBox dropTeach;
    }
}


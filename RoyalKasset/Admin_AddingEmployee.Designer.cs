namespace RoyalKasset
{
    partial class Admin_AddingEmployee
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWorkObject = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblSeriaNumberPassport = new System.Windows.Forms.Label();
            this.lblINN = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.cbWorkObject = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mtbSeriaNomerOfPassport = new System.Windows.Forms.MaskedTextBox();
            this.mtbINN = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RoyalKasset.Properties.Resources.Стандартная_форма;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1100, 650);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblWorkObject
            // 
            this.lblWorkObject.AutoSize = true;
            this.lblWorkObject.BackColor = System.Drawing.Color.White;
            this.lblWorkObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkObject.Location = new System.Drawing.Point(591, 376);
            this.lblWorkObject.Name = "lblWorkObject";
            this.lblWorkObject.Size = new System.Drawing.Size(148, 24);
            this.lblWorkObject.TabIndex = 59;
            this.lblWorkObject.Text = "Объект работы";
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.Location = new System.Drawing.Point(338, 218);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(246, 28);
            this.tbSurname.TabIndex = 57;
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(341, 403);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(243, 30);
            this.cbRole.TabIndex = 54;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(594, 536);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 39);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(432, 536);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 39);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.BackColor = System.Drawing.Color.White;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMiddleName.Location = new System.Drawing.Point(335, 309);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(98, 24);
            this.lblMiddleName.TabIndex = 49;
            this.lblMiddleName.Text = "Отчество";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(337, 249);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 24);
            this.lblName.TabIndex = 48;
            this.lblName.Text = "Имя";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.White;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRole.Location = new System.Drawing.Point(337, 376);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(112, 24);
            this.lblRole.TabIndex = 47;
            this.lblRole.Text = "Должность";
            // 
            // lblSeriaNumberPassport
            // 
            this.lblSeriaNumberPassport.AutoSize = true;
            this.lblSeriaNumberPassport.BackColor = System.Drawing.Color.White;
            this.lblSeriaNumberPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeriaNumberPassport.Location = new System.Drawing.Point(591, 191);
            this.lblSeriaNumberPassport.Name = "lblSeriaNumberPassport";
            this.lblSeriaNumberPassport.Size = new System.Drawing.Size(233, 24);
            this.lblSeriaNumberPassport.TabIndex = 46;
            this.lblSeriaNumberPassport.Text = "Серия и номер паспорта";
            // 
            // lblINN
            // 
            this.lblINN.AutoSize = true;
            this.lblINN.BackColor = System.Drawing.Color.White;
            this.lblINN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblINN.Location = new System.Drawing.Point(591, 312);
            this.lblINN.Name = "lblINN";
            this.lblINN.Size = new System.Drawing.Size(49, 24);
            this.lblINN.TabIndex = 45;
            this.lblINN.Text = "ИНН";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.BackColor = System.Drawing.Color.White;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirthday.Location = new System.Drawing.Point(591, 249);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(150, 24);
            this.lblBirthday.TabIndex = 44;
            this.lblBirthday.Text = "Дата рождения";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.White;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.Location = new System.Drawing.Point(337, 191);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(91, 24);
            this.lblSurname.TabIndex = 43;
            this.lblSurname.Text = "Фамилия";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.BackColor = System.Drawing.Color.White;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployee.Location = new System.Drawing.Point(495, 125);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(150, 31);
            this.lblEmployee.TabIndex = 42;
            this.lblEmployee.Text = "Сотрудник";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Image = global::RoyalKasset.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(17, 36);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(150, 120);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 41;
            this.pbLogo.TabStop = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(595, 476);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(225, 28);
            this.tbPassword.TabIndex = 64;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(591, 449);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 24);
            this.lblPassword.TabIndex = 63;
            this.lblPassword.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(339, 476);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(246, 28);
            this.tbLogin.TabIndex = 62;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(337, 449);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(64, 24);
            this.lblLogin.TabIndex = 61;
            this.lblLogin.Text = "Логин";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(338, 280);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(246, 28);
            this.tbName.TabIndex = 65;
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMiddleName.Location = new System.Drawing.Point(339, 336);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(246, 28);
            this.tbMiddleName.TabIndex = 66;
            // 
            // cbWorkObject
            // 
            this.cbWorkObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbWorkObject.FormattingEnabled = true;
            this.cbWorkObject.Location = new System.Drawing.Point(594, 403);
            this.cbWorkObject.Name = "cbWorkObject";
            this.cbWorkObject.Size = new System.Drawing.Size(226, 30);
            this.cbWorkObject.TabIndex = 67;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(595, 281);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 28);
            this.dateTimePicker1.TabIndex = 68;
            // 
            // mtbSeriaNomerOfPassport
            // 
            this.mtbSeriaNomerOfPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbSeriaNomerOfPassport.Location = new System.Drawing.Point(595, 218);
            this.mtbSeriaNomerOfPassport.Mask = "0000000000";
            this.mtbSeriaNomerOfPassport.Name = "mtbSeriaNomerOfPassport";
            this.mtbSeriaNomerOfPassport.Size = new System.Drawing.Size(224, 28);
            this.mtbSeriaNomerOfPassport.TabIndex = 69;
            // 
            // mtbINN
            // 
            this.mtbINN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbINN.Location = new System.Drawing.Point(595, 336);
            this.mtbINN.Mask = "000000000000";
            this.mtbINN.Name = "mtbINN";
            this.mtbINN.Size = new System.Drawing.Size(224, 28);
            this.mtbINN.TabIndex = 70;
            // 
            // Admin_AddingEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.mtbINN);
            this.Controls.Add(this.mtbSeriaNomerOfPassport);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbWorkObject);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblWorkObject);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblSeriaNumberPassport);
            this.Controls.Add(this.lblINN);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_AddingEmployee";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_AddingEmployee";
            this.Load += new System.EventHandler(this.Admin_AddingEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWorkObject;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblSeriaNumberPassport;
        private System.Windows.Forms.Label lblINN;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.ComboBox cbWorkObject;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox mtbSeriaNomerOfPassport;
        private System.Windows.Forms.MaskedTextBox mtbINN;
    }
}
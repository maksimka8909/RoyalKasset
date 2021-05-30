namespace RoyalKasset
{
    partial class Autorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            this.lblAutorization = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbxLogin = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbFon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutorization
            // 
            this.lblAutorization.AutoSize = true;
            this.lblAutorization.BackColor = System.Drawing.Color.White;
            this.lblAutorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAutorization.Location = new System.Drawing.Point(451, 239);
            this.lblAutorization.Name = "lblAutorization";
            this.lblAutorization.Size = new System.Drawing.Size(178, 31);
            this.lblAutorization.TabIndex = 2;
            this.lblAutorization.Text = "Авторизация";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(404, 313);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(68, 25);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Логин";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(404, 390);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 25);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Пароль";
            // 
            // txtbxLogin
            // 
            this.txtbxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxLogin.Location = new System.Drawing.Point(409, 341);
            this.txtbxLogin.Name = "txtbxLogin";
            this.txtbxLogin.Size = new System.Drawing.Size(253, 30);
            this.txtbxLogin.TabIndex = 5;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxPassword.Location = new System.Drawing.Point(409, 418);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.PasswordChar = '*';
            this.txtbxPassword.Size = new System.Drawing.Size(253, 30);
            this.txtbxPassword.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(409, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.Location = new System.Drawing.Point(538, 480);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(124, 35);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Image = global::RoyalKasset.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(409, 34);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(253, 153);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // pbFon
            // 
            this.pbFon.Image = global::RoyalKasset.Properties.Resources.Авторизация;
            this.pbFon.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFon.InitialImage")));
            this.pbFon.Location = new System.Drawing.Point(-1, -1);
            this.pbFon.Name = "pbFon";
            this.pbFon.Size = new System.Drawing.Size(1085, 604);
            this.pbFon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFon.TabIndex = 0;
            this.pbFon.TabStop = false;
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblAutorization);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbFon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autorization";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFon;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblAutorization;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbxLogin;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnter;
    }
}


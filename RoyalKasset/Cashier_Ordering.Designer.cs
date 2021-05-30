namespace RoyalKasset
{
    partial class Cashier_Ordering
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
            this.pbFon = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblOrdering = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblSeriaNumberPassport = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnCloseRequest = new System.Windows.Forms.Button();
            this.cbEdition = new System.Windows.Forms.ComboBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.cbNameOfFilm = new System.Windows.Forms.ComboBox();
            this.lblNameOfFilm = new System.Windows.Forms.Label();
            this.mtbSeriaNumberOfPassport = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFon
            // 
            this.pbFon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFon.Image = global::RoyalKasset.Properties.Resources.Стандартная_форма;
            this.pbFon.Location = new System.Drawing.Point(0, 0);
            this.pbFon.Name = "pbFon";
            this.pbFon.Size = new System.Drawing.Size(1100, 650);
            this.pbFon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFon.TabIndex = 0;
            this.pbFon.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Image = global::RoyalKasset.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(31, 26);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(150, 120);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lblOrdering
            // 
            this.lblOrdering.AutoSize = true;
            this.lblOrdering.BackColor = System.Drawing.Color.White;
            this.lblOrdering.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrdering.Location = new System.Drawing.Point(449, 154);
            this.lblOrdering.Name = "lblOrdering";
            this.lblOrdering.Size = new System.Drawing.Size(275, 31);
            this.lblOrdering.TabIndex = 2;
            this.lblOrdering.Text = "Оформление заказа";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.White;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.Location = new System.Drawing.Point(362, 210);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(91, 24);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Фамилия";
            // 
            // lblSeriaNumberPassport
            // 
            this.lblSeriaNumberPassport.AutoSize = true;
            this.lblSeriaNumberPassport.BackColor = System.Drawing.Color.White;
            this.lblSeriaNumberPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeriaNumberPassport.Location = new System.Drawing.Point(585, 212);
            this.lblSeriaNumberPassport.Name = "lblSeriaNumberPassport";
            this.lblSeriaNumberPassport.Size = new System.Drawing.Size(233, 24);
            this.lblSeriaNumberPassport.TabIndex = 4;
            this.lblSeriaNumberPassport.Text = "Серия и номер паспорта";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(362, 271);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 24);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Имя";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.BackColor = System.Drawing.Color.White;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMiddleName.Location = new System.Drawing.Point(362, 342);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(98, 24);
            this.lblMiddleName.TabIndex = 7;
            this.lblMiddleName.Text = "Отчество";
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.BackColor = System.Drawing.Color.White;
            this.lblEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEdition.Location = new System.Drawing.Point(585, 273);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(88, 24);
            this.lblEdition.TabIndex = 9;
            this.lblEdition.Text = "Издание";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(446, 491);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 33);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirmOrder.Location = new System.Drawing.Point(600, 491);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(124, 33);
            this.btnConfirmOrder.TabIndex = 11;
            this.btnConfirmOrder.Text = "Оформить";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.BtnConfirmOrder_Click);
            // 
            // btnCloseRequest
            // 
            this.btnCloseRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseRequest.Location = new System.Drawing.Point(795, 576);
            this.btnCloseRequest.Name = "btnCloseRequest";
            this.btnCloseRequest.Size = new System.Drawing.Size(258, 37);
            this.btnCloseRequest.TabIndex = 12;
            this.btnCloseRequest.Text = "Закрыть заявку";
            this.btnCloseRequest.UseVisualStyleBackColor = true;
            this.btnCloseRequest.Click += new System.EventHandler(this.BtnCloseRequest_Click);
            // 
            // cbEdition
            // 
            this.cbEdition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbEdition.FormattingEnabled = true;
            this.cbEdition.Location = new System.Drawing.Point(586, 300);
            this.cbEdition.Name = "cbEdition";
            this.cbEdition.Size = new System.Drawing.Size(232, 30);
            this.cbEdition.TabIndex = 13;
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMiddleName.Location = new System.Drawing.Point(366, 369);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(203, 28);
            this.tbMiddleName.TabIndex = 16;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(366, 300);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(202, 28);
            this.tbName.TabIndex = 17;
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.Location = new System.Drawing.Point(366, 239);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(201, 28);
            this.tbSurname.TabIndex = 18;
            // 
            // cbNameOfFilm
            // 
            this.cbNameOfFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameOfFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbNameOfFilm.FormattingEnabled = true;
            this.cbNameOfFilm.Location = new System.Drawing.Point(586, 369);
            this.cbNameOfFilm.Name = "cbNameOfFilm";
            this.cbNameOfFilm.Size = new System.Drawing.Size(232, 30);
            this.cbNameOfFilm.TabIndex = 14;
            // 
            // lblNameOfFilm
            // 
            this.lblNameOfFilm.AutoSize = true;
            this.lblNameOfFilm.BackColor = System.Drawing.Color.White;
            this.lblNameOfFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameOfFilm.Location = new System.Drawing.Point(585, 344);
            this.lblNameOfFilm.Name = "lblNameOfFilm";
            this.lblNameOfFilm.Size = new System.Drawing.Size(171, 24);
            this.lblNameOfFilm.TabIndex = 8;
            this.lblNameOfFilm.Text = "Название фильма";
            // 
            // mtbSeriaNumberOfPassport
            // 
            this.mtbSeriaNumberOfPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbSeriaNumberOfPassport.Location = new System.Drawing.Point(586, 239);
            this.mtbSeriaNumberOfPassport.Mask = "0000000000";
            this.mtbSeriaNumberOfPassport.Name = "mtbSeriaNumberOfPassport";
            this.mtbSeriaNumberOfPassport.Size = new System.Drawing.Size(232, 28);
            this.mtbSeriaNumberOfPassport.TabIndex = 19;
            // 
            // Cashier_Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.mtbSeriaNumberOfPassport);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.cbNameOfFilm);
            this.Controls.Add(this.cbEdition);
            this.Controls.Add(this.btnCloseRequest);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblEdition);
            this.Controls.Add(this.lblNameOfFilm);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSeriaNumberPassport);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblOrdering);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbFon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cashier_Ordering";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier_Ordering";
            this.Load += new System.EventHandler(this.Cashier_Ordering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFon;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblOrdering;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblSeriaNumberPassport;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnCloseRequest;
        private System.Windows.Forms.ComboBox cbEdition;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.ComboBox cbNameOfFilm;
        private System.Windows.Forms.Label lblNameOfFilm;
        private System.Windows.Forms.MaskedTextBox mtbSeriaNumberOfPassport;
    }
}
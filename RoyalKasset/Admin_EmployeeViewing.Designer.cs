namespace RoyalKasset
{
    partial class Admin_EmployeeViewing
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
            this.dgvListEmployers = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMoreInfo = new System.Windows.Forms.Button();
            this.btnListOfChecks = new System.Windows.Forms.Button();
            this.btnListOfRequest = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblListEmployers = new System.Windows.Forms.Label();
            this.cbObjectOfWork = new System.Windows.Forms.ComboBox();
            this.lblObjectOfWork = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListEmployers
            // 
            this.dgvListEmployers.AllowUserToAddRows = false;
            this.dgvListEmployers.AllowUserToDeleteRows = false;
            this.dgvListEmployers.AllowUserToResizeColumns = false;
            this.dgvListEmployers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListEmployers.BackgroundColor = System.Drawing.Color.White;
            this.dgvListEmployers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListEmployers.Location = new System.Drawing.Point(12, 197);
            this.dgvListEmployers.MultiSelect = false;
            this.dgvListEmployers.Name = "dgvListEmployers";
            this.dgvListEmployers.ReadOnly = true;
            this.dgvListEmployers.RowHeadersWidth = 51;
            this.dgvListEmployers.RowTemplate.Height = 24;
            this.dgvListEmployers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListEmployers.Size = new System.Drawing.Size(1076, 354);
            this.dgvListEmployers.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(12, 591);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(307, 557);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(482, 557);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMoreInfo.Location = new System.Drawing.Point(654, 557);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(154, 28);
            this.btnMoreInfo.TabIndex = 5;
            this.btnMoreInfo.Text = "Подробно";
            this.btnMoreInfo.UseVisualStyleBackColor = true;
            this.btnMoreInfo.Click += new System.EventHandler(this.BtnMoreInfo_Click);
            // 
            // btnListOfChecks
            // 
            this.btnListOfChecks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnListOfChecks.Location = new System.Drawing.Point(912, 557);
            this.btnListOfChecks.Name = "btnListOfChecks";
            this.btnListOfChecks.Size = new System.Drawing.Size(176, 28);
            this.btnListOfChecks.TabIndex = 6;
            this.btnListOfChecks.Text = "Список чеков";
            this.btnListOfChecks.UseVisualStyleBackColor = true;
            this.btnListOfChecks.Click += new System.EventHandler(this.BtnListOfChecks_Click);
            // 
            // btnListOfRequest
            // 
            this.btnListOfRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnListOfRequest.Location = new System.Drawing.Point(912, 591);
            this.btnListOfRequest.Name = "btnListOfRequest";
            this.btnListOfRequest.Size = new System.Drawing.Size(176, 29);
            this.btnListOfRequest.TabIndex = 7;
            this.btnListOfRequest.Text = "Список заявок";
            this.btnListOfRequest.UseVisualStyleBackColor = true;
            this.btnListOfRequest.Click += new System.EventHandler(this.BtnListOfRequest_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Image = global::RoyalKasset.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(21, 27);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(227, 141);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // lblListEmployers
            // 
            this.lblListEmployers.AutoSize = true;
            this.lblListEmployers.BackColor = System.Drawing.Color.White;
            this.lblListEmployers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblListEmployers.Location = new System.Drawing.Point(434, 151);
            this.lblListEmployers.Name = "lblListEmployers";
            this.lblListEmployers.Size = new System.Drawing.Size(273, 31);
            this.lblListEmployers.TabIndex = 9;
            this.lblListEmployers.Text = "Список сотрудников";
            // 
            // cbObjectOfWork
            // 
            this.cbObjectOfWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObjectOfWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbObjectOfWork.FormattingEnabled = true;
            this.cbObjectOfWork.Location = new System.Drawing.Point(911, 161);
            this.cbObjectOfWork.Name = "cbObjectOfWork";
            this.cbObjectOfWork.Size = new System.Drawing.Size(146, 28);
            this.cbObjectOfWork.TabIndex = 10;
            this.cbObjectOfWork.SelectedIndexChanged += new System.EventHandler(this.CbObjectOfWork_SelectedIndexChanged);
            // 
            // lblObjectOfWork
            // 
            this.lblObjectOfWork.AutoSize = true;
            this.lblObjectOfWork.BackColor = System.Drawing.Color.White;
            this.lblObjectOfWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblObjectOfWork.Location = new System.Drawing.Point(908, 141);
            this.lblObjectOfWork.Name = "lblObjectOfWork";
            this.lblObjectOfWork.Size = new System.Drawing.Size(139, 20);
            this.lblObjectOfWork.TabIndex = 11;
            this.lblObjectOfWork.Text = "Объект работы";
            // 
            // Admin_EmployeeViewing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::RoyalKasset.Properties.Resources.Стандартная_форма;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.lblObjectOfWork);
            this.Controls.Add(this.cbObjectOfWork);
            this.Controls.Add(this.lblListEmployers);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnListOfRequest);
            this.Controls.Add(this.btnListOfChecks);
            this.Controls.Add(this.btnMoreInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvListEmployers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_EmployeeViewing";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_EmployeeViewing";
            this.Load += new System.EventHandler(this.Admin_EmployeeViewing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListEmployers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMoreInfo;
        private System.Windows.Forms.Button btnListOfChecks;
        private System.Windows.Forms.Button btnListOfRequest;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblListEmployers;
        private System.Windows.Forms.ComboBox cbObjectOfWork;
        private System.Windows.Forms.Label lblObjectOfWork;
    }
}
namespace RoyalKasset
{
    partial class Admin_ListOfApplications
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
            this.lblActivity = new System.Windows.Forms.Label();
            this.cbActivity = new System.Windows.Forms.ComboBox();
            this.lblListRequest = new System.Windows.Forms.Label();
            this.pbFon = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvRequestList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).BeginInit();
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
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.BackColor = System.Drawing.Color.White;
            this.lblActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActivity.Location = new System.Drawing.Point(907, 157);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(109, 20);
            this.lblActivity.TabIndex = 24;
            this.lblActivity.Text = "Активность";
            // 
            // cbActivity
            // 
            this.cbActivity.BackColor = System.Drawing.Color.White;
            this.cbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbActivity.FormattingEnabled = true;
            this.cbActivity.Location = new System.Drawing.Point(911, 180);
            this.cbActivity.Name = "cbActivity";
            this.cbActivity.Size = new System.Drawing.Size(146, 28);
            this.cbActivity.TabIndex = 23;
            this.cbActivity.SelectedIndexChanged += new System.EventHandler(this.CbActivity_SelectedIndexChanged);
            // 
            // lblListRequest
            // 
            this.lblListRequest.AutoSize = true;
            this.lblListRequest.BackColor = System.Drawing.Color.White;
            this.lblListRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblListRequest.Location = new System.Drawing.Point(466, 160);
            this.lblListRequest.Name = "lblListRequest";
            this.lblListRequest.Size = new System.Drawing.Size(201, 31);
            this.lblListRequest.TabIndex = 22;
            this.lblListRequest.Text = "Список заявок";
            // 
            // pbFon
            // 
            this.pbFon.BackColor = System.Drawing.Color.White;
            this.pbFon.Image = global::RoyalKasset.Properties.Resources.Logo;
            this.pbFon.Location = new System.Drawing.Point(21, 46);
            this.pbFon.Name = "pbFon";
            this.pbFon.Size = new System.Drawing.Size(227, 141);
            this.pbFon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFon.TabIndex = 21;
            this.pbFon.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(482, 576);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 28);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // dgvRequestList
            // 
            this.dgvRequestList.AllowUserToAddRows = false;
            this.dgvRequestList.AllowUserToDeleteRows = false;
            this.dgvRequestList.AllowUserToResizeColumns = false;
            this.dgvRequestList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequestList.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestList.Location = new System.Drawing.Point(12, 216);
            this.dgvRequestList.MultiSelect = false;
            this.dgvRequestList.Name = "dgvRequestList";
            this.dgvRequestList.ReadOnly = true;
            this.dgvRequestList.RowHeadersWidth = 51;
            this.dgvRequestList.RowTemplate.Height = 24;
            this.dgvRequestList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequestList.Size = new System.Drawing.Size(1076, 354);
            this.dgvRequestList.TabIndex = 19;
            // 
            // Admin_ListOfApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.cbActivity);
            this.Controls.Add(this.lblListRequest);
            this.Controls.Add(this.pbFon);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvRequestList);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_ListOfApplications";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_ListOfApplications";
            this.Load += new System.EventHandler(this.Admin_ListOfApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.ComboBox cbActivity;
        private System.Windows.Forms.Label lblListRequest;
        private System.Windows.Forms.PictureBox pbFon;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvRequestList;
    }
}
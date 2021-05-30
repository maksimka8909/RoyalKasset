namespace RoyalKasset
{
    partial class Admin_CheckList
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
            this.lblData = new System.Windows.Forms.Label();
            this.lblListEmployers = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvCheckList = new System.Windows.Forms.DataGridView();
            this.cbFilter = new System.Windows.Forms.CheckBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.pbFon = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.White;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblData.Location = new System.Drawing.Point(870, 108);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(52, 20);
            this.lblData.TabIndex = 18;
            this.lblData.Text = "Дата";
            // 
            // lblListEmployers
            // 
            this.lblListEmployers.AutoSize = true;
            this.lblListEmployers.BackColor = System.Drawing.Color.White;
            this.lblListEmployers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblListEmployers.Location = new System.Drawing.Point(466, 141);
            this.lblListEmployers.Name = "lblListEmployers";
            this.lblListEmployers.Size = new System.Drawing.Size(186, 31);
            this.lblListEmployers.TabIndex = 16;
            this.lblListEmployers.Text = "Список чеков";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(482, 557);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 28);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // dgvCheckList
            // 
            this.dgvCheckList.AllowUserToAddRows = false;
            this.dgvCheckList.AllowUserToDeleteRows = false;
            this.dgvCheckList.AllowUserToResizeColumns = false;
            this.dgvCheckList.AllowUserToResizeRows = false;
            this.dgvCheckList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheckList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckList.Location = new System.Drawing.Point(12, 197);
            this.dgvCheckList.MultiSelect = false;
            this.dgvCheckList.Name = "dgvCheckList";
            this.dgvCheckList.ReadOnly = true;
            this.dgvCheckList.RowHeadersVisible = false;
            this.dgvCheckList.RowHeadersWidth = 51;
            this.dgvCheckList.RowTemplate.Height = 24;
            this.dgvCheckList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckList.Size = new System.Drawing.Size(1076, 354);
            this.dgvCheckList.TabIndex = 13;
            // 
            // cbFilter
            // 
            this.cbFilter.AutoSize = true;
            this.cbFilter.BackColor = System.Drawing.Color.White;
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFilter.Location = new System.Drawing.Point(874, 163);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(186, 24);
            this.cbFilter.TabIndex = 23;
            this.cbFilter.Text = "Включить фильтр";
            this.cbFilter.UseVisualStyleBackColor = false;
            this.cbFilter.CheckedChanged += new System.EventHandler(this.CbFilter_CheckedChanged);
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpData.Location = new System.Drawing.Point(874, 131);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 26);
            this.dtpData.TabIndex = 22;
            this.dtpData.ValueChanged += new System.EventHandler(this.DtpData_ValueChanged);
            // 
            // pbFon
            // 
            this.pbFon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFon.BackColor = System.Drawing.Color.Transparent;
            this.pbFon.Image = global::RoyalKasset.Properties.Resources.Logo;
            this.pbFon.Location = new System.Drawing.Point(21, 27);
            this.pbFon.Name = "pbFon";
            this.pbFon.Size = new System.Drawing.Size(227, 141);
            this.pbFon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFon.TabIndex = 15;
            this.pbFon.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::RoyalKasset.Properties.Resources.Стандартная_форма;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(1100, 650);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
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
            // Admin_CheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblListEmployers);
            this.Controls.Add(this.pbFon);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvCheckList);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_CheckList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_CheckList";
            this.Load += new System.EventHandler(this.Admin_CheckList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblListEmployers;
        private System.Windows.Forms.PictureBox pbFon;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvCheckList;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.CheckBox cbFilter;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}
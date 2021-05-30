namespace RoyalKasset
{
    partial class Cashier_Execution
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
            this.lblDataCreate = new System.Windows.Forms.Label();
            this.lblListRequest = new System.Windows.Forms.Label();
            this.pbFon = new System.Windows.Forms.PictureBox();
            this.btnCloseRequest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvListRequest = new System.Windows.Forms.DataGridView();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cbFilter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRequest)).BeginInit();
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
            // lblDataCreate
            // 
            this.lblDataCreate.AutoSize = true;
            this.lblDataCreate.BackColor = System.Drawing.Color.White;
            this.lblDataCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDataCreate.Location = new System.Drawing.Point(873, 104);
            this.lblDataCreate.Name = "lblDataCreate";
            this.lblDataCreate.Size = new System.Drawing.Size(185, 20);
            this.lblDataCreate.TabIndex = 18;
            this.lblDataCreate.Text = "Дата формирования";
            // 
            // lblListRequest
            // 
            this.lblListRequest.AutoSize = true;
            this.lblListRequest.BackColor = System.Drawing.Color.White;
            this.lblListRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblListRequest.Location = new System.Drawing.Point(457, 154);
            this.lblListRequest.Name = "lblListRequest";
            this.lblListRequest.Size = new System.Drawing.Size(201, 31);
            this.lblListRequest.TabIndex = 16;
            this.lblListRequest.Text = "Список заявок";
            // 
            // pbFon
            // 
            this.pbFon.BackColor = System.Drawing.Color.White;
            this.pbFon.Image = global::RoyalKasset.Properties.Resources.Logo;
            this.pbFon.Location = new System.Drawing.Point(21, 29);
            this.pbFon.Name = "pbFon";
            this.pbFon.Size = new System.Drawing.Size(227, 141);
            this.pbFon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFon.TabIndex = 15;
            this.pbFon.TabStop = false;
            // 
            // btnCloseRequest
            // 
            this.btnCloseRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseRequest.Location = new System.Drawing.Point(567, 558);
            this.btnCloseRequest.Name = "btnCloseRequest";
            this.btnCloseRequest.Size = new System.Drawing.Size(162, 29);
            this.btnCloseRequest.TabIndex = 14;
            this.btnCloseRequest.Text = "Закрыть заявку";
            this.btnCloseRequest.UseVisualStyleBackColor = true;
            this.btnCloseRequest.Click += new System.EventHandler(this.BtnCloseRequest_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(378, 558);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 29);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // dgvListRequest
            // 
            this.dgvListRequest.AllowUserToAddRows = false;
            this.dgvListRequest.AllowUserToDeleteRows = false;
            this.dgvListRequest.AllowUserToResizeColumns = false;
            this.dgvListRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListRequest.BackgroundColor = System.Drawing.Color.White;
            this.dgvListRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListRequest.Location = new System.Drawing.Point(12, 199);
            this.dgvListRequest.MultiSelect = false;
            this.dgvListRequest.Name = "dgvListRequest";
            this.dgvListRequest.ReadOnly = true;
            this.dgvListRequest.RowHeadersWidth = 51;
            this.dgvListRequest.RowTemplate.Height = 24;
            this.dgvListRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListRequest.Size = new System.Drawing.Size(1076, 354);
            this.dgvListRequest.TabIndex = 12;
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpData.Location = new System.Drawing.Point(877, 131);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 26);
            this.dtpData.TabIndex = 19;
            this.dtpData.ValueChanged += new System.EventHandler(this.DtpData_ValueChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.AutoSize = true;
            this.cbFilter.BackColor = System.Drawing.Color.White;
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFilter.Location = new System.Drawing.Point(877, 163);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(186, 24);
            this.cbFilter.TabIndex = 20;
            this.cbFilter.Text = "Включить фильтр";
            this.cbFilter.UseVisualStyleBackColor = false;
            this.cbFilter.CheckedChanged += new System.EventHandler(this.CbFilter_CheckedChanged);
            // 
            // Cashier_Execution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblDataCreate);
            this.Controls.Add(this.lblListRequest);
            this.Controls.Add(this.pbFon);
            this.Controls.Add(this.btnCloseRequest);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvListRequest);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cashier_Execution";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier_Execution";
            this.Load += new System.EventHandler(this.Cashier_Execution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDataCreate;
        private System.Windows.Forms.Label lblListRequest;
        private System.Windows.Forms.PictureBox pbFon;
        private System.Windows.Forms.Button btnCloseRequest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvListRequest;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.CheckBox cbFilter;
    }
}
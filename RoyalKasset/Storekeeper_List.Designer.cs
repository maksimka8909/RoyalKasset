namespace RoyalKasset
{
    partial class Storekeeper_List
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
            this.lblYearOfRealese = new System.Windows.Forms.Label();
            this.cbYearOfRealese = new System.Windows.Forms.ComboBox();
            this.lblListVideo = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnMoreInfo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvListEmployers = new System.Windows.Forms.DataGridView();
            this.lblTypeOfCarier = new System.Windows.Forms.Label();
            this.cbTypeOfCarrier = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cbGenge = new System.Windows.Forms.ComboBox();
            this.lblEdition = new System.Windows.Forms.Label();
            this.cbEdition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployers)).BeginInit();
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
            // lblYearOfRealese
            // 
            this.lblYearOfRealese.AutoSize = true;
            this.lblYearOfRealese.BackColor = System.Drawing.Color.White;
            this.lblYearOfRealese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYearOfRealese.Location = new System.Drawing.Point(780, 142);
            this.lblYearOfRealese.Name = "lblYearOfRealese";
            this.lblYearOfRealese.Size = new System.Drawing.Size(97, 18);
            this.lblYearOfRealese.TabIndex = 20;
            this.lblYearOfRealese.Text = "Год выпуска";
            // 
            // cbYearOfRealese
            // 
            this.cbYearOfRealese.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYearOfRealese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbYearOfRealese.FormattingEnabled = true;
            this.cbYearOfRealese.Location = new System.Drawing.Point(783, 163);
            this.cbYearOfRealese.Name = "cbYearOfRealese";
            this.cbYearOfRealese.Size = new System.Drawing.Size(126, 26);
            this.cbYearOfRealese.TabIndex = 19;
            this.cbYearOfRealese.SelectedIndexChanged += new System.EventHandler(this.CbYearOfRealese_SelectedIndexChanged);
            // 
            // lblListVideo
            // 
            this.lblListVideo.AutoSize = true;
            this.lblListVideo.BackColor = System.Drawing.Color.White;
            this.lblListVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblListVideo.Location = new System.Drawing.Point(389, 153);
            this.lblListVideo.Name = "lblListVideo";
            this.lblListVideo.Size = new System.Drawing.Size(339, 31);
            this.lblListVideo.TabIndex = 18;
            this.lblListVideo.Text = "Список видеоматериалов";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Image = global::RoyalKasset.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(21, 29);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(227, 141);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 17;
            this.pbLogo.TabStop = false;
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.Location = new System.Drawing.Point(654, 559);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(154, 28);
            this.btnMoreInfo.TabIndex = 16;
            this.btnMoreInfo.Text = "Подробно";
            this.btnMoreInfo.UseVisualStyleBackColor = true;
            this.btnMoreInfo.Click += new System.EventHandler(this.BtnMoreInfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(482, 559);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 28);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(307, 559);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 28);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 593);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 29);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // dgvListEmployers
            // 
            this.dgvListEmployers.AllowUserToAddRows = false;
            this.dgvListEmployers.AllowUserToDeleteRows = false;
            this.dgvListEmployers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListEmployers.BackgroundColor = System.Drawing.Color.White;
            this.dgvListEmployers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListEmployers.Location = new System.Drawing.Point(12, 199);
            this.dgvListEmployers.MultiSelect = false;
            this.dgvListEmployers.Name = "dgvListEmployers";
            this.dgvListEmployers.ReadOnly = true;
            this.dgvListEmployers.RowHeadersWidth = 51;
            this.dgvListEmployers.RowTemplate.Height = 24;
            this.dgvListEmployers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListEmployers.Size = new System.Drawing.Size(1076, 354);
            this.dgvListEmployers.TabIndex = 12;
            // 
            // lblTypeOfCarier
            // 
            this.lblTypeOfCarier.AutoSize = true;
            this.lblTypeOfCarier.BackColor = System.Drawing.Color.White;
            this.lblTypeOfCarier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTypeOfCarier.Location = new System.Drawing.Point(915, 142);
            this.lblTypeOfCarier.Name = "lblTypeOfCarier";
            this.lblTypeOfCarier.Size = new System.Drawing.Size(102, 18);
            this.lblTypeOfCarier.TabIndex = 22;
            this.lblTypeOfCarier.Text = "Тип носителя";
            // 
            // cbTypeOfCarrier
            // 
            this.cbTypeOfCarrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeOfCarrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTypeOfCarrier.FormattingEnabled = true;
            this.cbTypeOfCarrier.Location = new System.Drawing.Point(915, 163);
            this.cbTypeOfCarrier.Name = "cbTypeOfCarrier";
            this.cbTypeOfCarrier.Size = new System.Drawing.Size(168, 26);
            this.cbTypeOfCarrier.TabIndex = 21;
            this.cbTypeOfCarrier.SelectedIndexChanged += new System.EventHandler(this.CbTypeOfCarrier_SelectedIndexChanged);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.White;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGenre.Location = new System.Drawing.Point(780, 95);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(46, 18);
            this.lblGenre.TabIndex = 24;
            this.lblGenre.Text = "Жанр";
            // 
            // cbGenge
            // 
            this.cbGenge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbGenge.FormattingEnabled = true;
            this.cbGenge.Location = new System.Drawing.Point(783, 116);
            this.cbGenge.Name = "cbGenge";
            this.cbGenge.Size = new System.Drawing.Size(126, 26);
            this.cbGenge.TabIndex = 23;
            this.cbGenge.SelectedIndexChanged += new System.EventHandler(this.CbGenge_SelectedIndexChanged);
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.BackColor = System.Drawing.Color.White;
            this.lblEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEdition.Location = new System.Drawing.Point(912, 96);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(68, 18);
            this.lblEdition.TabIndex = 26;
            this.lblEdition.Text = "Издание";
            // 
            // cbEdition
            // 
            this.cbEdition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbEdition.FormattingEnabled = true;
            this.cbEdition.Location = new System.Drawing.Point(915, 116);
            this.cbEdition.Name = "cbEdition";
            this.cbEdition.Size = new System.Drawing.Size(168, 26);
            this.cbEdition.TabIndex = 25;
            this.cbEdition.SelectedIndexChanged += new System.EventHandler(this.CbEdition_SelectedIndexChanged);
            // 
            // Storekeeper_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.lblEdition);
            this.Controls.Add(this.cbEdition);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.cbGenge);
            this.Controls.Add(this.lblTypeOfCarier);
            this.Controls.Add(this.cbTypeOfCarrier);
            this.Controls.Add(this.lblYearOfRealese);
            this.Controls.Add(this.cbYearOfRealese);
            this.Controls.Add(this.lblListVideo);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnMoreInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvListEmployers);
            this.Controls.Add(this.pbFon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Storekeeper_List";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storekeeper_List";
            this.Load += new System.EventHandler(this.Storekeeper_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFon;
        private System.Windows.Forms.Label lblYearOfRealese;
        private System.Windows.Forms.ComboBox cbYearOfRealese;
        private System.Windows.Forms.Label lblListVideo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnMoreInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvListEmployers;
        private System.Windows.Forms.Label lblTypeOfCarier;
        private System.Windows.Forms.ComboBox cbTypeOfCarrier;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cbGenge;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.ComboBox cbEdition;
    }
}
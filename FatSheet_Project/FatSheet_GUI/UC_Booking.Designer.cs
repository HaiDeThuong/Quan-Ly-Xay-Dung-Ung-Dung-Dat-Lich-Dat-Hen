namespace FatSheet_GUI
{
    partial class UC_Booking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ff = new System.Windows.Forms.Label();
            this.cboBarber = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.colInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG ĐẶT LỊCH CẮT TÓC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "1. Chọn dịch vụ muốn làm:";
            // 
            // cboService
            // 
            this.cboService.BackColor = System.Drawing.SystemColors.Window;
            this.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(274, 66);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(182, 33);
            this.cboService.TabIndex = 3;
            this.cboService.SelectedIndexChanged += new System.EventHandler(this.cboService_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "3. Chọn thời gian:";
            // 
            // ff
            // 
            this.ff.AutoSize = true;
            this.ff.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ff.ForeColor = System.Drawing.Color.Black;
            this.ff.Location = new System.Drawing.Point(21, 159);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(195, 25);
            this.ff.TabIndex = 6;
            this.ff.Text = "2. Chọn Barber (Thợ):";
            // 
            // cboBarber
            // 
            this.cboBarber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBarber.FormattingEnabled = true;
            this.cboBarber.Location = new System.Drawing.Point(274, 159);
            this.cboBarber.Name = "cboBarber";
            this.cboBarber.Size = new System.Drawing.Size(189, 33);
            this.cboBarber.TabIndex = 7;
            this.cboBarber.SelectedIndexChanged += new System.EventHandler(this.cboBarber_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(361, 264);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 9;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // cboTime
            // 
            this.cboTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.ItemHeight = 16;
            this.cboTime.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00"});
            this.cboTime.Location = new System.Drawing.Point(274, 262);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(67, 24);
            this.cboTime.TabIndex = 10;
            this.cboTime.SelectedIndexChanged += new System.EventHandler(this.cboTime_SelectedIndexChanged);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(106, 316);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(437, 120);
            this.txtNote.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.dgvPreview);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(567, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 456);
            this.panel1.TabIndex = 13;
            // 
            // dgvPreview
            // 
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreview.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInfo,
            this.colValue});
            this.dgvPreview.EnableHeadersVisualStyles = false;
            this.dgvPreview.GridColor = System.Drawing.Color.Silver;
            this.dgvPreview.Location = new System.Drawing.Point(31, 66);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.ReadOnly = true;
            this.dgvPreview.RowHeadersVisible = false;
            this.dgvPreview.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvPreview.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPreview.RowTemplate.Height = 24;
            this.dgvPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreview.Size = new System.Drawing.Size(581, 286);
            this.dgvPreview.TabIndex = 17;
            // 
            // colInfo
            // 
            this.colInfo.HeaderText = "Hạng mục";
            this.colInfo.MinimumWidth = 6;
            this.colInfo.Name = "colInfo";
            this.colInfo.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.HeaderText = "Chi tiết";
            this.colValue.MinimumWidth = 6;
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirm.Location = new System.Drawing.Point(177, 383);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(286, 53);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "XÁC NHẬN ĐẶT LỊCH";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "THÔNG TIN LỊCH HẸN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ghi Chú";
            // 
            // UC_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboBarber);
            this.Controls.Add(this.ff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UC_Booking";
            this.Size = new System.Drawing.Size(1197, 456);
            this.Load += new System.EventHandler(this.UC_Booking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ff;
        private System.Windows.Forms.ComboBox cboBarber;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

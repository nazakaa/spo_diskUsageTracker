namespace DriveTracker
{
    partial class TrackInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackInfo));
            this.bttnTrack = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAmountValue = new System.Windows.Forms.Label();
            this.lblLetterValue = new System.Windows.Forms.Label();
            this.lblLetter = new System.Windows.Forms.Label();
            this.lblTracking = new System.Windows.Forms.Label();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnTrack
            // 
            this.bttnTrack.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bttnTrack.Location = new System.Drawing.Point(15, 158);
            this.bttnTrack.Name = "bttnTrack";
            this.bttnTrack.Size = new System.Drawing.Size(75, 23);
            this.bttnTrack.TabIndex = 2;
            this.bttnTrack.Text = "Track";
            this.bttnTrack.UseVisualStyleBackColor = true;
            this.bttnTrack.Click += new System.EventHandler(this.bttnTrack_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Location = new System.Drawing.Point(197, 158);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 3;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.lblAmount, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lblAmountValue, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lblLetterValue, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblLetter, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblTracking, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.chkBox, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(284, 50);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(4, 36);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(88, 13);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Tracking Amount";
            // 
            // lblAmountValue
            // 
            this.lblAmountValue.AutoSize = true;
            this.lblAmountValue.Location = new System.Drawing.Point(99, 36);
            this.lblAmountValue.Name = "lblAmountValue";
            this.lblAmountValue.Size = new System.Drawing.Size(0, 13);
            this.lblAmountValue.TabIndex = 4;
            // 
            // lblLetterValue
            // 
            this.lblLetterValue.AutoSize = true;
            this.lblLetterValue.Location = new System.Drawing.Point(99, 1);
            this.lblLetterValue.Name = "lblLetterValue";
            this.lblLetterValue.Size = new System.Drawing.Size(0, 13);
            this.lblLetterValue.TabIndex = 1;
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Location = new System.Drawing.Point(4, 1);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(34, 13);
            this.lblLetter.TabIndex = 0;
            this.lblLetter.Text = "Letter";
            // 
            // lblTracking
            // 
            this.lblTracking.AutoSize = true;
            this.lblTracking.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTracking.Location = new System.Drawing.Point(4, 15);
            this.lblTracking.Name = "lblTracking";
            this.lblTracking.Size = new System.Drawing.Size(49, 20);
            this.lblTracking.TabIndex = 2;
            this.lblTracking.Text = "Tracking";
            // 
            // chkBox
            // 
            this.chkBox.AutoCheck = false;
            this.chkBox.AutoSize = true;
            this.chkBox.Location = new System.Drawing.Point(99, 18);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(15, 14);
            this.chkBox.TabIndex = 6;
            this.chkBox.TabStop = false;
            this.chkBox.UseVisualStyleBackColor = true;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(55, 86);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 5;
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(161, 85);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(76, 21);
            this.comboBox.TabIndex = 6;
            // 
            // TrackInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 198);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrackInfo";
            this.Text = "Tracking Info";
            this.Load += new System.EventHandler(this.TrackInfo_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnTrack;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblAmountValue;
        private System.Windows.Forms.Label lblLetterValue;
        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.Label lblTracking;
        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.ComboBox comboBox;
    }
}
namespace DSA2021G43
{
    partial class ViewAdminReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.view_btn = new System.Windows.Forms.Button();
            this.type_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lastDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 52);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(785, 446);
            this.dataGridView.TabIndex = 25;
            // 
            // view_btn
            // 
            this.view_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.view_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_btn.ForeColor = System.Drawing.Color.White;
            this.view_btn.Location = new System.Drawing.Point(652, 10);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(54, 34);
            this.view_btn.TabIndex = 24;
            this.view_btn.Text = "view";
            this.view_btn.UseVisualStyleBackColor = false;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // type_cb
            // 
            this.type_cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.type_cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.type_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.type_cb.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_cb.ForeColor = System.Drawing.Color.White;
            this.type_cb.FormattingEnabled = true;
            this.type_cb.Items.AddRange(new object[] {
            "Call Receiver",
            "Driver",
            "Patient",
            "Ambulance"});
            this.type_cb.Location = new System.Drawing.Point(547, 11);
            this.type_cb.Name = "type_cb";
            this.type_cb.Size = new System.Drawing.Size(99, 32);
            this.type_cb.TabIndex = 23;
            this.type_cb.Text = "--type--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Start Date:";
            // 
            // startDate
            // 
            this.startDate.CalendarFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Location = new System.Drawing.Point(121, 17);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(143, 20);
            this.startDate.TabIndex = 26;
            this.startDate.Value = new System.DateTime(2021, 12, 9, 15, 8, 52, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(275, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Last Date:";
            // 
            // lastDate
            // 
            this.lastDate.CalendarFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastDate.Location = new System.Drawing.Point(384, 16);
            this.lastDate.Name = "lastDate";
            this.lastDate.Size = new System.Drawing.Size(143, 20);
            this.lastDate.TabIndex = 30;
            this.lastDate.Value = new System.DateTime(2021, 12, 9, 15, 8, 52, 0);
            // 
            // ViewAdminReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 510);
            this.Controls.Add(this.lastDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.type_cb);
            this.Name = "ViewAdminReportsForm";
            this.Text = "ViewAdminReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.ComboBox type_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker lastDate;
    }
}
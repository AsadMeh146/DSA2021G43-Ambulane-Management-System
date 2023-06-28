namespace DSA2021G43
{
    partial class ViewUpdateStaffForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.category_cb = new System.Windows.Forms.ComboBox();
            this.view_btn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // category_cb
            // 
            this.category_cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.category_cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_cb.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_cb.ForeColor = System.Drawing.Color.White;
            this.category_cb.FormattingEnabled = true;
            this.category_cb.Items.AddRange(new object[] {
            "Call Reciever",
            "Driver"});
            this.category_cb.Location = new System.Drawing.Point(12, 12);
            this.category_cb.Name = "category_cb";
            this.category_cb.Size = new System.Drawing.Size(197, 32);
            this.category_cb.TabIndex = 13;
            this.category_cb.Text = "--select-category--";
            // 
            // view_btn
            // 
            this.view_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.view_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_btn.ForeColor = System.Drawing.Color.White;
            this.view_btn.Location = new System.Drawing.Point(215, 12);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(54, 34);
            this.view_btn.TabIndex = 21;
            this.view_btn.Text = "view";
            this.view_btn.UseVisualStyleBackColor = false;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 52);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(785, 373);
            this.dataGridView.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(12, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 30);
            this.label4.TabIndex = 23;
            this.label4.Text = "selected item:";
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(178, 438);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(91, 34);
            this.update_btn.TabIndex = 24;
            this.update_btn.Text = "update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(275, 438);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(91, 34);
            this.delete_btn.TabIndex = 25;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // ViewUpdateStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 510);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.category_cb);
            this.Name = "ViewUpdateStaffForm";
            this.Text = "ViewUpdateStaffForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox category_cb;
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
    }
}
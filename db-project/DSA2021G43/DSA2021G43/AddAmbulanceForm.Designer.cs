namespace DSA2021G43
{
    partial class AddAmbulanceForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.id_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.engine_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hospital_cb = new System.Windows.Forms.ComboBox();
            this.purchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.panel1.Location = new System.Drawing.Point(63, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 3);
            this.panel1.TabIndex = 14;
            // 
            // id_input
            // 
            this.id_input.BackColor = System.Drawing.Color.White;
            this.id_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_input.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_input.ForeColor = System.Drawing.Color.Gray;
            this.id_input.Location = new System.Drawing.Point(63, 38);
            this.id_input.Multiline = true;
            this.id_input.Name = "id_input";
            this.id_input.ReadOnly = true;
            this.id_input.Size = new System.Drawing.Size(197, 34);
            this.id_input.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(58, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.panel2.Location = new System.Drawing.Point(305, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 3);
            this.panel2.TabIndex = 17;
            // 
            // engine_input
            // 
            this.engine_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.engine_input.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engine_input.ForeColor = System.Drawing.Color.Gray;
            this.engine_input.Location = new System.Drawing.Point(305, 38);
            this.engine_input.Multiline = true;
            this.engine_input.Name = "engine_input";
            this.engine_input.Size = new System.Drawing.Size(197, 34);
            this.engine_input.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Engine No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label7.Location = new System.Drawing.Point(537, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "Hospital";
            // 
            // hospital_cb
            // 
            this.hospital_cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.hospital_cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hospital_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hospital_cb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospital_cb.ForeColor = System.Drawing.Color.White;
            this.hospital_cb.FormattingEnabled = true;
            this.hospital_cb.Location = new System.Drawing.Point(542, 45);
            this.hospital_cb.Name = "hospital_cb";
            this.hospital_cb.Size = new System.Drawing.Size(197, 31);
            this.hospital_cb.TabIndex = 22;
            this.hospital_cb.Text = "--select--";
            // 
            // purchaseDate
            // 
            this.purchaseDate.CalendarFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDate.Location = new System.Drawing.Point(60, 136);
            this.purchaseDate.Name = "purchaseDate";
            this.purchaseDate.Size = new System.Drawing.Size(200, 20);
            this.purchaseDate.TabIndex = 24;
            this.purchaseDate.Value = new System.DateTime(2021, 12, 9, 15, 8, 52, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label3.Location = new System.Drawing.Point(58, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "Purchase Date";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(305, 109);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(197, 47);
            this.add_btn.TabIndex = 26;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // AddAmbulanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 510);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.purchaseDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hospital_cb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.engine_input);
            this.Controls.Add(this.id_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddAmbulanceForm";
            this.Text = "AddAmbulanceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox id_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox engine_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox hospital_cb;
        private System.Windows.Forms.DateTimePicker purchaseDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_btn;
    }
}
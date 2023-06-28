namespace DSA2021G43
{
    partial class AddStaffForm
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
            this.name_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.id_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gender_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.phone_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.category_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.shift_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.job_city_cb = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.home_address_input = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.password_input = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.panel1.Location = new System.Drawing.Point(56, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 3);
            this.panel1.TabIndex = 8;
            // 
            // name_input
            // 
            this.name_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_input.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_input.ForeColor = System.Drawing.Color.Gray;
            this.name_input.Location = new System.Drawing.Point(56, 47);
            this.name_input.Multiline = true;
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(197, 34);
            this.name_input.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(51, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.panel2.Location = new System.Drawing.Point(311, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 3);
            this.panel2.TabIndex = 11;
            // 
            // id_input
            // 
            this.id_input.BackColor = System.Drawing.Color.White;
            this.id_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_input.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_input.ForeColor = System.Drawing.Color.Gray;
            this.id_input.Location = new System.Drawing.Point(311, 49);
            this.id_input.Multiline = true;
            this.id_input.Name = "id_input";
            this.id_input.ReadOnly = true;
            this.id_input.Size = new System.Drawing.Size(197, 34);
            this.id_input.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(306, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // gender_cb
            // 
            this.gender_cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.gender_cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gender_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gender_cb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_cb.ForeColor = System.Drawing.Color.White;
            this.gender_cb.FormattingEnabled = true;
            this.gender_cb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.gender_cb.Location = new System.Drawing.Point(56, 161);
            this.gender_cb.Name = "gender_cb";
            this.gender_cb.Size = new System.Drawing.Size(197, 31);
            this.gender_cb.TabIndex = 12;
            this.gender_cb.Text = "--select--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label3.Location = new System.Drawing.Point(51, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select Gender";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.panel3.Location = new System.Drawing.Point(550, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 3);
            this.panel3.TabIndex = 11;
            // 
            // phone_input
            // 
            this.phone_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone_input.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_input.ForeColor = System.Drawing.Color.Gray;
            this.phone_input.Location = new System.Drawing.Point(550, 47);
            this.phone_input.Multiline = true;
            this.phone_input.Name = "phone_input";
            this.phone_input.Size = new System.Drawing.Size(197, 34);
            this.phone_input.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(545, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone";
            // 
            // category_cb
            // 
            this.category_cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.category_cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_cb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_cb.ForeColor = System.Drawing.Color.White;
            this.category_cb.FormattingEnabled = true;
            this.category_cb.Items.AddRange(new object[] {
            "Call Reciever",
            "Driver"});
            this.category_cb.Location = new System.Drawing.Point(311, 161);
            this.category_cb.Name = "category_cb";
            this.category_cb.Size = new System.Drawing.Size(197, 31);
            this.category_cb.TabIndex = 14;
            this.category_cb.Text = "--select--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label5.Location = new System.Drawing.Point(306, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label6.Location = new System.Drawing.Point(545, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Select Shift";
            // 
            // shift_cb
            // 
            this.shift_cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.shift_cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shift_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shift_cb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shift_cb.ForeColor = System.Drawing.Color.White;
            this.shift_cb.FormattingEnabled = true;
            this.shift_cb.Items.AddRange(new object[] {
            "8:00 am to 4:00 pm",
            "4:00 pm to 12:00 am",
            "12:00 am to 8:00 am"});
            this.shift_cb.Location = new System.Drawing.Point(550, 161);
            this.shift_cb.Name = "shift_cb";
            this.shift_cb.Size = new System.Drawing.Size(197, 31);
            this.shift_cb.TabIndex = 16;
            this.shift_cb.Text = "--select--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label7.Location = new System.Drawing.Point(51, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "Job City";
            // 
            // job_city_cb
            // 
            this.job_city_cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.job_city_cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.job_city_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.job_city_cb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_city_cb.ForeColor = System.Drawing.Color.White;
            this.job_city_cb.FormattingEnabled = true;
            this.job_city_cb.Location = new System.Drawing.Point(56, 254);
            this.job_city_cb.Name = "job_city_cb";
            this.job_city_cb.Size = new System.Drawing.Size(197, 31);
            this.job_city_cb.TabIndex = 18;
            this.job_city_cb.Text = "--select--";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.panel4.Location = new System.Drawing.Point(311, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 3);
            this.panel4.TabIndex = 14;
            // 
            // home_address_input
            // 
            this.home_address_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.home_address_input.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_address_input.ForeColor = System.Drawing.Color.Gray;
            this.home_address_input.Location = new System.Drawing.Point(311, 249);
            this.home_address_input.Multiline = true;
            this.home_address_input.Name = "home_address_input";
            this.home_address_input.Size = new System.Drawing.Size(197, 34);
            this.home_address_input.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label8.Location = new System.Drawing.Point(306, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Home Address";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(311, 362);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(197, 47);
            this.add_btn.TabIndex = 20;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.panel5.Location = new System.Drawing.Point(550, 282);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 3);
            this.panel5.TabIndex = 23;
            // 
            // password_input
            // 
            this.password_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_input.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_input.ForeColor = System.Drawing.Color.Gray;
            this.password_input.Location = new System.Drawing.Point(550, 249);
            this.password_input.Multiline = true;
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(197, 34);
            this.password_input.TabIndex = 22;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.PasswordLabel.Location = new System.Drawing.Point(545, 220);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(94, 26);
            this.PasswordLabel.TabIndex = 21;
            this.PasswordLabel.Text = "Password";
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 510);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.home_address_input);
            this.Controls.Add(this.job_city_cb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shift_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.category_cb);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phone_input);
            this.Controls.Add(this.gender_cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.id_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label2);
            this.Name = "AddStaffForm";
            this.Text = "AddStaffForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox id_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox gender_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox phone_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox category_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox shift_cb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox job_city_cb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox home_address_input;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label PasswordLabel;
    }
}
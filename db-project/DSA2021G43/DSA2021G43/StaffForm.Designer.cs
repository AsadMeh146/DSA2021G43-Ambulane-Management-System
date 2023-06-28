
namespace DSA2021G43
{
    partial class StaffForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.assign_ambulance_btn = new System.Windows.Forms.Button();
            this.answer_call_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.staffPanel = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(209, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(825, 112);
            this.panel3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(85, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ambulance Service Management System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(48, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 45);
            this.label4.TabIndex = 12;
            this.label4.Text = "Staff";
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Location = new System.Drawing.Point(0, 112);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(209, 47);
            this.dashboard_btn.TabIndex = 12;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 112);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DSA2021G43.Properties.Resources.Light1;
            this.pictureBox1.Location = new System.Drawing.Point(36, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.assign_ambulance_btn);
            this.panel1.Controls.Add(this.answer_call_btn);
            this.panel1.Controls.Add(this.dashboard_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 661);
            this.panel1.TabIndex = 16;
            // 
            // assign_ambulance_btn
            // 
            this.assign_ambulance_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.assign_ambulance_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assign_ambulance_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.assign_ambulance_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assign_ambulance_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assign_ambulance_btn.ForeColor = System.Drawing.Color.White;
            this.assign_ambulance_btn.Location = new System.Drawing.Point(0, 206);
            this.assign_ambulance_btn.Name = "assign_ambulance_btn";
            this.assign_ambulance_btn.Size = new System.Drawing.Size(209, 47);
            this.assign_ambulance_btn.TabIndex = 14;
            this.assign_ambulance_btn.Text = "Assign Ambulance";
            this.assign_ambulance_btn.UseVisualStyleBackColor = false;
            this.assign_ambulance_btn.Click += new System.EventHandler(this.assign_ambulance_btn_Click);
            // 
            // answer_call_btn
            // 
            this.answer_call_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.answer_call_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer_call_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer_call_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.answer_call_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer_call_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_call_btn.ForeColor = System.Drawing.Color.White;
            this.answer_call_btn.Location = new System.Drawing.Point(0, 159);
            this.answer_call_btn.Name = "answer_call_btn";
            this.answer_call_btn.Size = new System.Drawing.Size(209, 47);
            this.answer_call_btn.TabIndex = 11;
            this.answer_call_btn.Text = "Answer to the call";
            this.answer_call_btn.UseVisualStyleBackColor = false;
            this.answer_call_btn.Click += new System.EventHandler(this.answer_call_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(0, 613);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(209, 48);
            this.logout_btn.TabIndex = 9;
            this.logout_btn.Text = "Log out";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // staffPanel
            // 
            this.staffPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffPanel.Location = new System.Drawing.Point(209, 112);
            this.staffPanel.Name = "staffPanel";
            this.staffPanel.Size = new System.Drawing.Size(825, 549);
            this.staffPanel.TabIndex = 18;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.staffPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1050, 700);
            this.MinimumSize = new System.Drawing.Size(1050, 700);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button answer_call_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button assign_ambulance_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel staffPanel;
    }
}

namespace DSA2021G43
{
    partial class CallerForm
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
            this.view_map_btn = new System.Windows.Forms.Button();
            this.makecall_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goback_btn = new System.Windows.Forms.Button();
            this.callerPanel = new System.Windows.Forms.Panel();
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
            this.panel3.TabIndex = 20;
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
            this.label4.Size = new System.Drawing.Size(109, 45);
            this.label4.TabIndex = 12;
            this.label4.Text = "Caller";
            // 
            // view_map_btn
            // 
            this.view_map_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.view_map_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_map_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_map_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_map_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_map_btn.ForeColor = System.Drawing.Color.White;
            this.view_map_btn.Location = new System.Drawing.Point(0, 159);
            this.view_map_btn.Name = "view_map_btn";
            this.view_map_btn.Size = new System.Drawing.Size(209, 47);
            this.view_map_btn.TabIndex = 11;
            this.view_map_btn.Text = "View Map";
            this.view_map_btn.UseVisualStyleBackColor = false;
            this.view_map_btn.Click += new System.EventHandler(this.answer_call_btn_Click);
            // 
            // makecall_btn
            // 
            this.makecall_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.makecall_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.makecall_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.makecall_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makecall_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makecall_btn.ForeColor = System.Drawing.Color.White;
            this.makecall_btn.Location = new System.Drawing.Point(0, 112);
            this.makecall_btn.Name = "makecall_btn";
            this.makecall_btn.Size = new System.Drawing.Size(209, 47);
            this.makecall_btn.TabIndex = 12;
            this.makecall_btn.Text = "Make A Call";
            this.makecall_btn.UseVisualStyleBackColor = false;
            this.makecall_btn.Click += new System.EventHandler(this.makecall_btn_Click);
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
            this.panel1.Controls.Add(this.view_map_btn);
            this.panel1.Controls.Add(this.makecall_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.goback_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 661);
            this.panel1.TabIndex = 19;
            // 
            // goback_btn
            // 
            this.goback_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.goback_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goback_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback_btn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback_btn.ForeColor = System.Drawing.Color.White;
            this.goback_btn.Location = new System.Drawing.Point(0, 613);
            this.goback_btn.Name = "goback_btn";
            this.goback_btn.Size = new System.Drawing.Size(209, 48);
            this.goback_btn.TabIndex = 9;
            this.goback_btn.Text = "Go Back";
            this.goback_btn.UseVisualStyleBackColor = false;
            this.goback_btn.Click += new System.EventHandler(this.goback_btn_Click);
            // 
            // callerPanel
            // 
            this.callerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.callerPanel.Location = new System.Drawing.Point(209, 112);
            this.callerPanel.Name = "callerPanel";
            this.callerPanel.Size = new System.Drawing.Size(825, 549);
            this.callerPanel.TabIndex = 21;
            // 
            // CallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.callerPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1050, 700);
            this.MinimumSize = new System.Drawing.Size(1050, 700);
            this.Name = "CallerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CallerForm";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button view_map_btn;
        private System.Windows.Forms.Button makecall_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button goback_btn;
        private System.Windows.Forms.Panel callerPanel;
    }
}
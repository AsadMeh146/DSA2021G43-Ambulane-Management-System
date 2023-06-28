
namespace DSA2021G43
{
    partial class AssignAmbulanceStaffForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.assign_ambulance_staff_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(90, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Caller Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(365, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 45);
            this.label2.TabIndex = 18;
            this.label2.Text = "City ";
            // 
            // assign_ambulance_staff_btn
            // 
            this.assign_ambulance_staff_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.assign_ambulance_staff_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assign_ambulance_staff_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assign_ambulance_staff_btn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assign_ambulance_staff_btn.ForeColor = System.Drawing.Color.White;
            this.assign_ambulance_staff_btn.Location = new System.Drawing.Point(524, 62);
            this.assign_ambulance_staff_btn.Name = "assign_ambulance_staff_btn";
            this.assign_ambulance_staff_btn.Size = new System.Drawing.Size(209, 47);
            this.assign_ambulance_staff_btn.TabIndex = 19;
            this.assign_ambulance_staff_btn.Text = "Assign";
            this.assign_ambulance_staff_btn.UseVisualStyleBackColor = false;
            this.assign_ambulance_staff_btn.Click += new System.EventHandler(this.assign_ambulance_staff_btn_Click);
            // 
            // AssignAmbulanceStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.assign_ambulance_staff_btn);
            this.Name = "AssignAmbulanceStaffForm";
            this.Text = "AssignAmbulanceStaffForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button assign_ambulance_staff_btn;
    }
}
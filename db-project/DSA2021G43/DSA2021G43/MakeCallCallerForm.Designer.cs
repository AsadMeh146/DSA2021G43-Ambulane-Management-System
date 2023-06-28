
namespace DSA2021G43
{
    partial class MakeCallCallerForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.city_cb = new System.Windows.Forms.ComboBox();
            this.call_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.view_details_label = new System.Windows.Forms.Label();
            this.call_receiver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 3);
            this.panel1.TabIndex = 11;
            // 
            // name_input
            // 
            this.name_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_input.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_input.ForeColor = System.Drawing.Color.Gray;
            this.name_input.Location = new System.Drawing.Point(12, 39);
            this.name_input.Multiline = true;
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(197, 34);
            this.name_input.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.label7.Location = new System.Drawing.Point(281, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 26);
            this.label7.TabIndex = 21;
            this.label7.Text = "City";
            // 
            // city_cb
            // 
            this.city_cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.city_cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.city_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.city_cb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_cb.ForeColor = System.Drawing.Color.White;
            this.city_cb.FormattingEnabled = true;
            this.city_cb.Location = new System.Drawing.Point(286, 46);
            this.city_cb.Name = "city_cb";
            this.city_cb.Size = new System.Drawing.Size(197, 31);
            this.city_cb.TabIndex = 20;
            this.city_cb.Text = "--select--";
            // 
            // call_btn
            // 
            this.call_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.call_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.call_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.call_btn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.call_btn.ForeColor = System.Drawing.Color.White;
            this.call_btn.Location = new System.Drawing.Point(528, 30);
            this.call_btn.Name = "call_btn";
            this.call_btn.Size = new System.Drawing.Size(197, 47);
            this.call_btn.TabIndex = 22;
            this.call_btn.Text = "Call";
            this.call_btn.UseVisualStyleBackColor = false;
            this.call_btn.Click += new System.EventHandler(this.call_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Details:";
            // 
            // view_details_label
            // 
            this.view_details_label.AutoSize = true;
            this.view_details_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_details_label.Location = new System.Drawing.Point(12, 139);
            this.view_details_label.Name = "view_details_label";
            this.view_details_label.Size = new System.Drawing.Size(0, 16);
            this.view_details_label.TabIndex = 24;
            // 
            // call_receiver
            // 
            this.call_receiver.AutoSize = true;
            this.call_receiver.Location = new System.Drawing.Point(757, 494);
            this.call_receiver.Name = "call_receiver";
            this.call_receiver.Size = new System.Drawing.Size(35, 13);
            this.call_receiver.TabIndex = 25;
            this.call_receiver.Text = "label3";
            // 
            // MakeCallCallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 510);
            this.Controls.Add(this.call_receiver);
            this.Controls.Add(this.view_details_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.call_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.city_cb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label2);
            this.Name = "MakeCallCallerForm";
            this.Text = "MakeCallCallerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox city_cb;
        private System.Windows.Forms.Button call_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label view_details_label;
        private System.Windows.Forms.Label call_receiver;
    }
}
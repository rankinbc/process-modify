namespace ProcessModify
{
    partial class ModAddressControl
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
            this.scrollbar = new System.Windows.Forms.HScrollBar();
            this.lbl_value = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_max = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_min = new System.Windows.Forms.TextBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.cb_locked = new System.Windows.Forms.CheckBox();
            this.btn_tie = new System.Windows.Forms.Button();
            this.btn_automate = new System.Windows.Forms.Button();
            this.lbl_actual_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scrollbar
            // 
            this.scrollbar.Location = new System.Drawing.Point(41, 25);
            this.scrollbar.Name = "scrollbar";
            this.scrollbar.Size = new System.Drawing.Size(328, 29);
            this.scrollbar.TabIndex = 14;
            this.scrollbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollbar_Scroll);
            // 
            // lbl_value
            // 
            this.lbl_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value.Location = new System.Drawing.Point(118, 62);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(166, 15);
            this.lbl_value.TabIndex = 19;
            this.lbl_value.Text = "255";
            this.lbl_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "max";
            // 
            // tb_max
            // 
            this.tb_max.Location = new System.Drawing.Point(319, 67);
            this.tb_max.Name = "tb_max";
            this.tb_max.Size = new System.Drawing.Size(50, 20);
            this.tb_max.TabIndex = 17;
            this.tb_max.Text = "255";
            this.tb_max.TextChanged += new System.EventHandler(this.tb_max_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "min";
            // 
            // tb_min
            // 
            this.tb_min.Location = new System.Drawing.Point(62, 67);
            this.tb_min.Name = "tb_min";
            this.tb_min.Size = new System.Drawing.Size(50, 20);
            this.tb_min.TabIndex = 15;
            this.tb_min.Text = "0";
            this.tb_min.TextChanged += new System.EventHandler(this.tb_min_TextChanged);
            // 
            // lbl_type
            // 
            this.lbl_type.Location = new System.Drawing.Point(339, 4);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(40, 13);
            this.lbl_type.TabIndex = 13;
            this.lbl_type.Text = "float";
            this.lbl_type.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(15, 4);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(54, 13);
            this.lbl_address.TabIndex = 10;
            this.lbl_address.Text = "0x000000";
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(3, 4);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(372, 24);
            this.lbl_name.TabIndex = 20;
            this.lbl_name.Text = "float";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_locked
            // 
            this.cb_locked.AutoSize = true;
            this.cb_locked.Location = new System.Drawing.Point(-1, -1);
            this.cb_locked.Name = "cb_locked";
            this.cb_locked.Size = new System.Drawing.Size(15, 14);
            this.cb_locked.TabIndex = 21;
            this.cb_locked.UseVisualStyleBackColor = true;
            this.cb_locked.CheckedChanged += new System.EventHandler(this.cb_locked_CheckedChanged);
            // 
            // btn_tie
            // 
            this.btn_tie.Image = global::ProcessModify.Properties.Resources.tie;
            this.btn_tie.Location = new System.Drawing.Point(5, 60);
            this.btn_tie.Name = "btn_tie";
            this.btn_tie.Size = new System.Drawing.Size(27, 23);
            this.btn_tie.TabIndex = 12;
            this.btn_tie.UseVisualStyleBackColor = true;
            // 
            // btn_automate
            // 
            this.btn_automate.Image = global::ProcessModify.Properties.Resources.animate;
            this.btn_automate.Location = new System.Drawing.Point(5, 31);
            this.btn_automate.Name = "btn_automate";
            this.btn_automate.Size = new System.Drawing.Size(27, 23);
            this.btn_automate.TabIndex = 11;
            this.btn_automate.UseVisualStyleBackColor = true;
            // 
            // lbl_actual_value
            // 
            this.lbl_actual_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actual_value.Location = new System.Drawing.Point(119, 77);
            this.lbl_actual_value.Name = "lbl_actual_value";
            this.lbl_actual_value.Size = new System.Drawing.Size(163, 18);
            this.lbl_actual_value.TabIndex = 22;
            this.lbl_actual_value.Text = "255";
            this.lbl_actual_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_actual_value.Click += new System.EventHandler(this.lbl_actual_value_Click);
            // 
            // ModAddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.lbl_actual_value);
            this.Controls.Add(this.cb_locked);
            this.Controls.Add(this.scrollbar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_max);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_min);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.btn_tie);
            this.Controls.Add(this.btn_automate);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_name);
            this.Name = "ModAddressControl";
            this.Size = new System.Drawing.Size(378, 94);
            this.Load += new System.EventHandler(this.ModAddressControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar scrollbar;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_max;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_min;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Button btn_tie;
        private System.Windows.Forms.Button btn_automate;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.CheckBox cb_locked;
        private System.Windows.Forms.Label lbl_actual_value;
    }
}

namespace ProcessModify
{
    partial class HexEditForm
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tb_jump_address = new System.Windows.Forms.TextBox();
            this.btn_jump = new System.Windows.Forms.Button();
            this.lbl_selected_address = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btn_add_address = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "0    1    2    3    4    5    6    7    8    9    A    B    C    D    E    F";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tb_jump_address
            // 
            this.tb_jump_address.Location = new System.Drawing.Point(-1, 0);
            this.tb_jump_address.Name = "tb_jump_address";
            this.tb_jump_address.Size = new System.Drawing.Size(81, 20);
            this.tb_jump_address.TabIndex = 4;
            // 
            // btn_jump
            // 
            this.btn_jump.Location = new System.Drawing.Point(74, -1);
            this.btn_jump.Name = "btn_jump";
            this.btn_jump.Size = new System.Drawing.Size(44, 23);
            this.btn_jump.TabIndex = 5;
            this.btn_jump.Text = "Jump";
            this.btn_jump.UseVisualStyleBackColor = true;
            this.btn_jump.Click += new System.EventHandler(this.btn_jump_Click);
            // 
            // lbl_selected_address
            // 
            this.lbl_selected_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selected_address.Location = new System.Drawing.Point(12, 2);
            this.lbl_selected_address.Name = "lbl_selected_address";
            this.lbl_selected_address.Size = new System.Drawing.Size(459, 23);
            this.lbl_selected_address.TabIndex = 12;
            this.lbl_selected_address.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Byte",
            "UInt16",
            "Int16",
            "UInt32",
            "Int32",
            "UInt64",
            "Int64",
            "Float",
            "Double"});
            this.cb_type.Location = new System.Drawing.Point(393, 3);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(78, 21);
            this.cb_type.TabIndex = 13;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(459, 45);
            this.vScrollBar1.Maximum = 0;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 417);
            this.vScrollBar1.TabIndex = 14;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // btn_add_address
            // 
            this.btn_add_address.Image = global::ProcessModify.Properties.Resources.add;
            this.btn_add_address.Location = new System.Drawing.Point(445, 521);
            this.btn_add_address.Name = "btn_add_address";
            this.btn_add_address.Size = new System.Drawing.Size(26, 23);
            this.btn_add_address.TabIndex = 15;
            this.btn_add_address.UseVisualStyleBackColor = true;
            this.btn_add_address.Click += new System.EventHandler(this.btn_add_address_Click);
            // 
            // HexEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 626);
            this.Controls.Add(this.btn_add_address);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.btn_jump);
            this.Controls.Add(this.tb_jump_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_selected_address);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HexEditForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HexEditForm";
            this.Load += new System.EventHandler(this.HexEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tb_jump_address;
        private System.Windows.Forms.Button btn_jump;
        private System.Windows.Forms.Label lbl_selected_address;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button btn_add_address;
    }
}
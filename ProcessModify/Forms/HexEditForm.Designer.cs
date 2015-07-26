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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HexEditForm));
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tb_jump_address = new System.Windows.Forms.TextBox();
            this.btn_jump = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hex_panel = new System.Windows.Forms.Panel();
            this.control_box = new System.Windows.Forms.GroupBox();
            this.btn_refresh_process = new System.Windows.Forms.Button();
            this.btn_add_address = new System.Windows.Forms.Button();
            this.btn_jump_to_previous_nonzero = new System.Windows.Forms.Button();
            this.tb_jump_by = new System.Windows.Forms.TextBox();
            this.btn_jump_by = new System.Windows.Forms.Button();
            this.btn_jump_to_next_nonzero = new System.Windows.Forms.Button();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mod_panel = new System.Windows.Forms.Panel();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_random_corrupt = new System.Windows.Forms.Button();
            this.tb_corrupt_chunk = new System.Windows.Forms.TextBox();
            this.tb_corrupt_interval = new System.Windows.Forms.TextBox();
            this.tb_random_max = new System.Windows.Forms.TextBox();
            this.tb_random_min = new System.Windows.Forms.TextBox();
            this.tb_randomize_amount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_randomize = new System.Windows.Forms.Button();
            this.page_up = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.page_down = new System.Windows.Forms.Button();
            this.cb_corrupt_single_chunk = new System.Windows.Forms.CheckBox();
            this.control_box.SuspendLayout();
            this.tab_control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.mod_panel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 104);
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
            this.tb_jump_address.Location = new System.Drawing.Point(377, 10);
            this.tb_jump_address.Name = "tb_jump_address";
            this.tb_jump_address.Size = new System.Drawing.Size(56, 20);
            this.tb_jump_address.TabIndex = 4;
            this.tb_jump_address.Text = "00000000";
            // 
            // btn_jump
            // 
            this.btn_jump.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jump.Location = new System.Drawing.Point(433, 8);
            this.btn_jump.Name = "btn_jump";
            this.btn_jump.Size = new System.Drawing.Size(52, 23);
            this.btn_jump.TabIndex = 5;
            this.btn_jump.Text = "Jump To";
            this.btn_jump.UseVisualStyleBackColor = true;
            this.btn_jump.Click += new System.EventHandler(this.btn_jump_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(460, 121);
            this.vScrollBar1.Maximum = 0;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 417);
            this.vScrollBar1.TabIndex = 14;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hex_panel
            // 
            this.hex_panel.Location = new System.Drawing.Point(0, 121);
            this.hex_panel.Name = "hex_panel";
            this.hex_panel.Size = new System.Drawing.Size(457, 439);
            this.hex_panel.TabIndex = 16;
            // 
            // control_box
            // 
            this.control_box.BackColor = System.Drawing.SystemColors.Control;
            this.control_box.Controls.Add(this.btn_refresh_process);
            this.control_box.Controls.Add(this.btn_add_address);
            this.control_box.Controls.Add(this.btn_jump_to_previous_nonzero);
            this.control_box.Controls.Add(this.tb_jump_by);
            this.control_box.Controls.Add(this.btn_jump_by);
            this.control_box.Controls.Add(this.btn_jump_to_next_nonzero);
            this.control_box.Controls.Add(this.tab_control);
            this.control_box.Controls.Add(this.page_up);
            this.control_box.Controls.Add(this.label1);
            this.control_box.Controls.Add(this.btn_jump);
            this.control_box.Controls.Add(this.page_down);
            this.control_box.Controls.Add(this.tb_jump_address);
            this.control_box.Location = new System.Drawing.Point(0, -9);
            this.control_box.Name = "control_box";
            this.control_box.Size = new System.Drawing.Size(484, 112);
            this.control_box.TabIndex = 19;
            this.control_box.TabStop = false;
            // 
            // btn_refresh_process
            // 
            this.btn_refresh_process.Image = global::ProcessModify.Properties.Resources.refresh;
            this.btn_refresh_process.Location = new System.Drawing.Point(322, 5);
            this.btn_refresh_process.Name = "btn_refresh_process";
            this.btn_refresh_process.Size = new System.Drawing.Size(22, 22);
            this.btn_refresh_process.TabIndex = 16;
            this.btn_refresh_process.UseVisualStyleBackColor = true;
            this.btn_refresh_process.Click += new System.EventHandler(this.btn_refresh_process_Click);
            // 
            // btn_add_address
            // 
            this.btn_add_address.Image = global::ProcessModify.Properties.Resources.add;
            this.btn_add_address.Location = new System.Drawing.Point(343, 5);
            this.btn_add_address.Name = "btn_add_address";
            this.btn_add_address.Size = new System.Drawing.Size(22, 22);
            this.btn_add_address.TabIndex = 15;
            this.btn_add_address.UseVisualStyleBackColor = true;
            this.btn_add_address.Click += new System.EventHandler(this.btn_add_address_Click);
            // 
            // btn_jump_to_previous_nonzero
            // 
            this.btn_jump_to_previous_nonzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jump_to_previous_nonzero.Location = new System.Drawing.Point(383, 56);
            this.btn_jump_to_previous_nonzero.Name = "btn_jump_to_previous_nonzero";
            this.btn_jump_to_previous_nonzero.Size = new System.Drawing.Size(46, 26);
            this.btn_jump_to_previous_nonzero.TabIndex = 25;
            this.btn_jump_to_previous_nonzero.Text = "Prev Nonzero";
            this.btn_jump_to_previous_nonzero.UseVisualStyleBackColor = true;
            this.btn_jump_to_previous_nonzero.Click += new System.EventHandler(this.btn_jump_to_previous_nonzero_Click);
            // 
            // tb_jump_by
            // 
            this.tb_jump_by.Location = new System.Drawing.Point(383, 32);
            this.tb_jump_by.Name = "tb_jump_by";
            this.tb_jump_by.Size = new System.Drawing.Size(50, 20);
            this.tb_jump_by.TabIndex = 23;
            this.tb_jump_by.Text = "16";
            // 
            // btn_jump_by
            // 
            this.btn_jump_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jump_by.Location = new System.Drawing.Point(433, 30);
            this.btn_jump_by.Name = "btn_jump_by";
            this.btn_jump_by.Size = new System.Drawing.Size(52, 23);
            this.btn_jump_by.TabIndex = 24;
            this.btn_jump_by.Text = "Jump By";
            this.btn_jump_by.UseVisualStyleBackColor = true;
            this.btn_jump_by.Click += new System.EventHandler(this.btn_jump_by_Click);
            // 
            // btn_jump_to_next_nonzero
            // 
            this.btn_jump_to_next_nonzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jump_to_next_nonzero.Location = new System.Drawing.Point(383, 81);
            this.btn_jump_to_next_nonzero.Name = "btn_jump_to_next_nonzero";
            this.btn_jump_to_next_nonzero.Size = new System.Drawing.Size(46, 26);
            this.btn_jump_to_next_nonzero.TabIndex = 22;
            this.btn_jump_to_next_nonzero.Text = "Next Nonzero";
            this.btn_jump_to_next_nonzero.UseVisualStyleBackColor = true;
            this.btn_jump_to_next_nonzero.Click += new System.EventHandler(this.btn_jump_to_next_nonzero_Click);
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tabPage1);
            this.tab_control.Controls.Add(this.tabPage2);
            this.tab_control.Location = new System.Drawing.Point(0, 9);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(379, 104);
            this.tab_control.TabIndex = 21;
            this.tab_control.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_control_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mod_panel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(371, 78);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Set Value";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mod_panel
            // 
            this.mod_panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mod_panel.Controls.Add(this.cb_type);
            this.mod_panel.Location = new System.Drawing.Point(0, 0);
            this.mod_panel.Name = "mod_panel";
            this.mod_panel.Size = new System.Drawing.Size(374, 78);
            this.mod_panel.TabIndex = 17;
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
            this.cb_type.Location = new System.Drawing.Point(293, 1);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(78, 21);
            this.cb_type.TabIndex = 13;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btn_random_corrupt);
            this.tabPage2.Controls.Add(this.tb_corrupt_chunk);
            this.tabPage2.Controls.Add(this.tb_corrupt_interval);
            this.tabPage2.Controls.Add(this.tb_random_max);
            this.tabPage2.Controls.Add(this.tb_random_min);
            this.tabPage2.Controls.Add(this.tb_randomize_amount);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btn_randomize);
            this.tabPage2.Controls.Add(this.cb_corrupt_single_chunk);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(371, 78);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Corrupt";
            // 
            // btn_random_corrupt
            // 
            this.btn_random_corrupt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_random_corrupt.Location = new System.Drawing.Point(286, 56);
            this.btn_random_corrupt.Name = "btn_random_corrupt";
            this.btn_random_corrupt.Size = new System.Drawing.Size(82, 21);
            this.btn_random_corrupt.TabIndex = 37;
            this.btn_random_corrupt.Text = "Random Corrupt";
            this.btn_random_corrupt.UseVisualStyleBackColor = true;
            this.btn_random_corrupt.Click += new System.EventHandler(this.btn_random_corrupt_Click);
            // 
            // tb_corrupt_chunk
            // 
            this.tb_corrupt_chunk.Enabled = false;
            this.tb_corrupt_chunk.Location = new System.Drawing.Point(71, 57);
            this.tb_corrupt_chunk.Name = "tb_corrupt_chunk";
            this.tb_corrupt_chunk.Size = new System.Drawing.Size(64, 20);
            this.tb_corrupt_chunk.TabIndex = 36;
            // 
            // tb_corrupt_interval
            // 
            this.tb_corrupt_interval.Enabled = false;
            this.tb_corrupt_interval.Location = new System.Drawing.Point(71, 37);
            this.tb_corrupt_interval.Name = "tb_corrupt_interval";
            this.tb_corrupt_interval.Size = new System.Drawing.Size(64, 20);
            this.tb_corrupt_interval.TabIndex = 34;
            // 
            // tb_random_max
            // 
            this.tb_random_max.Location = new System.Drawing.Point(318, 6);
            this.tb_random_max.Name = "tb_random_max";
            this.tb_random_max.Size = new System.Drawing.Size(30, 20);
            this.tb_random_max.TabIndex = 6;
            this.tb_random_max.Text = "255";
            // 
            // tb_random_min
            // 
            this.tb_random_min.Location = new System.Drawing.Point(257, 6);
            this.tb_random_min.Name = "tb_random_min";
            this.tb_random_min.Size = new System.Drawing.Size(30, 20);
            this.tb_random_min.TabIndex = 3;
            this.tb_random_min.Text = "0";
            // 
            // tb_randomize_amount
            // 
            this.tb_randomize_amount.Location = new System.Drawing.Point(45, 2);
            this.tb_randomize_amount.Name = "tb_randomize_amount";
            this.tb_randomize_amount.Size = new System.Drawing.Size(64, 20);
            this.tb_randomize_amount.TabIndex = 0;
            this.tb_randomize_amount.Text = "1";
            this.tb_randomize_amount.TextChanged += new System.EventHandler(this.tb_randomize_amount_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Chunk size:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Interval:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "and";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "set between";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bytes:";
            // 
            // btn_randomize
            // 
            this.btn_randomize.Location = new System.Drawing.Point(286, 32);
            this.btn_randomize.Name = "btn_randomize";
            this.btn_randomize.Size = new System.Drawing.Size(82, 23);
            this.btn_randomize.TabIndex = 1;
            this.btn_randomize.Text = "Corrupt";
            this.btn_randomize.UseVisualStyleBackColor = true;
            this.btn_randomize.Click += new System.EventHandler(this.btn_randomize_Click);
            // 
            // page_up
            // 
            this.page_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page_up.Image = global::ProcessModify.Properties.Resources.uparrow;
            this.page_up.Location = new System.Drawing.Point(448, 54);
            this.page_up.Name = "page_up";
            this.page_up.Size = new System.Drawing.Size(19, 20);
            this.page_up.TabIndex = 20;
            this.page_up.UseVisualStyleBackColor = true;
            this.page_up.Click += new System.EventHandler(this.page_up_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Page";
            // 
            // page_down
            // 
            this.page_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page_down.Image = global::ProcessModify.Properties.Resources.downarrow;
            this.page_down.Location = new System.Drawing.Point(448, 87);
            this.page_down.Name = "page_down";
            this.page_down.Size = new System.Drawing.Size(19, 20);
            this.page_down.TabIndex = 18;
            this.page_down.UseVisualStyleBackColor = true;
            this.page_down.Click += new System.EventHandler(this.page_down_Click);
            // 
            // cb_corrupt_single_chunk
            // 
            this.cb_corrupt_single_chunk.AutoSize = true;
            this.cb_corrupt_single_chunk.Checked = true;
            this.cb_corrupt_single_chunk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_corrupt_single_chunk.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_corrupt_single_chunk.Location = new System.Drawing.Point(29, 21);
            this.cb_corrupt_single_chunk.Name = "cb_corrupt_single_chunk";
            this.cb_corrupt_single_chunk.Size = new System.Drawing.Size(76, 16);
            this.cb_corrupt_single_chunk.TabIndex = 38;
            this.cb_corrupt_single_chunk.Text = "Single chunk";
            this.cb_corrupt_single_chunk.UseVisualStyleBackColor = true;
            this.cb_corrupt_single_chunk.CheckedChanged += new System.EventHandler(this.cb_corrupt_single_chunk_CheckedChanged);
            // 
            // HexEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(485, 560);
            this.Controls.Add(this.control_box);
            this.Controls.Add(this.hex_panel);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HexEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.HexEditForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexEditForm_KeyPress);
            this.control_box.ResumeLayout(false);
            this.control_box.PerformLayout();
            this.tab_control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.mod_panel.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tb_jump_address;
        private System.Windows.Forms.Button btn_jump;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button btn_add_address;
        private System.Windows.Forms.Panel hex_panel;
        private System.Windows.Forms.Button page_down;
        private System.Windows.Forms.GroupBox control_box;
        private System.Windows.Forms.Button page_up;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_jump_to_next_nonzero;
        private System.Windows.Forms.TextBox tb_jump_by;
        private System.Windows.Forms.Button btn_jump_by;
        private System.Windows.Forms.Button btn_jump_to_previous_nonzero;
        private System.Windows.Forms.Button btn_refresh_process;
        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel mod_panel;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_corrupt_chunk;
        private System.Windows.Forms.TextBox tb_corrupt_interval;
        private System.Windows.Forms.TextBox tb_random_max;
        private System.Windows.Forms.TextBox tb_random_min;
        private System.Windows.Forms.TextBox tb_randomize_amount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_randomize;
        private System.Windows.Forms.Button btn_random_corrupt;
        private System.Windows.Forms.CheckBox cb_corrupt_single_chunk;
    }
}
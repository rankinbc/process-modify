namespace N64_RAM_modder3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_attach = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_load = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_attached_status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_pid = new System.Windows.Forms.Label();
            this.lbl_process = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_add_address = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_add_address_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_add_address = new System.Windows.Forms.TextBox();
            this.panel_mod_addresses = new System.Windows.Forms.Panel();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lb_mod_addresses = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_file_name = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_toggle_writing_to_process = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_remove_address = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_attach,
            this.menu_save,
            this.menu_load,
            this.menu_quit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_attach
            // 
            this.menu_attach.Name = "menu_attach";
            this.menu_attach.Size = new System.Drawing.Size(166, 22);
            this.menu_attach.Text = "Attach to Process";
            this.menu_attach.Click += new System.EventHandler(this.menu_attach_Click);
            // 
            // menu_save
            // 
            this.menu_save.Name = "menu_save";
            this.menu_save.Size = new System.Drawing.Size(166, 22);
            this.menu_save.Text = "Save";
            this.menu_save.Click += new System.EventHandler(this.menu_save_Click);
            // 
            // menu_load
            // 
            this.menu_load.Name = "menu_load";
            this.menu_load.Size = new System.Drawing.Size(166, 22);
            this.menu_load.Text = "Load";
            this.menu_load.Click += new System.EventHandler(this.menu_load_Click);
            // 
            // menu_quit
            // 
            this.menu_quit.Name = "menu_quit";
            this.menu_quit.Size = new System.Drawing.Size(166, 22);
            this.menu_quit.Text = "Quit";
            this.menu_quit.Click += new System.EventHandler(this.menu_quit_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_attached_status);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_pid);
            this.groupBox1.Controls.Add(this.lbl_process);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_attached_status
            // 
            this.lbl_attached_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_attached_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_attached_status.Location = new System.Drawing.Point(9, 13);
            this.lbl_attached_status.Name = "lbl_attached_status";
            this.lbl_attached_status.Size = new System.Drawing.Size(138, 23);
            this.lbl_attached_status.TabIndex = 10;
            this.lbl_attached_status.Text = "Not Attached";
            this.lbl_attached_status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_attached_status.Click += new System.EventHandler(this.lbl_attached_status_Click);
            this.lbl_attached_status.DoubleClick += new System.EventHandler(this.lbl_attached_status_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PID:";
            // 
            // lbl_pid
            // 
            this.lbl_pid.AutoSize = true;
            this.lbl_pid.Location = new System.Drawing.Point(34, 54);
            this.lbl_pid.Name = "lbl_pid";
            this.lbl_pid.Size = new System.Drawing.Size(0, 13);
            this.lbl_pid.TabIndex = 8;
            // 
            // lbl_process
            // 
            this.lbl_process.AutoSize = true;
            this.lbl_process.Location = new System.Drawing.Point(53, 35);
            this.lbl_process.Name = "lbl_process";
            this.lbl_process.Size = new System.Drawing.Size(0, 13);
            this.lbl_process.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.btn_add_address);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_add_address_name);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_add_address);
            this.groupBox2.Location = new System.Drawing.Point(160, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Add";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Byte (1)",
            "Short (2)",
            "Float (4)",
            "Double (8)"});
            this.comboBox1.Location = new System.Drawing.Point(50, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // btn_add_address
            // 
            this.btn_add_address.Image = global::ProcessModify.Properties.Resources.add;
            this.btn_add_address.Location = new System.Drawing.Point(124, 73);
            this.btn_add_address.Name = "btn_add_address";
            this.btn_add_address.Size = new System.Drawing.Size(26, 23);
            this.btn_add_address.TabIndex = 6;
            this.btn_add_address.UseVisualStyleBackColor = true;
            this.btn_add_address.Click += new System.EventHandler(this.btn_add_address_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // tb_add_address_name
            // 
            this.tb_add_address_name.Location = new System.Drawing.Point(50, 51);
            this.tb_add_address_name.Name = "tb_add_address_name";
            this.tb_add_address_name.Size = new System.Drawing.Size(100, 20);
            this.tb_add_address_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // tb_add_address
            // 
            this.tb_add_address.Location = new System.Drawing.Point(50, 29);
            this.tb_add_address.Name = "tb_add_address";
            this.tb_add_address.Size = new System.Drawing.Size(100, 20);
            this.tb_add_address.TabIndex = 0;
            this.tb_add_address.TextChanged += new System.EventHandler(this.tb_add_address_TextChanged);
            // 
            // panel_mod_addresses
            // 
            this.panel_mod_addresses.AutoScroll = true;
            this.panel_mod_addresses.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_mod_addresses.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_mod_addresses.Location = new System.Drawing.Point(320, 0);
            this.panel_mod_addresses.Name = "panel_mod_addresses";
            this.panel_mod_addresses.Size = new System.Drawing.Size(395, 495);
            this.panel_mod_addresses.TabIndex = 6;
            this.panel_mod_addresses.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel_mod_addresses_Scroll);
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 1;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lb_mod_addresses
            // 
            this.lb_mod_addresses.FormattingEnabled = true;
            this.lb_mod_addresses.Location = new System.Drawing.Point(192, 125);
            this.lb_mod_addresses.Name = "lb_mod_addresses";
            this.lb_mod_addresses.Size = new System.Drawing.Size(120, 368);
            this.lb_mod_addresses.TabIndex = 8;
            this.lb_mod_addresses.SelectedIndexChanged += new System.EventHandler(this.lb_mod_addresses_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "File:";
            // 
            // lbl_file_name
            // 
            this.lbl_file_name.AutoSize = true;
            this.lbl_file_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_file_name.Location = new System.Drawing.Point(34, 45);
            this.lbl_file_name.Name = "lbl_file_name";
            this.lbl_file_name.Size = new System.Drawing.Size(63, 13);
            this.lbl_file_name.TabIndex = 12;
            this.lbl_file_name.Text = "Not Loaded";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_load);
            this.groupBox3.Controls.Add(this.btn_save);
            this.groupBox3.Controls.Add(this.lbl_file_name);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(1, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 69);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // btn_load
            // 
            this.btn_load.Image = global::ProcessModify.Properties.Resources.load;
            this.btn_load.Location = new System.Drawing.Point(36, 11);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(26, 23);
            this.btn_load.TabIndex = 14;
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::ProcessModify.Properties.Resources.save;
            this.btn_save.Location = new System.Drawing.Point(6, 11);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(26, 23);
            this.btn_save.TabIndex = 13;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_toggle_writing_to_process
            // 
            this.btn_toggle_writing_to_process.Enabled = false;
            this.btn_toggle_writing_to_process.Image = global::ProcessModify.Properties.Resources.disconnected;
            this.btn_toggle_writing_to_process.Location = new System.Drawing.Point(160, 128);
            this.btn_toggle_writing_to_process.Name = "btn_toggle_writing_to_process";
            this.btn_toggle_writing_to_process.Size = new System.Drawing.Size(26, 23);
            this.btn_toggle_writing_to_process.TabIndex = 11;
            this.btn_toggle_writing_to_process.UseVisualStyleBackColor = false;
            this.btn_toggle_writing_to_process.Click += new System.EventHandler(this.btn_toggle_writing_to_process_Click);
            // 
            // button3
            // 
            this.button3.Image = global::ProcessModify.Properties.Resources.downarrow;
            this.button3.Location = new System.Drawing.Point(160, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::ProcessModify.Properties.Resources.uparrow;
            this.button2.Location = new System.Drawing.Point(160, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_remove_address
            // 
            this.btn_remove_address.Image = global::ProcessModify.Properties.Resources.remove;
            this.btn_remove_address.Location = new System.Drawing.Point(160, 157);
            this.btn_remove_address.Name = "btn_remove_address";
            this.btn_remove_address.Size = new System.Drawing.Size(26, 23);
            this.btn_remove_address.TabIndex = 7;
            this.btn_remove_address.UseVisualStyleBackColor = true;
            this.btn_remove_address.Click += new System.EventHandler(this.btn_remove_address_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(7, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 66);
            this.label9.TabIndex = 13;
            this.label9.Text = "PROCESS MODIFY";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(1, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 252);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 495);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_toggle_writing_to_process);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_remove_address);
            this.Controls.Add(this.lb_mod_addresses);
            this.Controls.Add(this.panel_mod_addresses);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Process Modify";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_attach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_add_address_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_add_address;
        private System.Windows.Forms.Button btn_add_address;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel_mod_addresses;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label lbl_pid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem menu_save;
        private System.Windows.Forms.ToolStripMenuItem menu_load;
        private System.Windows.Forms.ToolStripMenuItem menu_quit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lb_mod_addresses;
        private System.Windows.Forms.Button btn_remove_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_toggle_writing_to_process;
        private System.Windows.Forms.Label lbl_attached_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_file_name;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;

    }
}


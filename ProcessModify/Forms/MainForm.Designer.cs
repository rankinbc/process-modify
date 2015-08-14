namespace ProcessModify
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_file_name = new System.Windows.Forms.Label();
            this.lbl_pid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_process = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_writing_to_process = new System.Windows.Forms.Label();
            this.lbl_attached_status = new System.Windows.Forms.Label();
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
            this.label9 = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lb_mod_addresses = new System.Windows.Forms.ListBox();
            this.menu_buttons = new System.Windows.Forms.MenuStrip();
            this.menu_button_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_button_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_button_attach = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_button_toggle_write = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_button_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.var_conversion_panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_var_as_uint64 = new System.Windows.Forms.Label();
            this.lbl_var_as_uint16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_var_as_double = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_var_as_int32 = new System.Windows.Forms.Label();
            this.lbl_var_as_int64 = new System.Windows.Forms.Label();
            this.lbl_var_as_float = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_999 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_var_as_int16 = new System.Windows.Forms.Label();
            this.lbl_var_as_byte = new System.Windows.Forms.Label();
            this.lbl_var_as_uint32 = new System.Windows.Forms.Label();
            this.lbl_var_address = new System.Windows.Forms.Label();
            this.lbl_var_name = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_open_hex = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_remove_address = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menu_buttons.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.var_conversion_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_file_name);
            this.groupBox1.Controls.Add(this.lbl_pid);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_process);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PID:";
            // 
            // lbl_file_name
            // 
            this.lbl_file_name.AutoSize = true;
            this.lbl_file_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_file_name.Location = new System.Drawing.Point(30, 45);
            this.lbl_file_name.Name = "lbl_file_name";
            this.lbl_file_name.Size = new System.Drawing.Size(63, 13);
            this.lbl_file_name.TabIndex = 12;
            this.lbl_file_name.Text = "Not Loaded";
            // 
            // lbl_pid
            // 
            this.lbl_pid.AutoSize = true;
            this.lbl_pid.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pid.Location = new System.Drawing.Point(32, 26);
            this.lbl_pid.Name = "lbl_pid";
            this.lbl_pid.Size = new System.Drawing.Size(0, 15);
            this.lbl_pid.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "File:";
            // 
            // lbl_process
            // 
            this.lbl_process.AutoSize = true;
            this.lbl_process.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_process.Location = new System.Drawing.Point(51, 7);
            this.lbl_process.Name = "lbl_process";
            this.lbl_process.Size = new System.Drawing.Size(0, 15);
            this.lbl_process.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process:";
            // 
            // lbl_writing_to_process
            // 
            this.lbl_writing_to_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_writing_to_process.ForeColor = System.Drawing.Color.Red;
            this.lbl_writing_to_process.Location = new System.Drawing.Point(187, 50);
            this.lbl_writing_to_process.Name = "lbl_writing_to_process";
            this.lbl_writing_to_process.Size = new System.Drawing.Size(133, 13);
            this.lbl_writing_to_process.TabIndex = 11;
            this.lbl_writing_to_process.Text = "Not writing to process";
            this.lbl_writing_to_process.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_attached_status
            // 
            this.lbl_attached_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_attached_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_attached_status.Location = new System.Drawing.Point(187, 31);
            this.lbl_attached_status.Name = "lbl_attached_status";
            this.lbl_attached_status.Size = new System.Drawing.Size(133, 23);
            this.lbl_attached_status.TabIndex = 10;
            this.lbl_attached_status.Text = "Not Attached";
            this.lbl_attached_status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_attached_status.DoubleClick += new System.EventHandler(this.lbl_attached_status_DoubleClick);
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
            this.groupBox2.Location = new System.Drawing.Point(1, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 83);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Add Address";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Byte (1)",
            "UInt16 (2)",
            "Int16 (2)",
            "UInt32 (4)",
            "Int32 (4)",
            "UInt64 (8)",
            "Int64 (8)",
            "Float (4)",
            "Double (8)"});
            this.comboBox1.Location = new System.Drawing.Point(59, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // btn_add_address
            // 
            this.btn_add_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_address.Image = global::ProcessModify.Properties.Resources.add;
            this.btn_add_address.Location = new System.Drawing.Point(138, 57);
            this.btn_add_address.Name = "btn_add_address";
            this.btn_add_address.Size = new System.Drawing.Size(22, 22);
            this.btn_add_address.TabIndex = 6;
            this.btn_add_address.UseVisualStyleBackColor = true;
            this.btn_add_address.Click += new System.EventHandler(this.btn_add_address_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // tb_add_address_name
            // 
            this.tb_add_address_name.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F);
            this.tb_add_address_name.Location = new System.Drawing.Point(59, 39);
            this.tb_add_address_name.Name = "tb_add_address_name";
            this.tb_add_address_name.Size = new System.Drawing.Size(100, 18);
            this.tb_add_address_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // tb_add_address
            // 
            this.tb_add_address.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F);
            this.tb_add_address.Location = new System.Drawing.Point(59, 20);
            this.tb_add_address.Name = "tb_add_address";
            this.tb_add_address.Size = new System.Drawing.Size(100, 18);
            this.tb_add_address.TabIndex = 0;
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
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.ForestGreen;
            this.label9.Location = new System.Drawing.Point(2, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 80);
            this.label9.TabIndex = 13;
            this.label9.Text = "PROCESS MODIFY";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lb_mod_addresses.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lb_mod_addresses.FormattingEnabled = true;
            this.lb_mod_addresses.Location = new System.Drawing.Point(192, 99);
            this.lb_mod_addresses.Name = "lb_mod_addresses";
            this.lb_mod_addresses.Size = new System.Drawing.Size(120, 394);
            this.lb_mod_addresses.TabIndex = 8;
            this.lb_mod_addresses.SelectedIndexChanged += new System.EventHandler(this.lb_mod_addresses_SelectedIndexChanged);
            // 
            // menu_buttons
            // 
            this.menu_buttons.AutoSize = false;
            this.menu_buttons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menu_buttons.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_buttons.Font = new System.Drawing.Font("Segoe UI", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_buttons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_button_save,
            this.menu_button_open,
            this.menu_button_attach,
            this.menu_button_toggle_write,
            this.menu_button_refresh});
            this.menu_buttons.Location = new System.Drawing.Point(1, 0);
            this.menu_buttons.Name = "menu_buttons";
            this.menu_buttons.Padding = new System.Windows.Forms.Padding(0);
            this.menu_buttons.Size = new System.Drawing.Size(319, 27);
            this.menu_buttons.TabIndex = 25;
            this.menu_buttons.Text = "menuStrip2";
            // 
            // menu_button_save
            // 
            this.menu_button_save.Image = global::ProcessModify.Properties.Resources.save;
            this.menu_button_save.Name = "menu_button_save";
            this.menu_button_save.Padding = new System.Windows.Forms.Padding(0);
            this.menu_button_save.Size = new System.Drawing.Size(20, 27);
            this.menu_button_save.ToolTipText = "Save";
            this.menu_button_save.Click += new System.EventHandler(this.menu_button_save_Click);
            // 
            // menu_button_open
            // 
            this.menu_button_open.Image = global::ProcessModify.Properties.Resources.load;
            this.menu_button_open.Name = "menu_button_open";
            this.menu_button_open.Padding = new System.Windows.Forms.Padding(0);
            this.menu_button_open.Size = new System.Drawing.Size(20, 27);
            this.menu_button_open.ToolTipText = "Open";
            this.menu_button_open.Click += new System.EventHandler(this.menu_button_open_Click);
            // 
            // menu_button_attach
            // 
            this.menu_button_attach.Image = global::ProcessModify.Properties.Resources.disconnected;
            this.menu_button_attach.Name = "menu_button_attach";
            this.menu_button_attach.Padding = new System.Windows.Forms.Padding(0);
            this.menu_button_attach.Size = new System.Drawing.Size(20, 27);
            this.menu_button_attach.ToolTipText = "Attach to process";
            this.menu_button_attach.Click += new System.EventHandler(this.menu_button_attach_Click);
            // 
            // menu_button_toggle_write
            // 
            this.menu_button_toggle_write.Enabled = false;
            this.menu_button_toggle_write.Image = global::ProcessModify.Properties.Resources.notwriting;
            this.menu_button_toggle_write.Name = "menu_button_toggle_write";
            this.menu_button_toggle_write.Padding = new System.Windows.Forms.Padding(0);
            this.menu_button_toggle_write.Size = new System.Drawing.Size(20, 27);
            this.menu_button_toggle_write.ToolTipText = "Toggle write to process";
            this.menu_button_toggle_write.Click += new System.EventHandler(this.menu_button_toggle_write_Click_1);
            // 
            // menu_button_refresh
            // 
            this.menu_button_refresh.AutoToolTip = true;
            this.menu_button_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menu_button_refresh.Image = global::ProcessModify.Properties.Resources.refresh;
            this.menu_button_refresh.Name = "menu_button_refresh";
            this.menu_button_refresh.Padding = new System.Windows.Forms.Padding(0);
            this.menu_button_refresh.Size = new System.Drawing.Size(20, 27);
            this.menu_button_refresh.ToolTipText = "Refresh Process";
            this.menu_button_refresh.Click += new System.EventHandler(this.menu_button_refresh_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.var_conversion_panel);
            this.groupBox4.Controls.Add(this.lbl_var_address);
            this.groupBox4.Controls.Add(this.lbl_var_name);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(1, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 202);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // var_conversion_panel
            // 
            this.var_conversion_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.var_conversion_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.var_conversion_panel.Controls.Add(this.label8);
            this.var_conversion_panel.Controls.Add(this.label16);
            this.var_conversion_panel.Controls.Add(this.lbl_var_as_uint64);
            this.var_conversion_panel.Controls.Add(this.lbl_var_as_uint16);
            this.var_conversion_panel.Controls.Add(this.label11);
            this.var_conversion_panel.Controls.Add(this.label19);
            this.var_conversion_panel.Controls.Add(this.label17);
            this.var_conversion_panel.Controls.Add(this.lbl_var_as_double);
            this.var_conversion_panel.Controls.Add(this.label12);
            this.var_conversion_panel.Controls.Add(this.lbl_var_as_int32);
            this.var_conversion_panel.Controls.Add(this.lbl_var_as_int64);
            this.var_conversion_panel.Controls.Add(this.lbl_var_as_float);
            this.var_conversion_panel.Controls.Add(this.label13);
            this.var_conversion_panel.Controls.Add(this.label_999);
            this.var_conversion_panel.Controls.Add(this.label20);
            this.var_conversion_panel.Controls.Add(this.lbl_var_as_int16);
            this.var_conversion_panel.Controls.Add(this.lbl_var_as_byte);
            this.var_conversion_panel.Controls.Add(this.lbl_var_as_uint32);
            this.var_conversion_panel.Location = new System.Drawing.Point(16, 64);
            this.var_conversion_panel.Name = "var_conversion_panel";
            this.var_conversion_panel.Size = new System.Drawing.Size(153, 127);
            this.var_conversion_panel.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "Byte:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 12);
            this.label16.TabIndex = 24;
            this.label16.Text = "UInt16:";
            // 
            // lbl_var_as_uint64
            // 
            this.lbl_var_as_uint64.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_var_as_uint64.Location = new System.Drawing.Point(55, 70);
            this.lbl_var_as_uint64.Name = "lbl_var_as_uint64";
            this.lbl_var_as_uint64.Size = new System.Drawing.Size(93, 10);
            this.lbl_var_as_uint64.TabIndex = 33;
            this.lbl_var_as_uint64.Text = "0.00000";
            // 
            // lbl_var_as_uint16
            // 
            this.lbl_var_as_uint16.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_var_as_uint16.Location = new System.Drawing.Point(55, 15);
            this.lbl_var_as_uint16.Name = "lbl_var_as_uint16";
            this.lbl_var_as_uint16.Size = new System.Drawing.Size(93, 10);
            this.lbl_var_as_uint16.TabIndex = 25;
            this.lbl_var_as_uint16.Text = "0.00000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "Int16:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 12);
            this.label19.TabIndex = 26;
            this.label19.Text = "Int32:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 12);
            this.label17.TabIndex = 32;
            this.label17.Text = "UInt64:";
            // 
            // lbl_var_as_double
            // 
            this.lbl_var_as_double.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_var_as_double.Location = new System.Drawing.Point(55, 111);
            this.lbl_var_as_double.Name = "lbl_var_as_double";
            this.lbl_var_as_double.Size = new System.Drawing.Size(93, 10);
            this.lbl_var_as_double.TabIndex = 23;
            this.lbl_var_as_double.Text = "0.00000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "Float:";
            // 
            // lbl_var_as_int32
            // 
            this.lbl_var_as_int32.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_var_as_int32.Location = new System.Drawing.Point(55, 57);
            this.lbl_var_as_int32.Name = "lbl_var_as_int32";
            this.lbl_var_as_int32.Size = new System.Drawing.Size(93, 10);
            this.lbl_var_as_int32.TabIndex = 27;
            this.lbl_var_as_int32.Text = "0.00000";
            // 
            // lbl_var_as_int64
            // 
            this.lbl_var_as_int64.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_var_as_int64.Location = new System.Drawing.Point(55, 84);
            this.lbl_var_as_int64.Name = "lbl_var_as_int64";
            this.lbl_var_as_int64.Size = new System.Drawing.Size(93, 10);
            this.lbl_var_as_int64.TabIndex = 31;
            this.lbl_var_as_int64.Text = "0.00000";
            // 
            // lbl_var_as_float
            // 
            this.lbl_var_as_float.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_var_as_float.Location = new System.Drawing.Point(55, 97);
            this.lbl_var_as_float.Name = "lbl_var_as_float";
            this.lbl_var_as_float.Size = new System.Drawing.Size(93, 10);
            this.lbl_var_as_float.TabIndex = 22;
            this.lbl_var_as_float.Text = "0.00000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "Double:";
            // 
            // label_999
            // 
            this.label_999.AutoSize = true;
            this.label_999.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_999.Location = new System.Drawing.Point(3, 43);
            this.label_999.Name = "label_999";
            this.label_999.Size = new System.Drawing.Size(46, 12);
            this.label_999.TabIndex = 28;
            this.label_999.Text = "UInt32:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 12);
            this.label20.TabIndex = 30;
            this.label20.Text = "Int64:";
            // 
            // lbl_var_as_int16
            // 
            this.lbl_var_as_int16.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_var_as_int16.Location = new System.Drawing.Point(55, 29);
            this.lbl_var_as_int16.Name = "lbl_var_as_int16";
            this.lbl_var_as_int16.Size = new System.Drawing.Size(93, 10);
            this.lbl_var_as_int16.TabIndex = 21;
            this.lbl_var_as_int16.Text = "0.00000";
            // 
            // lbl_var_as_byte
            // 
            this.lbl_var_as_byte.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_var_as_byte.Location = new System.Drawing.Point(55, 1);
            this.lbl_var_as_byte.Name = "lbl_var_as_byte";
            this.lbl_var_as_byte.Size = new System.Drawing.Size(93, 10);
            this.lbl_var_as_byte.TabIndex = 20;
            this.lbl_var_as_byte.Text = "0.00000";
            // 
            // lbl_var_as_uint32
            // 
            this.lbl_var_as_uint32.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_var_as_uint32.Location = new System.Drawing.Point(55, 43);
            this.lbl_var_as_uint32.Name = "lbl_var_as_uint32";
            this.lbl_var_as_uint32.Size = new System.Drawing.Size(93, 10);
            this.lbl_var_as_uint32.TabIndex = 29;
            this.lbl_var_as_uint32.Text = "0.00000";
            // 
            // lbl_var_address
            // 
            this.lbl_var_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_var_address.Location = new System.Drawing.Point(11, 42);
            this.lbl_var_address.Name = "lbl_var_address";
            this.lbl_var_address.Size = new System.Drawing.Size(162, 15);
            this.lbl_var_address.TabIndex = 15;
            this.lbl_var_address.Text = "00000000";
            this.lbl_var_address.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_var_name
            // 
            this.lbl_var_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_var_name.Location = new System.Drawing.Point(12, 25);
            this.lbl_var_name.Name = "lbl_var_name";
            this.lbl_var_name.Size = new System.Drawing.Size(162, 15);
            this.lbl_var_name.TabIndex = 14;
            this.lbl_var_name.Text = "None";
            this.lbl_var_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(65, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Variable";
            // 
            // btn_open_hex
            // 
            this.btn_open_hex.Enabled = false;
            this.btn_open_hex.Location = new System.Drawing.Point(57, 460);
            this.btn_open_hex.Name = "btn_open_hex";
            this.btn_open_hex.Size = new System.Drawing.Size(75, 23);
            this.btn_open_hex.TabIndex = 24;
            this.btn_open_hex.Text = "Hex Editor";
            this.btn_open_hex.UseVisualStyleBackColor = true;
            this.btn_open_hex.Click += new System.EventHandler(this.btn_open_hex_Click);
            // 
            // button2
            // 
            this.button2.Image = global::ProcessModify.Properties.Resources.uparrow;
            this.button2.Location = new System.Drawing.Point(190, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 22);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::ProcessModify.Properties.Resources.downarrow;
            this.button3.Location = new System.Drawing.Point(211, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 22);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_remove_address
            // 
            this.btn_remove_address.Image = global::ProcessModify.Properties.Resources.remove;
            this.btn_remove_address.Location = new System.Drawing.Point(232, 77);
            this.btn_remove_address.Name = "btn_remove_address";
            this.btn_remove_address.Size = new System.Drawing.Size(22, 22);
            this.btn_remove_address.TabIndex = 7;
            this.btn_remove_address.UseVisualStyleBackColor = true;
            this.btn_remove_address.Click += new System.EventHandler(this.btn_remove_address_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label14.Location = new System.Drawing.Point(135, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "v1.4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 495);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_writing_to_process);
            this.Controls.Add(this.lbl_attached_status);
            this.Controls.Add(this.menu_buttons);
            this.Controls.Add(this.btn_open_hex);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_remove_address);
            this.Controls.Add(this.lb_mod_addresses);
            this.Controls.Add(this.panel_mod_addresses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Process Modify";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menu_buttons.ResumeLayout(false);
            this.menu_buttons.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.var_conversion_panel.ResumeLayout(false);
            this.var_conversion_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_add_address_name;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_add_address;
        public System.Windows.Forms.Button btn_add_address;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel_mod_addresses;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label lbl_pid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lb_mod_addresses;
        private System.Windows.Forms.Button btn_remove_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_attached_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_file_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_var_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_var_address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_var_as_double;
        private System.Windows.Forms.Label lbl_var_as_float;
        private System.Windows.Forms.Label lbl_var_as_int16;
        private System.Windows.Forms.Label lbl_var_as_byte;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_open_hex;
        private System.Windows.Forms.Label lbl_var_as_uint16;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_var_as_uint32;
        private System.Windows.Forms.Label label_999;
        private System.Windows.Forms.Label lbl_var_as_int32;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_var_as_uint64;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_var_as_int64;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_writing_to_process;
        private System.Windows.Forms.Panel var_conversion_panel;
        private System.Windows.Forms.MenuStrip menu_buttons;
        private System.Windows.Forms.ToolStripMenuItem menu_button_save;
        private System.Windows.Forms.ToolStripMenuItem menu_button_open;
        private System.Windows.Forms.ToolStripMenuItem menu_button_refresh;
        private System.Windows.Forms.ToolStripMenuItem menu_button_attach;
        private System.Windows.Forms.ToolStripMenuItem menu_button_toggle_write;
        private System.Windows.Forms.Label label14;

    }
}


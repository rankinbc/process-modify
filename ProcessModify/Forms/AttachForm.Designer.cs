namespace ProcessModify
{
    partial class AttachForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttachForm));
            this.lb_processes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.tb_process = new System.Windows.Forms.TextBox();
            this.btn_select_mupen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_processes
            // 
            this.lb_processes.FormattingEnabled = true;
            this.lb_processes.Location = new System.Drawing.Point(12, 42);
            this.lb_processes.Name = "lb_processes";
            this.lb_processes.Size = new System.Drawing.Size(171, 238);
            this.lb_processes.TabIndex = 0;
            this.lb_processes.SelectedIndexChanged += new System.EventHandler(this.lb_processes_SelectedIndexChanged);
            this.lb_processes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_processes_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Process";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(12, 312);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(171, 26);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // tb_process
            // 
            this.tb_process.Location = new System.Drawing.Point(12, 286);
            this.tb_process.Name = "tb_process";
            this.tb_process.Size = new System.Drawing.Size(171, 20);
            this.tb_process.TabIndex = 0;
            // 
            // btn_select_mupen
            // 
            this.btn_select_mupen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_select_mupen.Location = new System.Drawing.Point(177, 312);
            this.btn_select_mupen.Name = "btn_select_mupen";
            this.btn_select_mupen.Size = new System.Drawing.Size(16, 26);
            this.btn_select_mupen.TabIndex = 3;
            this.btn_select_mupen.UseVisualStyleBackColor = false;
            this.btn_select_mupen.Click += new System.EventHandler(this.btn_select_mupen_Click);
            // 
            // AttachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 338);
            this.Controls.Add(this.btn_select_mupen);
            this.Controls.Add(this.tb_process);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_processes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttachForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AttachForm";
            this.Load += new System.EventHandler(this.AttachForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AttachForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_processes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.TextBox tb_process;
        private System.Windows.Forms.Button btn_select_mupen;
    }
}
namespace Process_scheduling_algorithm
{
    partial class SJF
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
            this.dataGridView_SJF = new System.Windows.Forms.DataGridView();
            this.label_proccess_name = new System.Windows.Forms.Label();
            this.label_remain_time = new System.Windows.Forms.Label();
            this.label_arri_time = new System.Windows.Forms.Label();
            this.textBox_proccess_name = new System.Windows.Forms.TextBox();
            this.textBo_arri_time = new System.Windows.Forms.TextBox();
            this.textBox_remain_time = new System.Windows.Forms.TextBox();
            this.button_add_process = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_start = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.textBox_show_time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.label_speed = new System.Windows.Forms.Label();
            this.comboBox_speed = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SJF)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SJF
            // 
            this.dataGridView_SJF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SJF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_SJF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SJF.Location = new System.Drawing.Point(172, 148);
            this.dataGridView_SJF.MultiSelect = false;
            this.dataGridView_SJF.Name = "dataGridView_SJF";
            this.dataGridView_SJF.RowHeadersVisible = false;
            this.dataGridView_SJF.RowHeadersWidth = 82;
            this.dataGridView_SJF.RowTemplate.Height = 37;
            this.dataGridView_SJF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_SJF.Size = new System.Drawing.Size(814, 938);
            this.dataGridView_SJF.TabIndex = 0;
            // 
            // label_proccess_name
            // 
            this.label_proccess_name.AutoSize = true;
            this.label_proccess_name.Location = new System.Drawing.Point(1130, 215);
            this.label_proccess_name.Name = "label_proccess_name";
            this.label_proccess_name.Size = new System.Drawing.Size(82, 24);
            this.label_proccess_name.TabIndex = 1;
            this.label_proccess_name.Text = "进程名";
            // 
            // label_remain_time
            // 
            this.label_remain_time.AutoSize = true;
            this.label_remain_time.Location = new System.Drawing.Point(1130, 332);
            this.label_remain_time.Name = "label_remain_time";
            this.label_remain_time.Size = new System.Drawing.Size(82, 24);
            this.label_remain_time.TabIndex = 3;
            this.label_remain_time.Text = "总时间";
            // 
            // label_arri_time
            // 
            this.label_arri_time.AutoSize = true;
            this.label_arri_time.Location = new System.Drawing.Point(1130, 276);
            this.label_arri_time.Name = "label_arri_time";
            this.label_arri_time.Size = new System.Drawing.Size(106, 24);
            this.label_arri_time.TabIndex = 4;
            this.label_arri_time.Text = "到达时间";
            // 
            // textBox_proccess_name
            // 
            this.textBox_proccess_name.Location = new System.Drawing.Point(1245, 212);
            this.textBox_proccess_name.Name = "textBox_proccess_name";
            this.textBox_proccess_name.Size = new System.Drawing.Size(100, 35);
            this.textBox_proccess_name.TabIndex = 5;
            // 
            // textBo_arri_time
            // 
            this.textBo_arri_time.Location = new System.Drawing.Point(1245, 273);
            this.textBo_arri_time.Name = "textBo_arri_time";
            this.textBo_arri_time.Size = new System.Drawing.Size(100, 35);
            this.textBo_arri_time.TabIndex = 6;
            // 
            // textBox_remain_time
            // 
            this.textBox_remain_time.Location = new System.Drawing.Point(1245, 329);
            this.textBox_remain_time.Name = "textBox_remain_time";
            this.textBox_remain_time.Size = new System.Drawing.Size(100, 35);
            this.textBox_remain_time.TabIndex = 7;
            // 
            // button_add_process
            // 
            this.button_add_process.Location = new System.Drawing.Point(1134, 412);
            this.button_add_process.Name = "button_add_process";
            this.button_add_process.Size = new System.Drawing.Size(133, 49);
            this.button_add_process.TabIndex = 8;
            this.button_add_process.Text = "添加";
            this.button_add_process.UseVisualStyleBackColor = true;
            this.button_add_process.Click += new System.EventHandler(this.button_add_process_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(1134, 668);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(150, 49);
            this.button_start.TabIndex = 9;
            this.button_start.Text = "开始/继续";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(1350, 668);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(133, 49);
            this.button_pause.TabIndex = 11;
            this.button_pause.Text = "暂停";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // textBox_show_time
            // 
            this.textBox_show_time.Location = new System.Drawing.Point(1254, 846);
            this.textBox_show_time.Name = "textBox_show_time";
            this.textBox_show_time.Size = new System.Drawing.Size(100, 35);
            this.textBox_show_time.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(1130, 849);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "当前时间";
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(1548, 668);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(133, 49);
            this.button_reset.TabIndex = 15;
            this.button_reset.Text = "重置";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Location = new System.Drawing.Point(1130, 603);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(58, 24);
            this.label_speed.TabIndex = 16;
            this.label_speed.Text = "速度";
            // 
            // comboBox_speed
            // 
            this.comboBox_speed.FormattingEnabled = true;
            this.comboBox_speed.Items.AddRange(new object[] {
            "0.5x",
            "1.0x",
            "2.0x"});
            this.comboBox_speed.Location = new System.Drawing.Point(1211, 600);
            this.comboBox_speed.Name = "comboBox_speed";
            this.comboBox_speed.Size = new System.Drawing.Size(150, 32);
            this.comboBox_speed.TabIndex = 17;
            this.comboBox_speed.SelectedIndexChanged += new System.EventHandler(this.comboBox_speed_SelectedIndexChanged);
            // 
            // SJF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2074, 1179);
            this.Controls.Add(this.comboBox_speed);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_show_time);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_add_process);
            this.Controls.Add(this.textBox_remain_time);
            this.Controls.Add(this.textBo_arri_time);
            this.Controls.Add(this.textBox_proccess_name);
            this.Controls.Add(this.label_arri_time);
            this.Controls.Add(this.label_remain_time);
            this.Controls.Add(this.label_proccess_name);
            this.Controls.Add(this.dataGridView_SJF);
            this.Name = "SJF";
            this.Text = "SJF";
            this.Load += new System.EventHandler(this.SJF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SJF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SJF;
        private System.Windows.Forms.Label label_proccess_name;
        private System.Windows.Forms.Label label_remain_time;
        private System.Windows.Forms.Label label_arri_time;
        private System.Windows.Forms.TextBox textBox_proccess_name;
        private System.Windows.Forms.TextBox textBo_arri_time;
        private System.Windows.Forms.TextBox textBox_remain_time;
        private System.Windows.Forms.Button button_add_process;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.TextBox textBox_show_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.ComboBox comboBox_speed;
    }
}
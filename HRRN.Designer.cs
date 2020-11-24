namespace Process_scheduling_algorithm
{
    partial class HRRN
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
            this.dataGridView_HRRN = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_proccess_name = new System.Windows.Forms.Label();
            this.label_arri_time = new System.Windows.Forms.Label();
            this.label_remain_time = new System.Windows.Forms.Label();
            this.textBox_proccess_name = new System.Windows.Forms.TextBox();
            this.textBox_arri_time = new System.Windows.Forms.TextBox();
            this.textBox_total_time = new System.Windows.Forms.TextBox();
            this.button_add_proccess = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.label_time_now = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.label_speed = new System.Windows.Forms.Label();
            this.textBox_time_now = new System.Windows.Forms.TextBox();
            this.comboBox_speed = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HRRN)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_HRRN
            // 
            this.dataGridView_HRRN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_HRRN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_HRRN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HRRN.Location = new System.Drawing.Point(146, 111);
            this.dataGridView_HRRN.Name = "dataGridView_HRRN";
            this.dataGridView_HRRN.RowHeadersVisible = false;
            this.dataGridView_HRRN.RowHeadersWidth = 82;
            this.dataGridView_HRRN.RowTemplate.Height = 37;
            this.dataGridView_HRRN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_HRRN.Size = new System.Drawing.Size(993, 938);
            this.dataGridView_HRRN.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_proccess_name
            // 
            this.label_proccess_name.AutoSize = true;
            this.label_proccess_name.Location = new System.Drawing.Point(1234, 141);
            this.label_proccess_name.Name = "label_proccess_name";
            this.label_proccess_name.Size = new System.Drawing.Size(82, 24);
            this.label_proccess_name.TabIndex = 1;
            this.label_proccess_name.Text = "进程名";
            // 
            // label_arri_time
            // 
            this.label_arri_time.AutoSize = true;
            this.label_arri_time.Location = new System.Drawing.Point(1234, 208);
            this.label_arri_time.Name = "label_arri_time";
            this.label_arri_time.Size = new System.Drawing.Size(106, 24);
            this.label_arri_time.TabIndex = 2;
            this.label_arri_time.Text = "到达时间";
            // 
            // label_remain_time
            // 
            this.label_remain_time.AutoSize = true;
            this.label_remain_time.Location = new System.Drawing.Point(1234, 270);
            this.label_remain_time.Name = "label_remain_time";
            this.label_remain_time.Size = new System.Drawing.Size(82, 24);
            this.label_remain_time.TabIndex = 3;
            this.label_remain_time.Text = "总时间";
            // 
            // textBox_proccess_name
            // 
            this.textBox_proccess_name.Location = new System.Drawing.Point(1341, 138);
            this.textBox_proccess_name.Name = "textBox_proccess_name";
            this.textBox_proccess_name.Size = new System.Drawing.Size(100, 35);
            this.textBox_proccess_name.TabIndex = 4;
            // 
            // textBox_arri_time
            // 
            this.textBox_arri_time.Location = new System.Drawing.Point(1341, 205);
            this.textBox_arri_time.Name = "textBox_arri_time";
            this.textBox_arri_time.Size = new System.Drawing.Size(100, 35);
            this.textBox_arri_time.TabIndex = 5;
            // 
            // textBox_total_time
            // 
            this.textBox_total_time.Location = new System.Drawing.Point(1341, 267);
            this.textBox_total_time.Name = "textBox_total_time";
            this.textBox_total_time.Size = new System.Drawing.Size(100, 35);
            this.textBox_total_time.TabIndex = 6;
            // 
            // button_add_proccess
            // 
            this.button_add_proccess.Location = new System.Drawing.Point(1238, 345);
            this.button_add_proccess.Name = "button_add_proccess";
            this.button_add_proccess.Size = new System.Drawing.Size(133, 49);
            this.button_add_proccess.TabIndex = 7;
            this.button_add_proccess.Text = "添加";
            this.button_add_proccess.UseVisualStyleBackColor = true;
            this.button_add_proccess.Click += new System.EventHandler(this.button_add_proccess_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(1238, 575);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(150, 49);
            this.button_start.TabIndex = 8;
            this.button_start.Text = "开始/继续";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(1461, 575);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(133, 49);
            this.button_pause.TabIndex = 9;
            this.button_pause.Text = "暂停";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // label_time_now
            // 
            this.label_time_now.AutoSize = true;
            this.label_time_now.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_time_now.Location = new System.Drawing.Point(1234, 757);
            this.label_time_now.Name = "label_time_now";
            this.label_time_now.Size = new System.Drawing.Size(106, 24);
            this.label_time_now.TabIndex = 10;
            this.label_time_now.Text = "当前时间";
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(1654, 575);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(133, 49);
            this.button_reset.TabIndex = 12;
            this.button_reset.Text = "重置";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Location = new System.Drawing.Point(1234, 509);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(58, 24);
            this.label_speed.TabIndex = 13;
            this.label_speed.Text = "速度";
            // 
            // textBox_time_now
            // 
            this.textBox_time_now.Location = new System.Drawing.Point(1355, 754);
            this.textBox_time_now.Name = "textBox_time_now";
            this.textBox_time_now.Size = new System.Drawing.Size(150, 35);
            this.textBox_time_now.TabIndex = 11;
            // 
            // comboBox_speed
            // 
            this.comboBox_speed.FormattingEnabled = true;
            this.comboBox_speed.Items.AddRange(new object[] {
            "0.5x",
            "1.0x",
            "2.0x"});
            this.comboBox_speed.Location = new System.Drawing.Point(1298, 506);
            this.comboBox_speed.Name = "comboBox_speed";
            this.comboBox_speed.Size = new System.Drawing.Size(150, 32);
            this.comboBox_speed.TabIndex = 14;
            this.comboBox_speed.SelectedIndexChanged += new System.EventHandler(this.comboBox_speed_SelectedIndexChanged);
            // 
            // HRRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2074, 1179);
            this.Controls.Add(this.comboBox_speed);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.textBox_time_now);
            this.Controls.Add(this.label_time_now);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_add_proccess);
            this.Controls.Add(this.textBox_total_time);
            this.Controls.Add(this.textBox_arri_time);
            this.Controls.Add(this.textBox_proccess_name);
            this.Controls.Add(this.label_remain_time);
            this.Controls.Add(this.label_arri_time);
            this.Controls.Add(this.label_proccess_name);
            this.Controls.Add(this.dataGridView_HRRN);
            this.Name = "HRRN";
            this.Text = "HRRN";
            this.Load += new System.EventHandler(this.HRRN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HRRN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_HRRN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_proccess_name;
        private System.Windows.Forms.Label label_arri_time;
        private System.Windows.Forms.Label label_remain_time;
        private System.Windows.Forms.TextBox textBox_proccess_name;
        private System.Windows.Forms.TextBox textBox_arri_time;
        private System.Windows.Forms.TextBox textBox_total_time;
        private System.Windows.Forms.Button button_add_proccess;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Label label_time_now;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.TextBox textBox_time_now;
        private System.Windows.Forms.ComboBox comboBox_speed;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_scheduling_algorithm
{
    public partial class choose_agrithm : Form
    {
        public choose_agrithm()
        {
            InitializeComponent();
        }

        private void 多级轮转调度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultiFeedback sub = new MultiFeedback();
            sub.TopLevel = false;
            sub.Dock = DockStyle.Fill;//把子窗体设置为控件
            sub.FormBorderStyle = FormBorderStyle.None;
            panel_show_agrithm.Controls.Clear();
            panel_show_agrithm.Controls.Add(sub);
            sub.Show();
        }

        private void 短作业优先ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SJF sub = new SJF();
            sub.TopLevel = false;
            sub.Dock = DockStyle.Fill;//把子窗体设置为控件
            sub.FormBorderStyle = FormBorderStyle.None;
            panel_show_agrithm.Controls.Clear();
            panel_show_agrithm.Controls.Add(sub);
            sub.Show();
        }

        private void 高响应比优先ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HRRN sub = new HRRN();
            sub.TopLevel = false;
            sub.Dock = DockStyle.Fill;//把子窗体设置为控件
            sub.FormBorderStyle = FormBorderStyle.None;
            panel_show_agrithm.Controls.Clear();
            panel_show_agrithm.Controls.Add(sub);
            sub.Show();
        }
    }
}

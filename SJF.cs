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
    public partial class SJF : Form
    {
        private BindingList<Pcb> BSPcb;    //进程队列
        public int time;    //当前时间

        public SJF()
        {
            InitializeComponent();
            BSPcb = new BindingList<Pcb>();
            this.dataGridView_SJF.DataSource = BSPcb;
        }

        private void button_add_process_Click(object sender, EventArgs e)
        {
            Pcb initalPcb = new Pcb();

            initalPcb.proccess_name = textBox_proccess_name.Text.Trim();

            try
            {
                int count = Convert.ToInt32(textBox_remain_time.Text); //string类型转换int类型,异常处理
                initalPcb.remain_time = count;    //输入的总时间也即初始剩余时间
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }

            try
            {
                int count = Convert.ToInt32(textBo_arri_time.Text); //string类型转换int类型,异常处理
                initalPcb.arri_time = count;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }

            //BindingList的数据改变时，DataGridView的数据会随之改变，无需重新绑定到DataGridView
            //BSPcb.Add(initalPcb);

            if (BSPcb.Count == 0)
            {
                BSPcb.Add(initalPcb);
            }
            else
            {
                //BSPcb.Insert(0, initalPcb);
                for (int i = 0; i < BSPcb.Count(); i++)
                {
                    if (initalPcb.arri_time < BSPcb[i].arri_time)
                    {
                        BSPcb.Insert(i, initalPcb);
                        break;
                    }

                    if(i == BSPcb.Count - 1)
                    {
                        BSPcb.Add(initalPcb);
                        break;
                    }
                }
            }

            textBox_proccess_name.Clear();
            textBox_remain_time.Clear();
            textBo_arri_time.Clear();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (BSPcb != null && BSPcb.Count() > 0)    //进程队列不为空
            {
                if (BSPcb[0].arri_time <= time)      //有进程已经到达，选择时间最短的进程
                {
                    int t = 0;
                    for(int i = 0; i < BSPcb.Count(); i++)
                    {
                        if (BSPcb[i].arri_time <= time && BSPcb[i].remain_time < BSPcb[t].remain_time)
                            t = i;
                    }
                    time = time + BSPcb[t].remain_time;
                    BSPcb.Remove(BSPcb[t]);
                }
                else    //没有进程到达，继续等待
                {
                    time++;
                }
                textBox_show_time.Text = time.ToString();
            }
        }
        //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red; 


        private void SJF_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;    //设置运行间隔
        }

        /**
         * 控制算法的进行和暂停
         */
        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        /**
         * 重置
         */
        private void button_reset_Click(object sender, EventArgs e)
        {
            BSPcb.Clear();
            time = 0;
        }

        /**
         * 改变运行速度
         */
        private void comboBox_speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            String speed = comboBox_speed.Text;
            if (speed.Equals("0.5x"))
            {
                timer1.Interval = 2000;
            }
            else if (speed.Equals("1.0x"))
            {
                timer1.Interval = 1000;
            }
            else if (speed.Equals("2.0x"))
            {
                timer1.Interval = 500;
            }
        }
    }
}

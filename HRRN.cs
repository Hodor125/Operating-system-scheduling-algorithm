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
    public partial class HRRN : Form
    {
        private BindingList<Pcb_HRRN> BSPcb;    //进程队列
        private int time = 0;    //当前时间

        public HRRN()
        {
            InitializeComponent();
            BSPcb = new BindingList<Pcb_HRRN>();
            this.dataGridView_HRRN.DataSource = BSPcb;
        }

        /**
         * 高响应比优先算法
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (BSPcb != null && BSPcb.Count() > 0)    //进程队列不为空
            {
                for (int i = 0; i < BSPcb.Count(); i++)
                {
                    if (BSPcb[i].arri_time <= time)     //更新已经到达得进程更新等待时间以及响应比
                    {
                        int wait_time = time - BSPcb[i].arri_time;
                        double response_ratio_t = ((double)wait_time + (double)BSPcb[i].remain_time) / (double)BSPcb[i].remain_time;
                        BSPcb[i].wait_time = wait_time;
                        BSPcb[i].response_ratio = response_ratio_t;
                    }
                }

                if (BSPcb[0].arri_time <= time)      //有进程已经到达，选择时间最短的进程
                {
                    int t = 0;
                    double response_ratio = BSPcb[0].response_ratio;
                    for (int i = 0; i < BSPcb.Count(); i++)
                    {
                        if (BSPcb[i].arri_time <= time && BSPcb[i].response_ratio > BSPcb[t].response_ratio)
                            t = i;
                    }
                    time = time + BSPcb[t].remain_time;    //更新时间
                    BSPcb.Remove(BSPcb[t]);
                }
                else    //没有进程到达，继续等待
                {
                    time++;    //更新时间
                }
                textBox_time_now.Text = time.ToString();    //更新时间显示
                for (int i = 0; i < BSPcb.Count(); i++)
                {
                    if (BSPcb[i].arri_time <= time)     //已经到达得进程更新等待时间以及响应比
                    {
                        int wait_time = time - BSPcb[i].arri_time;
                        double response_ratio_t = ((double)wait_time + (double)BSPcb[i].remain_time) / (double)BSPcb[i].remain_time;
                        BSPcb[i].wait_time = wait_time;
                        BSPcb[i].response_ratio = response_ratio_t;
                    }
                }
            }
        }

        private void HRRN_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;     //设置运行间隔
        }

        /**
         * 以下两个函数控制算法的进行
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
         * 添加进程
         */
        private void button_add_proccess_Click(object sender, EventArgs e)
        {
            Pcb_HRRN initalPcb = new Pcb_HRRN();
            int wait_time = 0;
            double response_ratio = 1;    //初始等待时间为0，响应比为1

            initalPcb.proccess_name = textBox_proccess_name.Text.Trim();

            try
            {
                int count = Convert.ToInt32(textBox_total_time.Text); //string类型转换int类型,异常处理
                initalPcb.remain_time = count;    //输入的总时间也即初始剩余时间
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }

            try
            {
                int count = Convert.ToInt32(textBox_arri_time.Text); //string类型转换int类型,异常处理
                initalPcb.arri_time = count;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }

            initalPcb.response_ratio = response_ratio;
            initalPcb.wait_time = wait_time;

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

                    if (i == BSPcb.Count - 1)
                    {
                        BSPcb.Add(initalPcb);
                        break;
                    }
                }
            }

            textBox_proccess_name.Clear();
            textBox_arri_time.Clear();
            textBox_total_time.Clear();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            time = 0;
            BSPcb.Clear();
        }

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

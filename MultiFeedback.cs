using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Process_scheduling_algorithm
{
    public partial class MultiFeedback : Form
    {
        public int time = 0;    //当前时间
        public int time_s1 = 0;
        public int time_s2 = 0;
        public int time_s3 = 0;    //三个优先级队列中的时间片

        private BindingList<Pcb> BSPcb1;    //定义三个BindingList的Pcb列表存储三个队列
        private BindingList<Pcb> BSPcb2;
        private BindingList<Pcb> BSPcb3;

        public MultiFeedback()
        {
            InitializeComponent();
            BSPcb1 = new BindingList<Pcb>();
            this.dataGridView_queue1.DataSource = BSPcb1;    //BindingList作为数据源

            BSPcb2 = new BindingList<Pcb>();
            this.dataGridView_queue2.DataSource = BSPcb2;

            BSPcb3 = new BindingList<Pcb>();
            this.dataGridView_queue3.DataSource = BSPcb3;

        }


        /**
         * 向队列中添加进程
         */
        private void button_add_Click(object sender, EventArgs e)
        {
            Pcb initalPcb = new Pcb();
            initalPcb.proccess_name = textBox_process_name.Text.Trim();

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
                int count = Convert.ToInt32(textBox_insert_arritime.Text); //string类型转换int类型,异常处理
                initalPcb.arri_time = count;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }

            //BindingList的数据改变时，DataGridView的数据会随之改变，无需重新绑定到DataGridView,添加到末尾
            if (BSPcb1.Count == 0)    //按到达时间排序
            {
                BSPcb1.Add(initalPcb);
            }
            else
            {
                //BSPcb.Insert(0, initalPcb);
                for (int i = 0; i < BSPcb1.Count(); i++)
                {
                    if (initalPcb.arri_time < BSPcb1[i].arri_time)
                    {
                        BSPcb1.Insert(i, initalPcb);
                        break;
                    }

                    if (i == BSPcb1.Count - 1)
                    {
                        BSPcb1.Add(initalPcb);
                        break;
                    }
                }
            }

            textBox_process_name.Clear();
            textBox_total_time.Clear();
            textBox_insert_arritime.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;    //毫秒为单位
        }


        /**
         * 多级反馈队列算法执行
         * 使用timer有时间间隔方便可视化
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox_show_name.Clear();    //清空上一次运行的
            textBox_show_time.Clear();
            textBox_show_priority.Clear();
            textBox_show_remain_time.Clear();

            if (BSPcb1 != null && BSPcb1.Count > 0)        //优先级最高的队列中有进程
            {
                if(BSPcb1[0].arri_time <= time)    //有进程已经到达
                {
                    int priority1 = 3;    //下方显示信息
                    textBox_show_name.Text = BSPcb1[0].proccess_name;
                    textBox_show_time.Text = BSPcb1[0].arri_time.ToString();
                    textBox_show_remain_time.Text = BSPcb1[0].remain_time.ToString();
                    textBox_show_time_now.Text = time.ToString();
                    textBox_show_priority.Text = priority1.ToString();

                    if (BSPcb1[0].remain_time > time_s1)        //运行完时间片后还未完成
                    {
                        BSPcb1[0].remain_time = BSPcb1[0].remain_time - time_s1;

                        Pcb initalPcb = new Pcb();        //将运行过时间片的进程移到次优先级的队列中
                        initalPcb.arri_time = BSPcb1[0].arri_time;
                        initalPcb.proccess_name = BSPcb1[0].proccess_name;
                        initalPcb.remain_time = BSPcb1[0].remain_time;

                        BSPcb2.Add(initalPcb);
                        BSPcb1.Remove(BSPcb1[0]);
                        time = time + time_s1;        //当前时间加上一个时间片
                    }
                    else
                    {
                        time = time + BSPcb1[0].remain_time;        //当前时间加上已经运行的时间
                        BSPcb1.Remove(BSPcb1[0]);
                    }
                }
                else
                {
                    time++;    //没有进程到达则等待
                }
                textBox_show_time_now.Text = time.ToString();    //更新当前时间的显示
            }
            else if(BSPcb2 !=null && BSPcb2.Count > 0)    //次高优先级队列中有进程
            {
                int priority2 = 2;    //下方显示信息
                textBox_show_name.Text = BSPcb2[0].proccess_name;
                textBox_show_time.Text = BSPcb2[0].arri_time.ToString();
                textBox_show_remain_time.Text = BSPcb2[0].remain_time.ToString();
                textBox_show_time_now.Text = time.ToString();
                textBox_show_priority.Text = priority2.ToString();

                if(BSPcb2[0].remain_time > time_s2)        //运行完时间片之后还未完成
                {
                    BSPcb2[0].remain_time = BSPcb2[0].remain_time - time_s2;

                    Pcb initalPcb = new Pcb();
                    initalPcb.proccess_name = BSPcb2[0].proccess_name;
                    initalPcb.arri_time = BSPcb2[0].arri_time;
                    initalPcb.remain_time = BSPcb2[0].remain_time;

                    BSPcb3.Add(initalPcb);
                    BSPcb2.Remove(BSPcb2[0]);
                    time = time + time_s2;        //当前的时间加上时间片
                }
                else
                {
                    time = time + BSPcb2[0].remain_time;       //当前时间加上运行的时间
                    BSPcb2.Remove(BSPcb2[0]);
                }
                textBox_show_time_now.Text = time.ToString();
            }
            else if(BSPcb3 != null && BSPcb3.Count > 0)       //最低优先级队列中有进程
            {
                int priority3 = 1;    //下方显示信息
                textBox_show_name.Text = BSPcb3[0].proccess_name;
                textBox_show_time.Text = BSPcb3[0].arri_time.ToString();
                textBox_show_remain_time.Text = BSPcb3[0].remain_time.ToString();
                textBox_show_time_now.Text = time.ToString();
                textBox_show_priority.Text = priority3.ToString();

                if(BSPcb3[0].remain_time > time_s3)
                {
                    BSPcb3[0].remain_time = BSPcb3[0].remain_time - time_s3;

                    Pcb initalPcb = new Pcb();
                    initalPcb.proccess_name = BSPcb3[0].proccess_name;
                    initalPcb.arri_time = BSPcb3[0].arri_time;
                    initalPcb.remain_time = BSPcb3[0].remain_time;

                    BSPcb3.Remove(BSPcb3[0]);
                    BSPcb3.Add(initalPcb);        //从队首移除放入队尾
                    time = time + time_s3;
                }
                else
                {
                    time = time + BSPcb3[0].remain_time;
                    BSPcb3.Remove(BSPcb3[0]);
                }
                textBox_show_time_now.Text = time.ToString();
            }
            //else        //所有进程已经完成
            //{
            //    MessageBox.Show("所有进程执行完毕");
            //    timer1.Enabled = false;        //算法循环停止
            //}
        }

        /**
         * 以下两个函数用来停止和继续调度算法
         */
        private void button_pause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


        /**
         * 确认时间片
         */
        private void button_confirm_time_Click(object sender, EventArgs e)
        {
            try
            {
                int count = Convert.ToInt32(textBox_time_slice1.Text); //string类型转换int类型,异常处理
                time_s1 = count;    //存放时间片
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }

            try
            {
                int count = Convert.ToInt32(textBox_time_slice2.Text); //string类型转换int类型,异常处理
                time_s2 = count;    //存放时间片
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }

            try
            {
                int count = Convert.ToInt32(textBox_time_slice3.Text); //string类型转换int类型,异常处理
                time_s3 = count;    //存放时间片
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }

            MessageBox.Show("时间片输入完成");
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            BSPcb1.Clear();
            BSPcb2.Clear();
            BSPcb3.Clear();
            textBox_show_name.Clear();
            textBox_show_time.Clear();
            textBox_show_time_now.Clear();
            textBox_show_priority.Clear();
            textBox_show_remain_time.Clear();
            time = 0;
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

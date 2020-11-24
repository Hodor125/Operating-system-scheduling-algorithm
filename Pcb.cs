using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * author@E21714005_lml
 * time:2020/4/28
 */

namespace Process_scheduling_algorithm
{
    /**
     * 短作业优先和时间片轮转调度数据结构
     */
    class Pcb
    {
        /**
         * 必须定义set和get方法，否则在作为数据源绑定后无法显示
         */

        public String proccess_name { get; set; }    //进程名
        public int arri_time{ get; set; }    //到达时间
        public int remain_time { get; set; }   //剩余时间

        //public int token_time;    //已使用时间
        //public int priority;    //优先级从低到高为1、2、3
        //public int time_slice;    //时间片
        //public String status;    //当前状态
        //public int total_time;    //总时间
    }


    /**
     * 高响应比优先算法数据结构
     */
    class Pcb_HRRN
    {
        public String proccess_name { get; set; }    //进程名
        public int arri_time { get; set; }    //到达时间
        public int remain_time { get; set; }   //剩余时间
        public int wait_time { get; set; }    //等待时间
        public double response_ratio { get; set; }    //响应比
    }

}

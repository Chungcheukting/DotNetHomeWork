using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Clock
{
    public delegate void ClockTick(DateTime dateTime);
    public delegate void ClockAlarm(DateTime time);

    public struct TimeStruct
    {
        public int sec, min, hour;
        public void add()
        {
            sec++;
            if (sec == 60) { sec = 0; min++; }
            if (min == 60) { min = 0; hour++; }
            if (hour == 24) { hour = 0; }
        }
        public void set(int a, int b, int c)
        {
            hour = a; min = b; sec = c;
        }
        public void Output()
        {
            string str = Convert.ToString(hour + ":" + min + ":" + sec);
            Console.WriteLine(str);
        }
    }

    static class Time
    {
        static public bool shutdown;
        static public event ClockTick Tick;
        static public event ClockAlarm alarm;
        static public DateTime LastTime;


        static public TimeStruct UserTime;
        static public TimeStruct TargetTime;
        static public void checkTick()
        {
            DateTime NowTime = DateTime.Now;
            if (NowTime.Second != LastTime.Second)
                Tick(NowTime);
            LastTime = NowTime;
        }
        static public void checkAlarm()
        {
            DateTime NowTime = DateTime.Now;
            if (NowTime.Hour == TargetTime.hour && NowTime.Minute == TargetTime.min)
                alarm(NowTime);
        }
    }

    public class Clock
    {
        public int Switch()
        {
            Console.WriteLine("请选择打开或者关闭闹钟：0.关闭  1.打开");
            int state = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("显示当前时间：" + DateTime.Now.ToString("HH:mm:ss"));
            return state;
        }

        public void TickFunc(DateTime t)
        {
            Console.WriteLine("嘀嗒~嘀嗒~");
            Time.checkAlarm();
            Time.UserTime.add();
            Time.UserTime.Output();
            //Time.PassedTime.add();
           // Console.Clear();
        }

        public void AlarmFunc(DateTime time)
        {
            Console.WriteLine("叮铃铃~叮铃铃~");
            Time.shutdown = true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Clock c = new Clock();
            c.Switch();
            //c.setTime();
            Console.WriteLine("请设定闹钟时间：（XX时XX分）");
            int hour = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            Time.TargetTime.set(hour, min, 0);

            Time.Tick += new ClockTick(c.TickFunc);
            Time.alarm += new ClockAlarm(c.AlarmFunc);

            while (true)
            {
                if (Time.shutdown) break;
                Time.checkTick();
            }
            Console.ReadKey();
        }
    }
}

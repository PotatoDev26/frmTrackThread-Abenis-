using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace frmTrackThread_Abenis_
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            int loopCount;
            for(int i = 1; i <= 2; i++)
            {
                loopCount = i;
                Thread.Sleep(500);

                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
            }
        }
        public static void Thread2()
        {
            int loopCount;
            for (int i = 1; i <= 6; i++)
            {
                loopCount = i;
                Thread.Sleep(1500);

                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
            }
        }
    }
}

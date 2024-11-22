using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTrackThread_Abenis_
{
    public partial class Form1 : Form
    {
        Thread threadA, threadB, threadC, threadD;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string threadstart = "-THREAD START-";
            string threadend = "-END OF THREAD-";
            Console.WriteLine(threadstart);
            label1.Text = threadstart;
            ThreadStart firstMainThread = new ThreadStart(MyThreadClass.Thread1);
            Console.WriteLine("Thread Sequence 1:");
            threadA = new Thread(firstMainThread);
            threadA.Name = "Thread A";
            threadA.Priority = ThreadPriority.Highest;

            threadB = new Thread(firstMainThread);
            threadB.Name = "Thread B";
            threadA.Priority = ThreadPriority.Normal;

            threadC = new Thread(firstMainThread);
            threadC.Name = "Thread C";
            threadA.Priority = ThreadPriority.AboveNormal;

            threadD = new Thread(firstMainThread);
            threadD.Name = "Thread D";
            threadA.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            ThreadStart secondMainThread = new ThreadStart(MyThreadClass.Thread2);
            Console.WriteLine("Thread Sequence 2:");
            threadA = new Thread(secondMainThread);
            threadA.Name = "Thread A";
            threadA.Priority = ThreadPriority.Highest;

            threadB = new Thread(secondMainThread);
            threadB.Name = "Thread B";
            threadA.Priority = ThreadPriority.Normal;

            threadC = new Thread(secondMainThread);
            threadC.Name = "Thread C";
            threadA.Priority = ThreadPriority.AboveNormal;

            threadD = new Thread(secondMainThread);
            threadD.Name = "Thread D";
            threadA.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            label1.Text = threadend;
            Console.WriteLine(threadend);
        }
    }
}

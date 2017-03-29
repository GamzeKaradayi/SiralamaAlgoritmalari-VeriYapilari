using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SortingAlgoritma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        int[] yuz = new int[100];
        int[] yediyuzelli = new int[750];
        int[] binbesyuz = new int[1500];
        int[] yedibinbesyuz = new int[7500];
        int[] onbesbin = new int[15000];
        int[] yetmisbesbin = new int[75000];
        int[] yuzellibin = new int[150000];


        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            Random r = new Random();

            for (i = 0; i < 100; i++)
            {
                yuz[i] = r.Next(100);
            }

            for (i = 0; i < 750; i++)
            {
                yediyuzelli[i] = r.Next(750);
            }

            for (i = 0; i < 1500; i++)
            {
                binbesyuz[i] = r.Next(1500);
            }

            for (i = 0; i < 7500; i++)
            {
               yedibinbesyuz[i] = r.Next(10);
                
            }
            for (i = 0; i < 15000; i++)
            {
                onbesbin[i] = r.Next(15000);
            }
            for (i = 0; i < 75000; i++)
            {
                yetmisbesbin[i] = r.Next(75000);
            }
            for (i = 0; i < 150000; i++)
            {
                yuzellibin[i] = r.Next(150000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BubbleSort bb = new BubbleSort();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            bb.Sort(yuz);
            sw.Stop();
            listBox1.Items.Add("100-->"+sw.ElapsedMilliseconds.ToString());

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            bb.Sort(yediyuzelli);
            sw2.Stop();
            listBox1.Items.Add("750-->" + sw2.ElapsedMilliseconds.ToString());

            Stopwatch sw3 = new Stopwatch();
            sw3.Start();
            bb.Sort(binbesyuz);
            sw3.Stop();
            listBox1.Items.Add("1500-->" + sw3.ElapsedMilliseconds.ToString());

            Stopwatch sw4 = new Stopwatch();
            sw4.Start();
            bb.Sort(yedibinbesyuz);
            sw4.Stop();
            listBox1.Items.Add("7500-->" + sw4.ElapsedMilliseconds.ToString());

            Stopwatch sw5 = new Stopwatch();
            sw5.Start();
            bb.Sort(onbesbin);
            sw5.Stop();
            listBox1.Items.Add("15000-->" + sw5.ElapsedMilliseconds.ToString());

            Stopwatch sw6 = new Stopwatch();
            sw6.Start();
            bb.Sort(yetmisbesbin);
            sw6.Stop();
            listBox1.Items.Add("75000-->" + sw6.ElapsedMilliseconds.ToString());

            Stopwatch sw7 = new Stopwatch();
            sw7.Start();
            bb.Sort(yuzellibin);
            sw7.Stop();
            listBox1.Items.Add("150000-->" + sw7.ElapsedMilliseconds.ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertionSort ıs = new InsertionSort();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ıs.Sort(yuz);
            sw.Stop();
            listBox1.Items.Add("100-->" + sw.ElapsedMilliseconds.ToString());

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            ıs.Sort(yediyuzelli);
            sw2.Stop();
            listBox1.Items.Add("750-->" + sw2.ElapsedMilliseconds.ToString());

            Stopwatch sw3 = new Stopwatch();
            sw3.Start();
            ıs.Sort(binbesyuz);
            sw3.Stop();
            listBox1.Items.Add("1500-->" + sw3.ElapsedMilliseconds.ToString());

            Stopwatch sw4 = new Stopwatch();
            sw4.Start();
            ıs.Sort(yedibinbesyuz);
            sw4.Stop();
            listBox1.Items.Add("7500-->" + sw4.ElapsedMilliseconds.ToString());

            Stopwatch sw5 = new Stopwatch();
            sw5.Start();
            ıs.Sort(onbesbin);
            sw5.Stop();
            listBox1.Items.Add("15000-->" + sw5.ElapsedMilliseconds.ToString());

            Stopwatch sw6 = new Stopwatch();
            sw6.Start();
            ıs.Sort(yetmisbesbin);
            sw6.Stop();
            listBox1.Items.Add("75000-->" + sw6.ElapsedMilliseconds.ToString());

            Stopwatch sw7 = new Stopwatch();
            sw7.Start();
            ıs.Sort(yuzellibin);
            sw7.Stop();
            listBox1.Items.Add("150000-->" + sw7.ElapsedMilliseconds.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectionSort ss = new SelectionSort();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ss.Sort(yuz);
            sw.Stop();
            listBox1.Items.Add("100-->" + sw.ElapsedMilliseconds.ToString());

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            ss.Sort(yediyuzelli);
            sw2.Stop();
            listBox1.Items.Add("750-->" + sw2.ElapsedMilliseconds.ToString());

            Stopwatch sw3 = new Stopwatch();
            sw3.Start();
            ss.Sort(binbesyuz);
            sw3.Stop();
            listBox1.Items.Add("1500-->" + sw3.ElapsedMilliseconds.ToString());

            Stopwatch sw4 = new Stopwatch();
            sw4.Start();
            ss.Sort(yedibinbesyuz);
            sw4.Stop();
            listBox1.Items.Add("7500-->" + sw4.ElapsedMilliseconds.ToString());

            Stopwatch sw5 = new Stopwatch();
            sw5.Start();
            ss.Sort(onbesbin);
            sw5.Stop();
            listBox1.Items.Add("15000-->" + sw5.ElapsedMilliseconds.ToString());

            Stopwatch sw6 = new Stopwatch();
            sw6.Start();
            ss.Sort(yetmisbesbin);
            sw6.Stop();
            listBox1.Items.Add("75000-->" + sw6.ElapsedMilliseconds.ToString());

            Stopwatch sw7 = new Stopwatch();
            sw7.Start();
            ss.Sort(yuzellibin);
            sw7.Stop();
            listBox1.Items.Add("150000-->" + sw7.ElapsedMilliseconds.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuickSort qs = new QuickSort();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            qs.Sort(yuz);
            sw.Stop();
            listBox1.Items.Add("100-->" + sw.ElapsedMilliseconds.ToString());

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            qs.Sort(yediyuzelli);
            sw2.Stop();
            listBox1.Items.Add("750-->" + sw2.ElapsedMilliseconds.ToString());

            Stopwatch sw3 = new Stopwatch();
            sw3.Start();
            qs.Sort(binbesyuz);
            sw3.Stop();
            listBox1.Items.Add("1500-->" + sw3.ElapsedMilliseconds.ToString());

            Stopwatch sw4 = new Stopwatch();
            sw4.Start();
            qs.Sort(yedibinbesyuz);
            sw4.Stop();
            listBox1.Items.Add("7500-->" + sw4.ElapsedMilliseconds.ToString());

            Stopwatch sw5 = new Stopwatch();
            sw5.Start();
            qs.Sort(onbesbin);
            sw5.Stop();
            listBox1.Items.Add("15000-->" + sw5.ElapsedMilliseconds.ToString());

            Stopwatch sw6 = new Stopwatch();
            sw6.Start();
            qs.Sort(yetmisbesbin);
            sw6.Stop();
            listBox1.Items.Add("75000-->" + sw6.ElapsedMilliseconds.ToString());

            Stopwatch sw7 = new Stopwatch();
            sw7.Start();
            qs.Sort(yuzellibin);
            sw7.Stop();
            listBox1.Items.Add("150000-->" + sw7.ElapsedMilliseconds.ToString());

        }
    }
}

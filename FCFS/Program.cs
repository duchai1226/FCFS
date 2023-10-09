using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCFS
{
    class Program
    {
        static void Main(string[] args)
        {
            XuLyTienTrinh fcfs = new XuLyTienTrinh();
            fcfs.Nhap();
            fcfs.DSXL = fcfs.Sort_TimeToReadyList();
            fcfs.Process();
            fcfs.Xuat();
            Console.ReadKey();
        }
    }
}

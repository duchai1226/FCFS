using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCFS
{
    class XuLyTienTrinh
    {
        List<TienTrinh> xltt ;
        int _NumberProcess;
        public int NumberProcess
        {
            get
            {
                return _NumberProcess;
            }
            set
            {
                if (value >= 0)
                    _NumberProcess = value;
                else
                    Console.WriteLine("Du lieu khong dung");
            }
        }
        public List<TienTrinh> DSXL
        {
            get
            {
                return xltt;
            }
            set
            {
                xltt = value;
            }
        }
        public XuLyTienTrinh()
        {
            xltt = new List<TienTrinh>(); 
        }
        public void Nhap()
        {
            Console.Write("Nhap so tien trinh can tinh toan: ");
            NumberProcess = int.Parse(Console.ReadLine());
            for(int i=0;i<NumberProcess;i++)
            {
                Console.Write("\nNhap thong tin tien trinh P{0}: ",i+1);
                TienTrinh a = new TienTrinh();
                a.Name = "P" + (i+1);
                a.Nhap();
                xltt.Add(a);
            }
        }
        public List<TienTrinh> Sort_TimeToReadyList()
        {
            return xltt.OrderBy(t => t.TimeToReadyList).ToList();
        }
        public void Process()
        {
            xltt[0].Start = 0;
            xltt[0].CT(); 
            for(int i=1;i<_NumberProcess;i++)
            {
                for (int j = i-1; j < _NumberProcess; j++)
                {
                    if(xltt[i].TimeToReadyList<=xltt[j].CompletionTime)
                    {
                        xltt[i].Start = xltt[j].Start + xltt[j].BurstTime;
                        xltt[i].CT();
                        break;
                    }
                    else
                    {
                        xltt[i].Start = xltt[i].TimeToReadyList;
                        xltt[i].CT();
                        break;
                    }
                }
            }
        }
        public double AWT()
        {
            return xltt.Sum(t => t.WT()) / _NumberProcess;
        }
        public double AFT()
        {
            return xltt.Sum(t => t.FT()) / _NumberProcess;
        }
        public void Xuat()
        {
            Console.WriteLine("\n\n\n  Tien trinh\t  TG den hang cho\tTG Xu Ly\tTG Hoan tat\tTG Doi");
            foreach(TienTrinh i in xltt)
            {
                Console.WriteLine("\n\t{0}\t\t{1}\t\t   {2}\t\t   {3}\t\t{4}", i.Name, i.TimeToReadyList, i.BurstTime, i.FT(), i.WT());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCFS
{
    class TienTrinh
    {
        protected string _Name;
        protected double _TimeToReadyList; //Tgian đến hàng chờ
        protected double _BurstTime; //Tgian xử lý
        double _Start;
        double _CompletionTime;
    
        public double TimeToReadyList
        {
            get
            {
                return _TimeToReadyList;
            }
            set
            {
                if (value >= 0)
                    _TimeToReadyList = value;
                else
                    Console.WriteLine("Du lieu khong dung");
            }
        }
        public double BurstTime
        {
            get
            {
                return _BurstTime;
            }
            set
            {
                if (value >= 0)
                    _BurstTime = value;
                else
                    Console.WriteLine("Du lieu khong dung");
            }
        }
        public double Start
        {
            get
            {
                return _Start;
            }
            set
            {
                _Start = value;
            }
        }
        public double CompletionTime
        {
            get
            {
                return _CompletionTime;
            }
            set
            {
                _CompletionTime = value;
            }
        }
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public TienTrinh()
        {
            _Name = String.Empty;
            _BurstTime = 0;
            _TimeToReadyList = 0;
            _Start = 0;
            _CompletionTime = 0;
        }
        public TienTrinh(string _Name,double _TimeToReadyList,double _BurstTime,double _CompletionTime)
        {
            this._Name = _Name;
            this._TimeToReadyList = _TimeToReadyList;
            this._BurstTime = _BurstTime;
            this._CompletionTime = _CompletionTime;
        }
        public void Nhap()
        {
            Console.Write("\nNhap thoi gian den hang cho: ");
            double.TryParse(Console.ReadLine(), out _TimeToReadyList);
            Console.Write("Nhap thoi gian xu ly: ");
            double.TryParse(Console.ReadLine(), out _BurstTime);
        }
        public void CT()
        {
            CompletionTime = _Start + _BurstTime;
        }
        public double FT()
        {
            return _CompletionTime - _TimeToReadyList;
        }
        public double WT()
        {
            return _Start - _TimeToReadyList;
        }
    }
}

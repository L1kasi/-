using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Frst= int.Parse(Console.ReadLine());
            p.Icallit(p);
        }
        private int frst;
        public int Frst
        {
            get
            {
                return frst;
            }
            set
            {
                frst = value;
            }
        }
        private int scnd;
        public int Scnd
        {
            get
            {
                return scnd;
            }
            set
            {
                scnd = value;
            }
        }
        private int sum;
        public int Sum
        {
            get
            {
                return sum;
            }
            set
            {
                sum = value;
            }
        }

        public void Icallit(Program p)
        {
            p.Scnd= int.Parse(Console.ReadLine());
            v.Summ(p);
            
        }
        public Visit v = new Visit();
    }
    class Visit
    {
       
        public void Summ(Program p)
        {
            p.Sum = p.Frst + p.Scnd;
            Console.WriteLine(p.Sum);
            Console.ReadKey();
        }
    }
 }

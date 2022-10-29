using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public delegate void AcHen(string message);
    public class Account
    {
        public int sum;
        public string fio;
        AcHen taken;
        public Account(string fio, int sum)
        {
            this.sum = sum;
            this.fio = fio;
        }
        public void RegHan(AcHen del)
        {
            taken = del;
        }
        public void Add(int sum)
        {
            this.sum += sum;


        }

        public void Take(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                taken?.Invoke($"Со счета списано {sum}р");

            }
            else
            {
                taken?.Invoke($"Недостаточно средств. На счете {this.sum}р");
            }
        }
    }
}

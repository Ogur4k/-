using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account account;
        private void button1_Click(object sender, EventArgs e)
        {
            account = new Account(textBox1.Text, Convert.ToInt32(textBox3.Text));
            listBox1.Items.Add($"Имя пользователя {account.fio}. Состояние счета: {account.sum}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            account.Add(Convert.ToInt32(textBox2.Text));
            listBox1.Items.Add($"Состояние счета: {account.sum}");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //account.Take(Convert.ToInt32(textBox2.Text));
            //listBox1.Items.Add($"Состояние счета: {account.sum}");
            int x = Convert.ToInt32(textBox2.Text);
            if (account.sum < x)
            {
                listBox1.Items.Add("На счету недосатточно средств");
            }
            else
            {
                account.Take(Convert.ToInt32(textBox2.Text));
                listBox1.Items.Add($"Состояние счета: {account.sum}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P133WinFormTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            long result = await LoopAsync();

            //Task task = Task.Run(() =>
            //{
            //    for (long i = 0; i < 9999999999; i++)
            //    {
            //        result += i;
            //    }
            //});

            //await task;

            lbl_1.Text = result.ToString();
        }

        async Task<long> LoopAsync()
        {
            long result = 0;

            Task task = Task.Run(() =>
            {
                for (long i = 0; i < 9999999999; i++)
                {
                    result += i;
                }
            });

            await task;

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Son Chsarp Dersi");
        }
    }
}

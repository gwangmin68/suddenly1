using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Response;
using System.Net;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }
        string link = "";
        private void btn_search_Click(object sender, EventArgs e)
        {
            new Form2(textBox1.Text).ShowDialog();
        }

        private int getminprice(string name)
        {

            var client = new RestClient("http://192.168.1.76/NAVER");
            var request = new RestRequest(name, Method.GET);
            int i = 999999;
            IRestResponse<Snack> response = client.Execute<Snack>(request);
            if (response.IsSuccessful)
            {

                var data = response.Data;
                foreach (var item in data.items)
                {
                    if (int.Parse(item.lprice) < i)
                    {
                        i = int.Parse(item.lprice);
                        link = item.link;
                    }

                }
            }

            return i;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            꼬깔콘.Text = "" + (getminprice("꼬깔콘")) + "원";
            string 꼬깔콘링크 = link;
            꼬깔콘사진.MouseClick += new MouseEventHandler((object sendler, MouseEventArgs error) =>
            {

                System.Diagnostics.Process.Start(꼬깔콘링크);
            });
            새우깡.Text = "" + (getminprice("새우깡")) + "원";
            string 새우깡링크 = link;
            새우깡사진.MouseClick += new MouseEventHandler((object sendler, MouseEventArgs error) =>
            {

                System.Diagnostics.Process.Start(새우깡링크);
            });

            포카칩.Text = "" + (getminprice("포카칩")) + "원";
            string 포카칩링크 = link;
            포카칩사진.MouseClick += new MouseEventHandler((object sendler, MouseEventArgs error) =>
            {

                System.Diagnostics.Process.Start(포카칩링크);
            });
            치토스.Text = "" + (getminprice("치토스")) + "원";
            string 치토스링크 = link;
            치토스사진.MouseClick += new MouseEventHandler((object sendler, MouseEventArgs error) =>
            {

                System.Diagnostics.Process.Start(치토스링크);
            });

            프링글스.Text = "" + (getminprice("프링글스")) + "원";
            string 프링글스링크 = link;
            프링글스사진.MouseClick += new MouseEventHandler((object sendler, MouseEventArgs error) =>
            {

                System.Diagnostics.Process.Start(프링글스링크);
            });

            콘칩.Text = "" + (getminprice("콘칩")) + "원";

            string 콘칩링크 = link;
            콘칩사진.MouseClick += new MouseEventHandler((object sendler, MouseEventArgs error) =>
            {
                System.Diagnostics.Process.Start(콘칩링크);



            }); 썬칩.Text = "" + (getminprice("썬칩")) + "원";

            string 썬칩링크 = null;

            썬칩사진.MouseClick += new MouseEventHandler((object sendler, MouseEventArgs error) =>
            {

                System.Diagnostics.Process.Start(썬칩링크);
            });

            콘초.Text = "" + (getminprice("콘초")) + "원";

            string 콘초링크 = link;
            콘초사진.MouseClick += new MouseEventHandler((object sendler, MouseEventArgs error) =>
            {

                System.Diagnostics.Process.Start(콘초링크);
            });

            오감자.Text = "" + (getminprice("오감자")) + "원";

            string 오감자링크 = link;
            오감자사진.MouseClick += new MouseEventHandler((object sendler, MouseEventArgs error) =>
            {

                System.Diagnostics.Process.Start(오감자링크);
            });

            허니버터칩.Text = "" + getminprice("허니버터칩") + "원"; 

            string 허니버터칩링크 = link;
            허니버터칩사진.MouseClick += new MouseEventHandler((object sendler, MouseEventArgs error) =>
            {

                System.Diagnostics.Process.Start(허니버터칩링크);
            });

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 새우깡_Click(object sender, EventArgs e)
        {

        }

        private void 포카칩_Click(object sender, EventArgs e)
        {

        }
        private void 꼬깔콘버튼_Click(object sender, EventArgs e)
        {
            //   new Form3("꼬깔콘", int.Parse(꼬깔콘.Text.Substring(0, 꼬깔콘.Text.Length-1)), 꼬깔콘사진.Image).Show();
        }

        private void 치토스사진_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private decimal getmoney(decimal cnt, string price)
        {
            return cnt * int.Parse(price.Substring(0, price.Length - 1));
        }
        private void button2_Click(object sender, EventArgs e)
        {

            string[] listView = new string[10] { "", "", "", "", "", "", "", "", "", "" };
            decimal[] arrint = new decimal[10] { getmoney(꼬깔콘갯수.Value, 꼬깔콘.Text),
                getmoney(새우깡갯수.Value, 새우깡.Text),
                getmoney(포카칩갯수.Value, 포카칩.Text),
                getmoney(치토스갯수.Value, 치토스.Text),
                getmoney(프링글스갯수.Value, 프링글스.Text),
                getmoney(콘칩갯수.Value, 콘칩.Text)
                ,getmoney(오감자갯수.Value, 오감자.Text),
                getmoney(콘초갯수.Value, 콘초.Text),
                getmoney(썬칩갯수.Value, 썬칩.Text),
                getmoney(콘초갯수.Value, 콘초.Text)};
            if (꼬깔콘갯수.Value > 0)
                listView[0] = ("꼬깔콘x" + 꼬깔콘갯수.Value);
            if (새우깡갯수.Value > 0)
                listView[1] = ("새우깡x" + 새우깡갯수.Value);
            if (포카칩갯수.Value > 0)
                listView[2] = ("포카칩x" + 포카칩갯수.Value);
            if (치토스갯수.Value > 0)
                listView[3] = ("치토스x" + 치토스갯수.Value);
            if (프링글스갯수.Value > 0)
                listView[4] = ("프링글스x" + 프링글스갯수.Value);
            if (콘칩갯수.Value > 0)
                listView[5] = ("콘칩x" + 콘칩갯수.Value);
            if (오감자갯수.Value > 0)
                listView[6] = ("오감자x" + 오감자갯수.Value);
            if (콘초갯수.Value > 0)
                listView[7] = ("콘초x" + 콘초갯수.Value);
            if (썬칩갯수.Value > 0)
                listView[8] = ("썬칩x" + 썬칩갯수.Value);
            if (콘초갯수.Value > 0)
                listView[9] = ("콘초x" + 콘초갯수.Value);

            new Form3(listView, arrint).ShowDialog();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search_Click(sender, e);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

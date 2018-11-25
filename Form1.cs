using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Manage
{
    public partial class Form1 : Form
    {
        Button[] pc;   //PC방 자리들
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameChange change = new nameChange(this);   //현재 객체를 멱줌
            change.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pcSetting pcsetting = new pcSetting(this);   //현재 객체를 멱줌
            pcsetting.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public void setPC(int total)
        {
            this.pc = new Button[total];   //pc개만큼 생성
            for(int i = 0; i < total; i++)
            {
                pc[i] = new Button();
                pc[i].Text = (i+1).ToString();
                pc[i].Size = new Size(35, 35);
                pc[i].Location = new Point((i % 10) * 35+180, ((i / 10) * 35)+50);
                pc[i].Click += pc_Click;
                pc[i].BackColor = Color.White;
                Controls.Add(pc[i]);
            }
        }

        //버튼 클릭 시 이벤트
        private void pc_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Green;
                present++;
            }
            else
            {
                btn.BackColor = Color.White;
                present--;
            }
            setPresent(present);
        }

        private void presentSpace_Click(object sender, EventArgs e)
        {

        }
    }
}

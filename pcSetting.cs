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
    public partial class pcSetting : Form
    {
        public pcSetting()
        {
            InitializeComponent();
        }
        public pcSetting(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void pcSetting_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (total <= 0)
                {
                    //System.Windows.Forms.MessageBox.Show("숫자를 정해주세요!", "미입력", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("공백 입력");
                }
                else
                {
                    mainForm.setTotal(this.total);
                    mainForm.setPC(total);
                    Application.DoEvents(); //즉시 변경
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("숫자를 정해주세요!","미입력",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                this.Close();   //창 닫기
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            total = int.Parse(textBox1.Text);
        }
    }
}

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
    public partial class nameChange : Form
    {
        public nameChange()
        {
            InitializeComponent();
        }
        public nameChange(Form1 mainForm)   //메인 폼을 받아옴
        {
            InitializeComponent();  //초기화
            this.mainForm = mainForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            changeValue = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (changeValue.Length > 0)
                {
                    mainForm.setName(changeValue);
                    Application.DoEvents(); //즉시 변경
                }
                else if (changeValue.Length == 0)
                {
                    throw new Exception("이름을 입력하세요");
                   // MessageBox.Show("이름을 입력해주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("이름을 입력해주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();   //창 닫기
        }
    }
}

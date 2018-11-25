namespace PC_Manage
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.presentSpace = new System.Windows.Forms.Label();
            this.totalSpace = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(293, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 55);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(56, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 없음";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "이름 변경";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(746, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "자리 수";
            // 
            // presentSpace
            // 
            this.presentSpace.AutoSize = true;
            this.presentSpace.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.presentSpace.Location = new System.Drawing.Point(771, 177);
            this.presentSpace.Name = "presentSpace";
            this.presentSpace.Size = new System.Drawing.Size(23, 28);
            this.presentSpace.TabIndex = 3;
            this.presentSpace.Text = "0";
            this.presentSpace.Click += new System.EventHandler(this.presentSpace_Click);
            // 
            // totalSpace
            // 
            this.totalSpace.AutoSize = true;
            this.totalSpace.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalSpace.Location = new System.Drawing.Point(812, 177);
            this.totalSpace.Name = "totalSpace";
            this.totalSpace.Size = new System.Drawing.Size(23, 28);
            this.totalSpace.TabIndex = 4;
            this.totalSpace.Text = "0";
            this.totalSpace.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(800, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "/";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(735, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "자리수 변경";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 561);
            this.Controls.Add(this.totalSpace);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.presentSpace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "PC방 관리";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void setName(string name)
        {
            pcName = name;
            label1.Text = name;
        }

        public void setTotal(int total)
        {
            this.total = total;
            this.present = 0;
            totalSpace.Text = total.ToString();
            presentSpace.Text = "0";
        }

        public void setPresent(int n)
        {
            presentSpace.Text = n.ToString();
        }


        private string pcName;  //pc방 이름
        private int present;    //현재 자리수
        private int total;      //총 자리수
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;  //pc방 이름
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;  //자리 수
        private System.Windows.Forms.Label presentSpace;  //현재 자리
        private System.Windows.Forms.Label totalSpace;  //총 자리
        private System.Windows.Forms.Label label5;  // '/'나타냄
        private System.Windows.Forms.Button button2;    //자리수 변경 변수
    }
}


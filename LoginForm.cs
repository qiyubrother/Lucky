using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Lucky
{
    public partial class LoginForm : Form
    {
        bool restart = false;   //���

        private static int acolor=0;
        bool coloradd = true;

        public LoginForm()
        {
            InitializeComponent();
        }

        //ϵͳ����
        private void btnset_Click(object sender, EventArgs e)
        {
            SetForm set = new SetForm();
            set.ShowDialog();
        }

        //����齱
        private void btnstart_Click(object sender, EventArgs e)
        {
            if (rdo1.Checked == true)
            {
                LuckyForm luck1 = new LuckyForm();
                luck1.choose = 1;
                luck1.ShowDialog();
            }
            else if (rdo2.Checked == true)
            {
                LuckyForm luck2 = new LuckyForm();
                luck2.choose = 2;
                luck2.ShowDialog();
            }
            else if (rdo3.Checked == true)
            {
                LuckyForm luck3 = new LuckyForm();
                luck3.choose = 3;
                luck3.ShowDialog();
            }

            else if (rdo4.Checked == true)
            {
                LuckyForm luck4= new LuckyForm();
                luck4.choose = 4;
                luck4.ShowDialog();
            }
            else if (rdo5.Checked == true)
            {
                LuckyForm luck5 = new LuckyForm();
                luck5.choose = 5;
                luck5.ShowDialog();
            }
            else if (rdot.Checked == true)
            {
                LuckyForm luck = new LuckyForm();
                luck.choose = 0;
                luck.ShowDialog();
            }
        }

        //�鿴��Ʒ
        private void btnsee_Click(object sender, EventArgs e)
        {
            ShowForm re = new ShowForm();
            re.ShowDialog();
        }
        
        //����
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //restart = false;
            //SoundPlayer sp = new SoundPlayer("zhufu.wav");
            //sp.PlayLooping();
        }

        //�鿴���
        private void btnresult_Click(object sender, EventArgs e)
        {
            ResultForm re = new ResultForm();
            re.ShowDialog();
        }

        //�˳�
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (restart==false)
            {                
                DialogResult re = MessageBox.Show("��Ҫ�˳��齱ϵͳ��?", "�ر���ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (re == DialogResult.Yes)
                {
                    DialogResult ree = MessageBox.Show("�˳��󱾴γ齱��¼����ʧ,ȷ��Ҫ�˳���?", "��Ҫ����", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (ree == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();            
            this.Dispose();            
        }      

        //���
        private void btnrestart_Click(object sender, EventArgs e)
        {            
            DialogResult re = MessageBox.Show("��ȷ��Ҫ��ճ齱��¼��?", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (re == DialogResult.OK)
            {               
                restart = true;
                Application.Restart();                
            }     
        }

        private void exitlabel_Click(object sender, EventArgs e)
        {

        }

        private void TitleTimer_Tick(object sender, EventArgs e)
        {

            TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(acolor)))));


            if (acolor == 255)
            {
                coloradd = false;

            }
            else if (acolor == 0)
            {
                coloradd = true;
            
            }

            if (coloradd)
            {
                acolor++;

            }
            else
            {
                acolor--;
            
            }
        }

        private void Titlefrontsizetext_DoubleClick(object sender, EventArgs e)
        {
            int tmpsize = 72;
            try
            {
                tmpsize = int.Parse(Titlefrontsizetext.Text.Trim());


            }
            catch (Exception)
            {
                return;
            }
            TitleLabel.Font = new Font("������κ",tmpsize);
        }

        private void Titlefrontsizetext_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
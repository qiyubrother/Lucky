using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lucky
{
    public partial class LuckyForm : Form
    {       
        public int choose;     
        int pernum;            //������(ͼƬ������)
        int i = 0;             //ͼƬ�±�(������)
        int index;             //�н��ߵ��±�(�����±�)           
        int dj = 1;            //�齱�ȼ�
        int save=0;              //�Ƿ񱣴�
        String winner="";          //�н����±�
 
        bool go = true;        //�жϿ�ʼ��ť  
        int wined = 0;         //�ѳ�����н�����

        Random ran = new Random(DateTime.Now.Millisecond);

        int tmpadd = 0;
        private static int aset = 0;
        private static int setnum=0;

        public LuckyForm()
        {
            InitializeComponent();
        }


        private void zhongjianglist()
        {
            if (dj == 1)
            {
                foreach (string a in UserHelper.yiwinner)
                {
                    if (a != null)
                    {
                        listBox1.Items.Add(a);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (dj == 2)
            {
                foreach (string b in UserHelper.erwinner)
                {
                    if (b != null)
                    {
                        listBox1.Items.Add(b);
                    }
                    else
                    {
                        break;
                    }
                }

            }
            else if (dj == 3)
            {
                foreach (string c in UserHelper.sanwinner)
                {
                    if (c != null)
                    {
                        listBox1.Items.Add(c);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            else if (dj == 4)
            {
                foreach (string d in UserHelper.siwinner)
                {
                    if (d != null)
                    {
                        listBox1.Items.Add(d);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (dj == 5)
            {
                foreach (string e in UserHelper.wuwinner)
                {
                    if (e != null)
                    {
                        listBox1.Items.Add(e);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (dj == 0)
            {
                foreach (string t in UserHelper.twinner)
                {
                    if (t != null)
                    {
                        listBox1.Items.Add(t);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

          
        private void LuckyForm_Load(object sender, EventArgs e)
        {
            try
            {

                //��ʾ�鼸�Ƚ�
                if (choose == 1)
                {
                    lblno.Text = "һ�Ƚ�";
                    lblset.Text = UserHelper.one.ToString();  //��������
                    lblcc.Text = readnum(1).ToString();������ //�������
                    dj = 1;
                }
                else if (choose == 2)
                {
                    lblno.Text = "���Ƚ�";
                    lblset.Text = UserHelper.two.ToString();
                    lblcc.Text = readnum(2).ToString();
                    dj = 2;
                }
                else if (choose == 3)
                {
                    lblno.Text = "���Ƚ�";
                    lblset.Text = UserHelper.three.ToString();
                    lblcc.Text = readnum(3).ToString();
                    dj = 3;
                }
                else if (choose == 4)
                {
                    lblno.Text = "�ĵȽ�";
                    lblset.Text = UserHelper.four.ToString();
                    lblcc.Text = readnum(4).ToString();
                    dj = 4;
                }
                else if (choose == 5)
                {
                    lblno.Text = "��Ƚ�";
                    lblset.Text = UserHelper.five.ToString();
                    lblcc.Text = readnum(5).ToString();
                    dj = 5;
                }
                else if (choose == 0)
                {
                    lblno.Text = "�صȽ�";
                    lblset.Text = UserHelper.te.ToString();
                    lblcc.Text = readnum(0).ToString();
                    dj = 0;
                }


                zhongjianglist();

                //����ͼƬ·��
                //string path = Application.StartupPath + @"\staff";

                ////���ó齱��Ա
                //DirectoryInfo dir = new DirectoryInfo(path);
                //FileInfo[] ff = dir.GetFiles("*.jpg");
                //i = ff.Length;
                //pernum = ff.Length;������//������

                //������ֵ�����
                //UserHelper.sname = new string[i];
                //int ix = 0;
                //foreach (FileInfo f in ff)
                //{
                //    UserHelper.sname[ix] = f.Name.ToString().Substring(0, f.Name.Length - 4);
                //    ilface.Images.Add(f.Name, Image.FromFile(f.FullName));
                //    ix++;
                //}

                //��ȡ�û���Ϣ �ŵ�������ȥĬ�����������500
                UserHelper.sname = new string[500];
                StreamReader sr = new StreamReader("staff.txt",System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                {
                    UserHelper.sname[i] = sr.ReadLine();
                    i++;
                }

                sr.Close();
                pernum = i;

                //���ص�����������
                save = Convert.ToInt32(lblcc.Text);
                //���س����������
                wined = readnum(1) + readnum(2) + readnum(3) + readnum(4) + readnum(5) + readnum(0);
            }
            catch (Exception)
            {
                MessageBox.Show("��Ǹ,����ʧ��!","ϵͳ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.Close();
            }
        }  
    
        //��ȡ��ȡ������
        private int readnum(int num)
        {
            int re = 0;  //������
            
            if (num == 1)
            {
                foreach (string n in UserHelper.yiwinner)
                {
                    if (n != null)
                    {
                        re++;
                    }
                    else 
                    {
                        break;
                    }
                }
            }
            else if (num == 2)
            {
                foreach (string n in UserHelper.erwinner)
                {
                    if (n != null)
                    {
                        re = re + 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (num == 3)
            {
                foreach (string n in UserHelper.sanwinner)
                {
                    if (n != null)
                    {
                        re = re + 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            else if (num == 4)
            {
                foreach (string n in UserHelper.siwinner)
                {
                    if (n != null)
                    {
                        re = re + 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (num == 5)
            {
                foreach (string n in UserHelper.wuwinner)
                {
                    if (n != null)
                    {
                        re = re + 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (num == 0)
            {
                foreach (string n in UserHelper.twinner)
                {
                    if (n != null)
                    {
                        re = re + 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return re;
        }

        //���̿���
        //private void LuckyForm_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //�ж��Ƿ��¿ո��س�
        //    if (e.KeyChar == '\r' || e.KeyChar == ' ')
        //    {
        //        btnonoff_Click(sender, e);
        //    }
        //}

        //ͼƬ�ζ�����
        private void tmrchoose_Tick(object sender, EventArgs e)
        {           
            index = ran.Next(1, i - 1);         
      
            //this.picface.Image = this.ilface.Images[index];
            this.lblname.Text = UserHelper.sname[index];
        }

        //�����ʼ�齱
        private void btnonoff_Click(object sender, EventArgs e)
        {
            //ͼƬ��������1
            if (pernum > 0)
            {
                //�жϰ�����ʼ�齱
                if (go)
                {
                    //�����������������ʾ����
                    if (Convert.ToInt32(lblcc.Text) >= Convert.ToInt32(lblset.Text))
                    {
                        DialogResult re = MessageBox.Show("�����õ��н������Ѿ�ȫ�����,Ҫ������?", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (re == DialogResult.OK)
                        {
                            this.Close();
                        }
                        else
                        {                            
                            tmrchoose.Enabled = true;
                            btnonoff.Text = "ֹͣ";
                            go = false;
                        }
                    }
                    else
                    {
                        tmrchoose.Enabled = true;
                        btnonoff.Text = "ֹͣ";
                        go = false;
                    }
                }
                else
                {
                    if (btnonoff.Text.Equals("����"))
                    {
                        DialogResult re = MessageBox.Show("Ҫ���汾�εĳ齱��¼��?", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (re == DialogResult.Yes)
                        {
                            switch (dj)
                            {
                                case 1:
                                    UserHelper.yiwinner[save] = winner;
                                    break;
                                case 2:
                                    UserHelper.erwinner[save] = winner;
                                    break;
                                case 3:
                                    UserHelper.sanwinner[save] = winner;
                                    break;  
                                case 4:
                                    UserHelper.siwinner[save] = winner;
                                    break;  
                                case 5:
                                    UserHelper.wuwinner[save] = winner;
                                    break;  
                                case 0:
                                    UserHelper.twinner[save] = winner;
                                    break;  
                            }

                            UserHelper.wintemp[wined] = winner;
                            listBox1.Items.Add(winner);

                            save = save + 1;     //�����н���������һ
                            wined = wined + 1;   //�н�����������һ
                            lblcc.Text = Convert.ToString(Convert.ToInt32(lblcc.Text) + 1);

                            btnonoff.Text = "��ʼ";
                            go = true;
                        }
                        else
                        {
                            btnonoff.Text = "��ʼ";
                            go = true;
                        }

                        winner = "";//����н��߻���
                    }
                    else
                    {
                        
                        tmrchoose.Enabled = false;
                        bool ishave;//�Ƿ��ظ�   
                        do
                        {
                            ishave = false;      //��ʼ��
                   
                            //�����������������ڲμӳ齱������,���������ν�(һ�㲻���ܳ���~~!)
                            if (wined >= i-1)
                            {
                                //ishave = false;
                                break;
                            }


                            foreach (string awin in UserHelper.wintemp)
                            {
                                if (UserHelper.sname[index].Equals(awin))
                                {
                                    ishave = true;
                                    break;
                                }
                            
                            }

                            if (ishave)
                            {
                                index++;
                                if (index >= i)
                                {
                                    index = 1;
                                
                                }
                            }
                        } while (ishave);

                        SetLucky();

                       // this.picface.Image = this.ilface.Images[index];
                        this.lblname.Text = winner;
                        //������Ľ������winner�� 
                        btnonoff.Text = "����";
                    }
                }
            }
            else 
            {
                MessageBox.Show("û���ҵ��齱��Ա!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetLucky()
        {
            if (dj == 0)
            {
                tmpadd = 1;

            }
            else if (tmpadd == 0)
            {
                tmpadd = ran.Next(1, dj);

            }

           aset++;

            if(aset == tmpadd)
            {
            switch (dj)
                {
                    case 0:
                        winner = UserHelper.setwin;
                        break;
                    case 1:
                        if (setnum < UserHelper.setwin1.Length && UserHelper.setwin1[setnum] != null)
                        {
                            winner = UserHelper.setwin1[setnum];
                            setnum++;
                        }
                        break;
                    case 2:
                        if (setnum < UserHelper.setwin2.Length && UserHelper.setwin2[setnum] != null)
                        {
                            winner = UserHelper.setwin2[setnum];
                            setnum++;
                        }
                        break;
                    case 3:
                        if (setnum < UserHelper.setwin3.Length && UserHelper.setwin3[setnum] != null)
                        {
                                winner = UserHelper.setwin3[setnum];
                                setnum++;
                        }
                        break;
                    case 4:
                        if (setnum < UserHelper.setwin4.Length && UserHelper.setwin4[setnum] != null)
                        {
                                winner = UserHelper.setwin4[setnum];
                                setnum++;
                        }
                        break;
                    case 5:
                        if (setnum < UserHelper.setwin5.Length && UserHelper.setwin5[setnum] != null)
                        {
                                winner = UserHelper.setwin5[setnum];
                                setnum++;

                        }
                        break;
                
                }

                            aset = 0;
                            tmpadd = 0;
             
            }

           

            if (winner==null || winner.Equals(""))
            {
                winner = UserHelper.sname[index];
            
            }

        }


        //�鿴���
        private void btnresult_Click(object sender, EventArgs e)
        {
            //WinnerForm winner = new WinnerForm();
            //winner.ccdj = this.dj;
            //winner.ShowDialog();
        }       
       
        //����
        private void btnbc_Click(object sender, EventArgs e)
        {

            aset = 0;
            setnum = 0;

            this.Close();

        }

        //�˳��ر�tmr
        private void LuckyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnonoff.Text.Equals("����"))
            { 
                       DialogResult re = MessageBox.Show("�ѳ���н��ߵ���δ����,Ҫ�ر���?", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                       if (re == DialogResult.Cancel)
                       {
                           e.Cancel = true;
                           return;
                       }
            

            }
            aset = 0;
            setnum = 0;

            GC.Collect();
            this.Dispose();



        }                
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lucky
{
    public partial class WinnerForm : Form
    {
        public int ccdj;    //�ȼ�

        public WinnerForm()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //�������
        private void WinnerForm_Load(object sender, EventArgs e)
        {
            //��ʾ�ȼ�
            if (ccdj == 1)
            {
                lbldj.Text = "һ�Ƚ�";
                saveout(1);                      
            }
            else if (ccdj == 2)
            {
                lbldj.Text = "���Ƚ�";
                saveout(2);
            }
            else if (ccdj == 3)
            {
                lbldj.Text = "���Ƚ�";
                saveout(3);
            }          
            
            //������ʾ
            //rtbwin.SelectAll();
            //rtbwin.SelectionAlignment= HorizontalAlignment.Center;           
        }

        //��ȡ����
        private void saveout(int dj)
        {
            if (dj == 1)
            {
                foreach (string a in UserHelper.yiwinner)
                {
                    if (a!=null)
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
                    if (b!=null)
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
            else
            {
                MessageBox.Show("û���н���Ա����","��ʾ");
                this.Close();
            
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lucky
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            //һ�Ƚ������
            foreach (string aa in UserHelper.yiwinner)
            {
                if (aa != null)
                {
                    rtb1.Text = rtb1.Text + (aa + "\n");
                }
                else 
                {
                    break;
                }
            }
            //���Ƚ������
            foreach (string bb in UserHelper.erwinner)
            {
                if (bb != null)
                {
                    rtb2.Text = rtb2.Text + (bb + "\n");
                }
                else
                {
                    break;
                }
            }
            //���Ƚ������
            foreach (string cc in UserHelper.sanwinner)
            {
                if (cc != null)
                {
                    rtb3.Text = rtb3.Text + (cc + "\n");
                }
                else
                {
                    break;
                }
            }

            //�ĵȽ������
            foreach (string dd in UserHelper.siwinner)
            {
                if (dd != null)
                {
                    rtb4.Text = rtb4.Text + (dd + "\n");
                }
                else
                {
                    break;
                }
            }
            //��Ƚ������
            foreach (string ee in UserHelper.wuwinner)
            {
                if (ee != null)
                {
                    rtb5.Text = rtb5.Text + (ee + "\n");
                }
                else
                {
                    break;
                }
            }
            //�صȽ������
            foreach (string tt in UserHelper.twinner)
            {
                if (tt != null)
                {
                    tedengjiang.Text = tedengjiang.Text + (tt + " ");
                }
                else
                {
                    break;
                }
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
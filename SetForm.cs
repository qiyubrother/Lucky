using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lucky
{
    public partial class SetForm : Form
    {
        public SetForm()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (vliainput())
            {
                saveset();
                this.Close();
            }
        }

        private void SetForm_Load(object sender, EventArgs e)
        {
            txt.Text = UserHelper.te.ToString();
            txt1.Text = UserHelper.one.ToString();
            txt2.Text = UserHelper.two.ToString();
            txt3.Text = UserHelper.three.ToString();
            txt4.Text = UserHelper.four.ToString();
            txt5.Text = UserHelper.five.ToString();
        }

        //��������
        private void saveset()
        {
            try
            {
                UserHelper.te = Convert.ToInt32(txt.Text);
                UserHelper.one = Convert.ToInt32(txt1.Text);
                UserHelper.two = Convert.ToInt32(txt2.Text);
                UserHelper.three = Convert.ToInt32(txt3.Text);
                UserHelper.four = Convert.ToInt32(txt4.Text);
                UserHelper.five = Convert.ToInt32(txt5.Text);
                UserHelper.allset = Convert.ToInt32(txt.Text) + Convert.ToInt32(txt1.Text) + Convert.ToInt32(txt2.Text) + Convert.ToInt32(txt3.Text) + Convert.ToInt32(txt4.Text) + Convert.ToInt32(txt5.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("����ʧ�ܣ������ԣ�","������");
            }
        }

        //������֤
        private bool vliainput()
        {
            bool result = true;
            
            try
            {
                int txtno1 = Convert.ToInt32(txt1.Text);
                if (txtno1 < 0 || txtno1 > 100)
                {
                    txt1.Clear();
                    txt1.Focus();
                    MessageBox.Show("����������ִ�С������!������1~100֮�������!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = false; 
                }
            }
            catch (Exception)
            {
                txt1.Clear();
                txt1.Focus();
                MessageBox.Show("���벻����Ҫ��!","������ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                result = false;
            }

            try
            {
                int txtno2 = Convert.ToInt32(txt2.Text);
                if (txtno2 < 1 || txtno2 > 1000)
                {
                    txt2.Clear();
                    txt2.Focus();
                    MessageBox.Show("����������ִ�С������!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = false;
                }
            }
            catch (Exception)
            {
                txt2.Clear();
                txt2.Focus();
                MessageBox.Show("����������!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                result = false;
            }

            try
            {
                int txtno3 = Convert.ToInt32(txt3.Text);
                if (txtno3 < 1 || txtno3 > 1000)
                {
                    txt3.Clear();
                    txt3.Focus();
                    MessageBox.Show("����������ִ�С������!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = false;
                }
            }
            catch (Exception)
            {
                txt3.Clear();
                txt3.Focus();
                MessageBox.Show("����������!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                result = false;
            }

            try
            {
                int txtno4 = Convert.ToInt32(txt4.Text);
                if (txtno4 < 1 || txtno4 > 1000)
                {
                    txt4.Clear();
                    txt4.Focus();
                    MessageBox.Show("����������ִ�С������!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = false;
                }
            }
            catch (Exception)
            {
                txt4.Clear();
                txt4.Focus();
                MessageBox.Show("����������!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                result = false;
            }
            try
            {
                int txtno5 = Convert.ToInt32(txt5.Text);
                if (txtno5 < 1 || txtno5 > 1000)
                {
                    txt5.Clear();
                    txt5.Focus();
                    MessageBox.Show("����������ִ�С������!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = false;
                }
            }
            catch (Exception)
            {
                txt5.Clear();
                txt5.Focus();
                MessageBox.Show("����������!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                result = false;
            }

            
            return result;
        }

        //��ݼ�
        //private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == '\r')
        //    {
        //        txt2.Focus();
        //    }
        //}

        //private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == '\r')
        //    {
        //        txt3.Focus();
        //    }
        //}
     
    }
}
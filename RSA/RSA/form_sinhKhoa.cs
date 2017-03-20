using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RSA
{
    public partial class Form_sinhkhoa : Form
    {
        int p, q, ee, phi, ks, kp, d, n;
        public int id = 0;
        string[] arr = new string[4];
        ListViewItem itm;

        public Form_sinhkhoa()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }
        

        #region Function + Tạo số nguyên tố
        public bool snt(int a)
        {
            if (a < 2)
                return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                        return false;
                }
                return true;
            }
        }

        public int USCLN(int a, int b)
        {
            while (b > 0)
            {
                int r = a % b;
                a = b;
                b = r;                
            }
            return a;
        }

        public int Modular_Inverse_Divide(int e, int N)
        {
            int i = 2;
            Cursor.Current = Cursors.WaitCursor;
            while (true)
            {
                if ((i * e) % N == 1)
                    break;
                i++;
            }
            Cursor.Current = Cursors.Default;
            return i;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            var ColumnToRemove = list.Columns["column1"];
            list.Columns.Remove(ColumnToRemove);
            list.Scrollable = true;
            list.View = View.Details;
            ColumnHeader header = new ColumnHeader();
            header.Text = "";            
            header.Name = "column1";
            list.Columns.Add(header);

            itm = new ListViewItem(arr);
            int sl_snt = Convert.ToInt32(n_nt.Text.ToString());
            int count = 0, i = 2;
            while (count < sl_snt)
            {
                if (snt(i))
                {
                    count++;
                    list.Items.Add(i.ToString());
                }
                i++;
            }
        }
        #endregion Function + Tạo số nguyên tố


        #region Sinh khóa
        private void button1_Click(object sender, EventArgs e)
        {
            textBox_p.Text = list.SelectedItems[0].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_q.Text = list.SelectedItems[0].Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_e.Text = list.SelectedItems[0].Text;
        }

        private void button_taoKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                p = Convert.ToInt32(textBox_p.Text);
                q = Convert.ToInt32(textBox_q.Text);
                ee = Convert.ToInt32(textBox_e.Text);

                if (USCLN(p, q) != 1)
                {
                    MessageBox.Show("Điều kiện: p và q là 2 số nguyên tố cùng nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    n = p * q;
                    phi = (p - 1) * (q - 1);

                    n_text.Text = n.ToString();
                    phi_text.Text = phi.ToString();

                    if (ee <= 1 || ee >= phi)
                    {
                        MessageBox.Show("Điều kiện: 1 < e < ɸ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else if (USCLN(ee, phi) != 1)
                    {
                        MessageBox.Show("Điều kiện: e và ɸ là 2 số nguyên tố cùng nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {

                        d = Modular_Inverse_Divide(ee, n);
                        kp = ee;
                        ks = d;

                        d_text.Text = d.ToString();
                        kp_text.Text = kp.ToString();
                        ks_text.Text = ks.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);                                
            }      
        }

        private void button_luuKhoa_Click(object sender, EventArgs e)
        {
            id++;            
            StreamWriter file = new StreamWriter(@"D:\abc.txt", true);
            file.WriteLine(id.ToString() + " " + kp_text.Text.ToString() + " " + ks_text.Text.ToString() + " " + DateTime.Now.ToString("dd/MM/yyyy"));
            file.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion Sinh khóa

        

    }
}
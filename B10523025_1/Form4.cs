using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B10523025_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MoveFirst();
            Record();
        }

        private void 書籍BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.書籍BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._p11_1dbDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 '_p11_1dbDataSet.書籍' 資料表。您可以視需要進行移動或移除。
            this.書籍TableAdapter.Fill(this._p11_1dbDataSet.書籍);

        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                書籍BindingSource.EndEdit();
                書籍TableAdapter.Update(_p11_1dbDataSet);
                MessageBox.Show("資料更新完成");
                Form4_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Record();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MovePrevious();
            Record();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MoveNext();
            Record();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MoveLast();
            Record();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                書籍BindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Record();
            書號TextBox.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            書籍BindingSource.RemoveAt(書籍BindingSource.Position);
            Record();
        }
        void Record()
        {
            label1.Text = "第" + (書籍BindingSource.Position + 1).ToString() + "筆, 共" + 書籍BindingSource.Count.ToString() + "筆";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

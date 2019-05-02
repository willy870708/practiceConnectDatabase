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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 '_p11_1dbDataSet.書籍' 資料表。您可以視需要進行移動或移除。
            this.書籍TableAdapter.Fill(this._p11_1dbDataSet.書籍);
           

        }
        void Record()
        {
            label1.Text = "第" + (書籍BindingSource.Position + 1).ToString() + "筆, 共" + 書籍BindingSource.Count.ToString() + "筆";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void 上一筆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MovePrevious();
            Record();
        }

        private void 下一筆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MoveNext();
            Record();
        }

        private void 最末筆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MoveLast();
            Record();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
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
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            書籍BindingSource.RemoveAt(書籍BindingSource.Position);
            Record();
        }

        private void 第一筆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MoveFirst();
            Record();
        }

        private void 更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                書籍BindingSource.EndEdit();
                書籍TableAdapter.Update(_p11_1dbDataSet);
                MessageBox.Show("資料更新完成");
                Form2_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Record();
        }

        private void 回到主畫面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

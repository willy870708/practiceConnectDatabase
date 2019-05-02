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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 '_p11_1dbDataSet.書籍' 資料表。您可以視需要進行移動或移除。
            this.書籍TableAdapter.Fill(this._p11_1dbDataSet.書籍);
            // TODO: 這行程式碼會將資料載入 '_p11_1dbDataSet.書籍' 資料表。您可以視需要進行移動或移除。
            this.書籍TableAdapter.Fill(this._p11_1dbDataSet.書籍);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.書籍BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this._p11_1dbDataSet);
                MessageBox.Show("資料更新完成");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.書籍TableAdapter.FillBy(this._p11_1dbDataSet.書籍);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 書籍BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.書籍BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._p11_1dbDataSet);

        }

        private void toolStripLabel1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

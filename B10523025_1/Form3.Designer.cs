namespace B10523025_1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label 書號Label;
            System.Windows.Forms.Label 書名Label;
            System.Windows.Forms.Label 單價Label;
            System.Windows.Forms.Label 數量Label;
            this._p11_1dbDataSet = new B10523025_1._p11_1dbDataSet();
            this.書籍BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.書籍TableAdapter = new B10523025_1._p11_1dbDataSetTableAdapters.書籍TableAdapter();
            this.tableAdapterManager = new B10523025_1._p11_1dbDataSetTableAdapters.TableAdapterManager();
            this.書籍BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.書籍BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.書號TextBox = new System.Windows.Forms.TextBox();
            this.書名TextBox = new System.Windows.Forms.TextBox();
            this.單價TextBox = new System.Windows.Forms.TextBox();
            this.數量TextBox = new System.Windows.Forms.TextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            書號Label = new System.Windows.Forms.Label();
            書名Label = new System.Windows.Forms.Label();
            單價Label = new System.Windows.Forms.Label();
            數量Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._p11_1dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍BindingNavigator)).BeginInit();
            this.書籍BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // _p11_1dbDataSet
            // 
            this._p11_1dbDataSet.DataSetName = "_p11_1dbDataSet";
            this._p11_1dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 書籍BindingSource
            // 
            this.書籍BindingSource.DataMember = "書籍";
            this.書籍BindingSource.DataSource = this._p11_1dbDataSet;
            // 
            // 書籍TableAdapter
            // 
            this.書籍TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = B10523025_1._p11_1dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.員工TableAdapter = null;
            this.tableAdapterManager.書籍TableAdapter = this.書籍TableAdapter;
            this.tableAdapterManager.訂貨主檔TableAdapter = null;
            this.tableAdapterManager.訂貨明細TableAdapter = null;
            // 
            // 書籍BindingNavigator
            // 
            this.書籍BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.書籍BindingNavigator.BindingSource = this.書籍BindingSource;
            this.書籍BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.書籍BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.書籍BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.書籍BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.書籍BindingNavigatorSaveItem,
            this.toolStripLabel1});
            this.書籍BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.書籍BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.書籍BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.書籍BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.書籍BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.書籍BindingNavigator.Name = "書籍BindingNavigator";
            this.書籍BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.書籍BindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.書籍BindingNavigator.TabIndex = 0;
            this.書籍BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 24);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(43, 24);
            this.bindingNavigatorAddNewItem.Text = "新增";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(43, 24);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // 書籍BindingNavigatorSaveItem
            // 
            this.書籍BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.書籍BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("書籍BindingNavigatorSaveItem.Image")));
            this.書籍BindingNavigatorSaveItem.Name = "書籍BindingNavigatorSaveItem";
            this.書籍BindingNavigatorSaveItem.Size = new System.Drawing.Size(43, 24);
            this.書籍BindingNavigatorSaveItem.Text = "更新";
            this.書籍BindingNavigatorSaveItem.Click += new System.EventHandler(this.書籍BindingNavigatorSaveItem_Click);
            // 
            // 書號Label
            // 
            書號Label.AutoSize = true;
            書號Label.Location = new System.Drawing.Point(252, 116);
            書號Label.Name = "書號Label";
            書號Label.Size = new System.Drawing.Size(41, 15);
            書號Label.TabIndex = 1;
            書號Label.Text = "書號:";
            // 
            // 書號TextBox
            // 
            this.書號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "書號", true));
            this.書號TextBox.Location = new System.Drawing.Point(299, 113);
            this.書號TextBox.Name = "書號TextBox";
            this.書號TextBox.Size = new System.Drawing.Size(100, 25);
            this.書號TextBox.TabIndex = 2;
            // 
            // 書名Label
            // 
            書名Label.AutoSize = true;
            書名Label.Location = new System.Drawing.Point(252, 166);
            書名Label.Name = "書名Label";
            書名Label.Size = new System.Drawing.Size(41, 15);
            書名Label.TabIndex = 3;
            書名Label.Text = "書名:";
            // 
            // 書名TextBox
            // 
            this.書名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "書名", true));
            this.書名TextBox.Location = new System.Drawing.Point(299, 163);
            this.書名TextBox.Name = "書名TextBox";
            this.書名TextBox.Size = new System.Drawing.Size(100, 25);
            this.書名TextBox.TabIndex = 4;
            // 
            // 單價Label
            // 
            單價Label.AutoSize = true;
            單價Label.Location = new System.Drawing.Point(252, 223);
            單價Label.Name = "單價Label";
            單價Label.Size = new System.Drawing.Size(41, 15);
            單價Label.TabIndex = 5;
            單價Label.Text = "單價:";
            // 
            // 單價TextBox
            // 
            this.單價TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "單價", true));
            this.單價TextBox.Location = new System.Drawing.Point(299, 220);
            this.單價TextBox.Name = "單價TextBox";
            this.單價TextBox.Size = new System.Drawing.Size(100, 25);
            this.單價TextBox.TabIndex = 6;
            // 
            // 數量Label
            // 
            數量Label.AutoSize = true;
            數量Label.Location = new System.Drawing.Point(252, 272);
            數量Label.Name = "數量Label";
            數量Label.Size = new System.Drawing.Size(41, 15);
            數量Label.TabIndex = 7;
            數量Label.Text = "數量:";
            // 
            // 數量TextBox
            // 
            this.數量TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "數量", true));
            this.數量TextBox.Location = new System.Drawing.Point(299, 269);
            this.數量TextBox.Name = "數量TextBox";
            this.數量TextBox.Size = new System.Drawing.Size(100, 25);
            this.數量TextBox.TabIndex = 8;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(69, 24);
            this.toolStripLabel1.Text = "回主畫面";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click_2);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(數量Label);
            this.Controls.Add(this.數量TextBox);
            this.Controls.Add(單價Label);
            this.Controls.Add(this.單價TextBox);
            this.Controls.Add(書名Label);
            this.Controls.Add(this.書名TextBox);
            this.Controls.Add(書號Label);
            this.Controls.Add(this.書號TextBox);
            this.Controls.Add(this.書籍BindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this._p11_1dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍BindingNavigator)).EndInit();
            this.書籍BindingNavigator.ResumeLayout(false);
            this.書籍BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _p11_1dbDataSet _p11_1dbDataSet;
        private System.Windows.Forms.BindingSource 書籍BindingSource;
        private _p11_1dbDataSetTableAdapters.書籍TableAdapter 書籍TableAdapter;
        private _p11_1dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator 書籍BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton 書籍BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox 書號TextBox;
        private System.Windows.Forms.TextBox 書名TextBox;
        private System.Windows.Forms.TextBox 單價TextBox;
        private System.Windows.Forms.TextBox 數量TextBox;
    }
}
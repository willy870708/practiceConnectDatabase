namespace B10523025_1
{
    partial class Form2
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
            System.Windows.Forms.Label 書號Label;
            System.Windows.Forms.Label 書名Label;
            System.Windows.Forms.Label 單價Label;
            System.Windows.Forms.Label 數量Label;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._p11_1dbDataSet = new B10523025_1._p11_1dbDataSet();
            this.tableAdapterManager = new B10523025_1._p11_1dbDataSetTableAdapters.TableAdapterManager();
            this.書籍BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.書籍TableAdapter = new B10523025_1._p11_1dbDataSetTableAdapters.書籍TableAdapter();
            this.書號TextBox = new System.Windows.Forms.TextBox();
            this.書名TextBox = new System.Windows.Forms.TextBox();
            this.單價TextBox = new System.Windows.Forms.TextBox();
            this.數量TextBox = new System.Windows.Forms.TextBox();
            this.瀏覽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.第一筆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一筆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一筆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最末筆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.回到主畫面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            書號Label = new System.Windows.Forms.Label();
            書名Label = new System.Windows.Forms.Label();
            單價Label = new System.Windows.Forms.Label();
            數量Label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._p11_1dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.瀏覽ToolStripMenuItem,
            this.編輯ToolStripMenuItem,
            this.更新ToolStripMenuItem,
            this.回到主畫面ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // _p11_1dbDataSet
            // 
            this._p11_1dbDataSet.DataSetName = "_p11_1dbDataSet";
            this._p11_1dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // 書籍BindingSource
            // 
            this.書籍BindingSource.DataMember = "書籍";
            this.書籍BindingSource.DataSource = this._p11_1dbDataSet;
            // 
            // 書籍TableAdapter
            // 
            this.書籍TableAdapter.ClearBeforeFill = true;
            // 
            // 書號Label
            // 
            書號Label.AutoSize = true;
            書號Label.Location = new System.Drawing.Point(172, 71);
            書號Label.Name = "書號Label";
            書號Label.Size = new System.Drawing.Size(41, 15);
            書號Label.TabIndex = 1;
            書號Label.Text = "書號:";
            // 
            // 書號TextBox
            // 
            this.書號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "書號", true));
            this.書號TextBox.Location = new System.Drawing.Point(219, 68);
            this.書號TextBox.Name = "書號TextBox";
            this.書號TextBox.Size = new System.Drawing.Size(100, 25);
            this.書號TextBox.TabIndex = 2;
            // 
            // 書名Label
            // 
            書名Label.AutoSize = true;
            書名Label.Location = new System.Drawing.Point(172, 122);
            書名Label.Name = "書名Label";
            書名Label.Size = new System.Drawing.Size(41, 15);
            書名Label.TabIndex = 3;
            書名Label.Text = "書名:";
            // 
            // 書名TextBox
            // 
            this.書名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "書名", true));
            this.書名TextBox.Location = new System.Drawing.Point(219, 119);
            this.書名TextBox.Name = "書名TextBox";
            this.書名TextBox.Size = new System.Drawing.Size(100, 25);
            this.書名TextBox.TabIndex = 4;
            // 
            // 單價Label
            // 
            單價Label.AutoSize = true;
            單價Label.Location = new System.Drawing.Point(172, 179);
            單價Label.Name = "單價Label";
            單價Label.Size = new System.Drawing.Size(41, 15);
            單價Label.TabIndex = 5;
            單價Label.Text = "單價:";
            // 
            // 單價TextBox
            // 
            this.單價TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "單價", true));
            this.單價TextBox.Location = new System.Drawing.Point(219, 176);
            this.單價TextBox.Name = "單價TextBox";
            this.單價TextBox.Size = new System.Drawing.Size(100, 25);
            this.單價TextBox.TabIndex = 6;
            // 
            // 數量Label
            // 
            數量Label.AutoSize = true;
            數量Label.Location = new System.Drawing.Point(172, 234);
            數量Label.Name = "數量Label";
            數量Label.Size = new System.Drawing.Size(41, 15);
            數量Label.TabIndex = 7;
            數量Label.Text = "數量:";
            // 
            // 數量TextBox
            // 
            this.數量TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "數量", true));
            this.數量TextBox.Location = new System.Drawing.Point(219, 231);
            this.數量TextBox.Name = "數量TextBox";
            this.數量TextBox.Size = new System.Drawing.Size(100, 25);
            this.數量TextBox.TabIndex = 8;
            // 
            // 瀏覽ToolStripMenuItem
            // 
            this.瀏覽ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.第一筆ToolStripMenuItem,
            this.上一筆ToolStripMenuItem,
            this.下一筆ToolStripMenuItem,
            this.最末筆ToolStripMenuItem});
            this.瀏覽ToolStripMenuItem.Name = "瀏覽ToolStripMenuItem";
            this.瀏覽ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.瀏覽ToolStripMenuItem.Text = "瀏覽";
            // 
            // 第一筆ToolStripMenuItem
            // 
            this.第一筆ToolStripMenuItem.Name = "第一筆ToolStripMenuItem";
            this.第一筆ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.第一筆ToolStripMenuItem.Text = "第一筆";
            this.第一筆ToolStripMenuItem.Click += new System.EventHandler(this.第一筆ToolStripMenuItem_Click);
            // 
            // 上一筆ToolStripMenuItem
            // 
            this.上一筆ToolStripMenuItem.Name = "上一筆ToolStripMenuItem";
            this.上一筆ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.上一筆ToolStripMenuItem.Text = "上一筆";
            this.上一筆ToolStripMenuItem.Click += new System.EventHandler(this.上一筆ToolStripMenuItem_Click);
            // 
            // 下一筆ToolStripMenuItem
            // 
            this.下一筆ToolStripMenuItem.Name = "下一筆ToolStripMenuItem";
            this.下一筆ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.下一筆ToolStripMenuItem.Text = "下一筆";
            this.下一筆ToolStripMenuItem.Click += new System.EventHandler(this.下一筆ToolStripMenuItem_Click);
            // 
            // 最末筆ToolStripMenuItem
            // 
            this.最末筆ToolStripMenuItem.Name = "最末筆ToolStripMenuItem";
            this.最末筆ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.最末筆ToolStripMenuItem.Text = "最末筆";
            this.最末筆ToolStripMenuItem.Click += new System.EventHandler(this.最末筆ToolStripMenuItem_Click);
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.刪除ToolStripMenuItem});
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.編輯ToolStripMenuItem.Text = "編輯";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 刪除ToolStripMenuItem
            // 
            this.刪除ToolStripMenuItem.Name = "刪除ToolStripMenuItem";
            this.刪除ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.刪除ToolStripMenuItem.Text = "刪除";
            this.刪除ToolStripMenuItem.Click += new System.EventHandler(this.刪除ToolStripMenuItem_Click);
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.更新ToolStripMenuItem.Text = "更新";
            this.更新ToolStripMenuItem.Click += new System.EventHandler(this.更新ToolStripMenuItem_Click);
            // 
            // 回到主畫面ToolStripMenuItem
            // 
            this.回到主畫面ToolStripMenuItem.Name = "回到主畫面ToolStripMenuItem";
            this.回到主畫面ToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.回到主畫面ToolStripMenuItem.Text = "回到主畫面";
            this.回到主畫面ToolStripMenuItem.Click += new System.EventHandler(this.回到主畫面ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "第1筆，共1筆";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(數量Label);
            this.Controls.Add(this.數量TextBox);
            this.Controls.Add(單價Label);
            this.Controls.Add(this.單價TextBox);
            this.Controls.Add(書名Label);
            this.Controls.Add(this.書名TextBox);
            this.Controls.Add(書號Label);
            this.Controls.Add(this.書號TextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._p11_1dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private _p11_1dbDataSet _p11_1dbDataSet;
        private _p11_1dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _p11_1dbDataSetTableAdapters.書籍TableAdapter 書籍TableAdapter;
        private System.Windows.Forms.BindingSource 書籍BindingSource;
        private System.Windows.Forms.ToolStripMenuItem 瀏覽ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 第一筆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上一筆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一筆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最末筆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 回到主畫面ToolStripMenuItem;
        private System.Windows.Forms.TextBox 書號TextBox;
        private System.Windows.Forms.TextBox 書名TextBox;
        private System.Windows.Forms.TextBox 單價TextBox;
        private System.Windows.Forms.TextBox 數量TextBox;
        private System.Windows.Forms.Label label1;
    }
}
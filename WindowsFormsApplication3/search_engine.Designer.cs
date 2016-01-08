namespace WindowsFormsApplication3
{
    partial class search_engine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search_engine));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开本地数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接远端数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提交报告ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.评估ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.层次分析法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPL筛选方法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hERA评估工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rBCA评估工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助主题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "搜索方式";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.数据ToolStripMenuItem,
            this.统计ToolStripMenuItem,
            this.评估ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.帮助ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开本地数据ToolStripMenuItem,
            this.连接远端数据ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "操作";
            // 
            // 打开本地数据ToolStripMenuItem
            // 
            this.打开本地数据ToolStripMenuItem.Name = "打开本地数据ToolStripMenuItem";
            this.打开本地数据ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.打开本地数据ToolStripMenuItem.Text = "打开本地数据库";
            // 
            // 连接远端数据ToolStripMenuItem
            // 
            this.连接远端数据ToolStripMenuItem.Name = "连接远端数据ToolStripMenuItem";
            this.连接远端数据ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.连接远端数据ToolStripMenuItem.Text = "连接远端数据库";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 数据ToolStripMenuItem
            // 
            this.数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成报表ToolStripMenuItem,
            this.提交报告ToolStripMenuItem});
            this.数据ToolStripMenuItem.Name = "数据ToolStripMenuItem";
            this.数据ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.数据ToolStripMenuItem.Text = "管理";
            // 
            // 生成报表ToolStripMenuItem
            // 
            this.生成报表ToolStripMenuItem.Name = "生成报表ToolStripMenuItem";
            this.生成报表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.生成报表ToolStripMenuItem.Text = "生成报告";
            this.生成报表ToolStripMenuItem.Click += new System.EventHandler(this.生成报表ToolStripMenuItem_Click);
            // 
            // 提交报告ToolStripMenuItem
            // 
            this.提交报告ToolStripMenuItem.Name = "提交报告ToolStripMenuItem";
            this.提交报告ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.提交报告ToolStripMenuItem.Text = "提交报告";
            this.提交报告ToolStripMenuItem.Click += new System.EventHandler(this.提交报告ToolStripMenuItem_Click);
            // 
            // 统计ToolStripMenuItem
            // 
            this.统计ToolStripMenuItem.Name = "统计ToolStripMenuItem";
            this.统计ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.统计ToolStripMenuItem.Text = "统计";
            this.统计ToolStripMenuItem.Click += new System.EventHandler(this.统计ToolStripMenuItem_Click);
            // 
            // 评估ToolStripMenuItem
            // 
            this.评估ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.层次分析法ToolStripMenuItem,
            this.nPL筛选方法ToolStripMenuItem});
            this.评估ToolStripMenuItem.Name = "评估ToolStripMenuItem";
            this.评估ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.评估ToolStripMenuItem.Text = "筛查";
            // 
            // 层次分析法ToolStripMenuItem
            // 
            this.层次分析法ToolStripMenuItem.Name = "层次分析法ToolStripMenuItem";
            this.层次分析法ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.层次分析法ToolStripMenuItem.Text = "层次分析法";
            this.层次分析法ToolStripMenuItem.Click += new System.EventHandler(this.层次分析法ToolStripMenuItem_Click);
            // 
            // nPL筛选方法ToolStripMenuItem
            // 
            this.nPL筛选方法ToolStripMenuItem.Name = "nPL筛选方法ToolStripMenuItem";
            this.nPL筛选方法ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.nPL筛选方法ToolStripMenuItem.Text = "NPLs筛选方法";
            this.nPL筛选方法ToolStripMenuItem.Click += new System.EventHandler(this.nPL筛选方法ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hERA评估工具ToolStripMenuItem,
            this.rBCA评估工具ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.帮助ToolStripMenuItem.Text = "外部工具";
            // 
            // hERA评估工具ToolStripMenuItem
            // 
            this.hERA评估工具ToolStripMenuItem.Name = "hERA评估工具ToolStripMenuItem";
            this.hERA评估工具ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hERA评估工具ToolStripMenuItem.Text = "HERA评估工具";
            this.hERA评估工具ToolStripMenuItem.Click += new System.EventHandler(this.hERA评估工具ToolStripMenuItem_Click);
            // 
            // rBCA评估工具ToolStripMenuItem
            // 
            this.rBCA评估工具ToolStripMenuItem.Name = "rBCA评估工具ToolStripMenuItem";
            this.rBCA评估工具ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.rBCA评估工具ToolStripMenuItem.Text = "RBCA评估工具";
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助主题ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem1.Text = "帮助";
            // 
            // 帮助主题ToolStripMenuItem
            // 
            this.帮助主题ToolStripMenuItem.Name = "帮助主题ToolStripMenuItem";
            this.帮助主题ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.帮助主题ToolStripMenuItem.Text = "帮助主题";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 65);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(221, 664);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(227, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1123, 664);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1115, 638);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "地籍信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1115, 638);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "污染物信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1115, 638);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "场地环境信息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1115, 638);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "事故及风险评级";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1115, 638);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "地图";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1115, 638);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "图像资料";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.webBrowser2);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1115, 638);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "在线化学品查询";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(1109, 632);
            this.webBrowser2.TabIndex = 0;
            this.webBrowser2.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 20);
            this.comboBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "关键字";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 10;
            this.button2.Text = "截图";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // search_engine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "search_engine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "污染场地管理系统  演示版                                                                    " +
    "                                         ";
            this.Load += new System.EventHandler(this.search_engine_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开本地数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接远端数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 评估ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem hERA评估工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rBCA评估工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 帮助主题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ToolStripMenuItem 生成报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 提交报告ToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.ToolStripMenuItem 层次分析法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPL筛选方法ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}
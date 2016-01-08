namespace WindowsFormsApplication3
{
    partial class risk_accessment
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.start_time3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_RA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(824, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "读取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(719, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 67;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.start_time3,
            this.end_time3,
            this.event3,
            this.event_RA,
            this.report3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(543, 315);
            this.dataGridView1.TabIndex = 68;
            // 
            // start_time3
            // 
            this.start_time3.DataPropertyName = "start_time";
            this.start_time3.HeaderText = " 发生时间";
            this.start_time3.Name = "start_time3";
            // 
            // end_time3
            // 
            this.end_time3.DataPropertyName = "end_time";
            this.end_time3.HeaderText = "结束时间";
            this.end_time3.Name = "end_time3";
            // 
            // event3
            // 
            this.event3.DataPropertyName = "brief_description";
            this.event3.HeaderText = "事故";
            this.event3.Name = "event3";
            // 
            // event_RA
            // 
            this.event_RA.DataPropertyName = "health_risk";
            this.event_RA.HeaderText = "事故风险";
            this.event_RA.Name = "event_RA";
            // 
            // report3
            // 
            this.report3.DataPropertyName = "event_detail";
            this.report3.HeaderText = "事故简报";
            this.report3.Name = "report3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(928, 558);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 69;
            this.button3.Text = "评估";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // risk_accessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 642);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "risk_accessment";
            this.Text = "risk_accessment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time3;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time3;
        private System.Windows.Forms.DataGridViewTextBoxColumn event3;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_RA;
        private System.Windows.Forms.DataGridViewTextBoxColumn report3;
        private System.Windows.Forms.Button button3;
    }
}
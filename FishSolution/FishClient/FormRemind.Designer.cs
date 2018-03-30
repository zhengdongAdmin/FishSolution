namespace FishClient
{
    partial class FormRemind
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components . Dispose ( );
            }
            base . Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new FishClient.UIControls.CalendarColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 415);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.realname,
            this.programId,
            this.programName,
            this.code,
            this.state,
            this.content,
            this.date});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 415);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // userName
            // 
            this.userName.DataPropertyName = "userName";
            this.userName.Frozen = true;
            this.userName.HeaderText = "用户名";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Visible = false;
            // 
            // realname
            // 
            this.realname.DataPropertyName = "realname";
            this.realname.Frozen = true;
            this.realname.HeaderText = "送审人";
            this.realname.Name = "realname";
            this.realname.ReadOnly = true;
            this.realname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.realname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // programId
            // 
            this.programId.DataPropertyName = "programId";
            this.programId.Frozen = true;
            this.programId.HeaderText = "程序编码";
            this.programId.Name = "programId";
            this.programId.ReadOnly = true;
            this.programId.Visible = false;
            // 
            // programName
            // 
            this.programName.DataPropertyName = "programName";
            this.programName.Frozen = true;
            this.programName.HeaderText = "送审单据";
            this.programName.Name = "programName";
            this.programName.ReadOnly = true;
            this.programName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.programName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "送审单号";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "送审状态";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // content
            // 
            this.content.DataPropertyName = "content";
            this.content.HeaderText = "送审内容";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "送审时间";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormRemind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 473);
            this.Controls.Add(this.panel1);
            this.Name = "FormRemind";
            this.Text = "送审消息提醒";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRemind_FormClosing);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn realname;
        private System.Windows.Forms.DataGridViewTextBoxColumn programId;
        private System.Windows.Forms.DataGridViewTextBoxColumn programName;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private UIControls.CalendarColumn date;
    }
}
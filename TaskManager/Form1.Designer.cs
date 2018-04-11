namespace TaskManager
{
	partial class Form1
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.processGridView = new System.Windows.Forms.DataGridView();
			this.processName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.resumeToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.suspendToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.label1 = new System.Windows.Forms.Label();
			this.processNameLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pidLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.memoryLabel = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cpuTimeLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.threadsLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ownerNameLabel = new System.Windows.Forms.Label();
			this.processInfo = new System.Windows.Forms.Button();
			this.totalProcessToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.processGridView)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(635, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "&Файл";
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.выходToolStripMenuItem.Text = "В&ыход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.totalProcessToolStripStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 272);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(635, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 17);
			this.toolStripStatusLabel1.Text = "Процессов:";
			// 
			// processGridView
			// 
			this.processGridView.AllowUserToAddRows = false;
			this.processGridView.AllowUserToDeleteRows = false;
			this.processGridView.AllowUserToOrderColumns = true;
			this.processGridView.AllowUserToResizeRows = false;
			this.processGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.processGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.processGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.processGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.processGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processName});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.processGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.processGridView.Location = new System.Drawing.Point(12, 52);
			this.processGridView.MultiSelect = false;
			this.processGridView.Name = "processGridView";
			this.processGridView.ReadOnly = true;
			this.processGridView.RowHeadersVisible = false;
			this.processGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.processGridView.Size = new System.Drawing.Size(269, 217);
			this.processGridView.TabIndex = 5;
			// 
			// processName
			// 
			this.processName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.processName.HeaderText = "Имя процесса";
			this.processName.Name = "processName";
			this.processName.ReadOnly = true;
			this.processName.Width = 120;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumeToolStripButton,
            this.suspendToolStripButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(635, 25);
			this.toolStrip1.TabIndex = 6;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// resumeToolStripButton
			// 
			this.resumeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.resumeToolStripButton.Enabled = false;
			this.resumeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("resumeToolStripButton.Image")));
			this.resumeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.resumeToolStripButton.Name = "resumeToolStripButton";
			this.resumeToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.resumeToolStripButton.ToolTipText = "Продолжить";
			this.resumeToolStripButton.Click += new System.EventHandler(this.resumeToolStripButton_Click);
			// 
			// suspendToolStripButton
			// 
			this.suspendToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.suspendToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("suspendToolStripButton.Image")));
			this.suspendToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.suspendToolStripButton.Name = "suspendToolStripButton";
			this.suspendToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.suspendToolStripButton.ToolTipText = "Приостановить";
			this.suspendToolStripButton.Click += new System.EventHandler(this.suspendToolStripButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(293, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Информация о процессе";
			// 
			// processNameLabel
			// 
			this.processNameLabel.AutoSize = true;
			this.processNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.processNameLabel.Location = new System.Drawing.Point(103, 4);
			this.processNameLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.processNameLabel.Name = "processNameLabel";
			this.processNameLabel.Size = new System.Drawing.Size(0, 13);
			this.processNameLabel.TabIndex = 9;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.processNameLabel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.pidLabel, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.memoryLabel, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.cpuTimeLabel, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.threadsLabel, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.ownerNameLabel, 1, 5);
			this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(296, 100);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(327, 169);
			this.tableLayoutPanel1.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 4);
			this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Имя процесса";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 25);
			this.label4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "PID";
			// 
			// pidLabel
			// 
			this.pidLabel.AutoSize = true;
			this.pidLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pidLabel.Location = new System.Drawing.Point(103, 25);
			this.pidLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.pidLabel.Name = "pidLabel";
			this.pidLabel.Size = new System.Drawing.Size(0, 13);
			this.pidLabel.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 46);
			this.label6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Память";
			// 
			// memoryLabel
			// 
			this.memoryLabel.AutoSize = true;
			this.memoryLabel.Location = new System.Drawing.Point(103, 46);
			this.memoryLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.memoryLabel.Name = "memoryLabel";
			this.memoryLabel.Size = new System.Drawing.Size(0, 13);
			this.memoryLabel.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 67);
			this.label7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Время ЦП";
			// 
			// cpuTimeLabel
			// 
			this.cpuTimeLabel.AutoSize = true;
			this.cpuTimeLabel.Location = new System.Drawing.Point(103, 67);
			this.cpuTimeLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.cpuTimeLabel.Name = "cpuTimeLabel";
			this.cpuTimeLabel.Size = new System.Drawing.Size(0, 13);
			this.cpuTimeLabel.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 88);
			this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 19;
			this.label2.Text = "Число потоков";
			// 
			// threadsLabel
			// 
			this.threadsLabel.AutoSize = true;
			this.threadsLabel.Location = new System.Drawing.Point(103, 88);
			this.threadsLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.threadsLabel.Name = "threadsLabel";
			this.threadsLabel.Size = new System.Drawing.Size(0, 13);
			this.threadsLabel.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 109);
			this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "Владелец";
			// 
			// ownerNameLabel
			// 
			this.ownerNameLabel.AutoSize = true;
			this.ownerNameLabel.Location = new System.Drawing.Point(103, 109);
			this.ownerNameLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.ownerNameLabel.Name = "ownerNameLabel";
			this.ownerNameLabel.Size = new System.Drawing.Size(0, 13);
			this.ownerNameLabel.TabIndex = 22;
			// 
			// processInfo
			// 
			this.processInfo.Location = new System.Drawing.Point(296, 52);
			this.processInfo.Name = "processInfo";
			this.processInfo.Size = new System.Drawing.Size(76, 29);
			this.processInfo.TabIndex = 11;
			this.processInfo.Text = "Подробнее";
			this.processInfo.UseVisualStyleBackColor = true;
			this.processInfo.Click += new System.EventHandler(this.processInfo_Click);
			// 
			// totalProcessToolStripStatusLabel
			// 
			this.totalProcessToolStripStatusLabel.Name = "totalProcessToolStripStatusLabel";
			this.totalProcessToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 294);
			this.Controls.Add(this.processInfo);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.processGridView);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Менеджер процессов";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.processGridView)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.DataGridView processGridView;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton resumeToolStripButton;
		private System.Windows.Forms.ToolStripButton suspendToolStripButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label processNameLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label pidLabel;
		private System.Windows.Forms.Label memoryLabel;
		private System.Windows.Forms.Label cpuTimeLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label threadsLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn processName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label ownerNameLabel;
		private System.Windows.Forms.Button processInfo;
		private System.Windows.Forms.ToolStripStatusLabel totalProcessToolStripStatusLabel;
	}
}


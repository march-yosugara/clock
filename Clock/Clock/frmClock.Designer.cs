namespace Clock
{
    partial class Clock
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LbTime = new System.Windows.Forms.Label();
            this.LbDate = new System.Windows.Forms.Label();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MiDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.MiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LbTime
            // 
            this.LbTime.BackColor = System.Drawing.Color.Transparent;
            this.LbTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LbTime.Font = new System.Drawing.Font("メイリオ", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)), true);
            this.LbTime.Location = new System.Drawing.Point(0, 41);
            this.LbTime.Margin = new System.Windows.Forms.Padding(0);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(284, 40);
            this.LbTime.TabIndex = 3;
            this.LbTime.Text = "00:00:00";
            this.LbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseUp);
            // 
            // LbDate
            // 
            this.LbDate.BackColor = System.Drawing.Color.Transparent;
            this.LbDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbDate.Font = new System.Drawing.Font("メイリオ", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)), true);
            this.LbDate.Location = new System.Drawing.Point(0, 0);
            this.LbDate.Margin = new System.Windows.Forms.Padding(0);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(284, 40);
            this.LbDate.TabIndex = 4;
            this.LbDate.Text = "0000/00/00(ddd)";
            this.LbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbDate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseUp);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.Menu;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "MarchClock";
            this.NotifyIcon.Visible = true;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiDisplay,
            this.MiExit});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(124, 52);
            // 
            // MiDisplay
            // 
            this.MiDisplay.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MiDisplay.Name = "MiDisplay";
            this.MiDisplay.Size = new System.Drawing.Size(123, 24);
            this.MiDisplay.Text = "Display";
            this.MiDisplay.Click += new System.EventHandler(this.MiDisplay_Click);
            // 
            // MiExit
            // 
            this.MiExit.Name = "MiExit";
            this.MiExit.Size = new System.Drawing.Size(123, 24);
            this.MiExit.Text = "Exit";
            this.MiExit.Click += new System.EventHandler(this.MiExit_Click);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.LbDate);
            this.Controls.Add(this.LbTime);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock";
            this.ShowInTaskbar = false;
            this.Text = "March Clock";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MiDisplay;
        private System.Windows.Forms.ToolStripMenuItem MiExit;
    }
}


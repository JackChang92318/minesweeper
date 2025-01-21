namespace WindowsFormsApp2
{
    partial class MainWin
    {
        
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NewGame_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GameSet_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boom_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MapScale_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rank_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(13, 32);
            this.pnlBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(1323, 918);
            this.pnlBoard.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGame_ToolStripMenuItem,
            this.GameSet_ToolStripMenuItem,
            this.Rank_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(516, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NewGame_ToolStripMenuItem
            // 
            this.NewGame_ToolStripMenuItem.Name = "NewGame_ToolStripMenuItem";
            this.NewGame_ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.NewGame_ToolStripMenuItem.Text = "新遊戲";
            this.NewGame_ToolStripMenuItem.Click += new System.EventHandler(this.NewGame_ToolStripMenuItem_Click);
            // 
            // GameSet_ToolStripMenuItem
            // 
            this.GameSet_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boom_ToolStripMenuItem,
            this.MapScale_ToolStripMenuItem});
            this.GameSet_ToolStripMenuItem.Name = "GameSet_ToolStripMenuItem";
            this.GameSet_ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.GameSet_ToolStripMenuItem.Text = "遊戲設定";
            // 
            // boom_ToolStripMenuItem
            // 
            this.boom_ToolStripMenuItem.Name = "boom_ToolStripMenuItem";
            this.boom_ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.boom_ToolStripMenuItem.Text = "炸彈數目";
            this.boom_ToolStripMenuItem.Click += new System.EventHandler(this.boom_ToolStripMenuItem_Click);
            // 
            // MapScale_ToolStripMenuItem
            // 
            this.MapScale_ToolStripMenuItem.Name = "MapScale_ToolStripMenuItem";
            this.MapScale_ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.MapScale_ToolStripMenuItem.Text = "地圖大小";
            this.MapScale_ToolStripMenuItem.Click += new System.EventHandler(this.MapScale_ToolStripMenuItem_Click);
            // 
            // Rank_ToolStripMenuItem
            // 
            this.Rank_ToolStripMenuItem.Name = "Rank_ToolStripMenuItem";
            this.Rank_ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.Rank_ToolStripMenuItem.Text = "排行榜";
            this.Rank_ToolStripMenuItem.Click += new System.EventHandler(this.Rank_ToolStripMenuItem_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 482);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlBoard);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWin";
            this.Text = "踩地雷";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NewGame_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GameSet_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boom_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rank_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MapScale_ToolStripMenuItem;
    }
}


namespace EQLevel2
{
    partial class Main
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
            this.Get_timer = new System.Windows.Forms.Timer(this.components);
            this.levellabel = new System.Windows.Forms.Label();
            this.redlabrl = new System.Windows.Forms.Label();
            this.yellowlabel = new System.Windows.Forms.Label();
            this.greenlabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Get_timer
            // 
            this.Get_timer.Interval = 2000;
            this.Get_timer.Tick += new System.EventHandler(this.Get_timer_Tick);
            // 
            // levellabel
            // 
            this.levellabel.AutoSize = true;
            this.levellabel.BackColor = System.Drawing.Color.Transparent;
            this.levellabel.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.levellabel.ForeColor = System.Drawing.Color.White;
            this.levellabel.Location = new System.Drawing.Point(12, 117);
            this.levellabel.Name = "levellabel";
            this.levellabel.Size = new System.Drawing.Size(135, 72);
            this.levellabel.TabIndex = 3;
            this.levellabel.Text = "振動レベル\r\nLv.0000";
            // 
            // redlabrl
            // 
            this.redlabrl.AutoSize = true;
            this.redlabrl.BackColor = System.Drawing.Color.Transparent;
            this.redlabrl.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.redlabrl.ForeColor = System.Drawing.Color.Red;
            this.redlabrl.Location = new System.Drawing.Point(12, 9);
            this.redlabrl.Name = "redlabrl";
            this.redlabrl.Size = new System.Drawing.Size(63, 36);
            this.redlabrl.TabIndex = 0;
            this.redlabrl.Text = "赤：";
            // 
            // yellowlabel
            // 
            this.yellowlabel.AutoSize = true;
            this.yellowlabel.BackColor = System.Drawing.Color.Transparent;
            this.yellowlabel.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.yellowlabel.ForeColor = System.Drawing.Color.Gold;
            this.yellowlabel.Location = new System.Drawing.Point(12, 45);
            this.yellowlabel.Name = "yellowlabel";
            this.yellowlabel.Size = new System.Drawing.Size(63, 36);
            this.yellowlabel.TabIndex = 1;
            this.yellowlabel.Text = "黄：";
            // 
            // greenlabel
            // 
            this.greenlabel.AutoSize = true;
            this.greenlabel.BackColor = System.Drawing.Color.Transparent;
            this.greenlabel.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.greenlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenlabel.Location = new System.Drawing.Point(12, 81);
            this.greenlabel.Name = "greenlabel";
            this.greenlabel.Size = new System.Drawing.Size(63, 36);
            this.greenlabel.TabIndex = 2;
            this.greenlabel.Text = "緑：";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(159, 196);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.greenlabel);
            this.Controls.Add(this.yellowlabel);
            this.Controls.Add(this.redlabrl);
            this.Controls.Add(this.levellabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "EqLevel2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Get_timer;
        private System.Windows.Forms.Label levellabel;
        private System.Windows.Forms.Label redlabrl;
        private System.Windows.Forms.Label yellowlabel;
        private System.Windows.Forms.Label greenlabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
    }
}


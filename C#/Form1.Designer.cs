namespace BitzRestApi
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.coinFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.coinTo = new System.Windows.Forms.TextBox();
            this.resolution = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tickerall = new System.Windows.Forms.Button();
            this.ticker = new System.Windows.Forms.Button();
            this.kline = new System.Windows.Forms.Button();
            this.symbolList = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.getUserAssets = new System.Windows.Forms.Button();
            this.historyEntrust = new System.Windows.Forms.Button();
            this.nowEntrust = new System.Windows.Forms.Button();
            this.addEntrustSheet = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // flowLayoutPanel4
            // 
            resources.ApplyResources(this.flowLayoutPanel4, "flowLayoutPanel4");
            this.flowLayoutPanel4.Controls.Add(this.coinFrom);
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.coinTo);
            this.flowLayoutPanel4.Controls.Add(this.resolution);
            this.flowLayoutPanel4.Controls.Add(this.comboBox1);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            // 
            // coinFrom
            // 
            resources.ApplyResources(this.coinFrom, "coinFrom");
            this.coinFrom.Name = "coinFrom";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // coinTo
            // 
            resources.ApplyResources(this.coinTo, "coinTo");
            this.coinTo.Name = "coinTo";
            // 
            // resolution
            // 
            resources.ApplyResources(this.resolution, "resolution");
            this.resolution.Name = "resolution";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5"),
            resources.GetString("comboBox1.Items6"),
            resources.GetString("comboBox1.Items7"),
            resources.GetString("comboBox1.Items8"),
            resources.GetString("comboBox1.Items9")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.txtConsole);
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.ForeColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.txtConsole, "txtConsole");
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.tickerall);
            this.flowLayoutPanel2.Controls.Add(this.ticker);
            this.flowLayoutPanel2.Controls.Add(this.kline);
            this.flowLayoutPanel2.Controls.Add(this.symbolList);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel2.Controls.Add(this.getUserAssets);
            this.flowLayoutPanel2.Controls.Add(this.historyEntrust);
            this.flowLayoutPanel2.Controls.Add(this.nowEntrust);
            this.flowLayoutPanel2.Controls.Add(this.addEntrustSheet);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // tickerall
            // 
            resources.ApplyResources(this.tickerall, "tickerall");
            this.tickerall.Name = "tickerall";
            this.tickerall.Click += new System.EventHandler(this.tickerall_Click);
            // 
            // ticker
            // 
            resources.ApplyResources(this.ticker, "ticker");
            this.ticker.Name = "ticker";
            this.ticker.UseVisualStyleBackColor = true;
            this.ticker.Click += new System.EventHandler(this.ticker_Click);
            // 
            // kline
            // 
            resources.ApplyResources(this.kline, "kline");
            this.kline.Name = "kline";
            this.kline.UseVisualStyleBackColor = true;
            this.kline.Click += new System.EventHandler(this.kline_Click);
            // 
            // symbolList
            // 
            resources.ApplyResources(this.symbolList, "symbolList");
            this.symbolList.Name = "symbolList";
            this.symbolList.UseVisualStyleBackColor = true;
            this.symbolList.Click += new System.EventHandler(this.symbolList_Click);
            // 
            // flowLayoutPanel5
            // 
            resources.ApplyResources(this.flowLayoutPanel5, "flowLayoutPanel5");
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            // 
            // getUserAssets
            // 
            resources.ApplyResources(this.getUserAssets, "getUserAssets");
            this.getUserAssets.Name = "getUserAssets";
            this.getUserAssets.UseVisualStyleBackColor = true;
            this.getUserAssets.Click += new System.EventHandler(this.getUserAssets_Click);
            // 
            // historyEntrust
            // 
            resources.ApplyResources(this.historyEntrust, "historyEntrust");
            this.historyEntrust.Name = "historyEntrust";
            this.historyEntrust.UseVisualStyleBackColor = true;
            this.historyEntrust.Click += new System.EventHandler(this.button1_Click);
            // 
            // nowEntrust
            // 
            resources.ApplyResources(this.nowEntrust, "nowEntrust");
            this.nowEntrust.Name = "nowEntrust";
            this.nowEntrust.UseVisualStyleBackColor = true;
            this.nowEntrust.Click += new System.EventHandler(this.nowEntrust_Click);
            // 
            // addEntrustSheet
            // 
            resources.ApplyResources(this.addEntrustSheet, "addEntrustSheet");
            this.addEntrustSheet.Name = "addEntrustSheet";
            this.addEntrustSheet.UseVisualStyleBackColor = true;
            this.addEntrustSheet.Click += new System.EventHandler(this.addEntrustSheet_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button tickerall;
        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox coinFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox coinTo;
        private System.Windows.Forms.Button ticker;
        private System.Windows.Forms.Label resolution;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button kline;
        private System.Windows.Forms.Button symbolList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button getUserAssets;
        private System.Windows.Forms.Button historyEntrust;
        private System.Windows.Forms.Button addEntrustSheet;
        private System.Windows.Forms.Button nowEntrust;
    }
}


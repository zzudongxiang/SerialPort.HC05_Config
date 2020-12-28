namespace HC05_Config
{
    partial class BlueTooth
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlueTooth));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.bgwReceive = new System.ComponentModel.BackgroundWorker();
            this.bgwConfig = new System.ComponentModel.BackgroundWorker();
            this.tbxLogs = new System.Windows.Forms.TextBox();
            this.pnlLogs = new System.Windows.Forms.Panel();
            this.gpbSerialPort = new System.Windows.Forms.GroupBox();
            this.pnlOpen = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pnlBaudRate = new System.Windows.Forms.Panel();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.pnlPortName = new System.Windows.Forms.Panel();
            this.cbxPortName = new System.Windows.Forms.ComboBox();
            this.pbxUpdate = new System.Windows.Forms.PictureBox();
            this.lbPortName = new System.Windows.Forms.Label();
            this.lbSplit = new System.Windows.Forms.Label();
            this.gpbHC05 = new System.Windows.Forms.GroupBox();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.pnlHC05BaudRate = new System.Windows.Forms.Panel();
            this.cbxHC05BaudRate = new System.Windows.Forms.ComboBox();
            this.lbHC05BaudRate = new System.Windows.Forms.Label();
            this.pnlNumbing = new System.Windows.Forms.Panel();
            this.tbxNumbing = new System.Windows.Forms.TextBox();
            this.lbNumbing = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLogs.SuspendLayout();
            this.gpbSerialPort.SuspendLayout();
            this.pnlOpen.SuspendLayout();
            this.pnlBaudRate.SuspendLayout();
            this.pnlPortName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpdate)).BeginInit();
            this.gpbHC05.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.pnlHC05BaudRate.SuspendLayout();
            this.pnlNumbing.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 38400;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // bgwReceive
            // 
            this.bgwReceive.WorkerReportsProgress = true;
            this.bgwReceive.WorkerSupportsCancellation = true;
            this.bgwReceive.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwReceive_DoWork);
            this.bgwReceive.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwReceive_ProgressChanged);
            // 
            // bgwConfig
            // 
            this.bgwConfig.WorkerReportsProgress = true;
            this.bgwConfig.WorkerSupportsCancellation = true;
            this.bgwConfig.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConfig_DoWork);
            this.bgwConfig.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwConfig_ProgressChanged);
            this.bgwConfig.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwConfig_RunWorkerCompleted);
            // 
            // tbxLogs
            // 
            this.tbxLogs.BackColor = System.Drawing.Color.Black;
            this.tbxLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLogs.ForeColor = System.Drawing.Color.Lime;
            this.tbxLogs.Location = new System.Drawing.Point(5, 5);
            this.tbxLogs.Multiline = true;
            this.tbxLogs.Name = "tbxLogs";
            this.tbxLogs.ReadOnly = true;
            this.tbxLogs.Size = new System.Drawing.Size(268, 100);
            this.tbxLogs.TabIndex = 8;
            this.tbxLogs.Text = "tbxLogs.Text";
            // 
            // pnlLogs
            // 
            this.pnlLogs.BackColor = System.Drawing.Color.Black;
            this.pnlLogs.Controls.Add(this.tbxLogs);
            this.pnlLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogs.Location = new System.Drawing.Point(3, 108);
            this.pnlLogs.Name = "pnlLogs";
            this.pnlLogs.Padding = new System.Windows.Forms.Padding(5);
            this.pnlLogs.Size = new System.Drawing.Size(278, 110);
            this.pnlLogs.TabIndex = 1;
            // 
            // gpbSerialPort
            // 
            this.gpbSerialPort.Controls.Add(this.pnlOpen);
            this.gpbSerialPort.Controls.Add(this.pnlBaudRate);
            this.gpbSerialPort.Controls.Add(this.pnlPortName);
            this.gpbSerialPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpbSerialPort.Location = new System.Drawing.Point(0, 5);
            this.gpbSerialPort.Name = "gpbSerialPort";
            this.gpbSerialPort.Padding = new System.Windows.Forms.Padding(0);
            this.gpbSerialPort.Size = new System.Drawing.Size(130, 95);
            this.gpbSerialPort.TabIndex = 0;
            this.gpbSerialPort.TabStop = false;
            this.gpbSerialPort.Text = "串口配置";
            // 
            // pnlOpen
            // 
            this.pnlOpen.Controls.Add(this.btnOpen);
            this.pnlOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOpen.Location = new System.Drawing.Point(0, 60);
            this.pnlOpen.Name = "pnlOpen";
            this.pnlOpen.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.pnlOpen.Size = new System.Drawing.Size(130, 35);
            this.pnlOpen.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen.Location = new System.Drawing.Point(15, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 25);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "打开串口";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pnlBaudRate
            // 
            this.pnlBaudRate.Controls.Add(this.cbxBaudRate);
            this.pnlBaudRate.Controls.Add(this.lbBaudRate);
            this.pnlBaudRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBaudRate.Location = new System.Drawing.Point(0, 40);
            this.pnlBaudRate.Name = "pnlBaudRate";
            this.pnlBaudRate.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlBaudRate.Size = new System.Drawing.Size(130, 20);
            this.pnlBaudRate.TabIndex = 1;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Items.AddRange(new object[] {
            "115200",
            "38400",
            "14400",
            "9600",
            "4800",
            "2400"});
            this.cbxBaudRate.Location = new System.Drawing.Point(53, 0);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(74, 20);
            this.cbxBaudRate.TabIndex = 3;
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbBaudRate.Location = new System.Drawing.Point(3, 0);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(50, 20);
            this.lbBaudRate.TabIndex = 0;
            this.lbBaudRate.Text = "波特率:";
            this.lbBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlPortName
            // 
            this.pnlPortName.Controls.Add(this.cbxPortName);
            this.pnlPortName.Controls.Add(this.pbxUpdate);
            this.pnlPortName.Controls.Add(this.lbPortName);
            this.pnlPortName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPortName.Location = new System.Drawing.Point(0, 14);
            this.pnlPortName.Name = "pnlPortName";
            this.pnlPortName.Padding = new System.Windows.Forms.Padding(3);
            this.pnlPortName.Size = new System.Drawing.Size(130, 26);
            this.pnlPortName.TabIndex = 0;
            // 
            // cbxPortName
            // 
            this.cbxPortName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPortName.FormattingEnabled = true;
            this.cbxPortName.Items.AddRange(new object[] {
            "COM1"});
            this.cbxPortName.Location = new System.Drawing.Point(53, 3);
            this.cbxPortName.Name = "cbxPortName";
            this.cbxPortName.Size = new System.Drawing.Size(47, 20);
            this.cbxPortName.TabIndex = 2;
            // 
            // pbxUpdate
            // 
            this.pbxUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbxUpdate.Image = global::HC05_Config.Properties.Resources.Refresh;
            this.pbxUpdate.Location = new System.Drawing.Point(100, 3);
            this.pbxUpdate.Name = "pbxUpdate";
            this.pbxUpdate.Size = new System.Drawing.Size(27, 20);
            this.pbxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUpdate.TabIndex = 1;
            this.pbxUpdate.TabStop = false;
            this.pbxUpdate.Click += new System.EventHandler(this.pbxUpdate_Click);
            // 
            // lbPortName
            // 
            this.lbPortName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbPortName.Location = new System.Drawing.Point(3, 3);
            this.lbPortName.Name = "lbPortName";
            this.lbPortName.Size = new System.Drawing.Size(50, 20);
            this.lbPortName.TabIndex = 0;
            this.lbPortName.Text = "串口号:";
            this.lbPortName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSplit
            // 
            this.lbSplit.BackColor = System.Drawing.SystemColors.Control;
            this.lbSplit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSplit.Location = new System.Drawing.Point(130, 5);
            this.lbSplit.Name = "lbSplit";
            this.lbSplit.Size = new System.Drawing.Size(3, 95);
            this.lbSplit.TabIndex = 2;
            this.lbSplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbHC05
            // 
            this.gpbHC05.Controls.Add(this.pnlConfig);
            this.gpbHC05.Controls.Add(this.pnlHC05BaudRate);
            this.gpbHC05.Controls.Add(this.pnlNumbing);
            this.gpbHC05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbHC05.Location = new System.Drawing.Point(133, 5);
            this.gpbHC05.Name = "gpbHC05";
            this.gpbHC05.Padding = new System.Windows.Forms.Padding(0);
            this.gpbHC05.Size = new System.Drawing.Size(145, 95);
            this.gpbHC05.TabIndex = 3;
            this.gpbHC05.TabStop = false;
            this.gpbHC05.Text = "蓝牙配置";
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.btnConfig);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfig.Location = new System.Drawing.Point(0, 57);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.pnlConfig.Size = new System.Drawing.Size(145, 38);
            this.pnlConfig.TabIndex = 3;
            // 
            // btnConfig
            // 
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfig.Location = new System.Drawing.Point(15, 5);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(115, 28);
            this.btnConfig.TabIndex = 0;
            this.btnConfig.Text = "配置HC05";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // pnlHC05BaudRate
            // 
            this.pnlHC05BaudRate.Controls.Add(this.cbxHC05BaudRate);
            this.pnlHC05BaudRate.Controls.Add(this.lbHC05BaudRate);
            this.pnlHC05BaudRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHC05BaudRate.Location = new System.Drawing.Point(0, 37);
            this.pnlHC05BaudRate.Name = "pnlHC05BaudRate";
            this.pnlHC05BaudRate.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlHC05BaudRate.Size = new System.Drawing.Size(145, 20);
            this.pnlHC05BaudRate.TabIndex = 2;
            // 
            // cbxHC05BaudRate
            // 
            this.cbxHC05BaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxHC05BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHC05BaudRate.FormattingEnabled = true;
            this.cbxHC05BaudRate.Items.AddRange(new object[] {
            "115200",
            "38400",
            "14400",
            "9600",
            "4800",
            "2400"});
            this.cbxHC05BaudRate.Location = new System.Drawing.Point(53, 0);
            this.cbxHC05BaudRate.Name = "cbxHC05BaudRate";
            this.cbxHC05BaudRate.Size = new System.Drawing.Size(89, 20);
            this.cbxHC05BaudRate.TabIndex = 7;
            // 
            // lbHC05BaudRate
            // 
            this.lbHC05BaudRate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbHC05BaudRate.Location = new System.Drawing.Point(3, 0);
            this.lbHC05BaudRate.Name = "lbHC05BaudRate";
            this.lbHC05BaudRate.Size = new System.Drawing.Size(50, 20);
            this.lbHC05BaudRate.TabIndex = 6;
            this.lbHC05BaudRate.Text = "波特率:";
            this.lbHC05BaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlNumbing
            // 
            this.pnlNumbing.Controls.Add(this.tbxNumbing);
            this.pnlNumbing.Controls.Add(this.lbNumbing);
            this.pnlNumbing.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNumbing.Location = new System.Drawing.Point(0, 14);
            this.pnlNumbing.Name = "pnlNumbing";
            this.pnlNumbing.Padding = new System.Windows.Forms.Padding(3);
            this.pnlNumbing.Size = new System.Drawing.Size(145, 23);
            this.pnlNumbing.TabIndex = 0;
            // 
            // tbxNumbing
            // 
            this.tbxNumbing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbxNumbing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNumbing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxNumbing.Font = new System.Drawing.Font("宋体", 11F);
            this.tbxNumbing.ForeColor = System.Drawing.Color.Blue;
            this.tbxNumbing.Location = new System.Drawing.Point(40, 3);
            this.tbxNumbing.Name = "tbxNumbing";
            this.tbxNumbing.Size = new System.Drawing.Size(102, 17);
            this.tbxNumbing.TabIndex = 4;
            this.tbxNumbing.Text = "181309000";
            this.tbxNumbing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbNumbing
            // 
            this.lbNumbing.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNumbing.Location = new System.Drawing.Point(3, 3);
            this.lbNumbing.Name = "lbNumbing";
            this.lbNumbing.Size = new System.Drawing.Size(37, 17);
            this.lbNumbing.TabIndex = 0;
            this.lbNumbing.Text = "编号:";
            this.lbNumbing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gpbHC05);
            this.pnlMain.Controls.Add(this.lbSplit);
            this.pnlMain.Controls.Add(this.gpbSerialPort);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(3, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlMain.Size = new System.Drawing.Size(278, 105);
            this.pnlMain.TabIndex = 0;
            // 
            // BlueTooth
            // 
            this.AcceptButton = this.btnConfig;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.pnlLogs);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 260);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 260);
            this.Name = "BlueTooth";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "HC-05配置 zzudongxiang@163.com";
            this.pnlLogs.ResumeLayout(false);
            this.pnlLogs.PerformLayout();
            this.gpbSerialPort.ResumeLayout(false);
            this.pnlOpen.ResumeLayout(false);
            this.pnlBaudRate.ResumeLayout(false);
            this.pnlPortName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpdate)).EndInit();
            this.gpbHC05.ResumeLayout(false);
            this.pnlConfig.ResumeLayout(false);
            this.pnlHC05BaudRate.ResumeLayout(false);
            this.pnlNumbing.ResumeLayout(false);
            this.pnlNumbing.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort;
        private System.ComponentModel.BackgroundWorker bgwReceive;
        private System.ComponentModel.BackgroundWorker bgwConfig;
        private System.Windows.Forms.TextBox tbxLogs;
        private System.Windows.Forms.Panel pnlLogs;
        private System.Windows.Forms.GroupBox gpbSerialPort;
        private System.Windows.Forms.Panel pnlOpen;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel pnlBaudRate;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.Panel pnlPortName;
        private System.Windows.Forms.ComboBox cbxPortName;
        private System.Windows.Forms.PictureBox pbxUpdate;
        private System.Windows.Forms.Label lbPortName;
        private System.Windows.Forms.Label lbSplit;
        private System.Windows.Forms.GroupBox gpbHC05;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Panel pnlHC05BaudRate;
        private System.Windows.Forms.ComboBox cbxHC05BaudRate;
        private System.Windows.Forms.Label lbHC05BaudRate;
        private System.Windows.Forms.Panel pnlNumbing;
        private System.Windows.Forms.TextBox tbxNumbing;
        private System.Windows.Forms.Label lbNumbing;
        private System.Windows.Forms.Panel pnlMain;
    }
}


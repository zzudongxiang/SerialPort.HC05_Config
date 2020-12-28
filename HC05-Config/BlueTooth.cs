using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace HC05_Config
{
    public partial class BlueTooth : Form
    {
        public BlueTooth()
        {
            sp_Rec = new List<string> { };
            configNext = 0;
            InitializeComponent();
            //选择默认串口属性
            pbxUpdate_Click(pbxUpdate, new EventArgs());
            cbxBaudRate.SelectedItem = "38400";
            //选择默认蓝牙属性
            tbxNumbing.Text = "181311000";
            cbxHC05BaudRate.SelectedItem = "115200";
            //禁用蓝牙属性
            gpbHC05.Enabled = false;
            //清除日志
            tbxLogs.Clear();
            //写入标题
            WriteLogs("* 写入日期:" + DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss.fff"));
            WriteLogs("蓝牙编号,蓝牙名称, 蓝牙密码, 蓝牙地址, 串口属性");
        }

        private List<string> sp_Rec { get; set; }

        private int configNext { get; set; }

        private string address { get; set; }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    //串口已开启, 则关闭串口
                    serialPort.Close();
                    btnOpen.Text = "打开串口";
                    gpbHC05.Enabled = false;
                    pnlPortName.Enabled = true;
                    pnlBaudRate.Enabled = true;
                    bgwReceive.CancelAsync();
                }
                else
                {
                    //串口未开启, 则开启串口
                    serialPort.PortName = cbxPortName.SelectedItem.ToString();
                    serialPort.BaudRate = Convert.ToInt32(cbxBaudRate.SelectedItem);
                    serialPort.Open();
                    btnOpen.Text = "关闭串口";
                    gpbHC05.Enabled = true;
                    pnlPortName.Enabled = false;
                    pnlBaudRate.Enabled = false;
                    bgwReceive.RunWorkerAsync();
                }
            }
            catch (Exception Ex)
            {
                string ExMessage = "Exception.Message\r\n";
                ExMessage += Ex.Message + "\r\n\r\n";
                ExMessage += "Exception.Source\r\n";
                ExMessage += Ex.Source + "\r\n\r\n";
                ExMessage += "Exception.StackTrace\r\n";
                ExMessage += Ex.StackTrace + "\r\n\r\n";
                MessageBox.Show(ExMessage, "RunTime Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //首先关闭串口
                if (serialPort.IsOpen) serialPort.Close();
                //清除原始值
                cbxPortName.Items.Clear();
                //添加可用串口名
                cbxPortName.Items.AddRange(SerialPort.GetPortNames());
                //如果有串口信息, 则选择默认信息
                if (cbxPortName.Items.Count > 0)
                    cbxPortName.SelectedIndex = 0;
            }
            catch (Exception Ex)
            {
                string ExMessage = "Exception.Message\r\n";
                ExMessage += Ex.Message + "\r\n\r\n";
                ExMessage += "Exception.Source\r\n";
                ExMessage += Ex.Source + "\r\n\r\n";
                ExMessage += "Exception.StackTrace\r\n";
                ExMessage += Ex.StackTrace + "\r\n\r\n";
                MessageBox.Show(ExMessage, "RunTime Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bgwConfig.IsBusy)
                {
                    Regex regex = new Regex(@"^\d{9}$");
                    if (!regex.IsMatch(tbxNumbing.Text))
                    {
                        MessageBox.Show("请输入合法的编号{9位数字}!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string args = tbxNumbing.Text + "_";
                    args += cbxHC05BaudRate.SelectedItem.ToString();
                    tbxLogs.Clear();
                    pnlNumbing.Enabled = false;
                    pnlHC05BaudRate.Enabled = false;
                    btnOpen.Enabled = false;
                    btnConfig.Text = "取消配置";
                    bgwConfig.RunWorkerAsync(args);
                }
                else bgwConfig.CancelAsync();
            }
            catch (Exception Ex)
            {
                string ExMessage = "Exception.Message\r\n";
                ExMessage += Ex.Message + "\r\n\r\n";
                ExMessage += "Exception.Source\r\n";
                ExMessage += Ex.Source + "\r\n\r\n";
                ExMessage += "Exception.StackTrace\r\n";
                ExMessage += Ex.StackTrace + "\r\n\r\n";
                MessageBox.Show(ExMessage, "RunTime Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                sp_Rec.Add(serialPort.ReadLine());
            }
            catch { }
        }

        private void bgwReceive_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!bgwReceive.CancellationPending)
            {
                if (sp_Rec.Count > 0)
                {
                    string rec = sp_Rec.First();
                    sp_Rec.RemoveAt(0);
                    rec = rec.ToUpper();
                    rec = rec.Replace("\r", string.Empty).Replace("\n", string.Empty);
                    bgwReceive.ReportProgress(0, rec);
                    if (rec.Contains("OK")) configNext = 1;
                    else
                    {
                        if (rec.Contains("+ADDR:"))
                            address = rec.Replace("+ADDR:", string.Empty);
                        else configNext = -1;
                    }
                }
                Thread.Sleep(100);
            }
        }

        private void bgwReceive_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tbxLogs.AppendText(" --> " + e.UserState + "\r\n");
        }

        private void bgwConfig_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                e.Cancel = false;
                //读取蓝牙基础属性
                string Number = e.Argument.ToString().Split('_').First();
                int BaudRate = Convert.ToInt32(e.Argument.ToString().Split('_').Last());
                //初始化变量
                List<string> AT_Command = new List<string> { };
                AT_Command.Add("AT");
                //AT_Command.Add("AT+ORGL");
                AT_Command.Add("AT+NAME=BlueTooth-" + Number);
                AT_Command.Add("AT+PSWD=\"" + Number + "\"");
                AT_Command.Add("AT+UART=" + BaudRate + ",0,0");
                AT_Command.Add("AT+ADDR?");
                //执行相应的命令
                for (int index = 0; index < AT_Command.Count; index++)
                {
                    if (!WaitCommand(index + 1, AT_Command[index]))
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
            catch (Exception Ex)
            {
                e.Result = Ex;
            }
        }

        private bool WaitCommand(int index, string command)
        {
            configNext = 0;
            serialPort.Write(command + "\r\n");
            bgwConfig.ReportProgress(index, command + "...");
            while (configNext == 0)
            {
                if (bgwConfig.CancellationPending)
                    return false;
                Thread.Sleep(100);
            }
            if (configNext < 0)
                throw new Exception("AT指令:\r\n" + command + "\r\n执行失败!");
            else return true;
        }

        private void bgwConfig_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tbxLogs.AppendText(e.ProgressPercentage + ": " + e.UserState);
        }

        private void bgwConfig_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnlNumbing.Enabled = true;
            pnlHC05BaudRate.Enabled = true;
            btnOpen.Enabled = true;
            btnConfig.Text = "配置HC05";
            if (!e.Cancelled)
            {
                if (e.Result is Exception Ex)
                {
                    string message = tbxNumbing.Text + " 异常\r\n" + Ex.Message;
                    tbxLogs.AppendText("\r\n" + message);
                    MessageBox.Show(message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string message = "BlueTooth-" + tbxNumbing.Text + " 配置完成...";
                    if (!string.IsNullOrEmpty(address))
                    {
                        string WriteLine = tbxNumbing.Text + ",";
                        WriteLine += "BlueTooth-" + tbxNumbing.Text + ",";
                        WriteLine += tbxNumbing.Text + ",";
                        WriteLine += address + ",";
                        WriteLine += "BaudRate:" + cbxHC05BaudRate.SelectedItem + "; StopBits:One; Parity:None;";
                        WriteLogs(WriteLine);
                        address = string.Empty;
                    }
                    else message += "\r\n无法写入日志!";
                    tbxLogs.AppendText("\r\n" + message);
                    tbxNumbing.Text = (Convert.ToInt32(tbxNumbing.Text) + 1).ToString("000000000");
                }
            }
            else
            {
                string message = tbxNumbing.Text + " 取消配置, Cancel...";
                tbxLogs.AppendText("\r\n" + message);
            }
        }

        private void WriteLogs(string Logs)
        {
            using (FileStream fs = new FileStream("./Export.csv", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.AutoFlush = true;
                    sw.WriteLine(Logs);
                }
            }
        }
    }
}

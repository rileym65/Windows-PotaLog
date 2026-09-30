using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace PotaLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            StreamWriter logFile;
            string entry;
            ExportDialog.Filter = "ADIF files (*.adif)|*.adif|All files (*.*)|*.*";
            if (ExportDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = ExportDialog.FileName;
                logFile = new StreamWriter(filename);
                logFile.WriteLine($"POTA Activation Log for {tb_CallSign.Text}");
                logFile.WriteLine("<ADIF_VER:5>3.1.4");
                logFile.WriteLine("<PROGRAMID:4>POTA");
                logFile.WriteLine("<EOH>");
                logFile.WriteLine("");
                string date = $"<QSO_DATE:8>{dt_Date.Value.Year:d4}{dt_Date.Value.Month:d2}{dt_Date.Value.Day:d2} ";
                string band = $"<BAND:{cb_Band.Text.Length}>{cb_Band.Text}";
                string mode = $"<MODE:{cb_Mode.Text.Length}>{cb_Mode.Text}";
                string park = $"<MY_SIG_INFO:{tb_Park.Text.Length}>{tb_Park.Text}";
                foreach (DataGridViewRow row in LogData.Rows)
                {
                    string call = (row.Cells[0].Value != null) ? row.Cells[0].Value.ToString().ToUpper() : "";
                    if (call.Length > 0)
                    {
                        string tx = (row.Cells[2].Value != null) ? row.Cells[2].Value.ToString().ToUpper() : "";
                        string rx = (row.Cells[3].Value != null) ? row.Cells[3].Value.ToString().ToUpper() : "";
                        bool isPtp = Convert.ToBoolean(row.Cells["PTP"].Value);
                        entry = $"<OPERATOR:{tb_CallSign.Text.Trim().Length}>{tb_CallSign.Text.Trim()} ";
                        entry += $"<CALL:{call.Length}>{call} ";
                        entry += date;
                        string timeon = row.Cells[1].Value.ToString() ?? "";
                        entry += $"<TIME_ON:4>{timeon:d4} ";
                        entry += $"{band} ";
                        entry += $"{mode} ";
                        if (tx.Length > 0) entry += $"<RST_SENT:{tx.Length}>{tx} ";
                        if (rx.Length > 0) entry += $"<RST_RCVD:{rx.Length}>{rx} ";
                        entry += "<MY_SIG:4>POTA ";
                        entry += $"{park} ";
                        if (isPtp)
                        {
                            string ptp = (row.Cells[5].Value != null) ? row.Cells[5].Value.ToString().ToUpper() : "";
                            if (ptp.Length > 0)
                            {
                                entry += "<SIG:4>POTA ";
                                entry += $"<SIG_INFO:{ptp.Length}>{ptp}";
                            }

                        }

                        entry += "<EOR>";
                        logFile.WriteLine(entry);
                    }
                }
                logFile.Close();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StreamWriter file;
            string line;
            ExportDialog.Filter = "Log files (*.log)|*.log|All files (*.*)|*.*";
            if (ExportDialog.ShowDialog() == DialogResult.OK)
            {
                file = new StreamWriter(ExportDialog.FileName);
                file.WriteLine($"Callsign: {tb_CallSign.Text}");
                file.WriteLine($"Band: {cb_Band.Text}");
                file.WriteLine($"Mode: {cb_Mode.Text}");
                file.WriteLine($"Park: {tb_Park.Text}");
                file.WriteLine($"Date: {dt_Date.Text}");
                foreach (DataGridViewRow row in LogData.Rows)
                {
                    string call = (row.Cells[0].Value != null) ? row.Cells[0].Value.ToString().ToUpper() : "";
                    string time = (row.Cells[1].Value != null) ? row.Cells[1].Value.ToString().ToUpper() : "";
                    string sent = (row.Cells[2].Value != null) ? row.Cells[2].Value.ToString().ToUpper() : "";
                    string rcvd = (row.Cells[3].Value != null) ? row.Cells[3].Value.ToString().ToUpper() : "";
                    bool isPtp = Convert.ToBoolean(row.Cells["PTP"].Value);
                    string ptp = (row.Cells[5].Value != null) ? row.Cells[5].Value.ToString().ToUpper() : "";
                    line = $"Entry: {call},{time},{sent},{rcvd},{isPtp.ToString()},{ptp}";
                    if (call.Length > 0) file.WriteLine(line);
                }
                file.Close();
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            StreamReader file;
            LoadFileDialog.Filter = "Log files (*.log)|*.log|All files (*.*)|*.*";

            if (LoadFileDialog.ShowDialog() == DialogResult.OK)
            {
                file = new StreamReader(LoadFileDialog.FileName);
                if (file != null)
                {
                    LogData.Rows.Clear();
                    while (!file.EndOfStream)
                    {
                        string line = file.ReadLine();
                        if (line.ToUpper().StartsWith("CALLSIGN: "))
                        {
                            string temp = line.Substring(line.IndexOf(' ') + 1).Trim();
                            tb_CallSign.Text = temp;
                        }
                        if (line.ToUpper().StartsWith("BAND: "))
                        {
                            string temp = line.Substring(line.IndexOf(' ') + 1).Trim();
                            cb_Band.Text = temp;
                        }
                        if (line.ToUpper().StartsWith("MODE: "))
                        {
                            string temp = line.Substring(line.IndexOf(' ') + 1).Trim();
                            cb_Mode.Text = temp;
                        }
                        if (line.ToUpper().StartsWith("PARK: "))
                        {
                            string temp = line.Substring(line.IndexOf(' ') + 1).Trim();
                            tb_Park.Text = temp;
                        }
                        if (line.ToUpper().StartsWith("DATE: "))
                        {
                            string temp = line.Substring(line.IndexOf(' ') + 1).Trim();
                            dt_Date.Text = temp;
                        }
                        if (line.ToUpper().StartsWith("ENTRY: "))
                        {
                            string temp = line.Substring(line.IndexOf(' ') + 1).Trim();
                            string[] fields = temp.Split(",");
                            LogData.Rows.Add();
                            LogData.Rows[LogData.Rows.Count - 2].Cells[0].Value = fields[0];
                            LogData.Rows[LogData.Rows.Count - 2].Cells[1].Value = fields[1];
                            LogData.Rows[LogData.Rows.Count - 2].Cells[2].Value = fields[2];
                            LogData.Rows[LogData.Rows.Count - 2].Cells[3].Value = fields[3];
                            LogData.Rows[LogData.Rows.Count - 2].Cells[4].Value = fields[4];
                            LogData.Rows[LogData.Rows.Count - 2].Cells[5].Value = fields[5];
                        }
                    }
                    file.Close();
                }
            }
        }
    }
}

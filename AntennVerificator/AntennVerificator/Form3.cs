using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace AntennVerificator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlCommand command;
        SqlConnection conn;

        
        public Form3(MainForm f)
        {

            InitializeComponent();
            f.BackColor = Color.Yellow;
            /*btnMenu1.Enabled = false;
            btnSettings.Enabled = false;
            btnAntennaDB.Enabled = false;
            btnAbout.Enabled = false;*/
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
            conn.Open();

            command = new SqlCommand("SELECT * FROM Antennas", conn);

            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    checkedListBox1.Items.Add((sqlDataReader[1].ToString()));
                }
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {

            }
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 4;
            Cursor.Current = Cursors.WaitCursor;
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True;multipleactiveresultsets=true");
            conn.Open();
            command = new SqlCommand("SELECT * FROM Antennas", conn);
            SqlDataReader dr1 = command.ExecuteReader();
            string shelp;
            int maxValue = 0;
            int c = 0;
            while (dr1.Read())
            {
                if (checkedListBox1.GetItemChecked(c) == true)
                {
                    shelp = dr1.GetValue(4).ToString().Trim();
                    shelp = shelp.Replace(";", "");
                    shelp = shelp.Replace(".", ",");
                    string[] subs = shelp.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    int[] intsubs = new int[subs.Length];
                    for (int i = 0; i < subs.Length; i++)
                        intsubs[i] = (int)Math.Round(float.Parse(subs[i].ToString()));
                    int k = intsubs.Max();
                    if (k > maxValue)
                    {
                        maxValue = k;
                    }
                    shelp = "";
                }
                c++;
            }
            progressBar1.PerformStep();
            dr1.Close();
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wSh = (Excel.Worksheet)exApp.ActiveSheet;
            wSh.Cells[1, 1] = "Частотные точки, шаг = 50 МГц";
            wSh.Cells[1, 2] = "КСВ антенны";
            int count = 50;

            Random rnd = new Random();
            for (int i = 2; i < maxValue / 50 + 2; i++)
            {
                wSh.Cells[i, 1] = count;
                count += 50;
                double value = rnd.NextDouble() * 10;
                value = Math.Round(value, 3);
                wSh.Cells[i, 2] = value;
            }
            progressBar1.PerformStep();

            count = 0;
            string s = "";
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True;multipleactiveresultsets=true");
            conn.Open();

            command = new SqlCommand("SELECT * FROM Antennas", conn);

            SqlDataReader dr2 = command.ExecuteReader();
            int j = 0;
            var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            progressBar1.PerformStep();
            while (dr2.Read())
            {
                if (checkedListBox1.GetItemChecked(j) == true)
                {
                    StreamWriter sw = new StreamWriter(Path.Combine(appDir, @"" + dr2.GetValue(1).ToString().Trim() + ". Отчет.txt"));
                    sw.WriteLine("Название антенны: " + dr2.GetValue(1).ToString());
                    sw.WriteLine("Частотный диапазон: " + dr2.GetValue(2).ToString());
                    sw.WriteLine("Описание: " + dr2.GetValue(3).ToString());
                    sw.WriteLine();
                    sw.WriteLine("№ Строки в Excel  Частотная точка              КСВ");
                    s = dr2.GetValue(4).ToString().Trim();
                    s = s.Replace(";", "");
                    s = s.Replace(".", ",");
                    string[] subs = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int[] intsubs = new int[subs.Length];
                    int line = 0;
                    for (int i = 0; i < subs.Length; i++)
                    {
                        intsubs[i] = (int)Math.Round(float.Parse(subs[i].ToString()));
                        line = intsubs[i] / 50;
                        if (line == 0)
                            sw.WriteLine(String.Format("{0,16} {1,16} {2,16}", "---", subs[i], "---"));
                        else
                        {
                            Excel.Range forYach = wSh.Cells[line + 1, 1] as Excel.Range;
                            string yach = forYach.Value.ToString();
                            Excel.Range ksv = wSh.Cells[line + 1, 2] as Excel.Range;
                            sw.WriteLine(String.Format("{0,16} {1,16} {2,16}", line, yach, ksv.Value.ToString()));
                        }
                    }
                    s = "";
                    sw.Close();
                }
                j++;
            }
            j = 0;
            progressBar1.PerformStep();
            exApp.Application.ActiveWorkbook.SaveAs(Path.Combine(appDir, @"Таблица.xlsx"), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //exApp.Quit();
            dr2.Close();
            Cursor.Current = Cursors.Default;

            DialogResult dialogResult = MessageBox.Show("Расчет успешно завершен. Открыть отчеты и Excel файл?", "Успешно", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlDataReader dr3 = command.ExecuteReader();
                while (dr3.Read())
                {
                    if (checkedListBox1.GetItemChecked(j) == true)
                    {
                        System.Diagnostics.Process txt = new System.Diagnostics.Process();
                        txt.StartInfo.FileName = "notepad.exe";
                        txt.StartInfo.Arguments = Path.Combine(appDir, @"" + dr3.GetValue(1).ToString().Trim() + ". Отчет.txt");
                        txt.Start();
                    }
                    j++;
                    exApp.Visible = true;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Вы можете найти файлы отчетов и Excel по пути Поверка/bin/x64/Debug");
            }
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
                button3.Enabled = true;
            else
                button3.Enabled = false;
        }
    }
}

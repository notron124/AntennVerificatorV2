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
using System.Diagnostics;

namespace AntennVerificator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        SqlCommand command;
        SqlConnection conn;

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CloseProcess(Excel.Application exApp, Excel.Worksheet wSh, Excel.Workbook wB)
        {
            /*exApp.Close(false);//aplication
            wB.Quit();//workbook
            wB = null;
            exApp = null;
            wSh = null;//Sheet*/
            Process[] List;
            List = Process.GetProcessesByName("EXCEL");
            foreach (Process proc in List)
            {
                proc.Kill();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 3;
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
            //Excel.Workbook wB = new Excel.Workbook();
            exApp.DisplayAlerts = false;
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

            count = 0;
            string s = "";
            /*conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True;multipleactiveresultsets=true");
            conn.Open();*/

            command = new SqlCommand("SELECT * FROM Antennas", conn);

            SqlDataReader dr2 = command.ExecuteReader();
            int j = 0;
            var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            progressBar1.PerformStep();
            StreamWriter sw = new StreamWriter(Path.Combine(appDir, @"Отчет.txt"));
            while (dr2.Read())
            {
                if (checkedListBox1.GetItemChecked(j) == true)
                {
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
                    sw.WriteLine();
                    sw.WriteLine("-------------------------------------------------------------");
                    sw.WriteLine();
                    s = "";
                }
                j++;
            }
            sw.Close();
            j = 0;
            //CloseProcess(exApp, wSh, wB);
            //exApp.Close(SaveChanges:= True, Filename:= CurDir & FileToSave);
            exApp.Application.ActiveWorkbook.SaveAs(Path.Combine(appDir, @"Таблица.xlsx"), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //exApp.Quit();
            dr2.Close();
            Cursor.Current = Cursors.Default;
            progressBar1.PerformStep();

            DialogResult dialogResult = MessageBox.Show("Расчет успешно завершен. Открыть отчеты и Excel файл?", "Успешно", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlDataReader dr3 = command.ExecuteReader();
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = Path.Combine(appDir, @"Отчет.txt");
                txt.Start();
                exApp.Visible = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Вы можете найти файлы отчетов и Excel по пути Поверка/bin/x64/Debug");
                Application.Exit();
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
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
            conn.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkedListBox1.CheckedItems.Count != 0)
                button3.Enabled = true;
            else
                button3.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkedListBox1.CheckedItems.Count != 0)
                button3.Enabled = true;
            else
                button3.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkedListBox1.CheckedItems.Count != 0)
                button3.Enabled = true;
            else
                button3.Enabled = false;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(checkedListBox1.CheckedItems.Count.ToString());
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkedListBox1.CheckedItems.Count != 0)
                button3.Enabled = true;
            else
                button3.Enabled = false;

        }

        private void checkedListBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(checkedListBox1.CheckedItems.Count.ToString());
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkedListBox1.CheckedItems.Count != 0)
                button3.Enabled = true;
            else
                button3.Enabled = false;
        }

        private void Calculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}

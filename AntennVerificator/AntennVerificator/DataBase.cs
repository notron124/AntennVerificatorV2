using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using TextBox = System.Windows.Forms.TextBox;
using System.Linq.Expressions;

namespace AntennVerificator
{
    public partial class DataBase : Form
    {
        #region --Variables--
        readonly Constants constVariables = new Constants();
        public List<Antenna> antennas = new List<Antenna>();

        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        #endregion

        #region --Functions--
        #region --Checks for inputs--
        public bool CheckIfInputIsNotEmpty(string ID, string name, string freqRange, string discription, string freqPoints)
        {
            return (!string.IsNullOrWhiteSpace(ID) && !string.IsNullOrWhiteSpace(name) &&
                !string.IsNullOrWhiteSpace(freqRange) &&
                !string.IsNullOrWhiteSpace(discription) &&
                !string.IsNullOrWhiteSpace(freqPoints));
        }
        public bool CheckIfInputIsNotEmpty(string name, string freqRange, string discription, string freqPoints)
        {
            return (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(freqRange) &&
                !string.IsNullOrWhiteSpace(discription) &&
                !string.IsNullOrWhiteSpace(freqPoints));
        }

        public string ShowWhatInputIsEmpty(string ID, string name, string freqRange, string discription, string freqPoints)
        {
            string spaces = "";
            if (string.IsNullOrEmpty(ID))
                spaces += "ID\n";
            if (string.IsNullOrEmpty(name))
                spaces += "Название\n";
            if (string.IsNullOrEmpty(freqRange))
                spaces += "Частотный диапазон\n";
            if (string.IsNullOrEmpty(discription))
                spaces += "Описание\n";
            if (string.IsNullOrEmpty(freqPoints))
                spaces += "Частотные точки";
            return spaces;

        }

        public string ShowWhatInputIsEmpty(string name, string freqRange, string discription, string freqPoints)
        {
            string spaces = "";
            if (string.IsNullOrEmpty(name))
                spaces += "Название\n";
            if (string.IsNullOrEmpty(freqRange))
                spaces += "Частотный диапазон\n";
            if (string.IsNullOrEmpty(discription))
                spaces += "Описание\n";
            if (string.IsNullOrEmpty(freqPoints))
                spaces += "Частотные точки";
            return spaces;

        }
        #endregion

        #region --Startup functuons--
        string ToFloatValuesString(float[] items, string separator = "; ")
        {
            var result = new StringBuilder();
            for (int i = 0; i < items.Length; i++)
            {
                result.Append(items[i].ToString("R", NumberFormatInfo.InvariantInfo));
                if (i < items.Length - 1)
                    result.Append(separator);
            }

            return result.ToString();
        }

        void FillListWithAntennas()
        {
            antennas.Add(constVariables.antenna1);
            antennas.Add(constVariables.antenna2);
            antennas.Add(constVariables.antenna3);
            antennas.Add(constVariables.antenna4);
            antennas.Add(constVariables.antenna5);
        }

        public void CreateAndOpenNewSQLConnection()
        {
            FillListWithAntennas();

            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
            sqlConnection.Open();



            /*for (int i = 0; i < antennas.Count; i++)
            {
                sqlCommand = new SqlCommand("UPDATE Antennas SET name=@name,frequencywidth=@frequencywidth,description=@description, freqdots=@freqdots WHERE id=@id", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@id", i + 1);
                sqlCommand.Parameters.AddWithValue("@name", antennas[i].Name);
                sqlCommand.Parameters.AddWithValue("@frequencywidth", antennas[i].FrequencyWidth);
                sqlCommand.Parameters.AddWithValue("@description", antennas[i].Description);
                sqlCommand.Parameters.AddWithValue("@freqdots", antennas[i].FreqDots.ToString());

                sqlCommand.ExecuteNonQuery();

            }*/
        }
        #endregion

        #region --TextBox Actions--
        public void ClearAllTextBoxes(RichTextBox rtbID, RichTextBox rtbName, RichTextBox rtbFreqRange, RichTextBox rtbDiscription, RichTextBox rtbFreqPoints)
        {
            rtbID.Text = "";
            rtbName.Text = "";
            rtbFreqRange.Text = "";
            rtbDiscription.Text = "";
            rtbFreqPoints.Text = "";
        }

        public void ClearAllTextBoxes(TextBox tbID, TextBox tbName, TextBox tbFreqRange, TextBox tbDiscription, TextBox tbFreqPoints)
        {
            tbID.Text = "";
            tbName.Text = "";
            tbFreqRange.Text = "";
            tbDiscription.Text = "";
            tbFreqPoints.Text = "";
        }

        private string SequenceFromTo(string from, string to, string step)
        {
            string sequence = "";
            int i = 0, N = 0, stp = 0;
            try
            {
                i = Int32.Parse(from);
            }
            catch(FormatException)
            {
                MessageBox.Show($"Неверный формат данных: '{from}'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return sequence;
            }

            try
            {
                N = Int32.Parse(to);
            }
            catch (FormatException)
            {
                MessageBox.Show($"Неверный формат данных: '{to}'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return sequence;
            }

            try
            {
                stp = Int32.Parse(step);
            }
            catch (FormatException)
            {
                MessageBox.Show($"Неверный формат данных: '{to}'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return sequence;
            }

            for (; i < N + stp; i += stp)
            {
                sequence += i.ToString() + " ";
            }
                return sequence;
        }
        #endregion

        #region --AntennasActions--
        public void AddAntenna(RichTextBox rtbID, RichTextBox rtbName, RichTextBox rtbFreqRange, RichTextBox rtbDiscription, RichTextBox rtbFreqPoints)
        {
            if (CheckIfInputIsNotEmpty(tbName.Text, tbFreqRange.Text, tbDiscription.Text, tbFreqPoints.Text))
            {
                string[] subs = rtbFreqPoints.Text.Split(new[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
                float[] mas = new float[subs.Length];

                for (int i = 0; i < subs.Length; i++)
                {
                    subs[i] = subs[i].Replace('.', ',');
                    subs[i] = subs[i].Replace("; ", "");
                    try
                    {
                        mas[i] = float.Parse(subs[i].ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Введены неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                string smas = ToFloatValuesString(mas);

                sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
                sqlConnection.Open();

                sqlCommand = new SqlCommand("INSERT INTO Antennas (name, frequencywidth, description, freqdots) VALUES (@name,@frequencywidth,@description,@freqdots)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@name", rtbName.Text);
                sqlCommand.Parameters.AddWithValue("@frequencywidth", rtbFreqRange.Text);
                sqlCommand.Parameters.AddWithValue("@description", rtbDiscription.Text);
                sqlCommand.Parameters.AddWithValue("@freqdots", smas);

                Antenna ant = new Antenna(rtbName.Text, rtbFreqRange.Text, rtbDiscription.Text, smas);
                antennas.Add(ant);
                WriteToDB(ant);

                sqlCommand.ExecuteNonQuery();

                ClearAllTextBoxes(tbID, tbName, tbFreqRange, tbDiscription, tbFreqPoints);
                sqlCommand = new SqlCommand("SELECT * FROM Antennas", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                int count = 0;
                while(sqlDataReader.Read())
                {
                    count++;
                }
                MessageBox.Show("Антенна добавлена: ID = " + count);
                sqlDataReader.Close();
                sqlConnection.Close();
            }
            else
                MessageBox.Show("Заполните поля:\n" + ShowWhatInputIsEmpty(tbName.Text, tbFreqRange.Text, tbDiscription.Text, tbFreqPoints.Text));
        }
        public void WriteToDB(Antenna ant)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
            sqlConnection.Open();

            sqlCommand = new SqlCommand("INSERT INTO Antennas (name,frequencywidth,description,freqdots) VALUES (@name,@frequencywidth,@description,@freqdots)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@name", ant.Name);
            sqlCommand.Parameters.AddWithValue("@frequencywidth", ant.FrequencyWidth);
            sqlCommand.Parameters.AddWithValue("@description", ant.Description);
            sqlCommand.Parameters.AddWithValue("@freqdots", ant.FreqDots);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Места добавлены из структуры", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //sqlConnection.Close();
        }
        public void AddAntenna(TextBox tbID, TextBox tbName, TextBox tbFreqRange, TextBox tbDiscription, TextBox tbFreqPoints)
        {
            if (CheckIfInputIsNotEmpty(tbName.Text, tbFreqRange.Text, tbDiscription.Text, tbFreqPoints.Text))
            {
                string[] subs = tbFreqPoints.Text.Split(new[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
                float[] mas = new float[subs.Length];

                for (int i = 0; i < subs.Length; i++)
                {
                    subs[i] = subs[i].Replace('.', ',');
                    subs[i] = subs[i].Replace("; ", "");
                    mas[i] = float.Parse(subs[i].ToString());
                }

                string smas = ToFloatValuesString(mas);

                sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
                sqlConnection.Open();

                sqlCommand = new SqlCommand("INSERT INTO Antennas (name, frequencywidth, description, freqdots) VALUES (@name,@frequencywidth,@description,@freqdots)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@name", tbName.Text);
                sqlCommand.Parameters.AddWithValue("@frequencywidth", tbFreqRange.Text);
                sqlCommand.Parameters.AddWithValue("@description", tbDiscription.Text);
                sqlCommand.Parameters.AddWithValue("@freqdots", smas);

                sqlCommand.ExecuteNonQuery();

                ClearAllTextBoxes(tbID, tbName, tbFreqRange, tbDiscription, tbFreqPoints);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                int count = 0;
                if (sqlDataReader.HasRows)
                {
                    count++;
                }
                MessageBox.Show("Антенна добавлена: ID = " + count);
            }
            else
                MessageBox.Show("Заполните поля:\n" + ShowWhatInputIsEmpty(tbName.Text, tbFreqRange.Text, tbDiscription.Text, tbFreqPoints.Text));
        }

        public void ChangeAntenna(TextBox tbID, TextBox tbName, TextBox tbFreqRange, TextBox tbDiscription, TextBox tbFreqPoints)
        {
            if (CheckIfInputIsNotEmpty(tbID.Text, tbName.Text, tbFreqRange.Text, tbDiscription.Text, tbFreqPoints.Text))
            {
                sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
                sqlConnection.Open();

                sqlCommand = new SqlCommand("UPDATE Antennas SET name=@name,frequencywidth=@frequencywidth,description=@description WHERE id=@id", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@name", tbName.Text);
                sqlCommand.Parameters.AddWithValue("@frequencywidth", tbFreqRange.Text);
                sqlCommand.Parameters.AddWithValue("@description", tbDiscription.Text);
                sqlCommand.Parameters.AddWithValue("@freqdots", tbDiscription.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Данные изменены");
            }
            else
                MessageBox.Show("Заполните поля:\n" + ShowWhatInputIsEmpty(tbID.Text, tbName.Text, tbFreqRange.Text, tbDiscription.Text, tbFreqPoints.Text));
        }

        public void ChangeAntenna(RichTextBox tbID, RichTextBox tbName, RichTextBox tbFreqRange, RichTextBox tbDiscription, RichTextBox tbFreqPoints)
        {
            if (CheckIfInputIsNotEmpty(tbID.Text, tbName.Text, tbFreqRange.Text, tbDiscription.Text, tbFreqPoints.Text))
            {
                sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
                sqlConnection.Open();

                sqlCommand = new SqlCommand("UPDATE Antennas SET name=@name,frequencywidth=@frequencywidth,description=@description WHERE id=" + tbID.Text + "", sqlConnection);

                //sqlCommand.Parameters.AddWithValue("@id", tbID.Text);
                sqlCommand.Parameters.AddWithValue("@name", tbName.Text);
                sqlCommand.Parameters.AddWithValue("@frequencywidth", tbFreqRange.Text);
                sqlCommand.Parameters.AddWithValue("@description", tbDiscription.Text);
                sqlCommand.Parameters.AddWithValue("@freqdots", tbDiscription.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Данные изменены");
            }
            else
                MessageBox.Show("Заполните поля:\n" + ShowWhatInputIsEmpty(tbID.Text, tbName.Text, tbFreqRange.Text, tbDiscription.Text, tbFreqPoints.Text));
        }

        public void CheckAntenna(TextBox tbID, TextBox tbName, TextBox tbFreqRange, TextBox tbDiscription, TextBox tbFreqPoints)
        {
            if (!string.IsNullOrWhiteSpace(tbID.Text))
            {
                sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
                sqlConnection.Open();

                sqlCommand = new SqlCommand("SELECT name,frequencywidth,description,freqdots FROM Antennas WHERE id=" + tbID.Text + "", sqlConnection);

                try
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();

                    if (sqlDataReader.HasRows)
                    {
                        tbName.Text = sqlDataReader[0].ToString();
                        tbFreqRange.Text = sqlDataReader[1].ToString();
                        tbDiscription.Text = sqlDataReader[2].ToString();
                        tbFreqPoints.Text = sqlDataReader[3].ToString();
                    }
                    else
                        MessageBox.Show("Антенны с таким ID нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Введите число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Введите ID");
        }

        public void CheckAntenna(RichTextBox tbID, RichTextBox tbName, RichTextBox tbFreqRange, RichTextBox tbDiscription, RichTextBox tbFreqPoints)
        {
            if (!string.IsNullOrWhiteSpace(tbID.Text))
            {
                sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
                sqlConnection.Open();

                sqlCommand = new SqlCommand("SELECT name,frequencywidth,description,freqdots FROM Antennas WHERE id=" + tbID.Text + "", sqlConnection);

                try
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();

                    if (sqlDataReader.HasRows)
                    {
                        tbName.Text = sqlDataReader[0].ToString();
                        tbFreqRange.Text = sqlDataReader[1].ToString();
                        tbDiscription.Text = sqlDataReader[2].ToString();
                        tbFreqPoints.Text = sqlDataReader[3].ToString();
                    }
                    else
                        MessageBox.Show("Антенны с таким ID нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Введите число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Введите ID", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void DeleteAntenna(TextBox tbID, TextBox tbName, TextBox tbFreqRange, TextBox tbDiscription, TextBox tbFreqPoints)
        {
            if (!string.IsNullOrWhiteSpace(tbID.Text))
            {
                sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
                sqlConnection.Open();

                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить эту антенну?", "", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    sqlCommand = new SqlCommand("DELETE FROM Antennas WHERE [id]=@id", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("id", tbID.Text);

                    sqlCommand.ExecuteNonQuery();
                    tbName.Text = "";
                    tbFreqRange.Text = "";
                    tbDiscription.Text = "";
                    tbFreqPoints.Text = "";
                    MessageBox.Show("Антенна удалена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Введите ID", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteAntenna(RichTextBox tbID, RichTextBox tbName, RichTextBox tbFreqRange, RichTextBox tbDiscription, RichTextBox tbFreqPoints)
        {
            if (!string.IsNullOrWhiteSpace(tbID.Text))
            {
                sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
                sqlConnection.Open();

                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить эту антенну?", "", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    sqlCommand = new SqlCommand("DELETE FROM Antennas WHERE [id]=@id", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("id", tbID.Text);

                    sqlCommand.ExecuteNonQuery();
                    tbName.Text = "";
                    tbFreqRange.Text = "";
                    tbDiscription.Text = "";
                    tbFreqPoints.Text = "";
                    MessageBox.Show("Антенна удалена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Введите ID", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void WriteAntennaInDB()
        {
            /*sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
            sqlConnection.Open();
            for (int i = 0; i < antennas.Count; i++)
            {
                sqlCommand = new SqlCommand("UPDATE Antennas SET name=@name,frequencywidth=@frequencywidth,description=@description,freqdots=@freqdots", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@name", antennas[i].Name);
                sqlCommand.Parameters.AddWithValue("@frequencywidth", antennas[i].FrequencyWidth);
                sqlCommand.Parameters.AddWithValue("@description", antennas[i].Description);
                sqlCommand.Parameters.AddWithValue("@freqdots", antennas[i].FreqDots);
                sqlCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Места добавлены из структуры", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlConnection.Close();*/
        }
        #endregion
        #endregion

        #region --Form start--
        public DataBase()
        {
            InitializeComponent();
        }
        private void AntennaFormLoad(object sender, EventArgs e)
        {
            CreateAndOpenNewSQLConnection();
        }
        #endregion

        #region --Button responce--
        private void changeBtn_Click(object sender, EventArgs e)
        {
            ChangeAntenna(tbID, tbName, tbFreqRange, tbDiscription, tbFreqPoints);
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            CheckAntenna(tbID, tbName, tbFreqRange, tbDiscription, tbFreqPoints);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteAntenna(tbID, tbName, tbFreqRange, tbDiscription, tbFreqPoints);
        }

        private void writeInDbBtn_Click(object sender, EventArgs e)
        {
            WriteAntennaInDB();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(tbID, tbName, tbFreqRange, tbDiscription, tbFreqPoints);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddAntenna(tbID, tbName, tbFreqRange, tbDiscription, tbFreqPoints);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void tbFreqPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsPunctuation(number) && !Char.IsWhiteSpace(number))
            {
                e.Handled = true;
            }
        }

        private void FillBtn_Click(object sender, EventArgs e)
        {
            tbFreqPoints.Text = SequenceFromTo(tbFrom.Text, tbTo.Text, tbStep.Text);
        }
    }
}

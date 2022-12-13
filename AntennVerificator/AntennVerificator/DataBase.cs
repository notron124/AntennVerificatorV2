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

namespace AntennVerificator
{
    public partial class DataBase : Form
    {
        #region --Variables--
        public List<Antenna> antennas = new List<Antenna>();
        List<Picture> Pictures = new List<Picture>();

        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        #endregion

        #region --Functions--
        public string ToFloatValuesString(float[] items, string separator = "; ")
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

        public void Fill()
        {
            string sfloatdots1 = "1000; 2000; 3000; 4000; 5000; 6000; 7000; 8000; 9000; 10000; 11000; 12000";
            string sfloatdots2 = "0.009; 0.01; 0.02; 0.05; 0.1; 0.2; 0.5; 1; 2; 5; 10; 20; 30; 50; 100; 200; 300; 400; 500; 600";
            string sfloatdots3 = "0.009; 0.01; 0.02; 0.05; 0.1; 0.2; 0.5; 1; 2; 5; 10; 20; 30; 50; 100; 200; 300";
            string sfloatdots4 = "0.009; 0.01; 0.02; 0.5; 1; 2; 5; 10; 20; 25; 30; 50; 100; 150; 200; 300; 400; 500; 1000; 1500; 2000; 2500; 3000; 3500; 4000; 4500; 5000; 5500; 6000; 6500; 7000; 7500";
            string sfloatdots5 = "1000; 2000; 3000; 4000; 5000; 6000; 7000; 8000; 9000; 10000; 11000; 12000";
            Antenna antenna1 = new Antenna("П6-23А", "1-12 ГГц", "Широкополосная антенна измерительная П6-23А представляет собой рупорно-линзовую антенну со стандартным коаксиальным соединителем. Антенна предназначена для измерения плотности потока энергии, создания электромагнитного поля с заданной плотностью, измерения параметров антенн различных типов, измерения параметров электромагнитной совместимости радиоэлектронных средств, мониторинга электромагнитной обстановки и пеленгации источников электромагнитного излучения совместно с приёмными устройствами.", sfloatdots1);
            Antenna antenna2 = new Antenna("НБА-02", "0,009-2500 МГц", "Антенна биконическая измерительная НБА-02 предназначена для измерений электрической составляющей электромагнитных полей в лабораторных помещениях в комплекте с измерительными приемниками, анализаторами спектра. Антенна имеет встроенный усилитель, конструктивно объединенный с устройством согласования. Питание биконической антенны осуществляется от аккумуляторной батареи, размещенной в ручке антенны.", sfloatdots2);
            Antenna antenna3 = new Antenna("АИ5-0", "0,009-2000 МГц", "АИ 5-0 предназначена для измерения побочных электромагнитных излучений и наводок (ПЭМИН) от различных радиоэлектронных устройств (РЭУ) и применяется в сфере обороны и безопасности, а также при проведении работ по обеспечению электромагнитной совместимости РЭУ.Обеспечивает высокую точность измерения на малых расстояниях от исследуемых РЭУ. Используется как в закрытых помещениях (лаборатории, экранированные камеры и т.д.), так и на открытой площади", sfloatdots3);
            Antenna antenna4 = new Antenna("НЕ300", "500-7500 МГц", "Удобная активная направленная антенна R&S HE300CE в сочетании сизмерительными приемниками или анализаторами спектра(например,приемниками R & S PR100 или R & S FSH - 8) используется для определенияположения источников сигнала, помех и измерения напряженности электрическогополя.", sfloatdots4);
            Antenna antenna5 = new Antenna("П6-59", "1-18 ГГц", "Антенна измерительная рупорная П6-59 является пассивной и предназначена для излучения и измерения электромагнитного поля в диапазоне частот от 1 до 18 ГГц и используется для измерения радиопомех при решении задач электромагнитной совместимости технических средств, а также предельно допустимых уровней электромагнитных полей при экологозащитных мероприятиях. Обеспечивает проведение раздельных измерений горизонтальной и вертикальной составляющих электромагнитного поля. Соответствует требованиям ГОСТ Р 51319-99 и международного стандарта СИСПР 16-1. Может эксплуатироваться в помещениях и на открытых площадках.", sfloatdots5);
            antennas.Add(antenna1);
            antennas.Add(antenna2);
            antennas.Add(antenna3);
            antennas.Add(antenna4);
            antennas.Add(antenna5);
            /*Picture image1 = new Picture(@"C:\Users\sshv2\Desktop\Images\p6-23a.jpg");
            Picture image2 = new Picture(@"C:\Users\sshv2\Desktop\Images\nba-02.jpg");
            Picture image3 = new Picture(@"C:\Users\sshv2\Desktop\Images\ai5-0.png");
            Picture image4 = new Picture(@"C:\Users\sshv2\Desktop\Images\he300.jpg");
            Picture image5 = new Picture(@"C:\Users\sshv2\Desktop\Images\p6-59.png");
            Pictures.Add(image1);
            Pictures.Add(image2);
            Pictures.Add(image3);
            Pictures.Add(image4);
            Pictures.Add(image5);*/
        }

        private void AntennaFormLoad(object sender, EventArgs e)
        {

            Fill();

            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
            sqlConnection.Open();



            for (int i = 0; i < antennas.Count; i++)
            {
                sqlCommand = new SqlCommand("UPDATE Antennas SET name=@name,frequencywidth=@frequencywidth,description=@description, freqdots=@freqdots WHERE id=@id", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@id", i + 1);
                sqlCommand.Parameters.AddWithValue("@name", antennas[i].Name);
                sqlCommand.Parameters.AddWithValue("@frequencywidth", antennas[i].FrequencyWidth);
                sqlCommand.Parameters.AddWithValue("@description", antennas[i].Description);
                sqlCommand.Parameters.AddWithValue("@freqdots", antennas[i].FreqDots.ToString());

                sqlCommand.ExecuteNonQuery();

            }

            for (int i = 0; i < Pictures.Count; i++)
            {
                sqlCommand = new SqlCommand("UPDATE ImageTable SET picture=@picture WHERE id=@id", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@id", i);
                sqlCommand.Parameters.AddWithValue("@picture", Image.FromFile(Pictures[i].Path));
            }
        }
        #endregion

        public DataBase()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text) &&
            !string.IsNullOrEmpty(tbName.Text) && !string.IsNullOrWhiteSpace(tbName.Text) &&
            !string.IsNullOrEmpty(tbFreqRange.Text) && !string.IsNullOrWhiteSpace(tbFreqRange.Text) &&
            !string.IsNullOrEmpty(tbDiscription.Text) && !string.IsNullOrWhiteSpace(tbDiscription.Text) &&
               !string.IsNullOrEmpty(tbFreqPoints.Text) && !string.IsNullOrWhiteSpace(tbFreqPoints.Text))
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
                tbName.Text = "";
                tbFreqRange.Text = "";
                tbDiscription.Text = "";
                tbFreqPoints.Text = "";
                MessageBox.Show("Антенна добавлена");
            }
            else
                MessageBox.Show("Необходимо заполнить все поля");
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text) &&
            !string.IsNullOrEmpty(tbName.Text) && !string.IsNullOrWhiteSpace(tbName.Text) &&
            !string.IsNullOrEmpty(tbFreqRange.Text) && !string.IsNullOrWhiteSpace(tbFreqRange.Text) &&
               !string.IsNullOrEmpty(tbDiscription.Text) && !string.IsNullOrWhiteSpace(tbDiscription.Text))
            {
                sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
                sqlConnection.Open();

                sqlCommand = new SqlCommand("UPDATE Antennas SET name=@name,frequencywidth=@frequencywidth,description=@description WHERE id=@id", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@name", tbName.Text);
                sqlCommand.Parameters.AddWithValue("@frequencywidth", tbFreqRange.Text);
                sqlCommand.Parameters.AddWithValue("@description", tbDiscription.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Данные изменены");
            }
            else
                MessageBox.Show("Необходимо заполнить все поля");
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text))
            {
                sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
                sqlConnection.Open();

                sqlCommand = new SqlCommand("SELECT name,frequencywidth,description,freqdots FROM Antennas WHERE id=" + tbID.Text + "", sqlConnection);

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
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
            sqlConnection.Open();
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text))
            {
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
                    MessageBox.Show("Антенна удалена");

                }
            }
            else
                MessageBox.Show("Введите ID");
        }

        private void writeInDbBtn_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AntennaDB.mdf;Integrated Security=True");
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
            for (int i = 0; i < Pictures.Count; i++)
            {
                sqlCommand = new SqlCommand("UPDATE ImageTable SET picture=@picture", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@name", antennas[i].Name);
                sqlCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Места добавлены из структуры");
            sqlConnection.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbName.Text = "";
            tbFreqRange.Text = "";
            tbDiscription.Text = "";
            tbFreqPoints.Text = "";
        }
    }
}

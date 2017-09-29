using FirebirdSql.Data.FirebirdClient;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TranslatorFDB
{
    public partial class TranslatorForm : Form
    {
        FbConnection fbConnection = new FbConnection();


        public TranslatorForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataGridView CopyDataGridView(DataGridView dgv_org)
        {
            DataGridView dgv_copy = new DataGridView();
            try
            {
                if (dgv_copy.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv_org.Columns)
                    {
                        dgv_copy.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv_org.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgv_org.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgv_org.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dgv_copy.Rows.Add(row);
                }
                dgv_copy.AllowUserToAddRows = false;
                dgv_copy.Refresh();

            }
            catch (Exception ex)
            {

            }
            return dgv_copy;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EndLangCB.SelectedIndex = 1;
            StartLangCB.SelectedIndex = 0;

            //формируем connection string для последующего соединения с нашей базой данных
            FbConnectionStringBuilder fb_con = new FbConnectionStringBuilder();
            fb_con.Charset = "WIN1251"; //используемая кодировка
            fb_con.UserID = "Sysdba"; //логин
            fb_con.Password = "masterkey"; //пароль
            fb_con.Database = @"D:\\DataBase\\Full_DB.IB"; //путь к файлу базы данных
            fb_con.ServerType = 0; //указываем тип сервера (0 - "полноценный Firebird" (classic или super server), 1 - встроенный (embedded))

            //создаем подключение
            fbConnection = new FbConnection(fb_con.ToString()); //передаем нашу строку подключения объекту класса FbConnection



            //FbDatabaseInfo fb_inf = new FbDatabaseInfo(fbConnection); //информация о БД
            //MessageBox.Show("Info: " + fb_inf.ServerClass + "; " + fb_inf.ServerVersion); //выводим тип и версию используемого сервера Firebird

            if (fbConnection.State == ConnectionState.Closed)
                fbConnection.Open();

            FbTransaction fbt = fbConnection.BeginTransaction(); //стартуем транзакцию; стартовать транзакцию можно только для открытой базы (т.е. мутод Open() уже был вызван ранее, иначе ошибка)

            FbCommand SelectSQL = new FbCommand("select rdb$relation_name from rdb$relations where rdb$view_blr is null and (rdb$system_flag is null or rdb$system_flag = 0);", fbConnection); //задаем запрос на выборку

            SelectSQL.Transaction = fbt; //необходимо проинициализить транзакцию для объекта SelectSQL
            FbDataReader reader = SelectSQL.ExecuteReader(); //для запросов, которые возвращают результат в виде набора данных надо использоваться метод ExecuteReader()

            var source = new AutoCompleteStringCollection(); //в эту переменную будем складывать результат запроса Select

            try
            {
                while (reader.Read()) //пока не прочли все данные выполняем...
                {
                    source.Add(reader.GetString(0).Trim());
                }
                TableNameTB.AutoCompleteCustomSource = source;
            }
            finally
            {
                //всегда необходимо вызывать метод Close(), когда чтение данных завершено
                reader.Close();
                fbConnection.Close(); //закрываем соединение, т.к. оно нам больше не нужно
            }

            SelectSQL.Dispose(); //в документации написано, что ОЧЕНЬ рекомендуется убивать объекты этого типа, если они больше не нужны

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RefreshColumnsBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

            // открываем соединение, если закрыто
            if (fbConnection.State == ConnectionState.Closed)
                fbConnection.Open();

            //-------------------заполнение таблицы с данными-----------------
            {
                // команда на выделение данных
                var command = string.Format("SELECT * from {0}", TableNameTB.Text);

                var fbda = new FbDataAdapter(command, fbConnection);
                // Объект DataTable отслеживает и сохраняет в памяти изменения
                var dt = new DataTable();
                // Теперь заполняем находящийся в памяти объект DataSet
                fbda.Fill(dt);
                // Привязываем элемент DataGridView (визуальную таблицу) к хранящимся в памяти данным
                StartDGV.DataSource = dt;

                //-------------------заполнение полей для выбора--------------------

                FbTransaction fbt = fbConnection.BeginTransaction(); //стартуем транзакцию; стартовать транзакцию можно только для открытой базы (т.е. мутод Open() уже был вызван ранее, иначе ошибка)
                command = string.Format("select rdb$field_name from rdb$relation_fields where rdb$relation_name = \'{0}\'", TableNameTB.Text);

                FbCommand SelectSQL = new FbCommand(command, fbConnection); //задаем запрос на выборку

                SelectSQL.Transaction = fbt; //необходимо проинициализить транзакцию для объекта SelectSQL
                FbDataReader reader = SelectSQL.ExecuteReader(); //для запросов, которые возвращают результат в виде набора данных надо использоваться метод ExecuteReader()

                var source = new List<string>(); //в эту переменную будем складывать результат запроса Select
                ColumnsCLB.Items.Clear();
                try
                {
                    while (reader.Read()) //пока не прочли все данные выполняем...
                    {
                        ColumnsCLB.Items.Add(reader.GetString(0).Trim());
                    }

                }
                finally
                {
                    //всегда необходимо вызывать метод Close(), когда чтение данных завершено
                    reader.Close();
                    fbt.Dispose();
                    //fbConnection.Close(); //закрываем соединение, т.к. оно нам больше не нужно
                }

                SelectSQL.Dispose(); //в документации написано, что ОЧЕНЬ рекомендуется убивать объекты этого типа, если они больше не нужны
            }
            //-------------------узнаем первичный ключ таблицы--------------------
            {
                //стартуем транзакцию;
                FbTransaction fbt = fbConnection.BeginTransaction();

                // команда для того, чтобы украсть имя пк таблицы
                string command = string.Format("select sg.rdb$field_name as pk_name" +
                    " from rdb$indices ix" +
                    " left join rdb$index_segments sg on ix.rdb$index_name = sg.rdb$index_name" +
                    " left join rdb$relation_constraints rc on rc.rdb$index_name = ix.rdb$index_name" +
                    " where rc.rdb$constraint_type = 'PRIMARY KEY' and rc.rdb$relation_name = \'{0}\'", TableNameTB.Text);

                FbCommand SelectSQL = new FbCommand(command, fbConnection); //задаем запрос на выборку

                SelectSQL.Transaction = fbt; //необходимо проинициализить транзакцию для объекта SelectSQL
                FbDataReader reader = SelectSQL.ExecuteReader(); //для запросов, которые возвращают результат в виде набора данных надо использоваться метод ExecuteReader()

                try
                {
                    reader.Read();
                    PkNameTB.Text = reader.GetString(0).Trim();

                }
                finally
                {
                    //всегда необходимо вызывать метод Close(), когда чтение данных завершено
                    reader.Close();
                    fbConnection.Close(); //закрываем соединение, т.к. оно нам больше не нужно
                }

                SelectSQL.Dispose();
            }


        }

        private void EndLangCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ColumnsCLB_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void ColumnsCLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                UpdateStartTable();
            }));
        }

        private void UpdateStartTable()
        {

            if (ColumnsCLB.CheckedItems.Count == 0)
            {
                TranslateBtn.Enabled = false;
                for (int i = 0; i < ColumnsCLB.Items.Count; i++)
                {
                    string colName = (string)ColumnsCLB.Items[i];
                    StartDGV.Columns[colName].Visible = true;
                }
            }
            else
            // The collection will not be empty once this click is handled
            {
                TranslateBtn.Enabled = true;

                // 
                string tablesNames = string.Join(",", ColumnsCLB.CheckedItems.OfType<object>().ToArray());
                for (int i = 0; i < ColumnsCLB.Items.Count; i++)
                {
                    bool colMustBeVisible = (ColumnsCLB.GetItemCheckState(i) == CheckState.Checked);
                    string colName = (string)ColumnsCLB.Items[i];
                    StartDGV.Columns[colName].Visible = colMustBeVisible;
                }

            }

        }

        private void TranslateBtn_Click(object sender, EventArgs e)
        {
            /*
             * 1. Получаем все выделенные поля
             * 2. Для каждого поля переводим нужные поля и заном все это в другую таблицу
             * */

            // поля для перевода
            List<string> colToTranslate = ColumnsCLB.CheckedItems.OfType<string>().ToList();

            //сначала запрос, потом чтение из базы до комита

            ResultDGV.Columns.Clear();
            foreach (DataGridViewColumn dgvc in StartDGV.Columns)
            {
                ResultDGV.Columns.Add(dgvc.Clone() as DataGridViewColumn);
            }


            DataGridViewRow row = new DataGridViewRow();

            for (int i = 0; i < StartDGV.Rows.Count; i++)
            {
                row = (DataGridViewRow)StartDGV.Rows[i].Clone();
                int intColIndex = 0;
                foreach (DataGridViewCell cell in StartDGV.Rows[i].Cells)
                {
                    if (colToTranslate.IndexOf(StartDGV.Columns[cell.ColumnIndex].Name) == -1)
                    {
                        row.Cells[intColIndex].Value = cell.Value;

                    }
                    else
                    {
                        //cell.ValueType = typeof(string);
                        row.Cells[intColIndex].Value = (object)TranslateText((string)cell.FormattedValue, StartLangCB.Text, EndLangCB.Text);
                    }

                    intColIndex++;
                }
                ResultDGV.Rows.Add(row);
            }

            ResultDGV.Refresh();

        }

        private void TableNameTB_TextChanged(object sender, EventArgs e)
        {
        }

        public string TranslateText(string input, string from_lang, string to_lang)
        {
            YandexTranslator yt = new YandexTranslator();

            // если изначальный язык текста не указан, то упускаем его для запроса и яндеск сам разберется
            string lang = (from_lang == "auto") ? (to_lang) : (from_lang + "-" + to_lang);

            return yt.Translate(input, lang);
        }

        private void MakeScriptBtn_Click(object sender, EventArgs e)
        {
            // данные для всех команд
            string pk_name = PkNameTB.Text,
                table_name = TableNameTB.Text;

            // поля для обновления
            List<string> colToTranslate = ColumnsCLB.CheckedItems.OfType<string>().ToList();

            // контейнер для команд
            List<string> commands = new List<string>();

            // цыкл по всем строкам 
            foreach (DataGridViewRow row in ResultDGV.Rows)
            {
                // начало очереднйо команды
                string command = string.Format("update {0} set ", table_name);

                // собираем все поля и их новые значения
                foreach (string col_name in colToTranslate)
                {
                    // в первой итерации ставится запятая, в отличие от других
                    command += ((col_name == colToTranslate[0]) ? ("") : (",")) + string.Format(" {0} = '{1}'", col_name, row.Cells[col_name].FormattedValue);
                }

                // делаем апдат только для записи с конкретным ид
                command += string.Format(" where {0} = {1};", pk_name, row.Cells[pk_name].FormattedValue);

                commands.Add(command);
            }
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = @"D:\Script.sql";
           
            save.Filter = "Sql script | *.sql";
            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(save.FileName, commands, Encoding.GetEncoding(1251));
                System.Diagnostics.Process.Start(save.FileName);
            }
            

        }





    }
}

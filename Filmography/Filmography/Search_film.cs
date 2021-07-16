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

namespace Filmography
{
    public partial class Search_film : Form
    {
        string res1 = "";


        DataSet Save = new DataSet();
        SqlDataAdapter adapter;
        SqlConnection connection;
        SqlCommandBuilder Builder;
        SqlCommand command2;
        SqlCommand command1;
        public Search_film()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data source=DESKTOP-550GBFP\SQLEXPRESS;Initial Catalog=Filmography; Integrated Security=SSPI");
            connection.Open();

          //  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.Location = new Point(0, 0);
            this.Size = new Size(800, 600);
            comboBox1.Sorted = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            res1 = comboBox1.SelectedItem.ToString();
           // MessageBox.Show(res1);
        }

        private void button20_Click(object sender, EventArgs e)
        {//=======================================1
            if (res1== "Безумный Макс")
            {
                FIlm_info film = new FIlm_info();//START

                film.Picture2.Image = Properties.Resources.Гибсон;
                film.Picture.Image = Properties.Resources.Безумный_макс;
                film.Info = "\n«Безу́мный Макс» (иногда — «Бешеный Макс», англ. Mad Max) — австралийский дистопический боевик 1979 года \n режиссёра Джорджа Миллера с Мелом Гибсоном в главной роли.\n Ряд источников называет фильм одним из лучших произведений в жанре дизельпанк.";

                //----1 информ.о фильме
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Безумный Макс' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }

                //----------------------------------------------Инф-я Актёр
                //--------------------------------1        

                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Мел' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--*******";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH
            }
            //=====================================================2
            else if (res1== "Чего хотят женщины")
            {
                FIlm_info film = new FIlm_info();//START

                film.Picture2.Image = Properties.Resources.Гибсон;
                film.Picture.Image = Properties.Resources.Чего_хотят_женщины;
                film.Info = "\nУтром Ник обнаруживает, что может слышать мысли женщин, включая животных женского пола. Сначала он считает, что сошёл с ума, " +
                    "и пытается избавиться от своего дара. Он спешит за советом к психотерапевту, у которой однажды, десять лет назад, был с бывшей женой. " +
                    "Женщина сначала отказывается верить Нику, но после пугающей демонстрации его новых возможностей приходит в восторг и перечисляет, какие блестящие перспективы теперь открылись перед ним.";

                //----1 информ.о фильме
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Чего хотят женщины' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                //----------------------------------------------Инф-я Актёр
                //--------------------------------1        

                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Мел' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--*******";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH
            }
            //=============================================3
            else if (res1== "Грань будущего")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Круз;
                film.Picture.Image = Properties.Resources.Грань_б;
                film.Info = "\nДействие фильма происходит в недалеком будущем. Земля подверглась нападению инопланетной расы (в репортажах СМИ пришельцы обозначены как «противник»; военные дают прозвище «мимики»). " +
                    "Пришельцы успели захватить Западную и часть Центральной Европы. Армии государств объединяются, " +
                    "понимая, что иного шанса победить нет. Единственный успех в войне был одержан накануне в битве при Вердене благодаря использованию экзоскелетов.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Грань будущего' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }

                //2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Том' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH
            }
            //========================================4
            else if (res1== "Рыцарь дня")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Круз;
                film.Picture.Image = Properties.Resources.Рыцарь_дня;
                film.Info = "\n«Рыцарь дня» (англ. Knight & Day) — художественный фильм Джеймса Мэнголда в жанре комедийного боевика, вышедший 23 июня 2010 года в США и 24 июня в России. Дословный перевод названия фильма" +
                    " — «Рыцарь и день», в чём наблюдается игра слов: «night» (ночь) и «knight» (рыцарь) произносятся одинаково";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Рыцарь дня' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Том' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //========================================5
            else if (res1 == "Теряя это")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Круз;
                film.Picture.Image = Properties.Resources.Теряя_это;
                film.Info = "\nПовествование фильма «Теряя это 1983>> Герои этой молодежной комедии, " +
                    "четверо школьных друзей отправляются в злачные места Тихуаны(Мексика) в поисках приключений";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Теряя это' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }

                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Том' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //==================================================6

            else if (res1 == "Собачья жизнь")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Чарли;
                film.Picture.Image = Properties.Resources.Соб_я_жизнь;
                film.Info = "\n«Собачья жизнь» (англ. A Dog's Life) — короткометражный немой фильм Чарли Чаплина, выпущенный 14 апреля 1918 года " +
                    "и ставший первой его работой на киностудии " +
                    "«First National Pictures». Актёрский дебют в кино глухого художника-тоналиста Гренвилля Редмонда.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Собачья жизнь' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }

                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Чарли' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //====================================7
            else if (res1 == "Искатель приключений")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Чарли;
                film.Picture.Image = Properties.Resources.Искатель_приключений;
                film.Info = "\n«Искатель приключений» (англ. The Adventurer) — немой короткометражный фильм Чарли Чаплина," +
                    " выпущенный 22 октября 1917 года, и последний его фильм, снятый на киностудии «Mutual».";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Искатель приключений' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Чарли' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //====================================8
            else if (res1 == "Стажёр")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Роберт;
                film.Picture.Image = Properties.Resources.Стажёр;
                film.Info = "\nПенсионеру из Нью-Йорка Бену Уиттакеру (Роберт Де Ниро) уже семьдесят, он вдовец, семья сына живёт на другом конце страны, в Калифорнии." +
                    " В его жизни «образовалась дыра», а спокойно сидеть без дела он просто не умеет." +
                    "Вот почему, увидев на рынке листовку, Бен решает попытаться получить место стажёра в офисе интернет " +
                    "- магазина модной одежды, объявившего социальную программу привлечения пенсионеров. Благо офис этот находится здесь же, " +
                    "в Бруклине, в том самом здании бывшей типографии, где он проработал сорок лет.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Стажёр' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }

                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Роберт' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //====================================9
            else if (res1 == "Джокер")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Роберт;
                film.Picture.Image = Properties.Resources.Джокер;
                film.Info = "\nДействие фильма происходит в 1981 году в Готэме. Главным героем является отвергнутый обществом Артур Флек — неудавшийся стендап-комик, уволенный клоун-аниматор и психически нездоровый человек." +
                    " Артур в клоунском наряде убивает трёх богачей из компании миллиардера Уэйна, когда они издеваются над ним в вагоне метро. " +
                    "Это вдохновляет жителей Готэма восстать против богатых. Сам Артур из-за общества и череды провальных событий стал нигилистическим преступником и символом мятежа.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Джокер' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }


                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Роберт' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //====================================10
            else if (res1 == "Ганнибал")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Мадс;
                film.Picture.Image = Properties.Resources.Ганнибал;
                film.Info = "\nУилл Грэм — одарённый профайлер, лучший аналитик ФБР. Уникальное мышление Уилла позволяет быстро понять психологию людей, даже психопатов, " +
                    "так как Уилл прекрасно осознаёт, какие инстинкты движут ими. Но когда маньяк-убийца, которого пытается выследить Уилл, оказывается слишком умён," +
                    " Грэм обращается за помощью к известному психиатру доктору Ганнибалу Лектеру. Вместе они начинают охоту за коварным убийцей, после чего Лектер становится регулярным консультантом Уилла," +
                    " а также помогает ему справиться с психологической травмой.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Ганнибал' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }


                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Мадс' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //====================================11
            else if (res1 == "Спецподразделение")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Мадс;
                film.Picture.Image = Properties.Resources.Спецпод_ие;
                film.Info = "\nСюжет сериала Спецподразделение (2000): Unit One - это спецподразделение датской полиции для расследования особо сложных убийств. " +
                    "После того, как шеф подразделения сам становится жертвой загадочного убийства," +
                    " выбор нового руководителя падает на женщину. Согласны ли бывшие сотрудники «убойного» подчиняться Ингрид Даль?" +
                    " Достаточно ли в ней опыта, упрямства и самоиронии, чтобы создать из циничных опытных полицейских свою команду единомышленников?" +
                    " Эта задача оказывается непростой и для команды, и для самой Ингрид...";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Спецподразделение' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }

                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Мадс' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //====================================12
            else if (res1 == "Молчание ягнят")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Джоди;
                film.Picture.Image = Properties.Resources.Молчание_ягнят;
                film.Info = "\nФБР занимается расследованием серии убийств, совершённых неизвестным серийным убийцей. " +
                    "За привычку сдирать кожу с убитых им женщин его прозвали «Буффало Билл» (в честь американского деятеля и предпринимателя Буффало Билла, убивавшего бизонов). " +
                    "Не находя зацепок, ФБР решает обратиться за советом к убийце-каннибалу," +
                    " бывшему психиатру, опасному Ганнибалу Лектеру, пребывающему в изоляторе психбольницы. " +
                    "Для беседы к нему направляют молодую курсантку академии ФБР Клариссу Старлинг.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Молчание ягнят' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }

                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Джоди' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //=====================================13
            else if (res1 == "Мэверик")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Джоди;
                film.Picture.Image = Properties.Resources.Мэв;
                film.Info = "\nБрэт Мэверик — профессиональный игрок в карты — собирается на чемпионат по покеру всех рек, для участия в котором необходимо собрать 25 000 долларов, и ему не хватает всего трёх тысяч." +
                    " В ходе путешествия к выигрышу в полмиллиона долларов он планирует собрать долги со своих старых знакомых и получить необходимую сумму." +
                    " Мэверик верит, что обладает сверхъестественным даром поднять в нужный момент нужную карту.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Мэверик' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                       // film.Info += res1+"\n";
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }

                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Джоди' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //=====================================14
            else if (res1 == "Шерлок")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Бенедикт;
                film.Picture.Image = Properties.Resources.Шерлок;
                film.Info = "\nСериал представляет собой вольную адаптацию произведений Cэра Артура Конан Дойла о частном детективе Шерлоке Холмсе и его напарнике, докторе Джоне Ватсоне. Действие перенесено из XIX в XXI век;" +
                    " консультирующий детектив Шерлок Холмс, подыскивая соседа по квартире, с помощью своего товарища, знакомится с Джоном Ватсоном — военным врачом, вернувшимся из Афганистана." +
                    " Шерлок сразу впечатляет Ватсона, рассказав ему о нём самом: о том, что он служил в Афганистане, о том, что боль в его ноге — психосоматическая, и о том, что у него есть брат." +
                    " Они поселяются в доме 221 Б по Бейкер-стрит у пожилой хозяйки миссис Хадсон. Вместе Шерлок и Джон помогают Скотланд-Ярду в раскрытии сложных дел, " +
                    "используя методы наблюдения, анализа, дедукции, а также современные технологии, такие как интернет и мобильные телефоны.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Шерлок' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }

                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Бенедикт' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //=====================================15
            else if (res1 == "Доктор Стрэндж")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Бенедикт;
                film.Picture.Image = Properties.Resources.Доктор_Стрэндж;
                film.Info = "\nТяжёлые травмы рук ломают его карьеру и жизнь, и Стивен ссорится со своей коллегой и подругой Кристиной Палмер, " +
                    "которая всячески пытается ему помочь. Стрэндж находит Джонатана Пэнгборна," +
                    " которого когда-то отказался оперировать и расспрашивает его, каким образом тот сумел излечиться, будучи парализованным." +
                    " Пэнгборн рассказывает Стрэнджу об одном учителе в Камар-Тадже, куда и отправляется Стивен. " +
                    "Там на него нападают местные грабители, которые ломают его часы Jaeger-LeCoultre, но его спасает Карл Мордо и отводит в Камар-Тадж. ";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Доктор Стрэндж' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }

                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Бенедикт' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //=====================================16
            else if (res1 == "Хоббит: Нежданное путешествие")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Мартин;
                film.Picture.Image = Properties.Resources.Хоббит_Нежданное_путешествие;
                film.Info = "\n«Хо́ббит: Нежда́нное путеше́ствие» (англ. The Hobbit: An Unexpected Journey)" +
                    " — первая часть кинотрилогии режиссёра Питера Джексона, основанной на книге Дж. Р. Р. Толкина «Хоббит, или Туда и обратно»." +
                    " Приквел кинотрилогии «Властелин колец» от той же студии и с близким актёрским составом.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Хоббит: Нежданное путешествие' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }


                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Мартин' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
           //=====================================17
            else if (res1 == "Хоббит: Пустошь Смауга")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Мартин;
                film.Picture.Image = Properties.Resources.Хоббит_Пустошь_Смауга;
                film.Info = "\nТорина и его компанию преследуют Азог Осквернитель и его орки после событий предыдущего фильма. " +
                    "Гэндальф ведёт их в близлежащий дом Беорна - оборотня. Ночью Азога призывает в Дол Гулдур Некромант, приказывающий ему собрать войска для войны." +
                    " Затем Азог поручает охоту на Торина своему сыну Больгу. На следующий день Беорн сопровождает компанию к границам Лихолесья, " +
                    "где Гэндальф обнаруживает чёрное наречие, отпечатанное на старых руинах";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Хоббит: Пустошь Смауга' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }


                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Мартин' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //=====================================18
            else if (res1 == "Хоббит: Битва пяти воинств")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Мартин;
                film.Picture.Image = Properties.Resources.Хоббит_Битва_пяти_воинств;
                film.Info = "\nВ фильме повествуется о событиях, которые происходят в Королевстве Эребор после того," +
                    " как гномы разбудили спящего гигантского дракона Смауга, который летит на город Эсгарот." +
                    " Огромная армия орков под командованием Азога приближается, вскоре разразится великая битва." +
                    " В оригинальной повести Битва пяти воинств описана на нескольких страницах";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Хоббит: Битва пяти воинств' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }


                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Мартин' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //=====================================19
            else if (res1 == "Охотники за привидениями")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Сигурни;
                film.Picture.Image = Properties.Resources.Охотники_за_привидениями;
                film.Info = "\nНеожиданно Нью-Йорк и несколько соседних городов захлёстывает паранормальная активность — привидения начинают появляться повсюду. " +
                    "Охотников за привидениями вызывают в отель, где они успешно отлавливают призрака." +
                    " После этого дела охотников идут в гору, днём и ночью они выезжают на заказы и даже расширяют своё дело.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Охотники за привидениями' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }


                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Сигурни' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //=====================================20
            else if (res1 == "Чужие")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Сигурни;
                film.Picture.Image = Properties.Resources.Чужие;
                film.Info = "\nСпасательный челнок «Нарцисс» с погружённой в анабиоз Эллен Рипли сбивается с курса и попадает на замкнутую орбиту, где только спустя 57 лет её подбирает поисковая команда. " +
                    "Компания «Вэйланд-Ютани» начинает разбирательство по поводу истории Рипли о том, что причиной подрыва космического тягача «Ностромо» и гибели экипажа стал Чужой. Но, очевидно, рейс «Ностромо» тогда," +
                    " 57 лет назад, был засекречен, и нынешнее руководство компании о нём ничего не знает. ";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Чужие' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Сигурни' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //=====================================21
            else if (res1 == "Секретные материалы")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Джиллиан;
                film.Picture.Image = Properties.Resources.Секретные_материалы;
                film.Info = "\n«Секре́тные материа́лы» (англ. The X-Files) — американский научно-фантастический телесериал, созданный Крисом Картером." +
                    " Показ стартовал 10 сентября 1993 года и завершился 21 марта 2018 года. За это время были сняты 218 серий. Сериал был хитом канала Fox;" +
                    " его символика и теглайны: «The Truth Is Out There» (рус. Истина где-то рядом или рус. Истина где-то там)[2], «Trust No One» (рус. Не доверяй никому)" +
                    ", «I Want to Believe» (рус. Я хочу верить) — были особенно популярны в поп-культуре 1990-х. Являясь своеобразной вехой эпохи," +
                    " ключевые сюжетные темы «Секретных материалов» основываются на недоверии общества к правительству....";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Секретные материалы' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }

                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Джиллиан' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //==========================================22
            else if (res1 == "Трамвай «Желание»")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Джиллиан;
                film.Picture.Image = Properties.Resources.Трамвай__Желание;
                film.Info = "\nБланш Дюбуа, увядающая, но всё ещё привлекательная бывшая учительница английского языка, " +
                    "приезжает в Новый Орлеан к сестре Стелле, живущей с мужем Стэнли Ковальски в бедном промышленном районе." +
                    " Бланш осталась без работы и без средств к существованию. Хотя беременная Стелла рада появлению сестры," +
                    " Стэнли относится к Бланш настороженно, а впоследствии и враждебно.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Трамвай «Желание»' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }


                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Джиллиан' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //===============================================23
            else if (res1 == "Мост")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.София_Хелин;
                film.Picture.Image = Properties.Resources.Мост;
                film.Info = "\nНа Эресуннском мосту внезапно выключается освещение, после чего обнаруживают труп женщины, лежащий ровно на границе между Данией и Швецией." +
                    " Шведская и датская полиция совместно расследуют убийство, но в ходе расследования выясняется, " +
                    "что убийство совершено не одно — преступления начались больше года назад и продолжаются до сих пор.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Мост' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }


                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='София' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //===============================================24
            else if (res1 == "Арн: Рыцарь-тамплиер")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.София_Хелин;
                film.Picture.Image = Properties.Resources.Арн_Рыцарь_тамплиер;
                film.Info = "\n«Арн: Рыцарь-тамплиер» (швед. Arn – Tempelriddaren) — художественный фильм 2007 года," +
                    " снятый на основе произведений шведского писателя Яна Гийу о тамплиере Арне Магнуссоне «Путь в Иерусалим» (Vägen till Jerusalem, 1998)" +
                    " и «Тамплиер» (Tempelriddaren, 1999).";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Арн: Рыцарь-тамплиер' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }

                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='София' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //===============================================25
            else if (res1 == "День сурка")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Энди_Макдауэлл;
                film.Picture.Image = Properties.Resources.День_сурка;
                film.Info = "\nФил Коннорс — метеоролог на телевизионном канале PBH Питтсбурга, резонёр и циник," +
                    " давно уставший от однообразной работы и разучившийся получать от неё удовольствие. Сюжет начинается с того, " +
                    "что 1 февраля Фил в компании с новым продюсером Ритой Хансон и оператором Ларри должен отправиться в городок Панксатони (англ. Punxsutawney)," +
                    " чтобы провести репортаж с праздника «День сурка»." +
                    " Если коллеги рады посетить праздник и развеяться, то Фил, " +
                    "который уже трижды ездил в аналогичные поездки, откровенно скучает.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='День сурка' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }


                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Энди' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //===============================================26
            else if (res1 == "Вид на жительство")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Энди_Макдауэлл;
                film.Picture.Image = Properties.Resources.Вид_на_жительство;
                film.Info = "\nЭмигрант из Франции Жорж (Жерар Депардьё) и американка Бронте (Энди Макдауэлл), " +
                    "желающая сохранить квартиру, в которой расположена дорогая её сердцу теплица, решают заключить фиктивный брак." +
                    " Когда этим случаем начинают интересоваться иммиграционные службы," +
                    " Жорж и Бронте оказываются перед необходимостью поближе узнать друг друга," +
                    " чтобы как следует подготовиться к собеседованию с властями. " +
                    "Они вынуждены несколько дней провести рядом друг с другом.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Вид на жительство' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }



                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Энди' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //===============================================27
            else if (res1 == "Невезучие")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Жерар_Депардье;
                film.Picture.Image = Properties.Resources.Невезучие;
                film.Info = "\nДочь президента крупной компании Мари, с которой постоянно происходят какие-то неприятности," +
                    " отправившись отдыхать в Мексику, случайно попадает к местным бандитам и исчезает." +
                    " Поиски с помощью полиции и частного сыска не дают результатов, её отец месье Бенц безутешен." +
                    " Штатный психолог компании Мейер подсказывает ему одну невероятную идею: " +
                    "направить по следу пропавшей девушки некоего Франсуа́ Перре́на," +
                    " сотрудника компании, такого же бедолагу, как и она. Использовав историю жизни художника Эжена Делакруа," +
                    " Мейер выдвигает теорию о существовании фатально невезучих людей, " +
                    "которые могут попадать в схожие неприятные ситуации. ";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Невезучие' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }



                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Жерар' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //===============================================28
            else if (res1 == "Человек в железной маске")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Жерар_Депардье;
                film.Picture.Image = Properties.Resources.Человек_в_железной_маске;
                film.Info = "\nГлавными героями фильма являются постаревшие три мушкетёра: Атос, Портос и Арамис, а также д’Артаньян." +
                    "Францией правит жестокий и эгоистичный король Людовик XIV, который занят не столько политикой, сколько развлечениями" +
                    " и соблазнением женщин. Арамис стал священнослужителем, Портос заправляет собственным борделем, " +
                    "д’Артаньян занимает пост капитана личной гвардии короля, а уже взрослый сын Атоса, " +
                    "Рауль, готовится стать мушкетёром и хочет предложить руку и сердце своей возлюбленной Кристине. ";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Человек в железной маске' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }


                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Жерар' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //===============================================29
            else if (res1 == "Большой куш")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Брэд_Питт;
                film.Picture.Image = Properties.Resources.Большой_куш;
                film.Info = "\nВ Антверпене банда грабителей, переодетых в религиозных евреев, один из которых — Фрэнки «Четыре пальца» (Бенисио дель Торо)," +
                    " похищает из еврейской ювелирной конторы множество драгоценностей, среди которых бриллиант в 86 карат." +
                    " Фрэнки предстоит доставить это сокровище в пристёгиваемом к руке бронированном дипломате с кодовой защитой " +
                    "прикрывающему эту банду ювелиру Ави Деновицу (Дэннис Фарина) в Нью-Йорк," +
                    " транзитом через Лондон. ";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Большой куш' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }

                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Брэд' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //===============================================30
            else if (res1 == "Бойцовский клуб")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Брэд_Питт;
                film.Picture.Image = Properties.Resources.Бойцовский_клуб;
                film.Info = "\n«Бойцо́вский клуб» (англ. Fight Club) — американский кинофильм 1999 года режиссёра Дэвида Финчера по мотивам одноимённого романа Чака Паланика," +
                    " вышедшего тремя годами ранее. " +
                    "Главные роли исполняют Эдвард Нортон, Брэд Питт и Хелена Бонэм Картер. " +
                    "Нортон исполняет роль безымянного рассказчика — обезличенного обывателя," +
                    " который недоволен своей жизнью в постиндустриальном потребительском обществе «белых воротничков»." +
                    " Он создаёт подпольную организацию «Бойцовский клуб» вместе с Тайлером Дёрденом — продавцом мыла," +
                    " роль которого исполнил Брэд Питт.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Бойцовский клуб' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }

                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Брэд' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //===============================================31
            else if (res1 == "В джазе только девушки")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Мэрилин_Монро;
                film.Picture.Image = Properties.Resources.В_джазе_только_девушки;
                film.Info = "\n«В джа́зе то́лько де́вушки» (англ. Some Like It Hot — «Не́которые лю́бят погоряче́е») — музыкальная комедия режиссёра и продюсера Билли Уайлдера, одна из центральных работ режиссёра и вторая его картина, " +
                    "созданная в тандеме со сценаристом Изи Даймондом. В главных ролях снялись Тони Кёртис, Джек Леммон и Мэрилин Монро. " +
                    "Сценарий комедии был создан по мотивам французского фильма Ришара Поттье «Фанфары любви» 1935 года и его одноимённого ремейка 1951 года, снятого Куртом Хоффманом в Германии. " +
                    "В картине рассказывается о приключениях двух музыкантов, " +
                    "вынужденных скрываться в женском обличье от преследующих их гангстеров";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='В джазе только девушки' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }

                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Мэрилин' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //===============================================32
            else if (res1 == "Как выйти замуж за миллионера")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Мэрилин_Монро;
                film.Picture.Image = Properties.Resources.Как_выйти_замуж_за_миллионера;
                film.Info = "\nШатци Пейдж, Локо Демпси и Пола Дебевуаз снимают роскошный пентхаус на Саттон-Плейс в Нью-Йорке у Фредди Денмарка," +
                    " который живёт в Европе чтобы не платить налоги. Женщины планируют использовать квартиру," +
                    " чтобы привлечь богатых мужчин и выйти за них замуж.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Как выйти замуж за миллионера' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Мэрилин' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //===============================================33
            else if (res1 == "Друзья")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Дженнифер_Энистон;
                film.Picture.Image = Properties.Resources.Друзья;
                film.Info = "\nДействие сериала происходит главным образом в Манхэттене (Нью-Йорк) приблизительно в тот же временной отрезок, когда снимался и сериал, — в 1994—2004 годах." +
                    "Сериал посвящён жизни шестерых друзей: избалованной «папенькиной дочки» Рэйчел Грин(Дженнифер Энистон); чистюли - повара Моники Геллер(Кортни Кокс);" +
                    " комплексующего остряка, офисного работника Чендлера Бинга(Мэттью Перри); помешанного на сексе и еде, простоватого, ждущего «своей» роли актёра Джоуи Триббиани(Мэтт Леблан);" +
                    " разведённого палеонтолога Росса Геллера(Дэвид Швиммер); хиппующей массажистки и певицы Фиби Буффе(Лиза Кудроу).";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Друзья' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }


                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Дженнифер' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //===============================================34
            else if (res1 == "Обещать — не значит жениться")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Дженнифер_Энистон;
                film.Picture.Image = Properties.Resources.Обещать_не_значить_ж_ся;
                film.Info = "\nФильм представляет собой истории нескольких молодых людей, живущих в Балтиморе. Им от 20 до 30 лет, " +
                    "и все они хотят одного — найти любовь. Одни сходятся, другие расстаются," +
                    " третьи пытаются найти золотую середину. Все они разные, но их объединяет одно желание — быть счастливыми," +
                    " и они стараются для этого сделать всё возможное, даже если это иногда причиняет боль.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Обещать — не значит жениться' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }


                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Дженнифер' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //===============================================35
            else if (res1 == "Голубая бездна")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Люк_Бессон;
                film.Picture.Image = Properties.Resources.Голубая_бездна;
                film.Info = "\n«Голуба́я бе́здна» (фр. Le Grand Bleu, англ. The Big Blue) — первый англоязычный кинофильм французского режиссёра Люка Бессона. " +
                    "В основу фильма положены моменты из биографии пионеров фридайвинга — Жака Майоля и Энцо Майорки.";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Голубая бездна' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }


                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Люк' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //===============================================36
            else if (res1 == "Такси 2")
            {
                FIlm_info film = new FIlm_info();//START
                film.Picture2.Image = Properties.Resources.Люк_Бессон;
                film.Picture.Image = Properties.Resources.Такси_2;
                film.Info = "\n«Такси́ 2» (фр. Taxi 2) — французская комедия 2000 года," +
                    " снятая режиссёром Жераром Кравчиком по сценарию Люка Бессона." +
                    " «Такси 2» является продолжением фильма «Такси». ";
                command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name='Такси 2' ;
", connection);
                SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

                try
                {
                    string res1 = "";

                    while (sqlData1.Read())
                    {
                        res1 = "O--Информация о фильме*******";

                        for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData1.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }


                //-----------------2
                command2 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name='Люк' ;
", connection);
                SqlDataReader sqlData7 = command2.ExecuteReader(); //откр    

                try
                {
                    string res1 = "";
                    while (sqlData7.Read())
                    {
                        res1 = "O--****";

                        for (int i = 0; i < sqlData7.FieldCount; i++)//вывод данныхиз стобцов
                        {
                            res1 += "  " + sqlData7.GetValue(i) + "  ";
                        }
                        film._List.Items.Add(res1);
                    }
                    connection.Close();
                    // listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажмите кнопку Close");
                }
                finally { connection.Open(); }
                film.ShowDialog();//FINISH

            }
            //======================================
            //======================================
            //======================================================
            else
            {
                return;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

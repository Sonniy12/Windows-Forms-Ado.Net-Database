using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;
using System.Data.SqlClient;
using Filmography.Class_connect;

namespace Filmography.Class_connect
{
    class Class_filmography
    {
        public class_Connect connect { get; set; }
        DataSet Save;
        //=================================
        SqlDataAdapter adapter;
        // SqlConnection connection;
        SqlCommandBuilder Builder;

        SqlCommand command1;


        public Class_filmography()
        {
            connect = class_Connect.Get_connect(@"Data source=DESKTOP-550GBFP\SQLEXPRESS;Initial Catalog=Filmography; Integrated Security=SSPI");
            connect.Open_connect();
            Save = new DataSet();
        }

        //=========== information about film   ===========
        public void InformAboutFilm(string nameFilm, FIlm_info film, ListBox _List)
        {
            command1 = new SqlCommand(@"select Film.ID,Film.Name, Film.Genre,Film.Country_of_issue,Film.Cost_per_film_money,Film.Year_of_issue,Actors.Name,Actors.Surname from Film    Join Actors ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Film.Name=" + "'" + nameFilm + "'" + ";"
, connect.Connection);
            SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

            try
            {
                string res1 = "";

                while (sqlData1.Read())
                {
                    res1 = "O--Информация о фильме*******\t";

                    for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данных из столбцов
                    {
                        res1 += "   " + sqlData1.GetValue(i) + "  ";
                    }
                    film._List.Items.Add(res1);
                }
                connect.Close_connect();
                // listBox1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нажмите кнопку Close");
            }
            finally { connect.Open_connect(); }

        }
        //=========== output of all films whose cost is less than this film   ===========
        public void OutputFilmsWhoseCost(string nameFilm, FIlm_info film, ListBox _List)
        {
            command1 = new SqlCommand(@"select Name, Genre='Комедия', Cost_per_film_money from Film where  Film.Cost_per_film_money <
(select  Cost_per_film_money  from Film where Film.Country_of_issue='США' AND Name="
+ "'" + nameFilm + "'" + " );"
, connect.Connection);
            SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

            try
            {
                string res1 = "";

                while (sqlData1.Read())
                {
                    res1 = "Вывод всех фильмов,чья стоимость меньше фильма<<" + nameFilm + ">> **********\t";

                    for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данных из столбцов
                    {
                        res1 += "  " + sqlData1.GetValue(i) + "  ";
                    }
                    film._List.Items.Add(res1);
                }
                connect.Close_connect();
                // listBox1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нажмите кнопку Close");
            }
            finally { connect.Open_connect(); }

        }

        //==  information about the film, reintag translation into languages=======
        public void InformationReintagTranslation(string nameFilm, FIlm_info film, ListBox _List)
        {
            command1 = new SqlCommand(@"select  Film.Name,Film.Country_of_issue,Film.Year_of_issue, Rating.good_rated,Rating.bad_rated,
Countries_and_languages.Display_country,Countries_and_languages.Translated_language
from Film		
			Inner Join Rating On  Rating.fk_id_film = Film.ID
			Inner Join Countries_and_languages On Countries_and_languages.fk_id_film= Film.ID
			where Film.Name=" + "'" + nameFilm + "'" + ";", connect.Connection);
            SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

            try
            {
                string res1 = "";

                while (sqlData1.Read())
                {
                    res1 = "Инф-я о фильме,рейтинг---хор---плох,перевод на языки*******\t";

                    for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данных из столбцов
                    {
                        res1 += "  " + sqlData1.GetValue(i) + "  ";
                    }
                    film._List.Items.Add(res1);
                }
                connect.Close_connect();
                // listBox1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нажмите кнопку Close");
            }
            finally { connect.Open_connect(); }

        }

        //==  where the actor was filmed=======
        public void ActorWasFilmed(string nameActor, FIlm_info film, ListBox _List)
        {
            command1 = new SqlCommand(@"select Actors.Name,Actors.Surname, Film.Name from Actors    Join Film ON Actors.ID>0 AND Film.ID>0
 Join Actors_in_film  ON Actors.ID= Actors_in_film.fk_id_actors And Actors_in_film.fk_id_film= Film.ID
where Actors.Name=" + "'" + nameActor + "'" + "; ", connect.Connection);
            SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

            try
            {
                string res1 = "";

                while (sqlData1.Read())
                {
                    res1 = "O--Инф-я о фильме,В каких фильмах актёр снимался*******";

                    for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данных из столбцов
                    {
                        res1 += "  " + sqlData1.GetValue(i) + "  ";
                    }
                    film._List.Items.Add(res1);
                }
                connect.Close_connect();
                // listBox1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нажмите кнопку Close");
            }
            finally { connect.Open_connect(); }
        }

        //==  information about Actor==================
        public void InformationAboutActor(string nameActor, FIlm_info film, ListBox _List)
        {
            command1 = new SqlCommand(@"select* from Actors 
where Actors.Name=" + "'" + nameActor + "'" + "; "
, connect.Connection);
            SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

            try
            {
                string res1 = "";

                while (sqlData1.Read())
                {
                    res1 = "O--Имя актёра, дата рождения, где родился, дата смерти*******";

                    for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данных из столбцов
                    {
                        res1 += "  " + sqlData1.GetValue(i) + "  ";
                    }
                    film._List.Items.Add(res1);
                }
                connect.Close_connect();
                // listBox1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нажмите кнопку Close");
            }
            finally { connect.Open_connect(); }
        }

        //==Address income profession of an actor=================

        public void AddressIncomeProfession(string nameActor, FIlm_info film, ListBox _List)
        {
            command1 = new SqlCommand(@"select Actors.Name,Actors.Surname, Citizenship_address_actor.Country, Citizenship_address_actor.City,Profession.Name,Actors_progress.Actor_income,
Actors_progress.Film_studio_president,Actors_progress.Studio_name from Actors Inner Join Citizenship_address_actor On  Actors.ID=Citizenship_address_actor.fk_id_actors
			Inner Join Actors_progress On  Actors_progress.fk_id_actors=Actors.ID
			Inner Join  Actors_in_Profession On Actors_in_Profession.fk_id_actors = Actors.ID
										Inner Join Profession On Profession.ID = Actors_in_Profession.fk_id_prof
										where Actors.Name =" + "'" + nameActor + "'" + "; "
, connect.Connection);
            SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

            try
            {
                string res1 = "";

                while (sqlData1.Read())
                {
                    res1 = "O--Адрес,доход и профессия*******\t\t\t";

                    for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данных из столбцов
                    {
                        res1 += "  " + sqlData1.GetValue(i) + "  ";
                    }
                    film._List.Items.Add(res1);
                }
                connect.Close_connect();
                // listBox1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нажмите кнопку Close");
            }
            finally { connect.Open_connect(); }
        }

        //==nomination actor=================

        public void NominationActor(string nameActor, FIlm_info film, ListBox _List)
        {
            command1 = new SqlCommand(@"select Actors.Name,Actors.Surname, Actors_progress.Nomination_awards,
Actors_progress.Film_studio_president,Actors_progress.Studio_name
from Actors 
			Inner Join Actors_progress On  Actors_progress.fk_id_actors=Actors.ID
		where Actors.Name=" + "'" + nameActor + "'" + "; "
, connect.Connection);
            SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

            try
            {
                string res1 = "";

                while (sqlData1.Read())
                {
                    res1 = "Вывод наминаций актеров + президент киностудии*******\t";

                    for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данных из столбцов
                    {
                        res1 += "  " + sqlData1.GetValue(i) + "  ";
                    }
                    film._List.Items.Add(res1);
                }
                connect.Close_connect();
                // listBox1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нажмите кнопку Close");
            }
            finally { connect.Open_connect(); }
        }
        //==place of residence=================

        public void Place_of_residence(string nameActor, FIlm_info film, ListBox _List)
        {
            command1 = new SqlCommand(@"select Actors.ID, Actors.Name,Actors.Surname, Citizenship_address_actor.Country,Citizenship_address_actor.City  from Actors Inner Join Citizenship_address_actor On
Actors.ID=Citizenship_address_actor.ID And Actors.Name=" + "'" + nameActor + "'" + "; "
, connect.Connection);
            SqlDataReader sqlData1 = command1.ExecuteReader(); //откр 

            try
            {
                string res1 = "";

                while (sqlData1.Read())
                {
                    res1 = "O--Вывод места проживания*******\t\t\t";

                    for (int i = 0; i < sqlData1.FieldCount; i++)//вывод данных из столбцов
                    {
                        res1 += "  " + sqlData1.GetValue(i) + "  ";
                    }
                    film._List.Items.Add(res1);
                }
                connect.Close_connect();
                // listBox1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нажмите кнопку Close");
            }
            finally { connect.Open_connect(); }
        }


        //========methods ===================
        public void Close_Form()
        {
            connect.Close_connect();
        }

        public void Show_All_fims(DataGridView dataGridView1)
        {
            string select = @"select* from Film ";
            adapter = new SqlDataAdapter(select, connect.Connection);
            Builder = new SqlCommandBuilder(adapter);
            Save.Clear();
            adapter.Fill(Save);
            dataGridView1.DataSource = Save.Tables[0];
        }

        public void Output_films_by_cost(DataGridView dataGridView1)
        {
            string select = @"select Film.Name, Film.Cost_per_film_money from Film ;";
            adapter = new SqlDataAdapter(select, connect.Connection);
            Builder = new SqlCommandBuilder(adapter);
            Save.Clear();
            adapter.Fill(Save);
            dataGridView1.DataSource = Save.Tables[0];
        }

        //=====sorted by year=====

        public void Sorted_by_year(DataGridView dataGridView2)
        {
            string select = @"select* from Film  ORDER BY Year(Year_of_issue);";
        adapter = new SqlDataAdapter(select, connect.Connection);
        Builder = new SqlCommandBuilder(adapter);
        Save.Clear();
            adapter.Fill(Save);
            dataGridView2.DataSource = Save.Tables[0];
            }
        //======sort by name===============
        public void Sorted_byName(DataGridView dataGridView2)
        {
            string select = @" select* from Film where ID>0  ORDER BY Name ;";

            adapter = new SqlDataAdapter(select, connect.Connection);
            Builder = new SqlCommandBuilder(adapter);
            Save.Clear();
            adapter.Fill(Save);
            dataGridView2.DataSource = Save.Tables[0];
        }
        //======sort by cost===============
        public void Sorted_byCost(DataGridView dataGridView2)
        {
            string select = @" select* from Film where ID>0  ORDER BY Cost_per_film_money ;";

            adapter = new SqlDataAdapter(select, connect.Connection);
            Builder = new SqlCommandBuilder(adapter);
            Save.Clear();
            adapter.Fill(Save);
            dataGridView2.DataSource = Save.Tables[0];
        }
        //======sort by country ===============
        public void Sorted_byCountry(DataGridView dataGridView2)
        {
            string select = @" select* from Film where ID>0  ORDER BY Country_of_issue ;";

            adapter = new SqlDataAdapter(select, connect.Connection);
            Builder = new SqlCommandBuilder(adapter);
            Save.Clear();
            adapter.Fill(Save);
            dataGridView2.DataSource = Save.Tables[0];
        }
        //======sort by genre===============
        public void Sorted_byGenre(DataGridView dataGridView2)
        {
            string select = @" select* from Film where ID>0  ORDER BY Genre ;";

            adapter = new SqlDataAdapter(select, connect.Connection);
            Builder = new SqlCommandBuilder(adapter);
            Save.Clear();
            adapter.Fill(Save);
            dataGridView2.DataSource = Save.Tables[0];
        }


        /*1 presidents of film studios, 
         * 2 actors and films
         * 3 where they live,
         4 nominations, 
         5 the oldest film, 
         6 the highest rating,
         7 expensive film*/

        //1
        public void presidents(DataGridView dataGridView3)
        {
            string select = @"select Actors.Name,Actors.Surname,Profession.Name,
Actors_progress.Film_studio_president,Actors_progress.Studio_name
from Actors 
			Inner Join Actors_progress On  Actors_progress.fk_id_actors=Actors.ID
			Inner Join  Actors_in_Profession On Actors_in_Profession.fk_id_actors = Actors.ID
										Inner Join Profession On Profession.ID = Actors_in_Profession.fk_id_prof
										where  Profession.Name ='Актёр, Актриса' AND Film_studio_president='Чарльз Чаплин '
										OR Film_studio_president='Люк Бессон' ;";
            adapter = new SqlDataAdapter(select, connect.Connection);
            Builder = new SqlCommandBuilder(adapter);
            Save.Clear();
            adapter.Fill(Save);
            dataGridView3.DataSource = Save.Tables[0];
        }
        //2
        public void actors_in_films(DataGridView dataGridView3)
        {
            string select = @"select Actors.Name,Actors.Surname, Film.Name from Actors ,
Film, Actors_in_film where Actors.ID= Actors_in_film.fk_id_actors  And Actors_in_film.fk_id_film= Film.ID;";
            adapter = new SqlDataAdapter(select, connect.Connection);
            Builder = new SqlCommandBuilder(adapter);
            Save.Clear();
            adapter.Fill(Save);
            dataGridView3.DataSource = Save.Tables[0];
        }
        //3
        public void where_they_live(DataGridView dataGridView3)
        {
            string select = @"select Actors.Name,Actors.Surname, Citizenship_address_actor.Country,Citizenship_address_actor.City from Actors,
Citizenship_address_actor  where Actors.ID=Citizenship_address_actor.ID;";
            adapter = new SqlDataAdapter(select, connect.Connection);
            Builder = new SqlCommandBuilder(adapter);
            Save.Clear();
            adapter.Fill(Save);
            dataGridView3.DataSource = Save.Tables[0];
        }
        //4
        public void nominations(DataGridView dataGridView3)
        {
            string select = @"select Actors.Name,Actors.Surname, Actors_progress.Nomination_awards,
Actors_progress.Film_studio_president,Actors_progress.Studio_name
from Actors 
			Inner Join Actors_progress On  Actors_progress.fk_id_actors=Actors.ID;";
            adapter = new SqlDataAdapter(select, connect.Connection);
            Builder = new SqlCommandBuilder(adapter);
            Save.Clear();
            adapter.Fill(Save);
            dataGridView3.DataSource = Save.Tables[0];
        }

        //5
        public void oldest_film(DataGridView dataGridView3)
        {
            string select = @"select* from Film
WHERE Year_of_issue = (SELECT Min(Year_of_issue) FROM Film);";
            adapter = new SqlDataAdapter(select, connect.Connection);
            Builder = new SqlCommandBuilder(adapter);
            Save.Clear();
            adapter.Fill(Save);
            dataGridView3.DataSource = Save.Tables[0];
        }

        //6
        public void highest_rating(DataGridView dataGridView3)
        {
            string select = @"select Name, good_rated from Film,Rating where Film.ID=Rating.ID AND  good_rated = (SELECT MAX(good_rated) FROM Rating) ;";
            adapter = new SqlDataAdapter(select, connect.Connection);
            Builder = new SqlCommandBuilder(adapter);
            Save.Clear();
            adapter.Fill(Save);
            dataGridView3.DataSource = Save.Tables[0];
        }
        //7
        public void expensive_film(DataGridView dataGridView3)
        {
            string select = @"select* from Film
WHERE Cost_per_film_money = (SELECT Max(Cost_per_film_money) FROM Film);
";
            adapter = new SqlDataAdapter(select, connect.Connection);
            Builder = new SqlCommandBuilder(adapter);
            Save.Clear();
            adapter.Fill(Save);
            dataGridView3.DataSource = Save.Tables[0];
        }
    }
}

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

namespace Filmography
{
    public partial class Start_page : Form
    {
        
        DataSet Save = new DataSet();
        SqlDataAdapter adapter;
        SqlConnection connection;
        SqlCommandBuilder Builder;
        SqlCommand command;
        SqlCommand command1;
        SqlCommand command2;
        SqlCommand command3;
        SqlCommand command4;
        SqlCommand command5;
        SqlCommand command6;
        SqlCommand command7;
        SqlCommand command8;
        //========================
        Class_filmography obj;
        
        public Start_page()
        {
            InitializeComponent();
            obj = new Class_filmography();

            connection = new SqlConnection(@"Data source=DESKTOP-550GBFP\SQLEXPRESS;Initial Catalog=Filmography; Integrated Security=SSPI");
            connection.Open();

            button9.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            
            //-------------------------------
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

           this.Size=new Size( 808, 1106);
            this.Location = new Point(0, 0);
            //------------------
            FIlm_info info = new FIlm_info();
            info.Info = "";
            //-----------------------------
           

        }

      

        private void button1_Click(object sender, EventArgs e)
        {

           
            obj.Show_All_fims(dataGridView1);
           
           

        }
        private void button12_Click(object sender, EventArgs e) //Вывод фильмов по стоимости
        {
            obj.Output_films_by_cost(dataGridView1);
          

            button2.BackColor = Color.Black;
            button1.BackColor = Color.DarkCyan;
        }
      
        //----------вкладка 1

        private void button8_Click(object sender, EventArgs e)
        {
            Page_programmer home = new Page_programmer();
            home.ShowDialog();
        }

      
        private void button7_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //----------вкладка 2


        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.DarkCyan;

            obj.Sorted_by_year(dataGridView2);
         

            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button6.BackColor = Color.Black;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Black;
            button2.BackColor = Color.DarkCyan;
            obj.Sorted_byName(dataGridView2);



            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button6.BackColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
            button3.BackColor = Color.DarkCyan;
            obj.Sorted_byCost(dataGridView2);
         

            button9.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button6.BackColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Black;
            button4.BackColor = Color.DarkCyan;

            obj.Sorted_byCountry(dataGridView2);
           
            button9.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button6.BackColor = Color.Black;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
            button6.BackColor = Color.DarkCyan;
            obj.Sorted_byGenre(dataGridView2);
       

            button9.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button2.BackColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Black;
            button5.BackColor = Color.DarkCyan;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            //connection.Close();
            obj.Close_Form();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
            // connection.Close();
            obj.Close_Form();
        }

       
        private void Start_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            //connection.Close();
            obj.Close_Form();
        }

        //ДОП.Информ-ю
        private void button16_Click(object sender, EventArgs e)
        {
            obj.presidents(dataGridView3);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            obj.actors_in_films(dataGridView3);
        
        }

        private void button14_Click(object sender, EventArgs e)
        {
            obj.where_they_live(dataGridView3);
         
        }

        private void button15_Click(object sender, EventArgs e)
        {
            obj.nominations(dataGridView3);
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            obj.oldest_film(dataGridView3);


        }

        private void button18_Click(object sender, EventArgs e)
        {
            obj.highest_rating(dataGridView3);
          
        }

        private void button19_Click(object sender, EventArgs e)
        {
            obj.expensive_film(dataGridView3);
        
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private void button20_Click(object sender, EventArgs e)
        {
            Search_film search_ = new Search_film();
            search_.ShowDialog();

        }
        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        //========================================================1
        private void pictureBox71_Click(object sender, EventArgs e)
        {           
              FIlm_info film = new FIlm_info();
            
            film.Picture2.Image = Properties.Resources.Гибсон;
            film.Picture.Image = Properties.Resources.Безумный_макс;
            film.Info = "\n«Безу́мный Макс» (иногда — «Бешеный Макс», англ. Mad Max) — австралийский дистопический боевик 1979 года \n режиссёра Джорджа Миллера с Мелом Гибсоном в главной роли.\n Ряд источников называет фильм одним из лучших произведений в жанре дизельпанк.";

            obj.InformAboutFilm("Безумный Макс", film, film._List);
            film._List.Items.Add("\n\n");
            //  obj.OutputFilmsWhoseCost("Безумный Макс", film, film._List);
            // obj.InformationReintagTranslation("Безумный Макс", film, film._List);
            obj.ActorWasFilmed("Мел", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Мел", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Мел", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Мел", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Мел", film, film._List);
            film.ShowDialog();//FINISH

        }

        //==================================2
        private void pictureBox70_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Чего хотят женщины

            film.Picture2.Image = Properties.Resources.Гибсон;
            film.Picture.Image = Properties.Resources.Чего_хотят_женщины;
            film.Info = "\nУтром Ник обнаруживает, что может слышать мысли женщин, включая животных женского пола. Сначала он считает, что сошёл с ума, " +
                "и пытается избавиться от своего дара. Он спешит за советом к психотерапевту, у которой однажды, десять лет назад, был с бывшей женой. " +
                "Женщина сначала отказывается верить Нику, но после пугающей демонстрации его новых возможностей приходит в восторг и перечисляет, какие блестящие перспективы теперь открылись перед ним.";

            obj.InformAboutFilm("Чего хотят женщины", film, film._List);
            film._List.Items.Add("\n\n");
            // obj.OutputFilmsWhoseCost("Чего хотят женщины", film, film._List);
            // obj.InformationReintagTranslation("Чего хотят женщины", film, film._List);
            obj.ActorWasFilmed("Мел", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Мел", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Мел", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Мел", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Мел", film, film._List);
            film.ShowDialog();//FINISH
        }

        //==================================================3
        private void pictureBox69_Click(object sender, EventArgs e)//грань_буд. Грань будущего , Том
        {
            FIlm_info film = new FIlm_info();//START
            film.Picture2.Image= Properties.Resources.Круз;
            film.Picture.Image = Properties.Resources.Грань_б;
            film.Info = "\nДействие фильма происходит в недалеком будущем. Земля подверглась нападению инопланетной расы (в репортажах СМИ пришельцы обозначены как «противник»; военные дают прозвище «мимики»). " +
                "Пришельцы успели захватить Западную и часть Центральной Европы. Армии государств объединяются, " +
                "понимая, что иного шанса победить нет. Единственный успех в войне был одержан накануне в битве при Вердене благодаря использованию экзоскелетов.";

            obj.InformAboutFilm("Грань будущего", film, film._List);           
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Том", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Том", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Том", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Том", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Том", film, film._List);
            film.ShowDialog();//FINISH   

        }
        //=================================================4
        private void pictureBox68_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Рыцарь дня
            film.Picture2.Image = Properties.Resources.Круз;
            film.Picture.Image = Properties.Resources.Рыцарь_дня;
            film.Info = "\n«Рыцарь дня» (англ. Knight & Day) — художественный фильм Джеймса Мэнголда в жанре комедийного боевика, вышедший 23 июня 2010 года в США и 24 июня в России. Дословный перевод названия фильма" +
                " — «Рыцарь и день», в чём наблюдается игра слов: «night» (ночь) и «knight» (рыцарь) произносятся одинаково";
            obj.InformAboutFilm("Рыцарь дня", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Том", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Том", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Том", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Том", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Том", film, film._List);
            film.ShowDialog();//FINISH   

        }
        //=============================================5
        private void pictureBox67_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Теряя это
            film.Picture2.Image = Properties.Resources.Круз;
            film.Picture.Image = Properties.Resources.Теряя_это;
            film.Info = "\nПовествование фильма «Теряя это 1983>> Герои этой молодежной комедии, " +
                "четверо школьных друзей отправляются в злачные места Тихуаны(Мексика) в поисках приключений";
            obj.InformAboutFilm("Теряя это", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Том", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Том", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Том", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Том", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Том", film, film._List);
            film.ShowDialog();//FINISH   
        }
        //====================================================6

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Собачья жизнь  Чарли
            film.Picture2.Image = Properties.Resources.Чарли;
            film.Picture.Image = Properties.Resources.Соб_я_жизнь;
            film.Info = "\n«Собачья жизнь» (англ. A Dog's Life) — короткометражный немой фильм Чарли Чаплина, выпущенный 14 апреля 1918 года " +
                "и ставший первой его работой на киностудии " +
                "«First National Pictures». Актёрский дебют в кино глухого художника-тоналиста Гренвилля Редмонда.";
            obj.InformAboutFilm("Собачья жизнь", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Чарли", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Чарли", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Чарли", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Чарли", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Чарли", film, film._List);
            film.ShowDialog();//FINISH   

        }
        //============================================7
        private void pictureBox66_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Искатель приключений
            film.Picture2.Image = Properties.Resources.Чарли;
            film.Picture.Image = Properties.Resources.Искатель_приключений;
            film.Info = "\n«Искатель приключений» (англ. The Adventurer) — немой короткометражный фильм Чарли Чаплина," +
                " выпущенный 22 октября 1917 года, и последний его фильм, снятый на киностудии «Mutual».";
            obj.InformAboutFilm("Искатель приключений", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Чарли", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Чарли", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Чарли", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Чарли", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Чарли", film, film._List);
            film.ShowDialog();//FINISH  
        }
        //=============================================8
        private void pictureBox65_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START  Стажёр  Роберт
            film.Picture2.Image = Properties.Resources.Роберт;
            film.Picture.Image = Properties.Resources.Стажёр;
            film.Info = "\nПенсионеру из Нью-Йорка Бену Уиттакеру (Роберт Де Ниро) уже семьдесят, он вдовец, семья сына живёт на другом конце страны, в Калифорнии." +
                " В его жизни «образовалась дыра», а спокойно сидеть без дела он просто не умеет." +
                "Вот почему, увидев на рынке листовку, Бен решает попытаться получить место стажёра в офисе интернет " +
                "- магазина модной одежды, объявившего социальную программу привлечения пенсионеров. Благо офис этот находится здесь же, " +
                "в Бруклине, в том самом здании бывшей типографии, где он проработал сорок лет.";
            obj.InformAboutFilm("Стажёр", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Роберт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Роберт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Роберт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Роберт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Роберт", film, film._List);
            film.ShowDialog();//FINISH  

        }
        //===============================================9
        private void pictureBox64_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Джокер
            film.Picture2.Image = Properties.Resources.Роберт;
            film.Picture.Image = Properties.Resources.Джокер;
            film.Info = "\nДействие фильма происходит в 1981 году в Готэме. Главным героем является отвергнутый обществом Артур Флек — неудавшийся стендап-комик, уволенный клоун-аниматор и психически нездоровый человек." +
                " Артур в клоунском наряде убивает трёх богачей из компании миллиардера Уэйна, когда они издеваются над ним в вагоне метро. " +
                "Это вдохновляет жителей Готэма восстать против богатых. Сам Артур из-за общества и череды провальных событий стал нигилистическим преступником и символом мятежа.";
            obj.InformAboutFilm("Джокер", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Роберт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Роберт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Роберт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Роберт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Роберт", film, film._List);
            film.ShowDialog();//FINISH  
        }
        //===========================================10
        private void pictureBox63_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START  Ганнибал Мадс
            film.Picture2.Image = Properties.Resources.Мадс;
            film.Picture.Image = Properties.Resources.Ганнибал;
            film.Info = "\nУилл Грэм — одарённый профайлер, лучший аналитик ФБР. Уникальное мышление Уилла позволяет быстро понять психологию людей, даже психопатов, " +
                "так как Уилл прекрасно осознаёт, какие инстинкты движут ими. Но когда маньяк-убийца, которого пытается выследить Уилл, оказывается слишком умён," +
                " Грэм обращается за помощью к известному психиатру доктору Ганнибалу Лектеру. Вместе они начинают охоту за коварным убийцей, после чего Лектер становится регулярным консультантом Уилла," +
                " а также помогает ему справиться с психологической травмой.";

            obj.InformAboutFilm("Ганнибал", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Мадс", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Мадс", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Мадс", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Мадс", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Мадс", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //==========================================11
        private void pictureBox62_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Спецподразделение
            film.Picture2.Image = Properties.Resources.Мадс;
            film.Picture.Image = Properties.Resources.Спецпод_ие;
            film.Info = "\nСюжет сериала Спецподразделение (2000): Unit One - это спецподразделение датской полиции для расследования особо сложных убийств. " +
                "После того, как шеф подразделения сам становится жертвой загадочного убийства," +
                " выбор нового руководителя падает на женщину. Согласны ли бывшие сотрудники «убойного» подчиняться Ингрид Даль?" +
                " Достаточно ли в ней опыта, упрямства и самоиронии, чтобы создать из циничных опытных полицейских свою команду единомышленников?" +
                " Эта задача оказывается непростой и для команды, и для самой Ингрид...";
            obj.InformAboutFilm("Спецподразделение", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Мадс", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Мадс", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Мадс", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Мадс", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Мадс", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //=============================================12
        private void pictureBox61_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Молчание ягнят Джоди
            film.Picture2.Image = Properties.Resources.Джоди;
            film.Picture.Image = Properties.Resources.Молчание_ягнят;
            film.Info = "\nФБР занимается расследованием серии убийств, совершённых неизвестным серийным убийцей. " +
                "За привычку сдирать кожу с убитых им женщин его прозвали «Буффало Билл» (в честь американского деятеля и предпринимателя Буффало Билла, убивавшего бизонов). " +
                "Не находя зацепок, ФБР решает обратиться за советом к убийце-каннибалу," +
                " бывшему психиатру, опасному Ганнибалу Лектеру, пребывающему в изоляторе психбольницы. " +
                "Для беседы к нему направляют молодую курсантку академии ФБР Клариссу Старлинг.";
            obj.InformAboutFilm("Молчание ягнят", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Джоди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Джоди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Джоди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Джоди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Джоди", film, film._List);
            film.ShowDialog();//FINISH 

        }
        //===========================================13
        private void pictureBox60_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Мэверик
            film.Picture2.Image = Properties.Resources.Джоди;
            film.Picture.Image = Properties.Resources.Мэв;
            film.Info = "\nБрэт Мэверик — профессиональный игрок в карты — собирается на чемпионат по покеру всех рек, для участия в котором необходимо собрать 25 000 долларов, и ему не хватает всего трёх тысяч." +
                " В ходе путешествия к выигрышу в полмиллиона долларов он планирует собрать долги со своих старых знакомых и получить необходимую сумму." +
                " Мэверик верит, что обладает сверхъестественным даром поднять в нужный момент нужную карту.";
            obj.InformAboutFilm("Мэверик", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Джоди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Джоди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Джоди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Джоди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Джоди", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //==========================================14
        private void pictureBox59_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Шерлок  Бенедикт
            film.Picture2.Image = Properties.Resources.Бенедикт;
            film.Picture.Image = Properties.Resources.Шерлок;
            film.Info = "\nСериал представляет собой вольную адаптацию произведений Cэра Артура Конан Дойла о частном детективе Шерлоке Холмсе и его напарнике, докторе Джоне Ватсоне. Действие перенесено из XIX в XXI век;" +
                " консультирующий детектив Шерлок Холмс, подыскивая соседа по квартире, с помощью своего товарища, знакомится с Джоном Ватсоном — военным врачом, вернувшимся из Афганистана." +
                " Шерлок сразу впечатляет Ватсона, рассказав ему о нём самом: о том, что он служил в Афганистане, о том, что боль в его ноге — психосоматическая, и о том, что у него есть брат." +
                " Они поселяются в доме 221 Б по Бейкер-стрит у пожилой хозяйки миссис Хадсон. Вместе Шерлок и Джон помогают Скотланд-Ярду в раскрытии сложных дел, " +
                "используя методы наблюдения, анализа, дедукции, а также современные технологии, такие как интернет и мобильные телефоны.";
            obj.InformAboutFilm("Шерлок", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Бенедикт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Бенедикт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Бенедикт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Бенедикт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Бенедикт", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //==============================================15
        private void pictureBox58_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Доктор Стрэндж
            film.Picture2.Image = Properties.Resources.Бенедикт;
            film.Picture.Image = Properties.Resources.Доктор_Стрэндж;
            film.Info = "\nТяжёлые травмы рук ломают его карьеру и жизнь, и Стивен ссорится со своей коллегой и подругой Кристиной Палмер, " +
                "которая всячески пытается ему помочь. Стрэндж находит Джонатана Пэнгборна," +
                " которого когда-то отказался оперировать и расспрашивает его, каким образом тот сумел излечиться, будучи парализованным." +
                " Пэнгборн рассказывает Стрэнджу об одном учителе в Камар-Тадже, куда и отправляется Стивен. " +
                "Там на него нападают местные грабители, которые ломают его часы Jaeger-LeCoultre, но его спасает Карл Мордо и отводит в Камар-Тадж. ";
           
            obj.InformAboutFilm("Доктор Стрэндж", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Бенедикт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Бенедикт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Бенедикт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Бенедикт", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Бенедикт", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //=============================================16
        private void pictureBox57_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Хоббит: Нежданное путешествие  Мартин
            film.Picture2.Image = Properties.Resources.Мартин;
            film.Picture.Image = Properties.Resources.Хоббит_Нежданное_путешествие;
            film.Info = "\n«Хо́ббит: Нежда́нное путеше́ствие» (англ. The Hobbit: An Unexpected Journey)" +
                " — первая часть кинотрилогии режиссёра Питера Джексона, основанной на книге Дж. Р. Р. Толкина «Хоббит, или Туда и обратно»." +
                " Приквел кинотрилогии «Властелин колец» от той же студии и с близким актёрским составом.";
            obj.InformAboutFilm("Хоббит: Нежданное путешествие", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Мартин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Мартин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Мартин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Мартин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Мартин", film, film._List);
            film.ShowDialog();//FINISH 

        }
        //=================================17
        private void pictureBox56_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Хоббит: Пустошь Смауга  Мартин
            film.Picture2.Image = Properties.Resources.Мартин;
            film.Picture.Image = Properties.Resources.Хоббит_Пустошь_Смауга;
            film.Info = "\nТорина и его компанию преследуют Азог Осквернитель и его орки после событий предыдущего фильма. " +
                "Гэндальф ведёт их в близлежащий дом Беорна - оборотня. Ночью Азога призывает в Дол Гулдур Некромант, приказывающий ему собрать войска для войны." +
                " Затем Азог поручает охоту на Торина своему сыну Больгу. На следующий день Беорн сопровождает компанию к границам Лихолесья, " +
                "где Гэндальф обнаруживает чёрное наречие, отпечатанное на старых руинах";
            obj.InformAboutFilm("Хоббит: Хоббит: Пустошь Смауга", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Мартин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Мартин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Мартин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Мартин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Мартин", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //==========================================18
        private void pictureBox55_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START  Хоббит: Битва пяти воинств
            film.Picture2.Image = Properties.Resources.Мартин;
            film.Picture.Image = Properties.Resources.Хоббит_Битва_пяти_воинств;
            film.Info = "\nВ фильме повествуется о событиях, которые происходят в Королевстве Эребор после того," +
                " как гномы разбудили спящего гигантского дракона Смауга, который летит на город Эсгарот." +
                " Огромная армия орков под командованием Азога приближается, вскоре разразится великая битва." +
                " В оригинальной повести Битва пяти воинств описана на нескольких страницах";
            obj.InformAboutFilm("Хоббит: Битва пяти воинств", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Мартин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Мартин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Мартин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Мартин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Мартин", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //=============================================19
        private void pictureBox54_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START  Охотники за привидениями  Сигурни
            film.Picture2.Image = Properties.Resources.Сигурни;
            film.Picture.Image = Properties.Resources.Охотники_за_привидениями;
            film.Info = "\nНеожиданно Нью-Йорк и несколько соседних городов захлёстывает паранормальная активность — привидения начинают появляться повсюду. " +
                "Охотников за привидениями вызывают в отель, где они успешно отлавливают призрака." +
                " После этого дела охотников идут в гору, днём и ночью они выезжают на заказы и даже расширяют своё дело.";
            obj.InformAboutFilm("Охотники за привидениями", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Сигурни", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Сигурни", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Сигурни", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Сигурни", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Сигурни", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //========================================20
        private void pictureBox53_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START  Чужие'
            film.Picture2.Image = Properties.Resources.Сигурни;
            film.Picture.Image = Properties.Resources.Чужие;
            film.Info = "\nСпасательный челнок «Нарцисс» с погружённой в анабиоз Эллен Рипли сбивается с курса и попадает на замкнутую орбиту, где только спустя 57 лет её подбирает поисковая команда. " +
                "Компания «Вэйланд-Ютани» начинает разбирательство по поводу истории Рипли о том, что причиной подрыва космического тягача «Ностромо» и гибели экипажа стал Чужой. Но, очевидно, рейс «Ностромо» тогда," +
                " 57 лет назад, был засекречен, и нынешнее руководство компании о нём ничего не знает. ";
            obj.InformAboutFilm("Чужие", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Сигурни", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Сигурни", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Сигурни", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Сигурни", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Сигурни", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //======================================21 Секретные материалы
        private void pictureBox52_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START  Секретные материалы  Джиллиан
            film.Picture2.Image = Properties.Resources.Джиллиан;
            film.Picture.Image = Properties.Resources.Секретные_материалы;
            film.Info = "\n«Секре́тные материа́лы» (англ. The X-Files) — американский научно-фантастический телесериал, созданный Крисом Картером." +
                " Показ стартовал 10 сентября 1993 года и завершился 21 марта 2018 года. За это время были сняты 218 серий. Сериал был хитом канала Fox;" +
                " его символика и теглайны: «The Truth Is Out There» (рус. Истина где-то рядом или рус. Истина где-то там)[2], «Trust No One» (рус. Не доверяй никому)" +
                ", «I Want to Believe» (рус. Я хочу верить) — были особенно популярны в поп-культуре 1990-х. Являясь своеобразной вехой эпохи," +
                " ключевые сюжетные темы «Секретных материалов» основываются на недоверии общества к правительству....";
            obj.InformAboutFilm("Секретные материалы", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Джиллиан", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Джиллиан", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Джиллиан", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Джиллиан", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Джиллиан", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //==========================================22
        private void pictureBox51_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Трамвай «Желание»
            film.Picture2.Image = Properties.Resources.Джиллиан;
            film.Picture.Image = Properties.Resources.Трамвай__Желание;
            film.Info = "\nБланш Дюбуа, увядающая, но всё ещё привлекательная бывшая учительница английского языка, " +
                "приезжает в Новый Орлеан к сестре Стелле, живущей с мужем Стэнли Ковальски в бедном промышленном районе." +
                " Бланш осталась без работы и без средств к существованию. Хотя беременная Стелла рада появлению сестры," +
                " Стэнли относится к Бланш настороженно, а впоследствии и враждебно.";
            obj.InformAboutFilm("Трамвай «Желание»", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Джиллиан", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Джиллиан", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Джиллиан", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Джиллиан", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Джиллиан", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //=================================================23
        private void pictureBox50_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Мост  София
            film.Picture2.Image = Properties.Resources.София_Хелин;
            film.Picture.Image = Properties.Resources.Мост;
            film.Info = "\nНа Эресуннском мосту внезапно выключается освещение, после чего обнаруживают труп женщины, лежащий ровно на границе между Данией и Швецией." +
                " Шведская и датская полиция совместно расследуют убийство, но в ходе расследования выясняется, " +
                "что убийство совершено не одно — преступления начались больше года назад и продолжаются до сих пор.";
            obj.InformAboutFilm("Мост", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("София", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("София", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("София", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("София", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("София", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //=========================================24
        private void pictureBox49_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Арн: Рыцарь-тамплиер
            film.Picture2.Image = Properties.Resources.София_Хелин;
            film.Picture.Image = Properties.Resources.Арн_Рыцарь_тамплиер;
            film.Info = "\n«Арн: Рыцарь-тамплиер» (швед. Arn – Tempelriddaren) — художественный фильм 2007 года," +
                " снятый на основе произведений шведского писателя Яна Гийу о тамплиере Арне Магнуссоне «Путь в Иерусалим» (Vägen till Jerusalem, 1998)" +
                " и «Тамплиер» (Tempelriddaren, 1999).";
            obj.InformAboutFilm("Арн: Рыцарь-тамплиер", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("София", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("София", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("София", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("София", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("София", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //=============================================25
        private void pictureBox48_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START День сурка  Энди
            film.Picture2.Image = Properties.Resources.Энди_Макдауэлл;
            film.Picture.Image = Properties.Resources.День_сурка;
            film.Info = "\nФил Коннорс — метеоролог на телевизионном канале PBH Питтсбурга, резонёр и циник," +
                " давно уставший от однообразной работы и разучившийся получать от неё удовольствие. Сюжет начинается с того, " +
                "что 1 февраля Фил в компании с новым продюсером Ритой Хансон и оператором Ларри должен отправиться в городок Панксатони (англ. Punxsutawney)," +
                " чтобы провести репортаж с праздника «День сурка»." +
                " Если коллеги рады посетить праздник и развеяться, то Фил, " +
                "который уже трижды ездил в аналогичные поездки, откровенно скучает.";
            obj.InformAboutFilm("День сурка", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Энди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Энди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Энди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Энди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Энди", film, film._List);
            film.ShowDialog();//FINISH 
        }

        //+++++++++++++++++++++++++++++++++++++++++++++++++26
        private void pictureBox47_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Вид на жительство
            film.Picture2.Image = Properties.Resources.Энди_Макдауэлл;
            film.Picture.Image = Properties.Resources.Вид_на_жительство;
            film.Info = "\nЭмигрант из Франции Жорж (Жерар Депардьё) и американка Бронте (Энди Макдауэлл), " +
                "желающая сохранить квартиру, в которой расположена дорогая её сердцу теплица, решают заключить фиктивный брак." +
                " Когда этим случаем начинают интересоваться иммиграционные службы," +
                " Жорж и Бронте оказываются перед необходимостью поближе узнать друг друга," +
                " чтобы как следует подготовиться к собеседованию с властями. " +
                "Они вынуждены несколько дней провести рядом друг с другом.";
            obj.InformAboutFilm("Вид на жительство", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Энди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Энди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Энди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Энди", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Энди", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++27
        private void pictureBox46_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Невезучие  Жерар
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
            obj.InformAboutFilm("Невезучие", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Жерар", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Жерар", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Жерар", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Жерар", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Жерар", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //====================================================28
        private void pictureBox45_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START Человек в железной маске
            film.Picture2.Image = Properties.Resources.Жерар_Депардье;
            film.Picture.Image = Properties.Resources.Человек_в_железной_маске;
            film.Info = "\nГлавными героями фильма являются постаревшие три мушкетёра: Атос, Портос и Арамис, а также д’Артаньян." +
                "Францией правит жестокий и эгоистичный король Людовик XIV, который занят не столько политикой, сколько развлечениями" +
                " и соблазнением женщин. Арамис стал священнослужителем, Портос заправляет собственным борделем, " +
                "д’Артаньян занимает пост капитана личной гвардии короля, а уже взрослый сын Атоса, " +
                "Рауль, готовится стать мушкетёром и хочет предложить руку и сердце своей возлюбленной Кристине. ";
            obj.InformAboutFilm("Человек в железной маске", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Жерар", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Жерар", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Жерар", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Жерар", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Жерар", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++29
        private void pictureBox44_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START  Большой куш  Брэд
            film.Picture2.Image = Properties.Resources.Брэд_Питт;
            film.Picture.Image = Properties.Resources.Большой_куш;
            film.Info = "\nВ Антверпене банда грабителей, переодетых в религиозных евреев, один из которых — Фрэнки «Четыре пальца» (Бенисио дель Торо)," +
                " похищает из еврейской ювелирной конторы множество драгоценностей, среди которых бриллиант в 86 карат." +
                " Фрэнки предстоит доставить это сокровище в пристёгиваемом к руке бронированном дипломате с кодовой защитой " +
                "прикрывающему эту банду ювелиру Ави Деновицу (Дэннис Фарина) в Нью-Йорк," +
                " транзитом через Лондон. ";
            obj.InformAboutFilm("Большой куш", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Брэд", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Брэд", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Брэд", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Брэд", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Брэд", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //==================================================30
        private void pictureBox43_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START  Бойцовский клуб
            film.Picture2.Image = Properties.Resources.Брэд_Питт;
            film.Picture.Image = Properties.Resources.Бойцовский_клуб;
            film.Info = "\n«Бойцо́вский клуб» (англ. Fight Club) — американский кинофильм 1999 года режиссёра Дэвида Финчера по мотивам одноимённого романа Чака Паланика," +
                " вышедшего тремя годами ранее. " +
                "Главные роли исполняют Эдвард Нортон, Брэд Питт и Хелена Бонэм Картер. " +
                "Нортон исполняет роль безымянного рассказчика — обезличенного обывателя," +
                " который недоволен своей жизнью в постиндустриальном потребительском обществе «белых воротничков»." +
                " Он создаёт подпольную организацию «Бойцовский клуб» вместе с Тайлером Дёрденом — продавцом мыла," +
                " роль которого исполнил Брэд Питт.";
            obj.InformAboutFilm("Бойцовский клуб", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Брэд", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Брэд", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Брэд", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Брэд", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Брэд", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //===================================31
        private void pictureBox42_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START  В джазе только девушки  Мэрилин
            film.Picture2.Image = Properties.Resources.Мэрилин_Монро;
            film.Picture.Image = Properties.Resources.В_джазе_только_девушки;
            film.Info = "\n«В джа́зе то́лько де́вушки» (англ. Some Like It Hot — «Не́которые лю́бят погоряче́е») — музыкальная комедия режиссёра и продюсера Билли Уайлдера, одна из центральных работ режиссёра и вторая его картина, " +
                "созданная в тандеме со сценаристом Изи Даймондом. В главных ролях снялись Тони Кёртис, Джек Леммон и Мэрилин Монро. " +
                "Сценарий комедии был создан по мотивам французского фильма Ришара Поттье «Фанфары любви» 1935 года и его одноимённого ремейка 1951 года, снятого Куртом Хоффманом в Германии. " +
                "В картине рассказывается о приключениях двух музыкантов, " +
                "вынужденных скрываться в женском обличье от преследующих их гангстеров";
            obj.InformAboutFilm("В джазе только девушки", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Мэрилин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Мэрилин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Мэрилин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Мэрилин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Мэрилин", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //=========================================32
        private void pictureBox41_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START  Как выйти замуж за миллионера
            film.Picture2.Image = Properties.Resources.Мэрилин_Монро;
            film.Picture.Image = Properties.Resources.Как_выйти_замуж_за_миллионера;
            film.Info = "\nШатци Пейдж, Локо Демпси и Пола Дебевуаз снимают роскошный пентхаус на Саттон-Плейс в Нью-Йорке у Фредди Денмарка," +
                " который живёт в Европе чтобы не платить налоги. Женщины планируют использовать квартиру," +
                " чтобы привлечь богатых мужчин и выйти за них замуж.";
            obj.InformAboutFilm("Как выйти замуж за миллионера", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Мэрилин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Мэрилин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Мэрилин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Мэрилин", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Мэрилин", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //====================================33
        private void pictureBox40_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START  Друзья Дженнифер
            film.Picture2.Image = Properties.Resources.Дженнифер_Энистон;
            film.Picture.Image = Properties.Resources.Друзья;
            film.Info = "\nДействие сериала происходит главным образом в Манхэттене (Нью-Йорк) приблизительно в тот же временной отрезок, когда снимался и сериал, — в 1994—2004 годах." +
                "Сериал посвящён жизни шестерых друзей: избалованной «папенькиной дочки» Рэйчел Грин(Дженнифер Энистон); чистюли - повара Моники Геллер(Кортни Кокс);" +
                " комплексующего остряка, офисного работника Чендлера Бинга(Мэттью Перри); помешанного на сексе и еде, простоватого, ждущего «своей» роли актёра Джоуи Триббиани(Мэтт Леблан);" +
                " разведённого палеонтолога Росса Геллера(Дэвид Швиммер); хиппующей массажистки и певицы Фиби Буффе(Лиза Кудроу).";
            obj.InformAboutFilm("Друзья", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Дженнифер", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Дженнифер", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Дженнифер", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Дженнифер", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Дженнифер", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //=======================================34
        private void pictureBox39_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START  Обещать — не значит жениться
            film.Picture2.Image = Properties.Resources.Дженнифер_Энистон;
            film.Picture.Image = Properties.Resources.Обещать_не_значить_ж_ся;
            film.Info = "\nФильм представляет собой истории нескольких молодых людей, живущих в Балтиморе. Им от 20 до 30 лет, " +
                "и все они хотят одного — найти любовь. Одни сходятся, другие расстаются," +
                " третьи пытаются найти золотую середину. Все они разные, но их объединяет одно желание — быть счастливыми," +
                " и они стараются для этого сделать всё возможное, даже если это иногда причиняет боль.";
            obj.InformAboutFilm("Обещать — не значит жениться", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Дженнифер", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Дженнифер", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Дженнифер", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Дженнифер", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Дженнифер", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //=========================================35
        private void pictureBox38_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START  Голубая бездна Люк
            film.Picture2.Image = Properties.Resources.Люк_Бессон;
            film.Picture.Image = Properties.Resources.Голубая_бездна;
            film.Info = "\n«Голуба́я бе́здна» (фр. Le Grand Bleu, англ. The Big Blue) — первый англоязычный кинофильм французского режиссёра Люка Бессона. " +
                "В основу фильма положены моменты из биографии пионеров фридайвинга — Жака Майоля и Энцо Майорки.";
            obj.InformAboutFilm("Голубая бездна", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Люк", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Люк", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Люк", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Люк", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Люк", film, film._List);
            film.ShowDialog();//FINISH 
        }
        //==============================================36
        private void pictureBox37_Click(object sender, EventArgs e)
        {
            FIlm_info film = new FIlm_info();//START
            film.Picture2.Image = Properties.Resources.Люк_Бессон;
            film.Picture.Image = Properties.Resources.Такси_2;
            film.Info = "\n«Такси́ 2» (фр. Taxi 2) — французская комедия 2000 года," +
                " снятая режиссёром Жераром Кравчиком по сценарию Люка Бессона." +
                " «Такси 2» является продолжением фильма «Такси». ";
            obj.InformAboutFilm("Такси 2", film, film._List);
            film._List.Items.Add("\n\n");
            obj.ActorWasFilmed("Люк", film, film._List);
            film._List.Items.Add("\n\n");
            obj.InformationAboutActor("Люк", film, film._List);
            film._List.Items.Add("\n\n");
            obj.AddressIncomeProfession("Люк", film, film._List);
            film._List.Items.Add("\n\n");
            obj.NominationActor("Люк", film, film._List);
            film._List.Items.Add("\n\n");
            obj.Place_of_residence("Люк", film, film._List);
            film.ShowDialog();//FINISH 

        }
      
        //------------------------------------------
    }
}

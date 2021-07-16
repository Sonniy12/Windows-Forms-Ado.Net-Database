namespace Filmography
{
    partial class Search_film
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_film));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Безумный Макс",
            "Чего хотят женщины",
            "Грань будущего",
            "Рыцарь дня",
            "Теряя это",
            "Собачья жизнь",
            "Искатель приключений",
            "Стажёр",
            "Джокер",
            "Ганнибал",
            "Спецподразделение",
            "Молчание ягнят",
            "Мэверик",
            "Шерлок",
            "Доктор Стрэндж",
            "Хоббит: Нежданное путешествие",
            "Хоббит: Пустошь Смауга",
            "Хоббит: Битва пяти воинств",
            "Охотники за привидениями",
            "Чужие",
            "Секретные материалы",
            "Трамвай «Желание»",
            "Мост",
            "Арн: Рыцарь-тамплиер",
            "День сурка",
            "Вид на жительство",
            "Невезучие",
            "Человек в железной маске",
            "Большой куш",
            "Бойцовский клуб",
            "В джазе только девушки",
            "Как выйти замуж за миллионера",
            "Друзья",
            "Обещать — не значит жениться",
            "Голубая бездна",
            "Такси 2"});
            this.comboBox1.Location = new System.Drawing.Point(43, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(696, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Teal;
            this.button20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button20.Location = new System.Drawing.Point(43, 255);
            this.button20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(696, 58);
            this.button20.TabIndex = 8;
            this.button20.Text = "Поиск";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Teal;
            this.button21.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button21.Location = new System.Drawing.Point(582, 513);
            this.button21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(157, 58);
            this.button21.TabIndex = 9;
            this.button21.Text = "Close";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // Search_film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(954, 636);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search_film";
            this.Text = "Search_film";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
    }
}
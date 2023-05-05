using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
/*Создайте приложение размером до 720х480 пикселов и разместите
на главной форме необходимые элементы управления для получения
информации:
■ Фамилия
■ Имя
■ Отчество
■ Пол
■ Год и дата рождения
■ Семейный статус
■ Дополнительная информация
Добавьте кнопку Save и обработчик нажатия кнопки для сохранения информации из элементов управления в файл.
Добавьте кнопку Load и обработчик нажатия кнопки для
восстановления информации из файла в элементы управления.*/
namespace HW_WF_Module_2
{






    public partial class Form1 : Form
    {
        HumanBase humanBase = new HumanBase();
        Human humanTemp = new Human();

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Width = 480;
            this.Height = 720;
            if (humanBase.humans.Count == 0)
            {
                humanBase.AddHuman(new Human
                {
                    Name = "Sergii",
                    FatherName = "Mihajlovich",
                    maritalStatus = MaritalStatus.eternal_child,
                    sex = Sex.male,
                    Surname = "Matviichuk",
                    OtherInfo = "После 5-й кружки чая сыпятся глаза",
                    BirthDate = new DateTime(1994, 5, 15)
                });

                humanBase.AddHuman(new Human
                {
                    Name = "Pavlo",
                    FatherName = "Pavlovich",
                    maritalStatus = MaritalStatus.married,
                    sex = Sex.male,
                    Surname = "Pavlenko",
                    OtherInfo = "После 3-й кружки пива вспоминаю анекдот",
                    BirthDate = new DateTime(1987, 2, 19)
                });
            }



            foreach (var item in humanBase.humans)
                comboBoxHumans.Items.Add(item.Name);

            comboBoxSex.DataSource = Enum.GetValues(typeof(Sex));
            comboBoxFamilyStatus.DataSource = Enum.GetValues(typeof(MaritalStatus));



        }

        private void comboBoxHumans_SelectedIndexChanged(object sender, EventArgs e)
            => InfoLabel.Text = humanBase.humans[comboBoxHumans.SelectedIndex].ToString();


        private void textBoxName_TextChanged(object sender, EventArgs e)
            => humanTemp.Name = textBoxName.Text;

        private void textBoxSurName_TextChanged(object sender, EventArgs e)
            => humanTemp.Surname = textBoxSurName.Text;


        private void textBoxFatherName_TextChanged(object sender, EventArgs e)
            => humanTemp.FatherName = textBoxFatherName.Text;


        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
            => humanTemp.sex = (Sex)comboBoxSex.SelectedIndex;


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            => humanTemp.BirthDate = dateTimePicker1.Value;


        private void comboBoxFamilyStatus_SelectedIndexChanged(object sender, EventArgs e)
            => humanTemp.maritalStatus = (MaritalStatus)comboBoxFamilyStatus.SelectedValue;


        private void textBoxOtherInfo_TextChanged(object sender, EventArgs e)
            => humanTemp.OtherInfo = textBoxOtherInfo.Text;

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxHumans.Items.Add(humanTemp.Name);
            humanBase.AddHuman(humanTemp);
            humanTemp = new Human();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            Saver saver = new Saver();
            if (textBox1.Text.Length > 4)
                saver.SaveToFile(humanBase, textBox1.Text);
            else
            {
                saver.SaveToFile(humanBase, "humanBase.xml");
                MessageBox.Show("very short name, saved to \'humanBase.xml\'");
            }


        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Saver saver = new Saver();
            if (textBox2.Text.Length > 4)
                saver.DownloadFromFile(ref humanBase, textBox2.Text);
            else
            {
                saver.DownloadFromFile(ref humanBase, "humanBase.xml");
                MessageBox.Show("very short name, load from \'humanBase.xml\'");
            }
            comboBoxHumans.Items.Clear();
            foreach (var item in humanBase.humans)
                comboBoxHumans.Items.Add(item.Name);


        }







        #region
        [Serializable]
        public enum MaritalStatus
        {
            single,
            married,
            divorced,
            widower,
            eternal_child

        }
        [Serializable]
        public enum Sex
        {
            male,
            female
        }
        [Serializable]
        public class HumanBase
        {
            Human human;
            public List<Human> humans = new List<Human>();

            public HumanBase(Human human)
            {
                if (humans.Count == 0) { humans = new List<Human>(); }
                this.human = human;
            }
            public HumanBase()
            {

            }
            public HumanBase(List<Human> humans)
            {
                this.humans = humans;
            }

            public void CreateHuman() => human = new Human();
            public void AddHuman(Human human) => humans.Add(human);

        }
        [Serializable]
        public class Human
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string FatherName { get; set; }
            public Sex sex { get; set; }
            public DateTime BirthDate { get; set; }
            public MaritalStatus maritalStatus { get; set; }
            public string OtherInfo { get; set; }

            public Human()
            {

            }
            public override string ToString()
            {
                return Name + "\n" + Surname + "\n" + FatherName + "\n" + sex + "\n" + OtherInfo +
                    "\n" + maritalStatus + "\n" + BirthDate.ToShortDateString();
            }


        }



        public class Saver
        {
            public void SaveToFile(HumanBase obj, string path)
            {

                FileStream stream = new FileStream(path, FileMode.Create);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Human>));
                xmlSerializer.Serialize(stream, obj.humans);
                MessageBox.Show("Saving was OK");

            }
            public void DownloadFromFile(ref HumanBase obj, string path)
            {

                FileStream stream = new FileStream(path, FileMode.Open);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Human>));
                obj = new HumanBase((List<Human>)xmlSerializer.Deserialize(stream));
                MessageBox.Show("Downloading  was OK");
            }


        }


        #endregion


    }
}


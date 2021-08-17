using System;
using System.Drawing;
using System.Windows.Forms;

namespace EHkspertnayaSistema
{
    public partial class Form1 : Form
    {
        byte NachalnoeSostoyanie = 0;
        byte TekushcheeSostoyanie = 0;
        byte KonecPoiska = 0;
        Font fnt = new Font("Times New Roman", 14);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PostroitTablicuPerekhodov();
            PostroitTablicuVoprosOtvet();
            Reshit();
        }
        private void PostroitTablicuPerekhodov()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dataGridView1.Columns[0].Name = "Начальное состояние";
            dataGridView1.Columns[0].Width = 170;
            dataGridView1.Columns[1].Name = "Конечное состояние";
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[2].Name = "Конец поиска";
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Name = "Ответ пользователя";
            string[] row1 = new string[] { "0", "1", "0", "Хочу найти работу" };
            string[] row2 = new string[] { "0", "2", "0", "Для саморазвития" };
            string[] row3 = new string[] { "1", "3", "0", "В компании" };
            string[] row4 = new string[] { "1", "11", "0", "Стартап" };
            string[] row5 = new string[] { "2", "4", "0", "Высокоуровневый" };
            string[] row6 = new string[] { "2", "5", "0", "«Железо»" };
            string[] row7 = new string[] { "3", "6", "1", "Google" };
            string[] row8 = new string[] { "3", "7", "1", "Windows" };
            string[] row9 = new string[] { "3", "8", "1", "Apple" };
            string[] row10 = new string[] { "4", "9", "1", "Объекты" };
            string[] row11 = new string[] { "4", "10", "1", "Функции" };
            string[] row12 = new string[] { "5", "12", "1", "Максимальные возможности" };
            string[] row13 = new string[] { "5", "13", "1", "Более понятный язык" };
            string[] row14 = new string[] { "11", "14", "0", "Мобильные приложения" };
            string[] row15 = new string[] { "11", "15", "0", "Web" };
            string[] row16 = new string[] { "14", "16", "1", "iOS" };
            string[] row17 = new string[] { "14", "17", "1", "Android" };
            string[] row18 = new string[] { "15", "18", "0", "Интерактивен" };
            string[] row19 = new string[] { "15", "19", "1", "Контент" };
            string[] row20 = new string[] { "18", "20", "1", "Новая технология" };
            string[] row21 = new string[] { "18", "21", "1", "Проверенный инструмент" };
            object[] rows = new object[] { row1, row2, row3, row4, row5, row6, row7, row8, row9, row10, row11,
                row12,row13, row14, row15, row16, row17, row18, row19, row20, row21};
            foreach (string[] rowArray in rows)
            {
                dataGridView1.Rows.Add(rowArray);
            }
        }
        private void PostroitTablicuVoprosOtvet()
        {
            dataGridView2.ColumnCount = 2;
            dataGridView2.Columns[0].Width = 50;
            string[] row1 = new string[] { "0", "Для чего вы хотите изучать программирование?" };
            string[] row2 = new string[] { "1", "Работа в компании, или свой стартап?" };
            string[] row3 = new string[] { "2", "Высокоуровневый или на уровне «железа»?" };
            string[] row4 = new string[] { "3", "В какой компании вы хотите работать?" };
            string[] row5 = new string[] { "6", "Вам подойдёт язык программирования Python." };
            string[] row6 = new string[] { "7", "Вам подойдёт язык программирования С#." };
            string[] row7 = new string[] { "8", "Вам подойдёт язык программирования Objective-C." };
            string[] row8 = new string[] { "11", "Мобильные приложения или web?" };
            string[] row9 = new string[] { "14", "Какая ОС?"};
            string[] row10 = new string[] { "16", "Вам подойдёт язык программирования Objective-C." };
            string[] row11 = new string[] { "17", "Вам подойдёт язык программирования Java." };
            string[] row12 = new string[] { "15", "Контент или интерактив?" };
            string[] row13 = new string[] { "18", "Проверенный инструмент или новая техенология?" };
            string[] row14 = new string[] { "20", "Вам подойдёт язык программирования Node.js." };
            string[] row15 = new string[] { "21", "Вам подойдёт язык программирования Ruby." };
            string[] row16 = new string[] { "19", "Вам подойдёт язык программирования Django." };
            string[] row17 = new string[] { "4", "Объекты или функции?" };
            string[] row18 = new string[] { "9", "Вам подойдёт язык программирования Smalltalk." };
            string[] row19 = new string[] { "10", "Вам подойдёт язык программирования Lisp." };
            string[] row20 = new string[] { "5", "Что для вас приоритетней максимальные возможности или болей понятный язык?" };
            string[] row21 = new string[] { "12", " Вам подойдёт язык программирования Assembler" };
            string[] row22 = new string[] { "13", "Вам подойдёт язык программирования С." };
            object[] rows = new object[] { row1, row2, row3, row4, row5, row6, row7, row8, row9, row10, row11,
                row12,row13, row14, row15, row16, row17, row18, row19, row20, row21, row22};
            foreach (string[] rowArray in rows)
            {
                dataGridView2.Rows.Add(rowArray);
            }
        }
        private void Reshit()
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (TekushcheeSostoyanie == Convert.ToByte(dataGridView2[0, i].Value))
                {
                    ZadatVopros(dataGridView2[1, i].FormattedValue.ToString());
                    break;
                }
            }
            if(KonecPoiska == 0)
            {
                Otvety();
            }
            else
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
            }
        }
        private void ZadatVopros(string text)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            StringFormat sf = new StringFormat();
            Rectangle r = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            g.DrawString(text, fnt, Brushes.Black, r, sf);
            pictureBox1.Image = bmp;
        }
        private void Otvety()
        {
            if(NachalnoeSostoyanie == 0)
            {
                radioButton1.Text = dataGridView1[3, 0].FormattedValue.ToString();
                radioButton2.Text = dataGridView1[3, 1].FormattedValue.ToString();
                radioButton3.Visible = false;
            }
            else if(NachalnoeSostoyanie == 1)
            {
                radioButton1.Text = dataGridView1[3, 2].FormattedValue.ToString();
                radioButton2.Text = dataGridView1[3, 3].FormattedValue.ToString();
                radioButton3.Visible = false;
            }
            else if(NachalnoeSostoyanie == 2)
            {
                radioButton1.Text = dataGridView1[3, 4].FormattedValue.ToString();
                radioButton2.Text = dataGridView1[3, 5].FormattedValue.ToString();
                radioButton3.Visible = false;
            }
            else if(NachalnoeSostoyanie == 3)
            {
                radioButton1.Text = dataGridView1[3, 6].FormattedValue.ToString();
                radioButton2.Text = dataGridView1[3, 7].FormattedValue.ToString();
                radioButton3.Visible = true;
                radioButton3.Text = dataGridView1[3, 8].FormattedValue.ToString();
            }
            else if(NachalnoeSostoyanie == 4)
            {
                radioButton1.Text = dataGridView1[3, 9].FormattedValue.ToString();
                radioButton2.Text = dataGridView1[3, 10].FormattedValue.ToString();
                radioButton3.Visible = false;
            }
            else if (NachalnoeSostoyanie == 5)
            {
                radioButton1.Text = dataGridView1[3, 11].FormattedValue.ToString();
                radioButton2.Text = dataGridView1[3, 12].FormattedValue.ToString();
                radioButton3.Visible = false;
            }
            else if (NachalnoeSostoyanie == 11)
            {
                radioButton1.Text = dataGridView1[3, 13].FormattedValue.ToString();
                radioButton2.Text = dataGridView1[3, 14].FormattedValue.ToString();
                radioButton3.Visible = false;
            }
            else if (NachalnoeSostoyanie == 14)
            {
                radioButton1.Text = dataGridView1[3, 15].FormattedValue.ToString();
                radioButton2.Text = dataGridView1[3, 16].FormattedValue.ToString();
                radioButton3.Visible = false;
            }
            else if (NachalnoeSostoyanie == 15)
            {
                radioButton1.Text = dataGridView1[3, 17].FormattedValue.ToString();
                radioButton2.Text = dataGridView1[3, 18].FormattedValue.ToString();
                radioButton3.Visible = false;
            }
            else if (NachalnoeSostoyanie == 18)
            {
                radioButton1.Text = dataGridView1[3, 19].FormattedValue.ToString();
                radioButton2.Text = dataGridView1[3, 20].FormattedValue.ToString();
                radioButton3.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Perejti(radioButton1.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Perejti(radioButton2.Text);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Perejti(radioButton3.Text);
        }
        private void Perejti(string otvet)
        {
            
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                if (TekushcheeSostoyanie == Convert.ToByte(dataGridView1[0, i].Value))
                {
                    if(otvet == dataGridView1[3, i].Value.ToString())
                    {
                        TekushcheeSostoyanie = Convert.ToByte(dataGridView1[1, i].Value);
                        NachalnoeSostoyanie = Convert.ToByte(dataGridView1[1, i].Value);
                        KonecPoiska = Convert.ToByte(dataGridView1[2, i].Value);
                        Reshit();
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NachalnoeSostoyanie = 0;
            TekushcheeSostoyanie = 0;
            KonecPoiska = 0;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            Reshit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

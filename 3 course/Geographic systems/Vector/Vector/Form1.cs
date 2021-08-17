using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector
{
    public partial class Form1 : Form
    {

        public int x_MouseDown_1, y_MouseDown_1, x_MouseDown_2, y_MouseDown_2; //дом
        public int x_MouseDown_11, y_MouseDown_11, x_MouseDown_22, y_MouseDown_22;//дорога 
        bool OffOn = false; //переключатель условия
        int K1 = 0;
        int K2 = 0;
        public Form1()
        {
            InitializeComponent();

            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.MyBase". При необходимости она может быть перемещена или удалена.
            //this.myBaseTableAdapter.Fill(this.myBaseDataSet.MyBase);

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //Открытие файла
            using (OpenFileDialog ofd = new OpenFileDialog()) 
            {
                ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                ofd.RestoreDirectory = true;
                try
                {
                    
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        
                        pictureBox1.Image = Image.FromFile(ofd.FileName);


                    }

                }

                catch
                {
                    MessageBox.Show("Выберити тип jpeg");
                }

            }
        }
                
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(BackColor);
            K1 = 0;
            K2 = 0;
        }
                
        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
           
            var Type = comboBox1.Text;
            var location = e.Location;
            int X = location.X;
            int Y = location.Y;
            Graphics g = pictureBox1.CreateGraphics();
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Выбери Тип");
            }
            if (comboBox1.SelectedIndex == 0)
            {
                //dataGridView1.Rows.Add(Type, X, Y);
                K1++;//высчитывает количество нажатий
                Pen myPen = new Pen(Color.Red, 3);
                x_MouseDown_2 = e.X;
                y_MouseDown_2 = e.Y;
                if (OffOn == false)
                {
                    x_MouseDown_1 = x_MouseDown_2;
                    y_MouseDown_1 = y_MouseDown_2;
                    OffOn = true;
                }
                else
                {
                    g.DrawLine(myPen, x_MouseDown_1, y_MouseDown_1, x_MouseDown_2, y_MouseDown_2);
                    x_MouseDown_1 = x_MouseDown_2;
                    y_MouseDown_1 = y_MouseDown_2;
                    if (K1 == 5)// если нажатий 5 то прекращаем рисовать и сбрасываем счетчик нажатий
                    {
                        OffOn = false; K1 = 0;
                    }
                    else
                    {

                    }                    
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
               //dataGridView1.Rows.Add(Type, X, Y);
                K2++;//высчитывает количество нажатий
                Pen myPen = new Pen(Color.Blue, 3);
                x_MouseDown_22 = e.X;
                y_MouseDown_22 = e.Y;
                if (OffOn == false)
                {
                    x_MouseDown_11 = x_MouseDown_22;
                    y_MouseDown_11 = y_MouseDown_22;
                    OffOn = true;
                }
                else
                {
                    g.DrawLine(myPen, x_MouseDown_11, y_MouseDown_11, x_MouseDown_22, y_MouseDown_22);
                    x_MouseDown_11 = x_MouseDown_22;
                    y_MouseDown_11 = y_MouseDown_22;
                    if (K2 == 5)// если нажатий 5 то прекращаем рисовать и сбрасываем счетчик нажатий
                    {
                        OffOn = false; K2 = 0;
                    }
                    else
                    {

                    }
                }
            }
        }
        
         
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            K1 = 0;
            K2 = 0;
        }
    }
}

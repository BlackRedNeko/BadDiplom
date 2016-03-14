using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nonograms
{
    public partial class form_Game : Form
    {
        public form_Game()
        {
            InitializeComponent();
        }

        // Создание переменных, который будут в дальнейшем использоваться в алгоритмах на этой форме
        string str_Cross_Name;
        int int_NumOfRow = 0;
        int int_Width, int_Height, int_Up, int_Left;
        int int_Cell = 21, int_Top_Border = 0, int_Left_Border = 0;
        int[,] array_int_New_Game = new int[20, 20];
        int[,] array_int_Answer = new int[20, 20];
        int[,] array_int_Up = new int[20, 10];
        int[,] array_int_Left = new int[10, 20];
        bool bool_Win = false;


        // Присвоение важным переменным значения и создание игрового поля
        private void form_Game_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nDBDataSet.jc". При необходимости она может быть перемещена или удалена.
            this.jcTableAdapter.Fill(this.nDBDataSet.jc);

            int_NumOfRow = Convert.ToInt32(lbl_Help.Text);
            str_Cross_Name = dataGridView1[0, int_NumOfRow].Value.ToString();
            lbl_Cross_Name.Text = str_Cross_Name;
            int_Width = Convert.ToInt32(dataGridView1[1, int_NumOfRow].Value.ToString());
            int_Height = Convert.ToInt32(dataGridView1[2, int_NumOfRow].Value.ToString());
            int_Up = Convert.ToInt32(dataGridView1[3, int_NumOfRow].Value.ToString());
            int_Left = Convert.ToInt32(dataGridView1[4, int_NumOfRow].Value.ToString());
            int int_pn = 0, int_Right_Wall = 0;

            pb_Load.Value = 0;
            pb_Load.Maximum = int_Width * int_Height + int_Width * int_Up + int_Height * int_Left;

            Label[,] lbl_Up = new Label[int_Width, int_Up];
            Label[,] lbl_Left = new Label[int_Left, int_Height];
            Label[,] lbl_Cell = new Label[int_Width, int_Height];

            string str_Top_Nums = System.IO.File.ReadAllText(@Application.StartupPath + "\\..\\..\\jcUpNum\\" + dataGridView1[0, int_NumOfRow].Value.ToString() + ".txt");
            string str_Left_Nums = System.IO.File.ReadAllText(@Application.StartupPath + "\\..\\..\\jcLeftNum\\" + dataGridView1[0, int_NumOfRow].Value.ToString() + ".txt");
            string str_Answer = System.IO.File.ReadAllText(@Application.StartupPath + "\\..\\..\\jcAnswers\\" + dataGridView1[0, int_NumOfRow].Value.ToString() + ".txt");

            Label lbl_Zero = new Label();
            lbl_Zero = new Label();
            lbl_Zero.Name = "Zero";
            lbl_Zero.AutoSize = false;
            lbl_Zero.Width = (int_Left * (int_Cell - 1)) + 1;
            lbl_Zero.Height = (int_Up * (int_Cell - 1)) + 1;
            lbl_Zero.BackColor = Color.White;
            lbl_Zero.BorderStyle = BorderStyle.FixedSingle;
            lbl_Zero.Location = new Point(20, 20 + 50);
            Controls.Add(lbl_Zero);
            
            

            int_Top_Border = 0;
            for (int i = 0; i < int_Width; i++)
            {
                if ((i % 5 == 0) && (i > 4)) { int_Top_Border++; }
                for (int j = 0; j < int_Up; j++)
                {
                    array_int_Up[i, j] = 2;
                    lbl_Up[i, j] = new Label();
                    lbl_Up[i, j].Name = "u" + ((i + 1) * 100 + (j + 1)).ToString();
                    lbl_Up[i, j].AutoSize = false;
                    lbl_Up[i, j].Width = 21;
                    lbl_Up[i, j].Height = 21;
                    lbl_Up[i, j].BackColor = Color.LightGray;
                    lbl_Up[i, j].BorderStyle = BorderStyle.FixedSingle;
                    lbl_Up[i, j].Location = new Point((i + 1) * 20 + (int_Left * (int_Cell - 1)) + int_Top_Border + 1, (j + 1) * 20 + 50);
                    lbl_Up[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    string str_Up_Cell_Num = "";

                    if (str_Top_Nums.Remove(1, str_Top_Nums.Length - 1) == "X")
                    {
                        lbl_Up[i, j].Text = "";
                        str_Top_Nums = str_Top_Nums.Remove(0, 1);
                    }
                    else
                    {
                        for (int q = 0; q < 2; q++)
                        {
                            if ((str_Top_Nums.Remove(1, str_Top_Nums.Length - 1) == "v"))
                            {
                                q = 3;
                                str_Top_Nums = str_Top_Nums.Remove(0, 1);
                            }
                            else
                            {
                                str_Up_Cell_Num += str_Top_Nums.Remove(1, str_Top_Nums.Length - 1);
                                str_Top_Nums = str_Top_Nums.Remove(0, 1);
                            }
                        }
                        lbl_Up[i, j].Text = str_Up_Cell_Num;
                        str_Up_Cell_Num = "";
                        array_int_Up[i, j] = 0;
                        lbl_Up[i, j].Click += new EventHandler(lbl_UpClick);
                    }

                    Controls.Add(lbl_Up[i, j]);
                    pb_Load.Value++;
                    int_Right_Wall = (((i + 1) * 20 + (int_Left * (int_Cell - 1)) + int_Top_Border + 21) + (((i + 1) * 20 + (int_Left * (int_Cell - 1)) + int_Top_Border + 21) / 8));
                }
            }

            int_Left_Border = 0;
            for (int i = 0; i < int_Height; i++)
            {
                if ((i % 5 == 0) && (i > 4)) { int_Left_Border++; }
                for (int j = 0; j < int_Left; j++)
                {
                    array_int_Left[j, i] = 2;
                    lbl_Left[j, i] = new Label();
                    lbl_Left[j, i].Name = "l" + ((j + 1) * 100 + (i + 1)).ToString();
                    lbl_Left[j, i].AutoSize = false;
                    lbl_Left[j, i].Width = 21;
                    lbl_Left[j, i].Height = 21;
                    lbl_Left[j, i].BackColor = Color.LightGray;
                    lbl_Left[j, i].BorderStyle = BorderStyle.FixedSingle;
                    lbl_Left[j, i].Location = new Point((j + 1) * 20, (i + 1) * 20 + (int_Up * (int_Cell - 1)) + int_Left_Border + 1 + 50);
                    lbl_Left[j, i].TextAlign = ContentAlignment.MiddleCenter;
                    string str_Left_Cell_Num = "";

                    if (str_Left_Nums.Remove(1, str_Left_Nums.Length - 1) == "X")
                    {
                        lbl_Left[j, i].Text = "";
                        str_Left_Nums = str_Left_Nums.Remove(0, 1);
                    }
                    else
                    {
                        for (int q = 0; q < 2; q++)
                        {
                            if ((str_Left_Nums.Remove(1, str_Left_Nums.Length - 1) == "v"))
                            {
                                q = 3;
                                str_Left_Nums = str_Left_Nums.Remove(0, 1);
                            }
                            else
                            {
                                str_Left_Cell_Num += str_Left_Nums.Remove(1, str_Left_Nums.Length - 1);
                                str_Left_Nums = str_Left_Nums.Remove(0, 1);
                            }
                        }
                        lbl_Left[j, i].Text = str_Left_Cell_Num;
                        str_Left_Cell_Num = "";
                        array_int_Left[j, i] = 0;
                        lbl_Left[j, i].Click += new EventHandler(lbl_LeftClick);
                    }

                    Controls.Add(lbl_Left[j, i]);
                    pb_Load.Value++;
                    int_pn = ((i + 1) * 20 + (int_Up * (int_Cell - 1)) + int_Left_Border + 1 + 50);

                }
                
            }
            
            int_Left_Border = 0;
            for (int j = 0; j < int_Height; j++)
            {
                int_Top_Border = 0;
                if ((j % 5 == 0) && (j > 4)) { int_Left_Border++; }
                for (int i = 0; i < int_Width; i++)
                {
                    array_int_New_Game[j, i] = 0;
                    lbl_Cell[i, j] = new Label();
                    lbl_Cell[i, j].Name = ((j + 1) * 100 + (i + 1)).ToString();
                    lbl_Cell[i, j].AutoSize = false;
                    lbl_Cell[i, j].Width = 21;
                    lbl_Cell[i, j].Height = 21;
                    lbl_Cell[i, j].BackColor = Color.White;
                    lbl_Cell[i, j].BorderStyle = BorderStyle.FixedSingle;
                    lbl_Cell[i, j].Click += new EventHandler(lbl_CellClick);
                    if ((i % 5 == 0) && (i > 4)) { int_Top_Border++; }
                    lbl_Cell[i, j].Location = new Point((i + 1) * 20 + (int_Left * (int_Cell - 1)) + int_Top_Border + 1, (j + 1) * 20 + (int_Up * (int_Cell - 1)) + int_Left_Border + 1 + 50);
                    lbl_Cell[i, j].Font = new Font(lbl_Cell[i, j].Font.Name, 12, lbl_Cell[i, j].Font.Style);
                    Controls.Add(lbl_Cell[i, j]);
                    pb_Load.Value++;

                    array_int_Answer[i, j] = Convert.ToInt16(str_Answer.Remove(1, str_Answer.Length - 1));
                    str_Answer = str_Answer.Remove(0, 1);
                }
            }

            pn_Menu.Location = new Point(20, int_pn + int_Cell + 20);

            pn_Start.Size = new Size(5, 5);
            pn_Start.Visible = false;
        }

        // Проверка правельности решения
        private void btn_Check_Cross_Click(object sender, EventArgs e)
        {
            bool bool_Check = true, bool_End = true;

            for (int j = 0; j < int_Height; j++)
            {
                for (int i = 0; i < int_Width; i++)
                {
                    if ((array_int_New_Game[i, j] == 1) && (array_int_New_Game[i, j] != array_int_Answer[i, j]))
                    {
                        bool_Check = false;
                        foreach (Control x in this.Controls)
                        {
                            if ((x is Label) && (x.Name == ((j + 1) * 100 + (i + 1)).ToString()))
                            {
                                ((Label)x).BackColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        if ((array_int_New_Game[i, j] == 2) && (array_int_Answer[i, j] == 1))
                        {
                            bool_Check = false;
                            foreach (Control x in this.Controls)
                            {
                                if ((x is Label) && (x.Name == ((j + 1) * 100 + (i + 1)).ToString()))
                                {
                                    ((Label)x).BackColor = Color.Red;
                                }
                            }
                        }
                    }

                    if ((array_int_Answer[i, j] == 1) && (array_int_New_Game[i, j] != 1))
                    {
                        bool_End = false;
                    }
                    if ((array_int_Answer[i, j] == 0) && (array_int_New_Game[i, j] == 1))
                    {
                        bool_End = false;
                    }

                }
            }


            if (bool_End == true)
            {
                MessageBox.Show("Поздравляю, вы разгадали кроссворд");
                bool_Win = true;
            }
            else
            {
                if (bool_Check == true)
                {
                    MessageBox.Show("Пока что всё верно");
                }
                else
                {
                    MessageBox.Show("Вы допустили ошибку");
                }
            }
        }

        // Собыие при клике по верхним числам
        private void lbl_UpClick(object sender, System.EventArgs e)
        {
            int i = Convert.ToInt16((sender as Label).Name.Remove(0, (sender as Label).Name.Length - 2)) - 1;
            int j = Convert.ToInt16((sender as Label).Name.Remove((sender as Label).Name.Length - 2, 2).Remove(0, 1)) - 1;
            if (array_int_Up[j, i] == 0)
            {
                (sender as Label).BackColor = Color.DimGray;
                array_int_Up[j, i] = 1;
            }
            else
            {
                (sender as Label).BackColor = Color.LightGray;
                array_int_Up[j, i] = 0;
            }
        }

        // Собыие при клике по числам слева
        private void lbl_LeftClick(object sender, System.EventArgs e)
        {
            int i = Convert.ToInt16((sender as Label).Name.Remove(0, (sender as Label).Name.Length - 2)) - 1;
            int j = Convert.ToInt16((sender as Label).Name.Remove((sender as Label).Name.Length - 2, 2).Remove(0, 1)) - 1;
            if (array_int_Left[i, j] == 0)
            {
                (sender as Label).BackColor = Color.DimGray;
                array_int_Left[i, j] = 1;
            }
            else
            {
                (sender as Label).BackColor = Color.LightGray;
                array_int_Left[i, j] = 0;
            }
        }

        // Собыие при клике по клетке игровго поля
        private void lbl_CellClick(object sender, System.EventArgs e)
        {
            int i = Convert.ToInt16((sender as Label).Name.Remove(0, (sender as Label).Name.Length - 2)) - 1;
            int j = Convert.ToInt16((sender as Label).Name.Remove((sender as Label).Name.Length - 2, 2)) - 1;
            if (array_int_New_Game[i, j] == 0)
            {
                (sender as Label).BackColor = Color.Black;
                array_int_New_Game[i, j] = 1;
            }
            else
            {
                if (array_int_New_Game[i, j] == 1)
                {
                    (sender as Label).BackColor = Color.White;
                    (sender as Label).Text = "X";
                    array_int_New_Game[i, j] = 2;
                }
                else
                {
                    (sender as Label).BackColor = Color.White;
                    (sender as Label).Text = "";
                    array_int_New_Game[i, j] = 0;
                }
            }
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
        }

        private void btn_Main_Menu_Click(object sender, EventArgs e)
        {
            if (bool_Win == false)
            {
                DialogResult result_Exit = MessageBox.Show("Ваш результат не будет сохранён. Вы уверены, что хотите вернуться в меню?", "Важно", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result_Exit == DialogResult.OK)
                {
                    form_Main_Menu fmm = new form_Main_Menu();
                    fmm.Show();
                    this.Close();
                }
            }
            else
            {
                form_Main_Menu fmm = new form_Main_Menu();
                fmm.Show();
                this.Close();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (bool_Win == false)
            {
                DialogResult result_Exit = MessageBox.Show("Ваш результат не будет сохранён. Вы уверены, что хотите выйти?", "Важно", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result_Exit == DialogResult.OK)
                {
                    this.Close();
                    Application.Exit();
                }
            }
            else
            {
                DialogResult result_Exit = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result_Exit == DialogResult.Yes)
                {
                    this.Close();
                    Application.Exit();
                }
            }
            
        }

    }
}

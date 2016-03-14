using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nonograms
{
    public partial class form_Create : Form
    {
        public form_Create()
        {
            InitializeComponent();
        }

        int int_Width = 0, int_Height = 0;
        int[,] array_int_New_Cross = new int[20, 20];

        private void form_Create_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nDBDataSet.jc". При необходимости она может быть перемещена или удалена.
            this.jcTableAdapter.Fill(this.nDBDataSet.jc);
        }

        // Создаёт поле
        private void btn_Size_Ok_Click(object sender, EventArgs e)
        {
            int_Width = Convert.ToInt32(nud_Width.Value.ToString());
            int_Height = Convert.ToInt32(nud_Height.Value.ToString());

            int int_Form_Width = 0, int_Form_Height = 0;

            pn_Size.Size = new Size(5, 5);
            pn_Size.Visible = false;

            Label[,] lbl_Cell = new Label[int_Width, int_Height];
            int int_Left_Border = 0, int_Top_Border = 0;

            int_Top_Border = 0;
            for (int j = 0; j < int_Height; j++)
            {
                int_Left_Border = 0;
                if ((j % 5 == 0) && (j > 4)) { int_Top_Border++; }
                for (int i = 0; i < int_Width; i++)
                {
                    array_int_New_Cross[j, i] = 0;
                    lbl_Cell[i, j] = new Label();
                    lbl_Cell[i, j].Name = ((j + 1) * 100 + (i + 1)).ToString();
                    lbl_Cell[i, j].AutoSize = false;
                    lbl_Cell[i, j].Width = 21;
                    lbl_Cell[i, j].Height = 21;
                    lbl_Cell[i, j].BackColor = Color.White;
                    lbl_Cell[i, j].BorderStyle = BorderStyle.FixedSingle;
                    lbl_Cell[i, j].Click += new EventHandler(lbl_CellClick);
                    if ((i % 5 == 0) && (i > 4)) { int_Left_Border++; }
                    lbl_Cell[i, j].Location = new Point((i + 1) * 20 + int_Left_Border, (j + 1) * 20 + int_Top_Border);
                    Controls.Add(lbl_Cell[i, j]);
                }
                int_Form_Width = (int_Width * 20 + int_Left_Border + 40);
            }
            int_Form_Height = (int_Height * 20 + int_Top_Border + 40);

            pn_Menu.Location = new Point(int_Form_Width, 20);

            pn_Menu.Visible = true;
        }

        // Обратно в меню
        public void btn_Size_Cancel_Click(object sender, EventArgs e)
        {
            form_Main_Menu fmm = new form_Main_Menu();
            fmm.Show();
            this.Close();
        }

        // Событие при клике на ячейку
        private void lbl_CellClick(object sender, System.EventArgs e)
        {
            int i = Convert.ToInt16((sender as Label).Name.Remove(0, (sender as Label).Name.Length - 2)) - 1;
            int j = Convert.ToInt16((sender as Label).Name.Remove((sender as Label).Name.Length - 2, 2)) - 1;
            if (array_int_New_Cross[i, j] == 0)
            {
                (sender as Label).BackColor = Color.Black;
                array_int_New_Cross[i, j] = 1;
            }
            else
            {
                (sender as Label).BackColor = Color.White;
                array_int_New_Cross[i, j] = 0;
            }
        }

        // Поместить кроссворд в базу данных
        private void btn_Create_Cross_Click(object sender, EventArgs e)
        {
            bool bool_God_Name = true, bool_Get_Img = false;

            if ((tb_Name.Text == "Введите название") || (tb_Name.Text == ""))
            {
                MessageBox.Show("Вы не ввели название своего кроссворда", "Создание кроссворда", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < dgv_JC.RowCount - 1; i++)
                {
                    if (tb_Name.Text == dgv_JC[0, i].Value.ToString())
                    { bool_God_Name = false; }
                }

                if (bool_God_Name == false)
                {
                    MessageBox.Show("В базе данных уже есть кроссворд с таким именем");
                }
                else
                {
                    for (int i = 0; i < int_Height; i++)
                    {
                        for (int j = 0; j < int_Width; j++)
                        {
                            if (array_int_New_Cross[i, j] == 1)
                            {
                                bool_Get_Img = true;
                            }
                        }
                    }

                    if (bool_Get_Img == false)
                    {
                        MessageBox.Show("Вы не создали рисунок");
                    }
                    else
                    {
                        int int_Top_Count = 0, int_Left_Count = 0, int_Top_Max = 0, int_Left_Max = 0;
                        string str_Answer = "";

                        for (int i = 0; i < int_Height; i++)
                        {
                            int_Left_Count = 0;

                            for (int j = 0; j < int_Width; j++)
                            {
                                str_Answer += array_int_New_Cross[j, i].ToString();

                                if (j == (int_Width - 1))
                                {
                                    if (array_int_New_Cross[j, i] == 1)
                                    { int_Left_Count++; }
                                }
                                else
                                {
                                    if ((array_int_New_Cross[j, i] == 1) && (array_int_New_Cross[j + 1, i] == 0))
                                    { int_Left_Count++; }
                                }

                            }
                            if (int_Left_Max < int_Left_Count) { int_Left_Max = int_Left_Count; }
                        }

                        for (int i = 0; i < int_Width; i++)
                        {
                            int_Top_Count = 0;
                            for (int j = 0; j < int_Height; j++)
                            {
                                if (j == (int_Height - 1))
                                {
                                    if (array_int_New_Cross[i, j] == 1)
                                    { int_Top_Count++; }
                                }
                                else
                                {
                                    if ((array_int_New_Cross[i, j] == 1) && (array_int_New_Cross[i, j + 1] == 0))
                                    { int_Top_Count++; }
                                }
                            }
                            if (int_Top_Max < int_Top_Count) { int_Top_Max = int_Top_Count; }
                        }

                        int[,] array_int_Top = new int[int_Width, int_Top_Max];
                        int[,] array_int_Left = new int[int_Left_Max, int_Height];

                        for (int i = 0; i < int_Width; i++) { for (int j = 0; j < int_Top_Max; j++) { array_int_Top[i, j] = 0; } }
                        for (int i = 0; i < int_Height; i++) { for (int j = 0; j < int_Left_Max; j++) { array_int_Left[j, i] = 0; } }

                        int int_Some_Num = 0, int_third = 0;

                        for (int i = 0; i < int_Height; i++)
                        {
                            int_Some_Num = 0;
                            int_third = int_Left_Max - 1;
                            for (int j = int_Width - 1; j > -1; j--)
                            {
                                if (j == 0)
                                {
                                    if (array_int_New_Cross[j, i] == 1)
                                    {
                                        int_Some_Num++;
                                        array_int_Left[int_third, i] = int_Some_Num;
                                        int_Some_Num = 0;
                                    }
                                    else
                                    {
                                        if (int_Some_Num > 0)
                                        {
                                            array_int_Left[int_third, i] = int_Some_Num;
                                            int_Some_Num = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    if (array_int_New_Cross[j, i] == 1)
                                    {
                                        int_Some_Num++;
                                    }
                                    else
                                    {
                                        if (int_Some_Num > 0)
                                        {
                                            array_int_Left[int_third, i] = int_Some_Num;
                                            int_Some_Num = 0;
                                            int_third--;
                                        }
                                    }
                                }
                            }
                        }

                        for (int i = 0; i < int_Width; i++)
                        {
                            int_Some_Num = 0;
                            int_third = int_Top_Max - 1;
                            for (int j = int_Height - 1; j > -1; j--)
                            {
                                if (j == 0)
                                {
                                    if (array_int_New_Cross[i, j] == 1)
                                    {
                                        int_Some_Num++;
                                        array_int_Top[i, int_third] = int_Some_Num;
                                        int_Some_Num = 0;
                                    }
                                    else
                                    {
                                        if (int_Some_Num > 0)
                                        {
                                            array_int_Top[i, int_third] = int_Some_Num;
                                            int_Some_Num = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    if (array_int_New_Cross[i, j] == 1)
                                    {
                                        int_Some_Num++;
                                    }
                                    else
                                    {
                                        if (int_Some_Num > 0)
                                        {
                                            array_int_Top[i, int_third] = int_Some_Num;
                                            int_Some_Num = 0;
                                            int_third--;
                                        }
                                    }
                                }
                            }
                        }

                        string str_Left = "";
                        for (int i = 0; i < int_Height; i++)
                        {
                            for (int j = 0; j < int_Left_Max; j++)
                            {
                                if (array_int_Left[j, i] == 0)
                                {
                                    str_Left += "X";
                                }
                                else
                                {
                                    str_Left += array_int_Left[j, i].ToString() + "v";
                                }
                            }
                        }
                        str_Left += "End";

                        string str_Top = "";
                        for (int i = 0; i < int_Width; i++)
                        {
                            for (int j = 0; j < int_Top_Max; j++)
                            {
                                if (array_int_Top[i, j] == 0)
                                {
                                    str_Top += "X";
                                }
                                else
                                {
                                    str_Top += array_int_Top[i, j].ToString() + "v";
                                }
                            }
                        }
                        str_Top += "End";


                        System.IO.File.WriteAllText(@Application.StartupPath + "\\..\\..\\jcAnswers\\" + tb_Name.Text + ".txt", str_Answer);
                        System.IO.File.WriteAllText(@Application.StartupPath + "\\..\\..\\jcLeftNum\\" + tb_Name.Text + ".txt", str_Left);
                        System.IO.File.WriteAllText(@Application.StartupPath + "\\..\\..\\jcUpNum\\" + tb_Name.Text + ".txt", str_Top);

                        this.jcTableAdapter.Insert(tb_Name.Text, int_Width, int_Height, int_Top_Max, int_Left_Max);
                        this.jcTableAdapter.Update(this.nDBDataSet.jc);
                        this.jcTableAdapter.Fill(this.nDBDataSet.jc);

                        MessageBox.Show("Поздравляем, ваш кроссворд в базе");
                        form_Main_Menu fmm = new form_Main_Menu();
                        fmm.Show();
                        this.Close();
                    }
                }
            }
        }

        // Закрыть форму и вернуться в меню
        private void btn_Back_To_Menu_Click(object sender, EventArgs e)
        {
            DialogResult result_Exit = MessageBox.Show("Ваш результат не будет сохранён. Вы уверены, что хотите вернуться в меню?", "Важно", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result_Exit == DialogResult.OK)
            {
                form_Main_Menu fmm = new form_Main_Menu();
                fmm.Show();
                this.Close();
            }
        }

        // Выйти из программы
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result_Exit = MessageBox.Show("Ваш результат не будет сохранён. Вы уверены, что хотите выйти?", "Важно", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result_Exit == DialogResult.OK)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}

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
    public partial class form_Main_Menu : Form
    {
        public form_Main_Menu()
        {
            InitializeComponent();
        }


        // Загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nDBDataSet.jc". При необходимости она может быть перемещена или удалена.
            this.jcTableAdapter.Fill(this.nDBDataSet.jc);

            // Заполнение ComboBox'а для выбора кроссворда
            for (int i = 0; i < dgv_Nonograms.RowCount; i++)
            {
                cb_Chosen_Cross.Items.Add(dgv_Nonograms[0, i].Value.ToString() + " " + dgv_Nonograms[1, i].Value.ToString() + "x" + dgv_Nonograms[2, i].Value.ToString());
            }

        }

        // Кнопка выхода из программы
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Кнопка начала игры
        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (cb_Chosen_Cross.SelectedIndex > -1)
            {
                form_Game fg = new form_Game();
                fg.lbl_Help.Text = cb_Chosen_Cross.SelectedIndex.ToString();
                fg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Вы не выбрали кроссворд");
            }
            
        }

        // Кнопка туториала
        private void btn_Tutorial_Click(object sender, EventArgs e)
        {
            form_Tutorial ft = new form_Tutorial();
            ft.Show();
            this.Hide();
        }

        // Кнопка создания нового кроссворда
        private void btn_Create_Click(object sender, EventArgs e)
        {
            form_Create fc = new form_Create();
            fc.Show();
            this.Hide();
        }
    }
}

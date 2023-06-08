using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1();
            gameForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void instrbutton_Click(object sender, EventArgs e)
        {
            string rules = "Правила гри Sudoku:\n\n1. Головна мета гри - заповнити всі клітинки ігрового поля цифрами від 1 до 9 таким чином, щоб в кожному рядку, кожному стовпці і кожному блоку 3x3 не було повторень цифр.\n\n2. Початкове розташування деяких цифр вже задане, і ваше завдання - дозаповнити відсутні цифри.\n\n3. Щоб поставити цифру в клітинку, клікніть на неї та виберіть потрібну цифру з панелі цифр. Кожне натискання на клітинку збільшує числове значення від 1 до 9, якщо досягнуто максимального значення, воно знову стає 1.\n\n4. Видалити цифру з клітинки неможливо. Якщо ви помилились, натисніть на іншу клітинку та виправте значення.\n\n5. Гра закінчується, коли всі клітинки заповнені правильно і головна мета досягнута.\n\nГарної гри!";
            MessageBox.Show(rules, "Правила гри Sudoku", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

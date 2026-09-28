using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Travel_Ticket
{
    public partial class AnaSeife : Form
    {
        public AnaSeife()
        {
            InitializeComponent();

            // Şəhərləri əlavə edirik
            comboBox1.Items.Add("Bakı");
            comboBox1.Items.Add("Gəncə");
            comboBox1.Items.Add("Sumqayıt");
            comboBox1.Items.Add("Şəki");

            comboBox2.Items.Add("Bakı");
            comboBox2.Items.Add("Gəncə");
            comboBox2.Items.Add("Sumqayıt");
            comboBox2.Items.Add("Şəki");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Zəhmət olmasa tələb olunan xanaları doldurun!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string haradan = comboBox1.Text;
            string haraya = comboBox2.Text;
            string tarix = maskedTextBox1.Text;
            string saat = maskedTextBox2.Text;
            string yer = textBox1.Text;
            string adSoyad = textBox3.Text;
            string fin = textBox2.Text;
            string email = textBox4.Text;
            string telefon = maskedTextBox3.Text;

            string biletMelumati = $"Ad: {adSoyad} | FIN: {fin} | {haradan} -> {haraya} | Tarix: {tarix} Saat: {saat} | Yer: {yer} | Tel: {telefon}";

            listBox1.Items.Add(biletMelumati);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa silmək üçün siyahıdan bir bilet seçin.", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Proqramdan çıxış edilsinmi?", "Bildiriş", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
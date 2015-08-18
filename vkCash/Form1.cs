#region using
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
#endregion

namespace vkCash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region variables
            string filePath = Path.Combine(textBox1.Text);       // Путь файлов
            string fileExtension = Path.Combine(textBox2.Text); // Расширение файлов
            string fileName = Path.Combine(textBox3.Text);     // Название файлов
            #endregion

            #region program
            int i = 0;                                                          // 
            foreach (var f in Directory.GetFiles(filePath))                     // Получение списка файлов
            File.Move(f, filePath + "\\" + fileName + i++ + fileExtension);     // Переименование файлов
            #endregion         
        }

            #region
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void instaLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}

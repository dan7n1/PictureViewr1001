using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewerTenishev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        

       
        

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Закрывает форму.
            this.Close();
        }

       
        
       

        private void buttobackground_Click(object sender, EventArgs e)
        {
            // Показывает диалоговое окно цвета.
            // Если пользователь нажмет кнопку «ОК»,
            // изменит фон элемента управления PictureBox на цвет,
            // выбранный пользователем.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = null;


        }

        private void showButton_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else // Если пользователь снимает флажок, изменяет его на «Нормальный».
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void расстянутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void нормалToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
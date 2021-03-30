using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{

  
    public partial class Form1 : Form
    {
        string filePath = string.Empty;

        public string PicturePath
        {
            get
            {
                return Properties.Settings.Default.PicturePath;
            }
            set
            {
                Properties.Settings.Default.PicturePath = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Only file (*.bmp)|*.bmp|Only file (*.jpg)|*.jpg|Only file (*.jpeg)|*.jpeg|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        filePath = openFileDialog.FileName;
                        tssPath.Text = filePath;
                        pbImage.Image = Image.FromFile(filePath);
                        btReset.Visible = true;
                    }
                    catch
                    {
                        MessageBox.Show("Niepoprawny lub uszkodzony plik. Wybierz inny.", "Błąd");
                    }
                }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tssPath.Text = "Ścieżka: ";
            btReset.Visible = false;
            pbImage.Image = null;
            filePath = null;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.PicturePath = filePath;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filePath = Properties.Settings.Default.PicturePath;
            pbImage.Image = Image.FromFile(filePath);
            tssPath.Text = filePath;
            btReset.Visible = true;
        }
    }
}

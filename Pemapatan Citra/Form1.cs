using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Pemapatan_Citra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Browse Image";
            openFile.Filter = "Choose Image (*.jpg) |*jpg";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox_Path.Text = openFile.FileName;
                Image image = Image.FromFile(textBox_Path.Text);
                pictureBox_Image.Image = image;
            }
        }

        private void button_Compress_Click(object sender, EventArgs e)
        {

            try
            {
                Image gambar = Image.FromFile(textBox_Path.Text);
                int kualitasGambar = 30;
                string simpanFile = textBox_Path.Text.Insert(textBox_Path.Text.Length - 4, " Compressed");

                //Membuat ImageCodecInfo object untuk informasi pematapan gambar
                ImageCodecInfo jpegCodec = null;

                //Mangatur kualitas gambar yang akan di hasilkan
                EncoderParameter imageQualitysParameter = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, kualitasGambar);

                //Mendapat kan algoritma encoding/compress/pemapatan
                ImageCodecInfo[] allCodecs = ImageCodecInfo.GetImageEncoders();

                EncoderParameters codecParameter = new EncoderParameters(1);
                codecParameter.Param[0] = imageQualitysParameter;

                // Mencari algorima yang cocok dengan gambar. yang sebelum nya
                // telah kita dapat dari object Image Code Info diatas
                for (int i = 0; i < allCodecs.Length; i++)
                {
                    if (allCodecs[i].MimeType == "image/jpeg")
                    {
                        jpegCodec = allCodecs[i];
                        break;
                    }
                }

                //Simpan Gambar
                gambar.Save(simpanFile, jpegCodec, codecParameter);
                MessageBox.Show("Gambar Berhasil Dimapatkan","Berhasil");
                MessageBox.Show(simpanFile, "Gambar Di Simpan");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}

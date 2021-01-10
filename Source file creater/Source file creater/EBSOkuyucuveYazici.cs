using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Source_file_creater
{
    public  class EBSOkuyucuveYazici
    {
        static ResXResourceReader reader;
        static ResXResourceWriter res;
        static Bitmap bp;
        static public OpenFileDialog op;
        public static void EBSresxYazText(string dosyayolu, RichTextBox rc,string Value)
        {
            res = new ResXResourceWriter(dosyayolu);
            res.AddResource(Value, rc.Text);
            res.Generate();
            res.Close();
            MessageBox.Show("Yazı Oluşturuldu.");
        }
        public static void EBSresxYazİmage(string dosyayolu,string imageyolu, PictureBox pic,string Value)
        {
            pic.ImageLocation = imageyolu;
            bp = new Bitmap(op.FileName);
            res = new ResXResourceWriter(dosyayolu);
            res.AddResource(Value, bp);
            res.Generate();
            res.Close();
            MessageBox.Show("Resim Oluşturuldu.");
        }
        public static void EBSresxokuText(string dosyayolu,RichTextBox rc)
        {
            reader = new ResXResourceReader(dosyayolu);
            var veri = reader.GetEnumerator();
            while (veri.MoveNext())
            {
                rc.AppendText("Veri Değeri :" + veri.Key + "\r" + "Veri Valu Değeri :" + veri.Value);
            }
        }
        public static void EBSresxokuİmage(string dosyayolu, PictureBox pic)
        {
            reader = new ResXResourceReader(dosyayolu);
            var veri = reader.GetEnumerator();
            while (veri.MoveNext())
            {
                if (veri.Value.GetType().Name == "Bitmap")
                {
                    Bitmap bp = (Bitmap)veri.Value;
                    pic.Image = bp;
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /*
         * SWITCH - CASE
         * IF-Else mantigiyle calisan bir kontrol mekanizmasidir. Aradaki fark, if-else yapisi buyukluk-kucukluk gibi durumlari kontrol ederken,
         * switch-case yalnizca esitlik durumlarini kontrol edebilen karar yapimizdir.. Kendisine ait bir index mekanizmasi ile kosullari algilar, 
         * siraya koyar ve otomatik olarak yuzlerce kosulunuz olsa bile herbirine bakmadan hangisine uydugunu bulabilir. Bu da performansı direktman  etkiler...
         * Switch blogu icerisine yazdiginiz veri tipiniz ne ise, case (durum) olarak belirttiginiz tum veriler de ayni veri tipinde olmalıdır!
         * break => Kosul saglandi, artik karar yapisindan kendini disari atabilirsin mesajini sisteme verir...
         */


        private void BtnOrnek1_Click(object sender, EventArgs e)
        {
            string mevsim = txtGelenDeger1.Text.ToLower();

            switch (mevsim)
            {
                case "yaz":
                    MessageBox.Show("Haziran - Temmuz - Ağustos");
                    break;
                case "sonbahar":
                    MessageBox.Show("Eylül - Ekim - Kasım");
                    break;
                case "kış":
                    MessageBox.Show("Aralık - Ocak - Şubat");
                    break;
                case "ilkbahar":
                    MessageBox.Show("Mart - Nisan - Mayıs");
                    break;
                default:
                    MessageBox.Show("Böyle bir mevsim bulunamadı!");
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string ay = txtGelenDeger1.Text.ToLower();
            switch (ay)
            {

                case "haziran":
                case "temmuz":
                case "agustos":
                    MessageBox.Show("Yaz");
                    break;

                case "eylül":
                case "ekim":
                case "kasım":
                    MessageBox.Show("Sonbahar");
                    break;

                case "aralık":
                case "ocak":
                case "şubat":
                    MessageBox.Show("Kış");
                    break;


                case "mart":
                case "nisan":
                case "mayıs":
                    MessageBox.Show("İlkbahar");
                    break;

                default:
                    break;
            }
        }

        private void BtnOrnek2_Click(object sender, EventArgs e)
        {
            //Eger ilk textbox'a "Admin","Moderator","Yonetici","CEO","Baskan" degerleri girilirse "Yönetim Paneline Yönlendiriliyorsunuz..."
            //"Uye" girilirse "Ana Sayfaya Yonlendiriliyorsunuz...";
            //Harici bir durumda "Bu Sayfayı Görme Yetkiniz Yok!";
        }

        private void BtnOrnek3_Click(object sender, EventArgs e)
        {
            //İç içe switch kullanarak kullanıcı adını ve şifresini kontrol ediniz.eğer kullanıcı kullanıcıadını ve şifresini doğru girerse "Tebrikler, hem kullanıcı adı hemde şifreniz doğru" uyarısı
            //Kullanıcı adı doğru şifre yanlışsa "Kullanıcı adınız doğru ancak şifreniz yanlış!" uyarısı
            //kullanıcı adı yanlışsa "Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!" uyarusını kullanıcıya veriniz.

            //KullaniciAdi = "bilgeadam";
            //Sifre = "1234";
        }
    }
}

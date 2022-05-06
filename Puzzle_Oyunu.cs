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
using System.IO;


namespace _19701038_Yunusnamli_Puzzle_Oyunu
{
    /*19701038 Yunus Namlı */
    public partial class Puzzle_Oyunu : Form
    {
        PictureBox kaynak_resim_kutusu;
        PictureBox hedef_resim_kutusu;

        public Puzzle_Oyunu()
        {
            InitializeComponent();
        }

        private void btn_Ac(object sender, EventArgs e)
        {
            /*
             Bu kısımda kullanıcı tarafından dosyadan seçilen bir resmi alıp pictureBox_Ana_Resim içerisine yerleştirdim.Bunu yapmamın amacı kullanıcının, seçtiği resime bakarak karışık şekilde ayrılmış olan parçaları tekrardan tam resim haline getirebilmesi için yaptım.
             */
            string resim_yolu;
            pictureBox_Ana_Resim.SizeMode = PictureBoxSizeMode.StretchImage;
            Dosyadan_Sec.ShowDialog();
            pictureBox_Ana_Resim.ImageLocation = Dosyadan_Sec.FileName;
            resim_yolu = Dosyadan_Sec.FileName;

            /*
             Bu kısımda parçalara ayırdığımız resimlerin her parçasını image olarak resim_parcalari adında bir generic liste sakladım. 
             *Seçilen resmi kaç satır ve kaç sütüna ayıracağımızı satir_sayisi ve sutun_sayisi değişkenlerine atadım.
             *For döngüsü kullanarak resmi parçalara ayırdım.
             * Seçili alan kadar bir bitmap oluşturdum.Daha sonra bu bitmap için grafik nesnesi oluşturdum.
             * Picturebox içindeki resmi 0,0 noktasına çizdirdim.
             * En son kısımda parçalara ayrılan her bir resmi resim_parcalari adındaki listenin içerisine attım.
             * En son kısımda ise grafik nesnesini sonlandırdım.        
             */
            Bitmap parcali_resim;
            List<Image> resim_parcalari = new List<Image>();
            Graphics graphic = null;
            Image secilen_resim = Image.FromFile(resim_yolu);
            int sutun_sayisi = 9;
            int satir_sayisi = 16;
            int x = 0;
            int y = 0;
            for (int i = 0; i < satir_sayisi; i++)
            {

                for (int j = 0; j < sutun_sayisi; j++)
                {

                    Rectangle seçili_alan = new Rectangle(x, y, secilen_resim.Width / sutun_sayisi, secilen_resim.Height / satir_sayisi);

                    parcali_resim = new Bitmap(seçili_alan.Width, seçili_alan.Height);

                    graphic = Graphics.FromImage(parcali_resim);

                    graphic.DrawImage(secilen_resim, 0, 0, seçili_alan, GraphicsUnit.Pixel);

                    resim_parcalari.Add(parcali_resim);

                    x += secilen_resim.Width / sutun_sayisi;

                }

                y += secilen_resim.Height / satir_sayisi;

                x = 0;
            }
            graphic.Dispose();

            /*
             Bu kısımda resim_kutusu adında bir picturebox dizisi oluşturdum ve her bir indisine tasarım kısmında eklemiş olduğum pictureboxları atadım. 
             */

            PictureBox[] resim_kutusu = new PictureBox[resim_parcalari.Count];

            resim_kutusu[0] = pictureBox1;
            resim_kutusu[1] = pictureBox2;
            resim_kutusu[2] = pictureBox3;
            resim_kutusu[3] = pictureBox4;
            resim_kutusu[4] = pictureBox5;
            resim_kutusu[5] = pictureBox6;
            resim_kutusu[6] = pictureBox7;
            resim_kutusu[7] = pictureBox8;
            resim_kutusu[8] = pictureBox9;
            resim_kutusu[9] = pictureBox10;
            resim_kutusu[10] = pictureBox11;
            resim_kutusu[11] = pictureBox12;
            resim_kutusu[12] = pictureBox13;
            resim_kutusu[13] = pictureBox14;
            resim_kutusu[14] = pictureBox15;
            resim_kutusu[15] = pictureBox16;
            resim_kutusu[16] = pictureBox17;
            resim_kutusu[17] = pictureBox18;
            resim_kutusu[18] = pictureBox19;
            resim_kutusu[19] = pictureBox20;
            resim_kutusu[20] = pictureBox21;
            resim_kutusu[21] = pictureBox22;
            resim_kutusu[22] = pictureBox23;
            resim_kutusu[23] = pictureBox24;
            resim_kutusu[24] = pictureBox25;
            resim_kutusu[25] = pictureBox26;
            resim_kutusu[26] = pictureBox27;
            resim_kutusu[27] = pictureBox28;
            resim_kutusu[28] = pictureBox29;
            resim_kutusu[29] = pictureBox30;
            resim_kutusu[30] = pictureBox31;
            resim_kutusu[31] = pictureBox32;
            resim_kutusu[32] = pictureBox33;
            resim_kutusu[33] = pictureBox34;
            resim_kutusu[34] = pictureBox35;
            resim_kutusu[35] = pictureBox36;
            resim_kutusu[36] = pictureBox37;
            resim_kutusu[37] = pictureBox38;
            resim_kutusu[38] = pictureBox39;
            resim_kutusu[39] = pictureBox40;
            resim_kutusu[40] = pictureBox41;
            resim_kutusu[41] = pictureBox42;
            resim_kutusu[42] = pictureBox43;
            resim_kutusu[43] = pictureBox44;
            resim_kutusu[44] = pictureBox45;
            resim_kutusu[45] = pictureBox46;
            resim_kutusu[46] = pictureBox47;
            resim_kutusu[47] = pictureBox48;
            resim_kutusu[48] = pictureBox49;
            resim_kutusu[49] = pictureBox50;
            resim_kutusu[50] = pictureBox51;
            resim_kutusu[51] = pictureBox52;
            resim_kutusu[52] = pictureBox53;
            resim_kutusu[53] = pictureBox54;
            resim_kutusu[54] = pictureBox55;
            resim_kutusu[55] = pictureBox56;
            resim_kutusu[56] = pictureBox57;
            resim_kutusu[57] = pictureBox58;
            resim_kutusu[58] = pictureBox59;
            resim_kutusu[59] = pictureBox60;
            resim_kutusu[60] = pictureBox61;
            resim_kutusu[61] = pictureBox62;
            resim_kutusu[62] = pictureBox63;
            resim_kutusu[63] = pictureBox64;
            resim_kutusu[64] = pictureBox65;
            resim_kutusu[65] = pictureBox66;
            resim_kutusu[66] = pictureBox67;
            resim_kutusu[67] = pictureBox68;
            resim_kutusu[68] = pictureBox69;
            resim_kutusu[69] = pictureBox70;
            resim_kutusu[70] = pictureBox71;
            resim_kutusu[71] = pictureBox72;
            resim_kutusu[72] = pictureBox73;
            resim_kutusu[73] = pictureBox74;
            resim_kutusu[74] = pictureBox75;
            resim_kutusu[75] = pictureBox76;
            resim_kutusu[76] = pictureBox77;
            resim_kutusu[77] = pictureBox78;
            resim_kutusu[78] = pictureBox79;
            resim_kutusu[79] = pictureBox80;
            resim_kutusu[80] = pictureBox81;
            resim_kutusu[81] = pictureBox82;
            resim_kutusu[82] = pictureBox83;
            resim_kutusu[83] = pictureBox84;
            resim_kutusu[84] = pictureBox85;
            resim_kutusu[85] = pictureBox86;
            resim_kutusu[86] = pictureBox87;
            resim_kutusu[87] = pictureBox88;
            resim_kutusu[88] = pictureBox89;
            resim_kutusu[89] = pictureBox90;
            resim_kutusu[90] = pictureBox91;
            resim_kutusu[91] = pictureBox92;
            resim_kutusu[92] = pictureBox93;
            resim_kutusu[93] = pictureBox94;
            resim_kutusu[94] = pictureBox95;
            resim_kutusu[95] = pictureBox96;
            resim_kutusu[96] = pictureBox97;
            resim_kutusu[97] = pictureBox98;
            resim_kutusu[98] = pictureBox99;
            resim_kutusu[99] = pictureBox100;
            resim_kutusu[100] = pictureBox101;
            resim_kutusu[101] = pictureBox102;
            resim_kutusu[102] = pictureBox103;
            resim_kutusu[103] = pictureBox104;
            resim_kutusu[104] = pictureBox105;
            resim_kutusu[105] = pictureBox106;
            resim_kutusu[106] = pictureBox107;
            resim_kutusu[107] = pictureBox108;
            resim_kutusu[108] = pictureBox109;
            resim_kutusu[109] = pictureBox110;
            resim_kutusu[110] = pictureBox111;
            resim_kutusu[111] = pictureBox112;
            resim_kutusu[112] = pictureBox113;
            resim_kutusu[113] = pictureBox114;
            resim_kutusu[114] = pictureBox115;
            resim_kutusu[115] = pictureBox116;
            resim_kutusu[116] = pictureBox117;
            resim_kutusu[117] = pictureBox118;
            resim_kutusu[118] = pictureBox119;
            resim_kutusu[119] = pictureBox120;
            resim_kutusu[120] = pictureBox121;
            resim_kutusu[121] = pictureBox122;
            resim_kutusu[122] = pictureBox123;
            resim_kutusu[123] = pictureBox124;
            resim_kutusu[124] = pictureBox125;
            resim_kutusu[125] = pictureBox126;
            resim_kutusu[126] = pictureBox127;
            resim_kutusu[127] = pictureBox128;
            resim_kutusu[128] = pictureBox129;
            resim_kutusu[129] = pictureBox130;
            resim_kutusu[130] = pictureBox131;
            resim_kutusu[131] = pictureBox132;
            resim_kutusu[132] = pictureBox133;
            resim_kutusu[133] = pictureBox134;
            resim_kutusu[134] = pictureBox135;
            resim_kutusu[135] = pictureBox136;
            resim_kutusu[136] = pictureBox137;
            resim_kutusu[137] = pictureBox138;
            resim_kutusu[138] = pictureBox139;
            resim_kutusu[139] = pictureBox140;
            resim_kutusu[140] = pictureBox141;
            resim_kutusu[141] = pictureBox142;
            resim_kutusu[142] = pictureBox143;
            resim_kutusu[143] = pictureBox144;

            /*
             Bu kısımda 0 da dahil olmaz üzere 144 e kadar toplamda 143 adet birbirinden farklı rastgele sayı ürettim ve bunu oluşturmuş olduğum sayilar listesine atadım.Bu kısımda rastgele üretilen sayılardan aynı olanları sayilar listesine dahil etmedim.Çünkü resim parçalarını karışık olarak pictureboxlara yerleştirdiğimizde aynı resim parçasından birden fazla olmasını engellemek istedim.
             */
            int sayac = 0;
            List<int> sayilar = new List<int>();
            Random rastegele = new Random();
            while (sayac < 2000)
            {
                int rastgelesayi = rastegele.Next(144);
                if (!sayilar.Contains(rastgelesayi))
                {
                    sayilar.Add(rastgelesayi);
                }
                sayac++;

            }

            /*
             Bu kısımda for döngüsü kullanarak önceden dizi olarak oluşturduğum resim_kutusu'nun her bir indisindeki ımage kısmına rastgele resim parçaları yerleştirdim.
             * Daha sonra kullanıcının sürükleme-bırakma yoluyla parçalara yer değiştirtip tam resmi oluşturabilmesi için  resim_kutusu_MouseDown, 
               resim_kutusu_DragEnter, resim_kutusu_DragDrop adında 3 adet fonksiyon oluşturdum.            
              */

            for (int i = 0; i < resim_kutusu.Length; i++)
            {

                resim_kutusu[i].Image = resim_parcalari[sayilar[i]];
                resim_kutusu[i].AllowDrop = true;
                resim_kutusu[i].MouseDown += resim_kutusu_MouseDown;//Sürükleme olayı başladı.
                resim_kutusu[i].DragEnter += resim_kutusu_DragEnter;//Sürükleme bir kutunun sahasına girdi.
                resim_kutusu[i].DragDrop += resim_kutusu_DragDrop;// Sürükleme bırakmayla sonuçlandırıldı.

            }


            #region ResmiDuzgunParcalama

            /*
             Yukarıda yazmış olduğum for döngüsünü açıklama satırı olarak alıp bu for döngüsünü kullanırsanız seçilen resmi sırasıyla parçalara ayrılmış ve sırasıyla pictureboxlara yerleştirilmiş bir şekilde bulacaksınız.  
             */

            /*
                    for (int i = 0; i < resim_kutusu.Length; i++)
                    {
                        resim_kutusu[i].Image = resim_parcalari[i];
                    }
            */

            #endregion

        }

        private void resim_kutusu_DragDrop(object sender, DragEventArgs e)
        {
            hedef_resim_kutusu = sender as PictureBox;
            kaynak_resim_kutusu = e.Data.GetData(typeof(PictureBox)) as PictureBox;

            Image tmp = hedef_resim_kutusu.Image;
            hedef_resim_kutusu.Image = kaynak_resim_kutusu.Image;
            kaynak_resim_kutusu.Image = tmp;
        }

        private void resim_kutusu_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                e.Effect = DragDropEffects.Move;


            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void resim_kutusu_MouseDown(object sender, MouseEventArgs e)
        {
            kaynak_resim_kutusu = sender as PictureBox;
            kaynak_resim_kutusu.DoDragDrop(kaynak_resim_kutusu, DragDropEffects.Move);
        }

    }
}

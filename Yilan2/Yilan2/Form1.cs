using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yilan2
{
    public partial class frm_yilanoyunu : Form
    {
        private Label _yilanKafasi;
        private int _yilanParcasiArasiMesafe=2;
        private int _yilanparcasiSayisi;
        private int _yilanBoyutu = 20;
        private int _yemBoyutu = 20;
        private Label _yem;
        private Random _random;
        private HareketYonu _yon;
        

        public frm_yilanoyunu()
        {
            InitializeComponent();
            _random = new Random();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_yilanoyunu_Load(object sender, EventArgs e)
        {
            _yilanparcasiSayisi = 0;
            yemOlustur();
            yemYerinidegis();
            yilani_yerlestir();
            sifirla();
            _yon = HareketYonu.Sola;
            tmr_yilanHareket.Enabled = true;
        }
        private void YenidenBAslat()
        {
            this.pnl_screen.Controls.Clear();
            _yilanparcasiSayisi = 0;
            yemOlustur();
            yemYerinidegis();
            yilani_yerlestir();
            _yon = HareketYonu.Sola;           
            lbl_puan1.Text = "0";
            lbl_sure1.Text = "0";
           
            tmr_yilanHareket.Enabled = true;

        }
        public void sifirla()
        {
         tmr_sure.Enabled = true;
        }
        
        private Label Yilanparcasiolustur(int locationX, int locationY)
        {
            _yilanparcasiSayisi++;
            Label lbl = new Label()
            {
                Name = "yilanParca" + _yilanparcasiSayisi,
                BackColor = Color.Yellow,
                Width = _yilanBoyutu,
                Height = _yilanBoyutu,
                Location = new Point(locationX, locationY),

            };
            this.pnl_screen.Controls.Add(lbl);
            return lbl;
        }
        private void yilani_yerlestir()
        {
            _yilanKafasi = Yilanparcasiolustur(0, 0);
            _yilanKafasi.Text = ":";
            _yilanKafasi.TextAlign=ContentAlignment.MiddleCenter;
            _yilanKafasi.ForeColor= Color.White;
            var locationX = (pnl_screen.Width / 2) - (_yilanKafasi.Width / 2);
            var locationY = (pnl_screen.Height / 2) - (_yilanKafasi.Height / 2);
            _yilanKafasi.Location = new Point(locationX, locationY);

        }
        private void yemOlustur()
        {
            Label lbl = new Label()
            {
                Name = "Yem" + _yilanparcasiSayisi,
                BackColor = Color.Blue,
                Width = _yemBoyutu,
                Height = _yemBoyutu,

            };
            _yem = lbl;
            this.pnl_screen.Controls.Add(lbl);
        }
        private void yemYerinidegis()
        {
            var loacationX = _random.Next(0, pnl_screen.Width - _yilanBoyutu);
            var locationY = _random.Next(0, pnl_screen.Height - _yilanBoyutu);
            _yem.Location = new Point(loacationX, locationY); 
        }
        private enum HareketYonu
        {
            Yukari,
            Asagi,
            Saga,
            Sola,
        }
        private void frm_yilanoyunu_KeyDown(object sender, KeyEventArgs e)
        {
            var keyCode = e.KeyCode;
            if (_yon==HareketYonu.Sola&&keyCode==Keys.D||
                _yon==HareketYonu.Saga&&keyCode==Keys.A
                ||_yon==HareketYonu.Yukari&&keyCode==Keys.W
                ||_yon ==HareketYonu.Asagi&&keyCode==Keys.S)
            {
                return;
            }
            switch (keyCode)
            {
                case Keys.W:
                    _yon = HareketYonu.Yukari;
                    break;
                case Keys.S:
                    _yon = HareketYonu.Asagi;
                    break;
                case Keys.A:
                    _yon = HareketYonu.Saga;
                    break;
                case Keys.D:
                    _yon = HareketYonu.Sola;
                    break;

                default:
                    break;
            }
        }

        private void tmr_yilanHareket_Tick(object sender, EventArgs e)
        {
            YilanKafasiniTakipEt();
            YilaniYurut();
            OyunBittimi();
            YilanYemiYedimi();
        }

        private void OyunBittimi()
        {
            bool oyunbittimi = false;
            var rect1 = new Rectangle(_yilanKafasi.Location, _yilanKafasi.Size);
            foreach(Control control in pnl_screen.Controls)
            {
                if(control is Label &&control.Name.Contains("yilanParca")&& control.Name != _yilanKafasi.Name)
                {
                    var rect2 =new Rectangle(control.Location, control.Size);
                    if (rect1.IntersectsWith(rect2))
                    {
                        oyunbittimi = true;
                        break;
                    }
                }
            }
            if (oyunbittimi)
            {
                tmr_yilanHareket.Enabled = true;
                DialogResult sonuc =MessageBox.Show("Puanınız:"+lbl_puan1.Text,"Oyun Bitti İbibik",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (sonuc==DialogResult.OK)
                {
                    YenidenBAslat();
                }
            }
        }

        private void YilaniYurut()
        {
            var locationX = _yilanKafasi.Location.X;
            var locationY = _yilanKafasi.Location.Y;
            switch (_yon)
            {
                case HareketYonu.Yukari:
                    _yilanKafasi.Location = new Point(locationX, locationY - (_yilanKafasi.Width + _yilanParcasiArasiMesafe));
                    break;
                case HareketYonu.Asagi:
                    _yilanKafasi.Location = new Point(locationX, locationY + (_yilanKafasi.Width + _yilanParcasiArasiMesafe));
                    break;
                case HareketYonu.Saga:
                    _yilanKafasi.Location = new Point(locationX - (_yilanKafasi.Width + _yilanParcasiArasiMesafe), locationY);
                    break;
                case HareketYonu.Sola:
                    _yilanKafasi.Location = new Point(locationX + (_yilanKafasi.Width + _yilanParcasiArasiMesafe), locationY);
                    break;
                default:
                    break;
            }

        }
        private void YilanYemiYedimi()
        {
            var rect1 = new Rectangle(_yilanKafasi.Location, _yilanKafasi.Size);
            var rect2 = new Rectangle(_yem.Location, _yem.Size);
            if (rect1.IntersectsWith(rect2))
            {
                lbl_puan1.Text=(Convert.ToDouble(lbl_puan1.Text)+10).ToString();
                yemYerinidegis();
                Yilanparcasiolustur(-_yilanBoyutu, -_yilanBoyutu);
            }
        }
        private void YilanKafasiniTakipEt()
        {
            if (_yilanparcasiSayisi <= 1) return;
            
                for (int i = _yilanparcasiSayisi; i > 1; i--)
                {
                var sonrakiParca =(Label)pnl_screen.Controls[i];
                var oncekiParca = (Label)pnl_screen.Controls[i-1];
                sonrakiParca.Location = oncekiParca.Location;
            }
            
        }

        private void tmr_sure_Tick(object sender, EventArgs e)
        {
            lbl_sure1.Text =(Convert.ToDouble(lbl_sure1.Text)+1).ToString();
        }

        private void lbl_sure1_Click(object sender, EventArgs e)
        {

        }
    }

}

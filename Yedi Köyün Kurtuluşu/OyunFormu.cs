using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace YediKoyunKurtulusu
{
	public partial class OyunFormu : Form
	{
		private OyunVerisi oyun;
		private Koy seciliKoy;
		private List<string> kullanilacakOgeler;
		private BST bst = new BST();
		private Dictionary<string, Button> koyButonlari;



		public OyunFormu()
		{
			InitializeComponent();
			oyun = new OyunVerisi();
			kullanilacakOgeler = new List<string>();
			koyButonlari = new Dictionary<string, Button>
	{
		{ "Ascent Koyu", btnKoy1 },
		{ "İcebox Koyu", btnKoy2 },
		{ "Pearl Koyu", btnKoy3 },
		{ "Split Koyu", btnKoy4 },
		{ "Breeze Koyu", btnKoy5 },
		{ "Fracture Koyu", btnKoy6 },
		{ "Sunset Koyu", btnKoy7 },
	};

			CantaGuncelle();
			ButonRenkleriniGuncelle();
			IstatistikleriGuncelle();


			string[] isimler = { "Ascent Koyu", "İcebox Koyu", "Pearl Koyu", "Split Koyu", "Breeze Koyu", "Fracture Koyu", "Sunset Koyu" };
			Button[] butonlar = { btnKoy1, btnKoy2, btnKoy3, btnKoy4, btnKoy5, btnKoy6, btnKoy7 };

			for (int i = 7 - 1; i >= 0; i--)
			{
				butonlar[i].Location = new System.Drawing.Point(30 + (i % 4) * 140, 30 + (i / 4) * 60);
				butonlar[i].Size = new System.Drawing.Size(130, 40);
				butonlar[i].Text = isimler[i];
				this.Controls.Add(butonlar[i]);
			}
		}


		private void CantaGuncelle()
		{
			lstCanta.Items.Clear();
			bst = new BST();

			foreach (var oge in oyun.Canta.OgeleriListele())
			{
				lstCanta.Items.Add(oge);
				bst.Ekle(oge);
			}

			lstSirali.Items.Clear();
			foreach (string oge in bst.InOrder())
				lstSirali.Items.Add(oge);

			IstatistikleriGuncelle();

		}


		private void KoySec(string koyAdi)
		{
			var siradaki = oyun.SiradakiKoy();

			if (siradaki == null)
			{
				lblDurum.Text = "Tüm köyler kurtarıldı!";
				return;
			}

			if (koyAdi != siradaki.Ad)
			{
				lblDurum.Text = $"Sadece sıradaki köy seçilebilir: {siradaki.Ad}";
				return;
			}

			seciliKoy = siradaki;
			lblSeciliKoy.Text = $"Seçilen Köy: {seciliKoy.Ad}";
			lblGerekenOgeler.Text = $"Gereken Öğeler: {string.Join(", ", seciliKoy.GerekenOgeler)}";
			lblOduller.Text = $"Kazandıracağı Eşyalar: {string.Join(", ", seciliKoy.Oduller)}";
			kullanilacakOgeler.Clear();
			lblDurum.Text = "";
		}


		private void btnOgeleriKullan_Click(object sender, EventArgs e)
		{
			if (seciliKoy == null)
			{
				MessageBox.Show("Lütfen önce bir koy seçin!");
				return;
			}

			kullanilacakOgeler.Clear();

			foreach (string oge in seciliKoy.GerekenOgeler)
			{
				if (oyun.Canta.VarMi(oge))
				{
					oyun.Canta.Cikar(oge);
					kullanilacakOgeler.Add(oge);
				}
				else
				{
					lblDurum.Text = $"'{oge}' çantada yok!";
					return;
				}
			}

			CantaGuncelle();
			lblDurum.Text = " Gerekli oğeler başarıyla kullanıldı.";
		}



		private void btnKurtar_Click(object sender, EventArgs e)
		{
			if (seciliKoy == null)
			{
				MessageBox.Show("Bir koy seçilmedi.");
				return;
			}

			if (seciliKoy.KurtarildiMi)
			{
				lblDurum.Text = "Bu koy zaten kurtarıldı.";
				return;
			}

			if (kullanilacakOgeler.Count == seciliKoy.GerekenOgeler.Count)
			{
				seciliKoy.KurtarildiMi = true;
				oyun.KoyKurtarildi();


				string eklendiMesaj = "";
				foreach (string odul in seciliKoy.Oduller)
				{
					if (oyun.Canta.Ekle(odul))
						eklendiMesaj += $"{odul}, ";
				}

				CantaGuncelle();
				lblDurum.Text = $"{seciliKoy.Ad} başarıyla kurtarıldı!\n🎁 Kazanılan: {eklendiMesaj.TrimEnd(',', ' ')}";
			}
			else
			{
				lblDurum.Text = "Tüm gerekli oğeler kullanılmadı!";
			}
			ButonRenkleriniGuncelle();
			IstatistikleriGuncelle();

			bool hepsiTamam = true;
			foreach (var k in oyun.Koyler)
			{
				if (!k.KurtarildiMi)
				{
					hepsiTamam = false;
					break;
				}
			}

			if (hepsiTamam)
			{
				MessageBox.Show(" Tebrikler! Tüm koyleri başarıyla kurtardınız.\nOyun şimdi kapanacak.", "Gorev Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Application.Exit();
			}
		}



		private void btnEsyaCikar_Click(object sender, EventArgs e)
		{
			if (lstCanta.SelectedItem == null)
			{
				MessageBox.Show("Lütfen çıkarılacak bir eşya seçin.");
				return;
			}

			string secili = lstCanta.SelectedItem.ToString();
			if (oyun.Canta.Cikar(secili))
			{
				lblDurum.Text = $" {secili} çantadan çıkarıldı.";
				CantaGuncelle();
			}
		}



		private void btnAra_Click(object sender, EventArgs e)
		{
			string aranacak = txtArama.Text.Trim();
			if (string.IsNullOrEmpty(aranacak))
			{
				MessageBox.Show("Aranacak kelimeyi yazınız.");
				return;
			}

			if (bst.Ara(aranacak))
				MessageBox.Show($"'{aranacak}' çantada mevcut!");
			else
				MessageBox.Show($"'{aranacak}' çantada bulunamadı.");
		}


		private void ButonRenkleriniGuncelle()
		{
			foreach (var koy in oyun.Koyler)
			{
				if (koyButonlari.ContainsKey(koy.Ad))
				{
					Button btn = koyButonlari[koy.Ad];
					if (koy.KurtarildiMi)
					{
						btn.BackColor = System.Drawing.Color.LightGreen;
					}
					else
					{
						btn.BackColor = System.Drawing.SystemColors.Control;
					}
				}
			}
		}


		private void IstatistikleriGuncelle()
		{
			int toplamKoy = oyun.Koyler.Count;
			int kurtarilan = 0;
			foreach (var koy in oyun.Koyler)
			{
				if (koy.KurtarildiMi)
					kurtarilan++;
			}

			int cantaSayisi = oyun.Canta.MevcutSayisi();

			lblKoyDurum.Text = $"Koyler: {kurtarilan}/{toplamKoy} kurtarıldı";
			lblCantaDurum.Text = $"Çantadaki Oğeler: {cantaSayisi}/10";
		}

		private void btnSifirla_Click(object sender, EventArgs e)
		{
			DialogResult cevap = MessageBox.Show(
				"Oyunu sıfırlamak istediğinizden emin misiniz?",
				"Sıfırlama Onayı",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (cevap == DialogResult.Yes)
			{
				oyun = new OyunVerisi(); // formu yeniden başlatır
				seciliKoy = null;
				kullanilacakOgeler.Clear();

				CantaGuncelle();
				ButonRenkleriniGuncelle();
				lblSeciliKoy.Text = "Seçilen Koy: -";
				lblGerekenOgeler.Text = "Gereken Oğeler: -";
				lblDurum.Text = "Oyun sıfırlandı.";
			}
		}

		private void btnIpucu_Click(object sender, EventArgs e)
		{
			List<Koy> kalanKoyler = oyun.Koyler.FindAll(k => !k.KurtarildiMi);

			if (kalanKoyler.Count == 0)
			{
				MessageBox.Show("Tüm koyler zaten kurtarıldı!", "İpucu");
				return;
			}

			string mesaj = "Sırayla kurtarman gereken koyler:\n\n";
			foreach (var koy in kalanKoyler)
			{
				mesaj += $"• {koy.Ad}\n";
			}

			MessageBox.Show(mesaj, "İpucu");
		}











		private void btnKoy1_Click(object sender, EventArgs e) => KoySec("Ascent Koyu");
		private void btnKoy2_Click(object sender, EventArgs e) => KoySec("İcebox Koyu");
		private void btnKoy3_Click(object sender, EventArgs e) => KoySec("Pearl Koyu");
		private void btnKoy4_Click(object sender, EventArgs e) => KoySec("Split Koyu");
		private void btnKoy5_Click(object sender, EventArgs e) => KoySec("Breeze Koyu");
		private void btnKoy6_Click(object sender, EventArgs e) => KoySec("Fracture Koyu");
		private void btnKoy7_Click(object sender, EventArgs e) => KoySec("Sunset Koyu");
	}
}

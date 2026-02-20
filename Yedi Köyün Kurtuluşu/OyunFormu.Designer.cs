using System.Windows.Forms;

namespace YediKoyunKurtulusu
{
	partial class OyunFormu
	{
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunFormu));
			this.lblSeciliKoy = new System.Windows.Forms.Label();
			this.lblGerekenOgeler = new System.Windows.Forms.Label();
			this.btnOgeleriKullan = new System.Windows.Forms.Button();
			this.btnKurtar = new System.Windows.Forms.Button();
			this.lblDurum = new System.Windows.Forms.Label();
			this.btnKoy1 = new System.Windows.Forms.Button();
			this.btnKoy2 = new System.Windows.Forms.Button();
			this.btnKoy3 = new System.Windows.Forms.Button();
			this.btnKoy4 = new System.Windows.Forms.Button();
			this.btnKoy5 = new System.Windows.Forms.Button();
			this.btnKoy6 = new System.Windows.Forms.Button();
			this.btnKoy7 = new System.Windows.Forms.Button();
			this.btnEsyaCikar = new System.Windows.Forms.Button();
			this.txtArama = new System.Windows.Forms.TextBox();
			this.btnAra = new System.Windows.Forms.Button();
			this.lstSirali = new System.Windows.Forms.ListBox();
			this.lblKoyDurum = new System.Windows.Forms.Label();
			this.lblCantaDurum = new System.Windows.Forms.Label();
			this.btnSifirla = new System.Windows.Forms.Button();
			this.lblOduller = new System.Windows.Forms.Label();
			this.btnIpucu = new System.Windows.Forms.Button();
			this.lstCanta = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lblSeciliKoy
			// 
			this.lblSeciliKoy.AutoSize = true;
			this.lblSeciliKoy.BackColor = System.Drawing.Color.Transparent;
			this.lblSeciliKoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSeciliKoy.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblSeciliKoy.Location = new System.Drawing.Point(30, 285);
			this.lblSeciliKoy.Name = "lblSeciliKoy";
			this.lblSeciliKoy.Size = new System.Drawing.Size(102, 16);
			this.lblSeciliKoy.TabIndex = 10;
			this.lblSeciliKoy.Text = "Seçilen Köy: -";
			// 
			// lblGerekenOgeler
			// 
			this.lblGerekenOgeler.AutoSize = true;
			this.lblGerekenOgeler.BackColor = System.Drawing.Color.Transparent;
			this.lblGerekenOgeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblGerekenOgeler.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblGerekenOgeler.Location = new System.Drawing.Point(30, 317);
			this.lblGerekenOgeler.Name = "lblGerekenOgeler";
			this.lblGerekenOgeler.Size = new System.Drawing.Size(130, 16);
			this.lblGerekenOgeler.TabIndex = 11;
			this.lblGerekenOgeler.Text = "Gereken Öğeler: -";
			// 
			// btnOgeleriKullan
			// 
			this.btnOgeleriKullan.Location = new System.Drawing.Point(30, 390);
			this.btnOgeleriKullan.Name = "btnOgeleriKullan";
			this.btnOgeleriKullan.Size = new System.Drawing.Size(150, 35);
			this.btnOgeleriKullan.TabIndex = 12;
			this.btnOgeleriKullan.Text = "Öğeleri Kullan";
			this.btnOgeleriKullan.Click += new System.EventHandler(this.btnOgeleriKullan_Click);
			// 
			// btnKurtar
			// 
			this.btnKurtar.Location = new System.Drawing.Point(200, 390);
			this.btnKurtar.Name = "btnKurtar";
			this.btnKurtar.Size = new System.Drawing.Size(150, 35);
			this.btnKurtar.TabIndex = 13;
			this.btnKurtar.Text = "Köyü Kurtar";
			this.btnKurtar.Click += new System.EventHandler(this.btnKurtar_Click);
			// 
			// lblDurum
			// 
			this.lblDurum.AutoSize = true;
			this.lblDurum.Location = new System.Drawing.Point(30, 440);
			this.lblDurum.Name = "lblDurum";
			this.lblDurum.Size = new System.Drawing.Size(0, 16);
			this.lblDurum.TabIndex = 14;
			// 
			// btnKoy1
			// 
			this.btnKoy1.Location = new System.Drawing.Point(0, 0);
			this.btnKoy1.Name = "btnKoy1";
			this.btnKoy1.Size = new System.Drawing.Size(75, 23);
			this.btnKoy1.TabIndex = 0;
			this.btnKoy1.Click += new System.EventHandler(this.btnKoy1_Click);
			// 
			// btnKoy2
			// 
			this.btnKoy2.Location = new System.Drawing.Point(0, 0);
			this.btnKoy2.Name = "btnKoy2";
			this.btnKoy2.Size = new System.Drawing.Size(75, 23);
			this.btnKoy2.TabIndex = 0;
			this.btnKoy2.Click += new System.EventHandler(this.btnKoy2_Click);
			// 
			// btnKoy3
			// 
			this.btnKoy3.Location = new System.Drawing.Point(0, 0);
			this.btnKoy3.Name = "btnKoy3";
			this.btnKoy3.Size = new System.Drawing.Size(75, 23);
			this.btnKoy3.TabIndex = 0;
			this.btnKoy3.Click += new System.EventHandler(this.btnKoy3_Click);
			// 
			// btnKoy4
			// 
			this.btnKoy4.Location = new System.Drawing.Point(0, 0);
			this.btnKoy4.Name = "btnKoy4";
			this.btnKoy4.Size = new System.Drawing.Size(75, 23);
			this.btnKoy4.TabIndex = 0;
			this.btnKoy4.Click += new System.EventHandler(this.btnKoy4_Click);
			// 
			// btnKoy5
			// 
			this.btnKoy5.Location = new System.Drawing.Point(0, 0);
			this.btnKoy5.Name = "btnKoy5";
			this.btnKoy5.Size = new System.Drawing.Size(75, 23);
			this.btnKoy5.TabIndex = 0;
			this.btnKoy5.Click += new System.EventHandler(this.btnKoy5_Click);
			// 
			// btnKoy6
			// 
			this.btnKoy6.Location = new System.Drawing.Point(0, 0);
			this.btnKoy6.Name = "btnKoy6";
			this.btnKoy6.Size = new System.Drawing.Size(75, 23);
			this.btnKoy6.TabIndex = 0;
			this.btnKoy6.Click += new System.EventHandler(this.btnKoy6_Click);
			// 
			// btnKoy7
			// 
			this.btnKoy7.Location = new System.Drawing.Point(0, 0);
			this.btnKoy7.Name = "btnKoy7";
			this.btnKoy7.Size = new System.Drawing.Size(75, 23);
			this.btnKoy7.TabIndex = 0;
			this.btnKoy7.Click += new System.EventHandler(this.btnKoy7_Click);
			// 
			// btnEsyaCikar
			// 
			this.btnEsyaCikar.Location = new System.Drawing.Point(370, 390);
			this.btnEsyaCikar.Name = "btnEsyaCikar";
			this.btnEsyaCikar.Size = new System.Drawing.Size(150, 35);
			this.btnEsyaCikar.TabIndex = 0;
			this.btnEsyaCikar.Text = "Eşya Çıkar";
			this.btnEsyaCikar.Click += new System.EventHandler(this.btnEsyaCikar_Click);
			// 
			// txtArama
			// 
			this.txtArama.Location = new System.Drawing.Point(588, 310);
			this.txtArama.Name = "txtArama";
			this.txtArama.Size = new System.Drawing.Size(130, 22);
			this.txtArama.TabIndex = 1;
			// 
			// btnAra
			// 
			this.btnAra.Location = new System.Drawing.Point(728, 309);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(60, 24);
			this.btnAra.TabIndex = 2;
			this.btnAra.Text = "Ara";
			this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
			// 
			// lstSirali
			// 
			this.lstSirali.ItemHeight = 16;
			this.lstSirali.Location = new System.Drawing.Point(588, 350);
			this.lstSirali.Name = "lstSirali";
			this.lstSirali.Size = new System.Drawing.Size(200, 116);
			this.lstSirali.TabIndex = 3;
			// 
			// lblKoyDurum
			// 
			this.lblKoyDurum.BackColor = System.Drawing.Color.Transparent;
			this.lblKoyDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblKoyDurum.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblKoyDurum.Location = new System.Drawing.Point(27, 478);
			this.lblKoyDurum.Name = "lblKoyDurum";
			this.lblKoyDurum.Size = new System.Drawing.Size(350, 20);
			this.lblKoyDurum.TabIndex = 4;
			this.lblKoyDurum.Text = "Köy Durumu:";
			// 
			// lblCantaDurum
			// 
			this.lblCantaDurum.Location = new System.Drawing.Point(30, 510);
			this.lblCantaDurum.Name = "lblCantaDurum";
			this.lblCantaDurum.Size = new System.Drawing.Size(350, 20);
			this.lblCantaDurum.TabIndex = 5;
			this.lblCantaDurum.Text = "Çanta Durumu:";
			// 
			// btnSifirla
			// 
			this.btnSifirla.Location = new System.Drawing.Point(370, 440);
			this.btnSifirla.Name = "btnSifirla";
			this.btnSifirla.Size = new System.Drawing.Size(150, 35);
			this.btnSifirla.TabIndex = 6;
			this.btnSifirla.Text = "Oyunu Sıfırla";
			this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
			// 
			// lblOduller
			// 
			this.lblOduller.AutoSize = true;
			this.lblOduller.BackColor = System.Drawing.Color.Transparent;
			this.lblOduller.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblOduller.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblOduller.Location = new System.Drawing.Point(30, 350);
			this.lblOduller.Name = "lblOduller";
			this.lblOduller.Size = new System.Drawing.Size(70, 16);
			this.lblOduller.TabIndex = 7;
			this.lblOduller.Text = "Ödüller: -";
			// 
			// btnIpucu
			// 
			this.btnIpucu.Location = new System.Drawing.Point(370, 341);
			this.btnIpucu.Name = "btnIpucu";
			this.btnIpucu.Size = new System.Drawing.Size(150, 35);
			this.btnIpucu.TabIndex = 8;
			this.btnIpucu.Text = "İpucu Al";
			this.btnIpucu.Click += new System.EventHandler(this.btnIpucu_Click);
			// 
			// lstCanta
			// 
			this.lstCanta.ItemHeight = 16;
			this.lstCanta.Location = new System.Drawing.Point(588, 28);
			this.lstCanta.Name = "lstCanta";
			this.lstCanta.Size = new System.Drawing.Size(200, 244);
			this.lstCanta.TabIndex = 9;
			// 
			// OyunFormu
			// 
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 500);
			this.Controls.Add(this.btnEsyaCikar);
			this.Controls.Add(this.txtArama);
			this.Controls.Add(this.btnAra);
			this.Controls.Add(this.lstSirali);
			this.Controls.Add(this.lblKoyDurum);
			this.Controls.Add(this.lblCantaDurum);
			this.Controls.Add(this.btnSifirla);
			this.Controls.Add(this.lblOduller);
			this.Controls.Add(this.btnIpucu);
			this.Controls.Add(this.lstCanta);
			this.Controls.Add(this.lblSeciliKoy);
			this.Controls.Add(this.lblGerekenOgeler);
			this.Controls.Add(this.btnOgeleriKullan);
			this.Controls.Add(this.btnKurtar);
			this.Controls.Add(this.lblDurum);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "OyunFormu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "🛡️ Yedi Köyün Kurtuluşu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label lblSeciliKoy;
		private System.Windows.Forms.Label lblGerekenOgeler;
		private System.Windows.Forms.Button btnOgeleriKullan;
		private System.Windows.Forms.Button btnKurtar;
		private System.Windows.Forms.Label lblDurum;
		private System.Windows.Forms.Button btnEsyaCikar;
		private System.Windows.Forms.TextBox txtArama;
		private System.Windows.Forms.Button btnAra;
		private System.Windows.Forms.ListBox lstSirali;
		private System.Windows.Forms.Label lblKoyDurum;
		private System.Windows.Forms.Label lblCantaDurum;
		private System.Windows.Forms.Button btnSifirla;
		private System.Windows.Forms.Label lblOduller;
		private System.Windows.Forms.Button btnIpucu;
		private ListBox lstCanta;






		private System.Windows.Forms.Button btnKoy1;
		private System.Windows.Forms.Button btnKoy2;
		private System.Windows.Forms.Button btnKoy3;
		private System.Windows.Forms.Button btnKoy4;
		private System.Windows.Forms.Button btnKoy5;
		private System.Windows.Forms.Button btnKoy6;
		private System.Windows.Forms.Button btnKoy7;

	}
}

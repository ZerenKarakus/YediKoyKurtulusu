using System.Collections.Generic;

namespace YediKoyunKurtulusu
{
	public class OyunVerisi
	{
		public List<Koy> Koyler { get; private set; }
		public Queue<Koy> KoyKuyrugu { get; private set; }
		public Canta Canta { get; private set; }

		public OyunVerisi()
		{
			Canta = new Canta();
			KoyleriOlustur();
			CantaBaslangicOgeleri();
		}

		private void KoyleriOlustur()
		{
			Koyler = new List<Koy>
			{
				new Koy("Ascent Koyu", new List<string> { "Kılıç", "Yiyecek" }, new List<string> { "Harita", "İksir", "Zırh","Kalkan" }),
				new Koy("İcebox Koyu", new List<string> { "İksir", "Harita" }, new List<string> { "Balta", "Yiyecek", "Bıçak","Bıçak"}),
				new Koy("Pearl Koyu", new List<string> { "Balta", "Yiyecek" }, new List<string> { "Kalkan", "Altın", "Zırh" }),
				new Koy("Split Koyu", new List<string> { "Kalkan", "Altın" }, new List<string> { "Balta", "İksir", "Tılsım", "Meşale" }),
				new Koy("Breeze Koyu", new List<string> { "Balta", "İksir" }, new List<string> { "Kalkan", "Meşale", "Şifa" }),
				new Koy("Fracture Koyu", new List<string> { "Meşale", "Kalkan" }, new List<string> { "Kılıç", "İksir", "Harita"}),
				new Koy("Sunset Koyu", new List<string> { "Kılıç", "İksir", "Harita" }, new List<string> {"Büyülü Taş", "Zırh"})
			};

			KoyKuyrugu = new Queue<Koy>(Koyler); // sırayla ekleniyor
		}

		private void CantaBaslangicOgeleri()
		{
			Canta.Ekle("Kılıç");
			Canta.Ekle("Yiyecek");
			Canta.Ekle("İksir");
			Canta.Ekle("Harita");
		}

		public Koy SiradakiKoy()
		{
			return KoyKuyrugu.Count > 0 ? KoyKuyrugu.Peek() : null;
		}

		public void KoyKurtarildi()
		{
			if (KoyKuyrugu.Count > 0)
				KoyKuyrugu.Dequeue(); // sıradaki köy çıkar
		}

		public Koy KoyBul(string ad)
		{
			return Koyler.Find(k => k.Ad == ad);
		}

		public List<Koy> KurtarilmayanKoyleriGetir()
		{
			return Koyler.FindAll(k => !k.KurtarildiMi);
		}
	}
}

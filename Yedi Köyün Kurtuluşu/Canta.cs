using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace YediKoyunKurtulusu
{
	public class Canta
	{
		private LinkedList<string> ogeler;
		private const int maksimumKapasite = 10;

		public Canta()
		{
			ogeler = new LinkedList<string>();
		}

		public bool Ekle(string oge)
		{
			if (ogeler.Count >= maksimumKapasite)
			{
				// Otomatik olarak ilk öğeyi çıkar
				string cikan = ogeler.First.Value;
				ogeler.RemoveFirst();
				MessageBox.Show($"Çanta doluydu, '{cikan}' otomatik çıkarıldı.");
			}

			ogeler.AddLast(oge);
			return true;
		}

		public bool Cikar(string oge)
		{
			if (ogeler.Contains(oge))
			{
				ogeler.Remove(oge);
				return true;
			}
			else
			{
				MessageBox.Show("Bu oğe çantada yok.");
				return false;
			}
		}

		public bool VarMi(string oge)
		{
			return ogeler.Contains(oge);
		}

		public List<string> OgeleriListele()
		{
			return new List<string>(ogeler);
		}

		public void Temizle()
		{
			ogeler.Clear();
		}

		public int MevcutSayisi()
		{
			return ogeler.Count;
		}



	}
}

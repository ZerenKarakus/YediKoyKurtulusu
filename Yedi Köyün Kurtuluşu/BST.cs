using System;
using System.Collections.Generic;

namespace YediKoyunKurtulusu
{
	public class BST
	{
		public BSTNode Kok;

		public void Ekle(string veri)
		{
			Kok = EkleRec(Kok, veri);
		}

		private BSTNode EkleRec(BSTNode node, string veri)
		{
			if (node == null) return new BSTNode(veri);

			int karsilastir = string.Compare(veri, node.Veri, true);
			if (karsilastir < 0)
				node.Sol = EkleRec(node.Sol, veri);
			else if (karsilastir > 0)
				node.Sag = EkleRec(node.Sag, veri);

			return node;
		}

		public bool Ara(string veri)
		{
			return AraRec(Kok, veri);
		}

		private bool AraRec(BSTNode node, string veri)
		{
			if (node == null) return false;

			int karsilastir = string.Compare(veri, node.Veri, true);
			if (karsilastir == 0) return true;
			if (karsilastir < 0) return AraRec(node.Sol, veri);
			return AraRec(node.Sag, veri);
		}

		public List<string> InOrder()
		{
			List<string> liste = new List<string>();
			InOrderRec(Kok, liste);
			return liste;
		}

		private void InOrderRec(BSTNode node, List<string> liste)
		{
			if (node != null)
			{
				InOrderRec(node.Sol, liste);
				liste.Add(node.Veri);
				InOrderRec(node.Sag, liste);
			}
		}
	}
}

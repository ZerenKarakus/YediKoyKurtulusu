using System.Collections.Generic;

public class Koy
{
	public string Ad { get; set; }
	public List<string> GerekenOgeler { get; set; }
	public List<string> Oduller { get; set; }
	public bool KurtarildiMi { get; set; }

	public Koy(string ad, List<string> gerekenOgeler, List<string> oduller)
	{
		Ad = ad;
		GerekenOgeler = gerekenOgeler;
		Oduller = oduller;
		KurtarildiMi = false;
	}
}

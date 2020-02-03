using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.WINUI.CustomTools
{
    public static class Crypto
    {
		
		public static string Sifrele(string sifre)
		{
			string veri = sifre;  //Girilen veri tipimizi saklayacak değişkeni oluşturuyoruz.
			string cryptedText = string.Empty; //Eventin her tetiklenmesinde üzerine yazılmamasını önleyip, döngü dışında değişkenimizi oluşturuyoruz.
			List<char> charText = veri.ToCharArray().ToList(); //Girilen veriyi char tabanlı açtığımız charText listesine kısa yoldan çeviriyoruz.
			for (int i = 0; i < charText.Count; i++) //Diziyi kontrol edicek döngüyü oluşturuyoruz.
			{
				cryptedText += (char)(charText[i] + 7); //Döngü dışında tuttuğumuz değişkenimize girilen verinin, char dizisinde karşılık olarak gelen karakter indexini 7 artırarak, ulaştığımız son karakterin değişkenimize ekleyen kod ifadesi.
			}
			return sifre = (cryptedText); //Cryptolu metni yazdır.
		}

		public static string SifreCoz(string sifre)
		{
			string veri = sifre;
			string cryptedText = string.Empty;
			List<char> charText = veri.ToCharArray().ToList();
			for (int i = 0; i < charText.Count; i++)
			{
				cryptedText += (char)(charText[i] - 7);
			}
			return sifre = (cryptedText);
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRYLİST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciSecim = string.Empty;
            ArrayList degerlistesi= new ArrayList(); 
            do
            {
                Console.Clear();
                Console.WriteLine("Menü");
                Console.WriteLine("1 - Değer Ekle");
                Console.WriteLine("2 - Değerler Listele");
                Console.WriteLine("3 - Değer Ara");
                Console.WriteLine("4 - Değer Düzenle");
                Console.WriteLine("5 - Değer Sil");
                Console.WriteLine("6 - Uygulama Çıkış");
                Console.Write("Bir değer giriniz: ");
                kullaniciSecim = Console.ReadLine();
            
                switch (kullaniciSecim)
                {
                    case "1":
                        Console.Write("Lütfen eklemek istediğniz değeri giriniz");
                        string kullaniciDeger = Console.ReadLine();
                        degerlistesi.Add(kullaniciDeger);
                        Console.WriteLine("Değeriniz başarılı bir şekilde eklendi");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "2":
                        for (int i =0; i < degerlistesi.Count; i++)
                        {
                            Console.WriteLine("{0}. Değer = {1}", i, degerlistesi[i]);
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basınız.");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Aramak istediğiniz değeri giriniz");
                        string kullaniciAramaDeger = Console.ReadLine();        
                        bool kontrol = degerlistesi.Contains(kullaniciAramaDeger);
                        if(kontrol)
                        {
                            int bulunanIndex= degerlistesi.IndexOf(kullaniciAramaDeger);
                            string bulunanDeger = degerlistesi[bulunanIndex].ToString();                            
                            Console.WriteLine("Değeriniz bulundu : index sırası : {0} - Değer : (1)",bulunanIndex, bulunanDeger);
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız kriterlerde bir değer bulunamadı");
                            Console.WriteLine("girdiğiniz değeri listeye eklemek isteri misiniz? (E/H)");

                            string kullaniciEkleCevap = Console.ReadLine();

                            if (kullaniciEkleCevap.ToUpper() == "E")
                            {
                                degerlistesi.Add(kullaniciAramaDeger);
                                Console.WriteLine("Değeriniz başarılı bir şekilde eklendi");
                                System.Threading.Thread.Sleep(2000);
                            }
                          
                            //eğer aradığı kriterlerde değer bulamadı ise kullanıcıya bu değeri listeye ekleyelim mi olarak sorun eğer kullanıcı evet derse listeye ekleyin
                        }
                        System.Threading.Thread.Sleep(2000);
                        break;
                    
                  
                    case "4":

                        Console.WriteLine("Güncellemek istediğiniz değeri giriniz");
                        string kullaniciDuzenlenecekDeger = Console.ReadLine();

                        Console.WriteLine("{0} değerini hangi değer ile güncellemek istiyorsunuz ", kullaniciDuzenlenecekDeger);
                        string kullaniciYeniDeger = Console.ReadLine();

                        if(degerlistesi.Contains(kullaniciDuzenlenecekDeger))
                        {
                            int kullaniciHedefİndex = degerlistesi.IndexOf(kullaniciDuzenlenecekDeger);
                            degerlistesi[kullaniciHedefİndex] =  kullaniciYeniDeger;
                            Console.WriteLine("Değeriniz güncellendi");
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız Değer Liste İcerisinde Bulunamadı.");
                        }

                        System.Threading.Thread.Sleep(2000);
              
                        break;
                    case "5":
                        Console.WriteLine("Tüm değerleri mi silmek istiyorsunuz? (E/H)");
                        string kullaniciSilCevap = Console.ReadLine();

                        if(kullaniciSilCevap.ToUpper() == "E")
                        {
                            degerlistesi.Clear();
                            Console.WriteLine("Tüm değerler silindi");
                        }
                        else
                        {
                            Console.WriteLine("Liste içerisinden silmek istediğiniz değeri giriniz.");
                            string kullanicisildeger = Console.ReadLine();
                            if(degerlistesi.Contains(kullanicisildeger))
                            {
                                degerlistesi.Remove(kullanicisildeger);
                                Console.WriteLine("değeriniz silindi");
                            }
                            else
                            {
                                Console.WriteLine("silmek istediğiniz değer liste içerisinde mevcut değil");
                            }
                        }


                        break;
                    default:
                        break;
                }
            } while (kullaniciSecim != "6");
        }
    }
}

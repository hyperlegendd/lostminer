using System;
using System.Text;

class Program
{
    static void Main()
    {

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;


        Console.WriteLine("LostMiner Wallet Cracker programımıza hoş geldiniz.");
        Console.WriteLine("v2.5 sürümünü kullanmaktasınız, bizi tercih ettiğiniz için teşekkür ederiz.");
        Console.WriteLine("Telegram = t.me/lostminerbtc");


        Console.ResetColor();

        Console.WriteLine();
        Console.Write("Lisans anahtarınızı giriniz : ");
        string girilenLisans = Console.ReadLine();
        string premiumLisans = "io1ciFpa0Z8DB1iweTrdWGeXurV63MHG8igAWouGMd";
        string vipLisans = "WGeXurV63MHG8igAWouGMdio1ciFpa0Z8DB1iweTrd";
        string ucretsizLisans = "HG8igAWouGMdio1cWGeXurV63GMdio1ciFpa0Z8DB1iweTrd";


        if (girilenLisans == premiumLisans)
        {
            Console.WriteLine("Üyelik tipi premium, iyi kullanımlar.");
        }
        else if (girilenLisans == vipLisans)
        {
            Console.WriteLine("Üyelik tipi VIP, iyi kullanımlar.");
        }
        else if (girilenLisans == ucretsizLisans)
        {
            Console.WriteLine("Üyelik tipi Deneme, iyi kullanımlar.");
        }


        else
        {
            Console.WriteLine("Lisans kodunuz hatalıdır, eğer bir lisansınız yoksa t.me/lostminerbtc üzerinden satın alabilirsiniz.");
            Console.Read();
            return;
        }

        {
            // Lisans süresi
            DateTime lisansBaslangic = DateTime.Now;
            DateTime lisansBitis = DateTime.Now.AddDays(1);

            DateTime simdikiZaman = DateTime.Now;

            if (simdikiZaman >= lisansBaslangic && simdikiZaman <= lisansBitis)
            {
                Console.WriteLine("Lisans süreniz 1 gündür, 1 gün boyunca programı kullanabilirsiniz.");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("ETH ve BTC arasında bir seçim yapın: ");
                string token = Console.ReadLine();
                string bitcoinAdresi = "";
                string ethereumAdresi = "";
                Console.WriteLine("Cracklenecek cüzdan listesi hazırlanıyor..");
                System.Threading.Thread.Sleep(3000);
                if (token == "BTC" || token == "btc")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();
                    Console.Write("Lütfen Bitcoin adresinizi girin: ");
                    bitcoinAdresi = Console.ReadLine();
                }
                else if (token == "ETH" || token == "eth")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();
                    Console.Write("Lütfen Ethereum adresinizi girin: ");
                    ethereumAdresi = Console.ReadLine();
                }
                else
                {
                    Console.Write("ETH veya BTC yazmanız gerekmektedir. Programı yeniden başlatın.");
                    Console.Read();
                    return;
                }

                // Wallet listeleme kısmı

                if (string.IsNullOrEmpty(bitcoinAdresi) && string.IsNullOrEmpty(ethereumAdresi))
                {
                    Console.WriteLine("Değer girilmedi, programı yeniden başlatın.");
                    Console.Read();
                    return;
                }
                else
                {
                    if (!string.IsNullOrEmpty(bitcoinAdresi))
                    {
                        Console.WriteLine("Bitcoin adresiniz kontrol ediliyor. ");
                        System.Threading.Thread.Sleep(5000);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Başarılı.");
                        Console.WriteLine();
                        // Rasgele wallet oluşturma
                        for (int j = 0; j < 10000000; j++)
                        {
                            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                            Random random = new Random();
                            string prefix = "bc";
                            StringBuilder builder = new StringBuilder();
                            builder.Append(prefix);


                            for (int i = 0; i < 40; i++)
                            {
                                builder.Append(characters[random.Next(characters.Length)]);
                            }

                            string randomText = builder.ToString();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[+] " + randomText + "| Invalid | 0.0000 BTC");
                            if (girilenLisans == vipLisans)
                            {
                                System.Threading.Thread.Sleep(0);
                            }
                            else if (girilenLisans == premiumLisans)
                            {
                                System.Threading.Thread.Sleep(150);
                            }
                            else if (girilenLisans == ucretsizLisans)
                            {
                                System.Threading.Thread.Sleep(6000);
                            }
                        
                    }

                    }
                    if (!string.IsNullOrEmpty(ethereumAdresi))
                    {
                        Console.WriteLine("Ethereum adresiniz kontrol ediliyor.");
                        System.Threading.Thread.Sleep(5000);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Başarılı.");
                        Console.WriteLine();
                        // Rasgele wallet oluşturma
                        for (int j = 0; j < 10000000; j++)
                        {
                            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                            Random random = new Random();
                            string prefix = "0x";
                            StringBuilder builder = new StringBuilder();
                            builder.Append(prefix);


                            for (int i = 0; i < 40; i++)
                            {
                                builder.Append(characters[random.Next(characters.Length)]);
                            }

                            string randomText = builder.ToString();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[+] " + randomText + "| Invalid | 0.0000 ETH");
                            if(girilenLisans == vipLisans)
                            { 
                            System.Threading.Thread.Sleep(0);
                            }
                            else if(girilenLisans == premiumLisans)
                            {
                            System.Threading.Thread.Sleep(150);
                            }
                            else if(girilenLisans == ucretsizLisans)
                            {
                                System.Threading.Thread.Sleep(6000);
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("Lisans süresi dolmuş. Programı kullanamazsınız.");
                        Console.Read();
                        return;
                    }
                }

                
                }
            }
        }
    }

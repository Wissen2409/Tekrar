
// bugünden, aynı 6 sayı ile , sayısal oynarsak, kaç yıl sonra 4,5,6 tuttururuz.

// tarih zaman olayları için datetime kullanıyoruz.



/*int[] kullanici = {12,44,35,23,7,10};
int[] random = new int[6];

DateTime zaman = DateTime.Now;
Random rnd = new Random();
int week=0;
// 6 bilmenin ne kadar süre alacağını bilmediğim için, sonsuz döngü yapıyorum
for(;;){

    week+=7;
    
    System.Threading.Thread.Sleep(500);
    Console.WriteLine("{0} tarihindeki çekiliş",DateTime.Now.AddDays(week).ToLongDateString());
    int bilinen = 0;
    // her döngüde, 6 adet random değer üretip, dizi içerisine yerleştirelim
    for(int i=0;i<random.Length;i++){

        random[i] = rnd.Next(1,49);
    }
    // Tahminler diziye dolduruldu

    for(int i =0;i<random.Length;i++){

        for(int j=0;j<random.Length;j++){

            // bu oyunda, tahmin basamakları farketmeksizin sayı bilinmiş oluyor.
            // dolayısıyla iki dizi kartezyen karşılaştırılmalıdır.

            // iki 6 elemanlı dizinin 36 kez karşılaştırılması gerekmektedir.

            // bunun için iç içe iki adet dizi kullanılmıştır.
            if(random[i]==kullanici[j]){

                bilinen++;
                if(bilinen==5){
                    Console.WriteLine("5 bilindi");
                }
                else if(bilinen==6){
                    Console.WriteLine("6 bilindi");
                    break;
                }

            }
        }

    }
    Console.WriteLine("Bu hafta bilinen sayı adedi : {0}",bilinen);
}*/

int rakam = int.Parse(Console.ReadLine());



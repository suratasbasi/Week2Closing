
//1.SORU
 Console.WriteLine("Merhaba\nNasılsın?\nİyiyim\nSen nasılsın?");



//2.SORU
string mevsim = "yaz";
int km = 10;
Console.WriteLine(mevsim);
Console.WriteLine(km);



//3.SORU
Random random = new Random();
int rastgele = random.Next();
Console.WriteLine("Rastgele bir sayı: " + rastgele);



//4.SORU
Random rnd = new Random();
int rastgele2 = rnd.Next();
int kalan = rastgele2 % 3;
Console.WriteLine(rastgele2 + " sayısının 3'e bölümünden kalan: " + kalan);



//5.SORU
Console.WriteLine("Lütfen yaşınızı giriniz.");
int yas = Convert.ToInt32(Console.ReadLine());

if (yas > 18)
    Console.WriteLine("+");
else
    Console.WriteLine("-");



//6.SORU
for (int i = 0; i < 10; i++)
    Console.WriteLine(" Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");



//7.SORU
Console.WriteLine("'Gülse Birsel' yazınız.");
string metin1 = Console.ReadLine();
Console.WriteLine("'Demet Evgar' yazınız.");
string metin2 = Console.ReadLine();

Console.WriteLine("1. Metin: " + metin1 + "\n2. Metin: " + metin2);

string temp = metin1;
metin1 = metin2;
metin2 = temp;

Console.WriteLine("Metinlerin yerleri değiştirilmiştir. \n1. Metin: " + metin1 + "\n2. Metin: " + metin2);



//8.SORU
static void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
BenDegerDondurmem();



//9.SORU
int IkiSayiToplami(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}

int toplam = IkiSayiToplami(2, 777);
Console.WriteLine(" '2' ve '777' sayılarının toplamı: " + toplam);



//10.SORU
Console.WriteLine("Lütfen ''true'' ya da ''false'' yazınız.");
bool giris = Convert.ToBoolean(Console.ReadLine());
string donus = TrueFalse(giris);

static string TrueFalse(bool giris)
{
    if (giris)
        return "true";
    else
        return "false";
}



//11.SORU
Console.WriteLine("1. kişinin yaşını yazınız.");
int yas1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. kişinin yaşını yazınız.");
int yas2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3. kişinin yaşını yazınız.");
int yas3 = Convert.ToInt32(Console.ReadLine());

int enYasli = EnYasliYas(yas1, yas2, yas3);

int EnYasliYas(int yas1, int yas2, int yas3)
{
    int enYasli = yas1;
    if (yas2 > enYasli)
        enYasli = yas2;
    if (yas3 > enYasli)
        enYasli = yas3;

    return enYasli;
}

Console.WriteLine("En yaşlı olanın yaşı: " + enYasli);



//12.SORU (en sona yazdım)



//13.SORU
Console.WriteLine("Lütfen bir isim giriniz: ");
string isim1 = Console.ReadLine();
Console.WriteLine("Lütfen ikinci bir isim giriniz: ");
string isim2 = Console.ReadLine();

IsimDegistir(ref isim1, ref isim2);
static void IsimDegistir(ref string isim1, ref string isim2)
{
    string temp = isim1;
    isim1 = isim2;
    isim2 = temp;
}

Console.WriteLine("İlk isim: " + isim1);
Console.WriteLine("İkinci isim: " + isim2);



//14.SORU
Console.WriteLine("Bir sayı giriniz.");
int sayi = Convert.ToInt32(Console.ReadLine());

bool sonuc = CiftMi(sayi);

if (sonuc)
    Console.WriteLine("Girmiş olduğunuz sayı çift sayıdır");
else
    Console.WriteLine("Girmiş olduğunuz sayı tek sayıdır");

static bool CiftMi(int sayi)
{
    return sayi % 2 == 0;
}



//15.SORU
Console.WriteLine("Kaç km hız yaptınız?");
double hiz = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ne kadar süre(saat) yaptınız?");
double zaman = Convert.ToDouble(Console.ReadLine());

double yol = GidilenYol(hiz, zaman);

Console.WriteLine("Gidilen toplam yol: " + yol + " km");

static double GidilenYol(double hiz, double zaman)
{
    return hiz * zaman;
}



//16.SORU
void DaireninAlaniniHesaplama(double yariCap)
{
    double alan = Math.PI * Math.Pow(yariCap, 2);

    Console.WriteLine("Yarıçapı 10 olan dairenin alanı: " + alan);
}
DaireninAlaniniHesaplama(10);



//17.SORU
string metin = "Zaman bir GeRi SayIm";

Console.WriteLine(metin.ToUpper());
Console.WriteLine(metin.ToLower());



//18.SORU
string mesaj = "    Selamlar   ";
Console.WriteLine(mesaj.Trim());



//12.SORU (Hocanın cevabı)
void EnBuyukDegeriBulma()
{
    Console.WriteLine("İstediğiniz adette sayı değeri girin:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    int max = int.MinValue;

    while (true)
    {
        Console.WriteLine("Sayı: ");
        bool uygunMu = int.TryParse(Console.ReadLine(), out sayi);

        if (uygunMu)
        {
            if (sayi > max)
                max = sayi;
        }
        else
        {
            Console.WriteLine("Yanlış formatta veri girişi yaptınız.");
        }

        if (max == int.MinValue)
            Console.WriteLine("Henüz geçerli bir sayı değeri girilmedi.");
        else
            Console.WriteLine("En büyük sayı: " + max);
    }
}
EnBuyukDegeriBulma();

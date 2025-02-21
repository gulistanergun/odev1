


// 1. SORU 
Console.Write("Kontrol edilecek sayıyı giriniz: ");
double sayi = Convert.ToDouble(Console.ReadLine());


if (sayi > 0)
{
    Console.WriteLine($"Kontrol edilen '{sayi}' sayısı pozitif.");
}
else if (sayi < 0)
{
    Console.WriteLine($"Kontrol edilen '{sayi}' sayısı negatif.");
}
else
{
    Console.WriteLine("Kontrol edilen sayı sıfırdır.");
}

///////////////////////////////////////////////////////////////////////////////////////////
/*
// 2. SORU 
Console.Write(" Belirlenecek gün sırasını girin: ");

int gunSirasi = Convert.ToInt32(Console.ReadLine());

switch (gunSirasi)
{
    case 1:
        Console.WriteLine("1. gün Pazartesi");
        break;
    case 2:
        Console.WriteLine("2. gün Salı");
        break;
    case 3:
        Console.WriteLine("3. gün Çarşamba");
        break;
    case 4:
        Console.WriteLine("4. gün Perşembe");
        break;
    case 5:
        Console.WriteLine("5. gün Cuma");
        break;
    case 6:
        Console.WriteLine("6. gün Cumartesi");
        break;
    case 7:
        Console.WriteLine("7. gün Pazar");
        break;
    default:
        Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen 1-7 arasında bir sayı girin.");
        break;
}*/

///////////////////////////////////////////////////////////////////////////////////////////
/*
// 3. SORU
Console.WriteLine("işlem yapmak istediğiniz sayıları girin");
Console.Write("Birinci sayıyı gir: ");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.Write("İkinci sayıyı gir: ");
double sayi2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
Console.WriteLine("1 - Toplama");
Console.WriteLine("2 - Çıkarma");
Console.WriteLine("3 - Çarpma");
Console.WriteLine("4 - Bölme");
Console.Write("Seçiminizi yapın (1/2/3/4): ");
int secim = Convert.ToInt32(Console.ReadLine());


double sonuc;

switch (secim)
{
    case 1:
        sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplama işlemi: " + sonuc);
        break;
    case 2:
        sonuc = sayi1 - sayi2;
        Console.WriteLine("Çıkarma işlemi: " + sonuc);
        break;
    case 3:
        sonuc = sayi1 * sayi2;
        Console.WriteLine("Çarpma işlemi: " + sonuc);
        break;
    case 4:

        if (sayi2 != 0)
        {
            sonuc = sayi1 / sayi2;
            Console.WriteLine("Bölme işlemi: " + sonuc);
        }
        else
        {
            Console.WriteLine("Hata! Sıfıra bölme olmaz.");
        }
        break;
    default:
        Console.WriteLine("Geçersiz seçim! Lütfen 1, 2, 3 veya 4 girin.");
        break;
}
*/
///////////////////////////////////////////////////////////////////////////////////////////
/*
// 4.SORU

Console.Write("Birinci sayıyı girin: ");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.Write("İkinci sayıyı girin: ");
double sayi2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Üçüncü sayıyı girin: ");
double sayi3 = Convert.ToDouble(Console.ReadLine());

double enBuyuk;

if (sayi1 >= sayi2 && sayi1 >= sayi3)
{
    enBuyuk = sayi1;
}
else if (sayi2 >= sayi1 && sayi2 >= sayi3)
{
    enBuyuk = sayi2;
}
else
{
    enBuyuk = sayi3;
}

Console.WriteLine("En büyük sayı: " + enBuyuk);
*/
///////////////////////////////////////////////////////////////////////////////////////////


// 5. SORU 

/*
Console.Write("Kontrol edilecek şifreyi girin: ");
string sifre = Console.ReadLine();

//koşul kontrollerib 
bool uzunlukUygunMu = sifre.Length >= 8;
bool buyukHarfVarMi = false;
bool ozelKarakterVarMi = false;

string ozelKarakter = "@#$%";

foreach (char karakter in sifre)
{
    if (char.IsUpper(karakter))
        buyukHarfVarMi = true;

    if (ozelKarakter.Contains(karakter))
        ozelKarakterVarMi = true;
}


if (uzunlukUygunMu && buyukHarfVarMi && ozelKarakterVarMi)
{
    Console.WriteLine("Güçlü şifre");
}
else
{
    Console.WriteLine("Şifre güçlü değil,  koşulları kontrol ediniz");
    if (!uzunlukUygunMu) Console.WriteLine("- Şifre en az 8 karakter uzunluğunda olmalı.");
    if (!buyukHarfVarMi) Console.WriteLine("- Şifre en az bir büyük harf içermeli.");
    if (!ozelKarakterVarMi) Console.WriteLine("- Şifre en az bir özel karakter içermeli (@, #, $, %).");
}



*/
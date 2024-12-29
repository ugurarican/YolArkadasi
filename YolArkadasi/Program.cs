Console.WriteLine("Yol Arkadaşı Uygulamasına Hoşgeldiniz.");
Console.WriteLine("Bu uygulamada amacımız size 3 günlük tatil boyuncaki harcamanızı yaklaşık olarak tahmin etmek.");
Console.WriteLine("Hangi lokasyonda tatil yaapmak istiyorsunuz ?");
Console.WriteLine("Lütfen alttaki seçenelrdenden birini yazınız.");
Console.WriteLine("1-> Bodrum");
Console.WriteLine("2-> Marmaris");
Console.WriteLine("3-> Çeşme");

// Evrana girilen değeri proince değişkenine hepsini büyük harf yazarak attım.
string province = Console.ReadLine().ToUpper();
int wallet = 0;
bool validLocation = false;

while (!validLocation)
{
    if (province == "BODRUM")
    {
        wallet = 4000;
        validLocation = true;
    }
    else if (province == "MARMARİS")
    {
        wallet = 3000;
        validLocation = true;
    }
    else if (province == "ÇEŞME")
    {
        wallet = 5000;
        validLocation = true;
    }
    else
    {
        Console.WriteLine("Bir hata oluştu.");
        province = Console.ReadLine().ToUpper();
    }
}
Console.WriteLine("Kaç kişi için tatil planlıyorsun?");
int person = 0;
bool validPerson = false;

//Kullanıcı geçerli kişi sayısı girene kadar döngüde kalsın.
while (!validPerson)
{
    string input = Console.ReadLine();
    if(int.TryParse(input, out person) && person >0)
            {
        validPerson = true;
    }
    else
    {
        Console.WriteLine("Geçersiz giriş!");
        Console.WriteLine("Kaç kişi için tatil planlıyorsun?");
    }
}

Console.WriteLine("Tatile ne şekilde girmek istiyorsun?");
Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
Console.WriteLine("Lütfen yukarıdaki seçenelerden bir tanesini seçiniz.");
string road = Console.ReadLine();

bool validRoad = false;
while (!validRoad) {
    if (road == "1")
    {
        wallet += 1500 * person;
        validRoad = true;
    }
    else if (road == "2")
    {
        wallet += 4000 * person;
        validRoad = true;
    }
    else
    {
        Console.WriteLine("Geçersiz giriş!");
        Console.WriteLine("Lütfen yukarıdaki seçenelerden bir tanesini seçiniz.");
    }
}
// Sonuç
Console.WriteLine($"Seçilen lokasyon: {province}");
Console.WriteLine($"Kişi başı maliyet: {wallet/person}");
Console.WriteLine($"Toplam maliyet({person} kişi için): {wallet} TL");
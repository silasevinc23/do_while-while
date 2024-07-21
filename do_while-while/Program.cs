Console.Write("Lütfen bir sayı giriniz :");
int sayi = Convert.ToInt32(Console.ReadLine());

int i = 0;
while (i <= sayi)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    i++;


}

// while önce koşulu kontrol ederken,do-while önce bir kere çalıştırıp sonra koşulu kontrol ediyor.Bu örnekte örneğin negatif sayı girildiğinde 
//koşulu sağlamayacağından while ile çalıştırıldığında ekrana hiçbir şey yazdırılmaz.do-while ile çalıştırılırsa koşulu sağlamamasına rağmen 
//bir kere ekranda "Ben bir Patika'lıyım" yazılır.



//Console.Write("Lütfen bir sayı giriniz :");
//int sayi = Convert.ToInt32(Console.ReadLine());
//int i = 0;
//do
//{
//    Console.WriteLine("Ben bir Patika'lıyım");
//    i++;

//} while (i <= sayi);


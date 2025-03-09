namespace ConsoleApp1
{
    class Loops 
    {
        static void Main()
        {

        //Birinci Soru  
        int number = 12345;
        string numberStr = number.ToString();
        int[] digits = new int[numberStr.Length];
        int sum ;

        for (int i = 0; i < numberStr.Length; i++)
        {
            digits[i] = numberStr[i] - '0'; 
        }

        foreach (var digit in digits)
        {
            //sum += digit;

        }
    


        //İkinci Soru

        bool nextquestion = false;
        while (nextquestion)
        {
            Console.WriteLine("Lütfen sayı giriniz");
            int numberTwo = int.Parse(Console.ReadLine());
            if (  numberTwo > 10 && numberTwo < 100)
            {
                nextquestion = true;
            }
            else
            {
                nextquestion = false;
            }
        }

        //Üçüncü Soru


        List<int> Ages = new List<int> {};

        for (int i = 1; i <= 10; i++)
        {

            Console.WriteLine("Sayı Giriniz");
            Ages.Add(int.Parse(Console.ReadLine()));

        }

        foreach (int yas in Ages)
        {
            string kategori;

            if (yas >= 0 && yas <= 12)
                kategori = "Çocuk";
            else if (yas >= 13 && yas <= 19)
                kategori = "Genç";
            else if (yas >= 20 && yas <= 64)
                kategori = "Yetişkin";
            else
                kategori = "Yaşlı";

            Console.WriteLine($"Yaş: {yas}, Kategori: {kategori}");
        }

        //Dördüncü Soru
        
        int[] LoopArray = { 1, 2, 3, 4, 5, 2, 3, 6, 7, 8, 1, 9, 5, 5 };
        Dictionary<int, int> RepeatDic = new Dictionary<int, int>();

        foreach (int element in LoopArray)
        {
            if (RepeatDic.ContainsKey(element))
                RepeatDic[element]++;
            else
                RepeatDic[element] = 1;
        }

        Console.WriteLine("Tekrar eden elemanlar:");
        foreach (var eleman in RepeatDic)
        {
            if (eleman.Value > 1)
                Console.WriteLine($"Eleman: {eleman.Key}, Tekrar Sayısı: {eleman.Value}");
        


        }

        //Beşinci Soru

        string[] words = { "Ali", "Veli", "Ahmet", "Mehmet", "Ayşe", "Fatma" };
        string shortestWord = words[0];
        string longestWord = words[0];

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
                longestWord = word;
            if (word.Length < shortestWord.Length)
                shortestWord = word;
        }

        Console.WriteLine($"En uzun kelime: {longestWord}");
        Console.WriteLine($"En kısa kelime: {shortestWord}");

        //Altıncı Soru


        Console.WriteLine("Lütfen bir cümle giriniz:");
        string sentence = Console.ReadLine();
        string[] words2 = sentence.Split(' ');
        Array.Sort(words2);

        Console.WriteLine("Sıralanmış kelimeler:");
        foreach (string word in words2)
        {
            Console.WriteLine(word);
        }
        

        // bu ödevin hepsini yapamadım.





        //--------------------------------------------------------------------------------
        // Sözel Soru Cevapları
        // Metod Nedir ? : 
        // Metodlar bir kod bloğunu adlandırarak tekrar kullnabilmemize olanak sağlar
        // Metodları Neden Kullanırız ? : 
        // Metodları tekrar eden işlemlerde sonrada değişiklik yapmak istediğimizde tekrar tekrar aynı işlemi yapmamak için kullanırız
        // Geriye değer döndüren (return kullanan) metot ile void metot arasındaki fark nedir?
        // Geriye değer döndüren metotlar return ile değer döndürür ve bu değeri başka bir değişkene atayabiliriz. Void metotlar ise değer değer döndürmezler.
        // Metotların parametreleri nasıl çalışır?
        // Metotlar parametre alabilirler ve bu parametreler metotun içinde kullanılabilirler. Bu sayede metodu çağırırken içine değer gönderebiliriz.
        // --------------------------------------------------------------------------------------------


        }

    }
}
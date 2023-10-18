namespace Task3_ValueAndRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            // wrong version:
            //int[] array1;
            //modulus(ref array1);

            // right way:
            int[] array2 = { -1 };
            modulus(ref array2);
            Console.WriteLine(array2[0]);

            // 2.
            /* 
            keyword "in" - "ref" və "out"-dan çox fərqlənmir. 
            Əgər "out" arqumenti mütləq blok içərisində dəyişməli,
            "ref" dəyişə bilər amma mütləqli deyilsə,
            "in" mütləq dəyişMƏMƏlidir. Əks halda error CS831.
            Sanki c++ dakı "const" və "*"(pointer) kombinasiyası yaddan çıxıbdır.
            */
            int ball = 100;
            corruption(ball);
            Console.WriteLine("true score: " + ball);
            /*
            Huşsuz proqramistən qorumaqdan başqa olaraq "in" keyword başqa
            istifadəsi əvvəl dediyimiz kimi "ref" və "out" çoxda fərqlənməməyidir.
            Adi halda method-lara parametr yükləyərkən onların kopiyası yaranır
            həmin method içərisində. Böyük verilənlərlə bu vaxt apara bilər.
            Bu keyword isə verilmiş parametrin özünə müraciət edir.
            */
        }
        static void modulus(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] *= -1;
                }
            }
        }
        static void corruption(in int VictimJafar)
        {
            // error CS831. Readonly qiyməti olmaz dəyişmək:
            //victim = 0;

            if (VictimJafar > 0)
            {
                Console.WriteLine("Injustice failed");
            }
            else
            {
                Console.WriteLine("MuHaHaHaHaHa");
            }
        }
    }
}
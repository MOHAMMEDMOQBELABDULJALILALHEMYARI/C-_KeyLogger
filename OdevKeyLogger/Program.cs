
class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo tusbilgisi;
        // CTRL+C tuş kombinasyonunun uygulamayı durdurmasını yani break etmesini engellemek için
        // aşağıdaki kodlama satırı yazılmıştır.
        Console.TreatControlCAsInput = true;

        Console.WriteLine("BİR TUŞA VEYA CTRL, ALT, SHIFT + BİR TUŞA BASINIZ...");
        Console.Write("ÇIKMAK İÇİN ESC TUŞUNA BASINIZ...\n");

        do
        {
            tusbilgisi = Console.ReadKey();
            Console.Write("\nBASILAN TUŞ: ");

            if ((tusbilgisi.Modifiers & ConsoleModifiers.Alt) != 0)
            {
                if (tusbilgisi.Key.ToString() == "B")
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                Console.WriteLine("ALT+{0}", tusbilgisi.Key.ToString());
            }
            else if ((tusbilgisi.Modifiers & ConsoleModifiers.Control) != 0)
            {
                if (tusbilgisi.Key.ToString() == "R")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine("CTRL+{0}", tusbilgisi.Key.ToString());
            }
            else if ((tusbilgisi.Modifiers & ConsoleModifiers.Shift) != 0)
            {
                Console.WriteLine("SHIFT+{0}", tusbilgisi.Key.ToString());
            }
            else
            {
                Console.WriteLine(tusbilgisi.Key.ToString());
            }

        } while (tusbilgisi.Key != ConsoleKey.Escape);
    }
}


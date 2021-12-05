namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneKeyPad();
            static void PhoneKeyPad()
            {
                Console.WriteLine("Enter text");
                string input = Console.ReadLine().ToLower();
                char[] inChar = input.ToCharArray();
                var keyPadDigits = new List<string>();
                int count = 0;
                for (int i = 0; i < inChar.Length; i++)
                {
                    if (char.IsDigit(inChar[i]))
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    Console.WriteLine("Error. Numbers in text");
                }
                else
                {
                    for (int i = 0; i < inChar.Length; i++)
                    {
                        switch (inChar[i])
                        {
                            case 'a':
                            case 'b':
                            case 'c':
                                keyPadDigits.Add("2");
                                break;
                            case 'd':
                            case 'e':
                            case 'f':
                                keyPadDigits.Add("3");
                                break;
                            case 'g':
                            case 'h':
                            case 'i':
                                keyPadDigits.Add("4");
                                break;
                            case 'j':
                            case 'k':
                            case 'l':
                                keyPadDigits.Add("5");
                                break;
                            case 'm':
                            case 'n':
                            case 'o':
                                keyPadDigits.Add("6");
                                break;
                            case 'p':
                            case 'q':
                            case 'r':
                            case 's':
                                keyPadDigits.Add("7");
                                break;
                            case 't':
                            case 'u':
                            case 'v':
                                keyPadDigits.Add("8");
                                break;
                            case 'w':
                            case 'x':
                            case 'y':
                            case 'z':
                                keyPadDigits.Add("9");
                                break;
                        }
                    }
                    Console.WriteLine("Key pad digit sequence:");
                    keyPadDigits.ForEach(Console.Write);
                }
            }
        }
    }
}
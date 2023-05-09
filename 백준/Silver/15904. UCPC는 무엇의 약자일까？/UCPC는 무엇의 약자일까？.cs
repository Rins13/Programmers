namespace ClassLibrary3
{
    public class Class1
    {
        public static void Main()
		{
            string str = System.Console.ReadLine();

            char[] UCPC = new char[] { 'U', 'C', 'P', 'C' };

            int idx = 0;

            foreach(char ch in str)
			{
                if (idx >= UCPC.Length)
                    break;

                if (UCPC[idx] == ch)
                    idx++;
			}

            if (idx < UCPC.Length)
                System.Console.WriteLine("I hate UCPC");
            else
                System.Console.WriteLine("I love UCPC");


        }
    }
}
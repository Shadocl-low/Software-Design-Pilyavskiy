namespace ConsoleTest.Classes
{
    public class USD : Money
    {
        public USD(long dollars, int cents) : base(dollars, cents, "USD")
        {
        }
    }

    public class EUR : Money
    {
        public EUR(long euros, int cents) : base(euros, cents, "EUR")
        {
        }
    }

    public class UAH : Money
    {
        public UAH(long hryvnias, int kopiykas) : base(hryvnias, kopiykas, "UAH")
        {
        }
    }
} 
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bitte geben Sie Ihren Namen ein:");
            string name = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie Ihre Kontonummer ein:");
            string number = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie Ihren Kontostand ein:");
            float initialBalance = float.Parse(Console.ReadLine());


            BankAccount account = new BankAccount(
                number,
                name,
                initialBalance
                );

            while (true)
            {
                Console.WriteLine("Bitte wählen Sie eine Aktion aus:");
                Console.WriteLine("1. Kontostand anzeigen");
                Console.WriteLine("2. Einzahlung machen");
                Console.WriteLine("3. Auszahlung machen");
                Console.WriteLine("4. Beenden");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    account.PrintBalance();
                } 
                else if(input == "2")
                {
                    Console.WriteLine("Bitte geben Sie den Betrag ein, den Sie einzahlen möchten:");
                    float depositAmount = float.Parse(Console.ReadLine());
                    account.MakeDeposit(depositAmount);
                } 
                else if (input == "3")
                {
                    Console.WriteLine("Bitte geben Sie den Betrag ein, den Sie abheben möchten:");
                    float withdrawalAmount = float.Parse(Console.ReadLine());
                    account.MakeWithdrawal(withdrawalAmount);
                } 
                else if (input == "4")
                {
                    break;
                } 
                else
                {
                    Console.WriteLine("Ungültige Auswahl. Bitte versuchen Sie es erneut.");
                }

            }
        }
    }
}
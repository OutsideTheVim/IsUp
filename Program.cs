internal class Program
{
    static void Main(string[] args)
    {
        var searchHandler = new SearchHandler();
        var connectionHandler = new ConnectionHandler();

        Console.WriteLine("URL?");
        string url = Console.ReadLine();

        if (!searchHandler.VerifySearch(url))
        {
            Console.WriteLine("Make sure the input is in this format: google.com");
        }
        else
        {

            var status = Convert.ToString(connectionHandler.VerifyDomainStatus(url));

            if (status == "Success")
            {
                Console.WriteLine("Host is up!");
            }
            else if (status == "TimedOut")
            {
                Console.WriteLine("Host seems down!");
            }
            else
            {
                throw new Exception("Something went wrong!");
            }

        }
    }
}

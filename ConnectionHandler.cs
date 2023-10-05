using System.Net.NetworkInformation;

class ConnectionHandler
{
    public IPStatus VerifyDomainStatus(string url)
    {
        var ping = new Ping();
        try
        {
            var result = ping.Send(url);
            return result.Status;
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR - Make sure the domain exists! (input ex: google.com)");
            System.Environment.Exit(0);
            return 0;
        }
    }
}
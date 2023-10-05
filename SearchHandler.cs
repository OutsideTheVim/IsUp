
using System.Text.RegularExpressions;

class SearchHandler
{
    public bool VerifySearch(string input)
    {
        Regex rx = new Regex(@"\b^(([a-zA-Z]{1})|([a-zA-Z]{1}[a-zA-Z]{1})|([a-zA-Z]{1}[0-9]{1})|([0-9]{1}[a-zA-Z]{1})|([a-zA-Z0-9][a-zA-Z0-9-_]{1,61}[a-zA-Z0-9]))\.([a-zA-Z]{2,6}|[a-zA-Z0-9-]{2,30}\.[a-zA-Z]{2,3})$\b",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);

        if (rx.IsMatch(input)) return true;

        return false;
    }
}

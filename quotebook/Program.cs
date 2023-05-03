using System;

class Program
{
    static void Main(string[] args)
    {
        Source source = new Source("None Were with Him", "http://www.churchofjesuschrist.org");

        // Console.WriteLine(source.Stringify());

        Quote holland = new Quote("Elder Holland", "Because Jesus walked such a long, lonely path utterly alone, we do not have to do so", source);

        // Console.WriteLine(holland.GetQuote());

        Board quoteboard = new Board();
        quoteboard.AddQuote(new Quote("Alma", "If ye have faith ye hope for things which are not seen, which are true.", new Source("Alma 32:21", "https://www.churchofjesuschrist.org/study/scriptures/bofm/alma/32?lang=eng")));
        quoteboard.AddQuote(new Quote("Sister Elaine S. Dalton", "Work hard to achieve your dreams. Don’t let discouragement or mistakes delay you.", new Source("How to Dare Great Things", "https://www.churchofjesuschrist.org/study/new-era/2012/03/how-to-dare-great-things?lang=eng")));
        quoteboard.AddQuote(new Quote("Elder Joseph B. Wirthlin", "Your Heavenly Father—who knows when even a sparrow falls—knows of your heartache and suffering.", new Source ("Finding a Safe Harbor", "https://www.churchofjesuschrist.org/study/general-conference/2000/04/finding-a-safe-harbor?lang=eng")));
        quoteboard.AddQuote(new Quote("Elder Gary E. Stevenson", "Do you realize that the Book of Mormon was written for you—and for your day?", new Source("Look to the Book, Look to the Lord", "https://www.churchofjesuschrist.org/study/general-conference/2016/10/look-to-the-book-look-to-the-lord?lang=eng")));

        // quoteboard.GetRandomQuote();

        Menu menu = new Menu(quoteboard);
        menu.Display();
    }

}

using System.Text.RegularExpressions;

public class Name
{
    public Name(string first, string last)
    {
        if (string.IsNullOrWhiteSpace(first))
            throw new ArgumentException("First name cannot be empty");
        if (string.IsNullOrWhiteSpace(last))
            throw new ArgumentException("First name cannot be empty");

        First = first;
        Last = last;
    }

    public string First { get; }
    public string Last { get; }
}

public class Address
{
    public string Country { get; }
    public string ZipCode { get; }
    public string City { get; }
    public string Street { get; }

    public Address(string country, string zipCode, string city, string street)
    {
        if (string.IsNullOrWhiteSpace(country))
            throw new ArgumentException("Country cannot be empty.");
        if (string.IsNullOrWhiteSpace(zipCode))
            throw new ArgumentException("Zip code cannot be empty.");
        if (string.IsNullOrWhiteSpace(city))
            throw new ArgumentException("City cannot be empty.");
        if (string.IsNullOrWhiteSpace(street))
            throw new ArgumentException("Street cannot be empty.");
        if (!new Regex("[0-9]{2}-[0-9]{3}").Match(zipCode).Success)
            throw new ArgumentException("Zip code must be NN-NNN format.");

        Country = country;
        ZipCode = zipCode;
        City = city;
        Street = street;
    }


    protected Address()
    {
    }
}

public class SpeakerWebsites
{
    public string Facebook { get; init; }
    public string LinkedIN { get; init; }
    public string Twitter { get; init; }
    public string Instagram { get; init; }
    public string TikTok { get; init; }
    public string YouTube { get; init; }
    public string FanPageOnFacebook { get; init; }

    public string GitHub { get; init; }
    public string Blog { get; init; }

    public SpeakerWebsites(string facebook = null, string linkedIN = null,
        string twitter = null, string instagram = null, string tikTok = null,
        string gitHub = null, string blog = null)
    {
        Facebook = facebook;
        LinkedIN = linkedIN;
        Twitter = twitter;
        Instagram = instagram;
        TikTok = tikTok;
        GitHub = gitHub;
        Blog = blog;
    }

    public SpeakerWebsites()
    {

    }

    public bool HaveSocialMedia()
    {
        if (!string.IsNullOrWhiteSpace(Facebook)
            || !string.IsNullOrWhiteSpace(LinkedIN)
            || !string.IsNullOrWhiteSpace(Twitter)
            || !string.IsNullOrWhiteSpace(Instagram)
            || !string.IsNullOrWhiteSpace(TikTok)
            || !string.IsNullOrWhiteSpace(YouTube)
            || !string.IsNullOrWhiteSpace(FanPageOnFacebook))
            return true;

        return false;
    }

    public bool HaveGitHub()
    {
        if (!string.IsNullOrWhiteSpace(GitHub))
            return true;

        return false;
    }

    public bool HaveBlog()
    {
        if (!string.IsNullOrWhiteSpace(Blog))
            return true;

        return false;
    }

}

public class Contact
{
    public string Phone { get; }
    public string Email { get; }

    public Contact(string phone, string email)
    {
        if (phone == null)
            throw new ArgumentException("phone cannot be null");
        if (email == null)
            throw new ArgumentException("email cannot be null");

        Phone = phone;
        Email = email;
    }

    protected Contact()
    {

    }
}

public class SpeakerWebsitesBuilder
{
    public static SpeakerWebsitesBuilder GivenSpeakerWebsites()
        => new SpeakerWebsitesBuilder();

    private string facebbok = "https://www.facebook.com/cezary.walenciuk";
    private string twitter = "https://twitter.com/walenciukc";
    private string tiktok = "https://www.tiktok.com/@shanselman?";
    private string instagram = "https://www.instagram.com/cezarywalenciuk/";
    private string youTube = "https://www.youtube.com/channel/UCaryk7_lKRI1EldZ6saVjBQ";
    private string fanPageOnFacebook = "https://www.facebook.com/JakProgramowac?fref=nf";
    private string linkedin = "https://www.linkedin.com/in/cezary-walenciuk-35615644/";
    private string blog = "https://cezarywalenciuk.pl/";
    private string github = "https://github.com/PanNiebieski";

    public SpeakerWebsitesBuilder ClearWebsites()
    {
        facebbok = "";
        instagram = "";
        twitter = "";
        tiktok = "";
        youTube = "";
        fanPageOnFacebook = "";
        linkedin = "";
        blog = "";
        blog = "";

        return this;
    }


    public SpeakerWebsitesBuilder WithFacebbok(string newfacebook)
    {
        facebbok = newfacebook;
        return this;
    }

    public SpeakerWebsitesBuilder WithInstagram(string newinstagram)
    {
        instagram = newinstagram;
        return this;
    }

    public SpeakerWebsitesBuilder WithTwitter(string newtwitter)
    {
        twitter = newtwitter;
        return this;
    }

    public SpeakerWebsitesBuilder WithTikTok(string newtiktok)
    {
        tiktok = newtiktok;
        return this;
    }

    public SpeakerWebsitesBuilder WithYoutube(string newyoutube)
    {
        youTube = newyoutube;
        return this;
    }

    public SpeakerWebsitesBuilder WithFanPageOnFacebook(string newfanPageOnFacebook)
    {
        fanPageOnFacebook = newfanPageOnFacebook;
        return this;
    }

    public SpeakerWebsitesBuilder WithLinkedIn(string newlinkedin)
    {
        linkedin = newlinkedin;
        return this;
    }

    public SpeakerWebsitesBuilder WithBlog(string newblog)
    {
        blog = newblog;
        return this;
    }

    public SpeakerWebsitesBuilder WithGitHub(string newgithub)
    {
        github = newgithub;
        return this;
    }

    public SpeakerWebsites Build()
    {
        return new SpeakerWebsites
        ()
        {
            Facebook = facebbok,
            Blog = blog,
            FanPageOnFacebook = fanPageOnFacebook,
            GitHub = github,
            Instagram = instagram,
            LinkedIN = linkedin,
            TikTok = tiktok,
            Twitter = twitter,
            YouTube = youTube
        };
    }
}
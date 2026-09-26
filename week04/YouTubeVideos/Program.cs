using System;

class Program
{
    static void Main(string[] args)
    {
        Video first = new Video("How to tie a tie", "ParkerYorkSmith", 81);
        Video second = new Video("How to tie your shoes", "howvidsdotcom", 104);
        Video third = new Video("Wagoner's Hitch | How to Tie a Trucker's Hitch", "Jason's Knot Channel", 118);
        Video fourth = new Video("Covenants and Responsibilities | Dallin H. Oaks | April 2024 General Conference", "General Conference of The Church of Jesus Christ", 910);
        List<Video> videos = new List<Video>();
        Comment a = new Comment("JollyOI", "'He's gonna look great' was a great addition to the video. 😊");
        first.AddComment(a);
        Comment b = new Comment("Mydogisreallymean", "Desperately needed this yesterday before Homecoming. My mom and I were struggling BAD!!");
        first.AddComment(b);
        Comment c = new Comment("DJ-inthehouse", "THANK YOU I NEEDED THIS FOR A COSPLAY");
        first.AddComment(c);
        Comment d = new Comment("Solaar_2100", "u dont know how much I appreciate this zac efron");
        first.AddComment(d);
        videos.Add(first);

        Comment f = new Comment("TerriblyTrouble", "I'm glad I'm not the only one that took a long time to tie their shoes");
        second.AddComment(f);
        Comment g = new Comment("shantamjohri", "I am 21 years old , and I finally learnt how to tie my shoes , Im pursuing a career in medicine and this is the first time Ive tied my shoes , thank you so much man");
        second.AddComment(g);
        Comment h = new Comment("miaz_ded", "My mom never taught me how to tie my shoes. Thank you.");
        second.AddComment(h);
        Comment j = new Comment("Geometry_dude14", "I feel ashamed I had to search this up");
        second.AddComment(j);
        videos.Add(second);

        Comment k = new Comment("Kevvy_Carabrenno", "You really should include the auto-lock, just wrap the loop at 0:36 (backwards, to YOUR right) around the rope coming from the tree which you have draped in front of the loop.");
        third.AddComment(k);
        Comment l = new Comment("JasonsKnotChannel", "The “auto-lock” doesn’t actually lock anything and also doesn’t work with all types of rope. It’s a nice gimmick though.");
        third.AddComment(l);
        Comment q = new Comment("kadmow", "(autolock - so called also removes most of the mechanical advantage.. - the simple 'sheepshank truckies / waggoners hitch is easily cascaded if the first is tied high enough giving a 4:1 theoretical advantage in 2 stages - and it is easily released after being tight for any length of time.)");
        third.AddComment(q);
        videos.Add(third);

        Comment w = new Comment("WisdomInChristFoundation", "Covenants with authority distinguish us.");
        fourth.AddComment(w);
        Comment e = new Comment("academyofchampions1", "President Oaks is a wonderful man and a great leader");
        fourth.AddComment(e);
        Comment r = new Comment("elainebeckford9762", "Amen Almighty God is working 🙏");
        fourth.AddComment(r);
        Comment t = new Comment("brotherofchrist7", "Help me get to the temple lord");
        fourth.AddComment(t);
        videos.Add(fourth);

        foreach (Video video in videos)
        {
            video.Display();
        }


    }
}
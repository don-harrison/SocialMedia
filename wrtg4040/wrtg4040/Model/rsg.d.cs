using System;

namespace wrtg4040{

    /*
        Describes what information correlates to any one User.
        Random Sentence Generator Interface
     */
    public interface IUser{
        string name { get; set; }
        string surname { get; set; }
        string gender { get; set; }
        string region { get; set; }
        int age { get; set; }
        string title { get; set; }
        string phone { get; set; }
        object birthday { get; set; }
        string email { get; set; }
        string password { get; set; }
        object credit_card { get; set; }
        string photo { get; set; }
    }

/*
    Describes any one post and what it contains.
 */
    interface IPost{
        string postContent { get; set; }
        string profilePictureLink { get; set; }       
        IUser user { get; set; }
    }
}
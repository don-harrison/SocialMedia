import System;

namespace wrtg4040{

    /*
        Describes what information correlates to any one User.
     */
    interface IUser{
        private string firstName;
        private string lastName;
        private string userName;
        private int age;
        private string email;
        private string birthday;
        private string profilePictureLink;

        string FirstName { get; set; }
        string LastName { get; set; }
        string UserName { get; set; }
        int Age { get; set; }
        string Email { get; set; }
        string Birthday { get; set; }
        string ProfilePictureLink { get; set; }
    }

/*
    Describes any one post and what it contains.
 */
    interface IPost{
        string postContent;
        string profilePictureLink;

        IUser user;
    }
}
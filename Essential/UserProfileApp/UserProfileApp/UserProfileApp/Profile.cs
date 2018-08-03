using System;

namespace UserProfileApp
{
    public class Profile
    {
        public Profile(User user)
        {
            User = user;
            CreateDate = DateTime.Now;
        }

        public DateTime CreateDate { get; }

        public User User { get; }
    }
}
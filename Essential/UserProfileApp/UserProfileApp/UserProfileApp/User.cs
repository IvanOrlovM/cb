namespace UserProfileApp
{   
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string SName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{nameof(Login)}: {Login}, {nameof(Name)}: {Name}, {nameof(SName)}: {SName}, {nameof(Age)}: {Age}";
        }
    }
}
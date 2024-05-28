namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Ali", Email = "abc@info.com", Phone = "4444444", WillAttend = true });

            _users.Add(new UserInfo() { Id = 2, Name = "Mehmet", Email = "abcd@info.com", Phone = "1111111", WillAttend = false });

            _users.Add(new UserInfo() { Id = 3, Name = "Buse", Email = "abcf@info.com", Phone = "333333", WillAttend = true });
        }

        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
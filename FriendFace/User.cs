namespace FriendFace
{
    public class User
    {
        string FirstName;
        string LastName;

        List<User> MyFriends = new();

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void ShowFriendsList()
        {
            foreach (var friend in MyFriends)
            {
                Console.WriteLine(friend.FirstName + " " + friend.LastName);
            }
        }
        public void AddFriend(User friend)
        {
            MyFriends.Add(friend);
        }
        public void RemoveFriend(User person)
        {
            MyFriends.Remove(person);
        }
    }
}

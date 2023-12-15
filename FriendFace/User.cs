using System.Numerics;

namespace FriendFace
{
    public class User
    {
        public string FirstName;
        public string LastName;

        List<User> MyFriends = new();

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?\n");
            Console.WriteLine("[1] Add Friend");
            Console.WriteLine("[2] Remove Friend");
            Console.WriteLine("[3] Show Friend");
            Console.WriteLine("[4] Show Friendslist\n");

            while (true)
            {
                int indexInput = Convert.ToInt32(Console.ReadLine());

                switch (indexInput)
                {
                    case 1:
                        AddFriend();
                        break;
                    case 2:
                        ShowFriendsList();
                        RemoveFriend();
                        break;
                    case 3:
                        ShowFriendsList();
                        ShowFriend();
                        Console.ReadKey();
                        break;
                    case 4:
                        ShowFriendsList();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
                ShowMenu();
            }
        }
        public void AddFriend()
        {
            Console.WriteLine("What is your friends first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("And what is your friends last name?");
            string lastName = Console.ReadLine();

            User friend = new(firstName, lastName);
            MyFriends.Add(friend);
        }
        public void RemoveFriend()
        {
            Console.WriteLine("Who do you want to unfriend?");
            int indexToDelete = Convert.ToInt32(Console.ReadLine()) - 1;

            MyFriends.RemoveAt(indexToDelete);
        }
        public void ShowFriend()
        {
            Console.WriteLine("Who do you want to show?");
            int indexToShow = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine($"Here is your friend: {MyFriends[indexToShow].FirstName} {MyFriends[indexToShow].LastName}");
        }
        public void ShowFriendsList()
        {
            Console.WriteLine("Friendslist:");

            for (int i = 0; i < MyFriends.Count; i++)
                Console.WriteLine($"[{i+1}] {MyFriends[i].FirstName} {MyFriends[i].LastName}");
        }
    }
}

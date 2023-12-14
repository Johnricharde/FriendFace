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
                        Console.WriteLine("What is your friends first name?");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("And what is your friends last name?");
                        string lastName = Console.ReadLine();
                        AddFriend(new User(firstName, lastName));
                        break;
                    case 2:
                        ShowFriendsList();
                        Console.WriteLine("Who do you want to unfriend?");
                        int friendlistIndex = Convert.ToInt32(Console.ReadLine());

                        //RemoveFriend();
                        Console.ReadKey();
                        break;
                    case 3:
                        ShowFriend();
                        break;
                    case 4:
                        ShowFriendsList();
                        Console.WriteLine("\nPress any button to go to main menu.");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
                ShowMenu();
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
        public void ShowFriend()
        {

        }
        public void ShowFriendsList()
        {
            Console.WriteLine("Friendslist:");

            for (int i = 0; i < MyFriends.Count; i++)
                Console.WriteLine($"[{i+1}] {MyFriends[i].FirstName} {MyFriends[i].LastName}");
        }
    }
}

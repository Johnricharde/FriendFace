namespace FriendFace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var BobArno = new User("Bob", "Arno");
            var GusBull = new User("Gus", "Bull");
            var JimNebb = new User("Jim", "Nebb");

            //BobArno.AddFriend(GusBull);
            //BobArno.ShowFriendsList();

            BobArno.ShowMenu();
        }
    }
}

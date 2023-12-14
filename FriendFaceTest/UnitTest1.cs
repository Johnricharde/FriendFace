using System.Reflection.Metadata;
using FriendFace;

namespace FriendFaceTest
{
    public class UnitTest1
    {
        [Fact]
        public void CheckAssignmentOfFirstAndLastName()
        {
            var BobArno = new User("Bob", "Arno");

            Assert.Equal("Bob", BobArno.FirstName);
            Assert.Equal("Arno", BobArno.LastName);
        }
    }
}
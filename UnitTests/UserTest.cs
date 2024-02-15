using Assignment_3_skeleton;

namespace Test_Assignment_3_1
{
    public class UserTest
    {
        private User user;

        [SetUp]
        //Creating a new User instance
        public void Setup()
        {
            user = new User(1, "Raiyan Anwar", "raiyanawnar003@gmail.com", "raiyananwar123");
        }

        [Test]
        //Testing 'getid()'
        public void TestGetId()
        {
            Assert.AreEqual(1, user.getId());
        }
        [Test]
        //Testing 'getName()'
        public void TestGetName()
        {
            Assert.AreEqual("Raiyan Anwar", user.getName());
        }
        [Test]
        //Testing 'getEmail()'
        public void TestGetEmail()
        {
            Assert.AreEqual("raiyanawnar003@gmail.com", user.getEmail());
        }

        [Test]
        //Testing 'isCorrectPassword()'
        public void TestIscorrectPassword()
        {
            Assert.True(user.isCorrectPassword("raiyananwar123"));
            Assert.False(user.isCorrectPassword("Raiynanwar123"));
        }
        [Test]
        //Testing 'Equals()'
        public void TestEquals()
        {
            //Creating an identical new user instance
            User IdenticalUser = new User(1, "Raiyan Anwar", "raiyanawnar003@gmail.com", "raiyananwar123");
            //Creating a differnet User
            User DiffUser = new User(2, "Can cun Na", "Ck0021@gmail.com", "CKpassword@123");

            Assert.True(user.equals(IdenticalUser));
            Assert.False (user.equals(DiffUser));
        }
    }
}
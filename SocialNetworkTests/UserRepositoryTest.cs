using Moq;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;

namespace SocialNetworkTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var list = new List<UserEntity>()
            {
                new UserEntity()
                { 
                    firstname = "Denis"
                },
                new UserEntity()
                {
                    firstname = "Nikita"
                }
            };

            Mock <IUserRepository> mock = new Mock<IUserRepository>();

            mock.Setup(v => v.FindAll()).Returns(list);


            Assert.That(mock.Object.FindAll().Any(user => user.firstname == "Denis"));
            Assert.That(mock.Object.FindAll().Any(user => user.firstname == "Nikita"));
        }
    }
}
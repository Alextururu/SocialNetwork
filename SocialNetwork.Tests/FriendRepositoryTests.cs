using NUnit.Framework;
using SocialNetwork.DAL.Repositories;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class FriendRepositoryTests
    {
        [Test]
        public void SubtractionMustReturnNotNullValue()
        {
            FriendRepository friendRepository  = new FriendRepository();
            Assert.That(friendRepository.FindAllByUserId(0).Count()!=0);
        }
    }
}
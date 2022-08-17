using iMessengerCoreAPI.BusinessLogic.Services;
using iMessengerCoreAPI.Domain.Models;

namespace IMessengerCoreAPI.Tests
{
    public class RGDialogsServiceTests
    {
        [Test]
        public void TryFindCommonDialog_ShouldReturnEmptyGuid()
        {
            // arrange
            RGDialogsClients rgDialogsClients = new RGDialogsClients();
            RGDialogsService dialogsService = new RGDialogsService();
            List<RGDialogsClients> clients = rgDialogsClients.Init();

            // act
            var result = dialogsService.TryFindCommonDialog(clients);

            // assert
            Assert.IsTrue(result.CompareTo(Guid.Empty) == 0);
        }

        [Test]
        public void TryFindCommonDialog_ShouldReturnDialogue1()
        {
            // arrange
            RGDialogsClients rgDialogsClients = new RGDialogsClients();
            RGDialogsService dialogsService = new RGDialogsService();
            List<RGDialogsClients> clients = rgDialogsClients.Init().Take(3).ToList();
            RGDialogsClients client = clients[0];

            // act
            var result = dialogsService.TryFindCommonDialog(clients);

            // assert
            Assert.IsTrue(result.CompareTo(client.IDRGDialog) == 0);
        }

        [Test]
        public void TryFindCommonDialog_ShouldReturnDialogue2()
        {
            // arrange
            RGDialogsClients rgDialogsClients = new RGDialogsClients();
            RGDialogsService dialogsService = new RGDialogsService();
            List<RGDialogsClients> clients = rgDialogsClients.Init().Skip(3).Take(2).ToList();
            RGDialogsClients client = clients[0];

            // act
            var result = dialogsService.TryFindCommonDialog(clients);

            // assert
            Assert.IsTrue(result.CompareTo(client.IDRGDialog) == 0);
        }

        [Test]
        public void TryFindCommonDialog_ShouldReturnDialogue3()
        {
            // arrange
            RGDialogsClients rgDialogsClients = new RGDialogsClients();
            RGDialogsService dialogsService = new RGDialogsService();
            List<RGDialogsClients> clients = rgDialogsClients.Init().Skip(5).Take(3).ToList();
            RGDialogsClients client = clients[0];

            // act
            var result = dialogsService.TryFindCommonDialog(clients);

            // assert
            Assert.IsTrue(result.CompareTo(client.IDRGDialog) == 0);
        }
    }
}
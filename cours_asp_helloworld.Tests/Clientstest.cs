using System;
using System.Collections.Generic;
using cours_asp_helloworld.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace cours_asp_helloworld.Tests
{
    [TestClass]
    public class Clientstest
    {
        [TestMethod]
        public void ObtenirListeClients_contient4Clients()
        {
            Clients clients = new Clients();
            List<Client> listClients = clients.ObtenirListeClients();
            Assert.AreEqual(4, listClients.Count);
        }

        [TestMethod]
        public void ObtenirListeClients_contientDelphine()
        {
            Clients clients = new Clients();
            List<Client> listClients = clients.ObtenirListeClients();
            Client client = listClients.Find(c => c.Nom == "Delphine");
            Assert.IsNotNull(client);
        }

        [TestMethod]
        public void ObtenirListeClients_neContientpasThibaud()
        {
            Clients clients = new Clients();
            List<Client> listClients = clients.ObtenirListeClients();
            Client client = listClients.Find(c => c.Nom == "Thibaud");
            Assert.IsNull(client);
        }

        [TestMethod]
        public void ObtenirListeClients_avecUnBouchon_contient4Clients()
        {
            List<Client> listClientsMockee = new List<Client>
            {
                new Client { Age = 33, Nom = "Nicolas"},
                new Client { Age = 30, Nom = "Delphine"},
                new Client { Age = 33, Nom = "Jérémie"}
            };

            Mock<IClients> mock = new Mock<IClients>();
            mock.Setup(clients => clients.ObtenirListeClients()).Returns(listClientsMockee);
            IClients clientsMocke = mock.Object;
            List<Client> listClients = clientsMocke.ObtenirListeClients();
            Assert.AreEqual(3, listClients.Count);
        }
    }
}

using iMessengerCoreAPI.Domain.Abstractions;
using iMessengerCoreAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.BusinessLogic.Services
{
    public class RGDialogsService : IRGDialogsService
    {
        /// <summary>
        /// Try to find a common client's dialog
        /// </summary>
        /// <param name="clients"></param>
        /// <returns> Guid </returns>
        public Guid TryFindCommonDialog(List<RGDialogsClients> clients)
        {
            Dictionary<Guid, bool> uniqueIDClientsWithLabels = new Dictionary<Guid, bool>();

            bool isIncluded;
            uniqueIDClientsWithLabels.Add(clients[0].IDClient, false); // add first client

            // fill distinct IDClients with labels
            for (int i = 0; i < clients.Count(); i++)
            {
                isIncluded = false;
                foreach (Guid idClient in uniqueIDClientsWithLabels.Keys)
                {
                    if (idClient.CompareTo(clients[i].IDClient) == 0)
                    {
                        isIncluded = true;
                        break;
                    }  
                }

                if (isIncluded == false)
                    uniqueIDClientsWithLabels.Add(clients[i].IDClient, false);
            }

            bool isCorrect;

            // find dialogue
            while (clients.Count() != 0)
            {
                Guid idRGDialog = clients[0].IDRGDialog;
                isCorrect = true;

                // check the dialog for the occurrence of all clients in it
                for (int j = 0; j < clients.Count(); j++)
                {
                    if (idRGDialog.CompareTo(clients[j].IDRGDialog) == 0)
                    {
                        // set label to client to true
                        foreach (Guid idClient in uniqueIDClientsWithLabels.Keys)
                        {
                            if (idClient.CompareTo(clients[j].IDClient) == 0)
                            {
                                uniqueIDClientsWithLabels[idClient] = true;
                                break;
                            }
                        }

                        // remove client with this dialogue
                        clients.RemoveAt(j);
                        j--;
                    }
                }

                // check that all clients have labels set to true
                foreach (Guid idClient in uniqueIDClientsWithLabels.Keys)
                {
                    if (uniqueIDClientsWithLabels[idClient] == false)
                    {
                        isCorrect = false;
                        break;
                    }
                }

                // if all clients have label set to true
                if (isCorrect == true)
                    return idRGDialog;

                // reset labels
                foreach (Guid distinctIDClient in uniqueIDClientsWithLabels.Keys)
                {
                    uniqueIDClientsWithLabels[distinctIDClient] = false;
                }
            }

            return Guid.Empty;
        }
    }
}

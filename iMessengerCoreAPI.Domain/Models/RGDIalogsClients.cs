using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.Domain.Models
{
    /// <summary>
    /// RGDialogsClients
    /// </summary>
    public class RGDialogsClients
    {
        /// <summary>
        /// unique id
        /// </summary>
        public Guid IDUnique { get; set; }
        /// <summary>
        /// unique dialog id
        /// </summary>
        public Guid IDRGDialog { get; set; }
        /// <summary>
        /// unique client id
        /// </summary>
        public Guid IDClient { get; set; }
        /// <summary>
        /// event date
        /// </summary>
        public DateTime? DateEvent { get; set; }

        public List<RGDialogsClients> Init()
        {
            List<RGDialogsClients> L1 = new List<RGDialogsClients>();

            var IDClient1 = new Guid("4b6a6b9a-2303-402a-9970-6e71f4a47151");
            var IDClient2 = new Guid("c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820");
            var IDClient3 = new Guid("7de3299b-2796-4982-a85b-2d6d1326396e");
            var IDClient4 = new Guid("0a58955e-342f-4095-88c6-1109d0f70583");
            var IDClient5 = new Guid("50454d55-a73c-4cbc-be25-3c5729dcb82b");

            Guid IDRGDialog1 = new Guid("fcd6b112-1834-4420-bee6-70c9776f6378");

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog1,
                IDClient = IDClient1
            });

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog1,
                IDClient = IDClient2
            });

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog1,
                IDClient = IDClient3
            });


            Guid IDRGDialog2 = new Guid("19f6f751-7f8d-41fa-8261-709028650592");

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog2,
                IDClient = IDClient1
            });

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog2,
                IDClient = IDClient2
            });


            Guid IDRGDialog3 = new Guid("83ebeb2b-c315-48a2-b6e5-f0324de57a9f");

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog3,
                IDClient = IDClient3
            });

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog3,
                IDClient = IDClient4
            });

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog3,
                IDClient = IDClient5
            });

            return L1;
        }
    }
}

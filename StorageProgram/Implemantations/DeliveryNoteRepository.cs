using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageProgram.Database;
using StorageProgram.Interfaces;
using Microsoft.VisualBasic;



namespace StorageProgram.Implemantations
{
    class DeliveryNoteRepository : Repository<DeliveryNote>, IDeliveryNoteRepository
    {
        public DeliveryNoteRepository(DatabaseStorage databaseStorage) : base(databaseStorage)
        {
        }
        public DatabaseStorage database
        {
            get { return _dbContext as DatabaseStorage; }
        }

        public void CreateOrderOrDelivery(string deliveryOrOrder)
        {
            DeliveryNote deliveryNote = new DeliveryNote();

            deliveryNote.DeliveryNoteOrderOrDelivery = deliveryOrOrder;
            deliveryNote.DeliveryNoteIndication = Interaction.InputBox("Označení listu.", deliveryOrOrder, "");

            database.DeliveryNotes.Add(deliveryNote);
        }

        public Tuple<string, int> Return(int itemToTake)
        {
            var item = database.DeliveryNotes.Where(it => it.DeliveryNoteId == itemToTake).ToList();
            
            foreach (var kos in item)
            {
                return Tuple.Create(kos.DeliveryNoteOrderOrDelivery, kos.DeliveryNoteId);
            }
            return null;
        }
    }
}

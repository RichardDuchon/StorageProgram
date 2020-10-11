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
        public DeliveryNoteRepository(DatabaseForStorage databaseForStorage) : base(databaseForStorage)
        {
        }
        public DatabaseForStorage database
        {
            get { return _dbContext as DatabaseForStorage; }
        }



        public void CreateOrderOrDelivery(string deliveryOrOrder)
        {
            DeliveryNote deliveryNote = new DeliveryNote();

            CompanyFrm companyFrm = new CompanyFrm();
            companyFrm.ShowDialog();

           
            

            deliveryNote.DeliveryNoteOrderOrDelivery = deliveryOrOrder;
            deliveryNote.DeliveryNoteIndication = Interaction.InputBox("Označení listu.", deliveryOrOrder, "");
            deliveryNote.DeliveryNoteNameOfCompany = database.Company.Where(x => x.CompanyId == companyFrm.idOfCompany).Single().CompanyName;
            deliveryNote.Company_id = companyFrm.idOfCompany;


            database.DeliveryNote.Add(deliveryNote);
        }

        public Tuple<string, int> Return(int itemToTake)
        {
            var item = database.DeliveryNote.Where(it => it.DeliveryNoteId == itemToTake).ToList();

            foreach (var i in item)
            {
                return Tuple.Create(i.DeliveryNoteOrderOrDelivery, i.DeliveryNoteId);
            }
            return null;
        }
    }
}

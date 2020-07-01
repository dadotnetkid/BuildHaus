using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class Items
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public decimal? TotalQty =>
          unitOfWork.InventoryRepo.Fetch(x => x.ItemId == Id && x.TransactionType != 4).Sum(x => x.QTY);
    }
}

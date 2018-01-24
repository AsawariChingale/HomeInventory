using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeInventory
{
    /// <summary>
    /// This represents the rooms in the house
    /// </summary>
    enum RoomType
    {
        Kitchen,
        LivingRoom,
        DiningRoom,
        PowderRoom,
        Office,
        Foyer,
        MasterBedroom,
        MasterBath,
        KidBedroom1,
        KidBedroom2,
        KidBath,
        MediaRoom,
        Gym,
        GuestRoom,
        PlayRoom,
        BackYard,
        Garage        
    }
    /// <summary>
    /// This represents whether product was sold, donated or recycled
    /// </summary>
    enum RemoveType
    {
        Sale,
        Donate,
        Recycle
    }
    /// <summary>
    /// This represents the products in the home
    /// </summary>
    class Products
    {
        #region Properties

        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public DateTime DatePurchased { get; set; }

        public Decimal PurchasedPrice { get; set; }

        public DateTime ExpiryDate { get; set; }

        public RoomType TypeOfRoom { get; set; }
        public RemoveType TypeOfRemoval { get; set; }

        public Decimal SalePrice { get; set; }

        public Boolean Defected { get; set; }
        #endregion

        #region Methods

        public Boolean IsExpired()
        {
            if (DateTime.Compare(DateTime.Now.Date, ExpiryDate.Date) == 0)
                return true;
            return false;
        }

        public Boolean IsDefected()
        {
            if (Defected)
                return true;
            return false;
        }
        #endregion


    }
}

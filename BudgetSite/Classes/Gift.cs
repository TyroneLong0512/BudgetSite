using BudgetSite.Base_Classes;
using BudgetSite.Enums;
using BudgetSite.Interfaces;

namespace BudgetSite.Classes
{
    /// <summary>
    /// Class to describe and handle functionality for gift budget items
    /// </summary>
    public class Gift : BudgetItem, IGift
    {
        #region Fields
        private GiftType _giftType;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructs an instance of Gift with all values set
        /// </summary>
        /// <param name="giftType">The type of gift item</param>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        /// <param name="storeBoughtFrom">The store the item was bought from</param>
        public Gift(GiftType giftType, string itemName, decimal total, string storeBoughtFrom) : base(itemName, total, storeBoughtFrom)
        {
            _giftType = giftType;
        }

        /// <summary>
        /// Constructs an instance of Gift with the food type set to default
        /// </summary>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        /// <param name="storeBoughtFrom">The store the item was bought from</param>
        public Gift(string itemName, decimal total, string storeBoughtFrom) : base(itemName, total, storeBoughtFrom)
        {
            _giftType = GiftType.Birthday;
        }

        /// <summary>
        /// Constructs an instance of Gift with the gift type and store bought from set to default
        /// </summary>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        public Gift(string itemName, decimal total) : base(itemName, total)
        {
            _giftType = GiftType.Birthday;
        }

        /// <summary>
        /// Constructs an instance of Gift with all values set to default
        /// </summary>
        public Gift() : base()
        {
            _giftType = GiftType.Birthday;
        }
        #endregion

        #region Public Methods
        public GiftType GetGiftType() =>
            _giftType;
        #endregion
    }
}

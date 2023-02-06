using BudgetSite.Interfaces;

namespace BudgetSite.Base_Classes
{
    /// <summary>
    /// Base class for budget items that implements the IBudgetItem interface
    /// </summary>
    public class BudgetItem : IBudgetItem
    {
        #region Fields
        private string _itemName;
        private decimal _total;
        private string _storeBoughtFrom;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructs an instance of BudgetItem with all values set
        /// </summary>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        /// <param name="storeBoughtFrom">The store the item was bought from</param>
        public BudgetItem(string itemName, decimal total, string storeBoughtFrom)
        {
            _itemName = itemName;
            _total = total;
            _storeBoughtFrom = storeBoughtFrom;
        }

        /// <summary>
        /// Constructs an instance of BudgetItem with only the name and total set
        /// </summary>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        public BudgetItem(string itemName, decimal total)
        {
            _itemName = itemName;
            _total = total;
            _storeBoughtFrom = string.Empty;
        }

        /// <summary>
        /// Construts an instance of BudgetItem with all values set to default
        /// </summary>
        public BudgetItem()
        {
            _itemName = string.Empty;
            _total = 0;
            _storeBoughtFrom = string.Empty;
        }
        #endregion

        #region Public Methods
        public string GetItemName() =>
            _itemName;

        public decimal GetItemTotal() =>
            _total;

        public Type GetItemType() =>
            GetType();


        public string GetStoreBoughtFrom() =>
            _storeBoughtFrom;
        #endregion
    }
}

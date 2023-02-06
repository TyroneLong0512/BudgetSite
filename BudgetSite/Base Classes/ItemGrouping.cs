using BudgetSite.Interfaces;

namespace BudgetSite.Base_Classes
{
    public abstract class ItemGrouping : IItemGrouping, IDisposable
    {
        #region Fields
        private IEnumerable<IBudgetItem> _items;
        private bool _disposedValue;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new instance of Item with a provided collection of budget items
        /// </summary>
        /// <param name="budgetItems"></param>
        public ItemGrouping(IEnumerable<IBudgetItem> budgetItems)
        {
            _items = budgetItems;
        }

        /// <summary>
        /// Creates a new instance of Item
        /// </summary>
        public ItemGrouping()
        {
            _items = new List<IBudgetItem>();
        }
        #endregion

        #region Private Methods
        private decimal getTotal()
        {
            decimal total = 0;

            foreach (IBudgetItem item in _items)
                total += item.GetItemTotal();

            return total;
        }

        private IEnumerable<IBudgetItem> getHighestTotalItem()
        {
            decimal highestTotal = 0;
            foreach (IBudgetItem item in _items)
                highestTotal = highestTotal < item.GetItemTotal() ? item.GetItemTotal() : highestTotal;

            return _items.Where(item => item.GetItemTotal() == highestTotal);
        }

        private IEnumerable<IBudgetItem> getLowestTotalItem()
        {
            decimal lowestTotal = 0;
            foreach (IBudgetItem item in _items)
                lowestTotal = lowestTotal > item.GetItemTotal() ? item.GetItemTotal() : lowestTotal;

            return _items.Where(item => item.GetItemTotal() == lowestTotal);
        }
        #endregion

        #region Public Methods
        public decimal GetTotal() =>
            getTotal();

        public IEnumerable<IBudgetItem> GetItems() =>
            _items;

        public IEnumerable<IBudgetItem> GetItemsByType<TItem>() where TItem : IBudgetItem =>
            _items.Where(item => item.GetItemType() == typeof(TItem));


        public IEnumerable<IBudgetItem> GetHighestTotalItem() =>
            getHighestTotalItem();


        public IEnumerable<IBudgetItem> GetLowestTotalItem() =>
            getLowestTotalItem();


        public abstract void LoadAllItems();

        public abstract void LoadItemsByType<TItem>() where TItem : IBudgetItem;
        #endregion

        #region Destructors
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Item()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}

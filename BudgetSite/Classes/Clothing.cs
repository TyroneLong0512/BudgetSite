using BudgetSite.Enums;
using BudgetSite.Interfaces;
using BudgetSite.Base_Classes;
using Microsoft.AspNetCore.Razor.Hosting;

namespace BudgetSite.Classes
{
    /// <summary>
    /// Class to describe and handle the functionality for a clothing budget item
    /// </summary>
    public class Clothing : BudgetItem, IClothing
    {
        #region Fields
        private ClothingType _clothingType;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructs an instance of Clothing with all values set
        /// </summary>
        /// <param name="clothingType">The type of clothing item</param>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        /// <param name="storeBoughtFrom">The store the item was bought from</param>
        public Clothing(ClothingType clothingType, string itemName, decimal total, string storeBoughtFrom) : base(itemName, total, storeBoughtFrom)
        {
            _clothingType = clothingType;
        }

        /// <summary>
        /// Constructs an instance of Clothing with the clothing type set to default
        /// </summary>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        /// <param name="storeBoughtFrom">The store the item was bought from</param>
        public Clothing(string itemName, decimal total, string storeBoughtFrom) : base(itemName, total, storeBoughtFrom)
        {
            _clothingType = ClothingType.Underwear;
        }

        /// <summary>
        /// Constructs an instance of Clothing with the clothing type and store bought from set to default
        /// </summary>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        public Clothing(string itemName, decimal total) : base(itemName, total)
        {
            _clothingType= ClothingType.Underwear;
        }

        /// <summary>
        /// Constructs an instance of Clothing with all values set to default
        /// </summary>
        public Clothing() : base()
        {
            _clothingType = ClothingType.Underwear;
        }
        #endregion

        #region Public Methods
        public ClothingType GetClothingType() =>
            _clothingType;
        #endregion
    }
}

using BudgetSite.Base_Classes;
using BudgetSite.Enums;
using BudgetSite.Interfaces;

namespace BudgetSite.Classes
{
    /// <summary>
    /// Class to describe and handle functionality for food budget items
    /// </summary>
    public class Food : BudgetItem, IFood
    {
        #region Fields
        private FoodType _foodType;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructs an instance of Food with all values set
        /// </summary>
        /// <param name="foodType">The type of food item</param>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        /// <param name="storeBoughtFrom">The store the item was bought from</param>
        public Food(FoodType foodType, string itemName, decimal total, string storeBoughtFrom) : base(itemName, total, storeBoughtFrom)
        {
            _foodType = foodType;
        }

        /// <summary>
        /// Constructs an instance of Food with the food type set to default
        /// </summary>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        /// <param name="storeBoughtFrom">The store the item was bought from</param>
        public Food(string itemName, decimal total, string storeBoughtFrom) : base(itemName, total, storeBoughtFrom)
        {
            _foodType = FoodType.FreshItems;
        }

        /// <summary>
        /// Constructs an instance of Food with the food type and store bought from set to default
        /// </summary>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        public Food(string itemName, decimal total) : base(itemName, total)
        {
            _foodType = FoodType.FreshItems;
        }

        /// <summary>
        /// Constructs an instance of Food with all values set to default
        /// </summary>
        public Food() : base()
        {
            _foodType = FoodType.FreshItems;
        }
        #endregion

        #region Public Methods
        public FoodType GetFoodType() =>
            _foodType;        
        #endregion
    }
}

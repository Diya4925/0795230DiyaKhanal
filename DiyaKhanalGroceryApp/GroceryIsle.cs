using System.Collections.Generic;


public class GroceryIsle
{
    public List<FoodItem> FoodItemsList;
    public string IsleName { get; set; }
    public decimal IsleNumber { get; set; } 

    public GroceryIsle (string IsleName, decimal IsleNumber, List<FoodItem> FoodItemsList)
    {
        this.IsleName = IsleName;
        this.IsleNumber = IsleNumber;
        this.FoodItemsList = FoodItemsList;
    }
}
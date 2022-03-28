// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DiyaKhanalGroceryApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\khana\OneDrive\Documents\GitHub\0795230DiyaKhanal\DiyaKhanalGroceryApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\khana\OneDrive\Documents\GitHub\0795230DiyaKhanal\DiyaKhanalGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\khana\OneDrive\Documents\GitHub\0795230DiyaKhanal\DiyaKhanalGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\khana\OneDrive\Documents\GitHub\0795230DiyaKhanal\DiyaKhanalGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\khana\OneDrive\Documents\GitHub\0795230DiyaKhanal\DiyaKhanalGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\khana\OneDrive\Documents\GitHub\0795230DiyaKhanal\DiyaKhanalGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\khana\OneDrive\Documents\GitHub\0795230DiyaKhanal\DiyaKhanalGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\khana\OneDrive\Documents\GitHub\0795230DiyaKhanal\DiyaKhanalGroceryApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\khana\OneDrive\Documents\GitHub\0795230DiyaKhanal\DiyaKhanalGroceryApp\_Imports.razor"
using DiyaKhanalGroceryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\khana\OneDrive\Documents\GitHub\0795230DiyaKhanal\DiyaKhanalGroceryApp\_Imports.razor"
using DiyaKhanalGroceryApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class GroceryStoreComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\khana\OneDrive\Documents\GitHub\0795230DiyaKhanal\DiyaKhanalGroceryApp\Shared\GroceryStoreComponent.razor"
    
    [Parameter]
    public bool ShowAddFoodForm { get; set; }
    private string isleInput;
    private string ItemNameInput;
    private string OriginInput;
    private string PriceInput;
    private string QtyInput;
    private List<GroceryIsle> islesList = new ()
        {
            new GroceryIsle("DairyandPoultry", 1, new List<FoodItem>()
            {
                new FoodItem {ItemName = "Milk", Qty = 19,  Origin = "Canada", Price = 3f},
                new FoodItem {ItemName = "Chicken", Qty = 12, Origin = "Canada", Price = 19f}
            }),
            new GroceryIsle("BathandBody", 2, new List<FoodItem>()
            {
                new FoodItem {ItemName = "Shampoo", Qty = 20, Origin= "Korea", Price = 5.9f},
                new FoodItem {ItemName = "BodyLotion", Qty = 11, Origin = "Paris", Price = 7.2f}
            }),
            new GroceryIsle("CandyandSnacks", 3, new List<FoodItem>()
            {
                new FoodItem {ItemName = "Hersey's", Qty = 19, Origin = "USA", Price = 13f},
                new FoodItem {ItemName = "Doritos", Qty = 5, Origin = "Mexico", Price = 23.7f}
            })
        };

    private void IncreaseQuantity (FoodItem foodItem, decimal isleNumber)
    {
        var foundIsle = islesList.Find(isle => isle.IsleNumber == isleNumber);
        var foundFood = foundIsle.FoodItemsList.Find(food => food.ItemName == foodItem.ItemName);

        if (foundFood.Qty >= 20) return;

        foundFood.Qty += 1;
    }
     private void DecreaseQuantity (FoodItem foodItem, decimal isleNumber)
    {
        var foundIsle = islesList.Find(isle => isle.IsleNumber == isleNumber);
        var foundFood = foundIsle.FoodItemsList.Find(food => food.ItemName == foodItem.ItemName);

        if (foundFood.Quantity <= 0) return;

        foundFood.Quantity -= 1;
    }

    private void AddNewFoodItem ()
    {
        if (string.IsNullOrWhiteSpace(isleInput)) return;
        if (string.IsNullOrWhiteSpace(ItemNameInput)) return;
        if (string.IsNullOrWhiteSpace(OriginInput)) return;
        if (string.IsNullOrWhiteSpace(PriceInput)) return;
        if (string.IsNullOrWhiteSpace(QtyInput)) return;

        FoodItem newFoodItem = new FoodItem 
            {
                ItemName = ItemNameInput,
                Qty = decimal.Parse(QtyInput),
                Origin = OriginInput,
                Price = float.Parse(PriceInput)
            };


        try
        {
            var isleToUpdate = islesList.Find(isle => isle.IsleNumber == decimal.Parse(isleInput));
            isleToUpdate.FoodItemsList.Add(newFoodItem);
        }
        catch (Exception err)
        {
            throw err;
        }

        isleInput = string.Empty;
        ItemNameInput = string.Empty;
        OriginInput = string.Empty;
        PriceInput = string.Empty;
        QtyInput = string.Empty;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

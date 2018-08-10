using CrunkCraftBeer.Models.BeverageInDepthDetails.cs.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrunkCraftBeer.Models.BeverageInDepthDetails.cs
{
    public class IngredientModel
    {
        public string Name { get; set; }
        public AmountModel Amount { get; set; }
        public string AddTime { get; set; }
        public string Attribute { get; set; }
    }
}
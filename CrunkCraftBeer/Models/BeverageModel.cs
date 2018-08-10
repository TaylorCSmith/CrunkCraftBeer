using CrunkCraftBeer.Models.BeverageInDepthDetails.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrunkCraftBeer.Models
{
    public class BeverageModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Tagline { get; set; }
        public string FirstBrewed { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string ABV { get; set; }
        public string IBU { get; set; }
        public string TargetFG { get; set; }
        public string TargetOG { get; set; }
        public string EBC { get; set; }
        public string SRM { get; set; }
        public string PH { get; set; }
        public string AttenuationLevel { get; set; }
        public VolumeModel Volume { get; set; }
        public BoilVolumeModel BoilVolume { get; set; }
        public List<IngredientModel> Ingredients { get; set; }
        public List<FoodPairingModel> FoodPairing { get; set; }
        public string BrewersTips { get; set; }
        public string Contribution { get; set; }
    }
}
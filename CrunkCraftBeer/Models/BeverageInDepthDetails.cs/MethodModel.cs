using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrunkCraftBeer.Models.BeverageInDepthDetails.cs
{
    public class MethodModel
    {
        public MashTempModel MashTemp { get; set; }
        public FermentationModel Fermination { get; set; }
        public bool Twist { get; set; }
    }
}
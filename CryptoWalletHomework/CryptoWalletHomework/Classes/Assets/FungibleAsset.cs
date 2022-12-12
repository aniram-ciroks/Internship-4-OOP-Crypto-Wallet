using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletHomework.Classes.Assets
{
    public class FungibleAsset : Asset
    {
        public string Tag { get; set; }
        public double FungibleUnitValueRegardingUSD { get; private set; }
        

        public FungibleAsset(string assetName, string tag, double fungibleUnitValueRegardingUSD) : base()
        {
            AssetName= assetName;
            Tag = tag;
            FungibleUnitValueRegardingUSD = fungibleUnitValueRegardingUSD;

        }



    }
}

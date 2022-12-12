using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletHomework.Classes.Assets
{
    public class NonFungibleAsset : Asset 
    {
        public double NonFungibleValue { get; set; }
        public Guid FungibleAdress { get; }

        public NonFungibleAsset(string assetName, double nonFungibleValue, Guid fungibleAdress) : base()
        {
            AssetName= assetName;
            NonFungibleValue= nonFungibleValue;
            FungibleAdress= fungibleAdress;

        }

    }
}

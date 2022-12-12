using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletHomework.Classes.Assets
{
    public abstract class Asset
    {
        public Guid AssetAdress { get; } 
        public string AssetName { get; set;}


        public Asset()
        {
            AssetAdress = Guid.NewGuid();
         
        }


    }
}

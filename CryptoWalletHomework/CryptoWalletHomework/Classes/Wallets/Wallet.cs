using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletHomework.Classes.Wallets
{
    public abstract class Wallet
    {
        public Guid WalletAdress { get; }
        public Dictionary<Guid, double> FungibleAssetBalances { get; private set; }
        public Dictionary <string, List<Guid>> SupportedFungibleAssetAdresses { get; set; }
        public List<Guid> TransactionAdresses { get; private set; }



        public Wallet(Dictionary<Guid, double> fungibleAssetBalances, List<Guid> transactionAdresses, Dictionary<string, List<Guid>> supportedFungibleAssetAdresses) 
        {
            WalletAdress = Guid.NewGuid();
            FungibleAssetBalances = fungibleAssetBalances;
            SupportedFungibleAssetAdresses = supportedFungibleAssetAdresses;
            TransactionAdresses = transactionAdresses;




        }

     


    }
}

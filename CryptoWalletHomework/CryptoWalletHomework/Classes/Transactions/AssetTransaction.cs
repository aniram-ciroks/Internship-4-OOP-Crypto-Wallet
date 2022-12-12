using CryptoWalletHomework.Classes.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletHomework.Classes.Transactions
{
    public abstract class AssetTransaction : Asset
    {
        public Guid TransactionID { get; private set; }
        public Guid AdressAsset { get; private set; }
        public DateTime TransactionDate { get; }
        public Guid WalletSenderAdress { get; }
        public Guid WalletReceiverAdress { get; }
        public bool IsTransactionRevoked { get; set; }


        public AssetTransaction(Guid sender, Guid receiver)  
        {
            TransactionID = Guid.NewGuid();
            TransactionDate = DateTime.Now; 
            WalletSenderAdress = sender;
            WalletReceiverAdress = receiver;
            AdressAsset = AssetAdress;
        }

        public void IsRevoked()
        {
            IsTransactionRevoked = true;
        }





    }
}

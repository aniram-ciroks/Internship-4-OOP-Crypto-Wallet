using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletHomework.Classes.Transactions
{
    public class FungibleAssetTransaction : AssetTransaction
    {
        public double InitialBalanceSender { get; set; }
        public double FinalBalanceSender { get; set;}
        public double InitialBalanceReceiver { get; set; }
        public double FinalBalanceReceiver { get; set;}

        public FungibleAssetTransaction(Guid sender, Guid receiver) : base()
        {

          



        }


    }
}

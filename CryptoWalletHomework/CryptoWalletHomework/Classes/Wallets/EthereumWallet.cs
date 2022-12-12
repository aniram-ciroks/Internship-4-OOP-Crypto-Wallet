using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletHomework.Classes.Wallets
{
    public class EthereumWallet : Wallet
    {
        public EthereumWallet(Dictionary<Guid, double> fungibleAssetBalances, List<Guid> transactionAdresses, Dictionary<string, List<Guid>> supportedFungibleAssetAdresses) : base(fungibleAssetBalances, transactionAdresses, supportedFungibleAssetAdresses)
        {



        }
    }
}

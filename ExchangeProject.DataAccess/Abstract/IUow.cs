using ExchangeProject.Common.DataAccess.EntityFramework;
using ExchangeProject.Common.Entities;
using ExchangeProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeProject.Common.DataAccess
{
    public interface IUow : IAsyncDisposable
    {
        IAppRoleRepository AppRole { get; }
        IAppUserRepository AppUser { get; }
        IAssetCoinRepository AssetCoin { get; }
        IAssetRepository Asset { get; }
        IWalletRepository Wallet { get; }
        ICoinRepository Coin { get; }
        IPairRepository Pair { get; }
        ICoinPairRepository CoinPair { get; }
        IWalletTransactionRepository WalletTransaction { get; }
        ITransactionRepository Transaction { get; }

        Task<int> SaveAsync();
    }
}

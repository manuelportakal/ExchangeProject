using ExchangeProject.Common.DataAccess;
using ExchangeProject.DataAccess.Abstract;
using ExchangeProject.DataAccess.Concrete.EntityFramework.Context;
using ExchangeProject.DataAccess.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeProject.DataAccess.Concrete.EntityFramework
{
    public class Uow : IUow
    {
        private readonly ExchangeDbContext _context;

        private readonly EfAppUserRepository _efAppUserRepository;
        private readonly EfPairRepository _efPairRepository;
        private readonly EfAppRoleRepository _efAppRoleRepository;
        private readonly EfWalletRepository _efWalletRepository;
        private readonly EfCoinRepository _efCoinRepository;
        private readonly EfAssetRepository _efAssetRepository;
        private readonly EfTransactionRepository _efTransactionRepository;
        private readonly EfCoinPairRepository _efCoinPairRepository;
        private readonly EfWalletTransactionRepository _efWalletTransactionRepository;

        public Uow(ExchangeDbContext context)
        {
            _context = context;
        }

        public IAppRoleRepository AppRole => _efAppRoleRepository ?? new EfAppRoleRepository(_context);

        public IAppUserRepository AppUser => _efAppUserRepository ?? new EfAppUserRepository(_context);

        public IAssetRepository Asset => _efAssetRepository ?? new EfAssetRepository(_context);

        public IWalletRepository Wallet => _efWalletRepository ?? new EfWalletRepository(_context);

        public ICoinRepository Coin => _efCoinRepository ?? new EfCoinRepository(_context);

        public IPairRepository Pair => _efPairRepository ?? new EfPairRepository(_context);

        public ICoinPairRepository CoinPair => _efCoinPairRepository ?? new EfCoinPairRepository(_context);

        public IWalletTransactionRepository WalletTransaction => _efWalletTransactionRepository ?? new EfWalletTransactionRepository(_context);

        public ITransactionRepository Transaction => _efTransactionRepository ?? new EfTransactionRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
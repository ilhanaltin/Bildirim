using Bildirim.App.Migrations;
using Bildirim.Common;
using Bildirim.Infrastructure.Main.Repositories.Impl.Authorization;
using Bildirim.Infrastructure.Main.Repositories.Impl.Shared;
using Bildirim.Infrastructure.Main.Repositories.Impl.Types;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Authorization;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Notify;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Shared;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Bildirim.Infrastructure.Main.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private TransactionScope transaction;
        private readonly BildirimContext _context;
        private readonly ApplicationConfig _appConfig;

        public UnitOfWork(BildirimContext context, ApplicationConfig appConfig)
        {
            _context = context;
            _appConfig = appConfig;
        }

        #region Repositories
         
        #region Authorization

        private IUserRepository _UserRepository;

        public IUserRepository UserRepository
        {
            get
            {
                if (this._UserRepository == null)
                {
                    this._UserRepository = new UserRepository(_context);
                }
                return _UserRepository;
            }
        }

        private IUserRoleRepository _UserRoleRepository;

        public IUserRoleRepository UserRoleRepository
        {
            get
            {
                if (this._UserRoleRepository == null)
                {
                    this._UserRoleRepository = new UserRoleRepository(_context);
                }
                return _UserRoleRepository;
            }
        }

        private IUserVerificationRepository _UserVerificationRepository;

        public IUserVerificationRepository UserVerificationRepository
        {
            get
            {
                if (this._UserVerificationRepository == null)
                {
                    this._UserVerificationRepository = new UserVerificationRepository(_context);
                }
                return _UserVerificationRepository;
            }
        }

        private ILoginRepository _LoginRepository;

        public ILoginRepository LoginRepository
        {
            get
            {
                if (this._LoginRepository == null)
                {
                    this._LoginRepository = new LoginRepository(_context);
                }
                return _LoginRepository;
            }
        }

        private IContactRepository _ContactRepository;

        public IContactRepository ContactRepository
        {
            get
            {
                if (this._ContactRepository == null)
                {
                    this._ContactRepository = new ContactRepository(_context);
                }
                return _ContactRepository;
            }
        }

        private ITokenRepository _TokenRepository;

        public ITokenRepository TokenRepository
        {
            get
            {
                if (this._TokenRepository == null)
                {
                    this._TokenRepository = new TokenRepository(_context, _appConfig);
                }
                return _TokenRepository;
            }
        }

        #endregion

        #region Notify

        private INotificationRepository _NotificationRepository;

        public INotificationRepository NotificationRepository
        {
            get
            {
                if (this._NotificationRepository == null)
                {
                    this._NotificationRepository = new NotificationRepository(_context);
                }
                return _NotificationRepository;
            }
        }

        private INotificationVoteRepository _NotificationVoteRepository;

        public INotificationVoteRepository NotificationVoteRepository
        {
            get
            {
                if (this._NotificationVoteRepository == null)
                {
                    this._NotificationVoteRepository = new NotificationVoteRepository(_context);
                }
                return _NotificationVoteRepository;
            }
        }

        #endregion

        #region Campaign

        private ICampaignRepository _CampaignRepository;

        public ICampaignRepository CampaignRepository
        {
            get
            {
                if (this._CampaignRepository == null)
                {
                    this._CampaignRepository = new CampaignRepository(_context);
                }
                return _CampaignRepository;
            }
        }

        #endregion

        #region Shared

        private IBrandRepository _BrandRepository;

        public IBrandRepository BrandRepository
        {
            get
            {
                if (this._BrandRepository == null)
                {
                    this._BrandRepository = new BrandRepository(_context);
                }
                return _BrandRepository;
            }
        }

        private ISectorRepository _SectorRepository;

        public ISectorRepository SectorRepository
        {
            get
            {
                if (this._SectorRepository == null)
                {
                    this._SectorRepository = new SectorRepository(_context);
                }
                return _SectorRepository;
            }
        }

        #endregion

        #region Types

        private IRoleTypeRepository _RoleTypeRepository;

        public IRoleTypeRepository RoleTypeRepository
        {
            get
            {
                if (this._RoleTypeRepository == null)
                {
                    this._RoleTypeRepository = new RoleTypeRepository(_context);
                }
                return _RoleTypeRepository;
            }
        }

        private IUserStatusTypeRepository _UserStatusTypeRepository;

        public IUserStatusTypeRepository UserStatusTypeRepository
        {
            get
            {
                if (this._UserStatusTypeRepository == null)
                {
                    this._UserStatusTypeRepository = new UserStatusTypeRepository(_context);
                }
                return _UserStatusTypeRepository;
            }
        }

        private INotificationTypeRepository _NotificationTypeRepository;

        public INotificationTypeRepository NotificationTypeRepository
        {
            get
            {
                if (this._NotificationTypeRepository == null)
                {
                    this._NotificationTypeRepository = new NotificationTypeRepository(_context);
                }
                return _NotificationTypeRepository;
            }
        }

        #endregion

        #endregion

        public void Dispose()
        {

        }

        //public DbContext Db => _context;

        public void Commit()
        {
            try
            {
                if (transaction != null)
                {
                    transaction.Complete();
                    transaction.Dispose();
                    transaction = null;
                }
            }
            catch (Exception ex)
            {
                transaction.Dispose();
                transaction = null;

                throw ex;
            }
        }

        public void StartTransaction()
        {
            if (transaction == null)
            {
                transaction = new TransactionScope();
            }
        }
    }
}

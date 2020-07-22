using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Models.Repository
{
    public partial class UnitOfWork : IDisposable
    {
        private ModelDb context=new ModelDb();

        public UnitOfWork()
        {
            this.context = ModelDb.Create();

        }

        private GenericRepository<Suppliers> _SuppliersRepo;
        public GenericRepository<Suppliers> SuppliersRepo
        {
            get
            {
                if (this._SuppliersRepo == null)
                    this._SuppliersRepo = new GenericRepository<Suppliers>(context);
                return _SuppliersRepo;
            }
            set { _SuppliersRepo = value; }
        }
        public UnitOfWork(bool lazyLoadingEnabled, bool proxyCreationEnabled)
        {
            this.context.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
            this.context.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
            this.context = ModelDb.Create();
        }
        public static string DataSource;


        private GenericRepository<Customers> _CustomersRepo;
        public GenericRepository<Customers> CustomersRepo
        {
            get
            {
                if (this._CustomersRepo == null)
                    this._CustomersRepo = new GenericRepository<Customers>(context);
                return _CustomersRepo;
            }
            set { _CustomersRepo = value; }
        }

        private GenericRepository<Categories> _CategoriesRepo;
        public GenericRepository<Categories> CategoriesRepo
        {
            get
            {
                if (this._CategoriesRepo == null)
                    this._CategoriesRepo = new GenericRepository<Categories>(context);
                return _CategoriesRepo;
            }
            set { _CategoriesRepo = value; }
        }

        private GenericRepository<Inventory> _InventoryRepo;
        public GenericRepository<Inventory> InventoryRepo
        {
            get
            {
                if (this._InventoryRepo == null)
                    this._InventoryRepo = new GenericRepository<Inventory>(context);
                return _InventoryRepo;
            }
            set { _InventoryRepo = value; }
        }

        private GenericRepository<Items> _ItemsRepo;
        public GenericRepository<Items> ItemsRepo
        {
            get
            {
                if (this._ItemsRepo == null)
                    this._ItemsRepo = new GenericRepository<Items>(context);
                return _ItemsRepo;
            }
            set { _ItemsRepo = value; }
        }


        private GenericRepository<ControllersActions> _ControllersActionsRepo;
        public GenericRepository<ControllersActions> ControllersActionsRepo
        {
            get
            {
                if (this._ControllersActionsRepo == null)
                    this._ControllersActionsRepo = new GenericRepository<ControllersActions>(context);
                return _ControllersActionsRepo;
            }
            set { _ControllersActionsRepo = value; }
        }



        private GenericRepository<Users> usersRepo;
        public GenericRepository<Users> UsersRepo
        {
            get
            {
                if (this.usersRepo == null)
                    this.usersRepo = new GenericRepository<Users>(context);
                return usersRepo;
            }
            set { usersRepo = value; }
        }

        private GenericRepository<UserRoles> userRolesRepo;
        public GenericRepository<UserRoles> UserRolesRepo
        {
            get
            {
                if (this.userRolesRepo == null)
                    this.userRolesRepo = new GenericRepository<UserRoles>(context);
                return userRolesRepo;
            }
            set { userRolesRepo = value; }
        }




        public void Save()
        {
            context.SaveChanges();

        }


        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }

}
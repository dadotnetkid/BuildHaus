using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Models.IInterfaces
{
    public interface ITransactions<TEntity> where TEntity : class
    {
        void Init();
        void Delete();
        void Delete(TEntity item);void Delete(Expression<Func<TEntity, bool>> filter);
        void Detail(TEntity item);
        void Save();
        void Save(TEntity item);
        MethodType MethodType { get; set; }
        void Close(FormClosingEventArgs eventArgs);
    }

    public enum MethodType
    {
        Add = 0,
        Edit = 1
    }
}

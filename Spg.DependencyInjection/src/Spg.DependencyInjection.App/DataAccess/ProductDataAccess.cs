using Spg.DependencyInjection.App.Interfaces;
using Spg.DependencyInjection.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DependencyInjection.App.DataAccess
{
    public class IProductDataAccess : Interfaces.IProductDataAccess
    {
        public Product GetProduct(long id)
        {
            throw new NotImplementedException();
        }
    }
}

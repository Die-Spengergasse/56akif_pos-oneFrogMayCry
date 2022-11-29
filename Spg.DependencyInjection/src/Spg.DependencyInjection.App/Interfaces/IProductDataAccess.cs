using Spg.DependencyInjection.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DependencyInjection.App.Interfaces
{
    public interface IProductDataAccess
    {
        Product GetProduct(long id);
    }
}

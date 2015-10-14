using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringProgram.Models.Interfaces
{
    public interface IOrderFileRepository
    {
        //bool FileExists(string Orderdate);
        List<Order> LoadOrders(string Orderdate);
        //void AddOrder(Order order);
        //void DeleteOrder(string Orderdate);
        //void ReplaceOrderFile(string orderDate, List<Order> orders);

    
    }
}

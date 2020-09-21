using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika24_1.Type
{
    public class Stock
    {
        //Id что бы адекватно удалять
        public int Id { get; set; }
        //Название
        public string Title { get; set; }
        //Дата проведения
        public DateTime Date{ get; set; }
    }
}

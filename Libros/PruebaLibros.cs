using CalidadT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros
{
    public class PruebaLibros
    {
        [Test]
        public void caso01Libro()
        {
            BookStore libro1 = new BookStore() { Name = "1", Price = 10 };
            var bookStore = new BookStore();
            var ob = bookStore.GetTotal(19);
            Assert.AreEqual(1, ob);

        }
    }
}

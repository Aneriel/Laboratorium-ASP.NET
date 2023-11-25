using Laboratorium_3.Models;

namespace Labolatorium_3.Models
{
    public interface IBookService
    {
        void Add(Contact book);
        void Delete(int id);
        void Update(Contact book);
        List<Contact> FindAll();
        Contact? FindById(int id);
    }
}

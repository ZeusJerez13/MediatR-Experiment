using Library.Models;

namespace Library.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPerson(string fristName, string lastName);
    }
}
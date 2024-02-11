using Lab_5.Models;

namespace Lab_5.ViewModels

{

    public class IndexViewModel

    {

        public IEnumerable<Person> People { get; set; } = new List<Person>();

        public IEnumerable<CompanyModel> Companies { get; set; } = new List<CompanyModel>();

    }

}
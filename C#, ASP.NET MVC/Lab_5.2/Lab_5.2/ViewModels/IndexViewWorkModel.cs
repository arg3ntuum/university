using Lab_5.Models;
using Lab_5.ViewModels;

namespace Lab_5.ViewModels
{
    public class IndexViewWorkModel
    {
        public IEnumerable<Worker> Workers { get; set; } = new List<Worker>();

        public IEnumerable<CompanyModel> Companies { get; set; } = new List<CompanyModel>();
    }
}

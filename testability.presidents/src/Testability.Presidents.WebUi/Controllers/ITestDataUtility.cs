using System.Threading.Tasks;

namespace Testability.Presidents.WebUI.Controllers
{
    public interface ITestDataUtility
    {
        Task CreatePresidentTestData();
        Task VerifyDatabaseIsPopulated();
    }

}

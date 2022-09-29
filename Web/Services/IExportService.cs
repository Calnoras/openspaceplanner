using openspace.Common.Entities;
using System.Threading.Tasks;

namespace openspace.Web.Services
{
    public interface IExportService
    {
        string GetSessionAsCsv(Session session);
    }
}

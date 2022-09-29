using openspace.Common.Entities;
using System.Text;

namespace openspace.Web.Services
{
    public class ExportService : IExportService
    {

        public ExportService()
        {
        }

        public string GetSessionAsCsv(Session session)
        {
            var topics = session.Topics;
            var csvBuilder = new StringBuilder();
            csvBuilder.AppendLine("Topic Name; Feedback; Topic Ratings");
            foreach (var topic in topics)
            {
                foreach (var f in topic.Feedback)
                {
                    csvBuilder.AppendLine($"{topic.Name};{f.Value.ToString()};");

                }
                foreach (var t in topic.Ratings)
                {
                    csvBuilder.AppendLine($"{topic.Name};;{t.Value.ToString()}");
                }
            }

            return csvBuilder.ToString();
        }
    }


}

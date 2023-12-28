using CloudDomain.Domain;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace TestApi.EntityDataModels
{
    public class CloudApiEntityDataModel
    {

        public IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.Namespace = "PurePOS.Cloud";
            builder.ContainerName = "PurePOS.Cloud.Container";

            builder.EntitySet<Application>("Application");

            return builder.GetEdmModel();
        }
    }
}

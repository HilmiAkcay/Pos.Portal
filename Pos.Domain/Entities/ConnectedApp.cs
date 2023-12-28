
namespace CloudDomain.Domain
{
    public class ConnectedApp:DefaultEntity
    {
        public long ApplicationId { get; set; }
        public long StationId { get; set; }
        public bool IsConnected { get; set; }
        public string ConnectionId { get; set; }
    }
}

using Pos.Domain.Enums;

namespace CloudDomain.Domain
{
    public class Application : DefaultEntity
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string ExeName { get; set; }
        public EnumServiceStartMode StartMode { get; set; }
        public bool StartAfterInstall { get; set; }
        public bool IsAssignable { get; set; }
        public List<StationApp> StationApps { get; set; }
        public List<ConnectedApp> ConnectedApps { get; set; }
        public List<ReleaseDetail> ReleaseDetails { get; set; }
        public List<InstallLog> InstallLogs { get; set; }
    }
}

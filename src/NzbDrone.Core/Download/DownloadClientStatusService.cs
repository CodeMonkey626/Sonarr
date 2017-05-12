using NLog;
using NzbDrone.Core.ThingiProvider.Status;

namespace NzbDrone.Core.Download
{
    public interface IDownloadClientStatusService : IProviderStatusServiceBase<DownloadClientStatus>
    {

    }

    public class DownloadClientStatusService : ProviderStatusServiceBase<IDownloadClient, DownloadClientStatus>, IDownloadClientStatusService
    {
        public DownloadClientStatusService(IDownloadClientStatusRepository providerStatusRepository, Logger logger)
            : base(providerStatusRepository, logger)
        {

        }
    }
}

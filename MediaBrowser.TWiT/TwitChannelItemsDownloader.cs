using System;
using System.Threading;
using System.Threading.Tasks;
using MediaBrowser.Common.Net;
using MediaBrowser.Model.Logging;
using MediaBrowser.Model.Serialization;

namespace MediaBrowser.Plugins.TWiT
{
    public class TwitChannelItemsDownloader
    {

        private ILogger _logger;
        private readonly IHttpClient _httpClient;
        private readonly IXmlSerializer _xmlSerializer;

        public TwitChannelItemsDownloader(ILogger logManager, IXmlSerializer xmlSerializer, IHttpClient httpClient)
        {
            _logger = logManager;
            _xmlSerializer = xmlSerializer;
            _httpClient = httpClient;
        }

        public async Task<rss> GetStreamList(String queryUrl, int offset, CancellationToken cancellationToken)
        {
            rss feed;

            using (var xml = await _httpClient.Get(queryUrl, CancellationToken.None).ConfigureAwait(false))
            {
                feed = _xmlSerializer.DeserializeFromStream(typeof(rss), xml) as rss;
            }

            return feed;
        }

    }
}

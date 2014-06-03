using MediaBrowser.Common.Net;
using MediaBrowser.Controller.Channels;
using MediaBrowser.Controller.Drawing;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Channels;
using MediaBrowser.Model.Entities;
using MediaBrowser.Model.Logging;
using MediaBrowser.Model.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace MediaBrowser.Plugins.TWiT
{
    class TwitChannel : IChannel, IRequiresMediaInfoCallback
    {
        private readonly IHttpClient _httpClient;
        private readonly ILogger _logger;
        private readonly IXmlSerializer _xmlSerializer;

        public TwitChannel(IHttpClient httpClient, IXmlSerializer xmlSerializer, ILogManager logManager, IServerManager serverManager)
        {
            _httpClient = httpClient;
            _logger = logManager.GetLogger(GetType().Name);
            _xmlSerializer = xmlSerializer;
        }

        public string DataVersion
        {
            get { return "1.0"; }
        }

        public Task<ChannelItemResult> GetAllMedia(InternalAllChannelMediaQuery query, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public InternalChannelFeatures GetChannelFeatures()
        {
            return new InternalChannelFeatures
            {
                CanSearch = false,

                ContentTypes = new List<ChannelMediaContentType>
                {
                    ChannelMediaContentType.Podcast
                },

                MediaTypes = new List<ChannelMediaType>
                {
                    ChannelMediaType.Video
                },

                MaxPageSize = 100,

                DefaultSortFields = new List<ChannelItemSortField>
                {
                    ChannelItemSortField.Name,
                    ChannelItemSortField.PremiereDate,
                    ChannelItemSortField.Runtime,
                },
            };
        }

        public Task<DynamicImageResponse> GetChannelImage(ImageType type, CancellationToken cancellationToken)
        {
            switch (type)
            {
                case ImageType.Thumb:
                case ImageType.Backdrop:
                case ImageType.Primary:
                    {
                        var path = GetType().Namespace + ".Images." + type.ToString().ToLower() + ".jpg";

                        return Task.FromResult(new DynamicImageResponse
                        {
                            Format = ImageFormat.Jpg,
                            HasImage = true,
                            Stream = GetType().Assembly.GetManifestResourceStream(path)
                        });
                    }
                default:
                    throw new ArgumentException("Unsupported image type: " + type);
            }
        }

        public async Task<ChannelItemResult> GetChannelItems(InternalChannelItemQuery query, CancellationToken cancellationToken)
        {
            ChannelItemResult result = null;

            //_logger.Debug("cat ID : " + query.FolderId);

            if (query.FolderId == null)
            {
                result = await GetChannelsInternal(query, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                result = await GetChannelItemsInternal(query, cancellationToken).ConfigureAwait(false);
            }

            return result;
        }

        private async Task<ChannelItemResult> GetChannelsInternal(InternalChannelItemQuery query, CancellationToken cancellationToken)
        {
            List<ChannelItemInfo> twitChannels = new List<ChannelItemInfo>();

            List<KeyValuePair<string,string>> masterChannelList = new List<KeyValuePair<string,string>>();
            masterChannelList.Add(new KeyValuePair<string, string>("aaa", "All About Android"));
            masterChannelList.Add(new KeyValuePair<string, string>("arena", "Android App Arena"));
            masterChannelList.Add(new KeyValuePair<string, string>("byb", "Before You Buy"));
            masterChannelList.Add(new KeyValuePair<string, string>("code", "Coding 101"));
            masterChannelList.Add(new KeyValuePair<string, string>("floss", "FLOSS Weekly"));
            masterChannelList.Add(new KeyValuePair<string, string>("dgw", "The Giz Wiz"));
            masterChannelList.Add(new KeyValuePair<string, string>("hn", "Ham Nation"));
            masterChannelList.Add(new KeyValuePair<string, string>("htg", "Home Theater Geeks"));
            masterChannelList.Add(new KeyValuePair<string, string>("ifive", "iFive For The iPhone"));
            masterChannelList.Add(new KeyValuePair<string, string>("ipad", "iPad Today"));
            masterChannelList.Add(new KeyValuePair<string, string>("kh", "Know How"));
            masterChannelList.Add(new KeyValuePair<string, string>("mbw", "MacBreak Weekly"));
            masterChannelList.Add(new KeyValuePair<string, string>("mm", "Marketing Mavericks"));
            masterChannelList.Add(new KeyValuePair<string, string>("omgcraft", "OMGcraft"));
            masterChannelList.Add(new KeyValuePair<string, string>("sn", "Security Now"));
            masterChannelList.Add(new KeyValuePair<string, string>("natn", "The Social Hour"));
            masterChannelList.Add(new KeyValuePair<string, string>("ttg", "The Tech Guy"));
            masterChannelList.Add(new KeyValuePair<string, string>("tnt", "Tech News Today"));
            masterChannelList.Add(new KeyValuePair<string, string>("tn2n", "Tech News 2Night"));
            masterChannelList.Add(new KeyValuePair<string, string>("twich", "This Week in Computer Hardware"));
            masterChannelList.Add(new KeyValuePair<string, string>("twiet", "This Week in Enterprise Tech"));
            masterChannelList.Add(new KeyValuePair<string, string>("twig", "This Week in Google"));
            masterChannelList.Add(new KeyValuePair<string, string>("twil", "This Week in Law"));
            masterChannelList.Add(new KeyValuePair<string, string>("twit", "This Week in Tech"));
            masterChannelList.Add(new KeyValuePair<string, string>("tri", "Triangulation"));
            masterChannelList.Add(new KeyValuePair<string, string>("specials", "TWiT Live Specials"));
            masterChannelList.Add(new KeyValuePair<string, string>("ww", "Windows Weekly"));

            Dictionary<string, string> altArtValues = new Dictionary<string, string>();
            altArtValues["natn"] = "tsh";

            int filterLimit;
            if (query.StartIndex + query.Limit <= masterChannelList.Count)
            {
                filterLimit = (int)(query.StartIndex + query.Limit) - 1;
            }
            else
            {
                filterLimit = masterChannelList.Count - 1;
            }

            Dictionary<string, string> filteredChannelList = new Dictionary<string, string>();
            for (int i = (int)query.StartIndex; i <= filterLimit; i++)
            {
                filteredChannelList[masterChannelList[i].Key] = masterChannelList[i].Value;
            }

            foreach (KeyValuePair<string, string> currentChannel in filteredChannelList)
            {
                if (altArtValues.ContainsKey(currentChannel.Key))
                {
                    twitChannels.Add(new ChannelItemInfo
                    {
                        Type = ChannelItemType.Folder,
                        ImageUrl = "http://feeds.twit.tv/coverart/" + altArtValues[currentChannel.Key] + "600.jpg",
                        Name = currentChannel.Value,
                        Id = altArtValues[currentChannel.Key],
                    });
                }
                else
                {
                    twitChannels.Add(new ChannelItemInfo
                    {
                        Type = ChannelItemType.Folder,
                        ImageUrl = "http://feeds.twit.tv/coverart/" + currentChannel.Key + "600.jpg",
                        Name = currentChannel.Value,
                        Id = currentChannel.Key,
                    });
                }
            }

            return new ChannelItemResult
            {
                Items = twitChannels.ToList(),
                TotalRecordCount = masterChannelList.Count,
                CacheLength = TimeSpan.FromHours(0),
            };
        }

        private async Task<ChannelItemResult> GetChannelItemsInternal(InternalChannelItemQuery query, CancellationToken cancellationToken)
        {
            var offset = query.StartIndex.GetValueOrDefault();
            var downloader = new TwitChannelItemsDownloader(_logger, _xmlSerializer, _httpClient);

            string streamingWidth = Channel.ConfigurationManager.Configuration.ChannelOptions.PreferredStreamingWidth.ToString();

            string baseurl = "http://feeds.twit.tv/" + query.FolderId + "_video_hd.xml";

            var videos = await downloader.GetStreamList(baseurl, offset, cancellationToken)
                .ConfigureAwait(false);

            var itemslist = videos.channel.item;

            List<ChannelItemInfo> items = new List<ChannelItemInfo>();

            foreach (rssChannelItem i in itemslist)
            {
                List<ChannelMediaInfo> mediaInfo = new List<ChannelMediaInfo>();
                mediaInfo.Add( new ChannelMediaInfo {
                    IsRemote = true,
                    Path = i.link,
                    Width = 1280,
                    Height = 720,
                });

                string[] runtimeArray = i.duration.Split(':');
                int hours;
                int minutes;
                int.TryParse(runtimeArray[0], out hours);
                int.TryParse(runtimeArray[1], out minutes);
                long runtime = (hours * 60) + minutes;
                runtime = TimeSpan.FromMinutes(runtime).Ticks;

                items.Add( new ChannelItemInfo {
                ContentType = ChannelMediaContentType.Podcast,
                ImageUrl = "http://feeds.twit.tv/coverart/" + query.FolderId + "600.jpg",
                IsInfiniteStream = true,
                MediaType = ChannelMediaType.Video,
                MediaSources = mediaInfo,
                RunTimeTicks = runtime,
                Name = i.title,
                Id = i.link,
                Type = ChannelItemType.Media,
                DateCreated = !String.IsNullOrEmpty(i.pubDate) ?
                    Convert.ToDateTime(i.pubDate) : (DateTime?)null,
                PremiereDate = !String.IsNullOrEmpty(i.pubDate) ?
                    Convert.ToDateTime(i.pubDate) : (DateTime?)null,
                Overview = i.summary,
                });
            }

            return new ChannelItemResult
            {
                Items = items,
                TotalRecordCount = items.Count,
                CacheLength = TimeSpan.FromHours(0)
            };
        }

        public IEnumerable<ImageType> GetSupportedChannelImages()
        {
            return new List<ImageType>
            {
                ImageType.Thumb,
                ImageType.Primary,
                ImageType.Backdrop
            };
        }

        public string HomePageUrl
        {
            get { return "http://twit.tv"; }
        }

        public bool IsEnabledFor(User user)
        {
            return true;
        }

        public string Name
        {
            get { return "TWiT"; }
        }

        public Task<IEnumerable<ChannelItemInfo>> Search(ChannelSearchInfo searchInfo, User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ChannelMediaInfo>> GetChannelItemMediaInfo(string id, CancellationToken cancellationToken)
        {
            string[] filenameparts = filenameparts = id.Split('_');
            string baseurl = filenameparts[0];

            _logger.Debug("**** TWiT PLAYBACK EPISODEID: " + baseurl + " ****");
            _logger.Debug("**** TWiT PLAYBACK HD Stream: " + baseurl + "_h264m_1280x720_1872.mp4" + " ****");
            _logger.Debug("**** TWiT PLAYBACK HQ Stream: " + baseurl + "_h264m_864x480_500.mp4" + " ****");
            _logger.Debug("**** TWiT PLAYBACK LQ Stream: " + baseurl + "_h264b_640x368_256.mp4" + " ****");

            return new List<ChannelMediaInfo>
                {
                    new ChannelMediaInfo
                    {
                        Path = baseurl + "_h264m_1280x720_1872.mp4",
                        Width = 1280,
                        Height = 720,
                    },
                    new ChannelMediaInfo
                    {
                        Path = baseurl + "_h264m_864x480_500.mp4",
                        Width = 864,
                        Height = 480,
                    },
                    new ChannelMediaInfo
                    {
                        Path = baseurl + "_h264b_640x368_256.mp4",
                        Width = 640,
                        Height = 368,
                    }
                };
        }
    }
}

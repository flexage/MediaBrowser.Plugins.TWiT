using System.Collections.Generic;

namespace MediaBrowser.Plugins.TWiT
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class rss
    {

        private rssChannel channelField;

        private decimal versionField;

        /// <remarks/>
        public rssChannel channel
        {
            get
            {
                return this.channelField;
            }
            set
            {
                this.channelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannel
    {

        private string titleField;

        private string linkField;

        private string generatorField;

        private string docsField;

        private string languageField;

        private string copyrightField;

        private string licenseField;

        private string managingEditorField;

        private string webMasterField;

        private ushort ttlField;

        private string updatePeriodField;

        private byte updateFrequencyField;

        private string lastBuildDateField;

        private string pubDateField;

        private string categoryField;

        private rssChannelImage imageField;

        private link link1Field;

        private string authorField;

        private string subtitleField;

        private string summaryField;

        private string descriptionField;

        private string keywordsField;

        private string explicitField;

        private owner ownerField;

        private string blockField;

        private image image1Field;

        private category[] category1Field;

        private rssChannelItem[] itemField;

        /// <remarks/>
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }

        /// <remarks/>
        public string generator
        {
            get
            {
                return this.generatorField;
            }
            set
            {
                this.generatorField = value;
            }
        }

        /// <remarks/>
        public string docs
        {
            get
            {
                return this.docsField;
            }
            set
            {
                this.docsField = value;
            }
        }

        /// <remarks/>
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public string copyright
        {
            get
            {
                return this.copyrightField;
            }
            set
            {
                this.copyrightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://backend.userland.com/creativeCommonsRssModule")]
        public string license
        {
            get
            {
                return this.licenseField;
            }
            set
            {
                this.licenseField = value;
            }
        }

        /// <remarks/>
        public string managingEditor
        {
            get
            {
                return this.managingEditorField;
            }
            set
            {
                this.managingEditorField = value;
            }
        }

        /// <remarks/>
        public string webMaster
        {
            get
            {
                return this.webMasterField;
            }
            set
            {
                this.webMasterField = value;
            }
        }

        /// <remarks/>
        public ushort ttl
        {
            get
            {
                return this.ttlField;
            }
            set
            {
                this.ttlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/rss/1.0/modules/syndication/")]
        public string updatePeriod
        {
            get
            {
                return this.updatePeriodField;
            }
            set
            {
                this.updatePeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/rss/1.0/modules/syndication/")]
        public byte updateFrequency
        {
            get
            {
                return this.updateFrequencyField;
            }
            set
            {
                this.updateFrequencyField = value;
            }
        }

        /// <remarks/>
        public string lastBuildDate
        {
            get
            {
                return this.lastBuildDateField;
            }
            set
            {
                this.lastBuildDateField = value;
            }
        }

        /// <remarks/>
        public string pubDate
        {
            get
            {
                return this.pubDateField;
            }
            set
            {
                this.pubDateField = value;
            }
        }

        /// <remarks/>
        public string category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public rssChannelImage image
        {
            get
            {
                return this.imageField;
            }
            set
            {
                this.imageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("link", Namespace = "http://www.w3.org/2005/Atom")]
        public link link1
        {
            get
            {
                return this.link1Field;
            }
            set
            {
                this.link1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string subtitle
        {
            get
            {
                return this.subtitleField;
            }
            set
            {
                this.subtitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string keywords
        {
            get
            {
                return this.keywordsField;
            }
            set
            {
                this.keywordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string @explicit
        {
            get
            {
                return this.explicitField;
            }
            set
            {
                this.explicitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public owner owner
        {
            get
            {
                return this.ownerField;
            }
            set
            {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string block
        {
            get
            {
                return this.blockField;
            }
            set
            {
                this.blockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("image", Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public image image1
        {
            get
            {
                return this.image1Field;
            }
            set
            {
                this.image1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("category", Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public category[] category1
        {
            get
            {
                return this.category1Field;
            }
            set
            {
                this.category1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public rssChannelItem[] item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelImage
    {

        private string titleField;

        private string urlField;

        private string linkField;

        private byte widthField;

        private byte heightField;

        /// <remarks/>
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public string link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }

        /// <remarks/>
        public byte width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        public byte height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
    public partial class link
    {

        private string hrefField;

        private string typeField;

        private string relField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rel
        {
            get
            {
                return this.relField;
            }
            set
            {
                this.relField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd", IsNullable = false)]
    public partial class owner
    {

        private string nameField;

        private string emailField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd", IsNullable = false)]
    public partial class image
    {

        private string hrefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd", IsNullable = false)]
    public partial class category
    {

        private categoryCategory category1Field;

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("category")]
        public categoryCategory category1
        {
            get
            {
                return this.category1Field;
            }
            set
            {
                this.category1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    public partial class categoryCategory
    {

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItem
    {

        private string titleField;

        private string pubDateField;

        private string commentsField;

        private string authorField;

        private string author1Field;

        private string categoryField;

        private string descriptionField;

        private rssChannelItemGuid guidField;

        private string subtitleField;

        private string summaryField;

        private string explicitField;

        private string durationField;

        private string linkField;

        private rssChannelItemEnclosure enclosureField;

        private content contentField;

        /// <remarks/>
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string pubDate
        {
            get
            {
                return this.pubDateField;
            }
            set
            {
                this.pubDateField = value;
            }
        }

        /// <remarks/>
        public string comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("author")]
        public string author1
        {
            get
            {
                return this.author1Field;
            }
            set
            {
                this.author1Field = value;
            }
        }

        /// <remarks/>
        public string category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public rssChannelItemGuid guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string subtitle
        {
            get
            {
                return this.subtitleField;
            }
            set
            {
                this.subtitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string @explicit
        {
            get
            {
                return this.explicitField;
            }
            set
            {
                this.explicitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        public string link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }

        /// <remarks/>
        public rssChannelItemEnclosure enclosure
        {
            get
            {
                return this.enclosureField;
            }
            set
            {
                this.enclosureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://search.yahoo.com/mrss/")]
        public content content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemGuid
    {

        private bool isPermaLinkField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isPermaLink
        {
            get
            {
                return this.isPermaLinkField;
            }
            set
            {
                this.isPermaLinkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemEnclosure
    {

        private string urlField;

        private uint lengthField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://search.yahoo.com/mrss/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://search.yahoo.com/mrss/", IsNullable = false)]
    public partial class content
    {

        private contentCredit[] creditField;

        private contentRating[] ratingField;

        private string urlField;

        private uint fileSizeField;

        private string typeField;

        private string mediumField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("credit")]
        public contentCredit[] credit
        {
            get
            {
                return this.creditField;
            }
            set
            {
                this.creditField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rating")]
        public contentRating[] rating
        {
            get
            {
                return this.ratingField;
            }
            set
            {
                this.ratingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint fileSize
        {
            get
            {
                return this.fileSizeField;
            }
            set
            {
                this.fileSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string medium
        {
            get
            {
                return this.mediumField;
            }
            set
            {
                this.mediumField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://search.yahoo.com/mrss/")]
    public partial class contentCredit
    {

        private string roleField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://search.yahoo.com/mrss/")]
    public partial class contentRating
    {

        private string schemeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string scheme
        {
            get
            {
                return this.schemeField;
            }
            set
            {
                this.schemeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

}
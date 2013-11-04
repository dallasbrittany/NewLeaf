/*
* LICENSE: https://raw.github.com/apimash/StarterKits/master/LicenseTerms-SampleApps%20.txt
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPlatformCloudKit.DataServices;
using XPlatformCloudKit.Models;

namespace XPlatformCloudKit
{
    /// <summary>
    /// Public singleton class for storing application-wide settings
    /// </summary>
    public static class AppSettings
    {
        #region Global Options
        //The name of your applicaion, this value appears at the top of your app
        public const string ApplicationName = "Animal Crossing New Leaf Walkthrough Guide";

        //Timeframe in minutes to store data before making new request to Data Source
        //set to negative value to disable caching
        public const int CacheIntervalInMinutes = 60;
        #endregion

        #region AzureMobileService Settings
        public const bool EnableAzureMobileService = false;  //Use Mobile Service located @ MobileServiceAddress with Key set to MobileServiceApplicationKey
        
        //Mark true to create the Initial Schema if you are running for the first time against a brand new Mobile Service
        //Be sure you have created a table named "Item" and have permission to update with app key
        //After running once, set back to false
        public const bool CreateInitialSchemaForAzureMobileService = false;

        //Your Azure Mobile Service Address 
        //i.e. https://xplatformcloudkit.azure-mobile.net/
        public const string MobileServiceAddress = "https://xplatformcloudkit.azure-mobile.net/";

        //You Azure Mobile Service Key 
        //i.e. UYZnUrrabofKBELSRdRsmCGboyDGMJ15
        public const string MobileServiceApplicationKey = "UYZnUrrabofKBELSRdRsmCGboyDGMJ15";

        #endregion

        #region RssService Settings
        public const bool EnableRssService = true;//Use RssAddressCollection 

        //Urls to an RSS Data Source 
        //i.e. http://reddit.com/r/technology/.rss
        public static readonly RssSource[] RssAddressCollection = 
        {     
            new RssSource{Url = "http://gdata.youtube.com/feeds/api/playlists/SP-7t9DoIELCRI6cwyP1IHZuaq5fzyeuwW?alt=rss&max-results=50", Group = "Part 1: Videos 1-50"},
            new RssSource{Url = "http://gdata.youtube.com/feeds/api/playlists/SP-7t9DoIELCRI6cwyP1IHZuaq5fzyeuwW?alt=rss&max-results=50&start-index=51", Group = "Part 2: Videos 51-100"},
            new RssSource{Url = "http://gdata.youtube.com/feeds/api/playlists/SP-7t9DoIELCRI6cwyP1IHZuaq5fzyeuwW?alt=rss&max-results=50&start-index=101", Group = "Part 3: Videos 101-150"},
            new RssSource{Url = "http://gdata.youtube.com/feeds/api/playlists/SP-7t9DoIELCRI6cwyP1IHZuaq5fzyeuwW?alt=rss&max-results=50&start-index=151", Group = "Part 4: Videos 151-200"},
        };
        #endregion

        #region LocalItemsFileService Settings 
        public const bool EnableLocalItemsFileService = false; //Use Items contained in LocalItemsFile.xml
        #endregion

        #region Windows8 Project options
        //Items whose Group Name is contained in the following Dictionary will display their Description field in full screen
        //When an item of this group is selected, it will not show it's Title, Subtitle, or Image. (Ideal for Youtube RSS feeds)
        public static readonly string[] GroupsToDisplayInFullScreen = 
        {
            "Part 1: Videos 1-50","Part 2: Videos 51-100","Part 3: Videos 101-150","Part 4: Videos 151-200"
        };

        //Determines whether to use the Light theme (white background / black text) over the default Dark theme
        //(black background / white text)
        public const bool UseLightThemeForWindows8 = true;

        //Url to your privacy policy - default value is "http://www.freeprivacypolicy.org/generic.php"
        //Note: This is REQUIRED for certification in the Windows 8 store
        public const string PrivacyPolicyUrl = "http://www.freeprivacypolicy.org/generic.php";
        #endregion

        #region Youtube Video Link Options
        //Forces Youtube links to be rewritten so that they load the video only in full screen
        //This produces a very clean look as the related videos etc. are not visible
        public const bool ForceYoutubeVideosToLoadFullScreen = true;

        //When a Youtube Video link exists for an item it will begin playing that video when the item is selected
        //This will only Display the Youtube video, all other data in the description is ignored - Effects Win8 only
        public const bool AutoPlayYoutubeVideos = true;
        #endregion

        #region Advanced ItemDescriptionView / Webview Options for Windows 8 and Windows Phone projects
        //Determines background color of WebView Control used behind Description in ItemDescriptionView.xaml.cs
        //Set to "Auto" to determine based on theme background or override using hex color string i.e. "#FFFFFF" for white, "#000000" for black
        public const string BackgroundColorOfDescription = "Auto";

        //Determines Font color of WebView Control used to display Description in ItemDescriptionView.xaml.cs
        //Set to "Auto" to determine based on theme background or override using hex color string i.e. "#FFFFFF" for white, "#000000" for black
        public const string FontColorOfDescription = "Auto"; 

        //Determines whether hyperlinks can be clicked in ItemDescriptionView.xaml for both Windows 8 and Windows Phone 8 projects
        //Sometimes, store may fail apps which contain hyperlinks that navigate improperly when clicked, this disables them
        public const bool DisableHyperLinksInItemDescriptionView = false;

        //Determines whether hyperlinks with target="_blank" are rewritten to target="_self"
        //When enabled, hyperlinks will not open in a new tab
        public const bool DisableOpeningHyperLinksInNewTab = true;
        #endregion

    }
}

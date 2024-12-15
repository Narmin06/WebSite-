////Task1. Primary constructor-suz

//WebSite site = new WebSite("Site1", "www.site1.com", "SiteDescription", "7r1384103");
//Console.WriteLine(site);
//class WebSite
//{
//    public string SiteName {  get; set; }
//    public string SiteAddress{ get; set; }
//    public string SiteDescription { get; set; }
//    public string IpAddress { get; set; }

//    public WebSite(string siteName, string siteAddress, string siteDescription, string ipAddress)
//    {
//        SiteName = siteName;
//        SiteAddress = siteAddress;
//        SiteDescription = siteDescription;
//        IpAddress = ipAddress;
//    }

//    public string GetSiteName()
//    {
//        return SiteName;
//    }

//    public string GetSiteAddress()
//    {
//        return SiteAddress;
//    }

//    public string GetSiteDescription()
//    {
//        return SiteDescription;
//    }

//    public string GetIpAddress()
//    {
//        return IpAddress;
//    }
//    public override string ToString()
//    {
//        return $@" Saytın adı: {SiteName} 
// Saytın ünvanı: {SiteAddress}
// Saytın tesviri: {SiteDescription}
// Saytın IP ünvanı: {IpAddress}";
//    }
//}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Task2. Primary constructor ilə 

WebSite site = new WebSite("Site1", "www.site1.com", "SiteDescription", "7r1384103");
Console.WriteLine(site);
class WebSite(string SiteName, string SiteAddress, string SiteDescription, string IpAddress)
{
    public override string ToString()
    {
        return $@" Saytın adı: {SiteName} 
 Saytın ünvanı: {SiteAddress}
 Saytın tesviri: {SiteDescription}
 Saytın IP ünvanı: {IpAddress}";
    }
}
# Metroappsite-MVC4
MetroAppSite for MVC4 is an off-the-shelf ASP.NET MVC4 project that leverages [Twitter Bootstrap][6] and [BootMetro][1] to help Windows Store developers craft customizeable, Metro-style websites to help promote their application and meet Windows Store certification requirements.

### What's Included
MetroAppSite includes:

* Metro UI, branding, and Microsoft SurfaceTM smooth screenshot slider.
* Fully configurable branding and content.
* Customizeable and extensible UI built with [Twitter Bootstrap][6] and [BootMetro][1].
* Includes privacy policy template, which is required to publish in the Windows Store.
* Integration points with [UserVoice][4] and [Google Analytics][2] to help you better manage your app's presence online.

## Configuration Instructions

1. Fork and clone this repository.
1. Edit the marketing text (features, testimonials, headers, etc...) on [Index.cshtml][7].
1. Add your own carousel pictures to [Index.cshtml][7]. MetroAppSite uses the [Twitter Bootstrap photo carousel][3].
1. Embed your own [Twitter timeline widget] [5] on [Index.cshtml][7].
1. Add your own[UserVoice] [4] information from [_userVoiceScriptPartial.cshtml][8] partial view.
1. Add your own [Google Analytics] [2] information from [_googleAnalyticsScriptPartial.cshtml][9] partial view.
1. Change the `ViewBag.Title` property for both your home page and privacy policy in [HomeController.cs][10].
1. Change the `AppDownloadUrl` variable in [HomeController.cs][10] to be equal to your app's url in the Windows Store.
1. Add your own marketing terms to meta tags at _Layout.cshtml.

This template is based on [BootMetro][1]. 

[1]: http://aozora.github.com/bootmetro/
[2]: http://www.google.com/analytics/
[3]: http://twitter.github.com/bootstrap/javascript.html#carousel
[4]: http://www.uservoice.com/
[5]: https://dev.twitter.com/docs/embedded-timelines
[6]: http://twitter.github.com/bootstrap/
[7]: https://github.com/markedup-mobi/metroappsite-mvc/blob/master/src/MetroAppSite/Views/Home/Index.cshtml
[8]: https://github.com/markedup-mobi/metroappsite-mvc/blob/master/src/MetroAppSite/Views/Shared/ThirdParty/_userVoiceScriptPartial.cshtml
[9]: https://github.com/markedup-mobi/metroappsite-mvc/blob/master/src/MetroAppSite/Views/Shared/ThirdParty/_googleAnalyticsScriptPartial.cshtml
[10]: https://github.com/markedup-mobi/metroappsite-mvc/blob/master/src/MetroAppSite/Controllers/HomeController.cs
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

1. Clone this repository.
1. Add your own carousel pictures. [Twitter bootstrap carousel] [3] is used.
1. Modify [twitter account] [5] information.
1. Edit [uservoice] [4] information from _userVoiceScriptPartial.cshtml partial view.
1. Modify [Google Analytics] [2] information from _googleAnalyticsScriptPartial.cshtml partial view.
1. Edit title and marketing text at index.cshtml and _Layout.cshtml.
1. Change download link to your github repo's url.
1. Add your own marketing terms to meta tags at _Layout.cshtml.

This is Asp.Net MVC4 template for Metro App developers. You may change the theme just by adding _metro-ui-dark.css and disable bootmetro-ui-light.css. This template is based on [boot metro] [1]. 

[1]: http://aozora.github.com/bootmetro/
[2]: http://www.google.com/analytics/
[3]: http://twitter.github.com/bootstrap/javascript.html#carousel
[4]: http://www.uservoice.com/
[5]: https://twitter.com/
[6]: http://twitter.github.com/bootstrap/
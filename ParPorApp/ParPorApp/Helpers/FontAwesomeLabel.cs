using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ParPorApp.Helpers
{
    public class FontAwesomeLabel : Label
    {
        public FontAwesomeLabel()
        {
            FontFamily = Device.OnPlatform(null, "FontAwesome", "/Assets/Fonts/fontawesome-webfont.ttf#FontAwesome");
        }
    }
}

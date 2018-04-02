using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParPorApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GroupMemberDetailPage : ContentPage
	{
		public GroupMemberDetailPage (MembersDetail memberDetail)
		{
			InitializeComponent ();
		    BindingContext = memberDetail ?? throw new ArgumentNullException();
        }
	}
}
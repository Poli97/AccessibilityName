using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AccessibilityName
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label label = new Label
            {
                BackgroundColor = Color.Orange,
            };
            AutomationProperties.SetIsInAccessibleTree(label, true);
            AutomationProperties.SetName(label, "Test accessibility name");
            AbsoluteLayout.SetLayoutBounds(label, new Rectangle(0.5, 0.5, 0.3, 0.2));
            AbsoluteLayout.SetLayoutFlags(label, AbsoluteLayoutFlags.All);

            absolutelayout.Children.Add(label);
        }
    }
}

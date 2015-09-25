using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;
using Bundle_Library;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace BundleTestApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            TestBundleable tb = new TestBundleable();
            TestBundleable tbout = null;
            Bundle b = new Bundle("Testing");
            b.storePackedObject("Test Object",tb);
            tbout = (TestBundleable) b.getPackedObject("Test Object");
            if (tb.Equals(tbout))
                Debug.WriteLine("Objects are equal");
            else
                Debug.WriteLine("Objects are not equal");
            Debug.WriteLine(tbout.TestInt);
            Debug.WriteLine(tbout.TestString);
            Bundle c = new Bundle("blah");
            c.putInt("abc",98765);
            c.putString("def","World");
            c = c + b;
            Debug.WriteLine(c.getString("def"));
            Debug.WriteLine(c.getInt("abc"));
            tbout = (TestBundleable)c.getPackedObject("Test Object");
            if (tb.Equals(tbout))
                Debug.WriteLine("Objects are equal");
            else
                Debug.WriteLine("Objects are not equal");


        }
    }
}

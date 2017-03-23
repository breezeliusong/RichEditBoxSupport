using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RichEditBoxSupport
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void add(object sender, RoutedEventArgs e)
        {
            ITextCharacterFormat format = editor.Document.GetDefaultCharacterFormat();
            format.Bold = FormatEffect.Off;
            format.ForegroundColor = Colors.Black;
            editor.Document.SetDefaultCharacterFormat(format);
            editor.Document.SetText(TextSetOptions.ApplyRtfDocumentDefaults, "Second Line of Text \r\n");
            format.Bold = FormatEffect.On;
            format.ForegroundColor = Colors.Red;
            editor.Document.Selection.CharacterFormat = format;
            editor.Document.Selection.SetText(TextSetOptions.Unhide, "First Line of Text \r\n");
        }
    }
}

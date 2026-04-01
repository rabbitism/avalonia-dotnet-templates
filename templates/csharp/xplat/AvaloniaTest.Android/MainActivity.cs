using Android.App;
using Android.Content.PM;
using Avalonia;
using Avalonia.Android;
#if (ReactiveUIToolkitChosen)
using ReactiveUI.Avalonia;
#endif

namespace AvaloniaTest.Android;

[Activity(
    Label = "AvaloniaTest.Android",
    Theme = "@style/MyTheme.NoActionBar",
    Icon = "@drawable/icon",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity
{
}

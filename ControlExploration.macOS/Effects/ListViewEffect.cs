using ControlExploration.macOS.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

[assembly: ExportEffect(typeof(ListViewEffect), nameof(ListViewEffect))]

namespace ControlExploration.macOS.Effects
{
    public class ListViewEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var nativeTableView = ((ListViewRenderer)Container).NativeTableView;
                
            // If this line is added, the list items no longer display
            //nativeTableView.SelectionDidChange += (sender, e) => { }; 
        }

        protected override void OnDetached()
        {
        }
    }
}

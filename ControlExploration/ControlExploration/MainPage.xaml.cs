using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace ControlExploration
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new ViewModel();
        }
    }

    internal class ViewModel
    {
        private readonly Thing[] _things;

        public ViewModel()
        {
            _things = new Thing[]
            {
                new Thing("A thing"),
                new Thing("B thing"),
                new Thing("C thing")
            };
        }

        public IEnumerable<Thing> Things
        {
            get { return _things; }
        }
    }

    internal class Thing
    {
        public Thing(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
    }
}

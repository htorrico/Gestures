using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GesturesDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GestureMultiple : ContentPage
    {
        public GestureMultiple()
        {
            InitializeComponent();
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += OnTapGestureRecognizerTapped;

            var pinchGesture = new PinchGestureRecognizer();
            pinchGesture.PinchUpdated += OnPinchUpdated;

            var panGesture = new PanGestureRecognizer();
            panGesture.PanUpdated += OnPanUpdated;

            var swipeGesture = new SwipeGestureRecognizer();
            swipeGesture.Swiped += OnSwiped;

            image1.GestureRecognizers.Add(tapGestureRecognizer);
            image1.GestureRecognizers.Add(pinchGesture);
            image1.GestureRecognizers.Add(panGesture);
            image1.GestureRecognizers.Add(swipeGesture);
        }
        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            labelMessage.Text = "TapGestureRecognizerTapped";
        }
        void OnPinchUpdated(object sender, EventArgs args)
        {
            labelMessage.Text = "OnPinchUpdated";
        }
        void OnPanUpdated(object sender, EventArgs e)
        {
            labelMessage.Text = "OnPanUpdated";
        }
        void OnSwiped(object sender, EventArgs e)
        {
            labelMessage.Text = "OnSwiped";
        }
    }
}
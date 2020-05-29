using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            //var Tap = new TapGestureRecognizer();
            //Tap.Tapped += OnTapGestureRecognizerTapped;

            /*
             Paso 1: Declarar una instancia del gesture a utilizar
             Paso 2: Creo un Evento
             Paso 3: Asigno mi evento creado en el paso2
             Paso 4: Asignr el gesto a  un control.
             */


            ////TAP
            //var tap1 = new TapGestureRecognizer(); // paso 1
            //tap1.Tapped += EventoTap;//paso 2 y paso 3
            //image1.GestureRecognizers.Add(tap1); //paso 4

            ////
            //var pinch1 = new PinchGestureRecognizer();
            //pinch1.PinchUpdated += EventoPinch;
            //image1.GestureRecognizers.Add(tap1);



            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += OnTapGestureRecognizerTapped;

            //PINCH
            var pinchGesture = new PinchGestureRecognizer();
            pinchGesture.PinchUpdated += OnPinchUpdated;

            //PAN
            var panGesture = new PanGestureRecognizer();
            panGesture.PanUpdated += OnPanUpdated;

            //SWIPE
            var swipeGesture = new SwipeGestureRecognizer();
            swipeGesture.Swiped += OnSwiped;

            image1.GestureRecognizers.Add(tapGestureRecognizer);
            image1.GestureRecognizers.Add(pinchGesture);
            image1.GestureRecognizers.Add(panGesture);
            image1.GestureRecognizers.Add(swipeGesture);
        }

        void EventoTap(object sender, EventArgs args)
        {         
            btnSave.IsVisible = false;
        }
        void EventoPinch(object sender, EventArgs args)
        {            
            btnSave.IsVisible = true;
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
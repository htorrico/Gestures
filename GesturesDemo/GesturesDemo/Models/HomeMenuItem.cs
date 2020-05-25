using System;
using System.Collections.Generic;
using System.Text;

namespace GesturesDemo.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        GestureMultiple,
        Tap,
        Pinch,
        Pan,        
        Swipe,
        SwipeBinding

    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}

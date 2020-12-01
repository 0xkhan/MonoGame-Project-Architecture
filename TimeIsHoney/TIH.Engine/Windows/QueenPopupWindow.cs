using System;
namespace TimeIsHoney.TIH.Engine.Windows
{
    public class QueenPopupWindow : Window
    {
        /// <summary>
        /// This class is specific to Queen popup window.
        /// This popup opens when the player clicks on Queen/Queen cell.
        ///
        /// In this class we will use (inherit) Window class and Interfaces if
        /// we created any. 
        ///
        /// Inheritance is done like following:
        ///
        /// public class HoneybeeEntity : Entity, IEntity, ILivingEntity { // Code }
        /// 
        /// It's good/common practice that an interface is defined with a capital
        /// "I" at the beginning -> IEntity, ILivingEntity
        /// </summary>
        public QueenPopupWindow()
        {
        }
    }
}

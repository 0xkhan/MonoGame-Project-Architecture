using System;
namespace TimeIsHoney.TIH.Engine.Windows
{
    public class LabPopupWindow : Window
    {
        /// <summary>
        /// This class is specific to lab popup window.
        /// This popup pops up when the player clicks on the lab cell.
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
        public LabPopupWindow()
        {
        }
    }
}

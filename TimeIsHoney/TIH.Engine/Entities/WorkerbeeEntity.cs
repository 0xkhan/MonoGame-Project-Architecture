using System;
namespace TimeIsHoney.TIH.Engine.Entities
{
    public class WorkerbeeEntity
    {

        /// <summary>
        /// This class is specific to Worker Bee entity.
        ///
        /// In this class we will use (inherit) Entity class and Interfaces if
        /// we created any. 
        ///
        /// Inheritance is done like following:
        ///
        /// public class HoneybeeEntity : Entity, IEntity, ILivingEntity { // Code }
        /// 
        /// It's good/common practice that an interface is defined with a capital
        /// "I" at the beginning -> IEntity, ILivingEntity
        /// </summary>
        public WorkerbeeEntity()
        {
        }
    }
}

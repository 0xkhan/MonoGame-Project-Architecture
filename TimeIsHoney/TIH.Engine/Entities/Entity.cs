using System;
namespace TimeIsHoney.TIH.Engine.Entities
{
    public class Entity
    {
        /// <summary>
        /// In this class all the properties and methods that are common to
        /// all the entities can be defined. This class will only be used to
        /// extend other classes that are specific to a particular entity.
        ///
        /// HERE ARE MOSTLY PROPERTIES AND GETTERS & SETTERS
        ///
        /// We'll have for example "Living Entities, Nonliving Entities etc"
        /// They're all Entities but have different characteristics therefore
        /// they'll have different properties.
        ///
        /// The classes for each specific entity are also created in entities
        /// folder so we can avoide using relative paths.
        /// Specific entities = HoneybeeEntity, QueenbeeEntity etc.
        ///
        /// It's also good practice that we use Interfaces for empty properties
        /// and empty methods. But we'll see how this works out.
        /// </summary>
        public Entity()
        {
        }
    }
}

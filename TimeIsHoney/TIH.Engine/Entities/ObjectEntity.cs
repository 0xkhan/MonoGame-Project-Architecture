using System;
namespace TimeIsHoney.TIH.Engine.Entities
{
    public class ObjectEntity : Entity
    {
        /// <summary>
        /// Object entities are nonliving entities. They're for example flowers,
        /// trees, stones, honeycomb cells etc.
        ///
        /// This class will also define honeycomb cells. We'll have different cells
        /// e.g honey cells, larva cells, Queen cell, Lab cell and Kitchen cell.
        ///
        /// It's also good practice that we use Interfaces for empty properties
        /// and empty methods. But we'll see how this works out.
        /// </summary>
        public ObjectEntity()
        {
        }
    }
}

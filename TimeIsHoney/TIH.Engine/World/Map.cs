using System;
namespace TimeIsHoney.TIH.Engine.World
{
    public class Map
    {

        /// <summary>
        /// Here we'll generate the map. The map is plain land where the objects
        /// are generated that the player interact with. Basically it's the whole
        /// background where all the interactions are happening.
        ///
        /// If the player were to leave the map and want to do something outside
        /// the map there will be no interactions.
        ///
        /// This class will not generate the map all by itself. We will be needing
        /// some classes like Terrain generator, Biome generator, a class for
        /// determining regions and kooridinate calculation etc. We'll see how
        /// many classes we're gonna need.
        /// </summary>
        public Map()
        {
        }
    }
}

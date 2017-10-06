using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// the character class the player uses in the game
    /// </summary>
    public class Traveler : Character
    {
        #region ENUMERABLES


        #endregion

        #region FIELDS
        private String _homePlanet;

        private Boolean _hasTraveledBefore;



        #endregion


        #region PROPERTIES
        public String HomePlanet
        {
            get { return _homePlanet; }
            set { _homePlanet = value; }
        }

        public Boolean HasTraveled

        {
            get { return _hasTraveledBefore; }
            set { _hasTraveledBefore = value; }
        }
        #endregion


        #region CONSTRUCTORS

        public Traveler()
        {

        }

        public Traveler(string name, RaceType race, int spaceTimeLocationID) : base(name, race, spaceTimeLocationID)
        {

        }

        #endregion


        #region METHODS

        public override string Greeting()
        {
            return $"Hello my name is {base.Name}, I am a {base.Race} and from {HomePlanet}";
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    /**
     * <summary>
     * This class defines a Hero
     * </summary>
     * @class Hero
     * @field {int} _strength 
     * @field {int} _speed 
     * @field {int} _health 
     * @field {string} _name
     * 
     */
    public class Hero
    {
        //PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;

        //PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This is a public property for _name field
         * </summary>
         * 
         * @property {string} Name
         */

        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        //CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This is the default empty constructor for the Hero class
         * </summary>
         * 
         * @constructor Hero
         * 
         */
        public Hero()
        {
        //Initialize public properties

            this.Name = "unknown name!";
        }

        /**<summary>
         * This is the constructor that takes name as a parameter and passes it to the _name private instance variable 
         * </summary>
         * 
         * @constructor Hero
         * @param {string} name
         * 
         */
        public Hero(string name)
        {
            this.Name = name;
        }
        /**<summary>
         * This is the constructor that call the generateAbilities method
         * </summary>
         * 
         * @constructor Hero
         */

        //+++++++++++++++++++++++++++++++++++++++++++

    }
}

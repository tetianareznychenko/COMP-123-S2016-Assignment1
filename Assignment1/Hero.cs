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

        //PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method randomly generates the ability numbers for the strength, speed and health properties.
         * </summary>
         * 
         * @method _generateAbilities()
         * @return {void}
         */
        private void _generateAbilities()
        {
            Random rnd = new Random();
            _strength = rnd.Next(1, 100); 
            _speed = rnd.Next(1, 100);   
            _health = rnd.Next(1,100); 
        }

        /**
         * <summary>
         * This method randomly determine if the Hero hits (this should be only 20% of the time) otherwise it will return false
         * </summary>
         * 
         * @method _ghitAttempt()
         * @return {bool}
         */
        private bool _hitAttempt()
        {
            Random gen = new Random();
            int prob = gen.Next(100);
            if (prob < 20)
                return true;
            else
                return false;
        }
        /**
         * <summary>
         * This method calculates the damage the Hero causes to the targeton a hit
         * </summary>
         * 
         * @method _hitDamage()
         * @return {int}
         */
        private int _hitDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(1, 6) * _strength;
            return (damage);
        }
    }
}

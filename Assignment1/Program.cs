using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    /**
     * Author name: Tetiana Reznychenko
     * Student number: 300870231
     * 
     * @class Program 
     */
    class Program
    {
        /**
         * The main method for driver class Program 
         * 
         * @method Main 
         * @param {string[]} args
         */

        static void Main(string[] args)
        {
            //create a new istance of the Hero class
            Hero blitzkrieg = new Hero("Blitzkrieg");
            blitzkrieg.Fight();
            blitzkrieg.Show();

        }
    }
}

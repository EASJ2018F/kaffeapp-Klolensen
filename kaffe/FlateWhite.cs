using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    class FlateWhite : Kaffe , Imælk
    {


        /// <summary>
        /// Returns the price of a Flate White
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            return 45;
        }

        /// <summary>
        /// Returns the amount of milk in a Flate White in Milliliters
        /// </summary>
        /// <returns></returns>
        public int MlMælk()
        {
            return 160;
        }

        /// <summary>
        /// Returns the strength of a Flate White
        /// </summary>
        /// <returns></returns>
        public override string Styrke()
        {
            return "Mild";
        }
    }
}

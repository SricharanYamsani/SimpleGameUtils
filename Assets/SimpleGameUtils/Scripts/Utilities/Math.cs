using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleGameUtils
{
    public class Math
    {
        /// <summary>
        /// This function maps the value in the current range to a new range and returns the new value.
        /// </summary>
        /// <param name="min">Minimum of the current Range.</param>
        /// <param name="max">Maximum of the current Range.</param>
        /// <param name="valueInRange">Value to map.</param>
        /// <param name="newMin">Minimum of the new range</param>
        /// <param name="newMax">Maximum of the new range</param>
        /// <returns></returns>
        public static float Remap(float min, float max, float valueInRange, float newMin, float newMax)
        {
            /* Steps :
             * 1. Get valueInRange as a value in [0,1] (Assuming the valueInRange falls in between min and max)
             * 2. Convert the fraction to the new range.
            */

            return newMin + ((valueInRange - min) / (max - min)) * (newMax - newMin);
        }
    }
}

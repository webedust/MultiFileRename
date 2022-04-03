using System;

namespace Dustin
{
    // Created by Dustin Weber
    /// <summary> Common C# functions </summary>
    public static class Utils
    {
        /// <summary> Converts bool to int </summary>
        /// <returns> 1 if True, 0 if False </returns>
        public static int BoolToInt(bool b)
        {
            if (b) return 1;
            else return 0;
        }

        /// <summary> Converts int to bool </summary>
        /// <param name="i">Int to convert</param>
        /// <returns>True if 1, False if 0. Throws error if any other value is provided.</returns>
        public static bool IntToBool(int i)
        {
            if (i == 1) return true;
            else if (i == 0) return false;
            throw new ArgumentOutOfRangeException($"Int with value {i} can not be converted to a bool.");
        }
    }
}

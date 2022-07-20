using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileRename
{
    /// <summary> Autocompletes common end patterns based on the starting pattern entered by the user. </summary>
    internal static class Autocomplete
    {
        /// <summary>
        /// Autocompletes/autofills the end pattern string based on specified start pattern text.
        /// </summary>
        /// <param name="start"> Start pattern to get autocomplete end pattern string for. </param>
        /// <returns> End pattern string associated with the pattern start. </returns>
        public static string FillEndPattern(string start)
        {
            return start switch
            {
                " [" or "[" => "]",
                "  (" or " (" or "(" => ")",
                _ => null
            };
        }
    }
}

using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {
        /// <summary>
        /// Converts an array of strings into a comma-separated string, with optional quotation marks around each item.
        /// </summary>
        /// <param name="items">The input array of strings.</param>
        /// <param name="quote">An optional quote character to wrap each item; can be null.</param>
        /// <returns>A single string with each item separated by a comma, and optionally wrapped in the provided quote character.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the input array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the input array is empty.</exception>
  
  
        public static string ToCommaSeparatedList(string[] items, string quote)
        {

            // Add validation
            if (items == null)
                throw new ArgumentNullException(nameof(items));
            
            if (items.Length == 0)
                throw new ArgumentException("Items array cannot be empty", nameof(items));

            // Handle null quote
            quote ??= string.Empty;

            var result = new StringBuilder($"{quote}{items[0] ?? string.Empty}{quote}");


           for (int i = 1; i < items.Length; i++)
            {
                result.Append($", {quote}{items[i] ?? string.Empty}{quote}");
            }
            return result.ToString();
        }
    }
}

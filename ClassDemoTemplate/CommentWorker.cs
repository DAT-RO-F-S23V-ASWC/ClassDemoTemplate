using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoTemplate
{
    /// <summary>
    /// Silly class to demonstrate comments
    /// </summary>
    public class CommentWorker
    {

        /// <summary>
        /// Takes the n-parameter and mulitiply by x
        /// </summary>
        /// <param name="x">The mulitiplier </param>
        /// <param name="n">the strin of an integer only 2 and 3 is allowed</param>
        /// <returns>The x multiplied by n</returns>
        /// <exception cref="ArgumentNullException">if the string n i null or empty</exception>
        /// <exception cref="ArgumentException">if n is outside 2 or 3 ythen it is not supported</exception>
        /// <exception cref="NotImplementedException">dummy</exception>
        public int SomeMethod(int x, String n)
        {
            if (string.IsNullOrWhiteSpace(n)) throw new ArgumentNullException("n must have a value but was null or empty");
            if (!(n == "2" || n == "3")) throw new ArgumentException("Only '2' or '3' is supported but was " + n);
            switch (n)
            {
                case "2": return x * 2;
                case "3": return x * 3;
            }
            throw new NotImplementedException("");
        }

    }
}

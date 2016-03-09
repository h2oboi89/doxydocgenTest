namespace HelloLib
{
    /// <summary>
    /// Greeter
    /// </summary>
    public class Hello
    {
        /// <summary>
        /// Message to greet entity with.
        /// </summary>
        private readonly string _greeting;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">Name of entity to greet.</param>
        public Hello(string name = null)
        {
            this._greeting = $"Hello, {name ?? "World"}!";
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return this._greeting;
        }
    }
}

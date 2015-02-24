namespace ToDoSample.WebApi
{
    /// <summary>
    /// The ToDo item.
    /// </summary>
    public class ToDoItem
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether completed.
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public long Id { get; set; }
    }
}

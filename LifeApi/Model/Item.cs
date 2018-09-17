namespace LifeApi.Model
{
    /// <summary>
    /// The information for each item being recorded/tracked.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Name of Item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Date the item was acquired.
        /// </summary>
        public string DateAcquired { get; set; }

        /// <summary>
        /// The original value of the item, at the time acquired.
        /// </summary>
        public int OriginalValue { get; set; }

        /// <summary>
        /// The location that the item is stored.
        /// </summary>
        public string Location { get; set; }
    }
}
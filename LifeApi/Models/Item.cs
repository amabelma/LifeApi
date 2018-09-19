using LifeApi.Models.Enums;
using System.Collections.Generic;

namespace LifeApi.Models
{
    /// <summary>
    /// The information for each item being recorded/tracked.
    /// </summary>
    public class Item
    {
        public Item(
            string title,
            string name,
            int number,
            string dateAcquired,
            string dateRemoved,
            double originalValue,
            Location location,
            string description,
            List<string> keywords
        )
        {
            this.Title = title;
            this.Name = name;
            this.number = number;
            this.DateAcquired = dateAcquired;
            this.DateRemoved = dateRemoved;
            this.OriginalValue = originalValue;
            this.Location = location;
            this.Description = description;
            this.Keywords = keywords;
        }

        /// <summary>
        /// The formal title of the item (usually the product name).
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Name of Item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The number of items in possesion.
        /// </summary>
        public int number { get; set; }

        /// <summary>
        /// Date the item was acquired, in format MMddyyyy.
        /// </summary>
        public string DateAcquired { get; set; }

        /// <summary>
        /// Date the item was removed, in format MMddyyyy.
        /// </summary>
        public string DateRemoved { get; set; }

        /// <summary>
        /// The original value of the item, at the time acquired/purchased.
        /// </summary>
        public double OriginalValue { get; set; }

        /// <summary>
        /// The location that the item is stored.
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// Description of the item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A list of keywords for the item, used for indexing and searches to the database.
        /// </summary>
        public List<string> Keywords { get; set; }
    }
}
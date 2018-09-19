using System;

namespace LifeApi.Helpers.Interfaces
{
    /// <summary>
    /// Will format dates as strings as expected by the database.
    /// </summary>
    public interface IDateTimeHelper
    {
        /// <summary>
        /// Will return the current date as a string in MMddyyyy format.
        /// </summary>
        /// <returns>The current date as a string in MMddyyyy format.</returns>
        string CurrentDateStamp();

        /// <summary>
        /// Will return the provided date as a string in MMddyyyy format.
        /// </summary>
        /// <returns>The provided date as a string in MMddyyyy format.</returns>
        string GenerateDateStamp(DateTime time);
    }
}
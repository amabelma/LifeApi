using System;
using LifeApi.Helper.Interfaces;

namespace LifeApi.Helper
{
    /// <inheritdoc />
    public class DateTimeHelper : IDateTimeHelper
    {
        /// <inheritdoc />
        public string CurrentDateStamp()
        {
            return DateTime.Now.ToString("MMddyyyy");
        }

        /// <inheritdoc />
        public string GenerateDateStamp(DateTime time)
        {
            return time.ToString("MMddyyyy");
        }
    }
}
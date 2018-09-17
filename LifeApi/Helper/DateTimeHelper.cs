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
            string dateStamp = String.Empty;

            if (time != DateTime.MinValue)
            {
                dateStamp = time.ToString("MMddyyyy");
            }

            return dateStamp;
        }
    }
}
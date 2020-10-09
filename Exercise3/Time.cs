using System;

namespace Exercise3
{
    class Time
    {
        #region Fields
        public int Hour { get; set; }
        public int Minute { get; set; }
        #endregion

        #region Constructors
        public Time(int Hour, int Minute)
        {
            if (Hour < 0 || Hour > 23)
                throw new ArgumentException("Error: Time.Hour type.");

            if (Minute < 0 || Minute > 59)
                throw new ArgumentException("Error: Time.Minute type.");

            this.Hour = Hour; this.Minute = Minute;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            string hourAsString = Hour.ToString();
            string minuteAsString = Minute.ToString();

            if (hourAsString.Length == 1)
                hourAsString = "0" + hourAsString;
            if (minuteAsString.Length == 1)
                minuteAsString = "0" + minuteAsString;

            return $"{hourAsString}:{minuteAsString}";
        }
        #endregion
    }
}

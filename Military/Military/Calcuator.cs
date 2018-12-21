using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public static class Calcuator
    {
        //accepts distance and speed and returns time in minutes
        public static int minutesTime(int distance, int consuption)
        {
            return (distance / consuption)*60;
        }
    }
}

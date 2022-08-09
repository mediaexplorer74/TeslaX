using System;
using System.Collections.Generic;
using System.Text;

namespace TeslaX.ViewModels
{
    public class HistoricalPower
    {
        public HistoricalPower(DateTime date, double power)
        {
            Date = date;
            Power = power;
        }

        public DateTime Date { get; set;  }

        public Double Power { get; set;  }
    }
}

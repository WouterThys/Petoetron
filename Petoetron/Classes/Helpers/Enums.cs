using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Classes.Helpers
{
    public enum MaterialUnit
    {
        lm = 0,
        kg
    }

    public enum DocumentType
    {
        Empty = 0,
        Pdf = 1,
        Image = 2,
        Text = 3,
        Excel = 4,
        Csv = 5
    }

    public enum PriceTypeUnit
    {
        PerHour = 0,
        PerKm = 1,
        PerKg = 2,
        PerM = 3,
        Fixed = 4
    }
}

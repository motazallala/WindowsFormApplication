using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlassFactory.Data.Model.LookupsData;

public class LookupsData
{
    public enum Status
    {
        Pending,
        Processing,
        Dispatched,
        Delivered,
    }
}
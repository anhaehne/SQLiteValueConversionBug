using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteValueConversionBug.Models
{
    public class BaseModel
    {
        public SubModel SubModel { get; set; } = default!;
    }
}

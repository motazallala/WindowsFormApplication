using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GlassFactory.Data.Model.LookupsData.LookupsData;

namespace GlassFactory.Data.Model
{
    public class Piece
    {
        public int PieceID { get; set; }
        public double height { get; set; }
        public double Width { get; set; }
        public Status Status { get; set; }
        public int CustomerID { get; set; }
        public int OrderItemId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual OrderItem OrderItem { get; set; }
    }
}
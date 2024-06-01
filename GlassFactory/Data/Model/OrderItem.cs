using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlassFactory.Data.Model;

public class OrderItem
{
    public int OrderItemId { get; set; }
    public int OrderId { get; set; }
    public int PieceID { get; set; }
    public double height { get; set; }
    public double Width { get; set; }
    public virtual Order Order { get; set; }
    public virtual Piece Piece { get; set; }
}
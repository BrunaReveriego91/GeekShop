using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeekShopping.ProductAPI.Model.Base
{
    public class BaseEntity
    {
        [KeyAttribute]
        [ColumnAttribute("id")]
        public long Id { get; set; }
    }
}
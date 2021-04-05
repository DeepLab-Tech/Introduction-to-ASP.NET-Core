using System;

namespace Models.Base
{
    public class Base
    {
        public bool IsActive  { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime AddingDate { get; set; }
        public DateTime DeletingDate { get; set; }
        public int Status { get; set; }
    }
}
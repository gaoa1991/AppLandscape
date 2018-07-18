using System.ComponentModel.DataAnnotations;

namespace ApplicationLandscape.SQL
{
    public class IPAddress
    {
        [Key]
        public string IP { get; set; }
        public Entity Entity { get; set; }
        public string IPType { get; set; }
    }
}
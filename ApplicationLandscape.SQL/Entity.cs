using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationLandscape.SQL
{
    public class Entity
    {
        public string UcmdbId { get; set; }
        public string CiId { get; set; }
        public string CiName { get; set; }
        public string CiType { get; set; }
        public string CiSubtype { get; set; }
        public string Status { get; set; }
        public string Environment { get; set; }
        public string Description { get; set; }
        public string BusinessOwner { get; set; }
        public string BusOwnerDept { get; set; }
        public string GpvernanceOwner { get; set; }
        public string GovConfigAdminGroup { get; set; }
        public string Location { get; set; }
        public string LocationComments { get; set; }
        public Vendor Vendor { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
using System;

namespace ApplicationLandscape.SQL
{
    public class Hardware:Entity
    {
        public string Id { get; set; }
        public string AssetTag { get; set; }
        public string ModelName { get; set; }
        public string ModelManuafacturer { get; set; }
        public string ModelDescription { get; set; }
        public string Version { get; set; }
        public string SerialNumber { get; set; }
        public string ExternalId { get; set; }
        public DateTime WarrantyExpiration { get; set; }
        public string MachineName { get; set; }
        public string OperationSystem { get; set; }
        public string OSVersion { get; set; }
        public int PhysicalMemory { get; set; }
        public int AllocatedCpu { get; set; }
        public string PrimaryMAC { get; set; }
        public string AllMacAddresses { get; set; }
        public string NetmorkName { get; set; }
    }
}
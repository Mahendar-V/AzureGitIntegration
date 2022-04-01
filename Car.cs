using System;
using System.Collections.Generic;

#nullable disable

namespace AzureGitIntegration
{
    public partial class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ModelNumber { get; set; }
        public string ManufactureYear { get; set; }
        public string Manufacturer { get; set; }
        public double? Rating { get; set; }
    }
}

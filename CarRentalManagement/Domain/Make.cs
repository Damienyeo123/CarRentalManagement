using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Domain
{
    public class Make : BaseDomainModel
    {
        public string? Name { get; set; }
    }
}

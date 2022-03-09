using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherWebSiteApp.Data.Models;

namespace TeacherWebSiteApp.Data.Configurations
{
    public class PublicationConfiguration : IEntityTypeConfiguration<Publication>
    {
        public void Configure(EntityTypeBuilder<Publication> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Text).HasMaxLength(200).IsRequired();
            //builder.Property(p => p.Attachments).IsRequired();
        }
    }
}

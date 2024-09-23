using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyContact.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.Data.EntityConfigs
{
    public class NumberConfig : IEntityTypeConfiguration<MyNumber>
    {
        public void Configure(EntityTypeBuilder<MyNumber> builder)
        {
            builder.HasKey(x => x.NumberId);

            builder.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(11);
        }
    }
}

﻿using Dashboard.Core.WalletAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Infrastructure.Data.Config
{
    public class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.ToTable("Wallets").HasKey(x=>x.Id);
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.OwnsOne(p => p.Currency, p =>
            {
                p.Property(pp => pp.Code).HasColumnName("Currency");
            });
            builder.Property(p=>p.Name).HasMaxLength(ColumnConstants.DEFAULT_NAME_LENGTH);
      
        }
    }
}

﻿using DLL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DLL.Configurations
{
	internal class WordConfiguration : IEntityTypeConfiguration<Word>
	{
		public void Configure(EntityTypeBuilder<Word> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Id)
					.ValueGeneratedOnAdd();
		}
	}
}
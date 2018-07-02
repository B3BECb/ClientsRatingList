using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

using CarList.Framework;

namespace CarList.Datastorage
{
	public class Clients
	{
		class Configuration : IEntityTypeConfiguration<Clients>
		{
			public Configuration()
			{
				ToTable("Clients");

				HasKey(e => e.Id);

				Property(e => e.Id)
					.HasColumnName("Id")
					.IsRequired()
					.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

				Property(e => e.PhoneNumber)
					.HasColumnName("PhoneNumber")
					.IsRequired();

				Property(e => e.FullName)
					.HasColumnName("FullName")
					.IsRequired();

				Property(e => e.Comment)
					.HasColumnName("Comment")
					.IsOptional();

				Property(e => e.Status)
					.HasColumnName("Status")
					.IsRequired();
			}
		}

		public static EntityTypeConfiguration<Clients> GetConfiguration()
		{
			return new Configuration();
		}

		public long Id { get; set; }

		public string PhoneNumber { get; set; }

		public string FullName { get; set; }

		public string Comment { get; set; }

		public Status Status { get; set; }
	}
}

using System;
using System.Data.Entity;

namespace CarList.Datastorage
{
	public class Context : DbContext
	{
		static Context()
		{
			Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
		}

		public Context(string connectionString)
			: base(connectionString)
		{
		}

		public Context()
			: base()
		{
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(Clients.GetConfiguration());
			base.OnModelCreating(modelBuilder);
		}

		/// <summary>Конфигурирует контекст только для чтения данных.</summary>
		public void ConfigureAsFetchOnly()
		{
			Configuration.AutoDetectChangesEnabled = false;
			Configuration.LazyLoadingEnabled = false;
			Configuration.ProxyCreationEnabled = false;
		}
	}
}

using System;
using System.Data.Linq;
using System.Linq;
using Microsoft.Phone.Data.Linq;

namespace AsthmaTracker.Models
{
    public class AsthmaTrackerDataContext : DataContext
    {
        private const string DATA_CONTEXT_URL = "";

        public AsthmaTrackerDataContext()
            : base(DATA_CONTEXT_URL)
        {
            if (!this.DatabaseExists())
                this.CreateDatabase();
            DatabaseSchemaUpdater updater = Extensions.CreateDatabaseSchemaUpdater(this);
            if (updater.DatabaseSchemaVersion < 0)
                ApplyUpdates();
        }

        private void ApplyUpdates()
        {
            throw new NotImplementedException();
        }
    }
}
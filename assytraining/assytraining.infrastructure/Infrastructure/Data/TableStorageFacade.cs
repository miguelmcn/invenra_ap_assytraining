using Azure;
using Azure.Data.Tables;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;

namespace assytraining.infrastructure.Infrastructure.Data
{
    internal class TableStorageFacade
    {
        private static TableStorageFacade? instance;

        private TableStorageFacade() { }

        public static TableStorageFacade GetInstance()
        {
            return instance ??= new TableStorageFacade();
        }

        public async Task<Dictionary<string, string>> GetData(string query)
        {
            Dictionary<string, string> result = new();

            var kvUri = new Uri($"https://assytrainningkv.vault.azure.net/");

            var client = new SecretClient(kvUri, new DefaultAzureCredential());
            var key = await client.GetSecretAsync("TableStorageConnString");

            var tableClient = new TableClient(
                new Uri("https://devinvenrastoragetable.table.core.windows.net/"),
                "Configurations",
                new TableSharedKeyCredential("devinvenrastoragetable", key.Value.Value));

            Pageable<TableEntity> queryResultsFilter = tableClient.Query<TableEntity>(filter: query);

            foreach (TableEntity qEntity in queryResultsFilter)
            {
                result.Add(qEntity.GetString("RowKey"), qEntity.GetString("type"));
            }

            return result;
        }
    }
}

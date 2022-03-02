using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tour_Planning_Tool.DataAccessLayer.Mappers
{
    public class ConfigMapper
    {
        public ConfigMapper(string connectionString, string dBUser, string dBPassword, string postgresDoubleEntry, string mapQuestKey, string mapQuestSecret)
        {
            ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            DBUser = dBUser ?? throw new ArgumentNullException(nameof(dBUser));
            DBPassword = dBPassword ?? throw new ArgumentNullException(nameof(dBPassword));
            PostgresDoubleEntry = postgresDoubleEntry ?? throw new ArgumentNullException(nameof(postgresDoubleEntry));
            MapQuestKey = mapQuestKey ?? throw new ArgumentNullException(nameof(mapQuestKey));
            MapQuestSecret = mapQuestSecret ?? throw new ArgumentNullException(nameof(mapQuestSecret));
        }

        [JsonPropertyName("connectionString")]
        public string ConnectionString { get; private set; }
        [JsonPropertyName("username")]
        public string DBUser { get; private set; }
        [JsonPropertyName("password")]
        public string DBPassword { get; private set; }

        [JsonPropertyName("postgresDoubleEntryCode")]
        public string PostgresDoubleEntry { get; private set; }

        [JsonPropertyName("mapQuestKey")]
        public string MapQuestKey { get; private set; }

        [JsonPropertyName("mapQuestSecret")]
        public string MapQuestSecret { get; private set; }

    }
}

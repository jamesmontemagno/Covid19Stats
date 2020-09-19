using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Covid19Stats
{
    public class AllCountriesData
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Coordinates
        {
            [JsonPropertyName("latitude")]
            public double? Latitude { get; set; }

            [JsonPropertyName("longitude")]
            public double? Longitude { get; set; }
        }

        public class Today
        {
            [JsonPropertyName("deaths")]
            public int Deaths { get; set; }

            [JsonPropertyName("confirmed")]
            public int Confirmed { get; set; }
        }

        public class Calculated
        {
            [JsonPropertyName("death_rate")]
            public double? DeathRate { get; set; }

            [JsonPropertyName("recovery_rate")]
            public double? RecoveryRate { get; set; }

            [JsonPropertyName("recovered_vs_death_ratio")]
            public object RecoveredVsDeathRatio { get; set; }

            [JsonPropertyName("cases_per_million_population")]
            public int CasesPerMillionPopulation { get; set; }
        }

        public class LatestData
        {
            [JsonPropertyName("deaths")]
            public int Deaths { get; set; }

            [JsonPropertyName("confirmed")]
            public int Confirmed { get; set; }

            [JsonPropertyName("recovered")]
            public int Recovered { get; set; }

            [JsonPropertyName("critical")]
            public int Critical { get; set; }

            [JsonPropertyName("calculated")]
            public Calculated Calculated { get; set; }
        }

        public class Datum
        {
            [JsonPropertyName("coordinates")]
            public Coordinates Coordinates { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("code")]
            public string Code { get; set; }

            [JsonPropertyName("population")]
            public int? Population { get; set; }

            [JsonPropertyName("updated_at")]
            public DateTime UpdatedAt { get; set; }

            [JsonPropertyName("today")]
            public Today Today { get; set; }

            [JsonPropertyName("latest_data")]
            public LatestData LatestData { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("data")]
            public List<Datum> Data { get; set; }

            [JsonPropertyName("_cacheHit")]
            public bool CacheHit { get; set; }
        }
    }

    public class SpecificCountryData
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Coordinates
        {
            [JsonPropertyName("latitude")]
            public int Latitude { get; set; }

            [JsonPropertyName("longitude")]
            public int Longitude { get; set; }
        }

        public class Today
        {
            [JsonPropertyName("deaths")]
            public int Deaths { get; set; }

            [JsonPropertyName("confirmed")]
            public int Confirmed { get; set; }
        }

        public class Calculated
        {
            [JsonPropertyName("death_rate")]
            public double DeathRate { get; set; }

            [JsonPropertyName("recovery_rate")]
            public double RecoveryRate { get; set; }

            [JsonPropertyName("recovered_vs_death_ratio")]
            public object RecoveredVsDeathRatio { get; set; }

            [JsonPropertyName("cases_per_million_population")]
            public int CasesPerMillionPopulation { get; set; }
        }

        public class LatestData
        {
            [JsonPropertyName("deaths")]
            public int Deaths { get; set; }

            [JsonPropertyName("confirmed")]
            public int Confirmed { get; set; }

            [JsonPropertyName("recovered")]
            public int Recovered { get; set; }

            [JsonPropertyName("critical")]
            public int Critical { get; set; }

            [JsonPropertyName("calculated")]
            public Calculated Calculated { get; set; }
        }

        public class Timeline
        {
            [JsonPropertyName("updated_at")]
            public DateTime UpdatedAt { get; set; }

            [JsonPropertyName("date")]
            public string Date { get; set; }

            [JsonPropertyName("deaths")]
            public int Deaths { get; set; }

            [JsonPropertyName("confirmed")]
            public int Confirmed { get; set; }

            [JsonPropertyName("recovered")]
            public int Recovered { get; set; }

            [JsonPropertyName("new_confirmed")]
            public int NewConfirmed { get; set; }

            [JsonPropertyName("new_recovered")]
            public int NewRecovered { get; set; }

            [JsonPropertyName("new_deaths")]
            public int NewDeaths { get; set; }

            [JsonPropertyName("active")]
            public int Active { get; set; }
        }

        public class Data
        {
            [JsonPropertyName("coordinates")]
            public Coordinates Coordinates { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("code")]
            public string Code { get; set; }

            [JsonPropertyName("population")]
            public int Population { get; set; }

            [JsonPropertyName("updated_at")]
            public DateTime UpdatedAt { get; set; }

            [JsonPropertyName("today")]
            public Today Today { get; set; }

            [JsonPropertyName("latest_data")]
            public LatestData LatestData { get; set; }

            [JsonPropertyName("timeline")]
            public List<Timeline> Timeline { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("data")]
            public Data Data { get; set; }

            [JsonPropertyName("_cacheHit")]
            public bool CacheHit { get; set; }
        }
    }
}

﻿using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19Stats
{
    public static class CovidService
    {
        public static async Task UpdateCountryData(string country = "")
        {
            try
            {
                var path = SettingsService.DirectoryPath;
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                var client = new HttpClient();
                if (!string.IsNullOrWhiteSpace(country))
                {
                    country = country.ToLowerInvariant();
                    var stream = await client.GetStreamAsync($"https://corona-api.com/countries/{country}");

                    var data = await JsonSerializer.DeserializeAsync<SpecificCountryData.Root>(stream);

                    await Task.Run(() =>
                    {
                        File.WriteAllText(Path.Combine(path, $"{country}-population.txt"), data.Data.Population.ToString());
                        File.WriteAllText(Path.Combine(path, $"{country}-total-deaths.txt"), data.Data.LatestData.Deaths.ToString());
                        File.WriteAllText(Path.Combine(path, $"{country}-total-confirmed.txt"), data.Data.LatestData.Confirmed.ToString());
                        File.WriteAllText(Path.Combine(path, $"{country}-total-recovered.txt"), data.Data.LatestData.Recovered.ToString());
                        File.WriteAllText(Path.Combine(path, $"{country}-total-critical.txt"), data.Data.LatestData.Critical.ToString());
                        File.WriteAllText(Path.Combine(path, $"{country}-calculated-deathrate.txt"), data.Data.LatestData.Calculated.DeathRate.ToString());
                        File.WriteAllText(Path.Combine(path, $"{country}-calculated-recoveryrate.txt"), data.Data.LatestData.Calculated.RecoveryRate.ToString());
                        File.WriteAllText(Path.Combine(path, $"{country}-calculated-casespermillion.txt"), data.Data.LatestData.Calculated.CasesPerMillionPopulation.ToString());
                    });
                }
                else
                {
                    var stream = await client.GetStreamAsync($"https://corona-api.com/countries");
                    var data = await JsonSerializer.DeserializeAsync<AllCountriesData.Root>(stream);

                    foreach(var d in data.Data)
                    {
                        country = d.Code.ToLowerInvariant();
                        await Task.Run(() =>
                        {
                            File.WriteAllText(Path.Combine(path, $"{country}-population.txt"), d.Population.ToString());
                            File.WriteAllText(Path.Combine(path, $"{country}-total-deaths.txt"), d.LatestData.Deaths.ToString());
                            File.WriteAllText(Path.Combine(path, $"{country}-total-confirmed.txt"), d.LatestData.Confirmed.ToString());
                            File.WriteAllText(Path.Combine(path, $"{country}-total-recovered.txt"), d.LatestData.Recovered.ToString());
                            File.WriteAllText(Path.Combine(path, $"{country}-total-critical.txt"), d.LatestData.Critical.ToString());
                            File.WriteAllText(Path.Combine(path, $"{country}-calculated-deathrate.txt"), d.LatestData.Calculated.DeathRate.ToString());
                            File.WriteAllText(Path.Combine(path, $"{country}-calculated-recoveryrate.txt"), d.LatestData.Calculated.RecoveryRate.ToString());
                            File.WriteAllText(Path.Combine(path, $"{country}-calculated-casespermillion.txt"), d.LatestData.Calculated.CasesPerMillionPopulation.ToString());
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
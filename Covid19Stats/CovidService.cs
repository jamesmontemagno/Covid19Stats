using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19Stats
{
    public static class CovidService
    {
        public static List<Country> Countries { get; }
        
        public static async Task UpdateCountryData(string country = "", bool worldData = true)
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
                        File.WriteAllText(Path.Combine(path, $"{country}-population.txt"), data.Data.Population.ToString("N0"));
                        File.WriteAllText(Path.Combine(path, $"{country}-total-deaths.txt"), data.Data.LatestData.Deaths.ToString("N0"));
                        File.WriteAllText(Path.Combine(path, $"{country}-total-confirmed.txt"), data.Data.LatestData.Confirmed.ToString("N0"));
                        File.WriteAllText(Path.Combine(path, $"{country}-total-recovered.txt"), data.Data.LatestData.Recovered.ToString("N0"));
                        File.WriteAllText(Path.Combine(path, $"{country}-total-critical.txt"), data.Data.LatestData.Critical.ToString("N0"));
                        File.WriteAllText(Path.Combine(path, $"{country}-calculated-deathrate.txt"), data.Data.LatestData.Calculated.DeathRate.ToString("N4"));
                        File.WriteAllText(Path.Combine(path, $"{country}-calculated-recoveryrate.txt"), data.Data.LatestData.Calculated.RecoveryRate.ToString("N4"));
                        File.WriteAllText(Path.Combine(path, $"{country}-calculated-casespermillion.txt"), data.Data.LatestData.Calculated.CasesPerMillionPopulation.ToString("N0"));
                    });
                }
                else
                {
                    var stream = await client.GetStreamAsync($"https://corona-api.com/countries");
                    var data = await JsonSerializer.DeserializeAsync<AllCountriesData.Root>(stream);


                    //var builder = new StringBuilder();
                    //builder.AppendLine("var countries = new List<Country>()");
                    //builder.AppendLine("{");
                    foreach (var d in data.Data)
                    {
                        country = d.Code.ToLowerInvariant();
                        //builder.AppendLine($"new Country(\"{country}\", \"{d.Name}\"),");
                        await Task.Run(() =>
                        {
                            File.WriteAllText(Path.Combine(path, $"{country}-population.txt"), d.Population?.ToString("N0") ?? string.Empty);
                            File.WriteAllText(Path.Combine(path, $"{country}-total-deaths.txt"), d.LatestData.Deaths.ToString("N0"));
                            File.WriteAllText(Path.Combine(path, $"{country}-total-confirmed.txt"), d.LatestData.Confirmed.ToString("N0"));
                            File.WriteAllText(Path.Combine(path, $"{country}-total-recovered.txt"), d.LatestData.Recovered.ToString("N0"));
                            File.WriteAllText(Path.Combine(path, $"{country}-total-critical.txt"), d.LatestData.Critical.ToString("N0"));
                            File.WriteAllText(Path.Combine(path, $"{country}-calculated-deathrate.txt"), d.LatestData.Calculated.DeathRate?.ToString("N4") ?? string.Empty);
                            File.WriteAllText(Path.Combine(path, $"{country}-calculated-recoveryrate.txt"), d.LatestData.Calculated.RecoveryRate?.ToString("N4") ?? string.Empty);
                            File.WriteAllText(Path.Combine(path, $"{country}-calculated-casespermillion.txt"), d.LatestData.Calculated.CasesPerMillionPopulation.ToString("N0"));
                        });

                    }

                    //builder.AppendLine("};");

                    //var test = builder.ToString();
                }

                if (worldData)
                {

                    var stream = await client.GetStreamAsync($"https://corona-api.com/timeline");
                    var data = await JsonSerializer.DeserializeAsync<WorldData.Root>(stream);

                    var today = data.Data.FirstOrDefault(d => d.IsInProgress);
                    if (today == null)
                        return;

                    await Task.Run(() =>
                    {
                        File.WriteAllText(Path.Combine(path, $"world-total-deaths.txt"), today.Deaths.ToString("N0"));
                        File.WriteAllText(Path.Combine(path, $"world-total-confirmed.txt"), today.Confirmed.ToString("N0"));
                        File.WriteAllText(Path.Combine(path, $"world-total-recovered.txt"), today.Recovered.ToString("N0"));
                        File.WriteAllText(Path.Combine(path, $"world-new-deaths.txt"), today.NewDeaths.ToString("N0"));
                        File.WriteAllText(Path.Combine(path, $"world-new-confirmed.txt"), today.NewConfirmed.ToString("N0"));
                        File.WriteAllText(Path.Combine(path, $"world-new-recovered.txt"), today.NewRecovered.ToString("N0"));
                        File.WriteAllText(Path.Combine(path, $"world-total-active.txt"), today.Active.ToString("N0"));
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static CovidService()
        {
            Countries = new List<Country>
            {
                new Country("af", "Afghanistan"),
                new Country("al", "Albania"),
                new Country("ax", "Åland Islands"),
                new Country("as", "American Samoa"),
                new Country("dz", "Algeria"),
                new Country("ad", "Andorra"),
                new Country("ao", "Angola"),
                new Country("ai", "Anguilla"),
                new Country("ag", "Antigua and Barbuda"),
                new Country("aq", "Antarctica"),
                new Country("au", "Australia"),
                new Country("at", "Austria"),
                new Country("bh", "Bahrain"),
                new Country("bd", "Bangladesh"),
                new Country("bj", "Benin"),
                new Country("bz", "Belize"),
                new Country("ar", "Argentina"),
                new Country("am", "Armenia"),
                new Country("ba", "Bosnia and Herzegovina"),
                new Country("aw", "Aruba"),
                new Country("az", "Azerbaijan"),
                new Country("bs", "Bahamas"),
                new Country("bn", "Brunei "),
                new Country("bq", "Bonaire, Sint Eustatius and Saba"),
                new Country("by", "Belarus"),
                new Country("bb", "Barbados"),
                new Country("io", "British Indian Ocean Territory"),
                new Country("bm", "Bermuda"),
                new Country("be", "Belgium"),
                new Country("cm", "Cameroon"),
                new Country("bt", "Bhutan"),
                new Country("bo", "Bolivia"),
                new Country("kh", "Cambodia"),
                new Country("cf", "CAR"),
                new Country("bw", "Botswana"),
                new Country("td", "Chad"),
                new Country("bg", "Bulgaria"),
                new Country("bv", "Bouvet Island"),
                new Country("br", "Brazil"),
                new Country("cc", "Cocos (Keeling) Islands"),
                new Country("co", "Colombia"),
                new Country("ca", "Canada"),
                new Country("bf", "Burkina Faso"),
                new Country("bi", "Burundi"),
                new Country("cr", "Costa Rica"),
                new Country("cv", "Cape Verde"),
                new Country("ky", "Cayman Islands"),
                new Country("ck", "Cook Islands"),
                new Country("cn", "China"),
                new Country("cw", "Curaçao"),
                new Country("cy", "Cyprus"),
                new Country("cx", "Christmas Island"),
                new Country("cl", "Chile"),
                new Country("do", "Dominican Republic"),
                new Country("km", "Comoros"),
                new Country("cg", "Congo"),
                new Country("cd", "DRC"),
                new Country("dm", "Dominica"),
                new Country("gq", "Equatorial Guinea"),
                new Country("ci", "Côte d'Ivoire"),
                new Country("hr", "Croatia"),
                new Country("cu", "Cuba"),
                new Country("er", "Eritrea"),
                new Country("cz", "Czechia"),
                new Country("dk", "Denmark"),
                new Country("dj", "Djibouti"),
                new Country("fj", "Fiji"),
                new Country("fo", "Faroe Islands"),
                new Country("sv", "El Salvador"),
                new Country("eg", "Egypt"),
                new Country("tf", "French Southern Territories"),
                new Country("pf", "French Polynesia"),
                new Country("ec", "Ecuador"),
                new Country("gh", "Ghana"),
                new Country("ee", "Estonia"),
                new Country("et", "Ethiopia"),
                new Country("de", "Germany"),
                new Country("fk", "Falkland Islands"),
                new Country("fi", "Finland"),
                new Country("gd", "Grenada"),
                new Country("fr", "France"),
                new Country("gp", "Guadeloupe"),
                new Country("ga", "Gabon"),
                new Country("gf", "French Guiana"),
                new Country("gn", "Guinea"),
                new Country("gm", "Gambia"),
                new Country("gw", "Guinea-Bissau"),
                new Country("hn", "Honduras"),
                new Country("gi", "Gibraltar"),
                new Country("ge", "Georgia"),
                new Country("gr", "Greece"),
                new Country("gl", "Greenland"),
                new Country("va", "Vatican City"),
                new Country("gt", "Guatemala"),
                new Country("id", "Indonesia"),
                new Country("gg", "Guernsey"),
                new Country("in", "India"),
                new Country("gu", "Guam"),
                new Country("im", "Isle of Man"),
                new Country("il", "Israel"),
                new Country("gy", "Guyana"),
                new Country("hk", "Hong Kong"),
                new Country("ht", "Haiti"),
                new Country("hm", "Heard Island and McDonald Islands"),
                new Country("je", "Jersey"),
                new Country("hu", "Hungary"),
                new Country("is", "Iceland"),
                new Country("ir", "Iran"),
                new Country("iq", "Iraq"),
                new Country("ie", "Ireland"),
                new Country("it", "Italy"),
                new Country("jm", "Jamaica"),
                new Country("jp", "Japan"),
                new Country("kp", "Korea, Democratic People's Republic of"),
                new Country("lv", "Latvia"),
                new Country("li", "Liechtenstein"),
                new Country("mg", "Madagascar"),
                new Country("mt", "Malta"),
                new Country("yt", "Mayotte"),
                new Country("mn", "Mongolia"),
                new Country("mm", "Myanmar"),
                new Country("nc", "New Caledonia"),
                new Country("nu", "Niue"),
                new Country("jo", "Jordan"),
                new Country("kr", "S. Korea"),
                new Country("lb", "Lebanon"),
                new Country("lt", "Lithuania"),
                new Country("mw", "Malawi"),
                new Country("mh", "Marshall Islands"),
                new Country("ke", "Kenya"),
                new Country("mx", "Mexico"),
                new Country("kg", "Kyrgyzstan"),
                new Country("me", "Montenegro"),
                new Country("ki", "Kiribati"),
                new Country("lr", "Liberia"),
                new Country("la", "Laos"),
                new Country("mo", "Macao"),
                new Country("ly", "Libya"),
                new Country("mv", "Maldives"),
                new Country("mk", "North Macedonia"),
                new Country("mr", "Mauritania"),
                new Country("ml", "Mali"),
                new Country("mu", "Mauritius"),
                new Country("na", "Namibia"),
                new Country("pk", "Pakistan"),
                new Country("md", "Moldova"),
                new Country("nz", "New Zealand"),
                new Country("ma", "Morocco"),
                new Country("nf", "Norfolk Island"),
                new Country("np", "Nepal"),
                new Country("py", "Paraguay"),
                new Country("ne", "Niger"),
                new Country("mc", "Monaco"),
                new Country("mz", "Mozambique"),
                new Country("nl", "Netherlands"),
                new Country("no", "Norway"),
                new Country("ng", "Nigeria"),
                new Country("pt", "Portugal"),
                new Country("om", "Oman"),
                new Country("ru", "Russia"),
                new Country("lc", "Saint Lucia"),
                new Country("sm", "San Marino"),
                new Country("pw", "Palau"),
                new Country("sc", "Seychelles"),
                new Country("pe", "Peru"),
                new Country("si", "Slovenia"),
                new Country("pr", "Puerto Rico"),
                new Country("ss", "South Sudan"),
                new Country("rw", "Rwanda"),
                new Country("sj", "Svalbard and Jan Mayen"),
                new Country("mf", "Saint Martin"),
                new Country("tw", "Taiwan"),
                new Country("st", "Sao Tome and Principe"),
                new Country("tg", "Togo"),
                new Country("sl", "Sierra Leone"),
                new Country("tr", "Turkey"),
                new Country("sb", "Solomon Islands"),
                new Country("ua", "Ukraine"),
                new Country("es", "Spain"),
                new Country("uy", "Uruguay"),
                new Country("sz", "Swaziland"),
                new Country("vg", "British Virgin Islands"),
                new Country("tj", "Tajikistan"),
                new Country("tk", "Tokelau"),
                new Country("tm", "Turkmenistan"),
                new Country("ae", "United Arab Emirates"),
                new Country("uz", "Uzbekistan"),
                new Country("vi", "U.S. Virgin Islands"),
                new Country("zw", "Zimbabwe"),
                new Country("kz", "Kazakhstan"),
                new Country("kw", "Kuwait"),
                new Country("ls", "Lesotho"),
                new Country("lu", "Luxembourg"),
                new Country("my", "Malaysia"),
                new Country("mq", "Martinique"),
                new Country("fm", "Micronesia, Federated States of"),
                new Country("ms", "Montserrat"),
                new Country("nr", "Nauru"),
                new Country("ni", "Nicaragua"),
                new Country("mp", "Northern Mariana Islands"),
                new Country("pa", "Panama"),
                new Country("pn", "Pitcairn"),
                new Country("re", "Réunion"),
                new Country("sh", "Saint Helena, Ascension and Tristan da Cunha"),
                new Country("vc", "Saint Vincent Grenadines"),
                new Country("sn", "Senegal"),
                new Country("sx", "Sint Maarten"),
                new Country("za", "South Africa"),
                new Country("sd", "Sudan"),
                new Country("ch", "Switzerland"),
                new Country("th", "Thailand"),
                new Country("tt", "Trinidad and Tobago"),
                new Country("tv", "Tuvalu"),
                new Country("us", "USA"),
                new Country("ve", "Venezuela"),
                new Country("pg", "Papua New Guinea"),
                new Country("pl", "Poland"),
                new Country("ro", "Romania"),
                new Country("kn", "Saint Kitts and Nevis"),
                new Country("ws", "Samoa"),
                new Country("rs", "Serbia"),
                new Country("sk", "Slovakia"),
                new Country("gs", "South Georgia and the South Sandwich Islands"),
                new Country("sr", "Suriname"),
                new Country("sy", "Syria"),
                new Country("tl", "Timor-Leste"),
                new Country("tn", "Tunisia"),
                new Country("ug", "Uganda"),
                new Country("um", "United States Minor Outlying Islands"),
                new Country("vn", "Vietnam"),
                new Country("ps", "Palestine"),
                new Country("ph", "Philippines"),
                new Country("qa", "Qatar"),
                new Country("bl", "Saint Barth"),
                new Country("pm", "Saint Pierre Miquelon"),
                new Country("sa", "Saudi Arabia"),
                new Country("sg", "Singapore"),
                new Country("so", "Somalia"),
                new Country("lk", "Sri Lanka"),
                new Country("se", "Sweden"),
                new Country("tz", "Tanzania"),
                new Country("to", "Tonga"),
                new Country("tc", "Turks and Caicos"),
                new Country("gb", "UK"),
                new Country("vu", "Vanuatu"),
                new Country("wf", "Wallis and Futuna"),
                new Country("zm", "Zambia"),
                new Country("eh", "Western Sahara"),
                new Country("ye", "Yemen"),
            }.OrderBy(c => c.Name).ToList();
        }
    }
}

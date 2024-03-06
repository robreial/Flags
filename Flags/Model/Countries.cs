using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Flags.Model
{
    public class Country
    {
        public Country()
        {

        }

        public Country(int countryId, string countryName, List<string> colors, string pattern, string lineDirection, string figure, string description = null)
        {
            CountryId = countryId;
            CountryName = countryName;
            Colors = colors;
            Pattern = pattern;
            LineDirection = lineDirection;
            Figure = figure;
            Description = description;
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public List<string> Colors { get; set; }
        public string Pattern { get; set; }
        public string LineDirection { get; set; }
        public string Figure { get; set; }
        public string Description { get; set; }
    }

    public class CountryModel
    {
        public List<Country> Country { get; set; }

        public CountryModel()
        {
            Country = new List<Country>();
        }

        public Country SearchCountryByIndex(int countryId)
        {
            foreach (Country country in Country)
            {
                if (country.CountryId == countryId)
                {
                    return country;
                }
            }
            return null;
        }
        
        /// <summary>
        /// Delite country by index
        /// </summary>
        /// <param name="countryId"></param>
        public void DelByIndex(int countryId)
        {
            foreach (Country country in Country)
            {
                if (country.CountryId == countryId)
                {
                    Country.Remove(country);
                    break;
                }
            }
        }
        /// <summary>
        /// Get maxindex+1 of ListCountry
        /// </summary>
        /// <returns></returns>
        public int NewIndex()
        {
            int lastIndex =0;
            foreach (Country country in this.Country)
            {
                if (country.CountryId > lastIndex)
                {
                    lastIndex = country.CountryId;
                }
                lastIndex++;
            }
            return lastIndex;
        }
        /// <summary>
        /// Returns the countries with the applied filter
        /// </summary>
        /// <param name="name"></param>
        /// <param name="colors"></param>
        /// <param name="patern"></param>
        /// <param name="line"></param>
        /// <param name="figure"></param>
        /// <returns></returns>
        public List<Country> Filter(string name = null, List<string> colors = null, string patern = null, string line = null, string figure = null)
        {
            List<Country> filtredCountry = new List<Country>(this.Country);

            if (name != null && name != "")
                filtredCountry = filtredCountry.Where(s => s.CountryName.Contains(name)).ToList();
            if (colors != null && colors.Count > 0)
                foreach (string c in colors)
                    filtredCountry = filtredCountry.Where(s => (s.Colors.Contains(c))).ToList();
            if (patern != null && patern != "")
                filtredCountry = filtredCountry.Where(s => s.Pattern.Contains(patern)).ToList();
            if (line != null && line != "")
                filtredCountry = filtredCountry.Where(s => s.LineDirection == line).ToList();
            if (figure != null && figure != "")
                filtredCountry = filtredCountry.Where(s => s.Figure.Contains(figure)).ToList();
            return filtredCountry;
        }
        /// <summary>
        /// Returns the random country
        /// </summary>
        /// <returns></returns>
        public Country GetRandomCountry()
        {
            var random = new Random();
            int index = random.Next(Country.Count);
            return Country[index];
        }
    }

}

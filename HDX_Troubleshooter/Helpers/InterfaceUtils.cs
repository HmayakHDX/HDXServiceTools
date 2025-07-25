﻿using HDX_ServiceTools.Models;
using System.Text;
using System.Text.Json;

namespace HDX_ServiceTools.Helpers
{
    public static class InterfaceUtils
    {
        /// <summary>
        /// Loads known errors from the embedded JSON resource.
        /// Throws if the file is missing or can't be deserialized.
        /// </summary>
        public static List<T> LoadFromJSON<T>(byte[] file)
        {
            try
            {
                string jsonContent = Encoding.UTF8.GetString(file);

                List<T>? result = JsonSerializer.Deserialize<List<T>>(jsonContent);

                if (result == null || result.Count == 0)
                    throw new InvalidOperationException("The embedded JSON was empty or could not be deserialized.");

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load data from embedded resource as {typeof(T).Name}.", ex);
            }
        }

        /// <summary>
        /// Filters a list of known errors by matching search terms against the error code and message.
        /// Performs a case-insensitive search and ignores extra whitespace.
        /// </summary>
        /// <param name="errors">The list of known error entries to search through.</param>
        /// <param name="query">The user's raw search input (typically from a TextBox).</param>
        /// <returns>A filtered list of matching ErrorInfo objects. Returns an empty list if no matches are found.</returns>
        public static List<ErrorInfo> Filter(List<ErrorInfo> errors, string query)
        {
            List<string> searchWords = query
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            return errors
                .Where(error =>
                    searchWords.Any(word =>
                        error.Code.ToLower().Contains(word) ||
                        error.Message.ToLower().Contains(word)
                    )
                )
                .ToList();
        }

        // Extract just the code portion from the selected item in the ListBox
        // The format is: "ERR-007: Sentinel error detected"
        // So we split on ":" and take the first part ("ERR-007")
        public static string ExtractErrorCode(string displayString)
        {
            return displayString.Split(':')[0].Trim();
        }

        // Search the knownErrors list for the ErrorInfo object that matches this code
        public static ErrorInfo? FindByCode(List<ErrorInfo> errors, string code)
        {
            return errors.FirstOrDefault(e =>
                e.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
        }

        public static InstallationInfo? FindByOption(List<InstallationInfo> options, string option)
        {
            return options.FirstOrDefault(o =>
                o.Option.Equals(option, StringComparison.OrdinalIgnoreCase));
        }
    }
}
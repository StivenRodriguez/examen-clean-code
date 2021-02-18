using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette.Utils
{
    public class ConfigurationManager
    {
        /// <summary>
        /// IConfiguration.
        /// </summary>
        private readonly IConfiguration _configuration;

        /// <summary>
        /// ConfigurationManager.
        /// </summary>
        public ConfigurationManager()
        {
            DiscoverApplicationPath();
            _configuration = new ConfigurationBuilder()
                  .SetBasePath(ApplicationPath)
                  .AddJsonFile("appsettings.json", false, true)
                  .AddEnvironmentVariables().Build();

            SetJwtValues();
        }

        /// <summary>
        /// jwtMinutesExpirationTime.
        /// </summary>
        public int jwtMinutesExpirationTime { get; set; }

        /// <summary>
        /// jwtDefaultUserName.
        /// </summary>
        public string jwtDefaultUserName { get; set; }

        /// <summary>
        /// jwtDefaultUserPassword.
        /// </summary>
        public string jwtDefaultUserPassword { get; set; }

        /// <summary>
        /// jwtEncryptionMethod.
        /// </summary>
        public string jwtEncryptionMethod { get; set; }

        /// <summary>
        /// jwtSecretKey.
        /// </summary>
        public string jwtSecretKey { get; set; }

        /// <summary>
        /// ApplicationPath.
        /// </summary>
        public static string ApplicationPath { get; set; }

        /// <summary>
        /// SetJwtValues.
        /// </summary>
        private void SetJwtValues()
        {
            jwtMinutesExpirationTime = int.Parse(_configuration["AuthorizationJwt:jwtMinutesExpirationTime"]);
            jwtEncryptionMethod = _configuration["AuthorizationJwt:ApplicationMethodEncrypt"];
            jwtSecretKey = _configuration["AuthorizationJwt:ApplicationKey"];
        }

        /// <summary>
        /// DiscoverApplicationPath.
        /// </summary>
        public void DiscoverApplicationPath()
        {
            ApplicationPath = (Directory.GetCurrentDirectory()).Replace(".Tests\\bin\\Debug\\netcoreapp2.0", "");
        }

        /// <summary>
        /// GetSettingsValue.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetSettingsValue(string key)
        {
            return _configuration["AppSettings:" + key];
        }

    }
}

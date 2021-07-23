using Microsoft.Extensions.Configuration;
using MingChi.NorApp.CRM;
using System;

namespace MingChi.Infrastructure.Configuration
{
    /// <summary>
    /// 
    /// </summary>
    public class JsonConfigurationBuilder : IJsonConfigurationBuilder
    {
        /// <summary>
        /// 取得連線字串
        /// </summary>
        /// <returns></returns>
        public string GetConnectionString()
        {
            string basePath = System.AppContext.BaseDirectory;
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appSettings.json")
                .Build();

            return configuration.GetConnectionString("Conn");
        }
    }
}

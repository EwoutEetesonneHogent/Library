using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Library.Startup
{
    public class SecretManager
    {

        internal static class SecretsManager
        {
            private static ConfigurationManager _configurationManager;
            static SecretsManager()
            {
                _configurationManager = new();
                _configurationManager.AddUserSecrets(Assembly.GetExecutingAssembly());

            }

            internal static string GetSecret(string key)
            {
                string? secret = _configurationManager[key];
                if (string.IsNullOrWhiteSpace(secret))
                {
                    throw new InvalidOperationException($"{key} not found in configuration (secrets.json).");
                }
                return secret;
            }
        }
    }
}

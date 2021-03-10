using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appi
{
    public class IdentityServerConfiguration
    {
        public static object IdentityServerContants { get; private set; }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {

            return new List<IdentityResource>()
                {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
                };

        }
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>()
                {
                new ApiResource("API", "Api da TOTVS")
                };


        }
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client()
                {
                    ClientId = "9F26B19C-E77F-44AE-9DAB-647BD34A4755",
                    ClientName = "Web Api TOTVS",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    AllowOfflineAccess = true,
                    ClientSecrets =
                    {
                        new Secret("1234567890".Sha256())
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "API"
                    }
                }
            };
        }

        internal static IEnumerable<object> GetIdentityResouces()
        {
            throw new NotImplementedException();
        }
    }
        
}
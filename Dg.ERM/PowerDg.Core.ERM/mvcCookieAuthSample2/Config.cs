using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Test;

using System.Collections;
using IdentityServer4;

namespace mvcCookieAuthSample2
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api1","API Application")
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile() ,
                new IdentityResources.Email() 

            //("api1","API Application")
        };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api1","API Application")
            };
        }


        public static List<TestUser> GetTestUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId="10000",
                    Username="jesse", 
                    Password ="123456"
                }
            }; 
        } 

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client()
                {
                    ClientId="mvc",
                    AllowedGrantTypes=GrantTypes.Implicit,
                    ClientSecrets =
                    {
                        new   Secret("secret".Sha256())
                    },
                    RequireConsent=false,
                    RedirectUris={ "http://localhost:5001/signin-oidc"},
                    PostLogoutRedirectUris={ "http://localhost:5001/signin-callback-oidc"},
                    AllowedScopes={
                        
                    IdentityServerConstants.StandardScopes.Profile,

                      IdentityServerConstants.StandardScopes.OpenId
                    } 
                },
                new Client()
                {
                    ClientId="client",
                    AllowedGrantTypes=GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new   Secret("secret".Sha256())
                    },
                    AllowedScopes={"api"}

                },
                new Client()
                {
                    ClientId="pwdClient",
                    AllowedGrantTypes=GrantTypes.ResourceOwnerPassword,
                    ClientSecrets =
                    {
                        new   Secret("secret".Sha256())
                    },
                    RequireClientSecret =false,
                    AllowedScopes={"api"}

                }
            };
        }


    }
}

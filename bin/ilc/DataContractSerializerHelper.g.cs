using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 632
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                8, // array length: 8
                1661, // index: 1661, string: "home_oid"
                1670, // index: 1670, string: "iss"
                1674, // index: 1674, string: "name"
                1679, // index: 1679, string: "oid"
                1683, // index: 1683, string: "preferred_username"
                1702, // index: 1702, string: "sub"
                1706, // index: 1706, string: "tid"
                1710, // index: 1710, string: "ver"
                8, // array length: 8
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                -1, // string: null
                1, // array length: 1
                361, // index: 361, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal"
                4, // array length: 4
                1714, // index: 1714, string: "RefreshToken"
                1727, // index: 1727, string: "ResourceInResponse"
                1746, // index: 1746, string: "Result"
                1753, // index: 1753, string: "UserAssertionHash"
                4, // array length: 4
                361, // index: 361, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal"
                361, // index: 361, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal"
                361, // index: 361, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal"
                361, // index: 361, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal"
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                582, // index: 582, string: "http://schemas.datacontract.org/2004/07/System"
                582, // index: 582, string: "http://schemas.datacontract.org/2004/07/System"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                8, // array length: 8
                1771, // index: 1771, string: "AccessToken"
                1783, // index: 1783, string: "AccessTokenType"
                1799, // index: 1799, string: "ExpiresOn"
                1809, // index: 1809, string: "ExtendedExpiresOn"
                1827, // index: 1827, string: "ExtendedLifeTimeToken"
                255, // index: 255, string: "IdToken"
                1849, // index: 1849, string: "TenantId"
                629, // index: 629, string: "UserInfo"
                8, // array length: 8
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                582, // index: 582, string: "http://schemas.datacontract.org/2004/07/System"
                2, // array length: 2
                1858, // index: 1858, string: "DateTime"
                1867, // index: 1867, string: "OffsetMinutes"
                2, // array length: 2
                582, // index: 582, string: "http://schemas.datacontract.org/2004/07/System"
                582, // index: 582, string: "http://schemas.datacontract.org/2004/07/System"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                582, // index: 582, string: "http://schemas.datacontract.org/2004/07/System"
                -1, // string: null
                1, // array length: 1
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                7, // array length: 7
                1881, // index: 1881, string: "DisplayableId"
                1895, // index: 1895, string: "FamilyName"
                1906, // index: 1906, string: "GivenName"
                1916, // index: 1916, string: "IdentityProvider"
                1933, // index: 1933, string: "PasswordChangeUrl"
                1951, // index: 1951, string: "PasswordExpiresOn"
                1969, // index: 1969, string: "UniqueId"
                7, // array length: 7
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                11, // array length: 11
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                11, // array length: 11
                1978, // index: 1978, string: "email"
                1984, // index: 1984, string: "family_name"
                1996, // index: 1996, string: "given_name"
                2007, // index: 2007, string: "idp"
                1670, // index: 1670, string: "iss"
                1679, // index: 1679, string: "oid"
                2011, // index: 2011, string: "pwd_exp"
                2019, // index: 2019, string: "pwd_url"
                1702, // index: 1702, string: "sub"
                1706, // index: 1706, string: "tid"
                2027, // index: 2027, string: "upn"
                11, // array length: 11
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                14, // array length: 14
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                770, // index: 770, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                14, // array length: 14
                2031, // index: 2031, string: "access_token"
                2044, // index: 2044, string: "claims"
                2051, // index: 2051, string: "correlation_id"
                2066, // index: 2066, string: "created_on"
                2077, // index: 2077, string: "error"
                2083, // index: 2083, string: "error_codes"
                2095, // index: 2095, string: "error_description"
                2113, // index: 2113, string: "expires_in"
                2124, // index: 2124, string: "expires_on"
                2135, // index: 2135, string: "ext_expires_in"
                2150, // index: 2150, string: "id_token"
                2159, // index: 2159, string: "refresh_token"
                2173, // index: 2173, string: "resource"
                2182, // index: 2182, string: "token_type"
                14, // array length: 14
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                10, // array length: 10
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                10, // array length: 10
                2193, // index: 2193, string: "client_id"
                2203, // index: 2203, string: "client_info"
                1710, // index: 1710, string: "ver"
                2031, // index: 2031, string: "access_token"
                2215, // index: 2215, string: "authority"
                2124, // index: 2124, string: "expires_on"
                2150, // index: 2150, string: "id_token"
                2225, // index: 2225, string: "scope"
                2182, // index: 2182, string: "token_type"
                2231, // index: 2231, string: "user_assertion_hash"
                10, // array length: 10
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                3, // array length: 3
                2193, // index: 2193, string: "client_id"
                2203, // index: 2203, string: "client_info"
                1710, // index: 1710, string: "ver"
                3, // array length: 3
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                8, // array length: 8
                2193, // index: 2193, string: "client_id"
                2203, // index: 2203, string: "client_info"
                1710, // index: 1710, string: "ver"
                2251, // index: 2251, string: "displayable_id"
                2266, // index: 2266, string: "environment"
                2278, // index: 2278, string: "identity_provider"
                1674, // index: 1674, string: "name"
                2159, // index: 2159, string: "refresh_token"
                8, // array length: 8
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                849, // index: 849, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                2, // array length: 2
                2296, // index: 2296, string: "uid"
                2300, // index: 2300, string: "utid"
                2, // array length: 2
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                770, // index: 770, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                3, // array length: 3
                2305, // index: 2305, string: "alg"
                2309, // index: 2309, string: "typ"
                2313, // index: 2313, string: "x5c"
                3, // array length: 3
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                3, // array length: 3
                2317, // index: 2317, string: "aud"
                2321, // index: 2321, string: "iat"
                2325, // index: 2325, string: "nonce"
                3, // array length: 3
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                6, // array length: 6
                2317, // index: 2317, string: "aud"
                2331, // index: 2331, string: "exp"
                1670, // index: 1670, string: "iss"
                2335, // index: 2335, string: "jti"
                2339, // index: 2339, string: "nbf"
                1702, // index: 1702, string: "sub"
                6, // array length: 6
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                4, // array length: 4
                2305, // index: 2305, string: "alg"
                2309, // index: 2309, string: "typ"
                2313, // index: 2313, string: "x5c"
                2343, // index: 2343, string: "x5t"
                4, // array length: 4
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                2, // array length: 2
                2305, // index: 2305, string: "alg"
                2309, // index: 2309, string: "typ"
                2, // array length: 2
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                1041, // index: 1041, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds"
                12, // array length: 12
                -1, // string: null
                -1, // string: null
                -1, // string: null
                770, // index: 770, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                12, // array length: 12
                2044, // index: 2044, string: "claims"
                2051, // index: 2051, string: "correlation_id"
                2077, // index: 2077, string: "error"
                2083, // index: 2083, string: "error_codes"
                2095, // index: 2095, string: "error_description"
                2031, // index: 2031, string: "access_token"
                2203, // index: 2203, string: "client_info"
                2113, // index: 2113, string: "expires_in"
                2150, // index: 2150, string: "id_token"
                2159, // index: 2159, string: "refresh_token"
                2225, // index: 2225, string: "scope"
                2182, // index: 2182, string: "token_type"
                12, // array length: 12
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                770, // index: 770, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                1, // array length: 1
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                5, // array length: 5
                2044, // index: 2044, string: "claims"
                2051, // index: 2051, string: "correlation_id"
                2077, // index: 2077, string: "error"
                2083, // index: 2083, string: "error_codes"
                2095, // index: 2095, string: "error_description"
                5, // array length: 5
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                770, // index: 770, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                7, // array length: 7
                2044, // index: 2044, string: "claims"
                2051, // index: 2051, string: "correlation_id"
                2077, // index: 2077, string: "error"
                2083, // index: 2083, string: "error_codes"
                2095, // index: 2095, string: "error_description"
                1431, // index: 1431, string: "links"
                2347, // index: 2347, string: "subject"
                7, // array length: 7
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                2, // array length: 2
                2355, // index: 2355, string: "href"
                2360, // index: 2360, string: "rel"
                2, // array length: 2
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                770, // index: 770, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                8, // array length: 8
                2044, // index: 2044, string: "claims"
                2051, // index: 2051, string: "correlation_id"
                2077, // index: 2077, string: "error"
                2083, // index: 2083, string: "error_codes"
                2095, // index: 2095, string: "error_description"
                2364, // index: 2364, string: "authorization_endpoint"
                2387, // index: 2387, string: "issuer"
                2394, // index: 2394, string: "token_endpoint"
                8, // array length: 8
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                770, // index: 770, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                6, // array length: 6
                2044, // index: 2044, string: "claims"
                2051, // index: 2051, string: "correlation_id"
                2077, // index: 2077, string: "error"
                2083, // index: 2083, string: "error_codes"
                2095, // index: 2095, string: "error_description"
                2409, // index: 2409, string: "tenant_discovery_endpoint"
                6, // array length: 6
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                770, // index: 770, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                6, // array length: 6
                2044, // index: 2044, string: "claims"
                2051, // index: 2051, string: "correlation_id"
                2077, // index: 2077, string: "error"
                2083, // index: 2083, string: "error_codes"
                2095, // index: 2095, string: "error_description"
                1507, // index: 1507, string: "IdentityProviderService"
                6, // array length: 6
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1211, // index: 1211, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                1, // array length: 1
                2435, // index: 2435, string: "PassiveAuthEndpoint"
                1, // array length: 1
                1334, // index: 1334, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                2, // array length: 2
                2455, // index: 2455, string: "metadata"
                2409, // index: 2409, string: "tenant_discovery_endpoint"
                2, // array length: 2
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                3, // array length: 3
                770, // index: 770, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                3, // array length: 3
                2464, // index: 2464, string: "aliases"
                2472, // index: 2472, string: "preferred_cache"
                2488, // index: 2488, string: "preferred_network"
                3, // array length: 3
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory"
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                6, // array length: 6
                2506, // index: 2506, string: "account_type"
                2519, // index: 2519, string: "cloud_audience_urn"
                2538, // index: 2538, string: "federation_active_auth_url"
                2565, // index: 2565, string: "federation_metadata_url"
                2589, // index: 2589, string: "federation_protocol"
                1710, // index: 1710, string: "ver"
                6, // array length: 6
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                8, // array length: 8
                2609, // index: 2609, string: "device_code"
                2077, // index: 2077, string: "error"
                2095, // index: 2095, string: "error_description"
                2113, // index: 2113, string: "expires_in"
                2621, // index: 2621, string: "interval"
                2630, // index: 2630, string: "message"
                2638, // index: 2638, string: "user_code"
                2648, // index: 2648, string: "verification_url"
                8, // array length: 8
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638, // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
                638  // index: 638, string: "http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=71
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                                "1d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.IdToken, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neutral, PublicK" +
                                "eyToken=0a613f4dd989e8ae")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.AuthenticationResultEx, Microsoft.IdentityModel.Clients" +
                                ".ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.AuthenticationResult, Microsoft.IdentityModel.Clients.ActiveDire" +
                                "ctory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.1.1, C" +
                                "ulture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.UserInfo, Microsoft.IdentityModel.Clients.ActiveDirectory, Versi" +
                                "on=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.IdToken, Microsoft.IdentityModel.Clients.ActiveD" +
                                "irectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.TokenResponse, Microsoft.IdentityModel.Clients.A" +
                                "ctiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.AccessTokenCacheItem, Microsoft.Identity.Client, Version=1.1.2.0, Cultu" +
                                "re=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.BaseTokenCacheItem, Microsoft.Identity.Client, Version=1.1.2.0, Culture" +
                                "=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.RefreshTokenCacheItem, Microsoft.Identity.Client, Version=1.1.2.0, Cult" +
                                "ure=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.ClientInfo, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neutral, Publ" +
                                "icKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.DeviceAuthHeader, Microsoft.IdentityModel.Client" +
                                "s.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                "d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.DeviceAuthPayload, Microsoft.IdentityModel.Clien" +
                                "ts.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds.JsonWebToken+JWTPayload, Microsoft.Identity" +
                                "Model.Clients.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds.JsonWebToken+JWTHeaderWithCertificate, Micr" +
                                "osoft.IdentityModel.Clients.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364" +
                                "e35")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds.JsonWebToken+JWTHeader, Microsoft.IdentityM" +
                                "odel.Clients.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 241, // 0xf1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.OAuth2.TokenResponse, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neu" +
                                "tral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.OAuth2.OAuth2ResponseBase, Microsoft.Identity.Client, Version=1.1.2.0, Cultur" +
                                "e=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 273, // 0x111
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.AdfsWebFingerResponse, Microsoft.Identity.Client, Version=1.1.2.0, C" +
                                "ulture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 289, // 0x121
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.Identity.Client.Internal.Instance.LinksList, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neutral, PublicKeyToken=0a613f4dd989e8ae]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.LinksList, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neutr" +
                                "al, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 305, // 0x131
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.TenantDiscoveryResponse, Microsoft.Identity.Client, Version=1.1.2.0," +
                                " Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 321, // 0x141
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.InstanceDiscoveryResponse, Microsoft.Identity.Client, Version=1.1.2." +
                                "0, Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 337, // 0x151
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.DrsMetadataResponse, Microsoft.Identity.Client, Version=1.1.2.0, Cul" +
                                "ture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 353, // 0x161
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.IdentityProviderService, Microsoft.Identity.Client, Version=1.1.2.0," +
                                " Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 369, // 0x171
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.InstanceDiscoveryResponse, Microsoft.IdentityModel.Clients.Activ" +
                                "eDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 385, // 0x181
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.InstanceDiscoveryMetadataEntry[], Microsoft.IdentityModel.Client" +
                                "s.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.InstanceDiscoveryMetadataEntry, Microsoft.IdentityModel.Clients." +
                                "ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 401, // 0x191
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.UserRealmDiscoveryResponse, Microsoft.IdentityMo" +
                                "del.Clients.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 417, // 0x1a1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.DeviceCodeResponse, Microsoft.IdentityModel.Clie" +
                                "nts.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 433, // 0x1b1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 66, // 0x42
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                                    "1d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                                    "1d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=28
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // IdToken
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 255, // IdToken
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 255, // IdToken
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.IdToken, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neutral, PublicK" +
                                    "eyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.IdToken, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neutral, PublicK" +
                                    "eyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 10,
                    MemberNamesListIndex = 12,
                    MemberNamespacesListIndex = 21,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 338, // AuthenticationResultEx
                        NamespaceIndex = 361, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal
                        StableNameIndex = 338, // AuthenticationResultEx
                        StableNameNamespaceIndex = 361, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal
                        TopLevelElementNameIndex = 338, // AuthenticationResultEx
                        TopLevelElementNamespaceIndex = 361, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.AuthenticationResultEx, Microsoft.IdentityModel.Clients" +
                                    ".ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.AuthenticationResultEx, Microsoft.IdentityModel.Clients" +
                                    ".ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 30,
                    ContractNamespacesListIndex = 35,
                    MemberNamesListIndex = 37,
                    MemberNamespacesListIndex = 42,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 458, // AuthenticationResult
                        NamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory
                        StableNameIndex = 458, // AuthenticationResult
                        StableNameNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory
                        TopLevelElementNameIndex = 458, // AuthenticationResult
                        TopLevelElementNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.AuthenticationResult, Microsoft.IdentityModel.Clients.ActiveDire" +
                                    "ctory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.AuthenticationResult, Microsoft.IdentityModel.Clients.ActiveDire" +
                                    "ctory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 47,
                    ContractNamespacesListIndex = 56,
                    MemberNamesListIndex = 58,
                    MemberNamespacesListIndex = 67,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 567, // DateTimeOffset
                        NamespaceIndex = 582, // http://schemas.datacontract.org/2004/07/System
                        StableNameIndex = 567, // DateTimeOffset
                        StableNameNamespaceIndex = 582, // http://schemas.datacontract.org/2004/07/System
                        TopLevelElementNameIndex = 567, // DateTimeOffset
                        TopLevelElementNamespaceIndex = 582, // http://schemas.datacontract.org/2004/07/System
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTimeOffset, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.1.1, C" +
                                    "ulture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 76,
                    ContractNamespacesListIndex = 79,
                    MemberNamesListIndex = 81,
                    MemberNamespacesListIndex = 84,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 629, // UserInfo
                        NamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory
                        StableNameIndex = 629, // UserInfo
                        StableNameNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory
                        TopLevelElementNameIndex = 629, // UserInfo
                        TopLevelElementNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.UserInfo, Microsoft.IdentityModel.Clients.ActiveDirectory, Versi" +
                                    "on=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.UserInfo, Microsoft.IdentityModel.Clients.ActiveDirectory, Versi" +
                                    "on=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 87,
                    ContractNamespacesListIndex = 95,
                    MemberNamesListIndex = 97,
                    MemberNamespacesListIndex = 105,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // IdToken
                        NamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        StableNameIndex = 255, // IdToken
                        StableNameNamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        TopLevelElementNameIndex = 255, // IdToken
                        TopLevelElementNamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.IdToken, Microsoft.IdentityModel.Clients.ActiveD" +
                                    "irectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.IdToken, Microsoft.IdentityModel.Clients.ActiveD" +
                                    "irectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 113,
                    ContractNamespacesListIndex = 125,
                    MemberNamesListIndex = 127,
                    MemberNamespacesListIndex = 139,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 742, // TokenResponse
                        NamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        StableNameIndex = 742, // TokenResponse
                        StableNameNamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        TopLevelElementNameIndex = 742, // TokenResponse
                        TopLevelElementNamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.TokenResponse, Microsoft.IdentityModel.Clients.A" +
                                    "ctiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.TokenResponse, Microsoft.IdentityModel.Clients.A" +
                                    "ctiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 151,
                    ContractNamespacesListIndex = 166,
                    MemberNamesListIndex = 168,
                    MemberNamespacesListIndex = 183,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 828, // AccessTokenCacheItem
                        NamespaceIndex = 849, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        StableNameIndex = 828, // AccessTokenCacheItem
                        StableNameNamespaceIndex = 849, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        TopLevelElementNameIndex = 828, // AccessTokenCacheItem
                        TopLevelElementNamespaceIndex = 849, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.AccessTokenCacheItem, Microsoft.Identity.Client, Version=1.1.2.0, Cultu" +
                                    "re=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.AccessTokenCacheItem, Microsoft.Identity.Client, Version=1.1.2.0, Cultu" +
                                    "re=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 198,
                    ContractNamespacesListIndex = 209,
                    MemberNamesListIndex = 212,
                    MemberNamespacesListIndex = 223,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 930, // BaseTokenCacheItem
                        NamespaceIndex = 849, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        StableNameIndex = 930, // BaseTokenCacheItem
                        StableNameNamespaceIndex = 849, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        TopLevelElementNameIndex = 930, // BaseTokenCacheItem
                        TopLevelElementNamespaceIndex = 849, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.BaseTokenCacheItem, Microsoft.Identity.Client, Version=1.1.2.0, Culture" +
                                    "=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.BaseTokenCacheItem, Microsoft.Identity.Client, Version=1.1.2.0, Culture" +
                                    "=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 234,
                    ContractNamespacesListIndex = 238,
                    MemberNamesListIndex = 240,
                    MemberNamespacesListIndex = 244,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 949, // RefreshTokenCacheItem
                        NamespaceIndex = 849, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        StableNameIndex = 949, // RefreshTokenCacheItem
                        StableNameNamespaceIndex = 849, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        TopLevelElementNameIndex = 949, // RefreshTokenCacheItem
                        TopLevelElementNamespaceIndex = 849, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.RefreshTokenCacheItem, Microsoft.Identity.Client, Version=1.1.2.0, Cult" +
                                    "ure=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.RefreshTokenCacheItem, Microsoft.Identity.Client, Version=1.1.2.0, Cult" +
                                    "ure=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 248,
                    ContractNamespacesListIndex = 257,
                    MemberNamesListIndex = 260,
                    MemberNamespacesListIndex = 269,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 971, // ClientInfo
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 971, // ClientInfo
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 971, // ClientInfo
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.ClientInfo, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neutral, Publ" +
                                    "icKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.ClientInfo, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neutral, Publ" +
                                    "icKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 278,
                    ContractNamespacesListIndex = 281,
                    MemberNamesListIndex = 283,
                    MemberNamespacesListIndex = 286,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 982, // DeviceAuthHeader
                        NamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        StableNameIndex = 982, // DeviceAuthHeader
                        StableNameNamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        TopLevelElementNameIndex = 982, // DeviceAuthHeader
                        TopLevelElementNamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.DeviceAuthHeader, Microsoft.IdentityModel.Client" +
                                    "s.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.DeviceAuthHeader, Microsoft.IdentityModel.Client" +
                                    "s.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 289,
                    ContractNamespacesListIndex = 293,
                    MemberNamesListIndex = 295,
                    MemberNamespacesListIndex = 299,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 999, // DeviceAuthPayload
                        NamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        StableNameIndex = 999, // DeviceAuthPayload
                        StableNameNamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        TopLevelElementNameIndex = 999, // DeviceAuthPayload
                        TopLevelElementNamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.DeviceAuthPayload, Microsoft.IdentityModel.Clien" +
                                    "ts.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.DeviceAuthPayload, Microsoft.IdentityModel.Clien" +
                                    "ts.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 303,
                    ContractNamespacesListIndex = 307,
                    MemberNamesListIndex = 309,
                    MemberNamespacesListIndex = 313,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1017, // JsonWebToken.JWTPayload
                        NamespaceIndex = 1041, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds
                        StableNameIndex = 1017, // JsonWebToken.JWTPayload
                        StableNameNamespaceIndex = 1041, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds
                        TopLevelElementNameIndex = 1017, // JsonWebToken.JWTPayload
                        TopLevelElementNamespaceIndex = 1041, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds.JsonWebToken+JWTPayload, Microsoft.Identity" +
                                    "Model.Clients.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds.JsonWebToken+JWTPayload, Microsoft.Identity" +
                                    "Model.Clients.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 317,
                    ContractNamespacesListIndex = 324,
                    MemberNamesListIndex = 326,
                    MemberNamespacesListIndex = 333,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1150, // JsonWebToken.JWTHeaderWithCertificate
                        NamespaceIndex = 1041, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds
                        StableNameIndex = 1150, // JsonWebToken.JWTHeaderWithCertificate
                        StableNameNamespaceIndex = 1041, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds
                        TopLevelElementNameIndex = 1150, // JsonWebToken.JWTHeaderWithCertificate
                        TopLevelElementNamespaceIndex = 1041, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds.JsonWebToken+JWTHeaderWithCertificate, Micr" +
                                    "osoft.IdentityModel.Clients.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364" +
                                    "e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds.JsonWebToken+JWTHeaderWithCertificate, Micr" +
                                    "osoft.IdentityModel.Clients.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364" +
                                    "e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 340,
                    ContractNamespacesListIndex = 345,
                    MemberNamesListIndex = 348,
                    MemberNamespacesListIndex = 353,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1188, // JsonWebToken.JWTHeader
                        NamespaceIndex = 1041, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds
                        StableNameIndex = 1188, // JsonWebToken.JWTHeader
                        StableNameNamespaceIndex = 1041, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds
                        TopLevelElementNameIndex = 1188, // JsonWebToken.JWTHeader
                        TopLevelElementNamespaceIndex = 1041, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds.JsonWebToken+JWTHeader, Microsoft.IdentityM" +
                                    "odel.Clients.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.ClientCreds.JsonWebToken+JWTHeader, Microsoft.IdentityM" +
                                    "odel.Clients.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 358,
                    ContractNamespacesListIndex = 361,
                    MemberNamesListIndex = 363,
                    MemberNamespacesListIndex = 366,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 742, // TokenResponse
                        NamespaceIndex = 1211, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2
                        StableNameIndex = 742, // TokenResponse
                        StableNameNamespaceIndex = 1211, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2
                        TopLevelElementNameIndex = 742, // TokenResponse
                        TopLevelElementNamespaceIndex = 1211, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.OAuth2.TokenResponse, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neu" +
                                    "tral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.OAuth2.TokenResponse, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neu" +
                                    "tral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 369,
                    ContractNamespacesListIndex = 382,
                    MemberNamesListIndex = 385,
                    MemberNamespacesListIndex = 398,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1293, // OAuth2ResponseBase
                        NamespaceIndex = 1211, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2
                        StableNameIndex = 1293, // OAuth2ResponseBase
                        StableNameNamespaceIndex = 1211, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2
                        TopLevelElementNameIndex = 1293, // OAuth2ResponseBase
                        TopLevelElementNamespaceIndex = 1211, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.OAuth2.OAuth2ResponseBase, Microsoft.Identity.Client, Version=1.1.2.0, Cultur" +
                                    "e=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.OAuth2.OAuth2ResponseBase, Microsoft.Identity.Client, Version=1.1.2.0, Cultur" +
                                    "e=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 411,
                    ContractNamespacesListIndex = 417,
                    MemberNamesListIndex = 419,
                    MemberNamespacesListIndex = 425,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1312, // AdfsWebFingerResponse
                        NamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        StableNameIndex = 1312, // AdfsWebFingerResponse
                        StableNameNamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        TopLevelElementNameIndex = 1312, // AdfsWebFingerResponse
                        TopLevelElementNamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.AdfsWebFingerResponse, Microsoft.Identity.Client, Version=1.1.2.0, C" +
                                    "ulture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.AdfsWebFingerResponse, Microsoft.Identity.Client, Version=1.1.2.0, C" +
                                    "ulture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 431,
                    ContractNamespacesListIndex = 439,
                    MemberNamesListIndex = 442,
                    MemberNamespacesListIndex = 450,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1431, // links
                        NamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        StableNameIndex = 1431, // links
                        StableNameNamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        TopLevelElementNameIndex = 1431, // links
                        TopLevelElementNamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.LinksList, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neutr" +
                                    "al, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.LinksList, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neutr" +
                                    "al, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 458,
                    ContractNamespacesListIndex = 461,
                    MemberNamesListIndex = 463,
                    MemberNamespacesListIndex = 466,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1437, // TenantDiscoveryResponse
                        NamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        StableNameIndex = 1437, // TenantDiscoveryResponse
                        StableNameNamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        TopLevelElementNameIndex = 1437, // TenantDiscoveryResponse
                        TopLevelElementNamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.TenantDiscoveryResponse, Microsoft.Identity.Client, Version=1.1.2.0," +
                                    " Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.TenantDiscoveryResponse, Microsoft.Identity.Client, Version=1.1.2.0," +
                                    " Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 469,
                    ContractNamespacesListIndex = 478,
                    MemberNamesListIndex = 481,
                    MemberNamespacesListIndex = 490,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1461, // InstanceDiscoveryResponse
                        NamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        StableNameIndex = 1461, // InstanceDiscoveryResponse
                        StableNameNamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        TopLevelElementNameIndex = 1461, // InstanceDiscoveryResponse
                        TopLevelElementNamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.InstanceDiscoveryResponse, Microsoft.Identity.Client, Version=1.1.2." +
                                    "0, Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.InstanceDiscoveryResponse, Microsoft.Identity.Client, Version=1.1.2." +
                                    "0, Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 499,
                    ContractNamespacesListIndex = 506,
                    MemberNamesListIndex = 509,
                    MemberNamespacesListIndex = 516,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1487, // DrsMetadataResponse
                        NamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        StableNameIndex = 1487, // DrsMetadataResponse
                        StableNameNamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        TopLevelElementNameIndex = 1487, // DrsMetadataResponse
                        TopLevelElementNamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.DrsMetadataResponse, Microsoft.Identity.Client, Version=1.1.2.0, Cul" +
                                    "ture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.DrsMetadataResponse, Microsoft.Identity.Client, Version=1.1.2.0, Cul" +
                                    "ture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 523,
                    ContractNamespacesListIndex = 530,
                    MemberNamesListIndex = 533,
                    MemberNamespacesListIndex = 540,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1507, // IdentityProviderService
                        NamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        StableNameIndex = 1507, // IdentityProviderService
                        StableNameNamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        TopLevelElementNameIndex = 1507, // IdentityProviderService
                        TopLevelElementNamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.IdentityProviderService, Microsoft.Identity.Client, Version=1.1.2.0," +
                                    " Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.IdentityProviderService, Microsoft.Identity.Client, Version=1.1.2.0," +
                                    " Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 547,
                    ContractNamespacesListIndex = 549,
                    MemberNamesListIndex = 551,
                    MemberNamespacesListIndex = 553,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1461, // InstanceDiscoveryResponse
                        NamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory
                        StableNameIndex = 1461, // InstanceDiscoveryResponse
                        StableNameNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory
                        TopLevelElementNameIndex = 1461, // InstanceDiscoveryResponse
                        TopLevelElementNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.InstanceDiscoveryResponse, Microsoft.IdentityModel.Clients.Activ" +
                                    "eDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.InstanceDiscoveryResponse, Microsoft.IdentityModel.Clients.Activ" +
                                    "eDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 555,
                    ContractNamespacesListIndex = 558,
                    MemberNamesListIndex = 560,
                    MemberNamespacesListIndex = 563,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1569, // InstanceDiscoveryMetadataEntry
                        NamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory
                        StableNameIndex = 1569, // InstanceDiscoveryMetadataEntry
                        StableNameNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory
                        TopLevelElementNameIndex = 1569, // InstanceDiscoveryMetadataEntry
                        TopLevelElementNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.InstanceDiscoveryMetadataEntry, Microsoft.IdentityModel.Clients." +
                                    "ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.InstanceDiscoveryMetadataEntry, Microsoft.IdentityModel.Clients." +
                                    "ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 566,
                    ContractNamespacesListIndex = 570,
                    MemberNamesListIndex = 572,
                    MemberNamespacesListIndex = 576,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1600, // UserRealmDiscoveryResponse
                        NamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        StableNameIndex = 1600, // UserRealmDiscoveryResponse
                        StableNameNamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        TopLevelElementNameIndex = 1600, // UserRealmDiscoveryResponse
                        TopLevelElementNamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.UserRealmDiscoveryResponse, Microsoft.IdentityMo" +
                                    "del.Clients.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.UserRealmDiscoveryResponse, Microsoft.IdentityMo" +
                                    "del.Clients.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 580,
                    ContractNamespacesListIndex = 587,
                    MemberNamesListIndex = 589,
                    MemberNamespacesListIndex = 596,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1627, // DeviceCodeResponse
                        NamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        StableNameIndex = 1627, // DeviceCodeResponse
                        StableNameNamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        TopLevelElementNameIndex = 1627, // DeviceCodeResponse
                        TopLevelElementNamespaceIndex = 638, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.DeviceCodeResponse, Microsoft.IdentityModel.Clie" +
                                    "nts.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.Internal.OAuth2.DeviceCodeResponse, Microsoft.IdentityModel.Clie" +
                                    "nts.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 603,
                    ContractNamespacesListIndex = 612,
                    MemberNamesListIndex = 614,
                    MemberNamespacesListIndex = 623,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=5
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 756, // ArrayOfstring
                        NamespaceIndex = 770, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 756, // ArrayOfstring
                        StableNameNamespaceIndex = 770, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 756, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 770, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 756, // ArrayOfstring
                        NamespaceIndex = 770, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 756, // ArrayOfstring
                        StableNameNamespaceIndex = 770, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 756, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 770, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1418, // ArrayOflinks
                        NamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        StableNameIndex = 1418, // ArrayOflinks
                        StableNameNamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        TopLevelElementNameIndex = 1418, // ArrayOflinks
                        TopLevelElementNamespaceIndex = 1334, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.Identity.Client.Internal.Instance.LinksList, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neutral, PublicKeyToken=0a613f4dd989e8ae]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.Identity.Client.Internal.Instance.LinksList, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neutral, PublicKeyToken=0a613f4dd989e8ae]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 1431, // links
                    KeyNameIndex = -1,
                    ItemNameIndex = 1431, // links
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.LinksList, Microsoft.Identity.Client, Version=1.1.2.0, Culture=neutr" +
                                "al, PublicKeyToken=0a613f4dd989e8ae")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1531, // ArrayOfInstanceDiscoveryMetadataEntry
                        NamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory
                        StableNameIndex = 1531, // ArrayOfInstanceDiscoveryMetadataEntry
                        StableNameNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory
                        TopLevelElementNameIndex = 1531, // ArrayOfInstanceDiscoveryMetadataEntry
                        TopLevelElementNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.IdentityModel.Clients.ActiveDirectory
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.InstanceDiscoveryMetadataEntry[], Microsoft.IdentityModel.Client" +
                                    "s.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.InstanceDiscoveryMetadataEntry[], Microsoft.IdentityModel.Client" +
                                    "s.ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    CollectionItemNameIndex = 1569, // InstanceDiscoveryMetadataEntry
                    KeyNameIndex = -1,
                    ItemNameIndex = 1569, // InstanceDiscoveryMetadataEntry
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.IdentityModel.Clients.ActiveDirectory.InstanceDiscoveryMetadataEntry, Microsoft.IdentityModel.Clients." +
                                "ActiveDirectory, Version=3.19.1.3001, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1646, // ArrayOfanyType
                        NamespaceIndex = 770, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1646, // ArrayOfanyType
                        StableNameNamespaceIndex = 770, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1646, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 770, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static readonly byte[] s_jsonDelegatesList_Hashtable = null;
        // Count=33
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 37,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type3.WriteIdTokenToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type2.ReadIdTokenFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 38,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type7.WriteAuthenticationResultExToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type6.ReadAuthenticationResultExFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 39,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type11.WriteAuthenticationResultToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type10.ReadAuthenticationResultFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 40,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type15.WriteDateTimeOffsetToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type14.ReadDateTimeOffsetFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 42,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type19.WriteUserInfoToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type18.ReadUserInfoFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 43,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type23.WriteIdTokenToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type22.ReadIdTokenFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 44,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type27.WriteTokenResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type26.ReadTokenResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 45,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type32.WriteArrayOfstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type31.ReadArrayOfstringFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type33.ReadArrayOfstringFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 46,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type37.WriteAccessTokenCacheItemToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type36.ReadAccessTokenCacheItemFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 47,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type41.WriteBaseTokenCacheItemToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type40.ReadBaseTokenCacheItemFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 48,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type45.WriteRefreshTokenCacheItemToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type44.ReadRefreshTokenCacheItemFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 49,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type49.WriteClientInfoToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type48.ReadClientInfoFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 50,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type53.WriteDeviceAuthHeaderToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type52.ReadDeviceAuthHeaderFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 51,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type58.WriteArrayOfstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type57.ReadArrayOfstringFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type59.ReadArrayOfstringFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 52,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type63.WriteDeviceAuthPayloadToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type62.ReadDeviceAuthPayloadFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 53,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type67.WriteJsonWebToken_JWTPayloadToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type66.ReadJsonWebToken_JWTPayloadFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 54,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type71.WriteJsonWebToken_JWTHeaderWithCertificateToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type70.ReadJsonWebToken_JWTHeaderWithCertificateFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 55,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type75.WriteJsonWebToken_JWTHeaderToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type74.ReadJsonWebToken_JWTHeaderFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 56,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type79.WriteTokenResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type78.ReadTokenResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 57,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type83.WriteOAuth2ResponseBaseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type82.ReadOAuth2ResponseBaseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 58,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type87.WriteAdfsWebFingerResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type86.ReadAdfsWebFingerResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 59,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type92.WriteArrayOflinksToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type91.ReadArrayOflinksFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type93.ReadArrayOflinksFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 60,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type97.WritelinksToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type96.ReadlinksFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 61,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type101.WriteTenantDiscoveryResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type100.ReadTenantDiscoveryResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 62,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type105.WriteInstanceDiscoveryResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type104.ReadInstanceDiscoveryResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 63,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type109.WriteDrsMetadataResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type108.ReadDrsMetadataResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 64,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type113.WriteIdentityProviderServiceToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type112.ReadIdentityProviderServiceFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 65,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type117.WriteInstanceDiscoveryResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type116.ReadInstanceDiscoveryResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 66,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type122.WriteArrayOfInstanceDiscoveryMetadataEntryToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type121.ReadArrayOfInstanceDiscoveryMetadataEntryFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type123.ReadArrayOfInstanceDiscoveryMetadataEntryFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 67,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type127.WriteInstanceDiscoveryMetadataEntryToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type126.ReadInstanceDiscoveryMetadataEntryFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 68,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type131.WriteUserRealmDiscoveryResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type130.ReadUserRealmDiscoveryResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 69,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type135.WriteDeviceCodeResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type134.ReadDeviceCodeResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 70,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type140.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type139.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type141.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','I','d','T','o','k','e','n','\0','h','t','t','p',':','/','/',
            's','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/',
            '0','7','/','M','i','c','r','o','s','o','f','t','.','I','d','e','n','t','i','t','y','.','C','l','i','e','n','t','.','I',
            'n','t','e','r','n','a','l','\0','A','u','t','h','e','n','t','i','c','a','t','i','o','n','R','e','s','u','l','t','E','x',
            '\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o',
            'r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f','t','.','I','d','e','n','t','i','t','y','M',
            'o','d','e','l','.','C','l','i','e','n','t','s','.','A','c','t','i','v','e','D','i','r','e','c','t','o','r','y','.','I',
            'n','t','e','r','n','a','l','\0','A','u','t','h','e','n','t','i','c','a','t','i','o','n','R','e','s','u','l','t','\0','h',
            't','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g',
            '/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f','t','.','I','d','e','n','t','i','t','y','M','o','d',
            'e','l','.','C','l','i','e','n','t','s','.','A','c','t','i','v','e','D','i','r','e','c','t','o','r','y','\0','D','a','t',
            'e','T','i','m','e','O','f','f','s','e','t','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t',
            'a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','S','y','s','t','e','m','\0','U',
            's','e','r','I','n','f','o','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n',
            't','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f','t','.','I','d',
            'e','n','t','i','t','y','M','o','d','e','l','.','C','l','i','e','n','t','s','.','A','c','t','i','v','e','D','i','r','e',
            'c','t','o','r','y','.','I','n','t','e','r','n','a','l','.','O','A','u','t','h','2','\0','T','o','k','e','n','R','e','s',
            'p','o','n','s','e','\0','A','r','r','a','y','O','f','s','t','r','i','n','g','\0','h','t','t','p',':','/','/','s','c','h',
            'e','m','a','s','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r',
            'i','a','l','i','z','a','t','i','o','n','/','A','r','r','a','y','s','\0','A','c','c','e','s','s','T','o','k','e','n','C',
            'a','c','h','e','I','t','e','m','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o',
            'n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f','t','.','I',
            'd','e','n','t','i','t','y','.','C','l','i','e','n','t','.','I','n','t','e','r','n','a','l','.','C','a','c','h','e','\0',
            'B','a','s','e','T','o','k','e','n','C','a','c','h','e','I','t','e','m','\0','R','e','f','r','e','s','h','T','o','k','e',
            'n','C','a','c','h','e','I','t','e','m','\0','C','l','i','e','n','t','I','n','f','o','\0','D','e','v','i','c','e','A','u',
            't','h','H','e','a','d','e','r','\0','D','e','v','i','c','e','A','u','t','h','P','a','y','l','o','a','d','\0','J','s','o',
            'n','W','e','b','T','o','k','e','n','.','J','W','T','P','a','y','l','o','a','d','\0','h','t','t','p',':','/','/','s','c',
            'h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7',
            '/','M','i','c','r','o','s','o','f','t','.','I','d','e','n','t','i','t','y','M','o','d','e','l','.','C','l','i','e','n',
            't','s','.','A','c','t','i','v','e','D','i','r','e','c','t','o','r','y','.','I','n','t','e','r','n','a','l','.','C','l',
            'i','e','n','t','C','r','e','d','s','\0','J','s','o','n','W','e','b','T','o','k','e','n','.','J','W','T','H','e','a','d',
            'e','r','W','i','t','h','C','e','r','t','i','f','i','c','a','t','e','\0','J','s','o','n','W','e','b','T','o','k','e','n',
            '.','J','W','T','H','e','a','d','e','r','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a',
            'c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f','t',
            '.','I','d','e','n','t','i','t','y','.','C','l','i','e','n','t','.','I','n','t','e','r','n','a','l','.','O','A','u','t',
            'h','2','\0','O','A','u','t','h','2','R','e','s','p','o','n','s','e','B','a','s','e','\0','A','d','f','s','W','e','b','F',
            'i','n','g','e','r','R','e','s','p','o','n','s','e','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d',
            'a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s',
            'o','f','t','.','I','d','e','n','t','i','t','y','.','C','l','i','e','n','t','.','I','n','t','e','r','n','a','l','.','I',
            'n','s','t','a','n','c','e','\0','A','r','r','a','y','O','f','l','i','n','k','s','\0','l','i','n','k','s','\0','T','e','n',
            'a','n','t','D','i','s','c','o','v','e','r','y','R','e','s','p','o','n','s','e','\0','I','n','s','t','a','n','c','e','D',
            'i','s','c','o','v','e','r','y','R','e','s','p','o','n','s','e','\0','D','r','s','M','e','t','a','d','a','t','a','R','e',
            's','p','o','n','s','e','\0','I','d','e','n','t','i','t','y','P','r','o','v','i','d','e','r','S','e','r','v','i','c','e',
            '\0','A','r','r','a','y','O','f','I','n','s','t','a','n','c','e','D','i','s','c','o','v','e','r','y','M','e','t','a','d',
            'a','t','a','E','n','t','r','y','\0','I','n','s','t','a','n','c','e','D','i','s','c','o','v','e','r','y','M','e','t','a',
            'd','a','t','a','E','n','t','r','y','\0','U','s','e','r','R','e','a','l','m','D','i','s','c','o','v','e','r','y','R','e',
            's','p','o','n','s','e','\0','D','e','v','i','c','e','C','o','d','e','R','e','s','p','o','n','s','e','\0','A','r','r','a',
            'y','O','f','a','n','y','T','y','p','e','\0','h','o','m','e','_','o','i','d','\0','i','s','s','\0','n','a','m','e','\0','o',
            'i','d','\0','p','r','e','f','e','r','r','e','d','_','u','s','e','r','n','a','m','e','\0','s','u','b','\0','t','i','d','\0',
            'v','e','r','\0','R','e','f','r','e','s','h','T','o','k','e','n','\0','R','e','s','o','u','r','c','e','I','n','R','e','s',
            'p','o','n','s','e','\0','R','e','s','u','l','t','\0','U','s','e','r','A','s','s','e','r','t','i','o','n','H','a','s','h',
            '\0','A','c','c','e','s','s','T','o','k','e','n','\0','A','c','c','e','s','s','T','o','k','e','n','T','y','p','e','\0','E',
            'x','p','i','r','e','s','O','n','\0','E','x','t','e','n','d','e','d','E','x','p','i','r','e','s','O','n','\0','E','x','t',
            'e','n','d','e','d','L','i','f','e','T','i','m','e','T','o','k','e','n','\0','T','e','n','a','n','t','I','d','\0','D','a',
            't','e','T','i','m','e','\0','O','f','f','s','e','t','M','i','n','u','t','e','s','\0','D','i','s','p','l','a','y','a','b',
            'l','e','I','d','\0','F','a','m','i','l','y','N','a','m','e','\0','G','i','v','e','n','N','a','m','e','\0','I','d','e','n',
            't','i','t','y','P','r','o','v','i','d','e','r','\0','P','a','s','s','w','o','r','d','C','h','a','n','g','e','U','r','l',
            '\0','P','a','s','s','w','o','r','d','E','x','p','i','r','e','s','O','n','\0','U','n','i','q','u','e','I','d','\0','e','m',
            'a','i','l','\0','f','a','m','i','l','y','_','n','a','m','e','\0','g','i','v','e','n','_','n','a','m','e','\0','i','d','p',
            '\0','p','w','d','_','e','x','p','\0','p','w','d','_','u','r','l','\0','u','p','n','\0','a','c','c','e','s','s','_','t','o',
            'k','e','n','\0','c','l','a','i','m','s','\0','c','o','r','r','e','l','a','t','i','o','n','_','i','d','\0','c','r','e','a',
            't','e','d','_','o','n','\0','e','r','r','o','r','\0','e','r','r','o','r','_','c','o','d','e','s','\0','e','r','r','o','r',
            '_','d','e','s','c','r','i','p','t','i','o','n','\0','e','x','p','i','r','e','s','_','i','n','\0','e','x','p','i','r','e',
            's','_','o','n','\0','e','x','t','_','e','x','p','i','r','e','s','_','i','n','\0','i','d','_','t','o','k','e','n','\0','r',
            'e','f','r','e','s','h','_','t','o','k','e','n','\0','r','e','s','o','u','r','c','e','\0','t','o','k','e','n','_','t','y',
            'p','e','\0','c','l','i','e','n','t','_','i','d','\0','c','l','i','e','n','t','_','i','n','f','o','\0','a','u','t','h','o',
            'r','i','t','y','\0','s','c','o','p','e','\0','u','s','e','r','_','a','s','s','e','r','t','i','o','n','_','h','a','s','h',
            '\0','d','i','s','p','l','a','y','a','b','l','e','_','i','d','\0','e','n','v','i','r','o','n','m','e','n','t','\0','i','d',
            'e','n','t','i','t','y','_','p','r','o','v','i','d','e','r','\0','u','i','d','\0','u','t','i','d','\0','a','l','g','\0','t',
            'y','p','\0','x','5','c','\0','a','u','d','\0','i','a','t','\0','n','o','n','c','e','\0','e','x','p','\0','j','t','i','\0','n',
            'b','f','\0','x','5','t','\0','s','u','b','j','e','c','t','\0','h','r','e','f','\0','r','e','l','\0','a','u','t','h','o','r',
            'i','z','a','t','i','o','n','_','e','n','d','p','o','i','n','t','\0','i','s','s','u','e','r','\0','t','o','k','e','n','_',
            'e','n','d','p','o','i','n','t','\0','t','e','n','a','n','t','_','d','i','s','c','o','v','e','r','y','_','e','n','d','p',
            'o','i','n','t','\0','P','a','s','s','i','v','e','A','u','t','h','E','n','d','p','o','i','n','t','\0','m','e','t','a','d',
            'a','t','a','\0','a','l','i','a','s','e','s','\0','p','r','e','f','e','r','r','e','d','_','c','a','c','h','e','\0','p','r',
            'e','f','e','r','r','e','d','_','n','e','t','w','o','r','k','\0','a','c','c','o','u','n','t','_','t','y','p','e','\0','c',
            'l','o','u','d','_','a','u','d','i','e','n','c','e','_','u','r','n','\0','f','e','d','e','r','a','t','i','o','n','_','a',
            'c','t','i','v','e','_','a','u','t','h','_','u','r','l','\0','f','e','d','e','r','a','t','i','o','n','_','m','e','t','a',
            'd','a','t','a','_','u','r','l','\0','f','e','d','e','r','a','t','i','o','n','_','p','r','o','t','o','c','o','l','\0','d',
            'e','v','i','c','e','_','c','o','d','e','\0','i','n','t','e','r','v','a','l','\0','m','e','s','s','a','g','e','\0','u','s',
            'e','r','_','c','o','d','e','\0','v','e','r','i','f','i','c','a','t','i','o','n','_','u','r','l','\0'};
    }
}

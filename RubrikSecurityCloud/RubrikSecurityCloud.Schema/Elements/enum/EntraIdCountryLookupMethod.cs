// EntraIdCountryLookupMethod.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RubrikSecurityCloud.Types
{
    public enum EntraIdCountryLookupMethod
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EID_COUNTRY_LOOKUP_METHOD_AUTHENTICATOR_APP_GPS")]
        EID_COUNTRY_LOOKUP_METHOD_AUTHENTICATOR_APP_GPS,

        [EnumMember(Value = "EID_COUNTRY_LOOKUP_METHOD_CLIENT_IP_ADDRESS")]
        EID_COUNTRY_LOOKUP_METHOD_CLIENT_IP_ADDRESS,

        [EnumMember(Value = "EID_COUNTRY_LOOKUP_METHOD_UNSPECIFIED")]
        EID_COUNTRY_LOOKUP_METHOD_UNSPECIFIED


    } // enum EntraIdCountryLookupMethod

} // namespace RubrikSecurityCloud.Types
// MongoAuthenticationType.cs
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
    public enum MongoAuthenticationType
    {
        [EnumMember(Value = "MONGO_AUTHENTICATION_TYPE_LDAP")]
        MONGO_AUTHENTICATION_TYPE_LDAP,

        [EnumMember(Value = "MONGO_AUTHENTICATION_TYPE_SCRAM")]
        MONGO_AUTHENTICATION_TYPE_SCRAM,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum MongoAuthenticationType

} // namespace RubrikSecurityCloud.Types
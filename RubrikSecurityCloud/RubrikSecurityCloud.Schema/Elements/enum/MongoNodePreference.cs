// MongoNodePreference.cs
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
    public enum MongoNodePreference
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "MONGO_NODE_PREFERENCE_NO_PREFERENCE")]
        MONGO_NODE_PREFERENCE_NO_PREFERENCE,

        [EnumMember(Value = "MONGO_NODE_PREFERENCE_PRIMARY")]
        MONGO_NODE_PREFERENCE_PRIMARY,

        [EnumMember(Value = "MONGO_NODE_PREFERENCE_PRIMARY_ONLY")]
        MONGO_NODE_PREFERENCE_PRIMARY_ONLY,

        [EnumMember(Value = "MONGO_NODE_PREFERENCE_SECONDARY")]
        MONGO_NODE_PREFERENCE_SECONDARY,

        [EnumMember(Value = "MONGO_NODE_PREFERENCE_SECONDARY_ONLY")]
        MONGO_NODE_PREFERENCE_SECONDARY_ONLY


    } // enum MongoNodePreference

} // namespace RubrikSecurityCloud.Types
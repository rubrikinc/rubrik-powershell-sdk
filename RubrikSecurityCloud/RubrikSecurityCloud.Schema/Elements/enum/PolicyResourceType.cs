// PolicyResourceType.cs
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
    public enum PolicyResourceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "RESOURCE_TYPE_IDENTITY")]
        RESOURCE_TYPE_IDENTITY,

        [EnumMember(Value = "RESOURCE_TYPE_IDP")]
        RESOURCE_TYPE_IDP,

        [EnumMember(Value = "RESOURCE_TYPE_OBJECT")]
        RESOURCE_TYPE_OBJECT,

        [EnumMember(Value = "RESOURCE_TYPE_UNSPECIFIED")]
        RESOURCE_TYPE_UNSPECIFIED


    } // enum PolicyResourceType

} // namespace RubrikSecurityCloud.Types
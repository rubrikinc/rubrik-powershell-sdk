// SmbDomainFilterField.cs
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
    public enum SmbDomainFilterField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "DOMAIN_NAME")]
        DOMAIN_NAME,

        [EnumMember(Value = "FIELD_UNSPECIFIED")]
        FIELD_UNSPECIFIED,

        [EnumMember(Value = "STATUS")]
        STATUS


    } // enum SmbDomainFilterField

} // namespace RubrikSecurityCloud.Types
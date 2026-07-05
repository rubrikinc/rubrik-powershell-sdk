// UnregisteredDcFilterField.cs
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
    public enum UnregisteredDcFilterField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DOMAIN_NAME")]
        DOMAIN_NAME,

        [EnumMember(Value = "DOMAIN_SID")]
        DOMAIN_SID,

        [EnumMember(Value = "HOSTNAME")]
        HOSTNAME,

        [EnumMember(Value = "UNREGISTERED_DC_FILTER_FIELD_UNSPECIFIED")]
        UNREGISTERED_DC_FILTER_FIELD_UNSPECIFIED


    } // enum UnregisteredDcFilterField

} // namespace RubrikSecurityCloud.Types
// GuestOsCredentialFilterField.cs
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
    public enum GuestOsCredentialFilterField
    {
        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "DOMAIN")]
        DOMAIN,

        [EnumMember(Value = "FIELD_UNSPECIFIED")]
        FIELD_UNSPECIFIED,

        [EnumMember(Value = "USERNAME_OR_DOMAIN")]
        USERNAME_OR_DOMAIN,

        [EnumMember(Value = "USER_NAME")]
        USER_NAME,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum GuestOsCredentialFilterField

} // namespace RubrikSecurityCloud.Types
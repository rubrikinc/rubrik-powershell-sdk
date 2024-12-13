// SapHanaSystemAuthType.cs
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
    public enum SapHanaSystemAuthType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AUTH_TYPE_UNSPECIFIED")]
        AUTH_TYPE_UNSPECIFIED,

        [EnumMember(Value = "SAP_HANA_SYSTEM_AUTH_TYPE_SPEC_AUTH_TYPE_HDB_USERSTORE")]
        SAP_HANA_SYSTEM_AUTH_TYPE_SPEC_AUTH_TYPE_HDB_USERSTORE,

        [EnumMember(Value = "SAP_HANA_SYSTEM_AUTH_TYPE_SPEC_AUTH_TYPE_USER_CREDENTIALS")]
        SAP_HANA_SYSTEM_AUTH_TYPE_SPEC_AUTH_TYPE_USER_CREDENTIALS


    } // enum SapHanaSystemAuthType

} // namespace RubrikSecurityCloud.Types
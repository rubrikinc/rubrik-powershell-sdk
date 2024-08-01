// SapHanaSystemAuthTypeSpecAuthType.cs
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
    public enum SapHanaSystemAuthTypeSpecAuthType
    {
        [EnumMember(Value = "SAP_HANA_SYSTEM_AUTH_TYPE_SPEC_AUTH_TYPE_HDB_USERSTORE")]
        SAP_HANA_SYSTEM_AUTH_TYPE_SPEC_AUTH_TYPE_HDB_USERSTORE,

        [EnumMember(Value = "SAP_HANA_SYSTEM_AUTH_TYPE_SPEC_AUTH_TYPE_USER_CREDENTIALS")]
        SAP_HANA_SYSTEM_AUTH_TYPE_SPEC_AUTH_TYPE_USER_CREDENTIALS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SapHanaSystemAuthTypeSpecAuthType

} // namespace RubrikSecurityCloud.Types
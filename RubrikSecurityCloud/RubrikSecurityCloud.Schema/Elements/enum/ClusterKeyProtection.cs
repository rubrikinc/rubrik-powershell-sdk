// ClusterKeyProtection.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum ClusterKeyProtection
    {
        [EnumMember(Value = "CLUSTER_KEY_PROTECTION_UNSPECIFIED")]
        CLUSTER_KEY_PROTECTION_UNSPECIFIED,

        [EnumMember(Value = "DEFAULT")]
        DEFAULT,

        [EnumMember(Value = "KMIP")]
        KMIP,

        [EnumMember(Value = "PASSWORD")]
        PASSWORD,

        [EnumMember(Value = "TPM")]
        TPM


    } // enum ClusterKeyProtection

} // namespace Rubrik.SecurityCloud.Types
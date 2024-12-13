// KuprClusterPortsType.cs
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
    public enum KuprClusterPortsType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BACKUP")]
        BACKUP,

        [EnumMember(Value = "USER_DRIVEN")]
        USER_DRIVEN


    } // enum KuprClusterPortsType

} // namespace RubrikSecurityCloud.Types
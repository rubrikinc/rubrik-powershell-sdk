// MultiNodeBackupMode.cs
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
    public enum MultiNodeBackupMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "MULTI_NODE_BACKUP_MODE_DISABLED")]
        MULTI_NODE_BACKUP_MODE_DISABLED,

        [EnumMember(Value = "MULTI_NODE_BACKUP_MODE_ENABLED")]
        MULTI_NODE_BACKUP_MODE_ENABLED,

        [EnumMember(Value = "MULTI_NODE_BACKUP_MODE_UNDEFINED")]
        MULTI_NODE_BACKUP_MODE_UNDEFINED


    } // enum MultiNodeBackupMode

} // namespace RubrikSecurityCloud.Types
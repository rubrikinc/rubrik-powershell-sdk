// SalesforceObjectBackupType.cs
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
    public enum SalesforceObjectBackupType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NOT_RECOMMENDED")]
        NOT_RECOMMENDED,

        [EnumMember(Value = "RECOMMENDED")]
        RECOMMENDED,

        [EnumMember(Value = "SALESFORCE_OBJECT_BACKUP_TYPE_UNSPECIFIED")]
        SALESFORCE_OBJECT_BACKUP_TYPE_UNSPECIFIED


    } // enum SalesforceObjectBackupType

} // namespace RubrikSecurityCloud.Types
// ArchivalLocationEncryptionStatusFilter.cs
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
    public enum ArchivalLocationEncryptionStatusFilter
    {
        [EnumMember(Value = "DISABLED_ARCHIVAL_LOCATION_ENCRYPTION_STATUS")]
        DISABLED_ARCHIVAL_LOCATION_ENCRYPTION_STATUS,

        [EnumMember(Value = "ENABLED_ARCHIVAL_LOCATION_ENCRYPTION_STATUS")]
        ENABLED_ARCHIVAL_LOCATION_ENCRYPTION_STATUS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ArchivalLocationEncryptionStatusFilter

} // namespace RubrikSecurityCloud.Types
// CdmNutanixSnapshotConsistencyMandate.cs
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
    public enum CdmNutanixSnapshotConsistencyMandate
    {
        [EnumMember(Value = "NUTANIX_SNAPSHOT_CONSISTENCY_MANDATE_APPLICATION_CONSISTENT")]
        NUTANIX_SNAPSHOT_CONSISTENCY_MANDATE_APPLICATION_CONSISTENT,

        [EnumMember(Value = "NUTANIX_SNAPSHOT_CONSISTENCY_MANDATE_AUTOMATIC")]
        NUTANIX_SNAPSHOT_CONSISTENCY_MANDATE_AUTOMATIC,

        [EnumMember(Value = "NUTANIX_SNAPSHOT_CONSISTENCY_MANDATE_CRASH_CONSISTENT")]
        NUTANIX_SNAPSHOT_CONSISTENCY_MANDATE_CRASH_CONSISTENT


    } // enum CdmNutanixSnapshotConsistencyMandate

} // namespace Rubrik.SecurityCloud.Types
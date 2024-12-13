// DeleteVmwareSnapshotRequestLocation.cs
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
    public enum DeleteVmwareSnapshotRequestLocation
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "V1_DELETE_VMWARE_SNAPSHOT_REQUEST_LOCATION_ALL")]
        V1_DELETE_VMWARE_SNAPSHOT_REQUEST_LOCATION_ALL,

        [EnumMember(Value = "V1_DELETE_VMWARE_SNAPSHOT_REQUEST_LOCATION_LOCAL")]
        V1_DELETE_VMWARE_SNAPSHOT_REQUEST_LOCATION_LOCAL


    } // enum DeleteVmwareSnapshotRequestLocation

} // namespace RubrikSecurityCloud.Types
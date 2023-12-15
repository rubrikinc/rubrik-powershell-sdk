// NutanixSnapshotConsistencyMandate.cs
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
    public enum NutanixSnapshotConsistencyMandate
    {
        [EnumMember(Value = "NUTANIX_APP_CONSISTENT")]
        NUTANIX_APP_CONSISTENT,

        [EnumMember(Value = "NUTANIX_AUTOMATIC")]
        NUTANIX_AUTOMATIC,

        [EnumMember(Value = "NUTANIX_CRASH_CONSISTENT")]
        NUTANIX_CRASH_CONSISTENT,

        [EnumMember(Value = "NUTANIX_UNSPECIFIED")]
        NUTANIX_UNSPECIFIED


    } // enum NutanixSnapshotConsistencyMandate

} // namespace RubrikSecurityCloud.Types
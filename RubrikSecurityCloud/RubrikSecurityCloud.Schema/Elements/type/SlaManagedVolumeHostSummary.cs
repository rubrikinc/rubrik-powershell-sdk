// SlaManagedVolumeHostSummary.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region SlaManagedVolumeHostSummary
    public class SlaManagedVolumeHostSummary: BaseType
    {
        #region members

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String! (scalar)
        [JsonProperty("operatingSystemType")]
        public System.String? OperatingSystemType { get; set; }

        //      C# -> System.String? RubrikBackupServiceStatus
        // GraphQL -> rubrikBackupServiceStatus: String! (scalar)
        [JsonProperty("rubrikBackupServiceStatus")]
        public System.String? RubrikBackupServiceStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SlaManagedVolumeHostSummary";
    }

    public SlaManagedVolumeHostSummary Set(
        System.String? HostId = null,
        System.String? HostName = null,
        System.String? OperatingSystemType = null,
        System.String? RubrikBackupServiceStatus = null
    ) 
    {
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( OperatingSystemType != null ) {
            this.OperatingSystemType = OperatingSystemType;
        }
        if ( RubrikBackupServiceStatus != null ) {
            this.RubrikBackupServiceStatus = RubrikBackupServiceStatus;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            s += ind + "hostId\n" ;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            s += ind + "hostName\n" ;
        }
        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String! (scalar)
        if (this.OperatingSystemType != null) {
            s += ind + "operatingSystemType\n" ;
        }
        //      C# -> System.String? RubrikBackupServiceStatus
        // GraphQL -> rubrikBackupServiceStatus: String! (scalar)
        if (this.RubrikBackupServiceStatus != null) {
            s += ind + "rubrikBackupServiceStatus\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId == null && ec.Includes("hostId",true))
        {
            this.HostId = "FETCH";
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName == null && ec.Includes("hostName",true))
        {
            this.HostName = "FETCH";
        }
        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String! (scalar)
        if (this.OperatingSystemType == null && ec.Includes("operatingSystemType",true))
        {
            this.OperatingSystemType = "FETCH";
        }
        //      C# -> System.String? RubrikBackupServiceStatus
        // GraphQL -> rubrikBackupServiceStatus: String! (scalar)
        if (this.RubrikBackupServiceStatus == null && ec.Includes("rubrikBackupServiceStatus",true))
        {
            this.RubrikBackupServiceStatus = "FETCH";
        }
    }


    #endregion

    } // class SlaManagedVolumeHostSummary
    
    #endregion

    public static class ListSlaManagedVolumeHostSummaryExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<SlaManagedVolumeHostSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SlaManagedVolumeHostSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaManagedVolumeHostSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SlaManagedVolumeHostSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
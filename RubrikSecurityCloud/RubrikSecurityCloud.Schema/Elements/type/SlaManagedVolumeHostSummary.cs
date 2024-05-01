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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostName\n" ;
            } else {
                s += ind + "hostName\n" ;
            }
        }
        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String! (scalar)
        if (this.OperatingSystemType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operatingSystemType\n" ;
            } else {
                s += ind + "operatingSystemType\n" ;
            }
        }
        //      C# -> System.String? RubrikBackupServiceStatus
        // GraphQL -> rubrikBackupServiceStatus: String! (scalar)
        if (this.RubrikBackupServiceStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rubrikBackupServiceStatus\n" ;
            } else {
                s += ind + "rubrikBackupServiceStatus\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (ec.Includes("hostId",true))
        {
            if(this.HostId == null) {

                this.HostId = "FETCH";

            } else {


            }
        }
        else if (this.HostId != null && ec.Excludes("hostId",true))
        {
            this.HostId = null;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (ec.Includes("hostName",true))
        {
            if(this.HostName == null) {

                this.HostName = "FETCH";

            } else {


            }
        }
        else if (this.HostName != null && ec.Excludes("hostName",true))
        {
            this.HostName = null;
        }
        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String! (scalar)
        if (ec.Includes("operatingSystemType",true))
        {
            if(this.OperatingSystemType == null) {

                this.OperatingSystemType = "FETCH";

            } else {


            }
        }
        else if (this.OperatingSystemType != null && ec.Excludes("operatingSystemType",true))
        {
            this.OperatingSystemType = null;
        }
        //      C# -> System.String? RubrikBackupServiceStatus
        // GraphQL -> rubrikBackupServiceStatus: String! (scalar)
        if (ec.Includes("rubrikBackupServiceStatus",true))
        {
            if(this.RubrikBackupServiceStatus == null) {

                this.RubrikBackupServiceStatus = "FETCH";

            } else {


            }
        }
        else if (this.RubrikBackupServiceStatus != null && ec.Excludes("rubrikBackupServiceStatus",true))
        {
            this.RubrikBackupServiceStatus = null;
        }
    }


    #endregion

    } // class SlaManagedVolumeHostSummary
    
    #endregion

    public static class ListSlaManagedVolumeHostSummaryExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<SlaManagedVolumeHostSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SlaManagedVolumeHostSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<SlaManagedVolumeHostSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// VmRecoveryJobInfo.cs
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
    #region VmRecoveryJobInfo
    public class VmRecoveryJobInfo: BaseType
    {
        #region members

        //      C# -> System.String? CdmRecoveryJobId
        // GraphQL -> cdmRecoveryJobId: String! (scalar)
        [JsonProperty("cdmRecoveryJobId")]
        public System.String? CdmRecoveryJobId { get; set; }

        //      C# -> System.String? JobStatus
        // GraphQL -> jobStatus: String! (scalar)
        [JsonProperty("jobStatus")]
        public System.String? JobStatus { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }

        //      C# -> System.Int64? VmSizeInKbs
        // GraphQL -> vmSizeInKbs: Long! (scalar)
        [JsonProperty("vmSizeInKbs")]
        public System.Int64? VmSizeInKbs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmRecoveryJobInfo";
    }

    public VmRecoveryJobInfo Set(
        System.String? CdmRecoveryJobId = null,
        System.String? JobStatus = null,
        System.String? VmId = null,
        System.String? VmName = null,
        System.Int64? VmSizeInKbs = null
    ) 
    {
        if ( CdmRecoveryJobId != null ) {
            this.CdmRecoveryJobId = CdmRecoveryJobId;
        }
        if ( JobStatus != null ) {
            this.JobStatus = JobStatus;
        }
        if ( VmId != null ) {
            this.VmId = VmId;
        }
        if ( VmName != null ) {
            this.VmName = VmName;
        }
        if ( VmSizeInKbs != null ) {
            this.VmSizeInKbs = VmSizeInKbs;
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
        //      C# -> System.String? CdmRecoveryJobId
        // GraphQL -> cdmRecoveryJobId: String! (scalar)
        if (this.CdmRecoveryJobId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmRecoveryJobId\n" ;
            } else {
                s += ind + "cdmRecoveryJobId\n" ;
            }
        }
        //      C# -> System.String? JobStatus
        // GraphQL -> jobStatus: String! (scalar)
        if (this.JobStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobStatus\n" ;
            } else {
                s += ind + "jobStatus\n" ;
            }
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmId\n" ;
            } else {
                s += ind + "vmId\n" ;
            }
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmName\n" ;
            } else {
                s += ind + "vmName\n" ;
            }
        }
        //      C# -> System.Int64? VmSizeInKbs
        // GraphQL -> vmSizeInKbs: Long! (scalar)
        if (this.VmSizeInKbs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmSizeInKbs\n" ;
            } else {
                s += ind + "vmSizeInKbs\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CdmRecoveryJobId
        // GraphQL -> cdmRecoveryJobId: String! (scalar)
        if (ec.Includes("cdmRecoveryJobId",true))
        {
            if(this.CdmRecoveryJobId == null) {

                this.CdmRecoveryJobId = "FETCH";

            } else {


            }
        }
        else if (this.CdmRecoveryJobId != null && ec.Excludes("cdmRecoveryJobId",true))
        {
            this.CdmRecoveryJobId = null;
        }
        //      C# -> System.String? JobStatus
        // GraphQL -> jobStatus: String! (scalar)
        if (ec.Includes("jobStatus",true))
        {
            if(this.JobStatus == null) {

                this.JobStatus = "FETCH";

            } else {


            }
        }
        else if (this.JobStatus != null && ec.Excludes("jobStatus",true))
        {
            this.JobStatus = null;
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (ec.Includes("vmId",true))
        {
            if(this.VmId == null) {

                this.VmId = "FETCH";

            } else {


            }
        }
        else if (this.VmId != null && ec.Excludes("vmId",true))
        {
            this.VmId = null;
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (ec.Includes("vmName",true))
        {
            if(this.VmName == null) {

                this.VmName = "FETCH";

            } else {


            }
        }
        else if (this.VmName != null && ec.Excludes("vmName",true))
        {
            this.VmName = null;
        }
        //      C# -> System.Int64? VmSizeInKbs
        // GraphQL -> vmSizeInKbs: Long! (scalar)
        if (ec.Includes("vmSizeInKbs",true))
        {
            if(this.VmSizeInKbs == null) {

                this.VmSizeInKbs = new System.Int64();

            } else {


            }
        }
        else if (this.VmSizeInKbs != null && ec.Excludes("vmSizeInKbs",true))
        {
            this.VmSizeInKbs = null;
        }
    }


    #endregion

    } // class VmRecoveryJobInfo
    
    #endregion

    public static class ListVmRecoveryJobInfoExtensions
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
            this List<VmRecoveryJobInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmRecoveryJobInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmRecoveryJobInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmRecoveryJobInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmRecoveryJobInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
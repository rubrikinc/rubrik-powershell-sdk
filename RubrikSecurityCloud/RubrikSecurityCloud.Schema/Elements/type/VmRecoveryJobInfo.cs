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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? CdmRecoveryJobId
        // GraphQL -> cdmRecoveryJobId: String! (scalar)
        if (this.CdmRecoveryJobId != null) {
            s += ind + "cdmRecoveryJobId\n" ;
        }
        //      C# -> System.String? JobStatus
        // GraphQL -> jobStatus: String! (scalar)
        if (this.JobStatus != null) {
            s += ind + "jobStatus\n" ;
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId != null) {
            s += ind + "vmId\n" ;
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName != null) {
            s += ind + "vmName\n" ;
        }
        //      C# -> System.Int64? VmSizeInKbs
        // GraphQL -> vmSizeInKbs: Long! (scalar)
        if (this.VmSizeInKbs != null) {
            s += ind + "vmSizeInKbs\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CdmRecoveryJobId
        // GraphQL -> cdmRecoveryJobId: String! (scalar)
        if (this.CdmRecoveryJobId == null && ec.Includes("cdmRecoveryJobId",true))
        {
            this.CdmRecoveryJobId = "FETCH";
        }
        //      C# -> System.String? JobStatus
        // GraphQL -> jobStatus: String! (scalar)
        if (this.JobStatus == null && ec.Includes("jobStatus",true))
        {
            this.JobStatus = "FETCH";
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId == null && ec.Includes("vmId",true))
        {
            this.VmId = "FETCH";
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName == null && ec.Includes("vmName",true))
        {
            this.VmName = "FETCH";
        }
        //      C# -> System.Int64? VmSizeInKbs
        // GraphQL -> vmSizeInKbs: Long! (scalar)
        if (this.VmSizeInKbs == null && ec.Includes("vmSizeInKbs",true))
        {
            this.VmSizeInKbs = new System.Int64();
        }
    }


    #endregion

    } // class VmRecoveryJobInfo
    
    #endregion

    public static class ListVmRecoveryJobInfoExtensions
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
            this List<VmRecoveryJobInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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
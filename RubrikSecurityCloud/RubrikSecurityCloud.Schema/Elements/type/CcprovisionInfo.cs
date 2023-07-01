// CcprovisionInfo.cs
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
    #region CcprovisionInfo
    public class CcprovisionInfo: BaseType
    {
        #region members

        //      C# -> CcpJobStatus? JobStatus
        // GraphQL -> jobStatus: CcpJobStatus! (enum)
        [JsonProperty("jobStatus")]
        public CcpJobStatus? JobStatus { get; set; }

        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        [JsonProperty("jobType")]
        public CcpJobType? JobType { get; set; }

        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        [JsonProperty("vendor")]
        public CcpVendorType? Vendor { get; set; }

        //      C# -> System.String? MarshaledConfig
        // GraphQL -> marshaledConfig: String! (scalar)
        [JsonProperty("marshaledConfig")]
        public System.String? MarshaledConfig { get; set; }

        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        [JsonProperty("progress")]
        public System.Int32? Progress { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CcprovisionInfo";
    }

    public CcprovisionInfo Set(
        CcpJobStatus? JobStatus = null,
        CcpJobType? JobType = null,
        CcpVendorType? Vendor = null,
        System.String? MarshaledConfig = null,
        System.Int32? Progress = null
    ) 
    {
        if ( JobStatus != null ) {
            this.JobStatus = JobStatus;
        }
        if ( JobType != null ) {
            this.JobType = JobType;
        }
        if ( Vendor != null ) {
            this.Vendor = Vendor;
        }
        if ( MarshaledConfig != null ) {
            this.MarshaledConfig = MarshaledConfig;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
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
        //      C# -> CcpJobStatus? JobStatus
        // GraphQL -> jobStatus: CcpJobStatus! (enum)
        if (this.JobStatus != null) {
            s += ind + "jobStatus\n" ;
        }
        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        if (this.JobType != null) {
            s += ind + "jobType\n" ;
        }
        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        if (this.Vendor != null) {
            s += ind + "vendor\n" ;
        }
        //      C# -> System.String? MarshaledConfig
        // GraphQL -> marshaledConfig: String! (scalar)
        if (this.MarshaledConfig != null) {
            s += ind + "marshaledConfig\n" ;
        }
        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        if (this.Progress != null) {
            s += ind + "progress\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CcpJobStatus? JobStatus
        // GraphQL -> jobStatus: CcpJobStatus! (enum)
        if (this.JobStatus == null && Exploration.Includes(parent + ".jobStatus", true))
        {
            this.JobStatus = new CcpJobStatus();
        }
        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        if (this.JobType == null && Exploration.Includes(parent + ".jobType", true))
        {
            this.JobType = new CcpJobType();
        }
        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        if (this.Vendor == null && Exploration.Includes(parent + ".vendor", true))
        {
            this.Vendor = new CcpVendorType();
        }
        //      C# -> System.String? MarshaledConfig
        // GraphQL -> marshaledConfig: String! (scalar)
        if (this.MarshaledConfig == null && Exploration.Includes(parent + ".marshaledConfig", true))
        {
            this.MarshaledConfig = "FETCH";
        }
        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        if (this.Progress == null && Exploration.Includes(parent + ".progress", true))
        {
            this.Progress = Int32.MinValue;
        }
    }


    #endregion

    } // class CcprovisionInfo
    
    #endregion

    public static class ListCcprovisionInfoExtensions
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
            this List<CcprovisionInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CcprovisionInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CcprovisionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CcpJobStatus? JobStatus
        // GraphQL -> jobStatus: CcpJobStatus! (enum)
        if (this.JobStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobStatus\n" ;
            } else {
                s += ind + "jobStatus\n" ;
            }
        }
        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        if (this.JobType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobType\n" ;
            } else {
                s += ind + "jobType\n" ;
            }
        }
        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        if (this.Vendor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vendor\n" ;
            } else {
                s += ind + "vendor\n" ;
            }
        }
        //      C# -> System.String? MarshaledConfig
        // GraphQL -> marshaledConfig: String! (scalar)
        if (this.MarshaledConfig != null) {
            if (conf.Flat) {
                s += conf.Prefix + "marshaledConfig\n" ;
            } else {
                s += ind + "marshaledConfig\n" ;
            }
        }
        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        if (this.Progress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progress\n" ;
            } else {
                s += ind + "progress\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CcpJobStatus? JobStatus
        // GraphQL -> jobStatus: CcpJobStatus! (enum)
        if (ec.Includes("jobStatus",true))
        {
            if(this.JobStatus == null) {

                this.JobStatus = new CcpJobStatus();

            } else {


            }
        }
        else if (this.JobStatus != null && ec.Excludes("jobStatus",true))
        {
            this.JobStatus = null;
        }
        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        if (ec.Includes("jobType",true))
        {
            if(this.JobType == null) {

                this.JobType = new CcpJobType();

            } else {


            }
        }
        else if (this.JobType != null && ec.Excludes("jobType",true))
        {
            this.JobType = null;
        }
        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        if (ec.Includes("vendor",true))
        {
            if(this.Vendor == null) {

                this.Vendor = new CcpVendorType();

            } else {


            }
        }
        else if (this.Vendor != null && ec.Excludes("vendor",true))
        {
            this.Vendor = null;
        }
        //      C# -> System.String? MarshaledConfig
        // GraphQL -> marshaledConfig: String! (scalar)
        if (ec.Includes("marshaledConfig",true))
        {
            if(this.MarshaledConfig == null) {

                this.MarshaledConfig = "FETCH";

            } else {


            }
        }
        else if (this.MarshaledConfig != null && ec.Excludes("marshaledConfig",true))
        {
            this.MarshaledConfig = null;
        }
        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        if (ec.Includes("progress",true))
        {
            if(this.Progress == null) {

                this.Progress = Int32.MinValue;

            } else {


            }
        }
        else if (this.Progress != null && ec.Excludes("progress",true))
        {
            this.Progress = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CcprovisionInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CcprovisionInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CcprovisionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CcprovisionInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
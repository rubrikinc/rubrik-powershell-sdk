// VcenterConnectivityStatus.cs
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
    #region VcenterConnectivityStatus
    public class VcenterConnectivityStatus: BaseType
    {
        #region members

        //      C# -> HostConnectionStatusType? VcenterConnection
        // GraphQL -> vcenterConnection: HostConnectionStatusType! (enum)
        [JsonProperty("vcenterConnection")]
        public HostConnectionStatusType? VcenterConnection { get; set; }

        //      C# -> System.String? JobId
        // GraphQL -> jobId: String (scalar)
        [JsonProperty("jobId")]
        public System.String? JobId { get; set; }

        //      C# -> DateTime? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: DateTime (scalar)
        [JsonProperty("lastUpdatedTime")]
        public DateTime? LastUpdatedTime { get; set; }

        //      C# -> List<EsxiHostConnectivityStatus>? EsxiHosts
        // GraphQL -> esxiHosts: [EsxiHostConnectivityStatus!]! (type)
        [JsonProperty("esxiHosts")]
        public List<EsxiHostConnectivityStatus>? EsxiHosts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VcenterConnectivityStatus";
    }

    public VcenterConnectivityStatus Set(
        HostConnectionStatusType? VcenterConnection = null,
        System.String? JobId = null,
        DateTime? LastUpdatedTime = null,
        List<EsxiHostConnectivityStatus>? EsxiHosts = null
    ) 
    {
        if ( VcenterConnection != null ) {
            this.VcenterConnection = VcenterConnection;
        }
        if ( JobId != null ) {
            this.JobId = JobId;
        }
        if ( LastUpdatedTime != null ) {
            this.LastUpdatedTime = LastUpdatedTime;
        }
        if ( EsxiHosts != null ) {
            this.EsxiHosts = EsxiHosts;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> HostConnectionStatusType? VcenterConnection
        // GraphQL -> vcenterConnection: HostConnectionStatusType! (enum)
        if (this.VcenterConnection != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcenterConnection\n" ;
            } else {
                s += ind + "vcenterConnection\n" ;
            }
        }
        //      C# -> System.String? JobId
        // GraphQL -> jobId: String (scalar)
        if (this.JobId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobId\n" ;
            } else {
                s += ind + "jobId\n" ;
            }
        }
        //      C# -> DateTime? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: DateTime (scalar)
        if (this.LastUpdatedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastUpdatedTime\n" ;
            } else {
                s += ind + "lastUpdatedTime\n" ;
            }
        }
        //      C# -> List<EsxiHostConnectivityStatus>? EsxiHosts
        // GraphQL -> esxiHosts: [EsxiHostConnectivityStatus!]! (type)
        if (this.EsxiHosts != null) {
            var fspec = this.EsxiHosts.AsFieldSpec(conf.Child("esxiHosts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "esxiHosts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HostConnectionStatusType? VcenterConnection
        // GraphQL -> vcenterConnection: HostConnectionStatusType! (enum)
        if (ec.Includes("vcenterConnection",true))
        {
            if(this.VcenterConnection == null) {

                this.VcenterConnection = new HostConnectionStatusType();

            } else {


            }
        }
        else if (this.VcenterConnection != null && ec.Excludes("vcenterConnection",true))
        {
            this.VcenterConnection = null;
        }
        //      C# -> System.String? JobId
        // GraphQL -> jobId: String (scalar)
        if (ec.Includes("jobId",true))
        {
            if(this.JobId == null) {

                this.JobId = "FETCH";

            } else {


            }
        }
        else if (this.JobId != null && ec.Excludes("jobId",true))
        {
            this.JobId = null;
        }
        //      C# -> DateTime? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: DateTime (scalar)
        if (ec.Includes("lastUpdatedTime",true))
        {
            if(this.LastUpdatedTime == null) {

                this.LastUpdatedTime = new DateTime();

            } else {


            }
        }
        else if (this.LastUpdatedTime != null && ec.Excludes("lastUpdatedTime",true))
        {
            this.LastUpdatedTime = null;
        }
        //      C# -> List<EsxiHostConnectivityStatus>? EsxiHosts
        // GraphQL -> esxiHosts: [EsxiHostConnectivityStatus!]! (type)
        if (ec.Includes("esxiHosts",false))
        {
            if(this.EsxiHosts == null) {

                this.EsxiHosts = new List<EsxiHostConnectivityStatus>();
                this.EsxiHosts.ApplyExploratoryFieldSpec(ec.NewChild("esxiHosts"));

            } else {

                this.EsxiHosts.ApplyExploratoryFieldSpec(ec.NewChild("esxiHosts"));

            }
        }
        else if (this.EsxiHosts != null && ec.Excludes("esxiHosts",false))
        {
            this.EsxiHosts = null;
        }
    }


    #endregion

    } // class VcenterConnectivityStatus
    
    #endregion

    public static class ListVcenterConnectivityStatusExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<VcenterConnectivityStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VcenterConnectivityStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VcenterConnectivityStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VcenterConnectivityStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VcenterConnectivityStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// ReplicationTargetThrottleBypassSummary.cs
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
    #region ReplicationTargetThrottleBypassSummary
    public class ReplicationTargetThrottleBypassSummary: BaseType
    {
        #region members

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? ShouldBypassReplicationThrottle
        // GraphQL -> shouldBypassReplicationThrottle: Boolean! (scalar)
        [JsonProperty("shouldBypassReplicationThrottle")]
        public System.Boolean? ShouldBypassReplicationThrottle { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReplicationTargetThrottleBypassSummary";
    }

    public ReplicationTargetThrottleBypassSummary Set(
        System.String? ClusterName = null,
        System.String? Id = null,
        System.Boolean? ShouldBypassReplicationThrottle = null
    ) 
    {
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( ShouldBypassReplicationThrottle != null ) {
            this.ShouldBypassReplicationThrottle = ShouldBypassReplicationThrottle;
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
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldBypassReplicationThrottle
        // GraphQL -> shouldBypassReplicationThrottle: Boolean! (scalar)
        if (this.ShouldBypassReplicationThrottle != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldBypassReplicationThrottle\n" ;
            } else {
                s += ind + "shouldBypassReplicationThrottle\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? ShouldBypassReplicationThrottle
        // GraphQL -> shouldBypassReplicationThrottle: Boolean! (scalar)
        if (ec.Includes("shouldBypassReplicationThrottle",true))
        {
            if(this.ShouldBypassReplicationThrottle == null) {

                this.ShouldBypassReplicationThrottle = true;

            } else {


            }
        }
        else if (this.ShouldBypassReplicationThrottle != null && ec.Excludes("shouldBypassReplicationThrottle",true))
        {
            this.ShouldBypassReplicationThrottle = null;
        }
    }


    #endregion

    } // class ReplicationTargetThrottleBypassSummary
    
    #endregion

    public static class ListReplicationTargetThrottleBypassSummaryExtensions
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
            this List<ReplicationTargetThrottleBypassSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReplicationTargetThrottleBypassSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationTargetThrottleBypassSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationTargetThrottleBypassSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReplicationTargetThrottleBypassSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
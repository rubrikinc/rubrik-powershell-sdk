// ClusterInfoWithNotSyncableReasons.cs
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
    #region ClusterInfoWithNotSyncableReasons
    public class ClusterInfoWithNotSyncableReasons: BaseType
    {
        #region members

        //      C# -> List<SlaUnsyncableReason>? UnsyncableReasons
        // GraphQL -> unsyncableReasons: [SLAUnsyncableReason!]! (enum)
        [JsonProperty("unsyncableReasons")]
        public List<SlaUnsyncableReason>? UnsyncableReasons { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? ClusterVersion
        // GraphQL -> clusterVersion: String! (scalar)
        [JsonProperty("clusterVersion")]
        public System.String? ClusterVersion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterInfoWithNotSyncableReasons";
    }

    public ClusterInfoWithNotSyncableReasons Set(
        List<SlaUnsyncableReason>? UnsyncableReasons = null,
        System.String? ClusterName = null,
        System.String? ClusterUuid = null,
        System.String? ClusterVersion = null
    ) 
    {
        if ( UnsyncableReasons != null ) {
            this.UnsyncableReasons = UnsyncableReasons;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( ClusterVersion != null ) {
            this.ClusterVersion = ClusterVersion;
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
        //      C# -> List<SlaUnsyncableReason>? UnsyncableReasons
        // GraphQL -> unsyncableReasons: [SLAUnsyncableReason!]! (enum)
        if (this.UnsyncableReasons != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unsyncableReasons\n" ;
            } else {
                s += ind + "unsyncableReasons\n" ;
            }
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? ClusterVersion
        // GraphQL -> clusterVersion: String! (scalar)
        if (this.ClusterVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterVersion\n" ;
            } else {
                s += ind + "clusterVersion\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<SlaUnsyncableReason>? UnsyncableReasons
        // GraphQL -> unsyncableReasons: [SLAUnsyncableReason!]! (enum)
        if (ec.Includes("unsyncableReasons",true))
        {
            if(this.UnsyncableReasons == null) {

                this.UnsyncableReasons = new List<SlaUnsyncableReason>();

            } else {


            }
        }
        else if (this.UnsyncableReasons != null && ec.Excludes("unsyncableReasons",true))
        {
            this.UnsyncableReasons = null;
        }
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.String? ClusterVersion
        // GraphQL -> clusterVersion: String! (scalar)
        if (ec.Includes("clusterVersion",true))
        {
            if(this.ClusterVersion == null) {

                this.ClusterVersion = "FETCH";

            } else {


            }
        }
        else if (this.ClusterVersion != null && ec.Excludes("clusterVersion",true))
        {
            this.ClusterVersion = null;
        }
    }


    #endregion

    } // class ClusterInfoWithNotSyncableReasons
    
    #endregion

    public static class ListClusterInfoWithNotSyncableReasonsExtensions
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
            this List<ClusterInfoWithNotSyncableReasons> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterInfoWithNotSyncableReasons> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterInfoWithNotSyncableReasons> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterInfoWithNotSyncableReasons());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterInfoWithNotSyncableReasons> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
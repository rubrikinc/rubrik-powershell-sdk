// K8sSnapshotInfo.cs
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
    #region K8sSnapshotInfo
    public class K8sSnapshotInfo: BaseType
    {
        #region members

        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        [JsonProperty("expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        [JsonProperty("namespace")]
        public System.String? Namespace { get; set; }

        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime! (scalar)
        [JsonProperty("snapshotTime")]
        public DateTime? SnapshotTime { get; set; }

        //      C# -> List<PvcInformation>? PvcList
        // GraphQL -> pvcList: [PvcInformation!]! (type)
        [JsonProperty("pvcList")]
        public List<PvcInformation>? PvcList { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sSnapshotInfo";
    }

    public K8sSnapshotInfo Set(
        DateTime? ExpirationTime = null,
        System.Boolean? IsArchived = null,
        System.String? Namespace = null,
        DateTime? SnapshotTime = null,
        List<PvcInformation>? PvcList = null
    ) 
    {
        if ( ExpirationTime != null ) {
            this.ExpirationTime = ExpirationTime;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( Namespace != null ) {
            this.Namespace = Namespace;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
        }
        if ( PvcList != null ) {
            this.PvcList = PvcList;
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
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationTime\n" ;
            } else {
                s += ind + "expirationTime\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        if (this.Namespace != null) {
            if (conf.Flat) {
                s += conf.Prefix + "namespace\n" ;
            } else {
                s += ind + "namespace\n" ;
            }
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime! (scalar)
        if (this.SnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotTime\n" ;
            } else {
                s += ind + "snapshotTime\n" ;
            }
        }
        //      C# -> List<PvcInformation>? PvcList
        // GraphQL -> pvcList: [PvcInformation!]! (type)
        if (this.PvcList != null) {
            var fspec = this.PvcList.AsFieldSpec(conf.Child("pvcList"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pvcList" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (ec.Includes("expirationTime",true))
        {
            if(this.ExpirationTime == null) {

                this.ExpirationTime = new DateTime();

            } else {


            }
        }
        else if (this.ExpirationTime != null && ec.Excludes("expirationTime",true))
        {
            this.ExpirationTime = null;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        if (ec.Includes("namespace",true))
        {
            if(this.Namespace == null) {

                this.Namespace = "FETCH";

            } else {


            }
        }
        else if (this.Namespace != null && ec.Excludes("namespace",true))
        {
            this.Namespace = null;
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime! (scalar)
        if (ec.Includes("snapshotTime",true))
        {
            if(this.SnapshotTime == null) {

                this.SnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotTime != null && ec.Excludes("snapshotTime",true))
        {
            this.SnapshotTime = null;
        }
        //      C# -> List<PvcInformation>? PvcList
        // GraphQL -> pvcList: [PvcInformation!]! (type)
        if (ec.Includes("pvcList",false))
        {
            if(this.PvcList == null) {

                this.PvcList = new List<PvcInformation>();
                this.PvcList.ApplyExploratoryFieldSpec(ec.NewChild("pvcList"));

            } else {

                this.PvcList.ApplyExploratoryFieldSpec(ec.NewChild("pvcList"));

            }
        }
        else if (this.PvcList != null && ec.Excludes("pvcList",false))
        {
            this.PvcList = null;
        }
    }


    #endregion

    } // class K8sSnapshotInfo
    
    #endregion

    public static class ListK8sSnapshotInfoExtensions
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
            this List<K8sSnapshotInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sSnapshotInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sSnapshotInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sSnapshotInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sSnapshotInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
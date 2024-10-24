// TprReplicationPair.cs
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
    #region TprReplicationPair
    public class TprReplicationPair: BaseType
    {
        #region members

        //      C# -> System.String? SourceClusterName
        // GraphQL -> sourceClusterName: String! (scalar)
        [JsonProperty("sourceClusterName")]
        public System.String? SourceClusterName { get; set; }

        //      C# -> System.String? TargetClusterName
        // GraphQL -> targetClusterName: String! (scalar)
        [JsonProperty("targetClusterName")]
        public System.String? TargetClusterName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprReplicationPair";
    }

    public TprReplicationPair Set(
        System.String? SourceClusterName = null,
        System.String? TargetClusterName = null
    ) 
    {
        if ( SourceClusterName != null ) {
            this.SourceClusterName = SourceClusterName;
        }
        if ( TargetClusterName != null ) {
            this.TargetClusterName = TargetClusterName;
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
        //      C# -> System.String? SourceClusterName
        // GraphQL -> sourceClusterName: String! (scalar)
        if (this.SourceClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceClusterName\n" ;
            } else {
                s += ind + "sourceClusterName\n" ;
            }
        }
        //      C# -> System.String? TargetClusterName
        // GraphQL -> targetClusterName: String! (scalar)
        if (this.TargetClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetClusterName\n" ;
            } else {
                s += ind + "targetClusterName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? SourceClusterName
        // GraphQL -> sourceClusterName: String! (scalar)
        if (ec.Includes("sourceClusterName",true))
        {
            if(this.SourceClusterName == null) {

                this.SourceClusterName = "FETCH";

            } else {


            }
        }
        else if (this.SourceClusterName != null && ec.Excludes("sourceClusterName",true))
        {
            this.SourceClusterName = null;
        }
        //      C# -> System.String? TargetClusterName
        // GraphQL -> targetClusterName: String! (scalar)
        if (ec.Includes("targetClusterName",true))
        {
            if(this.TargetClusterName == null) {

                this.TargetClusterName = "FETCH";

            } else {


            }
        }
        else if (this.TargetClusterName != null && ec.Excludes("targetClusterName",true))
        {
            this.TargetClusterName = null;
        }
    }


    #endregion

    } // class TprReplicationPair
    
    #endregion

    public static class ListTprReplicationPairExtensions
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
            this List<TprReplicationPair> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TprReplicationPair> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TprReplicationPair> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprReplicationPair());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TprReplicationPair> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
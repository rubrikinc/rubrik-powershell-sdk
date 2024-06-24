// SlaReplicationPair.cs
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
    #region SlaReplicationPair
    public class SlaReplicationPair: BaseType
    {
        #region members

        //      C# -> SlaDataLocationCluster? SourceCluster
        // GraphQL -> sourceCluster: SlaDataLocationCluster! (type)
        [JsonProperty("sourceCluster")]
        public SlaDataLocationCluster? SourceCluster { get; set; }

        //      C# -> SlaDataLocationCluster? TargetCluster
        // GraphQL -> targetCluster: SlaDataLocationCluster! (type)
        [JsonProperty("targetCluster")]
        public SlaDataLocationCluster? TargetCluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SlaReplicationPair";
    }

    public SlaReplicationPair Set(
        SlaDataLocationCluster? SourceCluster = null,
        SlaDataLocationCluster? TargetCluster = null
    ) 
    {
        if ( SourceCluster != null ) {
            this.SourceCluster = SourceCluster;
        }
        if ( TargetCluster != null ) {
            this.TargetCluster = TargetCluster;
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
        //      C# -> SlaDataLocationCluster? SourceCluster
        // GraphQL -> sourceCluster: SlaDataLocationCluster! (type)
        if (this.SourceCluster != null) {
            var fspec = this.SourceCluster.AsFieldSpec(conf.Child("sourceCluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceCluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaDataLocationCluster? TargetCluster
        // GraphQL -> targetCluster: SlaDataLocationCluster! (type)
        if (this.TargetCluster != null) {
            var fspec = this.TargetCluster.AsFieldSpec(conf.Child("targetCluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetCluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SlaDataLocationCluster? SourceCluster
        // GraphQL -> sourceCluster: SlaDataLocationCluster! (type)
        if (ec.Includes("sourceCluster",false))
        {
            if(this.SourceCluster == null) {

                this.SourceCluster = new SlaDataLocationCluster();
                this.SourceCluster.ApplyExploratoryFieldSpec(ec.NewChild("sourceCluster"));

            } else {

                this.SourceCluster.ApplyExploratoryFieldSpec(ec.NewChild("sourceCluster"));

            }
        }
        else if (this.SourceCluster != null && ec.Excludes("sourceCluster",false))
        {
            this.SourceCluster = null;
        }
        //      C# -> SlaDataLocationCluster? TargetCluster
        // GraphQL -> targetCluster: SlaDataLocationCluster! (type)
        if (ec.Includes("targetCluster",false))
        {
            if(this.TargetCluster == null) {

                this.TargetCluster = new SlaDataLocationCluster();
                this.TargetCluster.ApplyExploratoryFieldSpec(ec.NewChild("targetCluster"));

            } else {

                this.TargetCluster.ApplyExploratoryFieldSpec(ec.NewChild("targetCluster"));

            }
        }
        else if (this.TargetCluster != null && ec.Excludes("targetCluster",false))
        {
            this.TargetCluster = null;
        }
    }


    #endregion

    } // class SlaReplicationPair
    
    #endregion

    public static class ListSlaReplicationPairExtensions
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
            this List<SlaReplicationPair> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SlaReplicationPair> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SlaReplicationPair> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaReplicationPair());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SlaReplicationPair> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
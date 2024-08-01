// ClassifiableAssetCount.cs
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
    #region ClassifiableAssetCount
    public class ClassifiableAssetCount: BaseType
    {
        #region members

        //      C# -> System.Int64? TotalAssetCount
        // GraphQL -> totalAssetCount: Long! (scalar)
        [JsonProperty("totalAssetCount")]
        public System.Int64? TotalAssetCount { get; set; }

        //      C# -> List<AssetCount>? AssetCount
        // GraphQL -> assetCount: [AssetCount!]! (type)
        [JsonProperty("assetCount")]
        public List<AssetCount>? AssetCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClassifiableAssetCount";
    }

    public ClassifiableAssetCount Set(
        System.Int64? TotalAssetCount = null,
        List<AssetCount>? AssetCount = null
    ) 
    {
        if ( TotalAssetCount != null ) {
            this.TotalAssetCount = TotalAssetCount;
        }
        if ( AssetCount != null ) {
            this.AssetCount = AssetCount;
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
        //      C# -> System.Int64? TotalAssetCount
        // GraphQL -> totalAssetCount: Long! (scalar)
        if (this.TotalAssetCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalAssetCount\n" ;
            } else {
                s += ind + "totalAssetCount\n" ;
            }
        }
        //      C# -> List<AssetCount>? AssetCount
        // GraphQL -> assetCount: [AssetCount!]! (type)
        if (this.AssetCount != null) {
            var fspec = this.AssetCount.AsFieldSpec(conf.Child("assetCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "assetCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? TotalAssetCount
        // GraphQL -> totalAssetCount: Long! (scalar)
        if (ec.Includes("totalAssetCount",true))
        {
            if(this.TotalAssetCount == null) {

                this.TotalAssetCount = new System.Int64();

            } else {


            }
        }
        else if (this.TotalAssetCount != null && ec.Excludes("totalAssetCount",true))
        {
            this.TotalAssetCount = null;
        }
        //      C# -> List<AssetCount>? AssetCount
        // GraphQL -> assetCount: [AssetCount!]! (type)
        if (ec.Includes("assetCount",false))
        {
            if(this.AssetCount == null) {

                this.AssetCount = new List<AssetCount>();
                this.AssetCount.ApplyExploratoryFieldSpec(ec.NewChild("assetCount"));

            } else {

                this.AssetCount.ApplyExploratoryFieldSpec(ec.NewChild("assetCount"));

            }
        }
        else if (this.AssetCount != null && ec.Excludes("assetCount",false))
        {
            this.AssetCount = null;
        }
    }


    #endregion

    } // class ClassifiableAssetCount
    
    #endregion

    public static class ListClassifiableAssetCountExtensions
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
            this List<ClassifiableAssetCount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClassifiableAssetCount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClassifiableAssetCount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClassifiableAssetCount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClassifiableAssetCount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
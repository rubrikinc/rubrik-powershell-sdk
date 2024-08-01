// GetRcvRegionsReply.cs
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
    #region GetRcvRegionsReply
    public class GetRcvRegionsReply: BaseType
    {
        #region members

        //      C# -> List<RcvRegionList>? RegionList
        // GraphQL -> regionList: [RCVRegionList!]! (type)
        [JsonProperty("regionList")]
        public List<RcvRegionList>? RegionList { get; set; }

        //      C# -> List<RegionPair>? RegionMap
        // GraphQL -> regionMap: [RegionPair!]! (type)
        [JsonProperty("regionMap")]
        public List<RegionPair>? RegionMap { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetRCVRegionsReply";
    }

    public GetRcvRegionsReply Set(
        List<RcvRegionList>? RegionList = null,
        List<RegionPair>? RegionMap = null
    ) 
    {
        if ( RegionList != null ) {
            this.RegionList = RegionList;
        }
        if ( RegionMap != null ) {
            this.RegionMap = RegionMap;
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
        //      C# -> List<RcvRegionList>? RegionList
        // GraphQL -> regionList: [RCVRegionList!]! (type)
        if (this.RegionList != null) {
            var fspec = this.RegionList.AsFieldSpec(conf.Child("regionList"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "regionList" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RegionPair>? RegionMap
        // GraphQL -> regionMap: [RegionPair!]! (type)
        if (this.RegionMap != null) {
            var fspec = this.RegionMap.AsFieldSpec(conf.Child("regionMap"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "regionMap" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<RcvRegionList>? RegionList
        // GraphQL -> regionList: [RCVRegionList!]! (type)
        if (ec.Includes("regionList",false))
        {
            if(this.RegionList == null) {

                this.RegionList = new List<RcvRegionList>();
                this.RegionList.ApplyExploratoryFieldSpec(ec.NewChild("regionList"));

            } else {

                this.RegionList.ApplyExploratoryFieldSpec(ec.NewChild("regionList"));

            }
        }
        else if (this.RegionList != null && ec.Excludes("regionList",false))
        {
            this.RegionList = null;
        }
        //      C# -> List<RegionPair>? RegionMap
        // GraphQL -> regionMap: [RegionPair!]! (type)
        if (ec.Includes("regionMap",false))
        {
            if(this.RegionMap == null) {

                this.RegionMap = new List<RegionPair>();
                this.RegionMap.ApplyExploratoryFieldSpec(ec.NewChild("regionMap"));

            } else {

                this.RegionMap.ApplyExploratoryFieldSpec(ec.NewChild("regionMap"));

            }
        }
        else if (this.RegionMap != null && ec.Excludes("regionMap",false))
        {
            this.RegionMap = null;
        }
    }


    #endregion

    } // class GetRcvRegionsReply
    
    #endregion

    public static class ListGetRcvRegionsReplyExtensions
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
            this List<GetRcvRegionsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetRcvRegionsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetRcvRegionsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetRcvRegionsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetRcvRegionsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
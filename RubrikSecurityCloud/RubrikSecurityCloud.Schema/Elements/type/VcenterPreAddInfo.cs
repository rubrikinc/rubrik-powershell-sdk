// VcenterPreAddInfo.cs
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
    #region VcenterPreAddInfo
    public class VcenterPreAddInfo: BaseType
    {
        #region members

        //      C# -> List<ClusterHostGroupInfo>? ClusterHostGroupInfo
        // GraphQL -> clusterHostGroupInfo: [ClusterHostGroupInfo!]! (type)
        [JsonProperty("clusterHostGroupInfo")]
        public List<ClusterHostGroupInfo>? ClusterHostGroupInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VcenterPreAddInfo";
    }

    public VcenterPreAddInfo Set(
        List<ClusterHostGroupInfo>? ClusterHostGroupInfo = null
    ) 
    {
        if ( ClusterHostGroupInfo != null ) {
            this.ClusterHostGroupInfo = ClusterHostGroupInfo;
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
        //      C# -> List<ClusterHostGroupInfo>? ClusterHostGroupInfo
        // GraphQL -> clusterHostGroupInfo: [ClusterHostGroupInfo!]! (type)
        if (this.ClusterHostGroupInfo != null) {
            var fspec = this.ClusterHostGroupInfo.AsFieldSpec(conf.Child("clusterHostGroupInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterHostGroupInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ClusterHostGroupInfo>? ClusterHostGroupInfo
        // GraphQL -> clusterHostGroupInfo: [ClusterHostGroupInfo!]! (type)
        if (ec.Includes("clusterHostGroupInfo",false))
        {
            if(this.ClusterHostGroupInfo == null) {

                this.ClusterHostGroupInfo = new List<ClusterHostGroupInfo>();
                this.ClusterHostGroupInfo.ApplyExploratoryFieldSpec(ec.NewChild("clusterHostGroupInfo"));

            } else {

                this.ClusterHostGroupInfo.ApplyExploratoryFieldSpec(ec.NewChild("clusterHostGroupInfo"));

            }
        }
        else if (this.ClusterHostGroupInfo != null && ec.Excludes("clusterHostGroupInfo",false))
        {
            this.ClusterHostGroupInfo = null;
        }
    }


    #endregion

    } // class VcenterPreAddInfo
    
    #endregion

    public static class ListVcenterPreAddInfoExtensions
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
            this List<VcenterPreAddInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VcenterPreAddInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VcenterPreAddInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VcenterPreAddInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VcenterPreAddInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
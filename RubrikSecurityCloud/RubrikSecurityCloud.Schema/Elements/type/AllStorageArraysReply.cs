// AllStorageArraysReply.cs
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
    #region AllStorageArraysReply
    public class AllStorageArraysReply: BaseType
    {
        #region members

        //      C# -> List<ClusterStorageArrays>? ClusterStorageArrays
        // GraphQL -> clusterStorageArrays: [ClusterStorageArrays!]! (type)
        [JsonProperty("clusterStorageArrays")]
        public List<ClusterStorageArrays>? ClusterStorageArrays { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AllStorageArraysReply";
    }

    public AllStorageArraysReply Set(
        List<ClusterStorageArrays>? ClusterStorageArrays = null
    ) 
    {
        if ( ClusterStorageArrays != null ) {
            this.ClusterStorageArrays = ClusterStorageArrays;
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
        //      C# -> List<ClusterStorageArrays>? ClusterStorageArrays
        // GraphQL -> clusterStorageArrays: [ClusterStorageArrays!]! (type)
        if (this.ClusterStorageArrays != null) {
            var fspec = this.ClusterStorageArrays.AsFieldSpec(conf.Child("clusterStorageArrays"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterStorageArrays" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ClusterStorageArrays>? ClusterStorageArrays
        // GraphQL -> clusterStorageArrays: [ClusterStorageArrays!]! (type)
        if (ec.Includes("clusterStorageArrays",false))
        {
            if(this.ClusterStorageArrays == null) {

                this.ClusterStorageArrays = new List<ClusterStorageArrays>();
                this.ClusterStorageArrays.ApplyExploratoryFieldSpec(ec.NewChild("clusterStorageArrays"));

            } else {

                this.ClusterStorageArrays.ApplyExploratoryFieldSpec(ec.NewChild("clusterStorageArrays"));

            }
        }
        else if (this.ClusterStorageArrays != null && ec.Excludes("clusterStorageArrays",false))
        {
            this.ClusterStorageArrays = null;
        }
    }


    #endregion

    } // class AllStorageArraysReply
    
    #endregion

    public static class ListAllStorageArraysReplyExtensions
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
            this List<AllStorageArraysReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AllStorageArraysReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AllStorageArraysReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AllStorageArraysReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AllStorageArraysReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
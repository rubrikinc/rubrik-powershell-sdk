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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterStorageArrays {\n" + fspec + ind + "}\n" ;
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
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<AllStorageArraysReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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
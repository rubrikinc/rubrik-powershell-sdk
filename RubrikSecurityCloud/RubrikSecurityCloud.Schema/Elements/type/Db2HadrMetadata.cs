// Db2HadrMetadata.cs
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
    #region Db2HadrMetadata
    public class Db2HadrMetadata: BaseType
    {
        #region members

        //      C# -> List<Db2HadrInstanceInfo>? InstancesInfoList
        // GraphQL -> instancesInfoList: [Db2HadrInstanceInfo!]! (type)
        [JsonProperty("instancesInfoList")]
        public List<Db2HadrInstanceInfo>? InstancesInfoList { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Db2HadrMetadata";
    }

    public Db2HadrMetadata Set(
        List<Db2HadrInstanceInfo>? InstancesInfoList = null
    ) 
    {
        if ( InstancesInfoList != null ) {
            this.InstancesInfoList = InstancesInfoList;
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
        //      C# -> List<Db2HadrInstanceInfo>? InstancesInfoList
        // GraphQL -> instancesInfoList: [Db2HadrInstanceInfo!]! (type)
        if (this.InstancesInfoList != null) {
            var fspec = this.InstancesInfoList.AsFieldSpec(conf.Child("instancesInfoList"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "instancesInfoList {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<Db2HadrInstanceInfo>? InstancesInfoList
        // GraphQL -> instancesInfoList: [Db2HadrInstanceInfo!]! (type)
        if (ec.Includes("instancesInfoList",false))
        {
            if(this.InstancesInfoList == null) {

                this.InstancesInfoList = new List<Db2HadrInstanceInfo>();
                this.InstancesInfoList.ApplyExploratoryFieldSpec(ec.NewChild("instancesInfoList"));

            } else {

                this.InstancesInfoList.ApplyExploratoryFieldSpec(ec.NewChild("instancesInfoList"));

            }
        }
        else if (this.InstancesInfoList != null && ec.Excludes("instancesInfoList",false))
        {
            this.InstancesInfoList = null;
        }
    }


    #endregion

    } // class Db2HadrMetadata
    
    #endregion

    public static class ListDb2HadrMetadataExtensions
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
            this List<Db2HadrMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<Db2HadrMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Db2HadrMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2HadrMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Db2HadrMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
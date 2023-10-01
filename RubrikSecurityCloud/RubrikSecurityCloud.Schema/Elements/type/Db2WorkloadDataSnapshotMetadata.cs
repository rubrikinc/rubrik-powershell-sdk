// Db2WorkloadDataSnapshotMetadata.cs
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
    #region Db2WorkloadDataSnapshotMetadata
    public class Db2WorkloadDataSnapshotMetadata: BaseType
    {
        #region members

        //      C# -> List<System.String>? KvSnapshotFileInstancesInfoList
        // GraphQL -> kvSnapshotFileInstancesInfoList: [String!]! (scalar)
        [JsonProperty("kvSnapshotFileInstancesInfoList")]
        public List<System.String>? KvSnapshotFileInstancesInfoList { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Db2WorkloadDataSnapshotMetadata";
    }

    public Db2WorkloadDataSnapshotMetadata Set(
        List<System.String>? KvSnapshotFileInstancesInfoList = null
    ) 
    {
        if ( KvSnapshotFileInstancesInfoList != null ) {
            this.KvSnapshotFileInstancesInfoList = KvSnapshotFileInstancesInfoList;
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
        //      C# -> List<System.String>? KvSnapshotFileInstancesInfoList
        // GraphQL -> kvSnapshotFileInstancesInfoList: [String!]! (scalar)
        if (this.KvSnapshotFileInstancesInfoList != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kvSnapshotFileInstancesInfoList\n" ;
            } else {
                s += ind + "kvSnapshotFileInstancesInfoList\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? KvSnapshotFileInstancesInfoList
        // GraphQL -> kvSnapshotFileInstancesInfoList: [String!]! (scalar)
        if (ec.Includes("kvSnapshotFileInstancesInfoList",true))
        {
            if(this.KvSnapshotFileInstancesInfoList == null) {

                this.KvSnapshotFileInstancesInfoList = new List<System.String>();

            } else {


            }
        }
        else if (this.KvSnapshotFileInstancesInfoList != null && ec.Excludes("kvSnapshotFileInstancesInfoList",true))
        {
            this.KvSnapshotFileInstancesInfoList = null;
        }
    }


    #endregion

    } // class Db2WorkloadDataSnapshotMetadata
    
    #endregion

    public static class ListDb2WorkloadDataSnapshotMetadataExtensions
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
            this List<Db2WorkloadDataSnapshotMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<Db2WorkloadDataSnapshotMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Db2WorkloadDataSnapshotMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2WorkloadDataSnapshotMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Db2WorkloadDataSnapshotMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
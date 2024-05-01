// ObjectIdToSnapshotIds.cs
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
    #region ObjectIdToSnapshotIds
    public class ObjectIdToSnapshotIds: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> List<System.String>? Snapshots
        // GraphQL -> snapshots: [String!]! (scalar)
        [JsonProperty("snapshots")]
        public List<System.String>? Snapshots { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectIdToSnapshotIds";
    }

    public ObjectIdToSnapshotIds Set(
        System.String? Id = null,
        List<System.String>? Snapshots = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Snapshots != null ) {
            this.Snapshots = Snapshots;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> List<System.String>? Snapshots
        // GraphQL -> snapshots: [String!]! (scalar)
        if (this.Snapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshots\n" ;
            } else {
                s += ind + "snapshots\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> List<System.String>? Snapshots
        // GraphQL -> snapshots: [String!]! (scalar)
        if (ec.Includes("snapshots",true))
        {
            if(this.Snapshots == null) {

                this.Snapshots = new List<System.String>();

            } else {


            }
        }
        else if (this.Snapshots != null && ec.Excludes("snapshots",true))
        {
            this.Snapshots = null;
        }
    }


    #endregion

    } // class ObjectIdToSnapshotIds
    
    #endregion

    public static class ListObjectIdToSnapshotIdsExtensions
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
            this List<ObjectIdToSnapshotIds> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ObjectIdToSnapshotIds> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ObjectIdToSnapshotIds> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectIdToSnapshotIds());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectIdToSnapshotIds> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// ManagedObjectSummary.cs
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
    #region ManagedObjectSummary
    public class ManagedObjectSummary: BaseType
    {
        #region members

        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        [JsonProperty("objectType")]
        public ManagedObjectType? ObjectType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        [JsonProperty("slaDomainName")]
        public System.String? SlaDomainName { get; set; }

        //      C# -> List<SnapshotDetails>? SnapshotsDetails
        // GraphQL -> snapshotsDetails: [SnapshotDetails!]! (type)
        [JsonProperty("snapshotsDetails")]
        public List<SnapshotDetails>? SnapshotsDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedObjectSummary";
    }

    public ManagedObjectSummary Set(
        ManagedObjectType? ObjectType = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? SlaDomainName = null,
        List<SnapshotDetails>? SnapshotsDetails = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SlaDomainName != null ) {
            this.SlaDomainName = SlaDomainName;
        }
        if ( SnapshotsDetails != null ) {
            this.SnapshotsDetails = SnapshotsDetails;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        if (this.SlaDomainName != null) {
            s += ind + "slaDomainName\n" ;
        }
        //      C# -> List<SnapshotDetails>? SnapshotsDetails
        // GraphQL -> snapshotsDetails: [SnapshotDetails!]! (type)
        if (this.SnapshotsDetails != null) {
            var fspec = this.SnapshotsDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotsDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        if (this.ObjectType == null && ec.Includes("objectType",true))
        {
            this.ObjectType = new ManagedObjectType();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        if (this.SlaDomainName == null && ec.Includes("slaDomainName",true))
        {
            this.SlaDomainName = "FETCH";
        }
        //      C# -> List<SnapshotDetails>? SnapshotsDetails
        // GraphQL -> snapshotsDetails: [SnapshotDetails!]! (type)
        if (this.SnapshotsDetails == null && ec.Includes("snapshotsDetails",false))
        {
            this.SnapshotsDetails = new List<SnapshotDetails>();
            this.SnapshotsDetails.ApplyExploratoryFieldSpec(ec.NewChild("snapshotsDetails"));
        }
    }


    #endregion

    } // class ManagedObjectSummary
    
    #endregion

    public static class ListManagedObjectSummaryExtensions
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
            this List<ManagedObjectSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedObjectSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedObjectSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ManagedObjectSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
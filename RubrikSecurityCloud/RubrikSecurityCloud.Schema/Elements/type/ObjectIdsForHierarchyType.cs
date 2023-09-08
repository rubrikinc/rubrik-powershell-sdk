// ObjectIdsForHierarchyType.cs
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
    #region ObjectIdsForHierarchyType
    public class ObjectIdsForHierarchyType: BaseType
    {
        #region members

        //      C# -> WorkloadLevelHierarchy? SnappableType
        // GraphQL -> snappableType: WorkloadLevelHierarchy! (enum)
        [JsonProperty("snappableType")]
        public WorkloadLevelHierarchy? SnappableType { get; set; }

        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        [JsonProperty("objectIds")]
        public List<System.String>? ObjectIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectIdsForHierarchyType";
    }

    public ObjectIdsForHierarchyType Set(
        WorkloadLevelHierarchy? SnappableType = null,
        List<System.String>? ObjectIds = null
    ) 
    {
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
        }
        if ( ObjectIds != null ) {
            this.ObjectIds = ObjectIds;
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
        //      C# -> WorkloadLevelHierarchy? SnappableType
        // GraphQL -> snappableType: WorkloadLevelHierarchy! (enum)
        if (this.SnappableType != null) {
            s += ind + "snappableType\n" ;
        }
        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        if (this.ObjectIds != null) {
            s += ind + "objectIds\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> WorkloadLevelHierarchy? SnappableType
        // GraphQL -> snappableType: WorkloadLevelHierarchy! (enum)
        if (this.SnappableType == null && ec.Includes("snappableType",true))
        {
            this.SnappableType = new WorkloadLevelHierarchy();
        }
        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        if (this.ObjectIds == null && ec.Includes("objectIds",true))
        {
            this.ObjectIds = new List<System.String>();
        }
    }


    #endregion

    } // class ObjectIdsForHierarchyType
    
    #endregion

    public static class ListObjectIdsForHierarchyTypeExtensions
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
            this List<ObjectIdsForHierarchyType> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ObjectIdsForHierarchyType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectIdsForHierarchyType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ObjectIdsForHierarchyType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
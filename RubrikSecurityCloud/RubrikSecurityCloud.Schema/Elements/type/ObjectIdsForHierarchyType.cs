// ObjectIdsForHierarchyType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:02.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region ObjectIdsForHierarchyType
    public class ObjectIdsForHierarchyType: IFragment
    {
        #region members
        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        [JsonProperty("objectIds")]
        public List<System.String>? ObjectIds { get; set; }

        //      C# -> WorkloadLevelHierarchy? SnappableType
        // GraphQL -> snappableType: WorkloadLevelHierarchy! (enum)
        [JsonProperty("snappableType")]
        public WorkloadLevelHierarchy? SnappableType { get; set; }

        #endregion

    #region methods

    public ObjectIdsForHierarchyType Set(
        List<System.String>? ObjectIds = null,
        WorkloadLevelHierarchy? SnappableType = null
    ) 
    {
        if ( ObjectIds != null ) {
            this.ObjectIds = ObjectIds;
        }
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<System.String>? ObjectIds
            // GraphQL -> objectIds: [String!]! (scalar)
            if (this.ObjectIds != null)
            {
                 s += ind + "objectIds\n";

            }
            //      C# -> WorkloadLevelHierarchy? SnappableType
            // GraphQL -> snappableType: WorkloadLevelHierarchy! (enum)
            if (this.SnappableType != null)
            {
                 s += ind + "snappableType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? ObjectIds
            // GraphQL -> objectIds: [String!]! (scalar)
            if (this.ObjectIds == null && Exploration.Includes(parent + ".objectIds$"))
            {
                this.ObjectIds = new List<System.String>();
            }
            //      C# -> WorkloadLevelHierarchy? SnappableType
            // GraphQL -> snappableType: WorkloadLevelHierarchy! (enum)
            if (this.SnappableType == null && Exploration.Includes(parent + ".snappableType$"))
            {
                this.SnappableType = new WorkloadLevelHierarchy();
            }
        }


    #endregion

    } // class ObjectIdsForHierarchyType
    #endregion

    public static class ListObjectIdsForHierarchyTypeExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<ObjectIdsForHierarchyType> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ObjectIdsForHierarchyType> list, 
            String parent = "")
        {
            var item = new ObjectIdsForHierarchyType();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
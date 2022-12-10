// Permission.cs
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
    #region Permission
    public class Permission: IFragment
    {
        #region members
        //      C# -> List<ObjectIdsForHierarchyType>? ObjectsForHierarchyTypes
        // GraphQL -> objectsForHierarchyTypes: [ObjectIdsForHierarchyType!]! (type)
        [JsonProperty("objectsForHierarchyTypes")]
        public List<ObjectIdsForHierarchyType>? ObjectsForHierarchyTypes { get; set; }

        //      C# -> Operation? Operation
        // GraphQL -> operation: Operation! (enum)
        [JsonProperty("operation")]
        public Operation? Operation { get; set; }

        #endregion

    #region methods

    public Permission Set(
        List<ObjectIdsForHierarchyType>? ObjectsForHierarchyTypes = null,
        Operation? Operation = null
    ) 
    {
        if ( ObjectsForHierarchyTypes != null ) {
            this.ObjectsForHierarchyTypes = ObjectsForHierarchyTypes;
        }
        if ( Operation != null ) {
            this.Operation = Operation;
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
            //      C# -> List<ObjectIdsForHierarchyType>? ObjectsForHierarchyTypes
            // GraphQL -> objectsForHierarchyTypes: [ObjectIdsForHierarchyType!]! (type)
            if (this.ObjectsForHierarchyTypes != null)
            {
                 s += ind + "objectsForHierarchyTypes\n";

                 s += ind + "{\n" + 
                 this.ObjectsForHierarchyTypes.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Operation? Operation
            // GraphQL -> operation: Operation! (enum)
            if (this.Operation != null)
            {
                 s += ind + "operation\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<ObjectIdsForHierarchyType>? ObjectsForHierarchyTypes
            // GraphQL -> objectsForHierarchyTypes: [ObjectIdsForHierarchyType!]! (type)
            if (this.ObjectsForHierarchyTypes == null && Exploration.Includes(parent + ".objectsForHierarchyTypes"))
            {
                this.ObjectsForHierarchyTypes = new List<ObjectIdsForHierarchyType>();
                this.ObjectsForHierarchyTypes.ApplyExploratoryFragment(parent + ".objectsForHierarchyTypes");
            }
            //      C# -> Operation? Operation
            // GraphQL -> operation: Operation! (enum)
            if (this.Operation == null && Exploration.Includes(parent + ".operation$"))
            {
                this.Operation = new Operation();
            }
        }


    #endregion

    } // class Permission
    #endregion

    public static class ListPermissionExtensions
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
            this List<Permission> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Permission> list, 
            String parent = "")
        {
            var item = new Permission();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
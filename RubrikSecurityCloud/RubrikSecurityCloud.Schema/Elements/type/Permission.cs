// Permission.cs
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
    #region Permission
    public class Permission: BaseType
    {
        #region members

        //      C# -> Operation? Operation
        // GraphQL -> operation: Operation! (enum)
        [JsonProperty("operation")]
        public Operation? Operation { get; set; }

        //      C# -> List<ObjectIdsForHierarchyType>? ObjectsForHierarchyTypes
        // GraphQL -> objectsForHierarchyTypes: [ObjectIdsForHierarchyType!]! (type)
        [JsonProperty("objectsForHierarchyTypes")]
        public List<ObjectIdsForHierarchyType>? ObjectsForHierarchyTypes { get; set; }


        #endregion

    #region methods

    public Permission Set(
        Operation? Operation = null,
        List<ObjectIdsForHierarchyType>? ObjectsForHierarchyTypes = null
    ) 
    {
        if ( Operation != null ) {
            this.Operation = Operation;
        }
        if ( ObjectsForHierarchyTypes != null ) {
            this.ObjectsForHierarchyTypes = ObjectsForHierarchyTypes;
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
        //      C# -> Operation? Operation
        // GraphQL -> operation: Operation! (enum)
        if (this.Operation != null) {
            s += ind + "operation\n" ;
        }
        //      C# -> List<ObjectIdsForHierarchyType>? ObjectsForHierarchyTypes
        // GraphQL -> objectsForHierarchyTypes: [ObjectIdsForHierarchyType!]! (type)
        if (this.ObjectsForHierarchyTypes != null) {
            var fspec = this.ObjectsForHierarchyTypes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "objectsForHierarchyTypes {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> Operation? Operation
        // GraphQL -> operation: Operation! (enum)
        if (this.Operation == null && Exploration.Includes(parent + ".operation", true))
        {
            this.Operation = new Operation();
        }
        //      C# -> List<ObjectIdsForHierarchyType>? ObjectsForHierarchyTypes
        // GraphQL -> objectsForHierarchyTypes: [ObjectIdsForHierarchyType!]! (type)
        if (this.ObjectsForHierarchyTypes == null && Exploration.Includes(parent + ".objectsForHierarchyTypes"))
        {
            this.ObjectsForHierarchyTypes = new List<ObjectIdsForHierarchyType>();
            this.ObjectsForHierarchyTypes.ApplyExploratoryFieldSpec(parent + ".objectsForHierarchyTypes");
        }
    }


    #endregion

    } // class Permission
    
    #endregion

    public static class ListPermissionExtensions
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
            this List<Permission> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Permission> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Permission());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
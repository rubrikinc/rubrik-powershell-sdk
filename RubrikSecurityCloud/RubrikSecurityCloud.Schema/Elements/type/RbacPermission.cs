// RbacPermission.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region RbacPermission
    public class RbacPermission: BaseType
    {
        #region members

        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        [JsonProperty("operations")]
        public List<Operation>? Operations { get; set; }

        //      C# -> RbacObject? RbacObject
        // GraphQL -> rbacObject: RbacObject! (type)
        [JsonProperty("rbacObject")]
        public RbacObject? RbacObject { get; set; }


        #endregion

    #region methods

    public RbacPermission Set(
        List<Operation>? Operations = null,
        RbacObject? RbacObject = null
    ) 
    {
        if ( Operations != null ) {
            this.Operations = Operations;
        }
        if ( RbacObject != null ) {
            this.RbacObject = RbacObject;
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
        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        if (this.Operations != null) {
            s += ind + "operations\n" ;
        }
        //      C# -> RbacObject? RbacObject
        // GraphQL -> rbacObject: RbacObject! (type)
        if (this.RbacObject != null) {
            var fspec = this.RbacObject.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "rbacObject {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        if (this.Operations == null && Exploration.Includes(parent + ".operations", true))
        {
            this.Operations = new List<Operation>();
        }
        //      C# -> RbacObject? RbacObject
        // GraphQL -> rbacObject: RbacObject! (type)
        if (this.RbacObject == null && Exploration.Includes(parent + ".rbacObject"))
        {
            this.RbacObject = new RbacObject();
            this.RbacObject.ApplyExploratoryFieldSpec(parent + ".rbacObject");
        }
    }


    #endregion

    } // class RbacPermission
    
    #endregion

    public static class ListRbacPermissionExtensions
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
            this List<RbacPermission> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RbacPermission> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RbacPermission());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
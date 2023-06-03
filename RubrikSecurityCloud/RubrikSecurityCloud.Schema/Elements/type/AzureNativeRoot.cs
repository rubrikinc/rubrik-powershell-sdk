// AzureNativeRoot.cs
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
    #region AzureNativeRoot
    public class AzureNativeRoot: BaseType
    {
        #region members

        //      C# -> AzureNativeHierarchyObjectTypeConnection? ObjectTypeDescendantConnection
        // GraphQL -> objectTypeDescendantConnection: AzureNativeHierarchyObjectTypeConnection! (type)
        [JsonProperty("objectTypeDescendantConnection")]
        public AzureNativeHierarchyObjectTypeConnection? ObjectTypeDescendantConnection { get; set; }


        #endregion

    #region methods

    public AzureNativeRoot Set(
        AzureNativeHierarchyObjectTypeConnection? ObjectTypeDescendantConnection = null
    ) 
    {
        if ( ObjectTypeDescendantConnection != null ) {
            this.ObjectTypeDescendantConnection = ObjectTypeDescendantConnection;
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
        //      C# -> AzureNativeHierarchyObjectTypeConnection? ObjectTypeDescendantConnection
        // GraphQL -> objectTypeDescendantConnection: AzureNativeHierarchyObjectTypeConnection! (type)
        if (this.ObjectTypeDescendantConnection != null) {
            s += ind + "objectTypeDescendantConnection {\n" + this.ObjectTypeDescendantConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AzureNativeHierarchyObjectTypeConnection? ObjectTypeDescendantConnection
        // GraphQL -> objectTypeDescendantConnection: AzureNativeHierarchyObjectTypeConnection! (type)
        if (this.ObjectTypeDescendantConnection == null && Exploration.Includes(parent + ".objectTypeDescendantConnection"))
        {
            this.ObjectTypeDescendantConnection = new AzureNativeHierarchyObjectTypeConnection();
            this.ObjectTypeDescendantConnection.ApplyExploratoryFieldSpec(parent + ".objectTypeDescendantConnection");
        }
    }


    #endregion

    } // class AzureNativeRoot
    
    #endregion

    public static class ListAzureNativeRootExtensions
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
            this List<AzureNativeRoot> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeRoot> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeRoot());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
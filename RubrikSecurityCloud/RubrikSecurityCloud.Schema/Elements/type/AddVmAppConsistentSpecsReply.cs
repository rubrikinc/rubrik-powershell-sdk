// AddVmAppConsistentSpecsReply.cs
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
    #region AddVmAppConsistentSpecsReply
    public class AddVmAppConsistentSpecsReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? FailedSnappableIds
        // GraphQL -> failedSnappableIds: [String!]! (scalar)
        [JsonProperty("failedSnappableIds")]
        public List<System.String>? FailedSnappableIds { get; set; }

        //      C# -> List<System.String>? SuccessSnappableIds
        // GraphQL -> successSnappableIds: [String!]! (scalar)
        [JsonProperty("successSnappableIds")]
        public List<System.String>? SuccessSnappableIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AddVmAppConsistentSpecsReply";
    }

    public AddVmAppConsistentSpecsReply Set(
        List<System.String>? FailedSnappableIds = null,
        List<System.String>? SuccessSnappableIds = null
    ) 
    {
        if ( FailedSnappableIds != null ) {
            this.FailedSnappableIds = FailedSnappableIds;
        }
        if ( SuccessSnappableIds != null ) {
            this.SuccessSnappableIds = SuccessSnappableIds;
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
        //      C# -> List<System.String>? FailedSnappableIds
        // GraphQL -> failedSnappableIds: [String!]! (scalar)
        if (this.FailedSnappableIds != null) {
            s += ind + "failedSnappableIds\n" ;
        }
        //      C# -> List<System.String>? SuccessSnappableIds
        // GraphQL -> successSnappableIds: [String!]! (scalar)
        if (this.SuccessSnappableIds != null) {
            s += ind + "successSnappableIds\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? FailedSnappableIds
        // GraphQL -> failedSnappableIds: [String!]! (scalar)
        if (this.FailedSnappableIds == null && Exploration.Includes(parent + ".failedSnappableIds", true))
        {
            this.FailedSnappableIds = new List<System.String>();
        }
        //      C# -> List<System.String>? SuccessSnappableIds
        // GraphQL -> successSnappableIds: [String!]! (scalar)
        if (this.SuccessSnappableIds == null && Exploration.Includes(parent + ".successSnappableIds", true))
        {
            this.SuccessSnappableIds = new List<System.String>();
        }
    }


    #endregion

    } // class AddVmAppConsistentSpecsReply
    
    #endregion

    public static class ListAddVmAppConsistentSpecsReplyExtensions
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
            this List<AddVmAppConsistentSpecsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AddVmAppConsistentSpecsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AddVmAppConsistentSpecsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
// EnableDisableAppConsistencyReply.cs
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
    #region EnableDisableAppConsistencyReply
    public class EnableDisableAppConsistencyReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? FailedWorkloadIds
        // GraphQL -> failedWorkloadIds: [UUID!]! (scalar)
        [JsonProperty("failedWorkloadIds")]
        public List<System.String>? FailedWorkloadIds { get; set; }

        //      C# -> List<System.String>? SuccessWorkloadIds
        // GraphQL -> successWorkloadIds: [UUID!]! (scalar)
        [JsonProperty("successWorkloadIds")]
        public List<System.String>? SuccessWorkloadIds { get; set; }


        #endregion

    #region methods

    public EnableDisableAppConsistencyReply Set(
        List<System.String>? FailedWorkloadIds = null,
        List<System.String>? SuccessWorkloadIds = null
    ) 
    {
        if ( FailedWorkloadIds != null ) {
            this.FailedWorkloadIds = FailedWorkloadIds;
        }
        if ( SuccessWorkloadIds != null ) {
            this.SuccessWorkloadIds = SuccessWorkloadIds;
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
        //      C# -> List<System.String>? FailedWorkloadIds
        // GraphQL -> failedWorkloadIds: [UUID!]! (scalar)
        if (this.FailedWorkloadIds != null) {
            s += ind + "failedWorkloadIds\n" ;
        }
        //      C# -> List<System.String>? SuccessWorkloadIds
        // GraphQL -> successWorkloadIds: [UUID!]! (scalar)
        if (this.SuccessWorkloadIds != null) {
            s += ind + "successWorkloadIds\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? FailedWorkloadIds
        // GraphQL -> failedWorkloadIds: [UUID!]! (scalar)
        if (this.FailedWorkloadIds == null && Exploration.Includes(parent + ".failedWorkloadIds", true))
        {
            this.FailedWorkloadIds = new List<System.String>();
        }
        //      C# -> List<System.String>? SuccessWorkloadIds
        // GraphQL -> successWorkloadIds: [UUID!]! (scalar)
        if (this.SuccessWorkloadIds == null && Exploration.Includes(parent + ".successWorkloadIds", true))
        {
            this.SuccessWorkloadIds = new List<System.String>();
        }
    }


    #endregion

    } // class EnableDisableAppConsistencyReply
    
    #endregion

    public static class ListEnableDisableAppConsistencyReplyExtensions
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
            this List<EnableDisableAppConsistencyReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<EnableDisableAppConsistencyReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new EnableDisableAppConsistencyReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
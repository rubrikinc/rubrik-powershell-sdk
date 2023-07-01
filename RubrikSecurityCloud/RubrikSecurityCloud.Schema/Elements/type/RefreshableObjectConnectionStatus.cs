// RefreshableObjectConnectionStatus.cs
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
    #region RefreshableObjectConnectionStatus
    public class RefreshableObjectConnectionStatus: BaseType
    {
        #region members

        //      C# -> RefreshableObjectConnectionStatusType? Status
        // GraphQL -> status: RefreshableObjectConnectionStatusType! (enum)
        [JsonProperty("status")]
        public RefreshableObjectConnectionStatusType? Status { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RefreshableObjectConnectionStatus";
    }

    public RefreshableObjectConnectionStatus Set(
        RefreshableObjectConnectionStatusType? Status = null,
        System.String? Message = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Message != null ) {
            this.Message = Message;
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
        //      C# -> RefreshableObjectConnectionStatusType? Status
        // GraphQL -> status: RefreshableObjectConnectionStatusType! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RefreshableObjectConnectionStatusType? Status
        // GraphQL -> status: RefreshableObjectConnectionStatusType! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new RefreshableObjectConnectionStatusType();
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = "FETCH";
        }
    }


    #endregion

    } // class RefreshableObjectConnectionStatus
    
    #endregion

    public static class ListRefreshableObjectConnectionStatusExtensions
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
            this List<RefreshableObjectConnectionStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RefreshableObjectConnectionStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RefreshableObjectConnectionStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
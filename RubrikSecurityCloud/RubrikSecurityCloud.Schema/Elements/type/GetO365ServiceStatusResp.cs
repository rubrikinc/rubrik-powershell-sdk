// GetO365ServiceStatusResp.cs
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
    #region GetO365ServiceStatusResp
    public class GetO365ServiceStatusResp: BaseType
    {
        #region members

        //      C# -> O365ServiceStatusIndication? Status
        // GraphQL -> status: O365ServiceStatusIndication! (enum)
        [JsonProperty("status")]
        public O365ServiceStatusIndication? Status { get; set; }

        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime (scalar)
        [JsonProperty("lastUpdated")]
        public DateTime? LastUpdated { get; set; }


        #endregion

    #region methods

    public GetO365ServiceStatusResp Set(
        O365ServiceStatusIndication? Status = null,
        DateTime? LastUpdated = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( LastUpdated != null ) {
            this.LastUpdated = LastUpdated;
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
        //      C# -> O365ServiceStatusIndication? Status
        // GraphQL -> status: O365ServiceStatusIndication! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime (scalar)
        if (this.LastUpdated != null) {
            s += ind + "lastUpdated\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> O365ServiceStatusIndication? Status
        // GraphQL -> status: O365ServiceStatusIndication! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new O365ServiceStatusIndication();
        }
        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime (scalar)
        if (this.LastUpdated == null && Exploration.Includes(parent + ".lastUpdated", true))
        {
            this.LastUpdated = new DateTime();
        }
    }


    #endregion

    } // class GetO365ServiceStatusResp
    
    #endregion

    public static class ListGetO365ServiceStatusRespExtensions
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
            this List<GetO365ServiceStatusResp> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetO365ServiceStatusResp> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetO365ServiceStatusResp());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
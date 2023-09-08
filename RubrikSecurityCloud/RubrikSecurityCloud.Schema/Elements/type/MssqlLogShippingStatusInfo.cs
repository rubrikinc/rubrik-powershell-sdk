// MssqlLogShippingStatusInfo.cs
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
    #region MssqlLogShippingStatusInfo
    public class MssqlLogShippingStatusInfo: BaseType
    {
        #region members

        //      C# -> MssqlLogShippingStatus? Status
        // GraphQL -> status: MssqlLogShippingStatus! (enum)
        [JsonProperty("status")]
        public MssqlLogShippingStatus? Status { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlLogShippingStatusInfo";
    }

    public MssqlLogShippingStatusInfo Set(
        MssqlLogShippingStatus? Status = null,
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
        //      C# -> MssqlLogShippingStatus? Status
        // GraphQL -> status: MssqlLogShippingStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MssqlLogShippingStatus? Status
        // GraphQL -> status: MssqlLogShippingStatus! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new MssqlLogShippingStatus();
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && ec.Includes("message",true))
        {
            this.Message = "FETCH";
        }
    }


    #endregion

    } // class MssqlLogShippingStatusInfo
    
    #endregion

    public static class ListMssqlLogShippingStatusInfoExtensions
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
            this List<MssqlLogShippingStatusInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlLogShippingStatusInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlLogShippingStatusInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<MssqlLogShippingStatusInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
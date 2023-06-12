// RequestedMatchDetails.cs
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
    #region RequestedMatchDetails
    public class RequestedMatchDetails: BaseType
    {
        #region members

        //      C# -> List<HashType>? RequestedHashTypes
        // GraphQL -> requestedHashTypes: [HashType!] (enum)
        [JsonProperty("requestedHashTypes")]
        public List<HashType>? RequestedHashTypes { get; set; }


        #endregion

    #region methods

    public RequestedMatchDetails Set(
        List<HashType>? RequestedHashTypes = null
    ) 
    {
        if ( RequestedHashTypes != null ) {
            this.RequestedHashTypes = RequestedHashTypes;
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
        //      C# -> List<HashType>? RequestedHashTypes
        // GraphQL -> requestedHashTypes: [HashType!] (enum)
        if (this.RequestedHashTypes != null) {
            s += ind + "requestedHashTypes\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<HashType>? RequestedHashTypes
        // GraphQL -> requestedHashTypes: [HashType!] (enum)
        if (this.RequestedHashTypes == null && Exploration.Includes(parent + ".requestedHashTypes", true))
        {
            this.RequestedHashTypes = new List<HashType>();
        }
    }


    #endregion

    } // class RequestedMatchDetails
    
    #endregion

    public static class ListRequestedMatchDetailsExtensions
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
            this List<RequestedMatchDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RequestedMatchDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RequestedMatchDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
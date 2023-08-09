// VerifySlaWithReplicationToClusterResponse.cs
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
    #region VerifySlaWithReplicationToClusterResponse
    public class VerifySlaWithReplicationToClusterResponse: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsActiveSla
        // GraphQL -> isActiveSla: Boolean! (scalar)
        [JsonProperty("isActiveSla")]
        public System.Boolean? IsActiveSla { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VerifySlaWithReplicationToClusterResponse";
    }

    public VerifySlaWithReplicationToClusterResponse Set(
        System.Boolean? IsActiveSla = null
    ) 
    {
        if ( IsActiveSla != null ) {
            this.IsActiveSla = IsActiveSla;
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
        //      C# -> System.Boolean? IsActiveSla
        // GraphQL -> isActiveSla: Boolean! (scalar)
        if (this.IsActiveSla != null) {
            s += ind + "isActiveSla\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsActiveSla
        // GraphQL -> isActiveSla: Boolean! (scalar)
        if (this.IsActiveSla == null && Exploration.Includes(parent + ".isActiveSla", true))
        {
            this.IsActiveSla = true;
        }
    }


    #endregion

    } // class VerifySlaWithReplicationToClusterResponse
    
    #endregion

    public static class ListVerifySlaWithReplicationToClusterResponseExtensions
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
            this List<VerifySlaWithReplicationToClusterResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VerifySlaWithReplicationToClusterResponse> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VerifySlaWithReplicationToClusterResponse());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
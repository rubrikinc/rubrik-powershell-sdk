// GetAzureHostTypeResp.cs
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
    #region GetAzureHostTypeResp
    public class GetAzureHostTypeResp: BaseType
    {
        #region members

        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        [JsonProperty("hostType")]
        public AzureHostType? HostType { get; set; }


        #endregion

    #region methods

    public GetAzureHostTypeResp Set(
        AzureHostType? HostType = null
    ) 
    {
        if ( HostType != null ) {
            this.HostType = HostType;
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
        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        if (this.HostType != null) {
            s += ind + "hostType\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        if (this.HostType == null && Exploration.Includes(parent + ".hostType", true))
        {
            this.HostType = new AzureHostType();
        }
    }


    #endregion

    } // class GetAzureHostTypeResp
    
    #endregion

    public static class ListGetAzureHostTypeRespExtensions
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
            this List<GetAzureHostTypeResp> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetAzureHostTypeResp> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetAzureHostTypeResp());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
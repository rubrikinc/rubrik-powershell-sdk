// CloudAccountsExocomputeAccountMapping.cs
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
    #region CloudAccountsExocomputeAccountMapping
    public class CloudAccountsExocomputeAccountMapping: BaseType
    {
        #region members

        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: UUID! (scalar)
        [JsonProperty("applicationCloudAccountId")]
        public System.String? ApplicationCloudAccountId { get; set; }

        //      C# -> System.String? ExocomputeCloudAccountId
        // GraphQL -> exocomputeCloudAccountId: UUID! (scalar)
        [JsonProperty("exocomputeCloudAccountId")]
        public System.String? ExocomputeCloudAccountId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudAccountsExocomputeAccountMapping";
    }

    public CloudAccountsExocomputeAccountMapping Set(
        System.String? ApplicationCloudAccountId = null,
        System.String? ExocomputeCloudAccountId = null
    ) 
    {
        if ( ApplicationCloudAccountId != null ) {
            this.ApplicationCloudAccountId = ApplicationCloudAccountId;
        }
        if ( ExocomputeCloudAccountId != null ) {
            this.ExocomputeCloudAccountId = ExocomputeCloudAccountId;
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
        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: UUID! (scalar)
        if (this.ApplicationCloudAccountId != null) {
            s += ind + "applicationCloudAccountId\n" ;
        }
        //      C# -> System.String? ExocomputeCloudAccountId
        // GraphQL -> exocomputeCloudAccountId: UUID! (scalar)
        if (this.ExocomputeCloudAccountId != null) {
            s += ind + "exocomputeCloudAccountId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: UUID! (scalar)
        if (this.ApplicationCloudAccountId == null && Exploration.Includes(parent + ".applicationCloudAccountId", true))
        {
            this.ApplicationCloudAccountId = "FETCH";
        }
        //      C# -> System.String? ExocomputeCloudAccountId
        // GraphQL -> exocomputeCloudAccountId: UUID! (scalar)
        if (this.ExocomputeCloudAccountId == null && Exploration.Includes(parent + ".exocomputeCloudAccountId", true))
        {
            this.ExocomputeCloudAccountId = "FETCH";
        }
    }


    #endregion

    } // class CloudAccountsExocomputeAccountMapping
    
    #endregion

    public static class ListCloudAccountsExocomputeAccountMappingExtensions
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
            this List<CloudAccountsExocomputeAccountMapping> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudAccountsExocomputeAccountMapping> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudAccountsExocomputeAccountMapping());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
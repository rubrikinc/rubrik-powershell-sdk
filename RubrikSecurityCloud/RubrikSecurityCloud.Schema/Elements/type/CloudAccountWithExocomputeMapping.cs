// CloudAccountWithExocomputeMapping.cs
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
    #region CloudAccountWithExocomputeMapping
    public class CloudAccountWithExocomputeMapping: BaseType
    {
        #region members

        //      C# -> CloudAccountDetails? ApplicationAccount
        // GraphQL -> applicationAccount: CloudAccountDetails! (type)
        [JsonProperty("applicationAccount")]
        public CloudAccountDetails? ApplicationAccount { get; set; }

        //      C# -> CloudAccountDetails? ExocomputeAccount
        // GraphQL -> exocomputeAccount: CloudAccountDetails (type)
        [JsonProperty("exocomputeAccount")]
        public CloudAccountDetails? ExocomputeAccount { get; set; }


        #endregion

    #region methods

    public CloudAccountWithExocomputeMapping Set(
        CloudAccountDetails? ApplicationAccount = null,
        CloudAccountDetails? ExocomputeAccount = null
    ) 
    {
        if ( ApplicationAccount != null ) {
            this.ApplicationAccount = ApplicationAccount;
        }
        if ( ExocomputeAccount != null ) {
            this.ExocomputeAccount = ExocomputeAccount;
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
        //      C# -> CloudAccountDetails? ApplicationAccount
        // GraphQL -> applicationAccount: CloudAccountDetails! (type)
        if (this.ApplicationAccount != null) {
            var fspec = this.ApplicationAccount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "applicationAccount {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CloudAccountDetails? ExocomputeAccount
        // GraphQL -> exocomputeAccount: CloudAccountDetails (type)
        if (this.ExocomputeAccount != null) {
            var fspec = this.ExocomputeAccount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "exocomputeAccount {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CloudAccountDetails? ApplicationAccount
        // GraphQL -> applicationAccount: CloudAccountDetails! (type)
        if (this.ApplicationAccount == null && Exploration.Includes(parent + ".applicationAccount"))
        {
            this.ApplicationAccount = new CloudAccountDetails();
            this.ApplicationAccount.ApplyExploratoryFieldSpec(parent + ".applicationAccount");
        }
        //      C# -> CloudAccountDetails? ExocomputeAccount
        // GraphQL -> exocomputeAccount: CloudAccountDetails (type)
        if (this.ExocomputeAccount == null && Exploration.Includes(parent + ".exocomputeAccount"))
        {
            this.ExocomputeAccount = new CloudAccountDetails();
            this.ExocomputeAccount.ApplyExploratoryFieldSpec(parent + ".exocomputeAccount");
        }
    }


    #endregion

    } // class CloudAccountWithExocomputeMapping
    
    #endregion

    public static class ListCloudAccountWithExocomputeMappingExtensions
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
            this List<CloudAccountWithExocomputeMapping> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudAccountWithExocomputeMapping> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudAccountWithExocomputeMapping());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
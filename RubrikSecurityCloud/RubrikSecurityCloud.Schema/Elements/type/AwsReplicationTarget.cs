// AwsReplicationTarget.cs
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
    #region AwsReplicationTarget
    public class AwsReplicationTarget: BaseType
    {
        #region members

        //      C# -> AwsNativeRegionForReplication? Region
        // GraphQL -> region: AwsNativeRegionForReplication! (enum)
        [JsonProperty("region")]
        public AwsNativeRegionForReplication? Region { get; set; }

        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        [JsonProperty("accountId")]
        public System.String? AccountId { get; set; }

        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        [JsonProperty("accountName")]
        public System.String? AccountName { get; set; }


        #endregion

    #region methods

    public AwsReplicationTarget Set(
        AwsNativeRegionForReplication? Region = null,
        System.String? AccountId = null,
        System.String? AccountName = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( AccountId != null ) {
            this.AccountId = AccountId;
        }
        if ( AccountName != null ) {
            this.AccountName = AccountName;
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
        //      C# -> AwsNativeRegionForReplication? Region
        // GraphQL -> region: AwsNativeRegionForReplication! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        if (this.AccountId != null) {
            s += ind + "accountId\n" ;
        }
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (this.AccountName != null) {
            s += ind + "accountName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AwsNativeRegionForReplication? Region
        // GraphQL -> region: AwsNativeRegionForReplication! (enum)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = new AwsNativeRegionForReplication();
        }
        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        if (this.AccountId == null && Exploration.Includes(parent + ".accountId", true))
        {
            this.AccountId = "FETCH";
        }
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (this.AccountName == null && Exploration.Includes(parent + ".accountName", true))
        {
            this.AccountName = "FETCH";
        }
    }


    #endregion

    } // class AwsReplicationTarget
    
    #endregion

    public static class ListAwsReplicationTargetExtensions
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
            this List<AwsReplicationTarget> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsReplicationTarget> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsReplicationTarget());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
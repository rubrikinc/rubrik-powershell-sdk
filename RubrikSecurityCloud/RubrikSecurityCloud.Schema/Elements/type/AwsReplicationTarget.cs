// AwsReplicationTarget.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:12.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region AwsReplicationTarget
    public class AwsReplicationTarget: IFragment
    {
        #region members
        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        [JsonProperty("accountId")]
        public System.String? AccountId { get; set; }

        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        [JsonProperty("accountName")]
        public System.String? AccountName { get; set; }

        //      C# -> AwsNativeRegionForReplication? Region
        // GraphQL -> region: AwsNativeRegionForReplication! (enum)
        [JsonProperty("region")]
        public AwsNativeRegionForReplication? Region { get; set; }

        #endregion

    #region methods

    public AwsReplicationTarget Set(
        System.String? AccountId = null,
        System.String? AccountName = null,
        AwsNativeRegionForReplication? Region = null
    ) 
    {
        if ( AccountId != null ) {
            this.AccountId = AccountId;
        }
        if ( AccountName != null ) {
            this.AccountName = AccountName;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? AccountId
            // GraphQL -> accountId: String! (scalar)
            if (this.AccountId != null)
            {
                 s += ind + "accountId\n";

            }
            //      C# -> System.String? AccountName
            // GraphQL -> accountName: String! (scalar)
            if (this.AccountName != null)
            {
                 s += ind + "accountName\n";

            }
            //      C# -> AwsNativeRegionForReplication? Region
            // GraphQL -> region: AwsNativeRegionForReplication! (enum)
            if (this.Region != null)
            {
                 s += ind + "region\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AccountId
            // GraphQL -> accountId: String! (scalar)
            if (this.AccountId == null && Exploration.Includes(parent + ".accountId$"))
            {
                this.AccountId = new System.String("FETCH");
            }
            //      C# -> System.String? AccountName
            // GraphQL -> accountName: String! (scalar)
            if (this.AccountName == null && Exploration.Includes(parent + ".accountName$"))
            {
                this.AccountName = new System.String("FETCH");
            }
            //      C# -> AwsNativeRegionForReplication? Region
            // GraphQL -> region: AwsNativeRegionForReplication! (enum)
            if (this.Region == null && Exploration.Includes(parent + ".region$"))
            {
                this.Region = new AwsNativeRegionForReplication();
            }
        }


    #endregion

    } // class AwsReplicationTarget
    #endregion

    public static class ListAwsReplicationTargetExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<AwsReplicationTarget> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsReplicationTarget> list, 
            String parent = "")
        {
            var item = new AwsReplicationTarget();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
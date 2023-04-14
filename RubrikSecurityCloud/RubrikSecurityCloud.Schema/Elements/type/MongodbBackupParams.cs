// MongodbBackupParams.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region MongodbBackupParams
    public class MongodbBackupParams: IFragment
    {
        #region members
        //      C# -> System.String? StoreName
        // GraphQL -> storeName: String! (scalar)
        [JsonProperty("storeName")]
        public System.String? StoreName { get; set; }

        //      C# -> System.Int64? WatcherFrequency
        // GraphQL -> watcherFrequency: Long! (scalar)
        [JsonProperty("watcherFrequency")]
        public System.Int64? WatcherFrequency { get; set; }

        #endregion

    #region methods

    public MongodbBackupParams Set(
        System.String? StoreName = null,
        System.Int64? WatcherFrequency = null
    ) 
    {
        if ( StoreName != null ) {
            this.StoreName = StoreName;
        }
        if ( WatcherFrequency != null ) {
            this.WatcherFrequency = WatcherFrequency;
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
            //      C# -> System.String? StoreName
            // GraphQL -> storeName: String! (scalar)
            if (this.StoreName != null)
            {
                 s += ind + "storeName\n";

            }
            //      C# -> System.Int64? WatcherFrequency
            // GraphQL -> watcherFrequency: Long! (scalar)
            if (this.WatcherFrequency != null)
            {
                 s += ind + "watcherFrequency\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? StoreName
            // GraphQL -> storeName: String! (scalar)
            if (this.StoreName == null && Exploration.Includes(parent + ".storeName$"))
            {
                this.StoreName = new System.String("FETCH");
            }
            //      C# -> System.Int64? WatcherFrequency
            // GraphQL -> watcherFrequency: Long! (scalar)
            if (this.WatcherFrequency == null && Exploration.Includes(parent + ".watcherFrequency$"))
            {
                this.WatcherFrequency = new System.Int64();
            }
        }


    #endregion

    } // class MongodbBackupParams
    #endregion

    public static class ListMongodbBackupParamsExtensions
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
            this List<MongodbBackupParams> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MongodbBackupParams> list, 
            String parent = "")
        {
            var item = new MongodbBackupParams();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
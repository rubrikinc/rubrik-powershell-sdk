// MosaicStoreConnectionParameters.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:24.
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
    #region MosaicStoreConnectionParameters
    public class MosaicStoreConnectionParameters: IFragment
    {
        #region members
        //      C# -> System.String? NfsServer
        // GraphQL -> nfsServer: String! (scalar)
        [JsonProperty("nfsServer")]
        public System.String? NfsServer { get; set; }

        //      C# -> System.String? NfsServerMountPath
        // GraphQL -> nfsServerMountPath: String! (scalar)
        [JsonProperty("nfsServerMountPath")]
        public System.String? NfsServerMountPath { get; set; }

        //      C# -> System.String? StoreUrl
        // GraphQL -> storeUrl: String! (scalar)
        [JsonProperty("storeUrl")]
        public System.String? StoreUrl { get; set; }

        #endregion

    #region methods

    public MosaicStoreConnectionParameters Set(
        System.String? NfsServer = null,
        System.String? NfsServerMountPath = null,
        System.String? StoreUrl = null
    ) 
    {
        if ( NfsServer != null ) {
            this.NfsServer = NfsServer;
        }
        if ( NfsServerMountPath != null ) {
            this.NfsServerMountPath = NfsServerMountPath;
        }
        if ( StoreUrl != null ) {
            this.StoreUrl = StoreUrl;
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
            //      C# -> System.String? NfsServer
            // GraphQL -> nfsServer: String! (scalar)
            if (this.NfsServer != null)
            {
                 s += ind + "nfsServer\n";

            }
            //      C# -> System.String? NfsServerMountPath
            // GraphQL -> nfsServerMountPath: String! (scalar)
            if (this.NfsServerMountPath != null)
            {
                 s += ind + "nfsServerMountPath\n";

            }
            //      C# -> System.String? StoreUrl
            // GraphQL -> storeUrl: String! (scalar)
            if (this.StoreUrl != null)
            {
                 s += ind + "storeUrl\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? NfsServer
            // GraphQL -> nfsServer: String! (scalar)
            if (this.NfsServer == null && Exploration.Includes(parent + ".nfsServer$"))
            {
                this.NfsServer = new System.String("FETCH");
            }
            //      C# -> System.String? NfsServerMountPath
            // GraphQL -> nfsServerMountPath: String! (scalar)
            if (this.NfsServerMountPath == null && Exploration.Includes(parent + ".nfsServerMountPath$"))
            {
                this.NfsServerMountPath = new System.String("FETCH");
            }
            //      C# -> System.String? StoreUrl
            // GraphQL -> storeUrl: String! (scalar)
            if (this.StoreUrl == null && Exploration.Includes(parent + ".storeUrl$"))
            {
                this.StoreUrl = new System.String("FETCH");
            }
        }


    #endregion

    } // class MosaicStoreConnectionParameters
    #endregion

    public static class ListMosaicStoreConnectionParametersExtensions
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
            this List<MosaicStoreConnectionParameters> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MosaicStoreConnectionParameters> list, 
            String parent = "")
        {
            var item = new MosaicStoreConnectionParameters();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
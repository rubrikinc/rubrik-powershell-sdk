// RestoreFormConfigurationKmipServer.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:18.
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
    #region RestoreFormConfigurationKmipServer
    public class RestoreFormConfigurationKmipServer: IFragment
    {
        #region members
        //      C# -> System.String? ServerAddress
        // GraphQL -> serverAddress: String! (scalar)
        [JsonProperty("serverAddress")]
        public System.String? ServerAddress { get; set; }

        #endregion

    #region methods

    public RestoreFormConfigurationKmipServer Set(
        System.String? ServerAddress = null
    ) 
    {
        if ( ServerAddress != null ) {
            this.ServerAddress = ServerAddress;
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
            //      C# -> System.String? ServerAddress
            // GraphQL -> serverAddress: String! (scalar)
            if (this.ServerAddress != null)
            {
                 s += ind + "serverAddress\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ServerAddress
            // GraphQL -> serverAddress: String! (scalar)
            if (this.ServerAddress == null && Exploration.Includes(parent + ".serverAddress$"))
            {
                this.ServerAddress = new System.String("FETCH");
            }
        }


    #endregion

    } // class RestoreFormConfigurationKmipServer
    #endregion

    public static class ListRestoreFormConfigurationKmipServerExtensions
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
            this List<RestoreFormConfigurationKmipServer> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RestoreFormConfigurationKmipServer> list, 
            String parent = "")
        {
            var item = new RestoreFormConfigurationKmipServer();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
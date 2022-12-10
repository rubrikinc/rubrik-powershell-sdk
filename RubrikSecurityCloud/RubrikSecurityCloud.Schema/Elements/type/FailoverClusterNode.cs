// FailoverClusterNode.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:24.
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
    #region FailoverClusterNode
    public class FailoverClusterNode: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String (scalar)
        [JsonProperty("operatingSystem")]
        public System.String? OperatingSystem { get; set; }

        //      C# -> FailoverClusterNodeConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: FailoverClusterNodeConnectionStatus! (enum)
        [JsonProperty("connectionStatus")]
        public FailoverClusterNodeConnectionStatus? ConnectionStatus { get; set; }

        #endregion

    #region methods

    public FailoverClusterNode Set(
        System.String? Id = null,
        System.String? Name = null,
        System.String? OperatingSystem = null,
        FailoverClusterNodeConnectionStatus? ConnectionStatus = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OperatingSystem != null ) {
            this.OperatingSystem = OperatingSystem;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? OperatingSystem
            // GraphQL -> operatingSystem: String (scalar)
            if (this.OperatingSystem != null)
            {
                 s += ind + "operatingSystem\n";

            }
            //      C# -> FailoverClusterNodeConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: FailoverClusterNodeConnectionStatus! (enum)
            if (this.ConnectionStatus != null)
            {
                 s += ind + "connectionStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? OperatingSystem
            // GraphQL -> operatingSystem: String (scalar)
            if (this.OperatingSystem == null && Exploration.Includes(parent + ".operatingSystem$"))
            {
                this.OperatingSystem = new System.String("FETCH");
            }
            //      C# -> FailoverClusterNodeConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: FailoverClusterNodeConnectionStatus! (enum)
            if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus$"))
            {
                this.ConnectionStatus = new FailoverClusterNodeConnectionStatus();
            }
        }


    #endregion

    } // class FailoverClusterNode
    #endregion

    public static class ListFailoverClusterNodeExtensions
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
            this List<FailoverClusterNode> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FailoverClusterNode> list, 
            String parent = "")
        {
            var item = new FailoverClusterNode();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
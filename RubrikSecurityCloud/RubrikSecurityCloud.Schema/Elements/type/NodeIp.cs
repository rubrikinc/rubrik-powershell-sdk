// NodeIp.cs
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
    #region NodeIp
    public class NodeIp: IFragment
    {
        #region members
        //      C# -> System.String? Ip
        // GraphQL -> ip: String! (scalar)
        [JsonProperty("ip")]
        public System.String? Ip { get; set; }

        //      C# -> System.String? Node
        // GraphQL -> node: String! (scalar)
        [JsonProperty("node")]
        public System.String? Node { get; set; }

        #endregion

    #region methods

    public NodeIp Set(
        System.String? Ip = null,
        System.String? Node = null
    ) 
    {
        if ( Ip != null ) {
            this.Ip = Ip;
        }
        if ( Node != null ) {
            this.Node = Node;
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
            //      C# -> System.String? Ip
            // GraphQL -> ip: String! (scalar)
            if (this.Ip != null)
            {
                 s += ind + "ip\n";

            }
            //      C# -> System.String? Node
            // GraphQL -> node: String! (scalar)
            if (this.Node != null)
            {
                 s += ind + "node\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Ip
            // GraphQL -> ip: String! (scalar)
            if (this.Ip == null && Exploration.Includes(parent + ".ip$"))
            {
                this.Ip = new System.String("FETCH");
            }
            //      C# -> System.String? Node
            // GraphQL -> node: String! (scalar)
            if (this.Node == null && Exploration.Includes(parent + ".node$"))
            {
                this.Node = new System.String("FETCH");
            }
        }


    #endregion

    } // class NodeIp
    #endregion

    public static class ListNodeIpExtensions
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
            this List<NodeIp> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NodeIp> list, 
            String parent = "")
        {
            var item = new NodeIp();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
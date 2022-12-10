// ManagedVolumeMountSpec.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:42.
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
    #region ManagedVolumeMountSpec
    public class ManagedVolumeMountSpec: IFragment
    {
        #region members
        //      C# -> System.Int64? ImageSizeOpt
        // GraphQL -> imageSizeOpt: Long (scalar)
        [JsonProperty("imageSizeOpt")]
        public System.Int64? ImageSizeOpt { get; set; }

        //      C# -> System.String? MountDir
        // GraphQL -> mountDir: String! (scalar)
        [JsonProperty("mountDir")]
        public System.String? MountDir { get; set; }

        //      C# -> ClusterNode? Node
        // GraphQL -> node: ClusterNode (type)
        [JsonProperty("node")]
        public ClusterNode? Node { get; set; }

        #endregion

    #region methods

    public ManagedVolumeMountSpec Set(
        System.Int64? ImageSizeOpt = null,
        System.String? MountDir = null,
        ClusterNode? Node = null
    ) 
    {
        if ( ImageSizeOpt != null ) {
            this.ImageSizeOpt = ImageSizeOpt;
        }
        if ( MountDir != null ) {
            this.MountDir = MountDir;
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
            //      C# -> System.Int64? ImageSizeOpt
            // GraphQL -> imageSizeOpt: Long (scalar)
            if (this.ImageSizeOpt != null)
            {
                 s += ind + "imageSizeOpt\n";

            }
            //      C# -> System.String? MountDir
            // GraphQL -> mountDir: String! (scalar)
            if (this.MountDir != null)
            {
                 s += ind + "mountDir\n";

            }
            //      C# -> ClusterNode? Node
            // GraphQL -> node: ClusterNode (type)
            if (this.Node != null)
            {
                 s += ind + "node\n";

                 s += ind + "{\n" + 
                 this.Node.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? ImageSizeOpt
            // GraphQL -> imageSizeOpt: Long (scalar)
            if (this.ImageSizeOpt == null && Exploration.Includes(parent + ".imageSizeOpt$"))
            {
                this.ImageSizeOpt = new System.Int64();
            }
            //      C# -> System.String? MountDir
            // GraphQL -> mountDir: String! (scalar)
            if (this.MountDir == null && Exploration.Includes(parent + ".mountDir$"))
            {
                this.MountDir = new System.String("FETCH");
            }
            //      C# -> ClusterNode? Node
            // GraphQL -> node: ClusterNode (type)
            if (this.Node == null && Exploration.Includes(parent + ".node"))
            {
                this.Node = new ClusterNode();
                this.Node.ApplyExploratoryFragment(parent + ".node");
            }
        }


    #endregion

    } // class ManagedVolumeMountSpec
    #endregion

    public static class ListManagedVolumeMountSpecExtensions
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
            this List<ManagedVolumeMountSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumeMountSpec> list, 
            String parent = "")
        {
            var item = new ManagedVolumeMountSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
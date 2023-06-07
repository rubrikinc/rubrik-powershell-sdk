// ManagedVolumeMountSpec.cs
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
    #region ManagedVolumeMountSpec
    public class ManagedVolumeMountSpec: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? ImageSizeOpt
        // GraphQL -> imageSizeOpt: Long (scalar)
        if (this.ImageSizeOpt != null) {
            s += ind + "imageSizeOpt\n" ;
        }
        //      C# -> System.String? MountDir
        // GraphQL -> mountDir: String! (scalar)
        if (this.MountDir != null) {
            s += ind + "mountDir\n" ;
        }
        //      C# -> ClusterNode? Node
        // GraphQL -> node: ClusterNode (type)
        if (this.Node != null) {
            s += ind + "node {\n" + this.Node.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? ImageSizeOpt
        // GraphQL -> imageSizeOpt: Long (scalar)
        if (this.ImageSizeOpt == null && Exploration.Includes(parent + ".imageSizeOpt", true))
        {
            this.ImageSizeOpt = new System.Int64();
        }
        //      C# -> System.String? MountDir
        // GraphQL -> mountDir: String! (scalar)
        if (this.MountDir == null && Exploration.Includes(parent + ".mountDir", true))
        {
            this.MountDir = "FETCH";
        }
        //      C# -> ClusterNode? Node
        // GraphQL -> node: ClusterNode (type)
        if (this.Node == null && Exploration.Includes(parent + ".node"))
        {
            this.Node = new ClusterNode();
            this.Node.ApplyExploratoryFieldSpec(parent + ".node");
        }
    }


    #endregion

    } // class ManagedVolumeMountSpec
    
    #endregion

    public static class ListManagedVolumeMountSpecExtensions
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
            this List<ManagedVolumeMountSpec> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeMountSpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeMountSpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
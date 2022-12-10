// AwsCdmVersion.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:11.
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
    #region AwsCdmVersion
    public class AwsCdmVersion: IFragment
    {
        #region members
        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        [JsonProperty("imageId")]
        public System.String? ImageId { get; set; }

        //      C# -> System.Boolean? IsLatest
        // GraphQL -> isLatest: Boolean! (scalar)
        [JsonProperty("isLatest")]
        public System.Boolean? IsLatest { get; set; }

        //      C# -> List<System.String>? ProductCodes
        // GraphQL -> productCodes: [String!]! (scalar)
        [JsonProperty("productCodes")]
        public List<System.String>? ProductCodes { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> List<AwsCdmVersionTag>? Tags
        // GraphQL -> tags: [AwsCdmVersionTag!]! (type)
        [JsonProperty("tags")]
        public List<AwsCdmVersionTag>? Tags { get; set; }

        #endregion

    #region methods

    public AwsCdmVersion Set(
        System.String? ImageId = null,
        System.Boolean? IsLatest = null,
        List<System.String>? ProductCodes = null,
        System.String? Version = null,
        List<AwsCdmVersionTag>? Tags = null
    ) 
    {
        if ( ImageId != null ) {
            this.ImageId = ImageId;
        }
        if ( IsLatest != null ) {
            this.IsLatest = IsLatest;
        }
        if ( ProductCodes != null ) {
            this.ProductCodes = ProductCodes;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( Tags != null ) {
            this.Tags = Tags;
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
            //      C# -> System.String? ImageId
            // GraphQL -> imageId: String! (scalar)
            if (this.ImageId != null)
            {
                 s += ind + "imageId\n";

            }
            //      C# -> System.Boolean? IsLatest
            // GraphQL -> isLatest: Boolean! (scalar)
            if (this.IsLatest != null)
            {
                 s += ind + "isLatest\n";

            }
            //      C# -> List<System.String>? ProductCodes
            // GraphQL -> productCodes: [String!]! (scalar)
            if (this.ProductCodes != null)
            {
                 s += ind + "productCodes\n";

            }
            //      C# -> System.String? Version
            // GraphQL -> version: String! (scalar)
            if (this.Version != null)
            {
                 s += ind + "version\n";

            }
            //      C# -> List<AwsCdmVersionTag>? Tags
            // GraphQL -> tags: [AwsCdmVersionTag!]! (type)
            if (this.Tags != null)
            {
                 s += ind + "tags\n";

                 s += ind + "{\n" + 
                 this.Tags.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ImageId
            // GraphQL -> imageId: String! (scalar)
            if (this.ImageId == null && Exploration.Includes(parent + ".imageId$"))
            {
                this.ImageId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsLatest
            // GraphQL -> isLatest: Boolean! (scalar)
            if (this.IsLatest == null && Exploration.Includes(parent + ".isLatest$"))
            {
                this.IsLatest = new System.Boolean();
            }
            //      C# -> List<System.String>? ProductCodes
            // GraphQL -> productCodes: [String!]! (scalar)
            if (this.ProductCodes == null && Exploration.Includes(parent + ".productCodes$"))
            {
                this.ProductCodes = new List<System.String>();
            }
            //      C# -> System.String? Version
            // GraphQL -> version: String! (scalar)
            if (this.Version == null && Exploration.Includes(parent + ".version$"))
            {
                this.Version = new System.String("FETCH");
            }
            //      C# -> List<AwsCdmVersionTag>? Tags
            // GraphQL -> tags: [AwsCdmVersionTag!]! (type)
            if (this.Tags == null && Exploration.Includes(parent + ".tags"))
            {
                this.Tags = new List<AwsCdmVersionTag>();
                this.Tags.ApplyExploratoryFragment(parent + ".tags");
            }
        }


    #endregion

    } // class AwsCdmVersion
    #endregion

    public static class ListAwsCdmVersionExtensions
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
            this List<AwsCdmVersion> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsCdmVersion> list, 
            String parent = "")
        {
            var item = new AwsCdmVersion();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
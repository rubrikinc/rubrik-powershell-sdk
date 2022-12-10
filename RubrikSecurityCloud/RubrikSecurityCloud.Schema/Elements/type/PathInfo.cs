// PathInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:40.
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
    #region PathInfo
    public class PathInfo: IFragment
    {
        #region members
        //      C# -> System.String? AclDetails
        // GraphQL -> aclDetails: String (scalar)
        [JsonProperty("aclDetails")]
        public System.String? AclDetails { get; set; }

        //      C# -> DateTime? CreationTime
        // GraphQL -> creationTime: DateTime (scalar)
        [JsonProperty("creationTime")]
        public DateTime? CreationTime { get; set; }

        //      C# -> DateTime? ModificationTime
        // GraphQL -> modificationTime: DateTime (scalar)
        [JsonProperty("modificationTime")]
        public DateTime? ModificationTime { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> List<HashDetail>? RequestedHashDetails
        // GraphQL -> requestedHashDetails: [HashDetail!]! (type)
        [JsonProperty("requestedHashDetails")]
        public List<HashDetail>? RequestedHashDetails { get; set; }

        //      C# -> List<YaraMatchDetail>? YaraMatchDetails
        // GraphQL -> yaraMatchDetails: [YARAMatchDetail!]! (type)
        [JsonProperty("yaraMatchDetails")]
        public List<YaraMatchDetail>? YaraMatchDetails { get; set; }

        #endregion

    #region methods

    public PathInfo Set(
        System.String? AclDetails = null,
        DateTime? CreationTime = null,
        DateTime? ModificationTime = null,
        System.String? Path = null,
        List<HashDetail>? RequestedHashDetails = null,
        List<YaraMatchDetail>? YaraMatchDetails = null
    ) 
    {
        if ( AclDetails != null ) {
            this.AclDetails = AclDetails;
        }
        if ( CreationTime != null ) {
            this.CreationTime = CreationTime;
        }
        if ( ModificationTime != null ) {
            this.ModificationTime = ModificationTime;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( RequestedHashDetails != null ) {
            this.RequestedHashDetails = RequestedHashDetails;
        }
        if ( YaraMatchDetails != null ) {
            this.YaraMatchDetails = YaraMatchDetails;
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
            //      C# -> System.String? AclDetails
            // GraphQL -> aclDetails: String (scalar)
            if (this.AclDetails != null)
            {
                 s += ind + "aclDetails\n";

            }
            //      C# -> DateTime? CreationTime
            // GraphQL -> creationTime: DateTime (scalar)
            if (this.CreationTime != null)
            {
                 s += ind + "creationTime\n";

            }
            //      C# -> DateTime? ModificationTime
            // GraphQL -> modificationTime: DateTime (scalar)
            if (this.ModificationTime != null)
            {
                 s += ind + "modificationTime\n";

            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path != null)
            {
                 s += ind + "path\n";

            }
            //      C# -> List<HashDetail>? RequestedHashDetails
            // GraphQL -> requestedHashDetails: [HashDetail!]! (type)
            if (this.RequestedHashDetails != null)
            {
                 s += ind + "requestedHashDetails\n";

                 s += ind + "{\n" + 
                 this.RequestedHashDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<YaraMatchDetail>? YaraMatchDetails
            // GraphQL -> yaraMatchDetails: [YARAMatchDetail!]! (type)
            if (this.YaraMatchDetails != null)
            {
                 s += ind + "yaraMatchDetails\n";

                 s += ind + "{\n" + 
                 this.YaraMatchDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AclDetails
            // GraphQL -> aclDetails: String (scalar)
            if (this.AclDetails == null && Exploration.Includes(parent + ".aclDetails$"))
            {
                this.AclDetails = new System.String("FETCH");
            }
            //      C# -> DateTime? CreationTime
            // GraphQL -> creationTime: DateTime (scalar)
            if (this.CreationTime == null && Exploration.Includes(parent + ".creationTime$"))
            {
                this.CreationTime = new DateTime();
            }
            //      C# -> DateTime? ModificationTime
            // GraphQL -> modificationTime: DateTime (scalar)
            if (this.ModificationTime == null && Exploration.Includes(parent + ".modificationTime$"))
            {
                this.ModificationTime = new DateTime();
            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path == null && Exploration.Includes(parent + ".path$"))
            {
                this.Path = new System.String("FETCH");
            }
            //      C# -> List<HashDetail>? RequestedHashDetails
            // GraphQL -> requestedHashDetails: [HashDetail!]! (type)
            if (this.RequestedHashDetails == null && Exploration.Includes(parent + ".requestedHashDetails"))
            {
                this.RequestedHashDetails = new List<HashDetail>();
                this.RequestedHashDetails.ApplyExploratoryFragment(parent + ".requestedHashDetails");
            }
            //      C# -> List<YaraMatchDetail>? YaraMatchDetails
            // GraphQL -> yaraMatchDetails: [YARAMatchDetail!]! (type)
            if (this.YaraMatchDetails == null && Exploration.Includes(parent + ".yaraMatchDetails"))
            {
                this.YaraMatchDetails = new List<YaraMatchDetail>();
                this.YaraMatchDetails.ApplyExploratoryFragment(parent + ".yaraMatchDetails");
            }
        }


    #endregion

    } // class PathInfo
    #endregion

    public static class ListPathInfoExtensions
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
            this List<PathInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PathInfo> list, 
            String parent = "")
        {
            var item = new PathInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
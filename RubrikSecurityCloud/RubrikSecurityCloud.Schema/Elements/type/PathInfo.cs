// PathInfo.cs
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
    #region PathInfo
    public class PathInfo: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? AclDetails
        // GraphQL -> aclDetails: String (scalar)
        if (this.AclDetails != null) {
            s += ind + "aclDetails\n" ;
        }
        //      C# -> DateTime? CreationTime
        // GraphQL -> creationTime: DateTime (scalar)
        if (this.CreationTime != null) {
            s += ind + "creationTime\n" ;
        }
        //      C# -> DateTime? ModificationTime
        // GraphQL -> modificationTime: DateTime (scalar)
        if (this.ModificationTime != null) {
            s += ind + "modificationTime\n" ;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            s += ind + "path\n" ;
        }
        //      C# -> List<HashDetail>? RequestedHashDetails
        // GraphQL -> requestedHashDetails: [HashDetail!]! (type)
        if (this.RequestedHashDetails != null) {
            s += ind + "requestedHashDetails {\n" + this.RequestedHashDetails.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<YaraMatchDetail>? YaraMatchDetails
        // GraphQL -> yaraMatchDetails: [YARAMatchDetail!]! (type)
        if (this.YaraMatchDetails != null) {
            s += ind + "yaraMatchDetails {\n" + this.YaraMatchDetails.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AclDetails
        // GraphQL -> aclDetails: String (scalar)
        if (this.AclDetails == null && Exploration.Includes(parent + ".aclDetails", true))
        {
            this.AclDetails = new System.String("FETCH");
        }
        //      C# -> DateTime? CreationTime
        // GraphQL -> creationTime: DateTime (scalar)
        if (this.CreationTime == null && Exploration.Includes(parent + ".creationTime", true))
        {
            this.CreationTime = new DateTime();
        }
        //      C# -> DateTime? ModificationTime
        // GraphQL -> modificationTime: DateTime (scalar)
        if (this.ModificationTime == null && Exploration.Includes(parent + ".modificationTime", true))
        {
            this.ModificationTime = new DateTime();
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path == null && Exploration.Includes(parent + ".path", true))
        {
            this.Path = new System.String("FETCH");
        }
        //      C# -> List<HashDetail>? RequestedHashDetails
        // GraphQL -> requestedHashDetails: [HashDetail!]! (type)
        if (this.RequestedHashDetails == null && Exploration.Includes(parent + ".requestedHashDetails"))
        {
            this.RequestedHashDetails = new List<HashDetail>();
            this.RequestedHashDetails.ApplyExploratoryFieldSpec(parent + ".requestedHashDetails");
        }
        //      C# -> List<YaraMatchDetail>? YaraMatchDetails
        // GraphQL -> yaraMatchDetails: [YARAMatchDetail!]! (type)
        if (this.YaraMatchDetails == null && Exploration.Includes(parent + ".yaraMatchDetails"))
        {
            this.YaraMatchDetails = new List<YaraMatchDetail>();
            this.YaraMatchDetails.ApplyExploratoryFieldSpec(parent + ".yaraMatchDetails");
        }
    }


    #endregion

    } // class PathInfo
    
    #endregion

    public static class ListPathInfoExtensions
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
            this List<PathInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PathInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PathInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
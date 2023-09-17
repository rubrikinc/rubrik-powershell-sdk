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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "PathInfo";
    }

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
            var fspec = this.RequestedHashDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "requestedHashDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<YaraMatchDetail>? YaraMatchDetails
        // GraphQL -> yaraMatchDetails: [YARAMatchDetail!]! (type)
        if (this.YaraMatchDetails != null) {
            var fspec = this.YaraMatchDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "yaraMatchDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AclDetails
        // GraphQL -> aclDetails: String (scalar)
        if (this.AclDetails == null && ec.Includes("aclDetails",true))
        {
            this.AclDetails = "FETCH";
        }
        //      C# -> DateTime? CreationTime
        // GraphQL -> creationTime: DateTime (scalar)
        if (this.CreationTime == null && ec.Includes("creationTime",true))
        {
            this.CreationTime = new DateTime();
        }
        //      C# -> DateTime? ModificationTime
        // GraphQL -> modificationTime: DateTime (scalar)
        if (this.ModificationTime == null && ec.Includes("modificationTime",true))
        {
            this.ModificationTime = new DateTime();
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path == null && ec.Includes("path",true))
        {
            this.Path = "FETCH";
        }
        //      C# -> List<HashDetail>? RequestedHashDetails
        // GraphQL -> requestedHashDetails: [HashDetail!]! (type)
        if (this.RequestedHashDetails == null && ec.Includes("requestedHashDetails",false))
        {
            this.RequestedHashDetails = new List<HashDetail>();
            this.RequestedHashDetails.ApplyExploratoryFieldSpec(ec.NewChild("requestedHashDetails"));
        }
        //      C# -> List<YaraMatchDetail>? YaraMatchDetails
        // GraphQL -> yaraMatchDetails: [YARAMatchDetail!]! (type)
        if (this.YaraMatchDetails == null && ec.Includes("yaraMatchDetails",false))
        {
            this.YaraMatchDetails = new List<YaraMatchDetail>();
            this.YaraMatchDetails.ApplyExploratoryFieldSpec(ec.NewChild("yaraMatchDetails"));
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PathInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PathInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PathInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
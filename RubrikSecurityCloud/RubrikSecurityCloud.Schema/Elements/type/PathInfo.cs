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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? AclDetails
        // GraphQL -> aclDetails: String (scalar)
        if (this.AclDetails != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aclDetails\n" ;
            } else {
                s += ind + "aclDetails\n" ;
            }
        }
        //      C# -> DateTime? CreationTime
        // GraphQL -> creationTime: DateTime (scalar)
        if (this.CreationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "creationTime\n" ;
            } else {
                s += ind + "creationTime\n" ;
            }
        }
        //      C# -> DateTime? ModificationTime
        // GraphQL -> modificationTime: DateTime (scalar)
        if (this.ModificationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "modificationTime\n" ;
            } else {
                s += ind + "modificationTime\n" ;
            }
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            if (conf.Flat) {
                s += conf.Prefix + "path\n" ;
            } else {
                s += ind + "path\n" ;
            }
        }
        //      C# -> List<HashDetail>? RequestedHashDetails
        // GraphQL -> requestedHashDetails: [HashDetail!]! (type)
        if (this.RequestedHashDetails != null) {
            var fspec = this.RequestedHashDetails.AsFieldSpec(conf.Child("requestedHashDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "requestedHashDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<YaraMatchDetail>? YaraMatchDetails
        // GraphQL -> yaraMatchDetails: [YARAMatchDetail!]! (type)
        if (this.YaraMatchDetails != null) {
            var fspec = this.YaraMatchDetails.AsFieldSpec(conf.Child("yaraMatchDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "yaraMatchDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AclDetails
        // GraphQL -> aclDetails: String (scalar)
        if (ec.Includes("aclDetails",true))
        {
            if(this.AclDetails == null) {

                this.AclDetails = "FETCH";

            } else {


            }
        }
        else if (this.AclDetails != null && ec.Excludes("aclDetails",true))
        {
            this.AclDetails = null;
        }
        //      C# -> DateTime? CreationTime
        // GraphQL -> creationTime: DateTime (scalar)
        if (ec.Includes("creationTime",true))
        {
            if(this.CreationTime == null) {

                this.CreationTime = new DateTime();

            } else {


            }
        }
        else if (this.CreationTime != null && ec.Excludes("creationTime",true))
        {
            this.CreationTime = null;
        }
        //      C# -> DateTime? ModificationTime
        // GraphQL -> modificationTime: DateTime (scalar)
        if (ec.Includes("modificationTime",true))
        {
            if(this.ModificationTime == null) {

                this.ModificationTime = new DateTime();

            } else {


            }
        }
        else if (this.ModificationTime != null && ec.Excludes("modificationTime",true))
        {
            this.ModificationTime = null;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (ec.Includes("path",true))
        {
            if(this.Path == null) {

                this.Path = "FETCH";

            } else {


            }
        }
        else if (this.Path != null && ec.Excludes("path",true))
        {
            this.Path = null;
        }
        //      C# -> List<HashDetail>? RequestedHashDetails
        // GraphQL -> requestedHashDetails: [HashDetail!]! (type)
        if (ec.Includes("requestedHashDetails",false))
        {
            if(this.RequestedHashDetails == null) {

                this.RequestedHashDetails = new List<HashDetail>();
                this.RequestedHashDetails.ApplyExploratoryFieldSpec(ec.NewChild("requestedHashDetails"));

            } else {

                this.RequestedHashDetails.ApplyExploratoryFieldSpec(ec.NewChild("requestedHashDetails"));

            }
        }
        else if (this.RequestedHashDetails != null && ec.Excludes("requestedHashDetails",false))
        {
            this.RequestedHashDetails = null;
        }
        //      C# -> List<YaraMatchDetail>? YaraMatchDetails
        // GraphQL -> yaraMatchDetails: [YARAMatchDetail!]! (type)
        if (ec.Includes("yaraMatchDetails",false))
        {
            if(this.YaraMatchDetails == null) {

                this.YaraMatchDetails = new List<YaraMatchDetail>();
                this.YaraMatchDetails.ApplyExploratoryFieldSpec(ec.NewChild("yaraMatchDetails"));

            } else {

                this.YaraMatchDetails.ApplyExploratoryFieldSpec(ec.NewChild("yaraMatchDetails"));

            }
        }
        else if (this.YaraMatchDetails != null && ec.Excludes("yaraMatchDetails",false))
        {
            this.YaraMatchDetails = null;
        }
    }


    #endregion

    } // class PathInfo
    
    #endregion

    public static class ListPathInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<PathInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PathInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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
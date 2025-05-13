// FileMatchWithMatchedSnapshots.cs
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
    #region FileMatchWithMatchedSnapshots
    public class FileMatchWithMatchedSnapshots: BaseType
    {
        #region members

        //      C# -> System.String? Filepath
        // GraphQL -> filepath: String! (scalar)
        [JsonProperty("filepath")]
        public System.String? Filepath { get; set; }

        //      C# -> System.Int64? MatchId
        // GraphQL -> matchId: Long! (scalar)
        [JsonProperty("matchId")]
        public System.Int64? MatchId { get; set; }

        //      C# -> List<MatchedSnapshotInfo>? MatchedSnapshots
        // GraphQL -> matchedSnapshots: [MatchedSnapshotInfo!]! (type)
        [JsonProperty("matchedSnapshots")]
        public List<MatchedSnapshotInfo>? MatchedSnapshots { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FileMatchWithMatchedSnapshots";
    }

    public FileMatchWithMatchedSnapshots Set(
        System.String? Filepath = null,
        System.Int64? MatchId = null,
        List<MatchedSnapshotInfo>? MatchedSnapshots = null
    ) 
    {
        if ( Filepath != null ) {
            this.Filepath = Filepath;
        }
        if ( MatchId != null ) {
            this.MatchId = MatchId;
        }
        if ( MatchedSnapshots != null ) {
            this.MatchedSnapshots = MatchedSnapshots;
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
        //      C# -> System.String? Filepath
        // GraphQL -> filepath: String! (scalar)
        if (this.Filepath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filepath\n" ;
            } else {
                s += ind + "filepath\n" ;
            }
        }
        //      C# -> System.Int64? MatchId
        // GraphQL -> matchId: Long! (scalar)
        if (this.MatchId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchId\n" ;
            } else {
                s += ind + "matchId\n" ;
            }
        }
        //      C# -> List<MatchedSnapshotInfo>? MatchedSnapshots
        // GraphQL -> matchedSnapshots: [MatchedSnapshotInfo!]! (type)
        if (this.MatchedSnapshots != null) {
            var fspec = this.MatchedSnapshots.AsFieldSpec(conf.Child("matchedSnapshots"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "matchedSnapshots" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Filepath
        // GraphQL -> filepath: String! (scalar)
        if (ec.Includes("filepath",true))
        {
            if(this.Filepath == null) {

                this.Filepath = "FETCH";

            } else {


            }
        }
        else if (this.Filepath != null && ec.Excludes("filepath",true))
        {
            this.Filepath = null;
        }
        //      C# -> System.Int64? MatchId
        // GraphQL -> matchId: Long! (scalar)
        if (ec.Includes("matchId",true))
        {
            if(this.MatchId == null) {

                this.MatchId = new System.Int64();

            } else {


            }
        }
        else if (this.MatchId != null && ec.Excludes("matchId",true))
        {
            this.MatchId = null;
        }
        //      C# -> List<MatchedSnapshotInfo>? MatchedSnapshots
        // GraphQL -> matchedSnapshots: [MatchedSnapshotInfo!]! (type)
        if (ec.Includes("matchedSnapshots",false))
        {
            if(this.MatchedSnapshots == null) {

                this.MatchedSnapshots = new List<MatchedSnapshotInfo>();
                this.MatchedSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("matchedSnapshots"));

            } else {

                this.MatchedSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("matchedSnapshots"));

            }
        }
        else if (this.MatchedSnapshots != null && ec.Excludes("matchedSnapshots",false))
        {
            this.MatchedSnapshots = null;
        }
    }


    #endregion

    } // class FileMatchWithMatchedSnapshots
    
    #endregion

    public static class ListFileMatchWithMatchedSnapshotsExtensions
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
            this List<FileMatchWithMatchedSnapshots> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FileMatchWithMatchedSnapshots> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FileMatchWithMatchedSnapshots> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FileMatchWithMatchedSnapshots());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FileMatchWithMatchedSnapshots> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// NcdObjectProtectionStatus.cs
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
    #region NcdObjectProtectionStatus
    public class NcdObjectProtectionStatus: BaseType
    {
        #region members

        //      C# -> System.Int64? AverageFileSize
        // GraphQL -> averageFileSize: Long! (scalar)
        [JsonProperty("averageFileSize")]
        public System.Int64? AverageFileSize { get; set; }

        //      C# -> System.Int64? Throughput
        // GraphQL -> throughput: Long! (scalar)
        [JsonProperty("throughput")]
        public System.Int64? Throughput { get; set; }

        //      C# -> NcdFilesObjectProtectionStatusData? Files
        // GraphQL -> files: NcdFilesObjectProtectionStatusData (type)
        [JsonProperty("files")]
        public NcdFilesObjectProtectionStatusData? Files { get; set; }

        //      C# -> NcdSharesObjectProtectionStatusData? Shares
        // GraphQL -> shares: NcdSharesObjectProtectionStatusData (type)
        [JsonProperty("shares")]
        public NcdSharesObjectProtectionStatusData? Shares { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NcdObjectProtectionStatus";
    }

    public NcdObjectProtectionStatus Set(
        System.Int64? AverageFileSize = null,
        System.Int64? Throughput = null,
        NcdFilesObjectProtectionStatusData? Files = null,
        NcdSharesObjectProtectionStatusData? Shares = null
    ) 
    {
        if ( AverageFileSize != null ) {
            this.AverageFileSize = AverageFileSize;
        }
        if ( Throughput != null ) {
            this.Throughput = Throughput;
        }
        if ( Files != null ) {
            this.Files = Files;
        }
        if ( Shares != null ) {
            this.Shares = Shares;
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
        //      C# -> System.Int64? AverageFileSize
        // GraphQL -> averageFileSize: Long! (scalar)
        if (this.AverageFileSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "averageFileSize\n" ;
            } else {
                s += ind + "averageFileSize\n" ;
            }
        }
        //      C# -> System.Int64? Throughput
        // GraphQL -> throughput: Long! (scalar)
        if (this.Throughput != null) {
            if (conf.Flat) {
                s += conf.Prefix + "throughput\n" ;
            } else {
                s += ind + "throughput\n" ;
            }
        }
        //      C# -> NcdFilesObjectProtectionStatusData? Files
        // GraphQL -> files: NcdFilesObjectProtectionStatusData (type)
        if (this.Files != null) {
            var fspec = this.Files.AsFieldSpec(conf.Child("files"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "files" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NcdSharesObjectProtectionStatusData? Shares
        // GraphQL -> shares: NcdSharesObjectProtectionStatusData (type)
        if (this.Shares != null) {
            var fspec = this.Shares.AsFieldSpec(conf.Child("shares"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "shares" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? AverageFileSize
        // GraphQL -> averageFileSize: Long! (scalar)
        if (ec.Includes("averageFileSize",true))
        {
            if(this.AverageFileSize == null) {

                this.AverageFileSize = new System.Int64();

            } else {


            }
        }
        else if (this.AverageFileSize != null && ec.Excludes("averageFileSize",true))
        {
            this.AverageFileSize = null;
        }
        //      C# -> System.Int64? Throughput
        // GraphQL -> throughput: Long! (scalar)
        if (ec.Includes("throughput",true))
        {
            if(this.Throughput == null) {

                this.Throughput = new System.Int64();

            } else {


            }
        }
        else if (this.Throughput != null && ec.Excludes("throughput",true))
        {
            this.Throughput = null;
        }
        //      C# -> NcdFilesObjectProtectionStatusData? Files
        // GraphQL -> files: NcdFilesObjectProtectionStatusData (type)
        if (ec.Includes("files",false))
        {
            if(this.Files == null) {

                this.Files = new NcdFilesObjectProtectionStatusData();
                this.Files.ApplyExploratoryFieldSpec(ec.NewChild("files"));

            } else {

                this.Files.ApplyExploratoryFieldSpec(ec.NewChild("files"));

            }
        }
        else if (this.Files != null && ec.Excludes("files",false))
        {
            this.Files = null;
        }
        //      C# -> NcdSharesObjectProtectionStatusData? Shares
        // GraphQL -> shares: NcdSharesObjectProtectionStatusData (type)
        if (ec.Includes("shares",false))
        {
            if(this.Shares == null) {

                this.Shares = new NcdSharesObjectProtectionStatusData();
                this.Shares.ApplyExploratoryFieldSpec(ec.NewChild("shares"));

            } else {

                this.Shares.ApplyExploratoryFieldSpec(ec.NewChild("shares"));

            }
        }
        else if (this.Shares != null && ec.Excludes("shares",false))
        {
            this.Shares = null;
        }
    }


    #endregion

    } // class NcdObjectProtectionStatus
    
    #endregion

    public static class ListNcdObjectProtectionStatusExtensions
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
            this List<NcdObjectProtectionStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NcdObjectProtectionStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NcdObjectProtectionStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NcdObjectProtectionStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NcdObjectProtectionStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
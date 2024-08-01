// ArchivalLocationEncryptionJobsSummary.cs
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
    #region ArchivalLocationEncryptionJobsSummary
    public class ArchivalLocationEncryptionJobsSummary: BaseType
    {
        #region members

        //      C# -> System.Int32? AutomaticRotationFrequency
        // GraphQL -> automaticRotationFrequency: Int! (scalar)
        [JsonProperty("automaticRotationFrequency")]
        public System.Int32? AutomaticRotationFrequency { get; set; }

        //      C# -> ArchivalLocationEncryptionJobInfo? LastKeyRotationStatus
        // GraphQL -> lastKeyRotationStatus: ArchivalLocationEncryptionJobInfo (type)
        [JsonProperty("lastKeyRotationStatus")]
        public ArchivalLocationEncryptionJobInfo? LastKeyRotationStatus { get; set; }

        //      C# -> ArchivalLocationEncryptionJobInfo? LastMasterKeyRekeyStatus
        // GraphQL -> lastMasterKeyRekeyStatus: ArchivalLocationEncryptionJobInfo (type)
        [JsonProperty("lastMasterKeyRekeyStatus")]
        public ArchivalLocationEncryptionJobInfo? LastMasterKeyRekeyStatus { get; set; }

        //      C# -> ArchivalLocationEncryptionJobInfo? LastRootKekRekeyStatus
        // GraphQL -> lastRootKekRekeyStatus: ArchivalLocationEncryptionJobInfo (type)
        [JsonProperty("lastRootKekRekeyStatus")]
        public ArchivalLocationEncryptionJobInfo? LastRootKekRekeyStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalLocationEncryptionJobsSummary";
    }

    public ArchivalLocationEncryptionJobsSummary Set(
        System.Int32? AutomaticRotationFrequency = null,
        ArchivalLocationEncryptionJobInfo? LastKeyRotationStatus = null,
        ArchivalLocationEncryptionJobInfo? LastMasterKeyRekeyStatus = null,
        ArchivalLocationEncryptionJobInfo? LastRootKekRekeyStatus = null
    ) 
    {
        if ( AutomaticRotationFrequency != null ) {
            this.AutomaticRotationFrequency = AutomaticRotationFrequency;
        }
        if ( LastKeyRotationStatus != null ) {
            this.LastKeyRotationStatus = LastKeyRotationStatus;
        }
        if ( LastMasterKeyRekeyStatus != null ) {
            this.LastMasterKeyRekeyStatus = LastMasterKeyRekeyStatus;
        }
        if ( LastRootKekRekeyStatus != null ) {
            this.LastRootKekRekeyStatus = LastRootKekRekeyStatus;
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
        //      C# -> System.Int32? AutomaticRotationFrequency
        // GraphQL -> automaticRotationFrequency: Int! (scalar)
        if (this.AutomaticRotationFrequency != null) {
            if (conf.Flat) {
                s += conf.Prefix + "automaticRotationFrequency\n" ;
            } else {
                s += ind + "automaticRotationFrequency\n" ;
            }
        }
        //      C# -> ArchivalLocationEncryptionJobInfo? LastKeyRotationStatus
        // GraphQL -> lastKeyRotationStatus: ArchivalLocationEncryptionJobInfo (type)
        if (this.LastKeyRotationStatus != null) {
            var fspec = this.LastKeyRotationStatus.AsFieldSpec(conf.Child("lastKeyRotationStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lastKeyRotationStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ArchivalLocationEncryptionJobInfo? LastMasterKeyRekeyStatus
        // GraphQL -> lastMasterKeyRekeyStatus: ArchivalLocationEncryptionJobInfo (type)
        if (this.LastMasterKeyRekeyStatus != null) {
            var fspec = this.LastMasterKeyRekeyStatus.AsFieldSpec(conf.Child("lastMasterKeyRekeyStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lastMasterKeyRekeyStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ArchivalLocationEncryptionJobInfo? LastRootKekRekeyStatus
        // GraphQL -> lastRootKekRekeyStatus: ArchivalLocationEncryptionJobInfo (type)
        if (this.LastRootKekRekeyStatus != null) {
            var fspec = this.LastRootKekRekeyStatus.AsFieldSpec(conf.Child("lastRootKekRekeyStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lastRootKekRekeyStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? AutomaticRotationFrequency
        // GraphQL -> automaticRotationFrequency: Int! (scalar)
        if (ec.Includes("automaticRotationFrequency",true))
        {
            if(this.AutomaticRotationFrequency == null) {

                this.AutomaticRotationFrequency = Int32.MinValue;

            } else {


            }
        }
        else if (this.AutomaticRotationFrequency != null && ec.Excludes("automaticRotationFrequency",true))
        {
            this.AutomaticRotationFrequency = null;
        }
        //      C# -> ArchivalLocationEncryptionJobInfo? LastKeyRotationStatus
        // GraphQL -> lastKeyRotationStatus: ArchivalLocationEncryptionJobInfo (type)
        if (ec.Includes("lastKeyRotationStatus",false))
        {
            if(this.LastKeyRotationStatus == null) {

                this.LastKeyRotationStatus = new ArchivalLocationEncryptionJobInfo();
                this.LastKeyRotationStatus.ApplyExploratoryFieldSpec(ec.NewChild("lastKeyRotationStatus"));

            } else {

                this.LastKeyRotationStatus.ApplyExploratoryFieldSpec(ec.NewChild("lastKeyRotationStatus"));

            }
        }
        else if (this.LastKeyRotationStatus != null && ec.Excludes("lastKeyRotationStatus",false))
        {
            this.LastKeyRotationStatus = null;
        }
        //      C# -> ArchivalLocationEncryptionJobInfo? LastMasterKeyRekeyStatus
        // GraphQL -> lastMasterKeyRekeyStatus: ArchivalLocationEncryptionJobInfo (type)
        if (ec.Includes("lastMasterKeyRekeyStatus",false))
        {
            if(this.LastMasterKeyRekeyStatus == null) {

                this.LastMasterKeyRekeyStatus = new ArchivalLocationEncryptionJobInfo();
                this.LastMasterKeyRekeyStatus.ApplyExploratoryFieldSpec(ec.NewChild("lastMasterKeyRekeyStatus"));

            } else {

                this.LastMasterKeyRekeyStatus.ApplyExploratoryFieldSpec(ec.NewChild("lastMasterKeyRekeyStatus"));

            }
        }
        else if (this.LastMasterKeyRekeyStatus != null && ec.Excludes("lastMasterKeyRekeyStatus",false))
        {
            this.LastMasterKeyRekeyStatus = null;
        }
        //      C# -> ArchivalLocationEncryptionJobInfo? LastRootKekRekeyStatus
        // GraphQL -> lastRootKekRekeyStatus: ArchivalLocationEncryptionJobInfo (type)
        if (ec.Includes("lastRootKekRekeyStatus",false))
        {
            if(this.LastRootKekRekeyStatus == null) {

                this.LastRootKekRekeyStatus = new ArchivalLocationEncryptionJobInfo();
                this.LastRootKekRekeyStatus.ApplyExploratoryFieldSpec(ec.NewChild("lastRootKekRekeyStatus"));

            } else {

                this.LastRootKekRekeyStatus.ApplyExploratoryFieldSpec(ec.NewChild("lastRootKekRekeyStatus"));

            }
        }
        else if (this.LastRootKekRekeyStatus != null && ec.Excludes("lastRootKekRekeyStatus",false))
        {
            this.LastRootKekRekeyStatus = null;
        }
    }


    #endregion

    } // class ArchivalLocationEncryptionJobsSummary
    
    #endregion

    public static class ListArchivalLocationEncryptionJobsSummaryExtensions
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
            this List<ArchivalLocationEncryptionJobsSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalLocationEncryptionJobsSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalLocationEncryptionJobsSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalLocationEncryptionJobsSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalLocationEncryptionJobsSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
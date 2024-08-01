// ArchivalLocationEncryptionDetails.cs
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
    #region ArchivalLocationEncryptionDetails
    public class ArchivalLocationEncryptionDetails: BaseType
    {
        #region members

        //      C# -> ArchivalLocationEncryptionCipher? EncryptionCipher
        // GraphQL -> encryptionCipher: ArchivalLocationEncryptionCipher (enum)
        [JsonProperty("encryptionCipher")]
        public ArchivalLocationEncryptionCipher? EncryptionCipher { get; set; }

        //      C# -> Target? ArchivalLocation
        // GraphQL -> archivalLocation: Target! (interface)
        [JsonProperty("archivalLocation")]
        public Target? ArchivalLocation { get; set; }

        //      C# -> System.Boolean? IsEncryptionEnabled
        // GraphQL -> isEncryptionEnabled: Boolean! (scalar)
        [JsonProperty("isEncryptionEnabled")]
        public System.Boolean? IsEncryptionEnabled { get; set; }

        //      C# -> System.Boolean? IsUnifiedEncryptionEnabled
        // GraphQL -> isUnifiedEncryptionEnabled: Boolean! (scalar)
        [JsonProperty("isUnifiedEncryptionEnabled")]
        public System.Boolean? IsUnifiedEncryptionEnabled { get; set; }

        //      C# -> ArchivalLocationKeyAssignmentInfo? ArchivalLocationKeyAssignmentInfo
        // GraphQL -> archivalLocationKeyAssignmentInfo: ArchivalLocationKeyAssignmentInfo! (type)
        [JsonProperty("archivalLocationKeyAssignmentInfo")]
        public ArchivalLocationKeyAssignmentInfo? ArchivalLocationKeyAssignmentInfo { get; set; }

        //      C# -> ArchivalLocationEncryptionHealth? EncryptionHealth
        // GraphQL -> encryptionHealth: ArchivalLocationEncryptionHealth (type)
        [JsonProperty("encryptionHealth")]
        public ArchivalLocationEncryptionHealth? EncryptionHealth { get; set; }

        //      C# -> ArchivalLocationEncryptionJobsSummary? EncryptionJobsSummary
        // GraphQL -> encryptionJobsSummary: ArchivalLocationEncryptionJobsSummary (type)
        [JsonProperty("encryptionJobsSummary")]
        public ArchivalLocationEncryptionJobsSummary? EncryptionJobsSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalLocationEncryptionDetails";
    }

    public ArchivalLocationEncryptionDetails Set(
        ArchivalLocationEncryptionCipher? EncryptionCipher = null,
        Target? ArchivalLocation = null,
        System.Boolean? IsEncryptionEnabled = null,
        System.Boolean? IsUnifiedEncryptionEnabled = null,
        ArchivalLocationKeyAssignmentInfo? ArchivalLocationKeyAssignmentInfo = null,
        ArchivalLocationEncryptionHealth? EncryptionHealth = null,
        ArchivalLocationEncryptionJobsSummary? EncryptionJobsSummary = null
    ) 
    {
        if ( EncryptionCipher != null ) {
            this.EncryptionCipher = EncryptionCipher;
        }
        if ( ArchivalLocation != null ) {
            this.ArchivalLocation = ArchivalLocation;
        }
        if ( IsEncryptionEnabled != null ) {
            this.IsEncryptionEnabled = IsEncryptionEnabled;
        }
        if ( IsUnifiedEncryptionEnabled != null ) {
            this.IsUnifiedEncryptionEnabled = IsUnifiedEncryptionEnabled;
        }
        if ( ArchivalLocationKeyAssignmentInfo != null ) {
            this.ArchivalLocationKeyAssignmentInfo = ArchivalLocationKeyAssignmentInfo;
        }
        if ( EncryptionHealth != null ) {
            this.EncryptionHealth = EncryptionHealth;
        }
        if ( EncryptionJobsSummary != null ) {
            this.EncryptionJobsSummary = EncryptionJobsSummary;
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
        //      C# -> ArchivalLocationEncryptionCipher? EncryptionCipher
        // GraphQL -> encryptionCipher: ArchivalLocationEncryptionCipher (enum)
        if (this.EncryptionCipher != null) {
            if (conf.Flat) {
                s += conf.Prefix + "encryptionCipher\n" ;
            } else {
                s += ind + "encryptionCipher\n" ;
            }
        }
        //      C# -> Target? ArchivalLocation
        // GraphQL -> archivalLocation: Target! (interface)
        if (this.ArchivalLocation != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.ArchivalLocation, conf.Child("archivalLocation"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archivalLocation" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.Boolean? IsEncryptionEnabled
        // GraphQL -> isEncryptionEnabled: Boolean! (scalar)
        if (this.IsEncryptionEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEncryptionEnabled\n" ;
            } else {
                s += ind + "isEncryptionEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsUnifiedEncryptionEnabled
        // GraphQL -> isUnifiedEncryptionEnabled: Boolean! (scalar)
        if (this.IsUnifiedEncryptionEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isUnifiedEncryptionEnabled\n" ;
            } else {
                s += ind + "isUnifiedEncryptionEnabled\n" ;
            }
        }
        //      C# -> ArchivalLocationKeyAssignmentInfo? ArchivalLocationKeyAssignmentInfo
        // GraphQL -> archivalLocationKeyAssignmentInfo: ArchivalLocationKeyAssignmentInfo! (type)
        if (this.ArchivalLocationKeyAssignmentInfo != null) {
            var fspec = this.ArchivalLocationKeyAssignmentInfo.AsFieldSpec(conf.Child("archivalLocationKeyAssignmentInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archivalLocationKeyAssignmentInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ArchivalLocationEncryptionHealth? EncryptionHealth
        // GraphQL -> encryptionHealth: ArchivalLocationEncryptionHealth (type)
        if (this.EncryptionHealth != null) {
            var fspec = this.EncryptionHealth.AsFieldSpec(conf.Child("encryptionHealth"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "encryptionHealth" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ArchivalLocationEncryptionJobsSummary? EncryptionJobsSummary
        // GraphQL -> encryptionJobsSummary: ArchivalLocationEncryptionJobsSummary (type)
        if (this.EncryptionJobsSummary != null) {
            var fspec = this.EncryptionJobsSummary.AsFieldSpec(conf.Child("encryptionJobsSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "encryptionJobsSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ArchivalLocationEncryptionCipher? EncryptionCipher
        // GraphQL -> encryptionCipher: ArchivalLocationEncryptionCipher (enum)
        if (ec.Includes("encryptionCipher",true))
        {
            if(this.EncryptionCipher == null) {

                this.EncryptionCipher = new ArchivalLocationEncryptionCipher();

            } else {


            }
        }
        else if (this.EncryptionCipher != null && ec.Excludes("encryptionCipher",true))
        {
            this.EncryptionCipher = null;
        }
        //      C# -> Target? ArchivalLocation
        // GraphQL -> archivalLocation: Target! (interface)
        if (ec.Includes("archivalLocation",false))
        {
            if(this.ArchivalLocation == null) {

                var impls = new List<Target>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("archivalLocation"));
                this.ArchivalLocation = (Target)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<Target>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("archivalLocation"));
                this.ArchivalLocation = (Target)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.ArchivalLocation != null && ec.Excludes("archivalLocation",false))
        {
            this.ArchivalLocation = null;
        }
        //      C# -> System.Boolean? IsEncryptionEnabled
        // GraphQL -> isEncryptionEnabled: Boolean! (scalar)
        if (ec.Includes("isEncryptionEnabled",true))
        {
            if(this.IsEncryptionEnabled == null) {

                this.IsEncryptionEnabled = true;

            } else {


            }
        }
        else if (this.IsEncryptionEnabled != null && ec.Excludes("isEncryptionEnabled",true))
        {
            this.IsEncryptionEnabled = null;
        }
        //      C# -> System.Boolean? IsUnifiedEncryptionEnabled
        // GraphQL -> isUnifiedEncryptionEnabled: Boolean! (scalar)
        if (ec.Includes("isUnifiedEncryptionEnabled",true))
        {
            if(this.IsUnifiedEncryptionEnabled == null) {

                this.IsUnifiedEncryptionEnabled = true;

            } else {


            }
        }
        else if (this.IsUnifiedEncryptionEnabled != null && ec.Excludes("isUnifiedEncryptionEnabled",true))
        {
            this.IsUnifiedEncryptionEnabled = null;
        }
        //      C# -> ArchivalLocationKeyAssignmentInfo? ArchivalLocationKeyAssignmentInfo
        // GraphQL -> archivalLocationKeyAssignmentInfo: ArchivalLocationKeyAssignmentInfo! (type)
        if (ec.Includes("archivalLocationKeyAssignmentInfo",false))
        {
            if(this.ArchivalLocationKeyAssignmentInfo == null) {

                this.ArchivalLocationKeyAssignmentInfo = new ArchivalLocationKeyAssignmentInfo();
                this.ArchivalLocationKeyAssignmentInfo.ApplyExploratoryFieldSpec(ec.NewChild("archivalLocationKeyAssignmentInfo"));

            } else {

                this.ArchivalLocationKeyAssignmentInfo.ApplyExploratoryFieldSpec(ec.NewChild("archivalLocationKeyAssignmentInfo"));

            }
        }
        else if (this.ArchivalLocationKeyAssignmentInfo != null && ec.Excludes("archivalLocationKeyAssignmentInfo",false))
        {
            this.ArchivalLocationKeyAssignmentInfo = null;
        }
        //      C# -> ArchivalLocationEncryptionHealth? EncryptionHealth
        // GraphQL -> encryptionHealth: ArchivalLocationEncryptionHealth (type)
        if (ec.Includes("encryptionHealth",false))
        {
            if(this.EncryptionHealth == null) {

                this.EncryptionHealth = new ArchivalLocationEncryptionHealth();
                this.EncryptionHealth.ApplyExploratoryFieldSpec(ec.NewChild("encryptionHealth"));

            } else {

                this.EncryptionHealth.ApplyExploratoryFieldSpec(ec.NewChild("encryptionHealth"));

            }
        }
        else if (this.EncryptionHealth != null && ec.Excludes("encryptionHealth",false))
        {
            this.EncryptionHealth = null;
        }
        //      C# -> ArchivalLocationEncryptionJobsSummary? EncryptionJobsSummary
        // GraphQL -> encryptionJobsSummary: ArchivalLocationEncryptionJobsSummary (type)
        if (ec.Includes("encryptionJobsSummary",false))
        {
            if(this.EncryptionJobsSummary == null) {

                this.EncryptionJobsSummary = new ArchivalLocationEncryptionJobsSummary();
                this.EncryptionJobsSummary.ApplyExploratoryFieldSpec(ec.NewChild("encryptionJobsSummary"));

            } else {

                this.EncryptionJobsSummary.ApplyExploratoryFieldSpec(ec.NewChild("encryptionJobsSummary"));

            }
        }
        else if (this.EncryptionJobsSummary != null && ec.Excludes("encryptionJobsSummary",false))
        {
            this.EncryptionJobsSummary = null;
        }
    }


    #endregion

    } // class ArchivalLocationEncryptionDetails
    
    #endregion

    public static class ListArchivalLocationEncryptionDetailsExtensions
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
            this List<ArchivalLocationEncryptionDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalLocationEncryptionDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalLocationEncryptionDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalLocationEncryptionDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalLocationEncryptionDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
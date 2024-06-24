// SecurityMetadata.cs
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
    #region SecurityMetadata
    public class SecurityMetadata: BaseType
    {
        #region members

        //      C# -> SensitivityStatus? SensitivityStatus
        // GraphQL -> sensitivityStatus: SensitivityStatus! (enum)
        [JsonProperty("sensitivityStatus")]
        public SensitivityStatus? SensitivityStatus { get; set; }

        //      C# -> System.Int64? HighSensitiveHits
        // GraphQL -> highSensitiveHits: Long! (scalar)
        [JsonProperty("highSensitiveHits")]
        public System.Int64? HighSensitiveHits { get; set; }

        //      C# -> System.Int64? LowSensitiveHits
        // GraphQL -> lowSensitiveHits: Long! (scalar)
        [JsonProperty("lowSensitiveHits")]
        public System.Int64? LowSensitiveHits { get; set; }

        //      C# -> System.Int64? MediumSensitiveHits
        // GraphQL -> mediumSensitiveHits: Long! (scalar)
        [JsonProperty("mediumSensitiveHits")]
        public System.Int64? MediumSensitiveHits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SecurityMetadata";
    }

    public SecurityMetadata Set(
        SensitivityStatus? SensitivityStatus = null,
        System.Int64? HighSensitiveHits = null,
        System.Int64? LowSensitiveHits = null,
        System.Int64? MediumSensitiveHits = null
    ) 
    {
        if ( SensitivityStatus != null ) {
            this.SensitivityStatus = SensitivityStatus;
        }
        if ( HighSensitiveHits != null ) {
            this.HighSensitiveHits = HighSensitiveHits;
        }
        if ( LowSensitiveHits != null ) {
            this.LowSensitiveHits = LowSensitiveHits;
        }
        if ( MediumSensitiveHits != null ) {
            this.MediumSensitiveHits = MediumSensitiveHits;
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
        //      C# -> SensitivityStatus? SensitivityStatus
        // GraphQL -> sensitivityStatus: SensitivityStatus! (enum)
        if (this.SensitivityStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sensitivityStatus\n" ;
            } else {
                s += ind + "sensitivityStatus\n" ;
            }
        }
        //      C# -> System.Int64? HighSensitiveHits
        // GraphQL -> highSensitiveHits: Long! (scalar)
        if (this.HighSensitiveHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "highSensitiveHits\n" ;
            } else {
                s += ind + "highSensitiveHits\n" ;
            }
        }
        //      C# -> System.Int64? LowSensitiveHits
        // GraphQL -> lowSensitiveHits: Long! (scalar)
        if (this.LowSensitiveHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lowSensitiveHits\n" ;
            } else {
                s += ind + "lowSensitiveHits\n" ;
            }
        }
        //      C# -> System.Int64? MediumSensitiveHits
        // GraphQL -> mediumSensitiveHits: Long! (scalar)
        if (this.MediumSensitiveHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mediumSensitiveHits\n" ;
            } else {
                s += ind + "mediumSensitiveHits\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SensitivityStatus? SensitivityStatus
        // GraphQL -> sensitivityStatus: SensitivityStatus! (enum)
        if (ec.Includes("sensitivityStatus",true))
        {
            if(this.SensitivityStatus == null) {

                this.SensitivityStatus = new SensitivityStatus();

            } else {


            }
        }
        else if (this.SensitivityStatus != null && ec.Excludes("sensitivityStatus",true))
        {
            this.SensitivityStatus = null;
        }
        //      C# -> System.Int64? HighSensitiveHits
        // GraphQL -> highSensitiveHits: Long! (scalar)
        if (ec.Includes("highSensitiveHits",true))
        {
            if(this.HighSensitiveHits == null) {

                this.HighSensitiveHits = new System.Int64();

            } else {


            }
        }
        else if (this.HighSensitiveHits != null && ec.Excludes("highSensitiveHits",true))
        {
            this.HighSensitiveHits = null;
        }
        //      C# -> System.Int64? LowSensitiveHits
        // GraphQL -> lowSensitiveHits: Long! (scalar)
        if (ec.Includes("lowSensitiveHits",true))
        {
            if(this.LowSensitiveHits == null) {

                this.LowSensitiveHits = new System.Int64();

            } else {


            }
        }
        else if (this.LowSensitiveHits != null && ec.Excludes("lowSensitiveHits",true))
        {
            this.LowSensitiveHits = null;
        }
        //      C# -> System.Int64? MediumSensitiveHits
        // GraphQL -> mediumSensitiveHits: Long! (scalar)
        if (ec.Includes("mediumSensitiveHits",true))
        {
            if(this.MediumSensitiveHits == null) {

                this.MediumSensitiveHits = new System.Int64();

            } else {


            }
        }
        else if (this.MediumSensitiveHits != null && ec.Excludes("mediumSensitiveHits",true))
        {
            this.MediumSensitiveHits = null;
        }
    }


    #endregion

    } // class SecurityMetadata
    
    #endregion

    public static class ListSecurityMetadataExtensions
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
            this List<SecurityMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SecurityMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SecurityMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SecurityMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SecurityMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
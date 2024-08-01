// ThreatFeedScanStatus.cs
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
    #region ThreatFeedScanStatus
    public class ThreatFeedScanStatus: BaseType
    {
        #region members

        //      C# -> System.String? FeedVersion
        // GraphQL -> feedVersion: String! (scalar)
        [JsonProperty("feedVersion")]
        public System.String? FeedVersion { get; set; }

        //      C# -> System.Int32? NewIocs
        // GraphQL -> newIocs: Int! (scalar)
        [JsonProperty("newIocs")]
        public System.Int32? NewIocs { get; set; }

        //      C# -> System.Int64? ScannedObjects
        // GraphQL -> scannedObjects: Long! (scalar)
        [JsonProperty("scannedObjects")]
        public System.Int64? ScannedObjects { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatFeedScanStatus";
    }

    public ThreatFeedScanStatus Set(
        System.String? FeedVersion = null,
        System.Int32? NewIocs = null,
        System.Int64? ScannedObjects = null,
        DateTime? UpdatedAt = null
    ) 
    {
        if ( FeedVersion != null ) {
            this.FeedVersion = FeedVersion;
        }
        if ( NewIocs != null ) {
            this.NewIocs = NewIocs;
        }
        if ( ScannedObjects != null ) {
            this.ScannedObjects = ScannedObjects;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
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
        //      C# -> System.String? FeedVersion
        // GraphQL -> feedVersion: String! (scalar)
        if (this.FeedVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "feedVersion\n" ;
            } else {
                s += ind + "feedVersion\n" ;
            }
        }
        //      C# -> System.Int32? NewIocs
        // GraphQL -> newIocs: Int! (scalar)
        if (this.NewIocs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newIocs\n" ;
            } else {
                s += ind + "newIocs\n" ;
            }
        }
        //      C# -> System.Int64? ScannedObjects
        // GraphQL -> scannedObjects: Long! (scalar)
        if (this.ScannedObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scannedObjects\n" ;
            } else {
                s += ind + "scannedObjects\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAt\n" ;
            } else {
                s += ind + "updatedAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? FeedVersion
        // GraphQL -> feedVersion: String! (scalar)
        if (ec.Includes("feedVersion",true))
        {
            if(this.FeedVersion == null) {

                this.FeedVersion = "FETCH";

            } else {


            }
        }
        else if (this.FeedVersion != null && ec.Excludes("feedVersion",true))
        {
            this.FeedVersion = null;
        }
        //      C# -> System.Int32? NewIocs
        // GraphQL -> newIocs: Int! (scalar)
        if (ec.Includes("newIocs",true))
        {
            if(this.NewIocs == null) {

                this.NewIocs = Int32.MinValue;

            } else {


            }
        }
        else if (this.NewIocs != null && ec.Excludes("newIocs",true))
        {
            this.NewIocs = null;
        }
        //      C# -> System.Int64? ScannedObjects
        // GraphQL -> scannedObjects: Long! (scalar)
        if (ec.Includes("scannedObjects",true))
        {
            if(this.ScannedObjects == null) {

                this.ScannedObjects = new System.Int64();

            } else {


            }
        }
        else if (this.ScannedObjects != null && ec.Excludes("scannedObjects",true))
        {
            this.ScannedObjects = null;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (ec.Includes("updatedAt",true))
        {
            if(this.UpdatedAt == null) {

                this.UpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.UpdatedAt != null && ec.Excludes("updatedAt",true))
        {
            this.UpdatedAt = null;
        }
    }


    #endregion

    } // class ThreatFeedScanStatus
    
    #endregion

    public static class ListThreatFeedScanStatusExtensions
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
            this List<ThreatFeedScanStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatFeedScanStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatFeedScanStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatFeedScanStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatFeedScanStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
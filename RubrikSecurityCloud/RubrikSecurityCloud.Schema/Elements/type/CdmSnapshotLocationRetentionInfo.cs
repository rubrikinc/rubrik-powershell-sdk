// CdmSnapshotLocationRetentionInfo.cs
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
    #region CdmSnapshotLocationRetentionInfo
    public class CdmSnapshotLocationRetentionInfo: BaseType
    {
        #region members

        //      C# -> SnapshotFrequency? SnapshotFrequency
        // GraphQL -> snapshotFrequency: SnapshotFrequency! (enum)
        [JsonProperty("snapshotFrequency")]
        public SnapshotFrequency? SnapshotFrequency { get; set; }

        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        [JsonProperty("expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        //      C# -> System.Boolean? IsExpirationDateCalculated
        // GraphQL -> isExpirationDateCalculated: Boolean! (scalar)
        [JsonProperty("isExpirationDateCalculated")]
        public System.Boolean? IsExpirationDateCalculated { get; set; }

        //      C# -> System.Boolean? IsExpirationInformationUnavailable
        // GraphQL -> isExpirationInformationUnavailable: Boolean! (scalar)
        [JsonProperty("isExpirationInformationUnavailable")]
        public System.Boolean? IsExpirationInformationUnavailable { get; set; }

        //      C# -> System.Boolean? IsSnapshotOnLegalHold
        // GraphQL -> isSnapshotOnLegalHold: Boolean! (scalar)
        [JsonProperty("isSnapshotOnLegalHold")]
        public System.Boolean? IsSnapshotOnLegalHold { get; set; }

        //      C# -> System.Boolean? IsSnapshotPresent
        // GraphQL -> isSnapshotPresent: Boolean! (scalar)
        [JsonProperty("isSnapshotPresent")]
        public System.Boolean? IsSnapshotPresent { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmSnapshotLocationRetentionInfo";
    }

    public CdmSnapshotLocationRetentionInfo Set(
        SnapshotFrequency? SnapshotFrequency = null,
        DateTime? ExpirationTime = null,
        System.Boolean? IsExpirationDateCalculated = null,
        System.Boolean? IsExpirationInformationUnavailable = null,
        System.Boolean? IsSnapshotOnLegalHold = null,
        System.Boolean? IsSnapshotPresent = null,
        System.String? LocationId = null,
        System.String? Name = null
    ) 
    {
        if ( SnapshotFrequency != null ) {
            this.SnapshotFrequency = SnapshotFrequency;
        }
        if ( ExpirationTime != null ) {
            this.ExpirationTime = ExpirationTime;
        }
        if ( IsExpirationDateCalculated != null ) {
            this.IsExpirationDateCalculated = IsExpirationDateCalculated;
        }
        if ( IsExpirationInformationUnavailable != null ) {
            this.IsExpirationInformationUnavailable = IsExpirationInformationUnavailable;
        }
        if ( IsSnapshotOnLegalHold != null ) {
            this.IsSnapshotOnLegalHold = IsSnapshotOnLegalHold;
        }
        if ( IsSnapshotPresent != null ) {
            this.IsSnapshotPresent = IsSnapshotPresent;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> SnapshotFrequency? SnapshotFrequency
        // GraphQL -> snapshotFrequency: SnapshotFrequency! (enum)
        if (this.SnapshotFrequency != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotFrequency\n" ;
            } else {
                s += ind + "snapshotFrequency\n" ;
            }
        }
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationTime\n" ;
            } else {
                s += ind + "expirationTime\n" ;
            }
        }
        //      C# -> System.Boolean? IsExpirationDateCalculated
        // GraphQL -> isExpirationDateCalculated: Boolean! (scalar)
        if (this.IsExpirationDateCalculated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExpirationDateCalculated\n" ;
            } else {
                s += ind + "isExpirationDateCalculated\n" ;
            }
        }
        //      C# -> System.Boolean? IsExpirationInformationUnavailable
        // GraphQL -> isExpirationInformationUnavailable: Boolean! (scalar)
        if (this.IsExpirationInformationUnavailable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExpirationInformationUnavailable\n" ;
            } else {
                s += ind + "isExpirationInformationUnavailable\n" ;
            }
        }
        //      C# -> System.Boolean? IsSnapshotOnLegalHold
        // GraphQL -> isSnapshotOnLegalHold: Boolean! (scalar)
        if (this.IsSnapshotOnLegalHold != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSnapshotOnLegalHold\n" ;
            } else {
                s += ind + "isSnapshotOnLegalHold\n" ;
            }
        }
        //      C# -> System.Boolean? IsSnapshotPresent
        // GraphQL -> isSnapshotPresent: Boolean! (scalar)
        if (this.IsSnapshotPresent != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSnapshotPresent\n" ;
            } else {
                s += ind + "isSnapshotPresent\n" ;
            }
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationId\n" ;
            } else {
                s += ind + "locationId\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SnapshotFrequency? SnapshotFrequency
        // GraphQL -> snapshotFrequency: SnapshotFrequency! (enum)
        if (ec.Includes("snapshotFrequency",true))
        {
            if(this.SnapshotFrequency == null) {

                this.SnapshotFrequency = new SnapshotFrequency();

            } else {


            }
        }
        else if (this.SnapshotFrequency != null && ec.Excludes("snapshotFrequency",true))
        {
            this.SnapshotFrequency = null;
        }
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (ec.Includes("expirationTime",true))
        {
            if(this.ExpirationTime == null) {

                this.ExpirationTime = new DateTime();

            } else {


            }
        }
        else if (this.ExpirationTime != null && ec.Excludes("expirationTime",true))
        {
            this.ExpirationTime = null;
        }
        //      C# -> System.Boolean? IsExpirationDateCalculated
        // GraphQL -> isExpirationDateCalculated: Boolean! (scalar)
        if (ec.Includes("isExpirationDateCalculated",true))
        {
            if(this.IsExpirationDateCalculated == null) {

                this.IsExpirationDateCalculated = true;

            } else {


            }
        }
        else if (this.IsExpirationDateCalculated != null && ec.Excludes("isExpirationDateCalculated",true))
        {
            this.IsExpirationDateCalculated = null;
        }
        //      C# -> System.Boolean? IsExpirationInformationUnavailable
        // GraphQL -> isExpirationInformationUnavailable: Boolean! (scalar)
        if (ec.Includes("isExpirationInformationUnavailable",true))
        {
            if(this.IsExpirationInformationUnavailable == null) {

                this.IsExpirationInformationUnavailable = true;

            } else {


            }
        }
        else if (this.IsExpirationInformationUnavailable != null && ec.Excludes("isExpirationInformationUnavailable",true))
        {
            this.IsExpirationInformationUnavailable = null;
        }
        //      C# -> System.Boolean? IsSnapshotOnLegalHold
        // GraphQL -> isSnapshotOnLegalHold: Boolean! (scalar)
        if (ec.Includes("isSnapshotOnLegalHold",true))
        {
            if(this.IsSnapshotOnLegalHold == null) {

                this.IsSnapshotOnLegalHold = true;

            } else {


            }
        }
        else if (this.IsSnapshotOnLegalHold != null && ec.Excludes("isSnapshotOnLegalHold",true))
        {
            this.IsSnapshotOnLegalHold = null;
        }
        //      C# -> System.Boolean? IsSnapshotPresent
        // GraphQL -> isSnapshotPresent: Boolean! (scalar)
        if (ec.Includes("isSnapshotPresent",true))
        {
            if(this.IsSnapshotPresent == null) {

                this.IsSnapshotPresent = true;

            } else {


            }
        }
        else if (this.IsSnapshotPresent != null && ec.Excludes("isSnapshotPresent",true))
        {
            this.IsSnapshotPresent = null;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (ec.Includes("locationId",true))
        {
            if(this.LocationId == null) {

                this.LocationId = "FETCH";

            } else {


            }
        }
        else if (this.LocationId != null && ec.Excludes("locationId",true))
        {
            this.LocationId = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
    }


    #endregion

    } // class CdmSnapshotLocationRetentionInfo
    
    #endregion

    public static class ListCdmSnapshotLocationRetentionInfoExtensions
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
            this List<CdmSnapshotLocationRetentionInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmSnapshotLocationRetentionInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmSnapshotLocationRetentionInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmSnapshotLocationRetentionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmSnapshotLocationRetentionInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// ArchivalLocationForFailoverGroup.cs
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
    #region ArchivalLocationForFailoverGroup
    public class ArchivalLocationForFailoverGroup: BaseType
    {
        #region members

        //      C# -> ArchivalLocationIneligibilityReason? IneligibilityReason
        // GraphQL -> ineligibilityReason: ArchivalLocationIneligibilityReason! (enum)
        [JsonProperty("ineligibilityReason")]
        public ArchivalLocationIneligibilityReason? IneligibilityReason { get; set; }

        //      C# -> ArchivalLocationStatus? LocationStatus
        // GraphQL -> locationStatus: ArchivalLocationStatus! (enum)
        [JsonProperty("locationStatus")]
        public ArchivalLocationStatus? LocationStatus { get; set; }

        //      C# -> TargetType? LocationType
        // GraphQL -> locationType: TargetType! (enum)
        [JsonProperty("locationType")]
        public TargetType? LocationType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsEligible
        // GraphQL -> isEligible: Boolean! (scalar)
        [JsonProperty("isEligible")]
        public System.Boolean? IsEligible { get; set; }

        //      C# -> System.Boolean? IsImmutabilityEnabled
        // GraphQL -> isImmutabilityEnabled: Boolean! (scalar)
        [JsonProperty("isImmutabilityEnabled")]
        public System.Boolean? IsImmutabilityEnabled { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? StorageLocation
        // GraphQL -> storageLocation: String! (scalar)
        [JsonProperty("storageLocation")]
        public System.String? StorageLocation { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalLocationForFailoverGroup";
    }

    public ArchivalLocationForFailoverGroup Set(
        ArchivalLocationIneligibilityReason? IneligibilityReason = null,
        ArchivalLocationStatus? LocationStatus = null,
        TargetType? LocationType = null,
        System.String? Id = null,
        System.Boolean? IsEligible = null,
        System.Boolean? IsImmutabilityEnabled = null,
        System.String? Name = null,
        System.String? StorageLocation = null
    ) 
    {
        if ( IneligibilityReason != null ) {
            this.IneligibilityReason = IneligibilityReason;
        }
        if ( LocationStatus != null ) {
            this.LocationStatus = LocationStatus;
        }
        if ( LocationType != null ) {
            this.LocationType = LocationType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsEligible != null ) {
            this.IsEligible = IsEligible;
        }
        if ( IsImmutabilityEnabled != null ) {
            this.IsImmutabilityEnabled = IsImmutabilityEnabled;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( StorageLocation != null ) {
            this.StorageLocation = StorageLocation;
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
        //      C# -> ArchivalLocationIneligibilityReason? IneligibilityReason
        // GraphQL -> ineligibilityReason: ArchivalLocationIneligibilityReason! (enum)
        if (this.IneligibilityReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ineligibilityReason\n" ;
            } else {
                s += ind + "ineligibilityReason\n" ;
            }
        }
        //      C# -> ArchivalLocationStatus? LocationStatus
        // GraphQL -> locationStatus: ArchivalLocationStatus! (enum)
        if (this.LocationStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationStatus\n" ;
            } else {
                s += ind + "locationStatus\n" ;
            }
        }
        //      C# -> TargetType? LocationType
        // GraphQL -> locationType: TargetType! (enum)
        if (this.LocationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationType\n" ;
            } else {
                s += ind + "locationType\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsEligible
        // GraphQL -> isEligible: Boolean! (scalar)
        if (this.IsEligible != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEligible\n" ;
            } else {
                s += ind + "isEligible\n" ;
            }
        }
        //      C# -> System.Boolean? IsImmutabilityEnabled
        // GraphQL -> isImmutabilityEnabled: Boolean! (scalar)
        if (this.IsImmutabilityEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isImmutabilityEnabled\n" ;
            } else {
                s += ind + "isImmutabilityEnabled\n" ;
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
        //      C# -> System.String? StorageLocation
        // GraphQL -> storageLocation: String! (scalar)
        if (this.StorageLocation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageLocation\n" ;
            } else {
                s += ind + "storageLocation\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ArchivalLocationIneligibilityReason? IneligibilityReason
        // GraphQL -> ineligibilityReason: ArchivalLocationIneligibilityReason! (enum)
        if (ec.Includes("ineligibilityReason",true))
        {
            if(this.IneligibilityReason == null) {

                this.IneligibilityReason = new ArchivalLocationIneligibilityReason();

            } else {


            }
        }
        else if (this.IneligibilityReason != null && ec.Excludes("ineligibilityReason",true))
        {
            this.IneligibilityReason = null;
        }
        //      C# -> ArchivalLocationStatus? LocationStatus
        // GraphQL -> locationStatus: ArchivalLocationStatus! (enum)
        if (ec.Includes("locationStatus",true))
        {
            if(this.LocationStatus == null) {

                this.LocationStatus = new ArchivalLocationStatus();

            } else {


            }
        }
        else if (this.LocationStatus != null && ec.Excludes("locationStatus",true))
        {
            this.LocationStatus = null;
        }
        //      C# -> TargetType? LocationType
        // GraphQL -> locationType: TargetType! (enum)
        if (ec.Includes("locationType",true))
        {
            if(this.LocationType == null) {

                this.LocationType = new TargetType();

            } else {


            }
        }
        else if (this.LocationType != null && ec.Excludes("locationType",true))
        {
            this.LocationType = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsEligible
        // GraphQL -> isEligible: Boolean! (scalar)
        if (ec.Includes("isEligible",true))
        {
            if(this.IsEligible == null) {

                this.IsEligible = true;

            } else {


            }
        }
        else if (this.IsEligible != null && ec.Excludes("isEligible",true))
        {
            this.IsEligible = null;
        }
        //      C# -> System.Boolean? IsImmutabilityEnabled
        // GraphQL -> isImmutabilityEnabled: Boolean! (scalar)
        if (ec.Includes("isImmutabilityEnabled",true))
        {
            if(this.IsImmutabilityEnabled == null) {

                this.IsImmutabilityEnabled = true;

            } else {


            }
        }
        else if (this.IsImmutabilityEnabled != null && ec.Excludes("isImmutabilityEnabled",true))
        {
            this.IsImmutabilityEnabled = null;
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
        //      C# -> System.String? StorageLocation
        // GraphQL -> storageLocation: String! (scalar)
        if (ec.Includes("storageLocation",true))
        {
            if(this.StorageLocation == null) {

                this.StorageLocation = "FETCH";

            } else {


            }
        }
        else if (this.StorageLocation != null && ec.Excludes("storageLocation",true))
        {
            this.StorageLocation = null;
        }
    }


    #endregion

    } // class ArchivalLocationForFailoverGroup
    
    #endregion

    public static class ListArchivalLocationForFailoverGroupExtensions
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
            this List<ArchivalLocationForFailoverGroup> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalLocationForFailoverGroup> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalLocationForFailoverGroup> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalLocationForFailoverGroup());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalLocationForFailoverGroup> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
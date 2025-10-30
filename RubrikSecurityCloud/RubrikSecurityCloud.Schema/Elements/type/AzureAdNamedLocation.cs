// AzureAdNamedLocation.cs
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
    #region AzureAdNamedLocation
    public class AzureAdNamedLocation: BaseType
    {
        #region members

        //      C# -> AzureAdNamedLocationIsTrustedEnumType? IsTrusted
        // GraphQL -> isTrusted: AzureAdNamedLocationIsTrustedEnumType! (enum)
        [JsonProperty("isTrusted")]
        public AzureAdNamedLocationIsTrustedEnumType? IsTrusted { get; set; }

        //      C# -> AzureAdNamedLocationEnumType? LocationType
        // GraphQL -> locationType: AzureAdNamedLocationEnumType! (enum)
        [JsonProperty("locationType")]
        public AzureAdNamedLocationEnumType? LocationType { get; set; }

        //      C# -> DateTime? CreatedDateTime
        // GraphQL -> createdDateTime: DateTime (scalar)
        [JsonProperty("createdDateTime")]
        public DateTime? CreatedDateTime { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> DateTime? ModifiedDateTime
        // GraphQL -> modifiedDateTime: DateTime (scalar)
        [JsonProperty("modifiedDateTime")]
        public DateTime? ModifiedDateTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdNamedLocation";
    }

    public AzureAdNamedLocation Set(
        AzureAdNamedLocationIsTrustedEnumType? IsTrusted = null,
        AzureAdNamedLocationEnumType? LocationType = null,
        DateTime? CreatedDateTime = null,
        System.String? DisplayName = null,
        DateTime? ModifiedDateTime = null
    ) 
    {
        if ( IsTrusted != null ) {
            this.IsTrusted = IsTrusted;
        }
        if ( LocationType != null ) {
            this.LocationType = LocationType;
        }
        if ( CreatedDateTime != null ) {
            this.CreatedDateTime = CreatedDateTime;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( ModifiedDateTime != null ) {
            this.ModifiedDateTime = ModifiedDateTime;
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
        //      C# -> AzureAdNamedLocationIsTrustedEnumType? IsTrusted
        // GraphQL -> isTrusted: AzureAdNamedLocationIsTrustedEnumType! (enum)
        if (this.IsTrusted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isTrusted\n" ;
            } else {
                s += ind + "isTrusted\n" ;
            }
        }
        //      C# -> AzureAdNamedLocationEnumType? LocationType
        // GraphQL -> locationType: AzureAdNamedLocationEnumType! (enum)
        if (this.LocationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationType\n" ;
            } else {
                s += ind + "locationType\n" ;
            }
        }
        //      C# -> DateTime? CreatedDateTime
        // GraphQL -> createdDateTime: DateTime (scalar)
        if (this.CreatedDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdDateTime\n" ;
            } else {
                s += ind + "createdDateTime\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> DateTime? ModifiedDateTime
        // GraphQL -> modifiedDateTime: DateTime (scalar)
        if (this.ModifiedDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "modifiedDateTime\n" ;
            } else {
                s += ind + "modifiedDateTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdNamedLocationIsTrustedEnumType? IsTrusted
        // GraphQL -> isTrusted: AzureAdNamedLocationIsTrustedEnumType! (enum)
        if (ec.Includes("isTrusted",true))
        {
            if(this.IsTrusted == null) {

                this.IsTrusted = new AzureAdNamedLocationIsTrustedEnumType();

            } else {


            }
        }
        else if (this.IsTrusted != null && ec.Excludes("isTrusted",true))
        {
            this.IsTrusted = null;
        }
        //      C# -> AzureAdNamedLocationEnumType? LocationType
        // GraphQL -> locationType: AzureAdNamedLocationEnumType! (enum)
        if (ec.Includes("locationType",true))
        {
            if(this.LocationType == null) {

                this.LocationType = new AzureAdNamedLocationEnumType();

            } else {


            }
        }
        else if (this.LocationType != null && ec.Excludes("locationType",true))
        {
            this.LocationType = null;
        }
        //      C# -> DateTime? CreatedDateTime
        // GraphQL -> createdDateTime: DateTime (scalar)
        if (ec.Includes("createdDateTime",true))
        {
            if(this.CreatedDateTime == null) {

                this.CreatedDateTime = new DateTime();

            } else {


            }
        }
        else if (this.CreatedDateTime != null && ec.Excludes("createdDateTime",true))
        {
            this.CreatedDateTime = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> DateTime? ModifiedDateTime
        // GraphQL -> modifiedDateTime: DateTime (scalar)
        if (ec.Includes("modifiedDateTime",true))
        {
            if(this.ModifiedDateTime == null) {

                this.ModifiedDateTime = new DateTime();

            } else {


            }
        }
        else if (this.ModifiedDateTime != null && ec.Excludes("modifiedDateTime",true))
        {
            this.ModifiedDateTime = null;
        }
    }


    #endregion

    } // class AzureAdNamedLocation
    
    #endregion

    public static class ListAzureAdNamedLocationExtensions
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
            this List<AzureAdNamedLocation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdNamedLocation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdNamedLocation> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdNamedLocation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdNamedLocation> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
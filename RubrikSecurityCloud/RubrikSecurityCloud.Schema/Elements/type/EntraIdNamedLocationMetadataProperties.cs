// EntraIdNamedLocationMetadataProperties.cs
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
    #region EntraIdNamedLocationMetadataProperties
 
    public class EntraIdNamedLocationMetadataProperties: BaseType, PrincipalMetadata
    {
        #region members

        //      C# -> EntraIdNamedLocationType? LocationType
        // GraphQL -> locationType: EntraIDNamedLocationType! (enum)
        [JsonProperty("locationType")]
        public EntraIdNamedLocationType? LocationType { get; set; }

        //      C# -> System.String? CreatedDateTime
        // GraphQL -> createdDateTime: String! (scalar)
        [JsonProperty("createdDateTime")]
        public System.String? CreatedDateTime { get; set; }

        //      C# -> System.String? ModifiedDateTime
        // GraphQL -> modifiedDateTime: String! (scalar)
        [JsonProperty("modifiedDateTime")]
        public System.String? ModifiedDateTime { get; set; }

        //      C# -> PropertiesOneof? Properties
        // GraphQL -> properties: PropertiesOneof (type)
        [JsonProperty("properties")]
        public PropertiesOneof? Properties { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EntraIDNamedLocationMetadataProperties";
    }

    public EntraIdNamedLocationMetadataProperties Set(
        EntraIdNamedLocationType? LocationType = null,
        System.String? CreatedDateTime = null,
        System.String? ModifiedDateTime = null,
        PropertiesOneof? Properties = null
    ) 
    {
        if ( LocationType != null ) {
            this.LocationType = LocationType;
        }
        if ( CreatedDateTime != null ) {
            this.CreatedDateTime = CreatedDateTime;
        }
        if ( ModifiedDateTime != null ) {
            this.ModifiedDateTime = ModifiedDateTime;
        }
        if ( Properties != null ) {
            this.Properties = Properties;
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
        //      C# -> EntraIdNamedLocationType? LocationType
        // GraphQL -> locationType: EntraIDNamedLocationType! (enum)
        if (this.LocationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationType\n" ;
            } else {
                s += ind + "locationType\n" ;
            }
        }
        //      C# -> System.String? CreatedDateTime
        // GraphQL -> createdDateTime: String! (scalar)
        if (this.CreatedDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdDateTime\n" ;
            } else {
                s += ind + "createdDateTime\n" ;
            }
        }
        //      C# -> System.String? ModifiedDateTime
        // GraphQL -> modifiedDateTime: String! (scalar)
        if (this.ModifiedDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "modifiedDateTime\n" ;
            } else {
                s += ind + "modifiedDateTime\n" ;
            }
        }
        //      C# -> PropertiesOneof? Properties
        // GraphQL -> properties: PropertiesOneof (type)
        if (this.Properties != null) {
            var fspec = this.Properties.AsFieldSpec(conf.Child("properties"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "properties" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> EntraIdNamedLocationType? LocationType
        // GraphQL -> locationType: EntraIDNamedLocationType! (enum)
        if (ec.Includes("locationType",true))
        {
            if(this.LocationType == null) {

                this.LocationType = new EntraIdNamedLocationType();

            } else {


            }
        }
        else if (this.LocationType != null && ec.Excludes("locationType",true))
        {
            this.LocationType = null;
        }
        //      C# -> System.String? CreatedDateTime
        // GraphQL -> createdDateTime: String! (scalar)
        if (ec.Includes("createdDateTime",true))
        {
            if(this.CreatedDateTime == null) {

                this.CreatedDateTime = "FETCH";

            } else {


            }
        }
        else if (this.CreatedDateTime != null && ec.Excludes("createdDateTime",true))
        {
            this.CreatedDateTime = null;
        }
        //      C# -> System.String? ModifiedDateTime
        // GraphQL -> modifiedDateTime: String! (scalar)
        if (ec.Includes("modifiedDateTime",true))
        {
            if(this.ModifiedDateTime == null) {

                this.ModifiedDateTime = "FETCH";

            } else {


            }
        }
        else if (this.ModifiedDateTime != null && ec.Excludes("modifiedDateTime",true))
        {
            this.ModifiedDateTime = null;
        }
        //      C# -> PropertiesOneof? Properties
        // GraphQL -> properties: PropertiesOneof (type)
        if (ec.Includes("properties",false))
        {
            if(this.Properties == null) {

                this.Properties = new PropertiesOneof();
                this.Properties.ApplyExploratoryFieldSpec(ec.NewChild("properties"));

            } else {

                this.Properties.ApplyExploratoryFieldSpec(ec.NewChild("properties"));

            }
        }
        else if (this.Properties != null && ec.Excludes("properties",false))
        {
            this.Properties = null;
        }
    }


    #endregion

    } // class EntraIdNamedLocationMetadataProperties
    
    #endregion

    public static class ListEntraIdNamedLocationMetadataPropertiesExtensions
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
            this List<EntraIdNamedLocationMetadataProperties> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EntraIdNamedLocationMetadataProperties> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EntraIdNamedLocationMetadataProperties> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EntraIdNamedLocationMetadataProperties());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EntraIdNamedLocationMetadataProperties> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
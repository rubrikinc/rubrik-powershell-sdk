// AzureLocationDetailType.cs
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
    #region AzureLocationDetailType
    public class AzureLocationDetailType: BaseType
    {
        #region members

        //      C# -> AzureCloudAccountRegion? Location
        // GraphQL -> location: AzureCloudAccountRegion! (enum)
        [JsonProperty("location")]
        public AzureCloudAccountRegion? Location { get; set; }

        //      C# -> List<System.String>? LogicalAvailabilityZones
        // GraphQL -> logicalAvailabilityZones: [String!]! (scalar)
        [JsonProperty("logicalAvailabilityZones")]
        public List<System.String>? LogicalAvailabilityZones { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureLocationDetailType";
    }

    public AzureLocationDetailType Set(
        AzureCloudAccountRegion? Location = null,
        List<System.String>? LogicalAvailabilityZones = null
    ) 
    {
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( LogicalAvailabilityZones != null ) {
            this.LogicalAvailabilityZones = LogicalAvailabilityZones;
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
        //      C# -> AzureCloudAccountRegion? Location
        // GraphQL -> location: AzureCloudAccountRegion! (enum)
        if (this.Location != null) {
            if (conf.Flat) {
                s += conf.Prefix + "location\n" ;
            } else {
                s += ind + "location\n" ;
            }
        }
        //      C# -> List<System.String>? LogicalAvailabilityZones
        // GraphQL -> logicalAvailabilityZones: [String!]! (scalar)
        if (this.LogicalAvailabilityZones != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logicalAvailabilityZones\n" ;
            } else {
                s += ind + "logicalAvailabilityZones\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureCloudAccountRegion? Location
        // GraphQL -> location: AzureCloudAccountRegion! (enum)
        if (ec.Includes("location",true))
        {
            if(this.Location == null) {

                this.Location = new AzureCloudAccountRegion();

            } else {


            }
        }
        else if (this.Location != null && ec.Excludes("location",true))
        {
            this.Location = null;
        }
        //      C# -> List<System.String>? LogicalAvailabilityZones
        // GraphQL -> logicalAvailabilityZones: [String!]! (scalar)
        if (ec.Includes("logicalAvailabilityZones",true))
        {
            if(this.LogicalAvailabilityZones == null) {

                this.LogicalAvailabilityZones = new List<System.String>();

            } else {


            }
        }
        else if (this.LogicalAvailabilityZones != null && ec.Excludes("logicalAvailabilityZones",true))
        {
            this.LogicalAvailabilityZones = null;
        }
    }


    #endregion

    } // class AzureLocationDetailType
    
    #endregion

    public static class ListAzureLocationDetailTypeExtensions
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
            this List<AzureLocationDetailType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureLocationDetailType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureLocationDetailType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureLocationDetailType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureLocationDetailType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
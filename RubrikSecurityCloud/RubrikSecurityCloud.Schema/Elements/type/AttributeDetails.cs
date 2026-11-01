// AttributeDetails.cs
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
    #region AttributeDetails
    public class AttributeDetails: BaseType
    {
        #region members

        //      C# -> AzureAdObjectAttributeDifferenceEnumType? DifferenceType
        // GraphQL -> differenceType: AzureAdObjectAttributeDifferenceEnumType! (enum)
        [JsonProperty("differenceType")]
        public AzureAdObjectAttributeDifferenceEnumType? DifferenceType { get; set; }

        //      C# -> System.String? AttributeName
        // GraphQL -> attributeName: String! (scalar)
        [JsonProperty("attributeName")]
        public System.String? AttributeName { get; set; }

        //      C# -> System.Boolean? IsRecoverySupported
        // GraphQL -> isRecoverySupported: Boolean! (scalar)
        [JsonProperty("isRecoverySupported")]
        public System.Boolean? IsRecoverySupported { get; set; }

        //      C# -> List<System.String>? LiveValue
        // GraphQL -> liveValue: [String!]! (scalar)
        [JsonProperty("liveValue")]
        public List<System.String>? LiveValue { get; set; }

        //      C# -> List<System.String>? SnapshotValue
        // GraphQL -> snapshotValue: [String!]! (scalar)
        [JsonProperty("snapshotValue")]
        public List<System.String>? SnapshotValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AttributeDetails";
    }

    public AttributeDetails Set(
        AzureAdObjectAttributeDifferenceEnumType? DifferenceType = null,
        System.String? AttributeName = null,
        System.Boolean? IsRecoverySupported = null,
        List<System.String>? LiveValue = null,
        List<System.String>? SnapshotValue = null
    ) 
    {
        if ( DifferenceType != null ) {
            this.DifferenceType = DifferenceType;
        }
        if ( AttributeName != null ) {
            this.AttributeName = AttributeName;
        }
        if ( IsRecoverySupported != null ) {
            this.IsRecoverySupported = IsRecoverySupported;
        }
        if ( LiveValue != null ) {
            this.LiveValue = LiveValue;
        }
        if ( SnapshotValue != null ) {
            this.SnapshotValue = SnapshotValue;
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
        //      C# -> AzureAdObjectAttributeDifferenceEnumType? DifferenceType
        // GraphQL -> differenceType: AzureAdObjectAttributeDifferenceEnumType! (enum)
        if (this.DifferenceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "differenceType\n" ;
            } else {
                s += ind + "differenceType\n" ;
            }
        }
        //      C# -> System.String? AttributeName
        // GraphQL -> attributeName: String! (scalar)
        if (this.AttributeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attributeName\n" ;
            } else {
                s += ind + "attributeName\n" ;
            }
        }
        //      C# -> System.Boolean? IsRecoverySupported
        // GraphQL -> isRecoverySupported: Boolean! (scalar)
        if (this.IsRecoverySupported != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRecoverySupported\n" ;
            } else {
                s += ind + "isRecoverySupported\n" ;
            }
        }
        //      C# -> List<System.String>? LiveValue
        // GraphQL -> liveValue: [String!]! (scalar)
        if (this.LiveValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "liveValue\n" ;
            } else {
                s += ind + "liveValue\n" ;
            }
        }
        //      C# -> List<System.String>? SnapshotValue
        // GraphQL -> snapshotValue: [String!]! (scalar)
        if (this.SnapshotValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotValue\n" ;
            } else {
                s += ind + "snapshotValue\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdObjectAttributeDifferenceEnumType? DifferenceType
        // GraphQL -> differenceType: AzureAdObjectAttributeDifferenceEnumType! (enum)
        if (ec.Includes("differenceType",true))
        {
            if(this.DifferenceType == null) {

                this.DifferenceType = new AzureAdObjectAttributeDifferenceEnumType();

            } else {


            }
        }
        else if (this.DifferenceType != null && ec.Excludes("differenceType",true))
        {
            this.DifferenceType = null;
        }
        //      C# -> System.String? AttributeName
        // GraphQL -> attributeName: String! (scalar)
        if (ec.Includes("attributeName",true))
        {
            if(this.AttributeName == null) {

                this.AttributeName = "FETCH";

            } else {


            }
        }
        else if (this.AttributeName != null && ec.Excludes("attributeName",true))
        {
            this.AttributeName = null;
        }
        //      C# -> System.Boolean? IsRecoverySupported
        // GraphQL -> isRecoverySupported: Boolean! (scalar)
        if (ec.Includes("isRecoverySupported",true))
        {
            if(this.IsRecoverySupported == null) {

                this.IsRecoverySupported = true;

            } else {


            }
        }
        else if (this.IsRecoverySupported != null && ec.Excludes("isRecoverySupported",true))
        {
            this.IsRecoverySupported = null;
        }
        //      C# -> List<System.String>? LiveValue
        // GraphQL -> liveValue: [String!]! (scalar)
        if (ec.Includes("liveValue",true))
        {
            if(this.LiveValue == null) {

                this.LiveValue = new List<System.String>();

            } else {


            }
        }
        else if (this.LiveValue != null && ec.Excludes("liveValue",true))
        {
            this.LiveValue = null;
        }
        //      C# -> List<System.String>? SnapshotValue
        // GraphQL -> snapshotValue: [String!]! (scalar)
        if (ec.Includes("snapshotValue",true))
        {
            if(this.SnapshotValue == null) {

                this.SnapshotValue = new List<System.String>();

            } else {


            }
        }
        else if (this.SnapshotValue != null && ec.Excludes("snapshotValue",true))
        {
            this.SnapshotValue = null;
        }
    }


    #endregion

    } // class AttributeDetails
    
    #endregion

    public static class ListAttributeDetailsExtensions
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
            this List<AttributeDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AttributeDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AttributeDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AttributeDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AttributeDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
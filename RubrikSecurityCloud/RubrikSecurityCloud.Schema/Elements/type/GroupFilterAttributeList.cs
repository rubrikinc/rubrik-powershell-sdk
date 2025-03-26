// GroupFilterAttributeList.cs
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
    #region GroupFilterAttributeList
    public class GroupFilterAttributeList: BaseType
    {
        #region members

        //      C# -> AttributeType? AttributeType
        // GraphQL -> attributeType: AttributeType! (enum)
        [JsonProperty("attributeType")]
        public AttributeType? AttributeType { get; set; }

        //      C# -> AttributeDataType? DataType
        // GraphQL -> dataType: AttributeDataType! (enum)
        [JsonProperty("dataType")]
        public AttributeDataType? DataType { get; set; }

        //      C# -> JoinOpType? FilterOpType
        // GraphQL -> filterOpType: JoinOpType! (enum)
        [JsonProperty("filterOpType")]
        public JoinOpType? FilterOpType { get; set; }

        //      C# -> System.String? AttributeKey
        // GraphQL -> attributeKey: String! (scalar)
        [JsonProperty("attributeKey")]
        public System.String? AttributeKey { get; set; }

        //      C# -> System.String? AttributeValue
        // GraphQL -> attributeValue: String! (scalar)
        [JsonProperty("attributeValue")]
        public System.String? AttributeValue { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GroupFilterAttributeList";
    }

    public GroupFilterAttributeList Set(
        AttributeType? AttributeType = null,
        AttributeDataType? DataType = null,
        JoinOpType? FilterOpType = null,
        System.String? AttributeKey = null,
        System.String? AttributeValue = null,
        System.Boolean? IsArchived = null
    ) 
    {
        if ( AttributeType != null ) {
            this.AttributeType = AttributeType;
        }
        if ( DataType != null ) {
            this.DataType = DataType;
        }
        if ( FilterOpType != null ) {
            this.FilterOpType = FilterOpType;
        }
        if ( AttributeKey != null ) {
            this.AttributeKey = AttributeKey;
        }
        if ( AttributeValue != null ) {
            this.AttributeValue = AttributeValue;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
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
        //      C# -> AttributeType? AttributeType
        // GraphQL -> attributeType: AttributeType! (enum)
        if (this.AttributeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attributeType\n" ;
            } else {
                s += ind + "attributeType\n" ;
            }
        }
        //      C# -> AttributeDataType? DataType
        // GraphQL -> dataType: AttributeDataType! (enum)
        if (this.DataType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataType\n" ;
            } else {
                s += ind + "dataType\n" ;
            }
        }
        //      C# -> JoinOpType? FilterOpType
        // GraphQL -> filterOpType: JoinOpType! (enum)
        if (this.FilterOpType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filterOpType\n" ;
            } else {
                s += ind + "filterOpType\n" ;
            }
        }
        //      C# -> System.String? AttributeKey
        // GraphQL -> attributeKey: String! (scalar)
        if (this.AttributeKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attributeKey\n" ;
            } else {
                s += ind + "attributeKey\n" ;
            }
        }
        //      C# -> System.String? AttributeValue
        // GraphQL -> attributeValue: String! (scalar)
        if (this.AttributeValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attributeValue\n" ;
            } else {
                s += ind + "attributeValue\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AttributeType? AttributeType
        // GraphQL -> attributeType: AttributeType! (enum)
        if (ec.Includes("attributeType",true))
        {
            if(this.AttributeType == null) {

                this.AttributeType = new AttributeType();

            } else {


            }
        }
        else if (this.AttributeType != null && ec.Excludes("attributeType",true))
        {
            this.AttributeType = null;
        }
        //      C# -> AttributeDataType? DataType
        // GraphQL -> dataType: AttributeDataType! (enum)
        if (ec.Includes("dataType",true))
        {
            if(this.DataType == null) {

                this.DataType = new AttributeDataType();

            } else {


            }
        }
        else if (this.DataType != null && ec.Excludes("dataType",true))
        {
            this.DataType = null;
        }
        //      C# -> JoinOpType? FilterOpType
        // GraphQL -> filterOpType: JoinOpType! (enum)
        if (ec.Includes("filterOpType",true))
        {
            if(this.FilterOpType == null) {

                this.FilterOpType = new JoinOpType();

            } else {


            }
        }
        else if (this.FilterOpType != null && ec.Excludes("filterOpType",true))
        {
            this.FilterOpType = null;
        }
        //      C# -> System.String? AttributeKey
        // GraphQL -> attributeKey: String! (scalar)
        if (ec.Includes("attributeKey",true))
        {
            if(this.AttributeKey == null) {

                this.AttributeKey = "FETCH";

            } else {


            }
        }
        else if (this.AttributeKey != null && ec.Excludes("attributeKey",true))
        {
            this.AttributeKey = null;
        }
        //      C# -> System.String? AttributeValue
        // GraphQL -> attributeValue: String! (scalar)
        if (ec.Includes("attributeValue",true))
        {
            if(this.AttributeValue == null) {

                this.AttributeValue = "FETCH";

            } else {


            }
        }
        else if (this.AttributeValue != null && ec.Excludes("attributeValue",true))
        {
            this.AttributeValue = null;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
    }


    #endregion

    } // class GroupFilterAttributeList
    
    #endregion

    public static class ListGroupFilterAttributeListExtensions
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
            this List<GroupFilterAttributeList> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GroupFilterAttributeList> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GroupFilterAttributeList> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GroupFilterAttributeList());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GroupFilterAttributeList> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
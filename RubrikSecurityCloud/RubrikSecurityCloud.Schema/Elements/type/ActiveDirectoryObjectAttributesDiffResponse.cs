// ActiveDirectoryObjectAttributesDiffResponse.cs
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
    #region ActiveDirectoryObjectAttributesDiffResponse
    public class ActiveDirectoryObjectAttributesDiffResponse: BaseType
    {
        #region members

        //      C# -> System.Int32? CountLeft
        // GraphQL -> countLeft: Int! (scalar)
        [JsonProperty("countLeft")]
        public System.Int32? CountLeft { get; set; }

        //      C# -> System.Int32? CountRight
        // GraphQL -> countRight: Int! (scalar)
        [JsonProperty("countRight")]
        public System.Int32? CountRight { get; set; }

        //      C# -> System.Boolean? IsChanged
        // GraphQL -> isChanged: Boolean (scalar)
        [JsonProperty("isChanged")]
        public System.Boolean? IsChanged { get; set; }

        //      C# -> System.Boolean? IsTruncated
        // GraphQL -> isTruncated: Boolean (scalar)
        [JsonProperty("isTruncated")]
        public System.Boolean? IsTruncated { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> ActiveDirectoryObjectAttributeDiffValue? FirstNonNullValues
        // GraphQL -> firstNonNullValues: ActiveDirectoryObjectAttributeDiffValue! (type)
        [JsonProperty("firstNonNullValues")]
        public ActiveDirectoryObjectAttributeDiffValue? FirstNonNullValues { get; set; }

        //      C# -> List<ActiveDirectoryObjectAttributeDiffValue>? Values
        // GraphQL -> values: [ActiveDirectoryObjectAttributeDiffValue!]! (type)
        [JsonProperty("values")]
        public List<ActiveDirectoryObjectAttributeDiffValue>? Values { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectoryObjectAttributesDiffResponse";
    }

    public ActiveDirectoryObjectAttributesDiffResponse Set(
        System.Int32? CountLeft = null,
        System.Int32? CountRight = null,
        System.Boolean? IsChanged = null,
        System.Boolean? IsTruncated = null,
        System.String? Name = null,
        ActiveDirectoryObjectAttributeDiffValue? FirstNonNullValues = null,
        List<ActiveDirectoryObjectAttributeDiffValue>? Values = null
    ) 
    {
        if ( CountLeft != null ) {
            this.CountLeft = CountLeft;
        }
        if ( CountRight != null ) {
            this.CountRight = CountRight;
        }
        if ( IsChanged != null ) {
            this.IsChanged = IsChanged;
        }
        if ( IsTruncated != null ) {
            this.IsTruncated = IsTruncated;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( FirstNonNullValues != null ) {
            this.FirstNonNullValues = FirstNonNullValues;
        }
        if ( Values != null ) {
            this.Values = Values;
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
        //      C# -> System.Int32? CountLeft
        // GraphQL -> countLeft: Int! (scalar)
        if (this.CountLeft != null) {
            if (conf.Flat) {
                s += conf.Prefix + "countLeft\n" ;
            } else {
                s += ind + "countLeft\n" ;
            }
        }
        //      C# -> System.Int32? CountRight
        // GraphQL -> countRight: Int! (scalar)
        if (this.CountRight != null) {
            if (conf.Flat) {
                s += conf.Prefix + "countRight\n" ;
            } else {
                s += ind + "countRight\n" ;
            }
        }
        //      C# -> System.Boolean? IsChanged
        // GraphQL -> isChanged: Boolean (scalar)
        if (this.IsChanged != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isChanged\n" ;
            } else {
                s += ind + "isChanged\n" ;
            }
        }
        //      C# -> System.Boolean? IsTruncated
        // GraphQL -> isTruncated: Boolean (scalar)
        if (this.IsTruncated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isTruncated\n" ;
            } else {
                s += ind + "isTruncated\n" ;
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
        //      C# -> ActiveDirectoryObjectAttributeDiffValue? FirstNonNullValues
        // GraphQL -> firstNonNullValues: ActiveDirectoryObjectAttributeDiffValue! (type)
        if (this.FirstNonNullValues != null) {
            var fspec = this.FirstNonNullValues.AsFieldSpec(conf.Child("firstNonNullValues"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "firstNonNullValues" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ActiveDirectoryObjectAttributeDiffValue>? Values
        // GraphQL -> values: [ActiveDirectoryObjectAttributeDiffValue!]! (type)
        if (this.Values != null) {
            var fspec = this.Values.AsFieldSpec(conf.Child("values"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "values" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? CountLeft
        // GraphQL -> countLeft: Int! (scalar)
        if (ec.Includes("countLeft",true))
        {
            if(this.CountLeft == null) {

                this.CountLeft = Int32.MinValue;

            } else {


            }
        }
        else if (this.CountLeft != null && ec.Excludes("countLeft",true))
        {
            this.CountLeft = null;
        }
        //      C# -> System.Int32? CountRight
        // GraphQL -> countRight: Int! (scalar)
        if (ec.Includes("countRight",true))
        {
            if(this.CountRight == null) {

                this.CountRight = Int32.MinValue;

            } else {


            }
        }
        else if (this.CountRight != null && ec.Excludes("countRight",true))
        {
            this.CountRight = null;
        }
        //      C# -> System.Boolean? IsChanged
        // GraphQL -> isChanged: Boolean (scalar)
        if (ec.Includes("isChanged",true))
        {
            if(this.IsChanged == null) {

                this.IsChanged = true;

            } else {


            }
        }
        else if (this.IsChanged != null && ec.Excludes("isChanged",true))
        {
            this.IsChanged = null;
        }
        //      C# -> System.Boolean? IsTruncated
        // GraphQL -> isTruncated: Boolean (scalar)
        if (ec.Includes("isTruncated",true))
        {
            if(this.IsTruncated == null) {

                this.IsTruncated = true;

            } else {


            }
        }
        else if (this.IsTruncated != null && ec.Excludes("isTruncated",true))
        {
            this.IsTruncated = null;
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
        //      C# -> ActiveDirectoryObjectAttributeDiffValue? FirstNonNullValues
        // GraphQL -> firstNonNullValues: ActiveDirectoryObjectAttributeDiffValue! (type)
        if (ec.Includes("firstNonNullValues",false))
        {
            if(this.FirstNonNullValues == null) {

                this.FirstNonNullValues = new ActiveDirectoryObjectAttributeDiffValue();
                this.FirstNonNullValues.ApplyExploratoryFieldSpec(ec.NewChild("firstNonNullValues"));

            } else {

                this.FirstNonNullValues.ApplyExploratoryFieldSpec(ec.NewChild("firstNonNullValues"));

            }
        }
        else if (this.FirstNonNullValues != null && ec.Excludes("firstNonNullValues",false))
        {
            this.FirstNonNullValues = null;
        }
        //      C# -> List<ActiveDirectoryObjectAttributeDiffValue>? Values
        // GraphQL -> values: [ActiveDirectoryObjectAttributeDiffValue!]! (type)
        if (ec.Includes("values",false))
        {
            if(this.Values == null) {

                this.Values = new List<ActiveDirectoryObjectAttributeDiffValue>();
                this.Values.ApplyExploratoryFieldSpec(ec.NewChild("values"));

            } else {

                this.Values.ApplyExploratoryFieldSpec(ec.NewChild("values"));

            }
        }
        else if (this.Values != null && ec.Excludes("values",false))
        {
            this.Values = null;
        }
    }


    #endregion

    } // class ActiveDirectoryObjectAttributesDiffResponse
    
    #endregion

    public static class ListActiveDirectoryObjectAttributesDiffResponseExtensions
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
            this List<ActiveDirectoryObjectAttributesDiffResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActiveDirectoryObjectAttributesDiffResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectoryObjectAttributesDiffResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectoryObjectAttributesDiffResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectoryObjectAttributesDiffResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
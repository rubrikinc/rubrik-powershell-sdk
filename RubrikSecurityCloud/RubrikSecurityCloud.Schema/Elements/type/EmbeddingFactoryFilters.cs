// EmbeddingFactoryFilters.cs
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
    #region EmbeddingFactoryFilters
    public class EmbeddingFactoryFilters: BaseType
    {
        #region members

        //      C# -> List<System.String>? ExtensionWhitelist
        // GraphQL -> extensionWhitelist: [String!]! (scalar)
        [JsonProperty("extensionWhitelist")]
        public List<System.String>? ExtensionWhitelist { get; set; }

        //      C# -> List<System.String>? SensitiveDataPolicyIds
        // GraphQL -> sensitiveDataPolicyIds: [UUID!]! (scalar)
        [JsonProperty("sensitiveDataPolicyIds")]
        public List<System.String>? SensitiveDataPolicyIds { get; set; }

        //      C# -> ChatbotTimeRangeFilterType? ModifiedTimeRange
        // GraphQL -> modifiedTimeRange: ChatbotTimeRangeFilterType (type)
        [JsonProperty("modifiedTimeRange")]
        public ChatbotTimeRangeFilterType? ModifiedTimeRange { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EmbeddingFactoryFilters";
    }

    public EmbeddingFactoryFilters Set(
        List<System.String>? ExtensionWhitelist = null,
        List<System.String>? SensitiveDataPolicyIds = null,
        ChatbotTimeRangeFilterType? ModifiedTimeRange = null
    ) 
    {
        if ( ExtensionWhitelist != null ) {
            this.ExtensionWhitelist = ExtensionWhitelist;
        }
        if ( SensitiveDataPolicyIds != null ) {
            this.SensitiveDataPolicyIds = SensitiveDataPolicyIds;
        }
        if ( ModifiedTimeRange != null ) {
            this.ModifiedTimeRange = ModifiedTimeRange;
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
        //      C# -> List<System.String>? ExtensionWhitelist
        // GraphQL -> extensionWhitelist: [String!]! (scalar)
        if (this.ExtensionWhitelist != null) {
            if (conf.Flat) {
                s += conf.Prefix + "extensionWhitelist\n" ;
            } else {
                s += ind + "extensionWhitelist\n" ;
            }
        }
        //      C# -> List<System.String>? SensitiveDataPolicyIds
        // GraphQL -> sensitiveDataPolicyIds: [UUID!]! (scalar)
        if (this.SensitiveDataPolicyIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sensitiveDataPolicyIds\n" ;
            } else {
                s += ind + "sensitiveDataPolicyIds\n" ;
            }
        }
        //      C# -> ChatbotTimeRangeFilterType? ModifiedTimeRange
        // GraphQL -> modifiedTimeRange: ChatbotTimeRangeFilterType (type)
        if (this.ModifiedTimeRange != null) {
            var fspec = this.ModifiedTimeRange.AsFieldSpec(conf.Child("modifiedTimeRange"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "modifiedTimeRange" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? ExtensionWhitelist
        // GraphQL -> extensionWhitelist: [String!]! (scalar)
        if (ec.Includes("extensionWhitelist",true))
        {
            if(this.ExtensionWhitelist == null) {

                this.ExtensionWhitelist = new List<System.String>();

            } else {


            }
        }
        else if (this.ExtensionWhitelist != null && ec.Excludes("extensionWhitelist",true))
        {
            this.ExtensionWhitelist = null;
        }
        //      C# -> List<System.String>? SensitiveDataPolicyIds
        // GraphQL -> sensitiveDataPolicyIds: [UUID!]! (scalar)
        if (ec.Includes("sensitiveDataPolicyIds",true))
        {
            if(this.SensitiveDataPolicyIds == null) {

                this.SensitiveDataPolicyIds = new List<System.String>();

            } else {


            }
        }
        else if (this.SensitiveDataPolicyIds != null && ec.Excludes("sensitiveDataPolicyIds",true))
        {
            this.SensitiveDataPolicyIds = null;
        }
        //      C# -> ChatbotTimeRangeFilterType? ModifiedTimeRange
        // GraphQL -> modifiedTimeRange: ChatbotTimeRangeFilterType (type)
        if (ec.Includes("modifiedTimeRange",false))
        {
            if(this.ModifiedTimeRange == null) {

                this.ModifiedTimeRange = new ChatbotTimeRangeFilterType();
                this.ModifiedTimeRange.ApplyExploratoryFieldSpec(ec.NewChild("modifiedTimeRange"));

            } else {

                this.ModifiedTimeRange.ApplyExploratoryFieldSpec(ec.NewChild("modifiedTimeRange"));

            }
        }
        else if (this.ModifiedTimeRange != null && ec.Excludes("modifiedTimeRange",false))
        {
            this.ModifiedTimeRange = null;
        }
    }


    #endregion

    } // class EmbeddingFactoryFilters
    
    #endregion

    public static class ListEmbeddingFactoryFiltersExtensions
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
            this List<EmbeddingFactoryFilters> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EmbeddingFactoryFilters> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EmbeddingFactoryFilters> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EmbeddingFactoryFilters());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EmbeddingFactoryFilters> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
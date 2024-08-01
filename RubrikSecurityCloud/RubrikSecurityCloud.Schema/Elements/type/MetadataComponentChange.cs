// MetadataComponentChange.cs
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
    #region MetadataComponentChange
    public class MetadataComponentChange: BaseType
    {
        #region members

        //      C# -> AppItemActionType? Action
        // GraphQL -> action: AppItemActionType! (enum)
        [JsonProperty("action")]
        public AppItemActionType? Action { get; set; }

        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        [JsonProperty("appItemTypeToken")]
        public System.String? AppItemTypeToken { get; set; }

        //      C# -> System.String? ComponentId
        // GraphQL -> componentId: String! (scalar)
        [JsonProperty("componentId")]
        public System.String? ComponentId { get; set; }

        //      C# -> System.String? ComponentName
        // GraphQL -> componentName: String! (scalar)
        [JsonProperty("componentName")]
        public System.String? ComponentName { get; set; }

        //      C# -> System.String? LastModifiedBy
        // GraphQL -> lastModifiedBy: String! (scalar)
        [JsonProperty("lastModifiedBy")]
        public System.String? LastModifiedBy { get; set; }

        //      C# -> LineChangeSummary? LineChangeSummary
        // GraphQL -> lineChangeSummary: LineChangeSummary (type)
        [JsonProperty("lineChangeSummary")]
        public LineChangeSummary? LineChangeSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MetadataComponentChange";
    }

    public MetadataComponentChange Set(
        AppItemActionType? Action = null,
        System.String? AppItemTypeToken = null,
        System.String? ComponentId = null,
        System.String? ComponentName = null,
        System.String? LastModifiedBy = null,
        LineChangeSummary? LineChangeSummary = null
    ) 
    {
        if ( Action != null ) {
            this.Action = Action;
        }
        if ( AppItemTypeToken != null ) {
            this.AppItemTypeToken = AppItemTypeToken;
        }
        if ( ComponentId != null ) {
            this.ComponentId = ComponentId;
        }
        if ( ComponentName != null ) {
            this.ComponentName = ComponentName;
        }
        if ( LastModifiedBy != null ) {
            this.LastModifiedBy = LastModifiedBy;
        }
        if ( LineChangeSummary != null ) {
            this.LineChangeSummary = LineChangeSummary;
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
        //      C# -> AppItemActionType? Action
        // GraphQL -> action: AppItemActionType! (enum)
        if (this.Action != null) {
            if (conf.Flat) {
                s += conf.Prefix + "action\n" ;
            } else {
                s += ind + "action\n" ;
            }
        }
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (this.AppItemTypeToken != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appItemTypeToken\n" ;
            } else {
                s += ind + "appItemTypeToken\n" ;
            }
        }
        //      C# -> System.String? ComponentId
        // GraphQL -> componentId: String! (scalar)
        if (this.ComponentId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "componentId\n" ;
            } else {
                s += ind + "componentId\n" ;
            }
        }
        //      C# -> System.String? ComponentName
        // GraphQL -> componentName: String! (scalar)
        if (this.ComponentName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "componentName\n" ;
            } else {
                s += ind + "componentName\n" ;
            }
        }
        //      C# -> System.String? LastModifiedBy
        // GraphQL -> lastModifiedBy: String! (scalar)
        if (this.LastModifiedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastModifiedBy\n" ;
            } else {
                s += ind + "lastModifiedBy\n" ;
            }
        }
        //      C# -> LineChangeSummary? LineChangeSummary
        // GraphQL -> lineChangeSummary: LineChangeSummary (type)
        if (this.LineChangeSummary != null) {
            var fspec = this.LineChangeSummary.AsFieldSpec(conf.Child("lineChangeSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lineChangeSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AppItemActionType? Action
        // GraphQL -> action: AppItemActionType! (enum)
        if (ec.Includes("action",true))
        {
            if(this.Action == null) {

                this.Action = new AppItemActionType();

            } else {


            }
        }
        else if (this.Action != null && ec.Excludes("action",true))
        {
            this.Action = null;
        }
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (ec.Includes("appItemTypeToken",true))
        {
            if(this.AppItemTypeToken == null) {

                this.AppItemTypeToken = "FETCH";

            } else {


            }
        }
        else if (this.AppItemTypeToken != null && ec.Excludes("appItemTypeToken",true))
        {
            this.AppItemTypeToken = null;
        }
        //      C# -> System.String? ComponentId
        // GraphQL -> componentId: String! (scalar)
        if (ec.Includes("componentId",true))
        {
            if(this.ComponentId == null) {

                this.ComponentId = "FETCH";

            } else {


            }
        }
        else if (this.ComponentId != null && ec.Excludes("componentId",true))
        {
            this.ComponentId = null;
        }
        //      C# -> System.String? ComponentName
        // GraphQL -> componentName: String! (scalar)
        if (ec.Includes("componentName",true))
        {
            if(this.ComponentName == null) {

                this.ComponentName = "FETCH";

            } else {


            }
        }
        else if (this.ComponentName != null && ec.Excludes("componentName",true))
        {
            this.ComponentName = null;
        }
        //      C# -> System.String? LastModifiedBy
        // GraphQL -> lastModifiedBy: String! (scalar)
        if (ec.Includes("lastModifiedBy",true))
        {
            if(this.LastModifiedBy == null) {

                this.LastModifiedBy = "FETCH";

            } else {


            }
        }
        else if (this.LastModifiedBy != null && ec.Excludes("lastModifiedBy",true))
        {
            this.LastModifiedBy = null;
        }
        //      C# -> LineChangeSummary? LineChangeSummary
        // GraphQL -> lineChangeSummary: LineChangeSummary (type)
        if (ec.Includes("lineChangeSummary",false))
        {
            if(this.LineChangeSummary == null) {

                this.LineChangeSummary = new LineChangeSummary();
                this.LineChangeSummary.ApplyExploratoryFieldSpec(ec.NewChild("lineChangeSummary"));

            } else {

                this.LineChangeSummary.ApplyExploratoryFieldSpec(ec.NewChild("lineChangeSummary"));

            }
        }
        else if (this.LineChangeSummary != null && ec.Excludes("lineChangeSummary",false))
        {
            this.LineChangeSummary = null;
        }
    }


    #endregion

    } // class MetadataComponentChange
    
    #endregion

    public static class ListMetadataComponentChangeExtensions
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
            this List<MetadataComponentChange> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MetadataComponentChange> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MetadataComponentChange> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MetadataComponentChange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MetadataComponentChange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
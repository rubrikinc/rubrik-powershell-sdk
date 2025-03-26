// TagRuleEffectiveSla.cs
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
    #region TagRuleEffectiveSla
    public class TagRuleEffectiveSla: BaseType
    {
        #region members

        //      C# -> RetentionLockMode? RetentionLockMode
        // GraphQL -> retentionLockMode: RetentionLockMode! (enum)
        [JsonProperty("retentionLockMode")]
        public RetentionLockMode? RetentionLockMode { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsRetentionLockedSla
        // GraphQL -> isRetentionLockedSla: Boolean! (scalar)
        [JsonProperty("isRetentionLockedSla")]
        public System.Boolean? IsRetentionLockedSla { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TagRuleEffectiveSla";
    }

    public TagRuleEffectiveSla Set(
        RetentionLockMode? RetentionLockMode = null,
        System.String? Id = null,
        System.Boolean? IsRetentionLockedSla = null,
        System.String? Name = null
    ) 
    {
        if ( RetentionLockMode != null ) {
            this.RetentionLockMode = RetentionLockMode;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsRetentionLockedSla != null ) {
            this.IsRetentionLockedSla = IsRetentionLockedSla;
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
        //      C# -> RetentionLockMode? RetentionLockMode
        // GraphQL -> retentionLockMode: RetentionLockMode! (enum)
        if (this.RetentionLockMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "retentionLockMode\n" ;
            } else {
                s += ind + "retentionLockMode\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsRetentionLockedSla
        // GraphQL -> isRetentionLockedSla: Boolean! (scalar)
        if (this.IsRetentionLockedSla != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRetentionLockedSla\n" ;
            } else {
                s += ind + "isRetentionLockedSla\n" ;
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
        //      C# -> RetentionLockMode? RetentionLockMode
        // GraphQL -> retentionLockMode: RetentionLockMode! (enum)
        if (ec.Includes("retentionLockMode",true))
        {
            if(this.RetentionLockMode == null) {

                this.RetentionLockMode = new RetentionLockMode();

            } else {


            }
        }
        else if (this.RetentionLockMode != null && ec.Excludes("retentionLockMode",true))
        {
            this.RetentionLockMode = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> System.Boolean? IsRetentionLockedSla
        // GraphQL -> isRetentionLockedSla: Boolean! (scalar)
        if (ec.Includes("isRetentionLockedSla",true))
        {
            if(this.IsRetentionLockedSla == null) {

                this.IsRetentionLockedSla = true;

            } else {


            }
        }
        else if (this.IsRetentionLockedSla != null && ec.Excludes("isRetentionLockedSla",true))
        {
            this.IsRetentionLockedSla = null;
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

    } // class TagRuleEffectiveSla
    
    #endregion

    public static class ListTagRuleEffectiveSlaExtensions
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
            this List<TagRuleEffectiveSla> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TagRuleEffectiveSla> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TagRuleEffectiveSla> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TagRuleEffectiveSla());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TagRuleEffectiveSla> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
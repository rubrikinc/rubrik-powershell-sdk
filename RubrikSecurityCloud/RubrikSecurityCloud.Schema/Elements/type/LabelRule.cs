// LabelRule.cs
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
    #region LabelRule
    public class LabelRule: BaseType
    {
        #region members

        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        [JsonProperty("objectType")]
        public ManagedObjectType? ObjectType { get; set; }

        //      C# -> System.Boolean? ApplyToAllCloudAccounts
        // GraphQL -> applyToAllCloudAccounts: Boolean! (scalar)
        [JsonProperty("applyToAllCloudAccounts")]
        public System.Boolean? ApplyToAllCloudAccounts { get; set; }

        //      C# -> System.Boolean? HasPermissionToModify
        // GraphQL -> hasPermissionToModify: Boolean! (scalar)
        [JsonProperty("hasPermissionToModify")]
        public System.Boolean? HasPermissionToModify { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<CloudNativeAccountIdWithName>? CloudNativeAccounts
        // GraphQL -> cloudNativeAccounts: [CloudNativeAccountIdWithName!]! (type)
        [JsonProperty("cloudNativeAccounts")]
        public List<CloudNativeAccountIdWithName>? CloudNativeAccounts { get; set; }

        //      C# -> TagRuleEffectiveSla? EffectiveSla
        // GraphQL -> effectiveSla: TagRuleEffectiveSla (type)
        [JsonProperty("effectiveSla")]
        public TagRuleEffectiveSla? EffectiveSla { get; set; }

        //      C# -> CloudNativeLabel? Label
        // GraphQL -> label: CloudNativeLabel (type)
        [JsonProperty("label")]
        public CloudNativeLabel? Label { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LabelRule";
    }

    public LabelRule Set(
        ManagedObjectType? ObjectType = null,
        System.Boolean? ApplyToAllCloudAccounts = null,
        System.Boolean? HasPermissionToModify = null,
        System.String? Id = null,
        System.String? Name = null,
        List<CloudNativeAccountIdWithName>? CloudNativeAccounts = null,
        TagRuleEffectiveSla? EffectiveSla = null,
        CloudNativeLabel? Label = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( ApplyToAllCloudAccounts != null ) {
            this.ApplyToAllCloudAccounts = ApplyToAllCloudAccounts;
        }
        if ( HasPermissionToModify != null ) {
            this.HasPermissionToModify = HasPermissionToModify;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( CloudNativeAccounts != null ) {
            this.CloudNativeAccounts = CloudNativeAccounts;
        }
        if ( EffectiveSla != null ) {
            this.EffectiveSla = EffectiveSla;
        }
        if ( Label != null ) {
            this.Label = Label;
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
        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> System.Boolean? ApplyToAllCloudAccounts
        // GraphQL -> applyToAllCloudAccounts: Boolean! (scalar)
        if (this.ApplyToAllCloudAccounts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applyToAllCloudAccounts\n" ;
            } else {
                s += ind + "applyToAllCloudAccounts\n" ;
            }
        }
        //      C# -> System.Boolean? HasPermissionToModify
        // GraphQL -> hasPermissionToModify: Boolean! (scalar)
        if (this.HasPermissionToModify != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasPermissionToModify\n" ;
            } else {
                s += ind + "hasPermissionToModify\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> List<CloudNativeAccountIdWithName>? CloudNativeAccounts
        // GraphQL -> cloudNativeAccounts: [CloudNativeAccountIdWithName!]! (type)
        if (this.CloudNativeAccounts != null) {
            var fspec = this.CloudNativeAccounts.AsFieldSpec(conf.Child("cloudNativeAccounts"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudNativeAccounts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TagRuleEffectiveSla? EffectiveSla
        // GraphQL -> effectiveSla: TagRuleEffectiveSla (type)
        if (this.EffectiveSla != null) {
            var fspec = this.EffectiveSla.AsFieldSpec(conf.Child("effectiveSla"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSla" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudNativeLabel? Label
        // GraphQL -> label: CloudNativeLabel (type)
        if (this.Label != null) {
            var fspec = this.Label.AsFieldSpec(conf.Child("label"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "label" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new ManagedObjectType();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> System.Boolean? ApplyToAllCloudAccounts
        // GraphQL -> applyToAllCloudAccounts: Boolean! (scalar)
        if (ec.Includes("applyToAllCloudAccounts",true))
        {
            if(this.ApplyToAllCloudAccounts == null) {

                this.ApplyToAllCloudAccounts = true;

            } else {


            }
        }
        else if (this.ApplyToAllCloudAccounts != null && ec.Excludes("applyToAllCloudAccounts",true))
        {
            this.ApplyToAllCloudAccounts = null;
        }
        //      C# -> System.Boolean? HasPermissionToModify
        // GraphQL -> hasPermissionToModify: Boolean! (scalar)
        if (ec.Includes("hasPermissionToModify",true))
        {
            if(this.HasPermissionToModify == null) {

                this.HasPermissionToModify = true;

            } else {


            }
        }
        else if (this.HasPermissionToModify != null && ec.Excludes("hasPermissionToModify",true))
        {
            this.HasPermissionToModify = null;
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
        //      C# -> List<CloudNativeAccountIdWithName>? CloudNativeAccounts
        // GraphQL -> cloudNativeAccounts: [CloudNativeAccountIdWithName!]! (type)
        if (ec.Includes("cloudNativeAccounts",false))
        {
            if(this.CloudNativeAccounts == null) {

                this.CloudNativeAccounts = new List<CloudNativeAccountIdWithName>();
                this.CloudNativeAccounts.ApplyExploratoryFieldSpec(ec.NewChild("cloudNativeAccounts"));

            } else {

                this.CloudNativeAccounts.ApplyExploratoryFieldSpec(ec.NewChild("cloudNativeAccounts"));

            }
        }
        else if (this.CloudNativeAccounts != null && ec.Excludes("cloudNativeAccounts",false))
        {
            this.CloudNativeAccounts = null;
        }
        //      C# -> TagRuleEffectiveSla? EffectiveSla
        // GraphQL -> effectiveSla: TagRuleEffectiveSla (type)
        if (ec.Includes("effectiveSla",false))
        {
            if(this.EffectiveSla == null) {

                this.EffectiveSla = new TagRuleEffectiveSla();
                this.EffectiveSla.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSla"));

            } else {

                this.EffectiveSla.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSla"));

            }
        }
        else if (this.EffectiveSla != null && ec.Excludes("effectiveSla",false))
        {
            this.EffectiveSla = null;
        }
        //      C# -> CloudNativeLabel? Label
        // GraphQL -> label: CloudNativeLabel (type)
        if (ec.Includes("label",false))
        {
            if(this.Label == null) {

                this.Label = new CloudNativeLabel();
                this.Label.ApplyExploratoryFieldSpec(ec.NewChild("label"));

            } else {

                this.Label.ApplyExploratoryFieldSpec(ec.NewChild("label"));

            }
        }
        else if (this.Label != null && ec.Excludes("label",false))
        {
            this.Label = null;
        }
    }


    #endregion

    } // class LabelRule
    
    #endregion

    public static class ListLabelRuleExtensions
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
            this List<LabelRule> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LabelRule> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LabelRule> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LabelRule());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LabelRule> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
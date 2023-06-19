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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> System.Boolean? ApplyToAllCloudAccounts
        // GraphQL -> applyToAllCloudAccounts: Boolean! (scalar)
        if (this.ApplyToAllCloudAccounts != null) {
            s += ind + "applyToAllCloudAccounts\n" ;
        }
        //      C# -> System.Boolean? HasPermissionToModify
        // GraphQL -> hasPermissionToModify: Boolean! (scalar)
        if (this.HasPermissionToModify != null) {
            s += ind + "hasPermissionToModify\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> List<CloudNativeAccountIdWithName>? CloudNativeAccounts
        // GraphQL -> cloudNativeAccounts: [CloudNativeAccountIdWithName!]! (type)
        if (this.CloudNativeAccounts != null) {
            var fspec = this.CloudNativeAccounts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cloudNativeAccounts {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> TagRuleEffectiveSla? EffectiveSla
        // GraphQL -> effectiveSla: TagRuleEffectiveSla (type)
        if (this.EffectiveSla != null) {
            var fspec = this.EffectiveSla.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveSla {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CloudNativeLabel? Label
        // GraphQL -> label: CloudNativeLabel (type)
        if (this.Label != null) {
            var fspec = this.Label.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "label {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new ManagedObjectType();
        }
        //      C# -> System.Boolean? ApplyToAllCloudAccounts
        // GraphQL -> applyToAllCloudAccounts: Boolean! (scalar)
        if (this.ApplyToAllCloudAccounts == null && Exploration.Includes(parent + ".applyToAllCloudAccounts", true))
        {
            this.ApplyToAllCloudAccounts = true;
        }
        //      C# -> System.Boolean? HasPermissionToModify
        // GraphQL -> hasPermissionToModify: Boolean! (scalar)
        if (this.HasPermissionToModify == null && Exploration.Includes(parent + ".hasPermissionToModify", true))
        {
            this.HasPermissionToModify = true;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> List<CloudNativeAccountIdWithName>? CloudNativeAccounts
        // GraphQL -> cloudNativeAccounts: [CloudNativeAccountIdWithName!]! (type)
        if (this.CloudNativeAccounts == null && Exploration.Includes(parent + ".cloudNativeAccounts"))
        {
            this.CloudNativeAccounts = new List<CloudNativeAccountIdWithName>();
            this.CloudNativeAccounts.ApplyExploratoryFieldSpec(parent + ".cloudNativeAccounts");
        }
        //      C# -> TagRuleEffectiveSla? EffectiveSla
        // GraphQL -> effectiveSla: TagRuleEffectiveSla (type)
        if (this.EffectiveSla == null && Exploration.Includes(parent + ".effectiveSla"))
        {
            this.EffectiveSla = new TagRuleEffectiveSla();
            this.EffectiveSla.ApplyExploratoryFieldSpec(parent + ".effectiveSla");
        }
        //      C# -> CloudNativeLabel? Label
        // GraphQL -> label: CloudNativeLabel (type)
        if (this.Label == null && Exploration.Includes(parent + ".label"))
        {
            this.Label = new CloudNativeLabel();
            this.Label.ApplyExploratoryFieldSpec(parent + ".label");
        }
    }


    #endregion

    } // class LabelRule
    
    #endregion

    public static class ListLabelRuleExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<LabelRule> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LabelRule> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new LabelRule());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
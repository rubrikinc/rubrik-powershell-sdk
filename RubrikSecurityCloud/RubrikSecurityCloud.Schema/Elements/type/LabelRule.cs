// LabelRule.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:19.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region LabelRule
    public class LabelRule: IFragment
    {
        #region members
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

        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        [JsonProperty("objectType")]
        public ManagedObjectType? ObjectType { get; set; }

        #endregion

    #region methods

    public LabelRule Set(
        System.Boolean? ApplyToAllCloudAccounts = null,
        System.Boolean? HasPermissionToModify = null,
        System.String? Id = null,
        System.String? Name = null,
        List<CloudNativeAccountIdWithName>? CloudNativeAccounts = null,
        TagRuleEffectiveSla? EffectiveSla = null,
        CloudNativeLabel? Label = null,
        ManagedObjectType? ObjectType = null
    ) 
    {
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
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Boolean? ApplyToAllCloudAccounts
            // GraphQL -> applyToAllCloudAccounts: Boolean! (scalar)
            if (this.ApplyToAllCloudAccounts != null)
            {
                 s += ind + "applyToAllCloudAccounts\n";

            }
            //      C# -> System.Boolean? HasPermissionToModify
            // GraphQL -> hasPermissionToModify: Boolean! (scalar)
            if (this.HasPermissionToModify != null)
            {
                 s += ind + "hasPermissionToModify\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> List<CloudNativeAccountIdWithName>? CloudNativeAccounts
            // GraphQL -> cloudNativeAccounts: [CloudNativeAccountIdWithName!]! (type)
            if (this.CloudNativeAccounts != null)
            {
                 s += ind + "cloudNativeAccounts\n";

                 s += ind + "{\n" + 
                 this.CloudNativeAccounts.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> TagRuleEffectiveSla? EffectiveSla
            // GraphQL -> effectiveSla: TagRuleEffectiveSla (type)
            if (this.EffectiveSla != null)
            {
                 s += ind + "effectiveSla\n";

                 s += ind + "{\n" + 
                 this.EffectiveSla.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CloudNativeLabel? Label
            // GraphQL -> label: CloudNativeLabel (type)
            if (this.Label != null)
            {
                 s += ind + "label\n";

                 s += ind + "{\n" + 
                 this.Label.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedObjectType? ObjectType
            // GraphQL -> objectType: ManagedObjectType! (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? ApplyToAllCloudAccounts
            // GraphQL -> applyToAllCloudAccounts: Boolean! (scalar)
            if (this.ApplyToAllCloudAccounts == null && Exploration.Includes(parent + ".applyToAllCloudAccounts$"))
            {
                this.ApplyToAllCloudAccounts = new System.Boolean();
            }
            //      C# -> System.Boolean? HasPermissionToModify
            // GraphQL -> hasPermissionToModify: Boolean! (scalar)
            if (this.HasPermissionToModify == null && Exploration.Includes(parent + ".hasPermissionToModify$"))
            {
                this.HasPermissionToModify = new System.Boolean();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> List<CloudNativeAccountIdWithName>? CloudNativeAccounts
            // GraphQL -> cloudNativeAccounts: [CloudNativeAccountIdWithName!]! (type)
            if (this.CloudNativeAccounts == null && Exploration.Includes(parent + ".cloudNativeAccounts"))
            {
                this.CloudNativeAccounts = new List<CloudNativeAccountIdWithName>();
                this.CloudNativeAccounts.ApplyExploratoryFragment(parent + ".cloudNativeAccounts");
            }
            //      C# -> TagRuleEffectiveSla? EffectiveSla
            // GraphQL -> effectiveSla: TagRuleEffectiveSla (type)
            if (this.EffectiveSla == null && Exploration.Includes(parent + ".effectiveSla"))
            {
                this.EffectiveSla = new TagRuleEffectiveSla();
                this.EffectiveSla.ApplyExploratoryFragment(parent + ".effectiveSla");
            }
            //      C# -> CloudNativeLabel? Label
            // GraphQL -> label: CloudNativeLabel (type)
            if (this.Label == null && Exploration.Includes(parent + ".label"))
            {
                this.Label = new CloudNativeLabel();
                this.Label.ApplyExploratoryFragment(parent + ".label");
            }
            //      C# -> ManagedObjectType? ObjectType
            // GraphQL -> objectType: ManagedObjectType! (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new ManagedObjectType();
            }
        }


    #endregion

    } // class LabelRule
    #endregion

    public static class ListLabelRuleExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<LabelRule> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<LabelRule> list, 
            String parent = "")
        {
            var item = new LabelRule();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
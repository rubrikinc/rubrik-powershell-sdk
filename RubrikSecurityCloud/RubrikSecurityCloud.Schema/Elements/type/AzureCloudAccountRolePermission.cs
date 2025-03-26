// AzureCloudAccountRolePermission.cs
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
    #region AzureCloudAccountRolePermission
    public class AzureCloudAccountRolePermission: BaseType
    {
        #region members

        //      C# -> List<System.String>? ExcludedActions
        // GraphQL -> excludedActions: [String!]! (scalar)
        [JsonProperty("excludedActions")]
        public List<System.String>? ExcludedActions { get; set; }

        //      C# -> List<System.String>? ExcludedDataActions
        // GraphQL -> excludedDataActions: [String!]! (scalar)
        [JsonProperty("excludedDataActions")]
        public List<System.String>? ExcludedDataActions { get; set; }

        //      C# -> List<System.String>? IncludedActions
        // GraphQL -> includedActions: [String!]! (scalar)
        [JsonProperty("includedActions")]
        public List<System.String>? IncludedActions { get; set; }

        //      C# -> List<System.String>? IncludedDataActions
        // GraphQL -> includedDataActions: [String!]! (scalar)
        [JsonProperty("includedDataActions")]
        public List<System.String>? IncludedDataActions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureCloudAccountRolePermission";
    }

    public AzureCloudAccountRolePermission Set(
        List<System.String>? ExcludedActions = null,
        List<System.String>? ExcludedDataActions = null,
        List<System.String>? IncludedActions = null,
        List<System.String>? IncludedDataActions = null
    ) 
    {
        if ( ExcludedActions != null ) {
            this.ExcludedActions = ExcludedActions;
        }
        if ( ExcludedDataActions != null ) {
            this.ExcludedDataActions = ExcludedDataActions;
        }
        if ( IncludedActions != null ) {
            this.IncludedActions = IncludedActions;
        }
        if ( IncludedDataActions != null ) {
            this.IncludedDataActions = IncludedDataActions;
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
        //      C# -> List<System.String>? ExcludedActions
        // GraphQL -> excludedActions: [String!]! (scalar)
        if (this.ExcludedActions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "excludedActions\n" ;
            } else {
                s += ind + "excludedActions\n" ;
            }
        }
        //      C# -> List<System.String>? ExcludedDataActions
        // GraphQL -> excludedDataActions: [String!]! (scalar)
        if (this.ExcludedDataActions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "excludedDataActions\n" ;
            } else {
                s += ind + "excludedDataActions\n" ;
            }
        }
        //      C# -> List<System.String>? IncludedActions
        // GraphQL -> includedActions: [String!]! (scalar)
        if (this.IncludedActions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "includedActions\n" ;
            } else {
                s += ind + "includedActions\n" ;
            }
        }
        //      C# -> List<System.String>? IncludedDataActions
        // GraphQL -> includedDataActions: [String!]! (scalar)
        if (this.IncludedDataActions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "includedDataActions\n" ;
            } else {
                s += ind + "includedDataActions\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? ExcludedActions
        // GraphQL -> excludedActions: [String!]! (scalar)
        if (ec.Includes("excludedActions",true))
        {
            if(this.ExcludedActions == null) {

                this.ExcludedActions = new List<System.String>();

            } else {


            }
        }
        else if (this.ExcludedActions != null && ec.Excludes("excludedActions",true))
        {
            this.ExcludedActions = null;
        }
        //      C# -> List<System.String>? ExcludedDataActions
        // GraphQL -> excludedDataActions: [String!]! (scalar)
        if (ec.Includes("excludedDataActions",true))
        {
            if(this.ExcludedDataActions == null) {

                this.ExcludedDataActions = new List<System.String>();

            } else {


            }
        }
        else if (this.ExcludedDataActions != null && ec.Excludes("excludedDataActions",true))
        {
            this.ExcludedDataActions = null;
        }
        //      C# -> List<System.String>? IncludedActions
        // GraphQL -> includedActions: [String!]! (scalar)
        if (ec.Includes("includedActions",true))
        {
            if(this.IncludedActions == null) {

                this.IncludedActions = new List<System.String>();

            } else {


            }
        }
        else if (this.IncludedActions != null && ec.Excludes("includedActions",true))
        {
            this.IncludedActions = null;
        }
        //      C# -> List<System.String>? IncludedDataActions
        // GraphQL -> includedDataActions: [String!]! (scalar)
        if (ec.Includes("includedDataActions",true))
        {
            if(this.IncludedDataActions == null) {

                this.IncludedDataActions = new List<System.String>();

            } else {


            }
        }
        else if (this.IncludedDataActions != null && ec.Excludes("includedDataActions",true))
        {
            this.IncludedDataActions = null;
        }
    }


    #endregion

    } // class AzureCloudAccountRolePermission
    
    #endregion

    public static class ListAzureCloudAccountRolePermissionExtensions
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
            this List<AzureCloudAccountRolePermission> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureCloudAccountRolePermission> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureCloudAccountRolePermission> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCloudAccountRolePermission());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureCloudAccountRolePermission> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
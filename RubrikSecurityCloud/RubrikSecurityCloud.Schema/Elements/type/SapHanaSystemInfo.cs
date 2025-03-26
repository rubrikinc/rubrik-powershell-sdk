// SapHanaSystemInfo.cs
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
    #region SapHanaSystemInfo
    public class SapHanaSystemInfo: BaseType
    {
        #region members

        //      C# -> System.String? AzureFeatureId
        // GraphQL -> azureFeatureId: String (scalar)
        [JsonProperty("azureFeatureId")]
        public System.String? AzureFeatureId { get; set; }

        //      C# -> System.String? HanaVersion
        // GraphQL -> hanaVersion: String! (scalar)
        [JsonProperty("hanaVersion")]
        public System.String? HanaVersion { get; set; }

        //      C# -> System.Boolean? IsSystemReplicationEnabled
        // GraphQL -> isSystemReplicationEnabled: Boolean! (scalar)
        [JsonProperty("isSystemReplicationEnabled")]
        public System.Boolean? IsSystemReplicationEnabled { get; set; }

        //      C# -> SapHanaSystemAuthTypeSpec? AuthTypeSpec
        // GraphQL -> authTypeSpec: SapHanaSystemAuthTypeSpec (type)
        [JsonProperty("authTypeSpec")]
        public SapHanaSystemAuthTypeSpec? AuthTypeSpec { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaSystemInfo";
    }

    public SapHanaSystemInfo Set(
        System.String? AzureFeatureId = null,
        System.String? HanaVersion = null,
        System.Boolean? IsSystemReplicationEnabled = null,
        SapHanaSystemAuthTypeSpec? AuthTypeSpec = null
    ) 
    {
        if ( AzureFeatureId != null ) {
            this.AzureFeatureId = AzureFeatureId;
        }
        if ( HanaVersion != null ) {
            this.HanaVersion = HanaVersion;
        }
        if ( IsSystemReplicationEnabled != null ) {
            this.IsSystemReplicationEnabled = IsSystemReplicationEnabled;
        }
        if ( AuthTypeSpec != null ) {
            this.AuthTypeSpec = AuthTypeSpec;
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
        //      C# -> System.String? AzureFeatureId
        // GraphQL -> azureFeatureId: String (scalar)
        if (this.AzureFeatureId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureFeatureId\n" ;
            } else {
                s += ind + "azureFeatureId\n" ;
            }
        }
        //      C# -> System.String? HanaVersion
        // GraphQL -> hanaVersion: String! (scalar)
        if (this.HanaVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hanaVersion\n" ;
            } else {
                s += ind + "hanaVersion\n" ;
            }
        }
        //      C# -> System.Boolean? IsSystemReplicationEnabled
        // GraphQL -> isSystemReplicationEnabled: Boolean! (scalar)
        if (this.IsSystemReplicationEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSystemReplicationEnabled\n" ;
            } else {
                s += ind + "isSystemReplicationEnabled\n" ;
            }
        }
        //      C# -> SapHanaSystemAuthTypeSpec? AuthTypeSpec
        // GraphQL -> authTypeSpec: SapHanaSystemAuthTypeSpec (type)
        if (this.AuthTypeSpec != null) {
            var fspec = this.AuthTypeSpec.AsFieldSpec(conf.Child("authTypeSpec"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "authTypeSpec" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AzureFeatureId
        // GraphQL -> azureFeatureId: String (scalar)
        if (ec.Includes("azureFeatureId",true))
        {
            if(this.AzureFeatureId == null) {

                this.AzureFeatureId = "FETCH";

            } else {


            }
        }
        else if (this.AzureFeatureId != null && ec.Excludes("azureFeatureId",true))
        {
            this.AzureFeatureId = null;
        }
        //      C# -> System.String? HanaVersion
        // GraphQL -> hanaVersion: String! (scalar)
        if (ec.Includes("hanaVersion",true))
        {
            if(this.HanaVersion == null) {

                this.HanaVersion = "FETCH";

            } else {


            }
        }
        else if (this.HanaVersion != null && ec.Excludes("hanaVersion",true))
        {
            this.HanaVersion = null;
        }
        //      C# -> System.Boolean? IsSystemReplicationEnabled
        // GraphQL -> isSystemReplicationEnabled: Boolean! (scalar)
        if (ec.Includes("isSystemReplicationEnabled",true))
        {
            if(this.IsSystemReplicationEnabled == null) {

                this.IsSystemReplicationEnabled = true;

            } else {


            }
        }
        else if (this.IsSystemReplicationEnabled != null && ec.Excludes("isSystemReplicationEnabled",true))
        {
            this.IsSystemReplicationEnabled = null;
        }
        //      C# -> SapHanaSystemAuthTypeSpec? AuthTypeSpec
        // GraphQL -> authTypeSpec: SapHanaSystemAuthTypeSpec (type)
        if (ec.Includes("authTypeSpec",false))
        {
            if(this.AuthTypeSpec == null) {

                this.AuthTypeSpec = new SapHanaSystemAuthTypeSpec();
                this.AuthTypeSpec.ApplyExploratoryFieldSpec(ec.NewChild("authTypeSpec"));

            } else {

                this.AuthTypeSpec.ApplyExploratoryFieldSpec(ec.NewChild("authTypeSpec"));

            }
        }
        else if (this.AuthTypeSpec != null && ec.Excludes("authTypeSpec",false))
        {
            this.AuthTypeSpec = null;
        }
    }


    #endregion

    } // class SapHanaSystemInfo
    
    #endregion

    public static class ListSapHanaSystemInfoExtensions
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
            this List<SapHanaSystemInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SapHanaSystemInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaSystemInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaSystemInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SapHanaSystemInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
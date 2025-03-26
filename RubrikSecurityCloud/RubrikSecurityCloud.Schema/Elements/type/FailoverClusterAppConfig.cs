// FailoverClusterAppConfig.cs
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
    #region FailoverClusterAppConfig
    public class FailoverClusterAppConfig: BaseType
    {
        #region members

        //      C# -> FailoverClusterType? FailoverClusterType
        // GraphQL -> failoverClusterType: FailoverClusterType! (enum)
        [JsonProperty("failoverClusterType")]
        public FailoverClusterType? FailoverClusterType { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.String? FailoverClusterId
        // GraphQL -> failoverClusterId: String! (scalar)
        [JsonProperty("failoverClusterId")]
        public System.String? FailoverClusterId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> FailoverClusterAppSource? FailoverClusterAppSource
        // GraphQL -> failoverClusterAppSource: FailoverClusterAppSource (type)
        [JsonProperty("failoverClusterAppSource")]
        public FailoverClusterAppSource? FailoverClusterAppSource { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverClusterAppConfig";
    }

    public FailoverClusterAppConfig Set(
        FailoverClusterType? FailoverClusterType = null,
        System.String? ConfiguredSlaDomainId = null,
        System.String? FailoverClusterId = null,
        System.String? Name = null,
        FailoverClusterAppSource? FailoverClusterAppSource = null
    ) 
    {
        if ( FailoverClusterType != null ) {
            this.FailoverClusterType = FailoverClusterType;
        }
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( FailoverClusterId != null ) {
            this.FailoverClusterId = FailoverClusterId;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( FailoverClusterAppSource != null ) {
            this.FailoverClusterAppSource = FailoverClusterAppSource;
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
        //      C# -> FailoverClusterType? FailoverClusterType
        // GraphQL -> failoverClusterType: FailoverClusterType! (enum)
        if (this.FailoverClusterType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failoverClusterType\n" ;
            } else {
                s += ind + "failoverClusterType\n" ;
            }
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainId\n" ;
            } else {
                s += ind + "configuredSlaDomainId\n" ;
            }
        }
        //      C# -> System.String? FailoverClusterId
        // GraphQL -> failoverClusterId: String! (scalar)
        if (this.FailoverClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failoverClusterId\n" ;
            } else {
                s += ind + "failoverClusterId\n" ;
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
        //      C# -> FailoverClusterAppSource? FailoverClusterAppSource
        // GraphQL -> failoverClusterAppSource: FailoverClusterAppSource (type)
        if (this.FailoverClusterAppSource != null) {
            var fspec = this.FailoverClusterAppSource.AsFieldSpec(conf.Child("failoverClusterAppSource"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "failoverClusterAppSource" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> FailoverClusterType? FailoverClusterType
        // GraphQL -> failoverClusterType: FailoverClusterType! (enum)
        if (ec.Includes("failoverClusterType",true))
        {
            if(this.FailoverClusterType == null) {

                this.FailoverClusterType = new FailoverClusterType();

            } else {


            }
        }
        else if (this.FailoverClusterType != null && ec.Excludes("failoverClusterType",true))
        {
            this.FailoverClusterType = null;
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (ec.Includes("configuredSlaDomainId",true))
        {
            if(this.ConfiguredSlaDomainId == null) {

                this.ConfiguredSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.ConfiguredSlaDomainId != null && ec.Excludes("configuredSlaDomainId",true))
        {
            this.ConfiguredSlaDomainId = null;
        }
        //      C# -> System.String? FailoverClusterId
        // GraphQL -> failoverClusterId: String! (scalar)
        if (ec.Includes("failoverClusterId",true))
        {
            if(this.FailoverClusterId == null) {

                this.FailoverClusterId = "FETCH";

            } else {


            }
        }
        else if (this.FailoverClusterId != null && ec.Excludes("failoverClusterId",true))
        {
            this.FailoverClusterId = null;
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
        //      C# -> FailoverClusterAppSource? FailoverClusterAppSource
        // GraphQL -> failoverClusterAppSource: FailoverClusterAppSource (type)
        if (ec.Includes("failoverClusterAppSource",false))
        {
            if(this.FailoverClusterAppSource == null) {

                this.FailoverClusterAppSource = new FailoverClusterAppSource();
                this.FailoverClusterAppSource.ApplyExploratoryFieldSpec(ec.NewChild("failoverClusterAppSource"));

            } else {

                this.FailoverClusterAppSource.ApplyExploratoryFieldSpec(ec.NewChild("failoverClusterAppSource"));

            }
        }
        else if (this.FailoverClusterAppSource != null && ec.Excludes("failoverClusterAppSource",false))
        {
            this.FailoverClusterAppSource = null;
        }
    }


    #endregion

    } // class FailoverClusterAppConfig
    
    #endregion

    public static class ListFailoverClusterAppConfigExtensions
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
            this List<FailoverClusterAppConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailoverClusterAppConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailoverClusterAppConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverClusterAppConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailoverClusterAppConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
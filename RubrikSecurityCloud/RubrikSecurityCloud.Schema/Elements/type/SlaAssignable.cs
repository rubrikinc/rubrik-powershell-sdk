// SlaAssignable.cs
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
    #region SlaAssignable
    public class SlaAssignable: BaseType
    {
        #region members

        //      C# -> ConfiguredSlaType? ConfiguredSlaDomainType
        // GraphQL -> configuredSlaDomainType: ConfiguredSlaType (enum)
        [JsonProperty("configuredSlaDomainType")]
        public ConfiguredSlaType? ConfiguredSlaDomainType { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainName
        // GraphQL -> configuredSlaDomainName: String! (scalar)
        [JsonProperty("configuredSlaDomainName")]
        public System.String? ConfiguredSlaDomainName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsConfiguredSlaDomainRetentionLocked
        // GraphQL -> isConfiguredSlaDomainRetentionLocked: Boolean (scalar)
        [JsonProperty("isConfiguredSlaDomainRetentionLocked")]
        public System.Boolean? IsConfiguredSlaDomainRetentionLocked { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> DateTime? SlaLastUpdateTime
        // GraphQL -> slaLastUpdateTime: DateTime (scalar)
        [JsonProperty("slaLastUpdateTime")]
        public DateTime? SlaLastUpdateTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SlaAssignable";
    }

    public SlaAssignable Set(
        ConfiguredSlaType? ConfiguredSlaDomainType = null,
        System.String? ConfiguredSlaDomainId = null,
        System.String? ConfiguredSlaDomainName = null,
        System.String? Id = null,
        System.Boolean? IsConfiguredSlaDomainRetentionLocked = null,
        System.String? Name = null,
        System.String? PrimaryClusterId = null,
        DateTime? SlaLastUpdateTime = null
    ) 
    {
        if ( ConfiguredSlaDomainType != null ) {
            this.ConfiguredSlaDomainType = ConfiguredSlaDomainType;
        }
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( ConfiguredSlaDomainName != null ) {
            this.ConfiguredSlaDomainName = ConfiguredSlaDomainName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsConfiguredSlaDomainRetentionLocked != null ) {
            this.IsConfiguredSlaDomainRetentionLocked = IsConfiguredSlaDomainRetentionLocked;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( SlaLastUpdateTime != null ) {
            this.SlaLastUpdateTime = SlaLastUpdateTime;
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
        //      C# -> ConfiguredSlaType? ConfiguredSlaDomainType
        // GraphQL -> configuredSlaDomainType: ConfiguredSlaType (enum)
        if (this.ConfiguredSlaDomainType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainType\n" ;
            } else {
                s += ind + "configuredSlaDomainType\n" ;
            }
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainId\n" ;
            } else {
                s += ind + "configuredSlaDomainId\n" ;
            }
        }
        //      C# -> System.String? ConfiguredSlaDomainName
        // GraphQL -> configuredSlaDomainName: String! (scalar)
        if (this.ConfiguredSlaDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainName\n" ;
            } else {
                s += ind + "configuredSlaDomainName\n" ;
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
        //      C# -> System.Boolean? IsConfiguredSlaDomainRetentionLocked
        // GraphQL -> isConfiguredSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsConfiguredSlaDomainRetentionLocked != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isConfiguredSlaDomainRetentionLocked\n" ;
            } else {
                s += ind + "isConfiguredSlaDomainRetentionLocked\n" ;
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
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterId\n" ;
            } else {
                s += ind + "primaryClusterId\n" ;
            }
        }
        //      C# -> DateTime? SlaLastUpdateTime
        // GraphQL -> slaLastUpdateTime: DateTime (scalar)
        if (this.SlaLastUpdateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaLastUpdateTime\n" ;
            } else {
                s += ind + "slaLastUpdateTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ConfiguredSlaType? ConfiguredSlaDomainType
        // GraphQL -> configuredSlaDomainType: ConfiguredSlaType (enum)
        if (ec.Includes("configuredSlaDomainType",true))
        {
            if(this.ConfiguredSlaDomainType == null) {

                this.ConfiguredSlaDomainType = new ConfiguredSlaType();

            } else {


            }
        }
        else if (this.ConfiguredSlaDomainType != null && ec.Excludes("configuredSlaDomainType",true))
        {
            this.ConfiguredSlaDomainType = null;
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
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
        //      C# -> System.String? ConfiguredSlaDomainName
        // GraphQL -> configuredSlaDomainName: String! (scalar)
        if (ec.Includes("configuredSlaDomainName",true))
        {
            if(this.ConfiguredSlaDomainName == null) {

                this.ConfiguredSlaDomainName = "FETCH";

            } else {


            }
        }
        else if (this.ConfiguredSlaDomainName != null && ec.Excludes("configuredSlaDomainName",true))
        {
            this.ConfiguredSlaDomainName = null;
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
        //      C# -> System.Boolean? IsConfiguredSlaDomainRetentionLocked
        // GraphQL -> isConfiguredSlaDomainRetentionLocked: Boolean (scalar)
        if (ec.Includes("isConfiguredSlaDomainRetentionLocked",true))
        {
            if(this.IsConfiguredSlaDomainRetentionLocked == null) {

                this.IsConfiguredSlaDomainRetentionLocked = true;

            } else {


            }
        }
        else if (this.IsConfiguredSlaDomainRetentionLocked != null && ec.Excludes("isConfiguredSlaDomainRetentionLocked",true))
        {
            this.IsConfiguredSlaDomainRetentionLocked = null;
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
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (ec.Includes("primaryClusterId",true))
        {
            if(this.PrimaryClusterId == null) {

                this.PrimaryClusterId = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterId != null && ec.Excludes("primaryClusterId",true))
        {
            this.PrimaryClusterId = null;
        }
        //      C# -> DateTime? SlaLastUpdateTime
        // GraphQL -> slaLastUpdateTime: DateTime (scalar)
        if (ec.Includes("slaLastUpdateTime",true))
        {
            if(this.SlaLastUpdateTime == null) {

                this.SlaLastUpdateTime = new DateTime();

            } else {


            }
        }
        else if (this.SlaLastUpdateTime != null && ec.Excludes("slaLastUpdateTime",true))
        {
            this.SlaLastUpdateTime = null;
        }
    }


    #endregion

    } // class SlaAssignable
    
    #endregion

    public static class ListSlaAssignableExtensions
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
            this List<SlaAssignable> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SlaAssignable> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SlaAssignable> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaAssignable());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SlaAssignable> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
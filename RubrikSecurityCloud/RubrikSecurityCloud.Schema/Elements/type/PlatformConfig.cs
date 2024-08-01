// PlatformConfig.cs
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
    #region PlatformConfig
    public class PlatformConfig: BaseType
    {
        #region members

        //      C# -> TicketingPlatform? PlatformType
        // GraphQL -> platformType: TicketingPlatform! (enum)
        [JsonProperty("platformType")]
        public TicketingPlatform? PlatformType { get; set; }

        //      C# -> System.String? InstanceUrl
        // GraphQL -> instanceUrl: URL! (scalar)
        [JsonProperty("instanceUrl")]
        public System.String? InstanceUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PlatformConfig";
    }

    public PlatformConfig Set(
        TicketingPlatform? PlatformType = null,
        System.String? InstanceUrl = null
    ) 
    {
        if ( PlatformType != null ) {
            this.PlatformType = PlatformType;
        }
        if ( InstanceUrl != null ) {
            this.InstanceUrl = InstanceUrl;
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
        //      C# -> TicketingPlatform? PlatformType
        // GraphQL -> platformType: TicketingPlatform! (enum)
        if (this.PlatformType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "platformType\n" ;
            } else {
                s += ind + "platformType\n" ;
            }
        }
        //      C# -> System.String? InstanceUrl
        // GraphQL -> instanceUrl: URL! (scalar)
        if (this.InstanceUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceUrl\n" ;
            } else {
                s += ind + "instanceUrl\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TicketingPlatform? PlatformType
        // GraphQL -> platformType: TicketingPlatform! (enum)
        if (ec.Includes("platformType",true))
        {
            if(this.PlatformType == null) {

                this.PlatformType = new TicketingPlatform();

            } else {


            }
        }
        else if (this.PlatformType != null && ec.Excludes("platformType",true))
        {
            this.PlatformType = null;
        }
        //      C# -> System.String? InstanceUrl
        // GraphQL -> instanceUrl: URL! (scalar)
        if (ec.Includes("instanceUrl",true))
        {
            if(this.InstanceUrl == null) {

                this.InstanceUrl = "FETCH";

            } else {


            }
        }
        else if (this.InstanceUrl != null && ec.Excludes("instanceUrl",true))
        {
            this.InstanceUrl = null;
        }
    }


    #endregion

    } // class PlatformConfig
    
    #endregion

    public static class ListPlatformConfigExtensions
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
            this List<PlatformConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PlatformConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PlatformConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PlatformConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PlatformConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// VappTemplateExportOptions.cs
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
    #region VappTemplateExportOptions
    public class VappTemplateExportOptions: BaseType
    {
        #region members

        //      C# -> System.String? OrgVdcId
        // GraphQL -> orgVdcId: String! (scalar)
        [JsonProperty("orgVdcId")]
        public System.String? OrgVdcId { get; set; }

        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        [JsonProperty("availableStoragePolicies")]
        public List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VappTemplateExportOptions";
    }

    public VappTemplateExportOptions Set(
        System.String? OrgVdcId = null,
        List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies = null
    ) 
    {
        if ( OrgVdcId != null ) {
            this.OrgVdcId = OrgVdcId;
        }
        if ( AvailableStoragePolicies != null ) {
            this.AvailableStoragePolicies = AvailableStoragePolicies;
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
        //      C# -> System.String? OrgVdcId
        // GraphQL -> orgVdcId: String! (scalar)
        if (this.OrgVdcId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgVdcId\n" ;
            } else {
                s += ind + "orgVdcId\n" ;
            }
        }
        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        if (this.AvailableStoragePolicies != null) {
            var fspec = this.AvailableStoragePolicies.AsFieldSpec(conf.Child("availableStoragePolicies"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "availableStoragePolicies" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? OrgVdcId
        // GraphQL -> orgVdcId: String! (scalar)
        if (ec.Includes("orgVdcId",true))
        {
            if(this.OrgVdcId == null) {

                this.OrgVdcId = "FETCH";

            } else {


            }
        }
        else if (this.OrgVdcId != null && ec.Excludes("orgVdcId",true))
        {
            this.OrgVdcId = null;
        }
        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        if (ec.Includes("availableStoragePolicies",false))
        {
            if(this.AvailableStoragePolicies == null) {

                this.AvailableStoragePolicies = new List<VcdOrgVdcStorageProfile>();
                this.AvailableStoragePolicies.ApplyExploratoryFieldSpec(ec.NewChild("availableStoragePolicies"));

            } else {

                this.AvailableStoragePolicies.ApplyExploratoryFieldSpec(ec.NewChild("availableStoragePolicies"));

            }
        }
        else if (this.AvailableStoragePolicies != null && ec.Excludes("availableStoragePolicies",false))
        {
            this.AvailableStoragePolicies = null;
        }
    }


    #endregion

    } // class VappTemplateExportOptions
    
    #endregion

    public static class ListVappTemplateExportOptionsExtensions
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
            this List<VappTemplateExportOptions> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VappTemplateExportOptions> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VappTemplateExportOptions> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VappTemplateExportOptions());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VappTemplateExportOptions> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
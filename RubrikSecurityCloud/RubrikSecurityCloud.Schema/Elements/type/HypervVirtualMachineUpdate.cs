// HypervVirtualMachineUpdate.cs
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
    #region HypervVirtualMachineUpdate
    public class HypervVirtualMachineUpdate: BaseType
    {
        #region members

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> List<System.String>? VirtualDiskIdsExcludedFromSnapshot
        // GraphQL -> virtualDiskIdsExcludedFromSnapshot: [String!]! (scalar)
        [JsonProperty("virtualDiskIdsExcludedFromSnapshot")]
        public List<System.String>? VirtualDiskIdsExcludedFromSnapshot { get; set; }

        //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
        // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
        [JsonProperty("cloudInstantiationSpec")]
        public CloudInstantiationSpec? CloudInstantiationSpec { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervVirtualMachineUpdate";
    }

    public HypervVirtualMachineUpdate Set(
        System.String? ConfiguredSlaDomainId = null,
        List<System.String>? VirtualDiskIdsExcludedFromSnapshot = null,
        CloudInstantiationSpec? CloudInstantiationSpec = null
    ) 
    {
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( VirtualDiskIdsExcludedFromSnapshot != null ) {
            this.VirtualDiskIdsExcludedFromSnapshot = VirtualDiskIdsExcludedFromSnapshot;
        }
        if ( CloudInstantiationSpec != null ) {
            this.CloudInstantiationSpec = CloudInstantiationSpec;
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
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainId\n" ;
            } else {
                s += ind + "configuredSlaDomainId\n" ;
            }
        }
        //      C# -> List<System.String>? VirtualDiskIdsExcludedFromSnapshot
        // GraphQL -> virtualDiskIdsExcludedFromSnapshot: [String!]! (scalar)
        if (this.VirtualDiskIdsExcludedFromSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "virtualDiskIdsExcludedFromSnapshot\n" ;
            } else {
                s += ind + "virtualDiskIdsExcludedFromSnapshot\n" ;
            }
        }
        //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
        // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
        if (this.CloudInstantiationSpec != null) {
            var fspec = this.CloudInstantiationSpec.AsFieldSpec(conf.Child("cloudInstantiationSpec"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudInstantiationSpec" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> List<System.String>? VirtualDiskIdsExcludedFromSnapshot
        // GraphQL -> virtualDiskIdsExcludedFromSnapshot: [String!]! (scalar)
        if (ec.Includes("virtualDiskIdsExcludedFromSnapshot",true))
        {
            if(this.VirtualDiskIdsExcludedFromSnapshot == null) {

                this.VirtualDiskIdsExcludedFromSnapshot = new List<System.String>();

            } else {


            }
        }
        else if (this.VirtualDiskIdsExcludedFromSnapshot != null && ec.Excludes("virtualDiskIdsExcludedFromSnapshot",true))
        {
            this.VirtualDiskIdsExcludedFromSnapshot = null;
        }
        //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
        // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
        if (ec.Includes("cloudInstantiationSpec",false))
        {
            if(this.CloudInstantiationSpec == null) {

                this.CloudInstantiationSpec = new CloudInstantiationSpec();
                this.CloudInstantiationSpec.ApplyExploratoryFieldSpec(ec.NewChild("cloudInstantiationSpec"));

            } else {

                this.CloudInstantiationSpec.ApplyExploratoryFieldSpec(ec.NewChild("cloudInstantiationSpec"));

            }
        }
        else if (this.CloudInstantiationSpec != null && ec.Excludes("cloudInstantiationSpec",false))
        {
            this.CloudInstantiationSpec = null;
        }
    }


    #endregion

    } // class HypervVirtualMachineUpdate
    
    #endregion

    public static class ListHypervVirtualMachineUpdateExtensions
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
            this List<HypervVirtualMachineUpdate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HypervVirtualMachineUpdate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervVirtualMachineUpdate> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervVirtualMachineUpdate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervVirtualMachineUpdate> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
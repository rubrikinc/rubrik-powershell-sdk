// HypervisorSpecificDetails.cs
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
    #region HypervisorSpecificDetails
    public class HypervisorSpecificDetails: BaseType
    {
        #region members

        //      C# -> ProxmoxDetails? Proxmox
        // GraphQL -> proxmox: ProxmoxDetails (type)
        [JsonProperty("proxmox")]
        public ProxmoxDetails? Proxmox { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervisorSpecificDetails";
    }

    public HypervisorSpecificDetails Set(
        ProxmoxDetails? Proxmox = null
    ) 
    {
        if ( Proxmox != null ) {
            this.Proxmox = Proxmox;
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
        //      C# -> ProxmoxDetails? Proxmox
        // GraphQL -> proxmox: ProxmoxDetails (type)
        if (this.Proxmox != null) {
            var fspec = this.Proxmox.AsFieldSpec(conf.Child("proxmox"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "proxmox" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ProxmoxDetails? Proxmox
        // GraphQL -> proxmox: ProxmoxDetails (type)
        if (ec.Includes("proxmox",false))
        {
            if(this.Proxmox == null) {

                this.Proxmox = new ProxmoxDetails();
                this.Proxmox.ApplyExploratoryFieldSpec(ec.NewChild("proxmox"));

            } else {

                this.Proxmox.ApplyExploratoryFieldSpec(ec.NewChild("proxmox"));

            }
        }
        else if (this.Proxmox != null && ec.Excludes("proxmox",false))
        {
            this.Proxmox = null;
        }
    }


    #endregion

    } // class HypervisorSpecificDetails
    
    #endregion

    public static class ListHypervisorSpecificDetailsExtensions
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
            this List<HypervisorSpecificDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HypervisorSpecificDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervisorSpecificDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervisorSpecificDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervisorSpecificDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
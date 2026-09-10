// ProxmoxVirtualMachineDetails.cs
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
    #region ProxmoxVirtualMachineDetails
    public class ProxmoxVirtualMachineDetails: BaseType
    {
        #region members

        //      C# -> System.String? ProxmoxNodeId
        // GraphQL -> proxmoxNodeId: UUID! (scalar)
        [JsonProperty("proxmoxNodeId")]
        public System.String? ProxmoxNodeId { get; set; }

        //      C# -> System.String? ProxmoxVmId
        // GraphQL -> proxmoxVmId: UUID! (scalar)
        [JsonProperty("proxmoxVmId")]
        public System.String? ProxmoxVmId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ProxmoxVirtualMachineDetails";
    }

    public ProxmoxVirtualMachineDetails Set(
        System.String? ProxmoxNodeId = null,
        System.String? ProxmoxVmId = null
    ) 
    {
        if ( ProxmoxNodeId != null ) {
            this.ProxmoxNodeId = ProxmoxNodeId;
        }
        if ( ProxmoxVmId != null ) {
            this.ProxmoxVmId = ProxmoxVmId;
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
        //      C# -> System.String? ProxmoxNodeId
        // GraphQL -> proxmoxNodeId: UUID! (scalar)
        if (this.ProxmoxNodeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "proxmoxNodeId\n" ;
            } else {
                s += ind + "proxmoxNodeId\n" ;
            }
        }
        //      C# -> System.String? ProxmoxVmId
        // GraphQL -> proxmoxVmId: UUID! (scalar)
        if (this.ProxmoxVmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "proxmoxVmId\n" ;
            } else {
                s += ind + "proxmoxVmId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ProxmoxNodeId
        // GraphQL -> proxmoxNodeId: UUID! (scalar)
        if (ec.Includes("proxmoxNodeId",true))
        {
            if(this.ProxmoxNodeId == null) {

                this.ProxmoxNodeId = "FETCH";

            } else {


            }
        }
        else if (this.ProxmoxNodeId != null && ec.Excludes("proxmoxNodeId",true))
        {
            this.ProxmoxNodeId = null;
        }
        //      C# -> System.String? ProxmoxVmId
        // GraphQL -> proxmoxVmId: UUID! (scalar)
        if (ec.Includes("proxmoxVmId",true))
        {
            if(this.ProxmoxVmId == null) {

                this.ProxmoxVmId = "FETCH";

            } else {


            }
        }
        else if (this.ProxmoxVmId != null && ec.Excludes("proxmoxVmId",true))
        {
            this.ProxmoxVmId = null;
        }
    }


    #endregion

    } // class ProxmoxVirtualMachineDetails
    
    #endregion

    public static class ListProxmoxVirtualMachineDetailsExtensions
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
            this List<ProxmoxVirtualMachineDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ProxmoxVirtualMachineDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ProxmoxVirtualMachineDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProxmoxVirtualMachineDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ProxmoxVirtualMachineDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
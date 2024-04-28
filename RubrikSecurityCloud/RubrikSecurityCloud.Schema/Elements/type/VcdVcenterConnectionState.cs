// VcdVcenterConnectionState.cs
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
    #region VcdVcenterConnectionState
    public class VcdVcenterConnectionState: BaseType
    {
        #region members

        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: UUID! (scalar)
        [JsonProperty("vcenterId")]
        public System.String? VcenterId { get; set; }

        //      C# -> RefreshableObjectConnectionStatus? Status
        // GraphQL -> status: RefreshableObjectConnectionStatus! (type)
        [JsonProperty("status")]
        public RefreshableObjectConnectionStatus? Status { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VcdVcenterConnectionState";
    }

    public VcdVcenterConnectionState Set(
        System.String? VcenterId = null,
        RefreshableObjectConnectionStatus? Status = null
    ) 
    {
        if ( VcenterId != null ) {
            this.VcenterId = VcenterId;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: UUID! (scalar)
        if (this.VcenterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcenterId\n" ;
            } else {
                s += ind + "vcenterId\n" ;
            }
        }
        //      C# -> RefreshableObjectConnectionStatus? Status
        // GraphQL -> status: RefreshableObjectConnectionStatus! (type)
        if (this.Status != null) {
            var fspec = this.Status.AsFieldSpec(conf.Child("status"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "status" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: UUID! (scalar)
        if (ec.Includes("vcenterId",true))
        {
            if(this.VcenterId == null) {

                this.VcenterId = "FETCH";

            } else {


            }
        }
        else if (this.VcenterId != null && ec.Excludes("vcenterId",true))
        {
            this.VcenterId = null;
        }
        //      C# -> RefreshableObjectConnectionStatus? Status
        // GraphQL -> status: RefreshableObjectConnectionStatus! (type)
        if (ec.Includes("status",false))
        {
            if(this.Status == null) {

                this.Status = new RefreshableObjectConnectionStatus();
                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            } else {

                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            }
        }
        else if (this.Status != null && ec.Excludes("status",false))
        {
            this.Status = null;
        }
    }


    #endregion

    } // class VcdVcenterConnectionState
    
    #endregion

    public static class ListVcdVcenterConnectionStateExtensions
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
            this List<VcdVcenterConnectionState> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VcdVcenterConnectionState> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VcdVcenterConnectionState> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VcdVcenterConnectionState());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VcdVcenterConnectionState> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
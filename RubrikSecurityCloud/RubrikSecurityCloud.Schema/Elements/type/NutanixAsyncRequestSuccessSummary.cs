// NutanixAsyncRequestSuccessSummary.cs
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
    #region NutanixAsyncRequestSuccessSummary
    public class NutanixAsyncRequestSuccessSummary: BaseType
    {
        #region members

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }

        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixAsyncRequestSuccessSummary";
    }

    public NutanixAsyncRequestSuccessSummary Set(
        System.String? VmId = null,
        AsyncRequestStatus? AsyncRequestStatus = null
    ) 
    {
        if ( VmId != null ) {
            this.VmId = VmId;
        }
        if ( AsyncRequestStatus != null ) {
            this.AsyncRequestStatus = AsyncRequestStatus;
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
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmId\n" ;
            } else {
                s += ind + "vmId\n" ;
            }
        }
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus != null) {
            var fspec = this.AsyncRequestStatus.AsFieldSpec(conf.Child("asyncRequestStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "asyncRequestStatus {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (ec.Includes("vmId",true))
        {
            if(this.VmId == null) {

                this.VmId = "FETCH";

            } else {


            }
        }
        else if (this.VmId != null && ec.Excludes("vmId",true))
        {
            this.VmId = null;
        }
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (ec.Includes("asyncRequestStatus",false))
        {
            if(this.AsyncRequestStatus == null) {

                this.AsyncRequestStatus = new AsyncRequestStatus();
                this.AsyncRequestStatus.ApplyExploratoryFieldSpec(ec.NewChild("asyncRequestStatus"));

            } else {

                this.AsyncRequestStatus.ApplyExploratoryFieldSpec(ec.NewChild("asyncRequestStatus"));

            }
        }
        else if (this.AsyncRequestStatus != null && ec.Excludes("asyncRequestStatus",false))
        {
            this.AsyncRequestStatus = null;
        }
    }


    #endregion

    } // class NutanixAsyncRequestSuccessSummary
    
    #endregion

    public static class ListNutanixAsyncRequestSuccessSummaryExtensions
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
            this List<NutanixAsyncRequestSuccessSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixAsyncRequestSuccessSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixAsyncRequestSuccessSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixAsyncRequestSuccessSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixAsyncRequestSuccessSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
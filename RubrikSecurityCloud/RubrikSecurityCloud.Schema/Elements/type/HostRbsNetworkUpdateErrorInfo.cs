// HostRbsNetworkUpdateErrorInfo.cs
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
    #region HostRbsNetworkUpdateErrorInfo
    public class HostRbsNetworkUpdateErrorInfo: BaseType
    {
        #region members

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> RequestErrorInfo? NetworkThrottleUpdateStatus
        // GraphQL -> networkThrottleUpdateStatus: RequestErrorInfo (type)
        [JsonProperty("networkThrottleUpdateStatus")]
        public RequestErrorInfo? NetworkThrottleUpdateStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HostRbsNetworkUpdateErrorInfo";
    }

    public HostRbsNetworkUpdateErrorInfo Set(
        System.String? HostId = null,
        RequestErrorInfo? NetworkThrottleUpdateStatus = null
    ) 
    {
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( NetworkThrottleUpdateStatus != null ) {
            this.NetworkThrottleUpdateStatus = NetworkThrottleUpdateStatus;
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
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
        //      C# -> RequestErrorInfo? NetworkThrottleUpdateStatus
        // GraphQL -> networkThrottleUpdateStatus: RequestErrorInfo (type)
        if (this.NetworkThrottleUpdateStatus != null) {
            var fspec = this.NetworkThrottleUpdateStatus.AsFieldSpec(conf.Child("networkThrottleUpdateStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "networkThrottleUpdateStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (ec.Includes("hostId",true))
        {
            if(this.HostId == null) {

                this.HostId = "FETCH";

            } else {


            }
        }
        else if (this.HostId != null && ec.Excludes("hostId",true))
        {
            this.HostId = null;
        }
        //      C# -> RequestErrorInfo? NetworkThrottleUpdateStatus
        // GraphQL -> networkThrottleUpdateStatus: RequestErrorInfo (type)
        if (ec.Includes("networkThrottleUpdateStatus",false))
        {
            if(this.NetworkThrottleUpdateStatus == null) {

                this.NetworkThrottleUpdateStatus = new RequestErrorInfo();
                this.NetworkThrottleUpdateStatus.ApplyExploratoryFieldSpec(ec.NewChild("networkThrottleUpdateStatus"));

            } else {

                this.NetworkThrottleUpdateStatus.ApplyExploratoryFieldSpec(ec.NewChild("networkThrottleUpdateStatus"));

            }
        }
        else if (this.NetworkThrottleUpdateStatus != null && ec.Excludes("networkThrottleUpdateStatus",false))
        {
            this.NetworkThrottleUpdateStatus = null;
        }
    }


    #endregion

    } // class HostRbsNetworkUpdateErrorInfo
    
    #endregion

    public static class ListHostRbsNetworkUpdateErrorInfoExtensions
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
            this List<HostRbsNetworkUpdateErrorInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HostRbsNetworkUpdateErrorInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HostRbsNetworkUpdateErrorInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HostRbsNetworkUpdateErrorInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HostRbsNetworkUpdateErrorInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// GetHostRbsNetworkThrottleResponse.cs
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
    #region GetHostRbsNetworkThrottleResponse
    public class GetHostRbsNetworkThrottleResponse: BaseType
    {
        #region members

        //      C# -> HostRbsNetworkLimits? NetworkThrottleLimits
        // GraphQL -> networkThrottleLimits: HostRbsNetworkLimits (type)
        [JsonProperty("networkThrottleLimits")]
        public HostRbsNetworkLimits? NetworkThrottleLimits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetHostRbsNetworkThrottleResponse";
    }

    public GetHostRbsNetworkThrottleResponse Set(
        HostRbsNetworkLimits? NetworkThrottleLimits = null
    ) 
    {
        if ( NetworkThrottleLimits != null ) {
            this.NetworkThrottleLimits = NetworkThrottleLimits;
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
        //      C# -> HostRbsNetworkLimits? NetworkThrottleLimits
        // GraphQL -> networkThrottleLimits: HostRbsNetworkLimits (type)
        if (this.NetworkThrottleLimits != null) {
            var fspec = this.NetworkThrottleLimits.AsFieldSpec(conf.Child("networkThrottleLimits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "networkThrottleLimits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> HostRbsNetworkLimits? NetworkThrottleLimits
        // GraphQL -> networkThrottleLimits: HostRbsNetworkLimits (type)
        if (ec.Includes("networkThrottleLimits",false))
        {
            if(this.NetworkThrottleLimits == null) {

                this.NetworkThrottleLimits = new HostRbsNetworkLimits();
                this.NetworkThrottleLimits.ApplyExploratoryFieldSpec(ec.NewChild("networkThrottleLimits"));

            } else {

                this.NetworkThrottleLimits.ApplyExploratoryFieldSpec(ec.NewChild("networkThrottleLimits"));

            }
        }
        else if (this.NetworkThrottleLimits != null && ec.Excludes("networkThrottleLimits",false))
        {
            this.NetworkThrottleLimits = null;
        }
    }


    #endregion

    } // class GetHostRbsNetworkThrottleResponse
    
    #endregion

    public static class ListGetHostRbsNetworkThrottleResponseExtensions
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
            this List<GetHostRbsNetworkThrottleResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetHostRbsNetworkThrottleResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetHostRbsNetworkThrottleResponse> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetHostRbsNetworkThrottleResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetHostRbsNetworkThrottleResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
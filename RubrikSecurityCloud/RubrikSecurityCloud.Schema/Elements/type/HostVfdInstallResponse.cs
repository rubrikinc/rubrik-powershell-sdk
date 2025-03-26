// HostVfdInstallResponse.cs
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
    #region HostVfdInstallResponse
    public class HostVfdInstallResponse: BaseType
    {
        #region members

        //      C# -> HostVfdState? HostVfdDriverState
        // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
        [JsonProperty("hostVfdDriverState")]
        public HostVfdState? HostVfdDriverState { get; set; }

        //      C# -> System.String? ErrorInfo
        // GraphQL -> errorInfo: String (scalar)
        [JsonProperty("errorInfo")]
        public System.String? ErrorInfo { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HostVfdInstallResponse";
    }

    public HostVfdInstallResponse Set(
        HostVfdState? HostVfdDriverState = null,
        System.String? ErrorInfo = null,
        System.String? HostId = null
    ) 
    {
        if ( HostVfdDriverState != null ) {
            this.HostVfdDriverState = HostVfdDriverState;
        }
        if ( ErrorInfo != null ) {
            this.ErrorInfo = ErrorInfo;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
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
        //      C# -> HostVfdState? HostVfdDriverState
        // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
        if (this.HostVfdDriverState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostVfdDriverState\n" ;
            } else {
                s += ind + "hostVfdDriverState\n" ;
            }
        }
        //      C# -> System.String? ErrorInfo
        // GraphQL -> errorInfo: String (scalar)
        if (this.ErrorInfo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorInfo\n" ;
            } else {
                s += ind + "errorInfo\n" ;
            }
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> HostVfdState? HostVfdDriverState
        // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
        if (ec.Includes("hostVfdDriverState",true))
        {
            if(this.HostVfdDriverState == null) {

                this.HostVfdDriverState = new HostVfdState();

            } else {


            }
        }
        else if (this.HostVfdDriverState != null && ec.Excludes("hostVfdDriverState",true))
        {
            this.HostVfdDriverState = null;
        }
        //      C# -> System.String? ErrorInfo
        // GraphQL -> errorInfo: String (scalar)
        if (ec.Includes("errorInfo",true))
        {
            if(this.ErrorInfo == null) {

                this.ErrorInfo = "FETCH";

            } else {


            }
        }
        else if (this.ErrorInfo != null && ec.Excludes("errorInfo",true))
        {
            this.ErrorInfo = null;
        }
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
    }


    #endregion

    } // class HostVfdInstallResponse
    
    #endregion

    public static class ListHostVfdInstallResponseExtensions
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
            this List<HostVfdInstallResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HostVfdInstallResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HostVfdInstallResponse> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HostVfdInstallResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HostVfdInstallResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
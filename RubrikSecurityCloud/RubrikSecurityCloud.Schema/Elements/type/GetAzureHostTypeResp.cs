// GetAzureHostTypeResp.cs
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
    #region GetAzureHostTypeResp
    public class GetAzureHostTypeResp: BaseType
    {
        #region members

        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        [JsonProperty("hostType")]
        public AzureHostType? HostType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetAzureHostTypeResp";
    }

    public GetAzureHostTypeResp Set(
        AzureHostType? HostType = null
    ) 
    {
        if ( HostType != null ) {
            this.HostType = HostType;
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
        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        if (this.HostType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostType\n" ;
            } else {
                s += ind + "hostType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        if (ec.Includes("hostType",true))
        {
            if(this.HostType == null) {

                this.HostType = new AzureHostType();

            } else {


            }
        }
        else if (this.HostType != null && ec.Excludes("hostType",true))
        {
            this.HostType = null;
        }
    }


    #endregion

    } // class GetAzureHostTypeResp
    
    #endregion

    public static class ListGetAzureHostTypeRespExtensions
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
            this List<GetAzureHostTypeResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetAzureHostTypeResp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetAzureHostTypeResp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetAzureHostTypeResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetAzureHostTypeResp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
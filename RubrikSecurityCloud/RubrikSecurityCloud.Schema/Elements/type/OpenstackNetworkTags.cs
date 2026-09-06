// OpenstackNetworkTags.cs
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
    #region OpenstackNetworkTags
    public class OpenstackNetworkTags: BaseType
    {
        #region members

        //      C# -> System.String? NetworkId
        // GraphQL -> networkId: String! (scalar)
        [JsonProperty("networkId")]
        public System.String? NetworkId { get; set; }

        //      C# -> System.String? NetworkTag
        // GraphQL -> networkTag: String! (scalar)
        [JsonProperty("networkTag")]
        public System.String? NetworkTag { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OpenstackNetworkTags";
    }

    public OpenstackNetworkTags Set(
        System.String? NetworkId = null,
        System.String? NetworkTag = null
    ) 
    {
        if ( NetworkId != null ) {
            this.NetworkId = NetworkId;
        }
        if ( NetworkTag != null ) {
            this.NetworkTag = NetworkTag;
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
        //      C# -> System.String? NetworkId
        // GraphQL -> networkId: String! (scalar)
        if (this.NetworkId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkId\n" ;
            } else {
                s += ind + "networkId\n" ;
            }
        }
        //      C# -> System.String? NetworkTag
        // GraphQL -> networkTag: String! (scalar)
        if (this.NetworkTag != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkTag\n" ;
            } else {
                s += ind + "networkTag\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? NetworkId
        // GraphQL -> networkId: String! (scalar)
        if (ec.Includes("networkId",true))
        {
            if(this.NetworkId == null) {

                this.NetworkId = "FETCH";

            } else {


            }
        }
        else if (this.NetworkId != null && ec.Excludes("networkId",true))
        {
            this.NetworkId = null;
        }
        //      C# -> System.String? NetworkTag
        // GraphQL -> networkTag: String! (scalar)
        if (ec.Includes("networkTag",true))
        {
            if(this.NetworkTag == null) {

                this.NetworkTag = "FETCH";

            } else {


            }
        }
        else if (this.NetworkTag != null && ec.Excludes("networkTag",true))
        {
            this.NetworkTag = null;
        }
    }


    #endregion

    } // class OpenstackNetworkTags
    
    #endregion

    public static class ListOpenstackNetworkTagsExtensions
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
            this List<OpenstackNetworkTags> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OpenstackNetworkTags> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OpenstackNetworkTags> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OpenstackNetworkTags());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OpenstackNetworkTags> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
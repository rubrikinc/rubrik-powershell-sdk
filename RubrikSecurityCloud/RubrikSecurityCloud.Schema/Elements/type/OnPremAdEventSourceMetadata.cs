// OnPremAdEventSourceMetadata.cs
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
    #region OnPremAdEventSourceMetadata
    public class OnPremAdEventSourceMetadata: BaseType
    {
        #region members

        //      C# -> System.String? DcId
        // GraphQL -> dcId: String! (scalar)
        [JsonProperty("dcId")]
        public System.String? DcId { get; set; }

        //      C# -> System.String? DcName
        // GraphQL -> dcName: String! (scalar)
        [JsonProperty("dcName")]
        public System.String? DcName { get; set; }

        //      C# -> System.String? InvocationId
        // GraphQL -> invocationId: UUID! (scalar)
        [JsonProperty("invocationId")]
        public System.String? InvocationId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OnPremAdEventSourceMetadata";
    }

    public OnPremAdEventSourceMetadata Set(
        System.String? DcId = null,
        System.String? DcName = null,
        System.String? InvocationId = null
    ) 
    {
        if ( DcId != null ) {
            this.DcId = DcId;
        }
        if ( DcName != null ) {
            this.DcName = DcName;
        }
        if ( InvocationId != null ) {
            this.InvocationId = InvocationId;
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
        //      C# -> System.String? DcId
        // GraphQL -> dcId: String! (scalar)
        if (this.DcId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dcId\n" ;
            } else {
                s += ind + "dcId\n" ;
            }
        }
        //      C# -> System.String? DcName
        // GraphQL -> dcName: String! (scalar)
        if (this.DcName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dcName\n" ;
            } else {
                s += ind + "dcName\n" ;
            }
        }
        //      C# -> System.String? InvocationId
        // GraphQL -> invocationId: UUID! (scalar)
        if (this.InvocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "invocationId\n" ;
            } else {
                s += ind + "invocationId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DcId
        // GraphQL -> dcId: String! (scalar)
        if (ec.Includes("dcId",true))
        {
            if(this.DcId == null) {

                this.DcId = "FETCH";

            } else {


            }
        }
        else if (this.DcId != null && ec.Excludes("dcId",true))
        {
            this.DcId = null;
        }
        //      C# -> System.String? DcName
        // GraphQL -> dcName: String! (scalar)
        if (ec.Includes("dcName",true))
        {
            if(this.DcName == null) {

                this.DcName = "FETCH";

            } else {


            }
        }
        else if (this.DcName != null && ec.Excludes("dcName",true))
        {
            this.DcName = null;
        }
        //      C# -> System.String? InvocationId
        // GraphQL -> invocationId: UUID! (scalar)
        if (ec.Includes("invocationId",true))
        {
            if(this.InvocationId == null) {

                this.InvocationId = "FETCH";

            } else {


            }
        }
        else if (this.InvocationId != null && ec.Excludes("invocationId",true))
        {
            this.InvocationId = null;
        }
    }


    #endregion

    } // class OnPremAdEventSourceMetadata
    
    #endregion

    public static class ListOnPremAdEventSourceMetadataExtensions
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
            this List<OnPremAdEventSourceMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OnPremAdEventSourceMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OnPremAdEventSourceMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OnPremAdEventSourceMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OnPremAdEventSourceMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// GetPrincipalTagStatsReply.cs
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
    #region GetPrincipalTagStatsReply
    public class GetPrincipalTagStatsReply: BaseType
    {
        #region members

        //      C# -> PrincipalTagStats? Atrisk
        // GraphQL -> atrisk: PrincipalTagStats (type)
        [JsonProperty("atrisk")]
        public PrincipalTagStats? Atrisk { get; set; }

        //      C# -> PrincipalTagStats? Privileged
        // GraphQL -> privileged: PrincipalTagStats (type)
        [JsonProperty("privileged")]
        public PrincipalTagStats? Privileged { get; set; }

        //      C# -> PrincipalTagStats? Sensitive
        // GraphQL -> sensitive: PrincipalTagStats (type)
        [JsonProperty("sensitive")]
        public PrincipalTagStats? Sensitive { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetPrincipalTagStatsReply";
    }

    public GetPrincipalTagStatsReply Set(
        PrincipalTagStats? Atrisk = null,
        PrincipalTagStats? Privileged = null,
        PrincipalTagStats? Sensitive = null
    ) 
    {
        if ( Atrisk != null ) {
            this.Atrisk = Atrisk;
        }
        if ( Privileged != null ) {
            this.Privileged = Privileged;
        }
        if ( Sensitive != null ) {
            this.Sensitive = Sensitive;
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
        //      C# -> PrincipalTagStats? Atrisk
        // GraphQL -> atrisk: PrincipalTagStats (type)
        if (this.Atrisk != null) {
            var fspec = this.Atrisk.AsFieldSpec(conf.Child("atrisk"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "atrisk" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrincipalTagStats? Privileged
        // GraphQL -> privileged: PrincipalTagStats (type)
        if (this.Privileged != null) {
            var fspec = this.Privileged.AsFieldSpec(conf.Child("privileged"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "privileged" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrincipalTagStats? Sensitive
        // GraphQL -> sensitive: PrincipalTagStats (type)
        if (this.Sensitive != null) {
            var fspec = this.Sensitive.AsFieldSpec(conf.Child("sensitive"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sensitive" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PrincipalTagStats? Atrisk
        // GraphQL -> atrisk: PrincipalTagStats (type)
        if (ec.Includes("atrisk",false))
        {
            if(this.Atrisk == null) {

                this.Atrisk = new PrincipalTagStats();
                this.Atrisk.ApplyExploratoryFieldSpec(ec.NewChild("atrisk"));

            } else {

                this.Atrisk.ApplyExploratoryFieldSpec(ec.NewChild("atrisk"));

            }
        }
        else if (this.Atrisk != null && ec.Excludes("atrisk",false))
        {
            this.Atrisk = null;
        }
        //      C# -> PrincipalTagStats? Privileged
        // GraphQL -> privileged: PrincipalTagStats (type)
        if (ec.Includes("privileged",false))
        {
            if(this.Privileged == null) {

                this.Privileged = new PrincipalTagStats();
                this.Privileged.ApplyExploratoryFieldSpec(ec.NewChild("privileged"));

            } else {

                this.Privileged.ApplyExploratoryFieldSpec(ec.NewChild("privileged"));

            }
        }
        else if (this.Privileged != null && ec.Excludes("privileged",false))
        {
            this.Privileged = null;
        }
        //      C# -> PrincipalTagStats? Sensitive
        // GraphQL -> sensitive: PrincipalTagStats (type)
        if (ec.Includes("sensitive",false))
        {
            if(this.Sensitive == null) {

                this.Sensitive = new PrincipalTagStats();
                this.Sensitive.ApplyExploratoryFieldSpec(ec.NewChild("sensitive"));

            } else {

                this.Sensitive.ApplyExploratoryFieldSpec(ec.NewChild("sensitive"));

            }
        }
        else if (this.Sensitive != null && ec.Excludes("sensitive",false))
        {
            this.Sensitive = null;
        }
    }


    #endregion

    } // class GetPrincipalTagStatsReply
    
    #endregion

    public static class ListGetPrincipalTagStatsReplyExtensions
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
            this List<GetPrincipalTagStatsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetPrincipalTagStatsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetPrincipalTagStatsReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetPrincipalTagStatsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetPrincipalTagStatsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// BulkRegisterSecondaryHostsReply.cs
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
    #region BulkRegisterSecondaryHostsReply
    public class BulkRegisterSecondaryHostsReply: BaseType
    {
        #region members

        //      C# -> List<HostSecondaryRegistrationResult>? HostResults
        // GraphQL -> hostResults: [HostSecondaryRegistrationResult!]! (type)
        [JsonProperty("hostResults")]
        public List<HostSecondaryRegistrationResult>? HostResults { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BulkRegisterSecondaryHostsReply";
    }

    public BulkRegisterSecondaryHostsReply Set(
        List<HostSecondaryRegistrationResult>? HostResults = null
    ) 
    {
        if ( HostResults != null ) {
            this.HostResults = HostResults;
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
        //      C# -> List<HostSecondaryRegistrationResult>? HostResults
        // GraphQL -> hostResults: [HostSecondaryRegistrationResult!]! (type)
        if (this.HostResults != null) {
            var fspec = this.HostResults.AsFieldSpec(conf.Child("hostResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hostResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<HostSecondaryRegistrationResult>? HostResults
        // GraphQL -> hostResults: [HostSecondaryRegistrationResult!]! (type)
        if (ec.Includes("hostResults",false))
        {
            if(this.HostResults == null) {

                this.HostResults = new List<HostSecondaryRegistrationResult>();
                this.HostResults.ApplyExploratoryFieldSpec(ec.NewChild("hostResults"));

            } else {

                this.HostResults.ApplyExploratoryFieldSpec(ec.NewChild("hostResults"));

            }
        }
        else if (this.HostResults != null && ec.Excludes("hostResults",false))
        {
            this.HostResults = null;
        }
    }


    #endregion

    } // class BulkRegisterSecondaryHostsReply
    
    #endregion

    public static class ListBulkRegisterSecondaryHostsReplyExtensions
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
            this List<BulkRegisterSecondaryHostsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BulkRegisterSecondaryHostsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BulkRegisterSecondaryHostsReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkRegisterSecondaryHostsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BulkRegisterSecondaryHostsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
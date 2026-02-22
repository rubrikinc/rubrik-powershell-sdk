// GetSqlServerSetupScriptsReplyBulk.cs
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
    #region GetSqlServerSetupScriptsReplyBulk
    public class GetSqlServerSetupScriptsReplyBulk: BaseType
    {
        #region members

        //      C# -> List<SqlServerSetupScriptDetails>? ScriptDetails
        // GraphQL -> scriptDetails: [SqlServerSetupScriptDetails!]! (type)
        [JsonProperty("scriptDetails")]
        public List<SqlServerSetupScriptDetails>? ScriptDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetSqlServerSetupScriptsReplyBulk";
    }

    public GetSqlServerSetupScriptsReplyBulk Set(
        List<SqlServerSetupScriptDetails>? ScriptDetails = null
    ) 
    {
        if ( ScriptDetails != null ) {
            this.ScriptDetails = ScriptDetails;
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
        //      C# -> List<SqlServerSetupScriptDetails>? ScriptDetails
        // GraphQL -> scriptDetails: [SqlServerSetupScriptDetails!]! (type)
        if (this.ScriptDetails != null) {
            var fspec = this.ScriptDetails.AsFieldSpec(conf.Child("scriptDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "scriptDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<SqlServerSetupScriptDetails>? ScriptDetails
        // GraphQL -> scriptDetails: [SqlServerSetupScriptDetails!]! (type)
        if (ec.Includes("scriptDetails",false))
        {
            if(this.ScriptDetails == null) {

                this.ScriptDetails = new List<SqlServerSetupScriptDetails>();
                this.ScriptDetails.ApplyExploratoryFieldSpec(ec.NewChild("scriptDetails"));

            } else {

                this.ScriptDetails.ApplyExploratoryFieldSpec(ec.NewChild("scriptDetails"));

            }
        }
        else if (this.ScriptDetails != null && ec.Excludes("scriptDetails",false))
        {
            this.ScriptDetails = null;
        }
    }


    #endregion

    } // class GetSqlServerSetupScriptsReplyBulk
    
    #endregion

    public static class ListGetSqlServerSetupScriptsReplyBulkExtensions
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
            this List<GetSqlServerSetupScriptsReplyBulk> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetSqlServerSetupScriptsReplyBulk> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetSqlServerSetupScriptsReplyBulk> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetSqlServerSetupScriptsReplyBulk());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetSqlServerSetupScriptsReplyBulk> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// AwsOutpostAccountGetAccountReply.cs
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
    #region AwsOutpostAccountGetAccountReply
    public class AwsOutpostAccountGetAccountReply: BaseType
    {
        #region members

        //      C# -> AwsOutpostAccount? AwsOutpostAccount
        // GraphQL -> awsOutpostAccount: AwsOutpostAccount (type)
        [JsonProperty("awsOutpostAccount")]
        public AwsOutpostAccount? AwsOutpostAccount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsOutpostAccountGetAccountReply";
    }

    public AwsOutpostAccountGetAccountReply Set(
        AwsOutpostAccount? AwsOutpostAccount = null
    ) 
    {
        if ( AwsOutpostAccount != null ) {
            this.AwsOutpostAccount = AwsOutpostAccount;
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
        //      C# -> AwsOutpostAccount? AwsOutpostAccount
        // GraphQL -> awsOutpostAccount: AwsOutpostAccount (type)
        if (this.AwsOutpostAccount != null) {
            var fspec = this.AwsOutpostAccount.AsFieldSpec(conf.Child("awsOutpostAccount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsOutpostAccount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsOutpostAccount? AwsOutpostAccount
        // GraphQL -> awsOutpostAccount: AwsOutpostAccount (type)
        if (ec.Includes("awsOutpostAccount",false))
        {
            if(this.AwsOutpostAccount == null) {

                this.AwsOutpostAccount = new AwsOutpostAccount();
                this.AwsOutpostAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsOutpostAccount"));

            } else {

                this.AwsOutpostAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsOutpostAccount"));

            }
        }
        else if (this.AwsOutpostAccount != null && ec.Excludes("awsOutpostAccount",false))
        {
            this.AwsOutpostAccount = null;
        }
    }


    #endregion

    } // class AwsOutpostAccountGetAccountReply
    
    #endregion

    public static class ListAwsOutpostAccountGetAccountReplyExtensions
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
            this List<AwsOutpostAccountGetAccountReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsOutpostAccountGetAccountReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsOutpostAccountGetAccountReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsOutpostAccountGetAccountReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsOutpostAccountGetAccountReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
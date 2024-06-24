// GetPasskeyInfoReply.cs
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
    #region GetPasskeyInfoReply
    public class GetPasskeyInfoReply: BaseType
    {
        #region members

        //      C# -> PasskeyConfig? PasskeyConfig
        // GraphQL -> passkeyConfig: PasskeyConfig (type)
        [JsonProperty("passkeyConfig")]
        public PasskeyConfig? PasskeyConfig { get; set; }

        //      C# -> List<Passkey>? Passkeys
        // GraphQL -> passkeys: [Passkey!]! (type)
        [JsonProperty("passkeys")]
        public List<Passkey>? Passkeys { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetPasskeyInfoReply";
    }

    public GetPasskeyInfoReply Set(
        PasskeyConfig? PasskeyConfig = null,
        List<Passkey>? Passkeys = null
    ) 
    {
        if ( PasskeyConfig != null ) {
            this.PasskeyConfig = PasskeyConfig;
        }
        if ( Passkeys != null ) {
            this.Passkeys = Passkeys;
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
        //      C# -> PasskeyConfig? PasskeyConfig
        // GraphQL -> passkeyConfig: PasskeyConfig (type)
        if (this.PasskeyConfig != null) {
            var fspec = this.PasskeyConfig.AsFieldSpec(conf.Child("passkeyConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "passkeyConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Passkey>? Passkeys
        // GraphQL -> passkeys: [Passkey!]! (type)
        if (this.Passkeys != null) {
            var fspec = this.Passkeys.AsFieldSpec(conf.Child("passkeys"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "passkeys" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> PasskeyConfig? PasskeyConfig
        // GraphQL -> passkeyConfig: PasskeyConfig (type)
        if (ec.Includes("passkeyConfig",false))
        {
            if(this.PasskeyConfig == null) {

                this.PasskeyConfig = new PasskeyConfig();
                this.PasskeyConfig.ApplyExploratoryFieldSpec(ec.NewChild("passkeyConfig"));

            } else {

                this.PasskeyConfig.ApplyExploratoryFieldSpec(ec.NewChild("passkeyConfig"));

            }
        }
        else if (this.PasskeyConfig != null && ec.Excludes("passkeyConfig",false))
        {
            this.PasskeyConfig = null;
        }
        //      C# -> List<Passkey>? Passkeys
        // GraphQL -> passkeys: [Passkey!]! (type)
        if (ec.Includes("passkeys",false))
        {
            if(this.Passkeys == null) {

                this.Passkeys = new List<Passkey>();
                this.Passkeys.ApplyExploratoryFieldSpec(ec.NewChild("passkeys"));

            } else {

                this.Passkeys.ApplyExploratoryFieldSpec(ec.NewChild("passkeys"));

            }
        }
        else if (this.Passkeys != null && ec.Excludes("passkeys",false))
        {
            this.Passkeys = null;
        }
    }


    #endregion

    } // class GetPasskeyInfoReply
    
    #endregion

    public static class ListGetPasskeyInfoReplyExtensions
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
            this List<GetPasskeyInfoReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetPasskeyInfoReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetPasskeyInfoReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetPasskeyInfoReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetPasskeyInfoReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
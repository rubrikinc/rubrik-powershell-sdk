// HdfsBaseConfig.cs
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
    #region HdfsBaseConfig
    public class HdfsBaseConfig: BaseType
    {
        #region members

        //      C# -> System.String? ApiToken
        // GraphQL -> apiToken: String (scalar)
        [JsonProperty("apiToken")]
        public System.String? ApiToken { get; set; }

        //      C# -> System.String? KerberosTicket
        // GraphQL -> kerberosTicket: String (scalar)
        [JsonProperty("kerberosTicket")]
        public System.String? KerberosTicket { get; set; }

        //      C# -> System.String? Nameservices
        // GraphQL -> nameservices: String (scalar)
        [JsonProperty("nameservices")]
        public System.String? Nameservices { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> List<HdfsHost>? Hosts
        // GraphQL -> hosts: [HdfsHost!]! (type)
        [JsonProperty("hosts")]
        public List<HdfsHost>? Hosts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HdfsBaseConfig";
    }

    public HdfsBaseConfig Set(
        System.String? ApiToken = null,
        System.String? KerberosTicket = null,
        System.String? Nameservices = null,
        System.String? Username = null,
        List<HdfsHost>? Hosts = null
    ) 
    {
        if ( ApiToken != null ) {
            this.ApiToken = ApiToken;
        }
        if ( KerberosTicket != null ) {
            this.KerberosTicket = KerberosTicket;
        }
        if ( Nameservices != null ) {
            this.Nameservices = Nameservices;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( Hosts != null ) {
            this.Hosts = Hosts;
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
        //      C# -> System.String? ApiToken
        // GraphQL -> apiToken: String (scalar)
        if (this.ApiToken != null) {
            if (conf.Flat) {
                s += conf.Prefix + "apiToken\n" ;
            } else {
                s += ind + "apiToken\n" ;
            }
        }
        //      C# -> System.String? KerberosTicket
        // GraphQL -> kerberosTicket: String (scalar)
        if (this.KerberosTicket != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kerberosTicket\n" ;
            } else {
                s += ind + "kerberosTicket\n" ;
            }
        }
        //      C# -> System.String? Nameservices
        // GraphQL -> nameservices: String (scalar)
        if (this.Nameservices != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nameservices\n" ;
            } else {
                s += ind + "nameservices\n" ;
            }
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        if (this.Username != null) {
            if (conf.Flat) {
                s += conf.Prefix + "username\n" ;
            } else {
                s += ind + "username\n" ;
            }
        }
        //      C# -> List<HdfsHost>? Hosts
        // GraphQL -> hosts: [HdfsHost!]! (type)
        if (this.Hosts != null) {
            var fspec = this.Hosts.AsFieldSpec(conf.Child("hosts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hosts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ApiToken
        // GraphQL -> apiToken: String (scalar)
        if (ec.Includes("apiToken",true))
        {
            if(this.ApiToken == null) {

                this.ApiToken = "FETCH";

            } else {


            }
        }
        else if (this.ApiToken != null && ec.Excludes("apiToken",true))
        {
            this.ApiToken = null;
        }
        //      C# -> System.String? KerberosTicket
        // GraphQL -> kerberosTicket: String (scalar)
        if (ec.Includes("kerberosTicket",true))
        {
            if(this.KerberosTicket == null) {

                this.KerberosTicket = "FETCH";

            } else {


            }
        }
        else if (this.KerberosTicket != null && ec.Excludes("kerberosTicket",true))
        {
            this.KerberosTicket = null;
        }
        //      C# -> System.String? Nameservices
        // GraphQL -> nameservices: String (scalar)
        if (ec.Includes("nameservices",true))
        {
            if(this.Nameservices == null) {

                this.Nameservices = "FETCH";

            } else {


            }
        }
        else if (this.Nameservices != null && ec.Excludes("nameservices",true))
        {
            this.Nameservices = null;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        if (ec.Includes("username",true))
        {
            if(this.Username == null) {

                this.Username = "FETCH";

            } else {


            }
        }
        else if (this.Username != null && ec.Excludes("username",true))
        {
            this.Username = null;
        }
        //      C# -> List<HdfsHost>? Hosts
        // GraphQL -> hosts: [HdfsHost!]! (type)
        if (ec.Includes("hosts",false))
        {
            if(this.Hosts == null) {

                this.Hosts = new List<HdfsHost>();
                this.Hosts.ApplyExploratoryFieldSpec(ec.NewChild("hosts"));

            } else {

                this.Hosts.ApplyExploratoryFieldSpec(ec.NewChild("hosts"));

            }
        }
        else if (this.Hosts != null && ec.Excludes("hosts",false))
        {
            this.Hosts = null;
        }
    }


    #endregion

    } // class HdfsBaseConfig
    
    #endregion

    public static class ListHdfsBaseConfigExtensions
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
            this List<HdfsBaseConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HdfsBaseConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HdfsBaseConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HdfsBaseConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HdfsBaseConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
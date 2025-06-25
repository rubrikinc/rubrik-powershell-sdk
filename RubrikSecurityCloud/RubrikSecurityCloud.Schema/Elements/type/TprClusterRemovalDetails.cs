// TprClusterRemovalDetails.cs
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
    #region TprClusterRemovalDetails
    public class TprClusterRemovalDetails: BaseType
    {
        #region members

        //      C# -> ClusterStatus? Status
        // GraphQL -> status: ClusterStatus! (enum)
        [JsonProperty("status")]
        public ClusterStatus? Status { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Ip
        // GraphQL -> ip: String! (scalar)
        [JsonProperty("ip")]
        public System.String? Ip { get; set; }

        //      C# -> System.Boolean? IsForce
        // GraphQL -> isForce: Boolean! (scalar)
        [JsonProperty("isForce")]
        public System.Boolean? IsForce { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprClusterRemovalDetails";
    }

    public TprClusterRemovalDetails Set(
        ClusterStatus? Status = null,
        System.String? Id = null,
        System.String? Ip = null,
        System.Boolean? IsForce = null,
        System.String? Location = null,
        System.String? Name = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Ip != null ) {
            this.Ip = Ip;
        }
        if ( IsForce != null ) {
            this.IsForce = IsForce;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> ClusterStatus? Status
        // GraphQL -> status: ClusterStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Ip
        // GraphQL -> ip: String! (scalar)
        if (this.Ip != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ip\n" ;
            } else {
                s += ind + "ip\n" ;
            }
        }
        //      C# -> System.Boolean? IsForce
        // GraphQL -> isForce: Boolean! (scalar)
        if (this.IsForce != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isForce\n" ;
            } else {
                s += ind + "isForce\n" ;
            }
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            if (conf.Flat) {
                s += conf.Prefix + "location\n" ;
            } else {
                s += ind + "location\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ClusterStatus? Status
        // GraphQL -> status: ClusterStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ClusterStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Ip
        // GraphQL -> ip: String! (scalar)
        if (ec.Includes("ip",true))
        {
            if(this.Ip == null) {

                this.Ip = "FETCH";

            } else {


            }
        }
        else if (this.Ip != null && ec.Excludes("ip",true))
        {
            this.Ip = null;
        }
        //      C# -> System.Boolean? IsForce
        // GraphQL -> isForce: Boolean! (scalar)
        if (ec.Includes("isForce",true))
        {
            if(this.IsForce == null) {

                this.IsForce = true;

            } else {


            }
        }
        else if (this.IsForce != null && ec.Excludes("isForce",true))
        {
            this.IsForce = null;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (ec.Includes("location",true))
        {
            if(this.Location == null) {

                this.Location = "FETCH";

            } else {


            }
        }
        else if (this.Location != null && ec.Excludes("location",true))
        {
            this.Location = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
    }


    #endregion

    } // class TprClusterRemovalDetails
    
    #endregion

    public static class ListTprClusterRemovalDetailsExtensions
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
            this List<TprClusterRemovalDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TprClusterRemovalDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TprClusterRemovalDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprClusterRemovalDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TprClusterRemovalDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
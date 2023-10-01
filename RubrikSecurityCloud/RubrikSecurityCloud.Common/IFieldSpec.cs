using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace RubrikSecurityCloud.Types
{
    public class FieldSpecConfig
    {
        public bool Flat { get; set; } = false;
        public int Indent { get; set; } = 0;
        public string Prefix { get; set; } = "";

        public string Node { get; set; } = "";

        public FieldSpecConfig Child(string thisNode = "", string childNode = "")
        {
            thisNode = string.IsNullOrEmpty(thisNode) ? this.Node : thisNode;
            return new FieldSpecConfig
            {
                Flat = this.Flat,
                Indent = this.Indent + 1,
                Prefix = this.Prefix +
                    (string.IsNullOrEmpty(thisNode) ? "" : thisNode + "."),
                Node = childNode
            };
        }

        public string IndentStr()
        {
            return new string(' ', this.Indent * 2);
        }
    }
    public interface IFieldSpec
    {
        string AsFieldSpec(FieldSpecConfig? conf=null);
        List<string> SelectedFields();
        void ApplyExploratoryFieldSpec(ExplorationContext ec);
        void SelectForRetrieval();
    }
}

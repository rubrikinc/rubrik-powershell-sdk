### GroupFilterAttributeList
Specifications for a Microsoft 365 configured group.

- filterOpType: JoinOpType
  - Specifies the filter operation with other filter attributes.
- attributeType: AttributeType
  - Specifies the type of Microsoft directory object attribute type to apply filer. For more information, see https://learn.microsoft.com/en-us/graph/extensibility-overview?tabs=http#comparison-of-extension-types.
- attributeKey: System.String
  - Specifies the name of the attribute to apply filter.
- attributeValue: System.String
  - Specifies the value of the attribute key.

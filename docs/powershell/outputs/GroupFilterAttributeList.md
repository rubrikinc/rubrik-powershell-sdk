### GroupFilterAttributeList
Specifies Attribute Filtering criteria to define member of groups.
For AD group, members would be users, whereas for Configured group members would
be Teams/ SharePoint.

- filterOpType: JoinOpType
  - Defines the criteria for multiple filter join type.
- attributeType: AttributeType
  - Specifies the attribute type.
- attributeKey: System.String
  - Specifies the name of the attribute to apply the filter.
- attributeValue: System.String
  - Specifies the value of the attribute to apply filter.
- isArchived: System.Boolean
  - Specifies if the attribute is archived.
- dataType: AttributeDataType
  - Specifies the data type of the attribute.

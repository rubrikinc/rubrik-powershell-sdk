### CellData
A single cell of a report row, holding the cell's value and any metadata
scoped to that cell.

- metadata: list of Metadatas
  - Metadata scoped to this cell rather than to the whole column.
- metadataV2: list of MetadataV2s
  - The new version of metadata object.
- displayableValue: DisplayableValue
  - The display value of the cell.

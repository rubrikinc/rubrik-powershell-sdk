### Row
Row is a generic message type similar to SQL row.

- values: list of CellDatas
  - The cells of the row, in the same order as the columns.
- metadata: list of Metadatas
  - The metadata associated with the row. Superseded by metadataV2.
- metadataV2: list of MetadataV2s
  - New version of metadata object.

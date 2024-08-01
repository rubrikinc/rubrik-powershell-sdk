### RecursiveCharacterChunkerConfigInput
- chunkSize: System.Int32
  - Size of the chunks in runes. Defaults to 1024 if not specified.
- chunkOverlap: System.Int32
  - Amount of runes to overlap with the previous chunk. Defaults to 100 if not specified.
- separators: list of System.Strings
  - List of separators to use to split text into chunks.
                Separators earlier in the list will be prioritized. Defaults
                to ["\n\n, "\n", " ", ""] if not specified.

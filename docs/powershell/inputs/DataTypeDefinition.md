### DataTypeDefinition
Represents the details of a data type.

- analyzerType: AnalyzerTypeEnum
  - The analyzer type must be either KEYWORD or REGEX.
- name: System.String
  - The name of the data type.
- dictionaryCsv: System.String
  - A CSV string representing the dictionary for the data type.
- regex: System.String
  - A regular expression pattern for matching the data type.
- risk: RiskLevelType
  - Represents risk associated with the given analyzer.
- ruleTypes: list of AnalyzerRuleTypes
  - Represents the types of data you need to analyze using this analyzer.
- keyRegex: System.String
  - Regex to filter fields that need to be analyzed for structured data.
- structuredValueRegex: System.String
  - Regex to analyze the structured data.
- structuredDictionaryCsv: System.String
  - Dictionary to analyze for the structured data.
- structuredKeyDictionaryCsv: System.String
  - A dictionary to filter fields that need to be analyzed for structured data by dictionary analyzers.
- proximityKeywordsRegex: System.String
  - Regex pattern for proximity keywords used to filter hits.
- proximityDistance: System.Int32
  - Maximum character distance for proximity keyword matching.
- excludeValueRegex: System.String
  - A matched value is excluded when it matches this regex. Users express
alternation themselves with `|` (e.g. `^000-|^999-`).

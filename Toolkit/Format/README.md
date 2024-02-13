# `Toolkit/Format/` Directory

## Overview

This directory contains the custom formatting files for types defined or
used within the `RubrikSecurityCloud` module. These files, in `.ps1xml` format,
are utilized by PowerShell to determine how to display objects of a
specific type in the console.

## How to Use

When you import the `RubrikSecurityCloud` module, the custom formatting
defined in this directory will be automatically applied, ensuring that objects
are displayed in a more informative and user-friendly way.

If you wish to view the default formatting or override the custom formatting,
you can do so using the `Format-Table`, `Format-List`, `Format-Wide`,
and `Format-Custom` cmdlets.

## Files in this Directory

Each file in this directory defines custom formatting for a specific RSC SDK type.

## Contributing

If you believe there are improvements to be made in our custom formatting
or if you've defined a new type that requires custom formatting, please:

1. Create a new `.ps1xml` file or update an existing one.
2. Submit a pull request with your changes for review.

## Additional Resources

- [About Format.ps1xml Files](https://docs.microsoft.com/powershell/scripting/developer/format/about-format.ps1xml-files?view=powershell-7.1)
- [Writing a Custom Format View](https://docs.microsoft.com/powershell/scripting/developer/format/writing-a-custom-format-view?view=powershell-7.1)

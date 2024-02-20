# Private Functions

This directory contains functions that are intended for internal use within
the toolkit. These functions are not exported by the module and are not meant
to be called directly by the end-users.

## Guidelines

1. **Encapsulation**: Ensure that any function placed in this directory is not
   directly exposed to the end-user. If a function needs to be exposed,
   consider placing it in the `Public/` directory instead.

2. **Naming**: While naming the functions, avoid generic names.
   Use descriptive function names to convey the purpose of the function clearly.

3. **Documentation**: While these functions are private, it's essential to
   provide inline comments or documentation for the sake of maintainability.
   It aids other developers in understanding the purpose and usage of the
   function.

4. **Dependencies**: If a private function is dependent on another function or
   external module, ensure to document this in the function's comments.

Please follow the module's contribution guidelines and code of conduct
when working within this directory.

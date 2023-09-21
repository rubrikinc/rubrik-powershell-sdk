# Public Functions

This directory contains functions that are directly exposed to the
end-users of the `RubrikSecurityCloud` module. These functions represent
the primary functionality and features that users interact with
when using the module.

## Guidelines

1. **Exposure**: Only place functions in this directory that you intend to
   expose to the end-users. Functions in this directory are automatically
   exported by the module.

2. **Naming**: Ensure that function names are clear, concise, and descriptive.
   This helps users intuitively understand the purpose and usage of the function.

3. **Documentation**: It's crucial to provide comprehensive inline comments
   and documentation for public functions. This not only aids in
   maintainability but also provides users with guidance on how to use
   the function effectively.

4. **Error Handling**: Implement robust error handling in public functions.
   Ensure that error messages are user-friendly and provide guidance
   on potential resolutions.

5. **Dependencies**: If a public function relies on a private function or
   an external module, make sure this is clearly documented in the
   function's comments.

6. **Examples**: Always include example usage in the function's documentation.
   This provides users with practical guidance on how to employ the function
   in their scripts or workflows.

Adhere to the toolkit's contribution guidelines and code of conduct when
developing or modifying functions within this directory.

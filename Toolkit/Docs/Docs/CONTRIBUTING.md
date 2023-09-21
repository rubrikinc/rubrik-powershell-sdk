# Contribution Guidelines for the Toolkit Directory

Welcome to the `Toolkit` section of the `RubrikSecurityCloud` module.
The Toolkit is dedicated to aiding end-users in their workflows,
going beyond the foundational functions provided by the core module.
If you're looking to contribute to this vital section,
please adhere to the following guidelines.

## Getting Started

1. **Understanding the Toolkit**: Familiarize yourself with the current
   structure and functions in the `Toolkit` directory.
   The Toolkit is designed to be user-friendly and intuitive.
2. **Clone & Branch**: If you're an external contributor,
   fork the repository first. Then, clone it to your local machine and
   create a new branch for your additions or changes.

## Code Quality

1. **User-Centric Design**: Always design with the end-user in mind.
   The Toolkit is meant to simplify and aid user workflows.
2. **Consistent Naming**: Ensure that the names of functions and cmdlets
   are clear, descriptive, and consistent with the existing naming conventions.
3. **Error Handling**: Implement robust error handling, especially when
   integrating with the core module or external systems.

## Documentation

1. **Function Documentation**: Every function, especially those in the
   `Public/` sub-directory, should be well-documented.
   This includes a synopsis, description, parameters, return values, and examples.
2. **Update README**: Update the `Public/` and `Private/` README files
   if your contribution changes or adds significant functionality.

## Testing

1. **Write Tests**: Write Pester tests for your additions, ensuring they
   integrate well with the core module and deliver the desired user experience.
2. **Test Integrations**: Since the Toolkit works closely with the core module,
   always test how your contributions interact with core functionalities.

## Pull Requests

1. **Focused Contributions**: Keep your contributions and pull requests
   targeted. Address one issue or feature at a time.
2. **Detail Your Changes**: Describe what your changes aim to achieve,
   how they do it, and the benefits for the end-users.
3. **Collaborate on Feedback**: Address any feedback from the maintainers
   or other contributors promptly and collaboratively.

## Code of Conduct

1. **Respect and Open-mindedness**: Respect all contributors.
   Be open to feedback, even if it's constructive criticism.
   Every contribution helps improve the Toolkit.
2. **Collaboration**: Remember, this is a collective effort.
   The more we collaborate, the better the Toolkit will be for the users.
3. **Stay Professional**: Harassment, derogatory remarks, or any unprofessional
   behavior will not be tolerated.

## Queries & Assistance

For any questions or assistance related to contributing to the `Toolkit`,
please reach out to the repo maintainers at
[github.com/rubrikinc/rubrik-powershell-sdk/discussions](https://github.com/rubrikinc/rubrik-powershell-sdk/discussions).

# PoCTestArchitecture

## What is architecture testing?

**PoCTestArchitecture** is a project that implements an architecture testing approach for applications, focusing on ensuring that the code structure adheres to established standards and principles. This type of test is essential for identifying architectural issues before they become more complex and costly to resolve.

Architecture tests verify whether the application's modules and components communicate correctly, if dependencies are properly organized, and whether design practices are followed. The goal is to promote cleaner, scalable, and maintainable code.

## Benefits of using architecture tests

1. **Early Problem Detection**: Helps identify architectural flaws before they impact development, saving time and resources.

2. **Improved Maintainability**: Keeps the code organized and understandable, facilitating future modifications and maintenance.

3. **Increased Scalability**: Ensures that the architecture supports application growth without requiring major restructuring.

4. **Compliance with Design Principles**: Ensures the application follows design principles such as SOLID, DRY, among others, promoting good development practices.

5. **Living Documentation**: Architecture tests serve as documentation, describing the intentions and interactions between application components.

6. **Easier Integration**: A well-defined architecture makes integrating new modules or services simpler and more efficient.

## How to run the tests

To execute the architecture tests included in this project, follow these steps:

1. Clone the repository:
   ```bash
   git clone https://github.com/CarlosEduardoGui/PoCTestArchitecture.git
   ```

2. Navigate to the project directory:
   ```bash
   cd PoCTestArchitecture
   ```
3. Restore project dependencies:
   ```bash
   dotnet restore
   ```
4. Run the tests:
   ```bash
   dotnet test
   ```
The tests will run, and you will see the results in the console.

## References
1. [.NetArchTest Nuget](https://github.com/BenMorris/NetArchTest)
2. [Architecture tests in.NET](https://medium.com/@v.cheshmy/architecture-tests-in-net-d95192faf2dd)
3. [Maintaining Architectural Integrity in .Net projects with NetArchTest](https://medium.com/@sugumar.p/maintaining-architectural-integrity-in-net-projects-with-netarchtest-31a08e6a5788)
4. [Enforcing Software Architecture With Architecture Tests](https://www.milanjovanovic.tech/blog/enforcing-software-architecture-with-architecture-tests)

## Contribution
Contributions are welcome! Feel free to open issues or pull requests for improvements or new features.

## License
This project is licensed under the MIT License.

# xUnit tests with GitHub Actions

This project implements a simple calculator in C# that supports basic arithmetic operations: addition, subtraction, multiplication, and division. The project also includes unit tests written using the xUnit framework and a GitHub Actions workflow to automate running these tests on each push to the `main` branch.

## Project Structure

### 1. `Calculator.cs`

This file contains the `Calculator` class, which provides the following methods:

- `int Add(int a, int b)`: Returns the sum of `a` and `b`.
- `int Subtract(int a, int b)`: Returns the difference when `b` is subtracted from `a`.
- `int Multiply(int a, int b)`: Returns the product of `a` and `b`.
- `int Division(int a, int b)`: Returns the quotient when `a` is divided by `b`.


### 2. UnitTests.cs

This file contains the unit tests for the Calculator class using the xUnit framework. Each method in the Calculator class is tested to ensure it functions correctly.

- `TestAddition`: Tests the Add method.
- `TestSubtraction`: Tests the Subtract method.
- `TestMultiplyn`: Tests the Multiply method.
- `TestDivide`: Tests the Division method.

### 3. .github/workflows/tests.yml

This file defines a GitHub Actions workflow that automatically runs the unit tests whenever code is pushed to the main branch. The workflow performs the following steps:

- `Checkout Repository`: Checks out the code from the repository.
- `Set up .NET`: Installs the .NET SDK (version 6.x).
- `Restore Dependencies`: Restores the project dependencies.
- `Run Unit Tests`: Executes the unit tests using dotnet test.

### Continuous Integration
This project uses GitHub Actions for continuous integration. The workflow defined in `.github/workflows/tests.yml` automatically runs the unit tests on each push to the main branch.

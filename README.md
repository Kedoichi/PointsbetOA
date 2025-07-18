# PointsBet_Backend_Online_Code_Test
This is a simple folder containing a `StringFormatter.cs` file for code enhancement.

For candidates, please follow the below points to complete the test:
- Read the `README.md` file in the root directory, which should be the same file you are reading now. :)
- Go to the `README.md` file
  - Read the comment in the `StringFormatter.cs` file
  - Follow the instructions in the comment to complete the task
- Once complete your solution, please submit the codebase to your GitHub and share the public link with our HR team

Thank you for completing the code test with PointsBet.

# Solution Overview
This solution demonstrates Test-Driven Development (TDD) approach with improved StringFormatter class.

# Improvements Made
Fixed typos
Added input validation with proper exception handling
Modernized syntax using string interpolation instead of string.Format
Improved variable naming for better readability

# Key Features
Converts string arrays to comma-separated lists with optional quotes
Handles null arrays, empty arrays, and null items gracefully
Supports any quote character (double quotes, single quotes, or no quotes)
Follows modern C# best practices and SOLID principles

# Running Tests
Run all tests:
dotnet test

Run tests with detailed output:
dotnet test --verbosity normal


# Test Coverage
The solution includes comprehensive unit tests covering:

- Basic functionality - Single and multiple items
- Different quote types - Double quotes, single quotes, empty quotes, null quotes
- Edge cases - Null arrays, empty arrays, null items in arrays
- Special characters - Items with spaces, commas, and special characters
- Performance - Large arrays (1000+ items)
- Error handling - Proper exception throwing with meaningful messages

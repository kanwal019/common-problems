# Common Problems

A collection of algorithm and data structure exercises in C# and C++, with console applications for running the examples. The C# projects target .NET 11 and use its default C# 15 language version.

## Solution structure

| Project | Purpose |
| --- | --- |
| [CSharp](CSharp/) | C# implementations of algorithms and programming exercises. |
| [CSharp.ConsoleApplication](CSharp.ConsoleApplication/) | Console entry point for running C# examples. References `CSharp`. |
| [Native](Native/) | Native C++ library containing the `FindKElement` exercise. |
| [NativeConsole](NativeConsole/) | Console entry point for the C++ example. References `Native`. |

All four projects are included in [CommonProblems.sln](CommonProblems.sln).

## Requirements

For the C# projects, install the **.NET 11 SDK**. Check the installed SDK with:

```sh
dotnet --version
```

For the native C++ projects, use Windows and Visual Studio with the **Desktop development with C++** workload. The project files specify:

- Windows SDK `10.0.26100.0`.
- MSVC toolset `v145` for Debug/Win32.
- MSVC toolset `v143` for Release/Win32 and both x64 configurations.

Install the toolsets required for your selected configuration.

## Build and run the C# examples

Run these commands from the repository root:

```sh
dotnet build CSharp.ConsoleApplication/CSharp.ConsoleApplication.csproj --configuration Release
dotnet run --project CSharp.ConsoleApplication/CSharp.ConsoleApplication.csproj --configuration Release --no-build
```

Building the console application also builds the referenced C# library.

The current entry point runs `TwoSum.DisplayResult()` with `[3, 2, 4]` and a target of `6`. It prints the zero-based indices of the matching pair:

```text
1
2
```

To run another exercise, replace the final call in [Program.cs](CSharp.ConsoleApplication/Program.cs). For example:

```csharp
CSharp.Strings.SeatManagement.DisplayResult(2, "1A 2F 1C");
```

Many exercises expose a `DisplayResult` method. Some use built-in sample data; others read from standard input. Check the implementation and its comments for the expected input format.

## Exercise categories

| Category | Examples |
| --- | --- |
| [Arrays](CSharp/Arrays/) | Two Sum, subsets, duplicates, pair sums, array shifts. |
| [Data structures](CSharp/DataStructures/) | Linked-list-style map, binary number rotations. |
| [Dynamic programming](CSharp/DynamicProgramming/) | Job sequencing, subject selection, water allocation. |
| [Searching](CSharp/Searching/) | Binary search, linear search, missing numbers, ranking. |
| [Sorting](CSharp/Sorting/) | Bubble sort, insertion sort, selection sort, merge sort. |
| [Strings](CSharp/Strings/) | Palindromes, word reversal, bracket decoding, seat management. |
| [Trees](CSharp/Trees/) | Tree comparison, distance-based leaf-pair counting. |
| [Other](CSharp/Other/) | Product-of-sum and palindrome-sum exercises. |

## Build and run the C++ example

1. Open `CommonProblems.sln` in Visual Studio.
2. Select a native build configuration, such as **Release | x64**.
3. Set `NativeConsole` as the startup project.
4. Build the solution and run the application.

The native entry point calls `FindKElement::DisplayResult()`. See [FindKElement.cpp](Native/FindKElement.cpp) for its input handling. The native projects require the Visual Studio C++ build tools in addition to the .NET SDK.

## Validation

Build the C# console project and run the selected exercise to check its output. The solution currently contains no automated test project.

## License

[MIT](LICENSE).

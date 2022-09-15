# Mercury New Media - Coding Skills Test

You are working with a top-tier state university that needs help accessing their student and course data.

The university currently offers 350 different courses to over 10,000 students.

Currently, we have two rough C# interfaces, `IStudentAPI` and `ICourseAPI`, with only one method each.

## Refactoring

We would like to see how you would improve the example code. Please include a couple sentences describing your changes
along with the rationale, along with any additional changes you would have made given more time.

---

### 1. Resolve Warnings

**Warning**
> The target framework 'netcoreapp2.0' is out of support and will not receive security updates in the future.

**Resolution**

Update projects to .NET 6 and update depenencies to corresponding versions

**Commit**

    build!: update projects to .NET6; bump deps; update README

### 2. Rename Classes and Interfaces

**Issue**\
According to the most commonly accepted C# naming conventions, acronyms should be capitalized according to the following rules. *(see references below for supporting documentation)*

> capitalize both characters on two-character acronyms\
> capitalize only the first character of acronyms with three or more characters

**Resolution**\
Rename the classes and interfaces as indicated below.

    R   SkillsTest.Lib.ICourseAPI           SkillsTest.Lib.ICourseApi
    R   SkillsTest.Lib.IStudentAPI          SkillsTest.Lib.IStudentApi
    R   SkillsTest.Tests.CourseAPITests     SkillsTest.Tests.CourseApiTests
    R   SkillsTest.Tests.StudentAPITests    SkillsTest.Tests.StudentApiTests
*Note: file names are also renamed to match the new class or interface name*

**Commit**

    refactor(naming): rename classes and interfaces to conform to accepted conventions for 
    capitalization of acronyms in identifiers; update README

*__References - C# Naming Conventions__*\
[*MSDN - Capitalization Rules for Identifiers*](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/capitalization-conventions#capitalization-rules-for-identifiers)\
[*Stack Overflow - C# naming conventions for acronyms*](https://stackoverflow.com/questions/2109171/c-sharp-naming-conventions-for-acronyms#:~:text=DO%20capitalize%20only%20the%20first,of%20a%20camel%2Dcased%20identifier.&text=DO%20NOT%20capitalize%20any%20of,of%20a%20camel%2Dcased%20identifier.)\
[*ktaranov - C# Coding Standards and Naming Conventions*](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md)

---

## API Design

Extend the `IStudentAPI` to include methods to satisfy the following criteria:

- Retrieve all students, ordered by last name, as a pageable result set
- Find all students enrolled in a specified course
- Find all students with a given last name

Extend the `ICourseAPI` to include methods to satisfy the following criteria:

- Retrieve all courses, ordered by course name, as a pageable result set
- Find a single course by name

Assume that the consumers of the interface will only receive the API specification, including any
documented assumptions, error conditions, and method parameters. Judicious use of XML comments on the interface
is encouraged.

Implement your newly added interface methods.

## Unit Testing

In order to validate your API, what unit tests would you need to ensure it works as specified? 

Implement those tests in the test project.

## Time

Please limit your time to 2 hours. Include a few sentences about the changes you made, or any
additional changes you would make given more time.

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

### 3. Move Implementation Classes to Separate Files

**Issue**\
According to the most commonly accepted C# conventions, a .cs file should, generally, contain only one class, interface, struct or enum.

While less important for smaller projects, this convention makes it easier to re-organize implementation classes into separate namespaces (or even separate projects) from your interfaces as the project grows.

It's common, in fact, to deliver interfaces in a separate package from implementation classes so that a consumer of the provided service can reference the package that contains the interface without having an explicit dependancy on the actual implementation.

**Resolution**\
Move the following classes into separate .cs files as indicated below.

| Class Name | Original File Name | New File Name |
| -------- | -------------- | ----------- |
| `SkillsTest.Lib.DbCourseApi` | `SkillsTest.Lib\ICourseApi.cs` | `SkillsTest.Lib\DbCourseApi.cs` |
| `SkillsTest.Lib.DbStudentApi` | `SkillsTest.Lib\IStudentApi.cs` | `SkillsTest.Lib\DbStudentApi.cs` |


**Commit**

    refactor(files): move DbCourseApi and DbStudentApi into separate source files from
    their corresponding interfaces

### 4. Add XMLDOC comments to DTO classes and interfaces
As a general rule, XMLDOC comments should be added to public types and members of public types.

These comments not only provide information to developers and consumers of the types but they can
also be usedto generate and publish technical documentation for your library or project.

**Commit**

    docs: add xmldoc comments for public dto classes and interfaces

### 5. Other Refactoring Changes

Given more time and if I knew how the size and scope of this project might change over time, I might consider the following changes.
 - Move the interfaces into a sub-folder called `Interfaces`
 - Move the DB API classes into a sub-folder called `Implementation` or `Services`

Or, depending on how the library is to be delivered, I might consider taking it a step further with the following changes.
 - Move the DTO classes and interfaces into a separate project called `SkillsTest.Abstractions`
 - Change namespace of DTO classes and interfaces accordingly
 - Add a reference in the `SkillsTest.Lib` project to the new `SkillsTest.Abstractions` project
 - Add a reference in the `SkillsTest.Tests` project to the new `SkillsTest.Abstractions` project

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

---

### 1. Add StudentEnrollment entity
In order to identify students who are enrolled in a specific course or courses in which a specific student is enrolled,
we need an entity to represent the many-to-many relationship between students and courses.  The following class was
added for this purpose.

    SkillsTest.Lib.StudentEnrollment

**Commit**

    feat(API Design): add StudentEnrollment entity


### 2. Add new methods to interfaces and implement them

The following methods were added to `ICourseApi`

```csharp
ICollection<Course> ICourseApi.GetAll(int pageSize, int pageNumber)
```
```csharp
Course ICourseApi.GetByName(string courseName)
```

The following methods were added to `IStudentApi`

```csharp
ICollection<Student> GetAll(int pageSize, int pageNumber)
```
```csharp
ICollection<Student> GetByCourseId(int courseId)
```
```csharp
ICollection<Student> GetByLastName(string lastName)
```

**Commit**

    feat(API Design): add new methods to APIs

---

## Unit Testing

In order to validate your API, what unit tests would you need to ensure it works as specified? 

Implement those tests in the test project.

---

### Update Unit Tests

I was able to add unit tests for the new methods for the CourseApi but ran out of time before I could get to the StudentApi.

**Commit**

    feat(API Design): update unit tests

---

## Time

Please limit your time to 2 hours. Include a few sentences about the changes you made, or any
additional changes you would make given more time.

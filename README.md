# F# Template with FsUnit Tests

This repository is a GitHub template for a basic F# application using FsUnit for testing.
It can be used for code katas

## Getting Started

You can either **clone directly**, **open in codespace** or **create a new repository from this template**.

### Clone the Repository

```bash
# clone the template
git clone https://github.com/babali42/fsharp-template-with-fsunit-tests.git
cd fsharp-template-with-fsunit-tests

# restore dependencies and build
dotnet restore
dotnet build

# run tests
dotnet test
```

### Open and run in Codespaces

This project works out of the box in GitHub Codespaces:

1. Click the **Code** button and choose **Open with Codespaces**.
2. Once the container loads, run the same build/test commands shown above.

### Use as a GitHub Template

1. In GitHub, navigate to this repository.
2. Click **Use this template** and follow the prompts to create a new repository under your account or organization.
3. Clone the newly created repository and follow the setup steps above.

## Structure

- `App.fs` - main application code
- `Test.fs` - sample FsUnit tests
- `fsharp-template-with-tests.fsproj` - project file

## Up-to-date

I use renovate to update the dependencies as soon as possible.

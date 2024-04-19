## Full Circle TMS Interview Sample Project

This is a simple web app backed by a SQLite database. It runs ASP.Net Core with Angular front end.
It does require login, but you can create a new user without verifying email (it does not email out anyways).
Once logged in you'll see two pages of interest: **Fetch Data** and **Todo**.

There is an admin user already created:
- Username: `administrator@localhost`
- Password: `Administrator1!`

## Tasks

We would like you to compete 4 small tasks using this project:

1. Bug Fix: on Todo list page, number of incomplete items doesnt show in the left panel when that todo list isnt selected
1. Add a temperature filter to fetch data page to allow users to filter the results by a temperature range
1. If no items show on the fetch data page, show an appropriate message instead of empty page
1. Add the ability to track a reminder on the to-do items. It should be optional. (There is already a field `Reminder` that you can use)

This should only take a 1-3 hours, if you find yourself stuck please don't hesitate to reach out. 
We're interested in learning your problem solving approach, not looking for specific solutions.

## Requirements

- .NET 8
- NodeJS (latest)

## Build

Run `dotnet build -tl` to build the solution.

## Run

To run the web application:

```bash
cd .\src\Web\
dotnet watch run
```

Navigate to https://localhost:5001. The application will automatically reload if you change any of the source files.

## Project Template

The project was generated using the [Clean.Architecture.Solution.Template](https://github.com/jasontaylordev/FctmsDemoApp) version 8.0.2. To learn more about the 
template go to the [project website](https://github.com/jasontaylordev/CleanArchitecture). Here you can find additional 
guidance, request new features, report a bug, and discuss the template with other users.
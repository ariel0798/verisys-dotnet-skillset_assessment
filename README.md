# Introduction
Weather forecast api, to test how an integration would have work with external service that cannot be modified.
# Getting Started
You can run the project with:
<br /><br />
A) .Net 8
<br />
or
<br />
B) Docker


### A) Installation process for .Net 8
1.	Download and install .Net 8 using this [link](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

### B) Installation process for Docker
1.	Download and install [Docker](https://docs.docker.com/engine/install/)
2. Download and install [Docker compose](https://docs.docker.com/compose/install/)

# Build and Test
To build the project clone the repository.
<br />
<br />
If you are using .Net 8 follow steps on option A, and if you are using Docker follow step on option B.

### A) Run with .Net 8

1. Open the repository on your terminal
2. Copy, Paste and Run commands bellow:


```
cd dotnet
cd WeatherForecast
dotnet run
```

3. Your code should run successfully.

### B) Run with Docker
1. Open the repository on your terminal
2. Copy, Paste and Run the command bellow:

```
docker-compose up -d
```

3. Wait for everything to run successfully


## Test
To test the api, you can use Swagger going to the following link [localhost](http://localhost:5074/swagger/index.html)
<br /><br />

# Contribute
### How to Contribute

We welcome contributions from developers of all skill levels. To contribute to this project, please follow these steps:

1. **Fork the Repository**: Start by forking the repository and cloning it locally, or create a new branch if you have access permissions.

2. **Create an Issue**: If you find a bug or have a suggestion for an improvement, check if it has already been reported. If not, submit a new issue describing your feedback or proposed changes.

3. **Submit a Pull Request (PR)**: Make your changes in a dedicated branch and then submit a pull request. Ensure your PR description clearly describes the problem and solution, including any relevant issue numbers.

4. **Code Review**: Wait for the code review process, where maintainers of the project will review your contributions. Be open to feedback and make any requested changes to your PR.

5. **Merge**: Once your PR is approved, a maintainer will merge it into the project.
# Rock, Paper, Scissors app

DISCLAIMER: This solution is overengineered for demonstration purposes!

This is a simple console application for playing "Rock, Paper, Scissors". 

The application demonstrates the use of:

    * .NET Framework
    * Object-Oriented Programming (OOP) principles
    * Strategy Pattern
    * Test-Driven Development (TDD)
    * Clean Architechture
    * Use of containers

This project is using the latest version of .NET but it's not mandatory as I'm not using any feature specific to the 9 version.


## What you'll need:

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
- [Docker](https://www.docker.com/get-started) installed on your machine.

## Building the Application:

1. Open a terminal and navigate to the project directory:

    ```sh
    cd /Users/erictamura/Documents/paper-rock-scissors
    ```

2. Restore the project dependencies:

    ```sh
    dotnet restore
    ```

3. Build the project:

    ```sh
    dotnet build
    ```

## Running the Application:

1. In the terminal, navigate to the project directory:

    ```sh
    cd /Users/erictamura/Documents/paper-rock-scissors
    ```

2. Run the application:

    ```sh
    dotnet run --project RockPaperScissors.Presentation
    ```

3. Follow the on-screen instructions to play the game.

## Running the Tests:

1. In the terminal, navigate to the project directory:

    ```sh
    cd /Users/erictamura/Documents/paper-rock-scissors
    ```

2. Run the tests:

    ```sh
    dotnet test
    ```

## Using docker:

1. Open a terminal and navigate to the project directory:

    ```sh
    cd /Users/erictamura/Documents/paper-rock-scissors
    ```

2. Build the Docker image:

    ```sh
    docker build -t rock-paper-scissors-app .
    ```

3. Run the Docker container:

    ```sh
    docker run -it --rm rock-paper-scissors-app
    ```

4. Follow the on-screen instructions to play the game.

## Project Structure

- `RockPaperScissors.Core/IMove.cs`: Interface for the moves (Rock, Paper, Scissors).
- `RockPaperScissors.Core/Rock.cs`, `RockPaperScissors.Core/Paper.cs`, `RockPaperScissors.Core/Scissors.cs`: Clases that implementations of the `IMove` interface.
- `RockPaperScissors.Application/MoveFactory.cs`: Factory class for creating move instances.
- `RockPaperScissors.Application/Game.cs`: Contains the game logic.
- `RockPaperScissors.Tests/GameTests.cs`: Unit tests for the game logic.
- `RockPaperScissors.Presentation/Program.cs`: Main entry point for the console application.
- `Dockerfile`: Dockerfile for containerizing the application.

## License

This project is licensed under the MIT License.

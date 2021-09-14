# Tic-Tac-Toe
 A singleplayer/multiplayer GUI Tic-Tac-Toe game, providing a competitive AI for the singleplayer mode, based on the minimax algorithm.

 <!-- ![Game](https://github.com/EmanuelPutura/Tic-Tac-Toe/blob/main/img/game.png) -->
 <p align="center"> <img src="https://github.com/EmanuelPutura/Tic-Tac-Toe/blob/main/img/game.png" height="400"/> </p>
 
 
## Setup
 1. Clone the repo:
    ```sh
    $ git clone https://github.com/EmanuelPutura/Tic-Tac-Toe
    ```
 2. From the project's location:
    ```sh
    $ cd ./TicTacToeGame/bin/Release
    $ TicTacToeGame.exe
    ```


## Features
- multiplayer game mode, played between two human players. A label tells the players which one of them has the current move.
- singleplayer game mode, played between a human player and the computer. The AI is implemented using the minimax algorithm - test all possible moves and always choose the best possible move.
- the current score between player X and player 0 is displayed


## Future Improvements
It is worth mentioning that, being created some time ago, during highschool, the application lacks several key concepts which I would use today, if I were to start refactoring the code (e.g., using a layered arhitecture, separating the user interface and the functionalities).

﻿using System.Linq;

namespace MazeSolver.Solver
{
    public class Solver
    {
        private Player player;
        private Mazes currentMaze;
        private Main mainInterface;

        public int
            maxMoves, 
            movesLeft;
        public bool
            finished = false;

        private string IsValidMove(Move newMove)
        {
            bool hitExit = false;

            if (newMove.GetMoveSize() == 0)
                return "No moves left";

            if (newMove.position.x != 0 && newMove.position.y != 0)
                return "Invalid move: "+ newMove.position.GetPositionString() + ", no multiple axis per move allowed.";

            string[] maze = currentMaze.GetMazeArray();
            Position oldPlayerPosition = player.GetPosition(maze);
            Position playerPosition = player.GetPosition(maze);

            // Move position to new requested pos.
            playerPosition.MovePosition(newMove);

            if (newMove.position.y != 0 && (playerPosition.y < 0 || playerPosition.y >= maze.Length))
                return "Invalid move: " + newMove.position.GetPositionString() + ", Y out of bounds.";

            char[] newPlayerChar = maze[playerPosition.y].ToCharArray();

            if (newMove.position.x != 0 && (playerPosition.x < 0 || playerPosition.x >= newPlayerChar.Length))
                return "Invalid move: " + newMove.position.GetPositionString() + ", X out of bounds.";

            // New position is a wall.
            if (newPlayerChar[playerPosition.x] == currentMaze.GetWallChar())
                return "Invalid move: " + newMove.position.GetPositionString() + ", new position is a wall";

            // Exit was hit.
            if (newPlayerChar[playerPosition.x] == currentMaze.GetExitChar())
                hitExit = true;

            // Replace path character with new player character position.
            newPlayerChar[playerPosition.x] = currentMaze.GetPlayerChar();
            
            // Split player chars so we can inspect the X axis path for walls.
            string[] xPlayerPositions = new string(newPlayerChar).Split(currentMaze.GetPlayerChar());

            // X, check if we collide with a wall.
            if (newMove.position.x != 0 && xPlayerPositions[1].Contains(currentMaze.GetWallChar()))
                return "Invalid move: " + newMove.position.GetPositionString() + ", X hit a wall between the path.";

            // Y, check if we collide while moving.
            if (newMove.position.y != 0)
            {
                int i = oldPlayerPosition.y, newIndex = playerPosition.y;
                while(i != newIndex) // Can't split Y lines, check each line.
                {
                    char[] simulatedPlayerChar = maze[i].ToCharArray();

                    if (simulatedPlayerChar[playerPosition.x] == currentMaze.GetWallChar()) // Collided.
                        return "Invalid move: " + newMove.position.GetPositionString() + ", Y hit a wall between the path.";

                    i = (i < playerPosition.y) ? ++i : --i;
                }
            }

            return hitExit ? "Finished maze." : "Successfully performed move.";
        }

        private void UpdateMaze(Move move)
        {
            string[] newMaze = currentMaze.GetMazeArray();
            Position playerPosition = player.GetPosition(newMaze);

            // Store old position
            Position oldPlayerPosition = player.GetPosition(newMaze);

            // Move position to new requested.
            playerPosition.MovePosition(move);

            // Remove old player character.
            newMaze[oldPlayerPosition.y] = newMaze[oldPlayerPosition.y].Replace(currentMaze.GetPlayerChar(), currentMaze.GetPathChar());

            // Replace path character with new player character position.
            char[] newPlayerChar = newMaze[playerPosition.y].ToCharArray();
            newPlayerChar[playerPosition.x] = currentMaze.GetPlayerChar();

            // Update new position to our maze array.
            newMaze[playerPosition.y] = new string(newPlayerChar);
            currentMaze.UpdateMaze(newMaze);

            // Update interface
            mainInterface.UpdateDisplay(movesLeft, maxMoves);
        }

        private bool PerformMove(int x, int y)
        {
            Move newMove = new Move(x, y);

            // Check if the new move is valid.
            string validMoveStatus = IsValidMove(newMove);

            if (validMoveStatus.StartsWith("Finished") || validMoveStatus.StartsWith("Success"))
            {
                // Perform move succeeded, update maze array to new move position.
                movesLeft--;
                UpdateMaze(newMove);
                mainInterface.PrintInformation("Move: " + newMove.position.GetPositionString() + " - Moves left: " + movesLeft, Main.Icons.MOVE);
            }
            else
            {
                // Can't move there.
                mainInterface.PrintInformation(validMoveStatus, Main.Icons.FAILED_MOVE);
                return false;
            }

            if(validMoveStatus.StartsWith("Finished"))
                mainInterface.PrintInformation(validMoveStatus, Main.Icons.EXIT);

            return true;
        }

        private void Maze1Demo()
        {
            // Small demo of manually solved path.
            PerformMove(0, -1);
            PerformMove(-17, 0);
            PerformMove(0, -13);
            PerformMove(8, 0);
            PerformMove(0, -3);
            PerformMove(-2, 0);
            PerformMove(0, -1);
        }

        public void SolveMaze()
        {
            mainInterface.PrintInformation("Begin solving", Main.Icons.START);

            // Todo: add algorithms here
            switch (currentMaze.GetSelectedIndex())
            {
                case 0:
                    Maze1Demo();
                    break;
                case 1:
                    mainInterface.PrintInformation("No solutions added yet.", Main.Icons.INFO);
                    break;
            }
        }

        public Solver(Main main, Mazes selectedMaze, int moveAmount)
        {
            maxMoves = movesLeft = moveAmount;
            mainInterface = main;
            currentMaze = selectedMaze;
            player = new Player(currentMaze);
        }
    }
}

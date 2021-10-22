
namespace MazeSolver.Source
{
    public class Helper
    {
        private Player player;
        private Mazes currentMaze;

        public int GetMaxMovement(Direction dir) // Get maximum move per direction.
        {
            // No point to do anything if there are no moves left.
            if (Solver.movesLeft == 0)
                return 0;

            string[] newMaze = currentMaze.GetMazeArray();
            bool maxFound = false;
            int x = 0, y = 0, returnAxis = 0;

            while (!maxFound)
            {
                Position playerPosition = player.GetPosition(newMaze);
                Move newMove = new Move(x, y);

                // Move position to new requested pos.
                playerPosition.MovePosition(newMove);

                char[] newPlayerChar = newMaze[playerPosition.y].ToCharArray();

                switch (dir)
                {
                    // X, check if we collide with a wall.
                    case Direction.LEFT: case Direction.RIGHT:
                        if (newPlayerChar[(dir == Direction.LEFT) ? (playerPosition.x - 1) : (playerPosition.x + 1)] == currentMaze.GetExitChar())
                        {
                            returnAxis = (dir == Direction.LEFT) ? -1 : 1;
                        }
                        else if (newPlayerChar[(dir == Direction.LEFT) ? (playerPosition.x - 1) : (playerPosition.x + 1)] == currentMaze.GetWallChar())
                        {
                            // Found collision, use the previous move as it the maximum.
                            returnAxis = newMove.position.x = (dir == Direction.LEFT) ? newMove.position.x++ : newMove.position.x--;
                        }
                        else
                        {
                            x = (dir == Direction.LEFT) ? --x : ++x;
                        }
                        break;

                    // Y, check if we collide while moving.
                    case Direction.UP: case Direction.DOWN:
                        newPlayerChar = newMaze[(dir == Direction.DOWN) ? (playerPosition.y + 1) : (playerPosition.y - 1)].ToCharArray();
                        if (newPlayerChar[playerPosition.x] == currentMaze.GetExitChar())
                        {
                            returnAxis = (dir == Direction.DOWN) ? 1 : -1;
                        }
                        else if (newPlayerChar[playerPosition.x] == currentMaze.GetWallChar()) // Collided.
                        {
                            returnAxis = newMove.position.y = (dir == Direction.DOWN) ? newMove.position.y-- : newMove.position.y++;
                        }
                        else
                        {
                            y = (dir == Direction.DOWN) ? ++y : --y;
                        }
                        break;
                }

                if(returnAxis != 0)
                    maxFound = true;
            }

            return returnAxis;
        }

        public Helper(Mazes selectedMaze)
        {
            currentMaze = selectedMaze;
            player = new Player(currentMaze);
        }
    }
}

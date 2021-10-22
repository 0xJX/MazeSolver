using System.Linq;

namespace MazeSolver.Source
{
    public enum Direction
    {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }

    public enum Icons
    {
        MOVE,
        START,
        EXIT,
        FAILED_MOVE,
        INFO
    }

    public class Position
    {
        public int x = 0, y = 0;

        public void MovePosition(Move move)
        {
            x += move.position.x;
            y += move.position.y;
        }

        public string GetPositionString()
        {
            return "(x: " + x + ", y:" + y + ")";
        }

        public Position(int newX, int newY)
        {
            x = newX;
            y = newY;
        }
    }

    public class Move
    {
        public Position position = new Position(0, 0);
        public Move(int x, int y)
        {
            position.x = x;
            position.y = y;
        }

        public int GetMoveSize()
        {
            return position.x + position.y;
        }
    }

    public class Player
    {
        private char playerChar;

        public Position GetPosition(string[] maze)
        {
            for (int i = 0; i < maze.Length; i++)
            {
                // Find the line that contains playerChar
                if (!maze[i].Contains(playerChar))
                    continue;

                char[] currentLine = maze[i].ToCharArray();
                for (int j = 0; j < currentLine.Length; j++)
                {
                    // Find the char position on the line where the playerChar is.
                    if (currentLine[j].Equals(playerChar))
                    {
                        Position iPos = new Position(j, i);
                        return iPos;
                    }
                }
            }

            // Unable to find position
            return new Position(0, 0);
        }

        public Player(Mazes currentMaze)
        {
            playerChar = currentMaze.GetPlayerChar();
        }
    }
}

using System;
using System.Linq;

namespace MazeSolver.Source
{
    public class Mazes
    {
        private string[] mazes =
        {
            "WALL='#', EXIT='E', PATH=' ', PLAYER='^'" + Environment.NewLine +
            "#######E########E####################" + Environment.NewLine +
            "# ### #   ###### #    #     #     # E" + Environment.NewLine +
            "# ### ### #      #  #    #     #    #" + Environment.NewLine +
            "# ### # # # ###### ##################" + Environment.NewLine +
            "#            #       #    #   #   # #" + Environment.NewLine +
            "#  # ##      # ##### #  # # # # # # #" + Environment.NewLine +
            "#  #         #   #   #  # # # # #   #" + Environment.NewLine +
            "#  ######   ###  #  ### # # # # ### #" + Environment.NewLine +
            "#  #    #               #   #   #   #" + Environment.NewLine +
            "#  # ## ########   ## ###########   #" + Environment.NewLine +
            "#    ##          ###                #" + Environment.NewLine +
            "# ## #############  ###   ####   ## #" + Environment.NewLine +
            "#  ### ##         #  #  #           #" + Environment.NewLine +
            "#  #   ## ####     #    #      ###  #" + Environment.NewLine +
            "#  # #### #  #     #    #####       #" + Environment.NewLine +
            "#  #      #      ###           ##   #" + Environment.NewLine +
            "#  #####           #   ##   #   #   #" + Environment.NewLine +
            "#                                   #" + Environment.NewLine +
            "##################^##################"
                ,
            "WALL='#', EXIT='E', PATH=' ', PLAYER='^'" + Environment.NewLine +
            "######################################" + Environment.NewLine +
            "#       # ###       ##   ###  #      #" + Environment.NewLine +
            "# ### # #     ### #### #  ##  # ###  #" + Environment.NewLine +
            "#   # # # ##### #       #  ## # # #  #" + Environment.NewLine +
            "# ### #   ##    #######  # #  # # #  #" + Environment.NewLine +
            "#   # # # #  ## #      # # #    # #  #" + Environment.NewLine +
            "# ### # # # #   # #### # # # ## # #  #" + Environment.NewLine +
            "#   # # # # # ###    # # # #         #" + Environment.NewLine +
            "# # # # ### # # #### # # #   #########" + Environment.NewLine +
            "#   # #   # # #   ^  # # # # #       #" + Environment.NewLine +
            "# # # ## ## # ## ##### # # #   ##### #" + Environment.NewLine +
            "#   #     # #    #   # # # #####     #" + Environment.NewLine +
            "# #########  ##### # ##  #       #####" + Environment.NewLine +
            "#         ##       #    ## ####### # E" + Environment.NewLine +
            "######### ################ #       # #" + Environment.NewLine +
            "#         #            #     ####### #" + Environment.NewLine +
            "# ######### ###### # # # #####       #" + Environment.NewLine +
            "#   #   #   #      # # ### # # #######" + Environment.NewLine +
            "# #   #   # # #### # #               #" + Environment.NewLine +
            "######################################"
        };

        private string 
            selectedMaze;
        private int 
            selectedIndex = 0;
        private char
            playerChar,
            wallChar,
            exitChar,
            pathChar;
        
        public char GetPlayerChar()
        {
            return playerChar;
        }
        public char GetWallChar()
        {
            return wallChar;
        }

        public char GetExitChar()
        {
            return exitChar;
        }

        public char GetPathChar()
        {
            return pathChar;
        }

        public int GetSelectedIndex()
        {
            return selectedIndex;
        }

        public string[] GetMazeArray()
        {
            if (GetSelectedIndex() >= mazes.Length || GetSelectedIndex() < 0)
                return new string[] { "Invalid index" };

            return selectedMaze.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
        }

        public void UpdateMaze(string[] newMaze)
        {
            string newMazeString = "";
            for (int i = 0; i < newMaze.Length; i++)
            {
                newMazeString += newMaze[i];
                if (i != newMaze.Length - 1)
                    newMazeString += Environment.NewLine;
            }
            selectedMaze = newMazeString;
        }

        private string ReadMaze(int index)
        {
            string maze = mazes[index];
            string[] mazeLines = maze.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            // Parse character rules
            string[] args = mazeLines[0].Split(',');

            if (!args[0].Contains('\''))
                return "Invalid character args!" + Environment.NewLine + "Use format (in same order): WALL = '#', EXIT = 'E', PATH = ' ', PLAYER = '^'";

            wallChar = args[0].Split('\'')[1].ToCharArray()[0];
            exitChar = args[1].Split('\'')[1].ToCharArray()[0];
            pathChar = args[2].Split('\'')[1].ToCharArray()[0];
            playerChar = args[3].Split('\'')[1].ToCharArray()[0];

            // Construct maze without args included.
            string parsedMaze = "";
            for(int i = 1; i < mazeLines.Length; i++)
            {
                parsedMaze += mazeLines[i];
                if (i != mazeLines.Length - 1)
                    parsedMaze += Environment.NewLine;
            }

            return parsedMaze;
        }
        public void SetMaze(int index)
        {
            // Invalid index, return
            if (index >= mazes.Length || index < 0)
                return;

            selectedIndex = index;
            selectedMaze = ReadMaze(index);
        }

        public string GetMaze()
        {
            return selectedMaze;
        }
    }
}

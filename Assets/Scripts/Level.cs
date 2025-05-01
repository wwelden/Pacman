using UnityEngine;

public class Level : MonoBehaviour
{
    public GameObject RedGhost;
    public GameObject OrangeGhost;
    public GameObject PinkGhost;
    public GameObject TealGhost;
    public GameObject Wall;
    public GameObject Pellet;
    public GameObject PowerPellet;
    public GameObject Cherry;
    public GameObject Strawberry;
    public GameObject Orange;
    public GameObject Apple;
    public GameObject PacMan;


    char[][] pacmanMaze = new char[][]
  {
    new char[] {'W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W'},
    new char[] {'W','.','.','.','.','.','.','W','W','.','.','.','.','.','.','W','W','.','.','.','.','W','W'},
    new char[] {'W','.','W','W','W','W','.','W','W','.','W','W','W','W','.','W','W','.','W','W','W','W','W'},
    new char[] {'W','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','W'},
    new char[] {'W','.','W','W','W','W','.','W','W','W','W','.','W','W','W','W','.','W','W','W','W','.','W'},
    new char[] {'W','.','W','.','.','.','.','W','W','W','W','.','W','W','W','W','.','.','.','.','W','.','W'},
    new char[] {'W','.','W','.','W','W','W','W','.','.','W','W','W','W','.','.','W','W','W','.','W','.','W'},
    new char[] {'W','.','.','.','.','.','.','.','+','.','.','.','.','+','.','.','.','.','.','.','.','.','W'},
    new char[] {'W','.','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','.','W'},
    new char[] {'W','.','W','.','.','.','.',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','W','.','W','W'},
    new char[] {'W','.','W','.','W','W','W',' ','W','W','W','W','W',' ','W','W','W',' ','W','W','.','W','W'},
    new char[] {'W','.','.','.','W','W','W',' ','W',' ',' ',' ','W',' ','W','W','W',' ','W','.','.','.','W'},
    new char[] {'W','W','W','.','W',' ',' ',' ','W',' ',' ',' ','W',' ',' ',' ','W','.','W','W','W','W','W'},
    new char[] {'W',' ',' ','W',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','W',' ',' ','W','W'},
    new char[] {'W',' ',' ','W',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','W',' ',' ','W','W'},
    new char[] {'W','W','W','.','W','W','W','W','W','W','W','W','W','W','W','W','W','.','W','W','W','W','W'},
    new char[] {'W','.','.','.','.','.','.','.','+','.','.','.','.','+','.','.','.','.','.','.','.','.','W'},
    new char[] {'W','.','W','W','W','W','.','W','W','.','W','W','W','W','.','W','W','.','W','W','W','W','W'},
    new char[] {'W','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','W'},
    new char[] {'W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W'}
  };

    private void BuildLevel(char[][] level)
    {
        Debug.Log("Building level");
        float rowNum = -((pacmanMaze.Length / 2) + 2);
        float colNum = -((pacmanMaze[0].Length / 2) + 2);
        float xOffset = rowNum;
        foreach (var i in level)
        {
            colNum++;
            foreach (var j in i)
            {
                rowNum++;
                Vector3 pos = new Vector3(rowNum, colNum, 0f);
                switch (j)
                {
                    case 'W':
                        PlaceWall(pos);
                        break;
                    case '.':
                        PlacePellet(pos);
                        break;
                    case '+':
                        PlacePowerPellet(pos);
                        break;
                    case '@':
                        PlacePacMan(pos);
                        break;
                    case 'R':
                        PlaceGhost(pos, j);
                        break;
                    case 'O':
                        PlaceGhost(pos, j);
                        break;
                    case 'P':
                        PlaceGhost(pos, j);
                        break;
                    case 'T':
                        PlaceGhost(pos, j);
                        break;
                    case 'C':
                        PlaceFood(pos, j);
                        break;
                    case 'S':
                        PlaceFood(pos, j);
                        break;
                    case 'A':
                        PlaceFood(pos, j);
                        break;
                    case ' ':
                        break;
                }
            }
            rowNum = xOffset;

        }

    }

    private void PlaceGhost(Vector3 pos, char ghost)
    {
        switch (ghost)
        {
            case 'R':
                Instantiate(RedGhost, pos, Quaternion.identity);
                break;
            case 'O':
                Instantiate(OrangeGhost, pos, Quaternion.identity);
                break;
            case 'P':
                Instantiate(PinkGhost, pos, Quaternion.identity);
                break;
            case 'T':
                Instantiate(TealGhost, pos, Quaternion.identity);
                break;
        }

    }

    private void PlaceWall(Vector3 pos)
    {
        Instantiate(Wall, pos, Quaternion.identity);
    }

    private void PlacePellet(Vector3 pos)
    {
        Instantiate(Pellet, pos, Quaternion.identity);
    }

    private void PlacePowerPellet(Vector3 pos)
    {
        Instantiate(PowerPellet, pos, Quaternion.identity);
    }
    private void PlacePacMan(Vector3 pos)
    {
        Instantiate(PacMan, pos, Quaternion.identity);
    }
    private void PlaceFood(Vector3 pos, char food)
    {
        switch (food)
        {
            case 'C':
                Instantiate(Cherry, pos, Quaternion.identity);
                break;
            case 'S':
                Instantiate(Strawberry, pos, Quaternion.identity);
                break;
            case 'O':
                Instantiate(Orange, pos, Quaternion.identity);
                break;
            case 'A':
                Instantiate(Apple, pos, Quaternion.identity);
                break;
        }
    }

    private void Start()
    {
        BuildLevel(pacmanMaze);
    }
}


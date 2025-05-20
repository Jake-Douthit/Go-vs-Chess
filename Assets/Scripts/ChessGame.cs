using UnityEngine;

public class ChessGame : MonoBehaviour
{
    public GameObject chessPiecePrefab; // Prefab for the chess piece

    private GameObject[,] positions = new GameObject[8,8];
    private GameObject[] playerWhite = new GameObject[16];

    private string currentPlayer = "white";
    private bool gameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerWhite = new GameObject[]
        {
            Create("RookWhite", 0, 0), Create("KnightWhite", 1, 0), Create("BishopWhite", 2, 0),
            Create("QueenWhite", 3, 0), Create("KingWhite", 4, 0), Create("BishopWhite", 5, 0),
            Create("KnightWhite", 6, 0), Create("RookWhite", 7, 0), Create("PawnWhite", 0, 1),
            Create("PawnWhite", 1, 1), Create("PawnWhite", 2, 1), Create("PawnWhite", 3, 1),
            Create("PawnWhite", 4, 1), Create("PawnWhite", 5, 1), Create("PawnWhite", 6, 1),
            Create("PawnWhite", 7, 1)
        };
        for (int i = 0; i < playerWhite.Length; i++)
        {
            SetPosition(playerWhite[i]);
        }
    }

    public GameObject Create(string name, int x, int y)
    {
        GameObject piece = Instantiate(chessPiecePrefab, new Vector3(0,0,-1), Quaternion.identity);
        ChessMen cm = piece.GetComponent<ChessMen>();
        cm.name = name;
        cm.SetXBoard(x);
        cm.SetYBoard(y);
        cm.Activate();
        return piece;
    }

    public void SetPosition(GameObject piece)
    {
        ChessMen cm = piece.GetComponent<ChessMen>();
        
        positions[cm.GetXBoard(), cm.GetYBoard()] = piece;
    }

    public void SetPositionEmpty(int x, int y)
    {
        positions[x, y] = null;
    }

    public GameObject GetPosition(int x, int y)
    {
        return positions[x, y];
    }

    public bool PositionOnBoard(int x, int y)
    {
        if (x < 0 || y < 0 || x >= positions.GetLength(0) || y >= positions.GetLength(1))
        {
            return false;
        }
        else 
        {
            return true;
        }
    }
}

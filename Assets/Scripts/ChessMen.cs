using UnityEngine;
using UnityEngine.VFX;

public class ChessMen : MonoBehaviour
{
    public GameObject controler;
    public GameObject movePlate;

    private int xBoard = -1;
    private int yBoard = -1;

    private string player;

    public Sprite BishopWhite, PawnWhite, KnightWhite, RookWhite, KingWhite, QueenWhite;


    public void Activate()
    {
        controler = GameObject.FindGameObjectWithTag("GameController");

        SetCoords();
        switch (this.name)
        {
            case "BishopWhite":
                this.GetComponent<SpriteRenderer>().sprite = BishopWhite;
                break;
            case "PawnWhite":
                this.GetComponent<SpriteRenderer>().sprite = PawnWhite;
                break;
            case "KnightWhite":
                this.GetComponent<SpriteRenderer>().sprite = KnightWhite;
                break;
            case "RookWhite":
                this.GetComponent<SpriteRenderer>().sprite = RookWhite;
                break;
            case "KingWhite":
                this.GetComponent<SpriteRenderer>().sprite = KingWhite;
                break;
            case "QueenWhite":
                this.GetComponent<SpriteRenderer>().sprite = QueenWhite;
                break;
        }
    }

    public void SetCoords()
    {
        float x = xBoard;
        float y = yBoard;

        x *= 1.29f;
        y *= 1.30f;

        x += -4.5f;
        y += -4.5f;

        this.transform.position = new Vector3(x, y, -1f);
    }

    public int GetXBoard()
    {
        return xBoard;
    }

    public int GetYBoard()
    {
        return yBoard;
    }

    public void SetXBoard(int x)
    {
        xBoard = x;
    }

    public void SetYBoard(int y)
    {
        yBoard = y;
    }

    public void OnMouseUp()
    {
        DestroyMovePlates();

        InitiateMovePlates();
    }

    public void DestroyMovePlates()
    {
        GameObject[] movePlates = GameObject.FindGameObjectsWithTag("MovePlate");
        for (int i = 0; i < movePlates.Length; i++)
        {
            Destroy(movePlates[i]);
        }
    }

    public void InitiateMovePlates()
    {
        switch (this.name)
        {
            case "BishopWhite":
                LineMovePlate(1, 1);
                LineMovePlate(-1, -1);
                LineMovePlate(1, -1);
                LineMovePlate(-1, 1);

                break;
            case "PawnWhite":
                LineMovePlate(1, 0);
                break;
            case "KnightWhite":
                LMovePlate();
                break;
            case "RookWhite":
                LineMovePlate(1, 0);
                LineMovePlate(0, 1);
                LineMovePlate(-1, 0);
                LineMovePlate(0, -1);

                break;
            case "KingWhite":
                SurroundMovePlate();
                break;
            case "QueenWhite":
                LineMovePlate(1, 0);
                LineMovePlate(0, 1);
                LineMovePlate(-1, 0);
                LineMovePlate(0, -1);
                LineMovePlate(1, 1);
                LineMovePlate(0, 0);
                LineMovePlate(1, -1);
                LineMovePlate(-1, 1);

                break;
        }

    }

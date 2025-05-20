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

        x *= 1.27f;
        y *= 1.25f;

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

}

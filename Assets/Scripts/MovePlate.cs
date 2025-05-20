using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovePlate : MonoBehaviour
{
    public GameObject controller;

    GameObject reference = null;

    private int matrixX;
    private int matrixY;

    public bool attack = false;

    public void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0.5f);
    }

    public void OnMouseUp()
    { 

        controller = GameObject.FindGameObjectWithTag("GameController");

        if (attack) 
        {
            GameObject cp = controller.GetComponent<ChessGame>().GetPosition(matrixX, matrixY);

            Destroy(cp);
        }

        controller.GetComponent<ChessGame>().SetPositionEmpty(reference.GetComponent<ChessMen>().GetXBoard(), reference.GetComponent<ChessMen>().GetYBoard());

        reference.GetComponent<ChessMen>().SetXBoard(matrixX);
        reference.GetComponent<ChessMen>().SetYBoard(matrixY);
        reference.GetComponent<ChessMen>().SetCoords();

        controller.GetComponent<ChessGame>().SetPosition(reference);
        controller.GetComponent<ChessMen>().DestroyMovePlates();
    }

    public void SetCoords(int x, int y)
    {
        matrixX = x;
        matrixY = y;
    }

    public void SetReference(GameObject obj)
    {
        reference = obj;
    }

    public GameObject GetReference()
    {
        return reference;
    }

}

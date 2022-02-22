using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionPuzzle : MonoBehaviour
{
    // raycasting and drawing the line
    [SerializeField]
    private LineRenderer connectionLine;
    [SerializeField]
    private GameObject start;

    // moving the pieces of the stage
    private float bluePosition, redPosition;
    [SerializeField]
    private GameObject blueTiles, redTiles;
    private Vector3 blueStart, redStart;

    private void Start()
    {
        blueStart = blueTiles.transform.position;
        redStart = redTiles.transform.position;
    }

    private void Update()
    {
        // moving the blocks
        blueTiles.transform.position = blueStart + new Vector3(0f, bluePosition, 0f);
        redTiles.transform.position = redStart + new Vector3(0f, redPosition, 0f);

        // checking the connection
        RaycastHit2D hit = Physics2D.Raycast(start.transform.position, Vector3.right, 20f);
        if (hit.collider != null)
        {
            connectionLine.SetPosition(1, new Vector3(hit.point.x, hit.point.y, -9));
            if (hit.collider.tag == "Endpoint")
            {
                connectionLine.SetPosition(1, new Vector3(8, 0, -9)); // line was not connecting all the way
                ConnectionApplication app = FindObjectOfType<ConnectionApplication>();
                if (app != null)
                {
                    app.CompletePuzzle();
                } 
            }
        }
    }

    public void UpdateBluePosition(float pos)
    {
        bluePosition = pos;
    }

    public void UpdateRedPosition(float pos)
    {
        redPosition = pos;
    }
}

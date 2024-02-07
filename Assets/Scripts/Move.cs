using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Move : MonoBehaviour
{
    public TileBase TileToSet;

    public Transform player;

    private Tilemap map;
    private Camera mainCamera;

    void Start()
    {
        map= GetComponent<Tilemap>();
        mainCamera= Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 clickWorldPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

            Vector3Int clickCellPos = map.WorldToCell(clickWorldPos);

            player.position = map.CellToWorld(clickCellPos);
        }
    }
}

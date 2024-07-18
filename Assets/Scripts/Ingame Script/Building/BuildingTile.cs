using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "New Building Tile", menuName = "Tiles/BuildingTile")]
public class BuildingTile : Tile
{
    public Building building;

    public override void RefreshTile(Vector3Int position, ITilemap tilemap)
    {
        base.RefreshTile(position, tilemap);
    }

    public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
    {
        base.GetTileData(position, tilemap, ref tileData);
        if (building != null)
        {
            tileData.sprite = building.GameSprite;
        }
    }
}

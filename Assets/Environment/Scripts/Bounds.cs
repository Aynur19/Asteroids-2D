using UnityEngine;

public class Bounds : MonoBehaviour
{
    public Transform wall;
    public Camera mainCamera;

    private void Start()
    {
        var westWall = Instantiate(wall, new Vector2(Constants.xMinPos - 0.5f, 0f), Quaternion.identity);
        westWall.localScale = new Vector3(1f, 2 * Constants.yMaxPos, 1f);

        var eastWall = Instantiate(wall, new Vector2(Constants.xMaxPos + 0.5f, 0f), Quaternion.identity);
        eastWall.localScale = new Vector3(1f, 2 * Constants.yMaxPos, 1f);

        var northWall = Instantiate(wall, new Vector2(0f, Constants.yMinPos - 0.5f), Quaternion.identity);
        northWall.localScale = new Vector3(2 * Constants.xMaxPos, 1f, 1f);

        var southWall = Instantiate(wall, new Vector2(0f, Constants.yMaxPos + 0.5f), Quaternion.identity);
        southWall.localScale = new Vector3(2 * Constants.xMaxPos, 1f, 1f);
    }
}

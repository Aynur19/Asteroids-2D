using UnityEngine;

public class Bounds : MonoBehaviour
{
	public Transform wall;
    public Camera mainCamera;

    private float xPos = 0f;
    private float yPos = 0f; 

    private void Start()
    {
        xPos = ConvertToUnit(Screen.width / 2f);
        yPos = ConvertToUnit(Screen.height / 2f);

        Debug.Log($"xPos: {xPos}, yPos: {yPos}");
        Debug.Log($"xPos: {ConvertToUnit(xPos)}, yPos: {ConvertToUnit(yPos)}");

        var westWall = Instantiate(wall, new Vector2(-xPos - 0.5f, 0f), Quaternion.identity);
        westWall.localScale = new Vector3(1f, 2 * yPos, 1f);

        var eastWall = Instantiate(wall, new Vector2(xPos + 0.5f, 0f), Quaternion.identity);
        eastWall.localScale = new Vector3(1f, 2 * yPos, 1f);

        var northWall = Instantiate(wall, new Vector2(0f, -yPos - 0.5f), Quaternion.identity);
        northWall.localScale = new Vector3(2 * xPos, 1f, 1f);

        var southWall = Instantiate(wall, new Vector2(0f, yPos + 0.5f), Quaternion.identity);
        southWall.localScale = new Vector3(2 * xPos, 1f, 1f);
    }

    private float ConvertToUnit(float pixels)
	{
        var ortho = mainCamera.orthographicSize;
        var pixelH = mainCamera.pixelHeight;

        return (pixels * ortho * 2) / pixelH;
	}
}

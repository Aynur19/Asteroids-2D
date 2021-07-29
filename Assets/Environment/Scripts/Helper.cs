using UnityEngine;

public static class Helper
{
	public static float ConvertToUnit(float pixels, Camera cam)
	{
		var ortho = cam.orthographicSize;
		var pixelH = cam.pixelHeight;

		return (pixels * ortho * 2) / pixelH;
	}
}

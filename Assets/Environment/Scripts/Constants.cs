using UnityEngine;

public static class Constants
{
	public static float xMaxPos = Helper.ConvertToUnit(Screen.width / 2f, Camera.main);
	public static float xMinPos = -xMaxPos;

	public static float yMaxPos = Helper.ConvertToUnit(Screen.height / 2f, Camera.main);
	public static float yMinPos = -yMaxPos;

	public const float bulletImpulseForce = 20;
}
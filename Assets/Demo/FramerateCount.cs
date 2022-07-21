using UnityEngine;

public class FramerateCount: MonoBehaviour
{
    public static string fpsString { get; private set; }

    private void Update()
    {
        var fps = 1.0f / Time.deltaTime;
        fpsString = Mathf.Ceil(fps).ToString();
    }
}
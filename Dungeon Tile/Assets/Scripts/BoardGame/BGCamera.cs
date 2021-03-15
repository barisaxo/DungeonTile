using UnityEngine;

public class BGCamera : MonoBehaviour
{/* My copy-pastable camera script. Has my prefered default Camera settings. 
  * Save important tricks picked-up over time. 
  * Also has a random color background.*/

    public BGM bgm;
    public Camera cam;
    public float vertical, horizontal, screenRatio, targetRatio;
    //public Light lights;

    void Awake()
    {
        cam = gameObject.AddComponent<Camera>();
        cam.orthographic = false;
        cam.orthographicSize = 8;
        // cam.orthographicSize = Screen.height / Screen.width * .5f;
        cam.farClipPlane = 1500;
        cam.nearClipPlane = 5;

        cam.backgroundColor = new Color(Rand(), Rand(), Rand(), 1);

        vertical = cam.orthographicSize * ((float)Screen.height / Screen.width);
        horizontal = cam.orthographicSize * ((float)Screen.width / Screen.height);

        //cam.transform.position = new Vector3(0, 0, -10);
        //gameObject.transform.Translate(new Vector3(0, (int)cam.orthographicSize - vertical), 0);
    }

    /* Some default Lighting.*/
    //private void Start()
    //{
    //    //lights = gameObject.AddComponent<Light>();
    //    //lights.type = LightType.Area;
    //    //lights.areaSize = new Vector2(900, 900);
    //    //lights.intensity = .7f;
    //    //lights.range = 3000;
    //    //lights.lightmapBakeType = LightmapBakeType.Baked;
    //}

    float Rand() { return Random.Range(0.01f, 0.2f); }
}



/*
*IMPORTANT INFO:
* Vertical is always 2x orthographic size.
* Vertical scale is always 50.
*
*
*
*
*
*        //vertical = (int)cam.GetComponent<Camera>().orthographicSize;
         //horizontal = vertical * (Screen.width / Screen.height);
*
*
*
        vertical = cam.orthographicSize * ((float)Screen.height / Screen.width);
        horizontal = cam.orthographicSize * ((float)Screen.width / Screen.height);



*screenRatio = Screen.width / Screen.height;
targetRatio = 16 / 9;

if (screenRatio >= targetRatio)
{
    cam.orthographicSize = 8;
}
else
{
    float sizeDif = targetRatio / screenRatio;
    cam.orthographicSize = 8 * sizeDif;
}

*/
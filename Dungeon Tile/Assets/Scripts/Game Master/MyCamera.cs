using System.Collections;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    public GM gm;
    public Camera cam;
    public float vertical, horizontal, screenRatio, targetRatio;

    //public Light lights;

    void Awake()
    {
        cam = gameObject.AddComponent<Camera>();
        cam.orthographic = true;
        cam.orthographicSize = 8;
        cam.farClipPlane = 1500;
        // cam.orthographicSize = Screen.height / Screen.width * .5f;
        //cam.backgroundColor = new Color(Rand(), Rand(), Rand());

        vertical = cam.orthographicSize * ((float)Screen.height / Screen.width);
        horizontal = cam.orthographicSize * ((float)Screen.width / Screen.height);
        cam.transform.position = new Vector3(0, 0, -10);

        // gameObject.transform.Translate(new Vector3(0, (int)cam.orthographicSize - vertical), 0);
    }

    //private void Start()
    //{


    //    //lights = gameObject.AddComponent<Light>();
    //    //lights.type = LightType.Area;
    //    //lights.areaSize = new Vector2(900, 900);
    //    //lights.intensity = .7f;
    //    //lights.range = 3000;
    //    //lights.lightmapBakeType = LightmapBakeType.Baked;
    //}


}



/*
*IMPORTANT INFO
* vertical is always 2x orthographic size
* vertical scale is always 50
*
*
*        //vertical = (int)cam.GetComponent<Camera>().orthographicSize;
    //horizontal = vertical * (Screen.width / Screen.height);
*
*
*
    vertical = cam.orthographicSize * ((float)Screen.height / Screen.width);
    horizontal = cam.orthographicSize * ((float)Screen.width / Screen.height);
*/



/* probably trash:
 * 
 * 
 *     static float Rand()
    {
        return Random.Range(.01f, .1f);
    }



 *         screenRatio = Screen.width / Screen.height;
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
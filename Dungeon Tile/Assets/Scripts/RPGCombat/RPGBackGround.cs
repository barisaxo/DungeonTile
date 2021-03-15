using UnityEngine;

public class RPGBackGround : MonoBehaviour
{
    public RPGGM rpggm;

    GameObject bg1, bg2;

    float rFund1, rFund2, z1, z2, sFund1, sFund2, rOT1, rOT2, sOT1, sOT2;
    //Fundamental Tones & Over Tones

    private void Start()
    {
        bg1 = new GameObject("BackGround 1");
        bg1.transform.SetParent(gameObject.transform);
        bg1.transform.position = new Vector3(0, 0, 25);

        SpriteRenderer sr1 = bg1.AddComponent<SpriteRenderer>();
        sr1.sprite = rpggm.assetSub.sprite[1];


        bg2 = new GameObject("BackGround 2");
        bg2.transform.SetParent(gameObject.transform);
        bg2.transform.position = new Vector3(0, 0, 25);

        SpriteRenderer sr2 = bg2.AddComponent<SpriteRenderer>();
        sr2.sprite = rpggm.assetSub.sprite[2];


        rFund1 = Random.Range(.3f, .5f);
        rFund2 = Random.Range(.3f, .5f);

        sFund1 = Random.Range(.1f, .25f);
        sFund2 = Random.Range(.1f, .25f);

        sOT1 = Random.Range(1.8f, 2f);
        sOT2 = Random.Range(1.8f, 2f);

        rOT1 = Random.Range(.02f, .03f);
        rOT2 = Random.Range(.02f, .03f);

        z1 = Random.Range(.025f, .03f);
        z2 = Random.Range(.5f, .65f);
    }

    private void Update()
    {//strange pulsing background motions
        float xy1 = 15 + (15 * Mathf.Abs(Mathf.Sin(Time.time * sFund1) * rFund1) +
            (Mathf.Sin(Time.time * sOT1) * rOT1));
        bg1.transform.rotation = Quaternion.Euler(0, 0, Mathf.Abs(Mathf.Sin(Time.time * z1) * 180));
        bg1.transform.localScale = new Vector3(xy1 - 1.25f, xy1 - 1.25f, 1);
        bg1.transform.position = new Vector3(0, 0, 25 + xy1);


        float xy2 = 15 + (15 * Mathf.Abs(Mathf.Sin(Time.time * sFund2) * rFund2) +
            (Mathf.Sin(Time.time * sOT2) * rOT2));
        bg2.transform.rotation = Quaternion.Euler(0, 0, -Time.time * z2);
        bg2.transform.localScale = new Vector3(xy2 + .75f, xy2 + .75f, 1);
        bg2.transform.position = new Vector3(0, 0, 25 + xy2);

        //Debug.Log(xy1 + " " + xy2);
    }
}
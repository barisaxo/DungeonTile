using UnityEngine;

public class RPGNME : MonoBehaviour
{
    public RPGGM rpggm;
    public RPGBattleManager bm;

    public GameObject nmeParent, nme1, nme2, nme3, nme4, nme1B, nme2B, nme3B, nme4B;

    public void SetUp()
    {
        bm = rpggm.bm;

        //create a parent gameobject to keep organized
        nmeParent = new GameObject("NME Parent");
        nmeParent.transform.SetParent(bm.transform);

        SpawnNME();
    }

    public void SpawnNME()
    {
        /*
         * NME's:
         * 
         * create GameObject
         * Add SpriteRenderer Component
         * assign Sprite
         * assign Color
         * Place in appropriate screen position
         * Set Parent
         * Disable
         */

        //NME One
        nme1 = new GameObject("NME One");
        SpriteRenderer nme1SR = nme1.AddComponent<SpriteRenderer>();
        nme1SR.sprite = rpggm.assetSub.sprite[3];
        nme1SR.color = Color.black;
        nme1.transform.position = new Vector3(-8, 3.5f, 10);
        nme1.transform.localScale = new Vector3(2, 2, 1);
        nme1.transform.SetParent(nmeParent.transform);
        nme1.SetActive(false);

        //NME Two
        nme2 = new GameObject("NME Two");
        SpriteRenderer nme2SR = nme2.AddComponent<SpriteRenderer>();
        nme2SR.sprite = rpggm.assetSub.sprite[3];
        nme2SR.color = Color.black;
        nme2.transform.position = new Vector3(-3, 4, 10);
        nme2.transform.localScale = new Vector3(2, 2, 1);
        nme2.transform.SetParent(nmeParent.transform);
        nme2.SetActive(false);

        //NME Three
        nme3 = new GameObject("NME Three");
        SpriteRenderer nme3SR = nme3.AddComponent<SpriteRenderer>();
        nme3SR.sprite = rpggm.assetSub.sprite[3];
        nme3SR.color = Color.black;
        nme3.transform.position = new Vector3(2, 5f, 10);
        nme3.transform.localScale = new Vector3(2, 2, 1);
        nme3.transform.SetParent(nmeParent.transform);
        nme3.SetActive(false);

        //NME Four
        nme4 = new GameObject("NME Four");
        SpriteRenderer nme4SR = nme4.AddComponent<SpriteRenderer>();
        nme4SR.sprite = rpggm.assetSub.sprite[3];
        nme4SR.color = Color.black;
        nme4.transform.position = new Vector3(7, 4.5f, 10);
        nme4.transform.localScale = new Vector3(2, 2, 1);
        nme4.transform.SetParent(nmeParent.transform);
        nme4.SetActive(false);



        /*
         * NME Borders:
         * 
         * Create border GameObject
         * Add SpriteRenderer Component
         * assign sprite
         * assign color
         * set parent
         * set position
         */

        //NME Border 1
        nme1B = new GameObject("NME One Boarder");
        SpriteRenderer nme1BSR = nme1B.AddComponent<SpriteRenderer>();
        nme1BSR.sprite = rpggm.assetSub.sprite[3];
        nme1BSR.color = new Color(0, 0, 0, 0);
        nme1B.transform.SetParent(nme1.transform);
        nme1B.transform.position = nme1.transform.position;
        nme1B.transform.Translate(new Vector3(0, 0, 10));
        nme1B.transform.localScale = new Vector3(1.2f, 1.2f, 1);

        //NME Border 2
        nme2B = new GameObject("NME Two Boarder");
        SpriteRenderer nme2BSR = nme2B.AddComponent<SpriteRenderer>();
        nme2BSR.sprite = rpggm.assetSub.sprite[3];
        nme2BSR.color = new Color(0, 0, 0, 0);
        nme2B.transform.SetParent(nme2.transform);
        nme2B.transform.position = nme2.transform.position;
        nme2B.transform.Translate(new Vector3(0, 0, 10));
        nme2B.transform.localScale = new Vector3(1.2f, 1.2f, 1);

        //NME Border 3
        nme3B = new GameObject("NME Three Boarder");
        SpriteRenderer nme3BSR = nme3B.AddComponent<SpriteRenderer>();
        nme3BSR.sprite = rpggm.assetSub.sprite[3];
        nme3BSR.color = new Color(0, 0, 0, 0);
        nme3B.transform.SetParent(nme3.transform);
        nme3B.transform.position = nme3.transform.position;
        nme3B.transform.Translate(new Vector3(0, 0, 10));
        nme3B.transform.localScale = new Vector3(1.2f, 1.2f, 1);

        //NME Border 4
        nme4B = new GameObject("NME Four Boarder");
        SpriteRenderer nme4BSR = nme4B.AddComponent<SpriteRenderer>();
        nme4BSR.sprite = rpggm.assetSub.sprite[3];
        nme4BSR.color = new Color(0, 0, 0, 0);
        nme4B.transform.SetParent(nme4.transform);
        nme4B.transform.position = nme4.transform.position;
        nme4B.transform.Translate(new Vector3(0, 0, 10));
        nme4B.transform.localScale = new Vector3(1.2f, 1.2f, 1);
    }

    public void EnableNME()
    {
        //add a random number of NME to battle
        int noOfNME = Random.Range(1, 5);



        /*
         * Enable NME's on battle start:
         * 
         * Enable GameObject
         * assign AudioClip & add to List
         * add Game Object to List
         * add NMEBorder to list
         * add NMESprite Renderer to list -> color may be changed later
         * assign color
         */

        //Enable NME 1
        nme1.SetActive(true);
        bm.nmeAC.Add(rpggm.assetSub.audioClips[Random.Range(3, 6)]);
        bm.nmeGO.Add(nme1);
        bm.nmeBorderSR.Add(nme1B.GetComponent<SpriteRenderer>());
        // Debug.Log("NME.EnableNME: ADD bsr: " + nme1B);
        bm.nmeSR.Add(nme1.GetComponent<SpriteRenderer>());
        nme1.GetComponent<SpriteRenderer>().color = Color.black;

        //Enable NME 2
        if (noOfNME >= 2)
        {
            nme2.SetActive(true);
            bm.nmeAC.Add(rpggm.assetSub.audioClips[Random.Range(3, 6)]);
            bm.nmeGO.Add(nme2);
            bm.nmeBorderSR.Add(nme2B.GetComponent<SpriteRenderer>());
            // Debug.Log("NME.EnableNME: ADD bsr: " + nme2B);
            bm.nmeSR.Add(nme2.GetComponent<SpriteRenderer>());
            nme2.GetComponent<SpriteRenderer>().color = Color.black;
        }

        //Enable NME 3
        if (noOfNME >= 3)
        {
            nme3.SetActive(true);
            bm.nmeAC.Add(rpggm.assetSub.audioClips[Random.Range(3, 6)]);
            bm.nmeGO.Add(nme3);
            bm.nmeBorderSR.Add(nme3B.GetComponent<SpriteRenderer>());
            // Debug.Log("NME.EnableNME: ADD bsr: " + nme3B);
            bm.nmeSR.Add(nme3.GetComponent<SpriteRenderer>());
            nme3.GetComponent<SpriteRenderer>().color = Color.black;
        }

        //Enable NME 4
        if (noOfNME >= 4)
        {
            nme4.SetActive(true);
            bm.nmeAC.Add(rpggm.assetSub.audioClips[Random.Range(3, 6)]);
            bm.nmeGO.Add(nme4);
            bm.nmeBorderSR.Add(nme4B.GetComponent<SpriteRenderer>());
            // Debug.Log("NME.EnableNME: ADD bsr: " + nme4B);
            bm.nmeSR.Add(nme4.GetComponent<SpriteRenderer>());
            nme4.GetComponent<SpriteRenderer>().color = Color.black;
        }


        //attempts to not repeat audio clip from previous NME
        for (int n = 1; n < noOfNME; n++)
        {
            for (int i = 0; i < 4; i++)
            {
                if (bm.nmeAC[n - 1] == bm.nmeAC[n])
                {
                    bm.nmeAC[n] = (rpggm.assetSub.audioClips[Random.Range(3, 6)]);
                }

                else break;
            }
        }
    }
}
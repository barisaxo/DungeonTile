using UnityEngine;
using System.Collections.Generic;

public class RPGAssetSub : MonoBehaviour
{
    public RPGGM rpggm;

    public Sprite[] sprite = new Sprite[7];
    public Sprite[] chordQualitySprite = new Sprite[7];
    public Material[] bgMat = new Material[3];
    public Material[] starMat = new Material[3];
    public Material mat;
    public AudioClip[] audioClips = new AudioClip[9];

    public AudioClip cMaj, dMin, e7Alt, fDim, g13, aMin, bm7b5,
        machete, roulette;

    public enum ACName { CMaj, DMin, E7Alt, Fdim, G13, Amin, Bm7b5 }

    public List<AudioClip> cadences = new List<AudioClip>();

    void Awake()
    {
        //sprite[0] = Resources.Load<Sprite>("ART/tile");
        //sprite[1] = Resources.Load<Sprite>("ART/7spiralD");
        //sprite[2] = Resources.Load<Sprite>("ART/spiral");
        sprite[3] = Resources.Load<Sprite>("ART/white");
        //sprite[4] = Resources.Load<Sprite>("ART/Player1");
        //sprite[5] = Resources.Load<Sprite>("ART/Player2");

        sprite[2] = Resources.Load<Sprite>("ART/stars2");

        sprite[1] = Resources.Load<Sprite>("ART/stars1");
        ////sprite[3] = Resources.Load<Sprite>("ART/tile2");
        ////sprite[4] = Resources.Load<Sprite>("ART/ship1");
        ////sprite[5] = Resources.Load<Sprite>("ART/bullet");
        ////sprite[6] = Resources.Load<Sprite>("ART/spawner");


        chordQualitySprite[0] = Resources.Load<Sprite>("ART/Tonic");
        chordQualitySprite[1] = Resources.Load<Sprite>("ART/Recessive");
        chordQualitySprite[2] = Resources.Load<Sprite>("ART/Dominant");
        chordQualitySprite[3] = Resources.Load<Sprite>("ART/Tonic Minor");
        chordQualitySprite[4] = Resources.Load<Sprite>("ART/Recessive Minor");
        chordQualitySprite[5] = Resources.Load<Sprite>("ART/Dominant Minor");
        chordQualitySprite[6] = Resources.Load<Sprite>("ART/Diminished");


        //bgMat[0] = Resources.Load<Material>("ART/bgmat1");
        //bgMat[1] = Resources.Load<Material>("ART/bgmat2");
        //bgMat[2] = Resources.Load<Material>("ART/bgmat3");

        //starMat[1] = Resources.Load<Material>("ART/bgstar1");
        //starMat[2] = Resources.Load<Material>("ART/bgstar2");

        //mat = new Material(Shader.Find("Legacy Shaders/Particles/Alpha Blended Premultiply"));

        audioClips[0] = Resources.Load<AudioClip>("MUSIC/CMaj");
        audioClips[1] = Resources.Load<AudioClip>("MUSIC/DMin9");
        audioClips[5] = Resources.Load<AudioClip>("MUSIC/E7Alt");
        audioClips[6] = Resources.Load<AudioClip>("MUSIC/FDim");
        audioClips[2] = Resources.Load<AudioClip>("MUSIC/G13");
        audioClips[3] = Resources.Load<AudioClip>("MUSIC/ATonicMin9");
        audioClips[4] = Resources.Load<AudioClip>("MUSIC/BMin9b5");
        audioClips[7] = Resources.Load<AudioClip>("MUSIC/machete");
        audioClips[8] = Resources.Load<AudioClip>("MUSIC/Roulette loop");

        cMaj = Resources.Load<AudioClip>("MUSIC/CMaj");
        dMin = Resources.Load<AudioClip>("MUSIC/DMin9");
        g13 = Resources.Load<AudioClip>("MUSIC/G13");
        aMin = Resources.Load<AudioClip>("MUSIC/ATonicMin9");
        bm7b5 = Resources.Load<AudioClip>("MUSIC/BMin9b5");
        e7Alt = Resources.Load<AudioClip>("MUSIC/E7Alt");
        fDim = Resources.Load<AudioClip>("MUSIC/FDim");
        machete = Resources.Load<AudioClip>("MUSIC/machete");
        roulette = Resources.Load<AudioClip>("MUSIC/Roulette loop");

        cadences.Add(cMaj);
        cadences.Add(dMin);
        cadences.Add(e7Alt);
        cadences.Add(fDim);
        cadences.Add(g13);
        cadences.Add(aMin);
        cadences.Add(bm7b5);

    }
}
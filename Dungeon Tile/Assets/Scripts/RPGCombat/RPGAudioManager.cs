using System.Collections;
using UnityEngine;

public class RPGAudioManager : MonoBehaviour
{
    public RPGGM rpggm;

    public AudioListener audioListener;

    public AudioSource audioSource;

    public float playbackPos, explorePlaybackPos;

    public bool rollQue;

    public AudioClip queuedAC, exploreAC, nextAC;

    public enum AudioState { Rolling, NotRolling, exploring }
    public AudioState audioState = AudioState.NotRolling;

    enum FunctionQue { playExploreMusic, rollOffAudio, rollAudio }

    void Awake()
    {
        audioListener = gameObject.AddComponent<AudioListener>();

        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.volume = .75f;
        audioSource.spatialBlend = 1;
        audioSource.maxDistance = 1;
        audioSource.minDistance = 1;
        audioSource.rolloffMode = AudioRolloffMode.Linear;
        audioSource.dopplerLevel = 0f;
        // audioSource.Play();
    }

    private void Start()
    {
        exploreAC = rpggm.assetSub.audioClips[7];
    }

    public void QueAC(AudioClip ac)
    {
        queuedAC = ac;
        rollQue = true;
    }

    public void RollOffAudio()
    {
        if (audioState == AudioState.Rolling)
        { StartCoroutine(WaitForRoll(FunctionQue.rollOffAudio)); }

        else
        {
            audioState = AudioState.Rolling;
            //Debug.Log("RollOffAudio(). FadeToStop()");
            StartCoroutine(FadeToStop());
        }
    }

    IEnumerator FadeToStop()
    {//make audio quickly, yet gradually, fade out.
        if (audioSource.volume > .0f)
        {
            audioSource.volume -= Time.deltaTime * 1.5f;
            yield return new WaitForEndOfFrame();
            //Debug.Log("FadeToStop(). FadeToStop()");
            StartCoroutine(FadeToStop());
        }

        else
        {
            audioState = AudioState.NotRolling;
            audioSource.Stop();
            //Debug.Log("FadeToStop().Else");
            yield return null;
        }
    }

    public void RollAudio(AudioClip clip)
    { //make audio quickly, yet gradually, fade out. then back in
        nextAC = clip;

        if (audioState == AudioState.Rolling)
        { StartCoroutine(WaitForRoll(FunctionQue.rollAudio)); }
        else
        {
            audioState = AudioState.Rolling;
            //Debug.Log("RollAudio(). FadeOut()");
            StartCoroutine(FadeOut());
        }
    }

    IEnumerator FadeOut()
    {
        if (audioSource.volume > 0f)
        {
            audioSource.volume -= Time.deltaTime * 1.5f;
            yield return new WaitForEndOfFrame();
            //Debug.Log("FadeOut(). FadeOut()");
            StartCoroutine(FadeOut());
        }

        else
        {
            playbackPos = audioSource.time;
            audioSource.Pause();
            //Debug.Log("FadeOut().Else");
            RollOnAudio();
            yield return null;
        }
    }

    public void RollOnAudio()
    {//make audio quickly, yet gradually, fade in
        audioState = AudioState.Rolling;

        audioSource.clip = nextAC;

        if (audioSource.clip.length >= playbackPos)
        { audioSource.time = playbackPos; }

        audioSource.Play();


        //Debug.Log("RollOnAudio(). FadeIn()");
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        switch (rpggm.gameStateManager.gameState)
        {
            case RPGGameStateManager.GameState.Battle:
                if (audioSource.volume < .75f)
                {
                    audioSource.volume += Time.deltaTime * 1.5f;
                    yield return new WaitForEndOfFrame();
                    //Debug.Log("FadeIn(). FadeIn()");
                    StartCoroutine(FadeIn());
                }

                else
                {
                    audioSource.volume = .75f;
                    audioState = AudioState.NotRolling;
                    if (rollQue) { RollAudio(queuedAC); rollQue = false; }
                    //Debug.Log("FadeIn().Else");
                    yield return null;
                }

                break;

            case RPGGameStateManager.GameState.Explore:
                if (audioSource.volume < .75f)
                {
                    audioSource.volume += Time.deltaTime * 1.5f;
                    yield return new WaitForEndOfFrame();
                    //Debug.Log("FadeIn(). FadeIn().EXPLORE");
                    StartCoroutine(FadeIn());
                }

                else
                {
                    audioSource.volume = .75f;
                    //Debug.Log("FadeIn().EXPLORE.Else");
                }

                break;
        }
    }

    public void PlayExploreMusic()
    {
        if (audioState == AudioState.Rolling)
        {
            //Debug.Log("PlayExploreMuisc(). WaitForRoll()");
            StartCoroutine(WaitForRoll(FunctionQue.playExploreMusic));
        }
        else
        {
            audioSource.clip = exploreAC;
            audioState = AudioState.exploring;
            if (exploreAC.length >= explorePlaybackPos)
            {
                audioSource.time = explorePlaybackPos;
                //Debug.Log(explorePlaybackPos);
            }
            audioSource.Play();
            audioSource.volume = 0.1f;
            //Debug.Log("PlayExploreMusic(). FadeIn()");
            StartCoroutine(FadeIn());
        }
    }

    IEnumerator WaitForRoll(FunctionQue fq)
    {
        if (audioState == AudioState.Rolling)
        {
            yield return new WaitForEndOfFrame();
            //Debug.Log("WaitForRoll(). WaitForRoll()");
            StartCoroutine(WaitForRoll(fq));
        }

        else
        {
            switch (fq)
            {
                case FunctionQue.playExploreMusic:
                    PlayExploreMusic(); yield return null; break;
                case FunctionQue.rollOffAudio:
                    RollOffAudio(); break;
                case FunctionQue.rollAudio:
                    RollAudio(nextAC); break;
            }
        }
    }


    public void PauseExploreMusic()
    {
        audioState = AudioState.Rolling;
        explorePlaybackPos = audioSource.time;
        //Debug.Log(explorePlaybackPos);
        //Debug.Log("PauseExploreMusic(). FadeToStop()");
        StartCoroutine(FadeToStop());
    }
}
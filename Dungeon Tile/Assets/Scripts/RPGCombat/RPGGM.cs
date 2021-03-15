using UnityEngine;
/*TODO:
 *  Loading Screens: startup,pre-battle, spoils, fades to black,
 *  Menus: Help, Character, shop,
 *  Maps: town, world, area,
 *  
 */
public class RPGGM : MonoBehaviour
{
    public GM gm;

    public RPGMyCamera myCam;
    public RPGAssetSub assetSub;
    public RPGBackGround backGround;
    public RPGAudioManager audioManager;
    public RPGColorFlux colorFlux;
    public RPGInputKey inputKey;
    public RPGBattleManager bm;
    public RPGGameStateManager gameStateManager;
    public RPGPlayer player;
    public GameObject board;
    public RPGMovementSub movementSub;
    public RPGStartScreen startScreen;
    public RPGGameMenu gameMenu;

    void Awake()
    {
        assetSub = gameObject.AddComponent<RPGAssetSub>();
        assetSub.rpggm = this;

        myCam = new GameObject("Camera").AddComponent<RPGMyCamera>();
        myCam.rpggm = this;
        myCam.gameObject.transform.SetParent(transform);

        audioManager = gameObject.AddComponent<RPGAudioManager>();
        audioManager.rpggm = this;

        gameStateManager = gameObject.AddComponent<RPGGameStateManager>();
        gameStateManager.rpggm = this;
    }

    private void Start()
    {
        colorFlux = gameObject.AddComponent<RPGColorFlux>();
        colorFlux.rpggm = this;

        inputKey = gameObject.AddComponent<RPGInputKey>();
        inputKey.rpggm = this;

        board = new GameObject("GameBoard");
        board.transform.position = myCam.transform.position;
        board.gameObject.transform.SetParent(transform);

        backGround = new GameObject("BackGround").AddComponent<RPGBackGround>();
        backGround.rpggm = this;
        backGround.gameObject.transform.SetParent(board.transform);

        player = new GameObject("Player").AddComponent<RPGPlayer>();
        player.rpggm = this;
        player.gameObject.transform.SetParent(transform);

        movementSub = gameObject.AddComponent<RPGMovementSub>();
        movementSub.rpggm = this;

        bm = new GameObject("Battle Manager").AddComponent<RPGBattleManager>();
        bm.rpggm = this;
        bm.SetUp();
        bm.gameObject.transform.SetParent(transform);

        startScreen = new GameObject("Start Screen").AddComponent<RPGStartScreen>();
        startScreen.rpggm = this;
        startScreen.gameObject.transform.SetParent(transform);

        gameMenu = new GameObject("Game Menu").AddComponent<RPGGameMenu>();
        gameMenu.rpggm = this;
        gameMenu.gameObject.transform.SetParent(transform);

        bm.gameObject.SetActive(false);
        board.gameObject.SetActive(false);
        gameMenu.gameObject.SetActive(false);

        gameObject.SetActive(false);
    }
}

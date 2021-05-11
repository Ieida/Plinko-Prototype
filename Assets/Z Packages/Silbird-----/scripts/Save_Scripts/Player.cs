using UnityEngine;

public class Player : MonoBehaviour
{
    public static float Highscore;
    public static float Money;

    public static bool isPurchased_01;
    public static bool isPurchased_02;
    public static bool isPurchased_03;
    public static bool isPurchased_04;
    public static bool isPurchased_05;
    public static bool isPurchased_06;
    public static bool isPurchased_07;
    public static bool isPurchased_08;
    public static bool isPurchased_09;
    public static bool isPurchased_10;
    public static bool isPurchased_11;
    public static bool isPurchased_12;

    public static bool Item01_equipped;
    public static bool Item02_equipped;
    public static bool Item03_equipped;
    public static bool Item04_equipped;
    public static bool Item05_equipped;
    public static bool Item06_equipped;
    public static bool Item07_equipped;
    public static bool Item08_equipped;
    public static bool Item09_equipped;
    public static bool Item10_equipped;
    public static bool Item11_equipped;
    public static bool Item12_equipped;

    public static float ColorNumber;

    public static bool Landscape_01_Purchased;
    public static bool Landscape_02_Purchased;
    public static bool Landscape_03_Purchased;

    public static bool Landscape_01_equipped;
    public static bool Landscape_02_equipped;
    public static bool Landscape_03_equipped;

    public static bool Effect_01_Purchased;
    public static bool Effect_02_Purchased;
    public static bool Effect_03_Purchased;
    public static bool Effect_04_Purchased;
    public static bool Effect_05_Purchased;

    public static bool Effect_01_equipped;
    public static bool Effect_02_equipped;
    public static bool Effect_03_equipped;
    public static bool Effect_04_equipped;
    public static bool Effect_05_equipped;

    public static bool TutorielSeen;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);



        Highscore = Score_Script.Highscore;
        Money = Score_Script.Money;

        isPurchased_01 = Button_Interactable.isPurchased_01;
        isPurchased_02 = Button_Interactable.isPurchased_02;
        isPurchased_03 = Button_Interactable.isPurchased_03;
        isPurchased_04 = Button_Interactable.isPurchased_04;
        isPurchased_05 = Button_Interactable.isPurchased_05;
        isPurchased_06 = Button_Interactable.isPurchased_06;
        isPurchased_07 = Button_Interactable.isPurchased_07;
        isPurchased_08 = Button_Interactable.isPurchased_08;
        isPurchased_09 = Button_Interactable.isPurchased_09;
        isPurchased_10 = Button_Interactable.isPurchased_10;
        isPurchased_11 = Button_Interactable.isPurchased_11;
        isPurchased_12 = Button_Interactable.isPurchased_12;

        Item01_equipped = Button_Interactable.Item01_equipped;
        Item02_equipped = Button_Interactable.Item02_equipped;
        Item03_equipped = Button_Interactable.Item03_equipped;
        Item04_equipped = Button_Interactable.Item04_equipped;
        Item05_equipped = Button_Interactable.Item05_equipped;
        Item06_equipped = Button_Interactable.Item06_equipped;
        Item07_equipped = Button_Interactable.Item07_equipped;
        Item08_equipped = Button_Interactable.Item08_equipped;
        Item09_equipped = Button_Interactable.Item09_equipped;
        Item10_equipped = Button_Interactable.Item10_equipped;
        Item11_equipped = Button_Interactable.Item11_equipped;
        Item12_equipped = Button_Interactable.Item12_equipped;

        ColorNumber = Change_Color.ColorNumber;

        Landscape_01_Purchased = SwapLandscapes.isPurchased_01;
        Landscape_02_Purchased = SwapLandscapes.isPurchased_02;
        Landscape_03_Purchased = SwapLandscapes.isPurchased_03;

        Landscape_01_equipped = SwapLandscapes.Item01_equipped;
        Landscape_02_equipped = SwapLandscapes.Item02_equipped;
        Landscape_03_equipped = SwapLandscapes.Item03_equipped;

        Effect_01_Purchased = ParticleShop.isPurchased_01;
        Effect_02_Purchased = ParticleShop.isPurchased_02;
        Effect_03_Purchased = ParticleShop.isPurchased_03;
        Effect_04_Purchased = ParticleShop.isPurchased_04;
        Effect_05_Purchased = ParticleShop.isPurchased_05;

        Effect_01_equipped = ParticleShop.Item01_equipped;
        Effect_02_equipped = ParticleShop.Item02_equipped;
        Effect_03_equipped = ParticleShop.Item03_equipped;
        Effect_04_equipped = ParticleShop.Item04_equipped;
        Effect_05_equipped = ParticleShop.Item05_equipped;

        TutorielSeen = TutorielActive.TutorielSeen;
    }


    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();



        Score_Script.Highscore = data.ScoreValue;
        Score_Script.Money = data.Money;

        Button_Interactable.isPurchased_01 = data.isPurchased_01;
        Button_Interactable.isPurchased_02 = data.isPurchased_02;
        Button_Interactable.isPurchased_03 = data.isPurchased_03;
        Button_Interactable.isPurchased_04 = data.isPurchased_04;
        Button_Interactable.isPurchased_05 = data.isPurchased_05;
        Button_Interactable.isPurchased_06 = data.isPurchased_06;
        Button_Interactable.isPurchased_07 = data.isPurchased_07;
        Button_Interactable.isPurchased_08 = data.isPurchased_08;
        Button_Interactable.isPurchased_09 = data.isPurchased_09;
        Button_Interactable.isPurchased_10 = data.isPurchased_10;
        Button_Interactable.isPurchased_11 = data.isPurchased_11;
        Button_Interactable.isPurchased_12 = data.isPurchased_12;

        Button_Interactable.Item01_equipped = data.Item01_equipped;
        Button_Interactable.Item02_equipped = data.Item02_equipped;
        Button_Interactable.Item03_equipped = data.Item03_equipped;
        Button_Interactable.Item04_equipped = data.Item04_equipped;
        Button_Interactable.Item05_equipped = data.Item05_equipped;
        Button_Interactable.Item06_equipped = data.Item06_equipped;
        Button_Interactable.Item07_equipped = data.Item07_equipped;
        Button_Interactable.Item08_equipped = data.Item08_equipped;
        Button_Interactable.Item09_equipped = data.Item09_equipped;
        Button_Interactable.Item10_equipped = data.Item10_equipped;
        Button_Interactable.Item11_equipped = data.Item11_equipped;
        Button_Interactable.Item12_equipped = data.Item12_equipped;

        Change_Color.ColorNumber = data.ColorNumber;

        SwapLandscapes.isPurchased_01 = data.Landscape_01_isPurchased;
        SwapLandscapes.isPurchased_02 = data.Landscape_02_isPurchased;
        SwapLandscapes.isPurchased_03 = data.Landscape_03_isPurchased;

        SwapLandscapes.Item01_equipped = data.Landscape_01_equipped;
        SwapLandscapes.Item02_equipped = data.Landscape_02_equipped;
        SwapLandscapes.Item03_equipped = data.Landscape_03_equipped;

        ParticleShop.isPurchased_01 = data.Effect_01_isPurchased;
        ParticleShop.isPurchased_02 = data.Effect_02_isPurchased;
        ParticleShop.isPurchased_03 = data.Effect_03_isPurchased;
        ParticleShop.isPurchased_04 = data.Effect_04_isPurchased;
        ParticleShop.isPurchased_05 = data.Effect_05_isPurchased;

        ParticleShop.Item01_equipped = data.Effect_01_equipped;
        ParticleShop.Item02_equipped = data.Effect_02_equipped;
        ParticleShop.Item03_equipped = data.Effect_03_equipped;
        ParticleShop.Item04_equipped = data.Effect_04_equipped;
        ParticleShop.Item05_equipped = data.Effect_05_equipped;

        TutorielActive.TutorielSeen = data.TutorielSeen;
    }

    public void ResetPlayer()
    {
        /*
        Money = 0;
        Highscore = 0;

        Score_Script.Highscore = 0;
        Score_Script.Money = 0;
        */
    }



    private void Start()
    {
        PlayerData data = SaveSystem.LoadPlayer();



        //PlayerScore = data.Playercore;
    }
}

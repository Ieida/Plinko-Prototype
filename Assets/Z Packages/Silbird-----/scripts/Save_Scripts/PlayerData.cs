using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float ScoreValue;
    public float Money;

    public bool isPurchased_01;
    public bool isPurchased_02;
    public bool isPurchased_03;
    public bool isPurchased_04;
    public bool isPurchased_05;
    public bool isPurchased_06;
    public bool isPurchased_07;
    public bool isPurchased_08;
    public bool isPurchased_09;
    public bool isPurchased_10;
    public bool isPurchased_11;
    public bool isPurchased_12;

    public bool Item01_equipped;
    public bool Item02_equipped;
    public bool Item03_equipped;
    public bool Item04_equipped;
    public bool Item05_equipped;
    public bool Item06_equipped;
    public bool Item07_equipped;
    public bool Item08_equipped;
    public bool Item09_equipped;
    public bool Item10_equipped;
    public bool Item11_equipped;
    public bool Item12_equipped;

    public float ColorNumber;

    public bool Landscape_01_isPurchased;
    public bool Landscape_02_isPurchased;
    public bool Landscape_03_isPurchased;

    public bool Landscape_01_equipped;
    public bool Landscape_02_equipped;
    public bool Landscape_03_equipped;

    public bool Effect_01_isPurchased;
    public bool Effect_02_isPurchased;
    public bool Effect_03_isPurchased;
    public bool Effect_04_isPurchased;
    public bool Effect_05_isPurchased;

    public bool Effect_01_equipped;
    public bool Effect_02_equipped;
    public bool Effect_03_equipped;
    public bool Effect_04_equipped;
    public bool Effect_05_equipped;

    public bool TutorielSeen;

    public PlayerData(Player player)
    {
        ScoreValue = Player.Highscore;
        Money = Player.Money;

        isPurchased_01 = Player.isPurchased_01;
        isPurchased_02 = Player.isPurchased_02;
        isPurchased_03 = Player.isPurchased_03;
        isPurchased_04 = Player.isPurchased_04;
        isPurchased_05 = Player.isPurchased_05;
        isPurchased_06 = Player.isPurchased_06;
        isPurchased_07 = Player.isPurchased_07;
        isPurchased_08 = Player.isPurchased_08;
        isPurchased_09 = Player.isPurchased_09;
        isPurchased_10 = Player.isPurchased_10;
        isPurchased_11 = Player.isPurchased_11;
        isPurchased_12 = Player.isPurchased_12;

        Item01_equipped = Player.Item01_equipped;
        Item02_equipped = Player.Item02_equipped;
        Item03_equipped = Player.Item03_equipped;
        Item04_equipped = Player.Item04_equipped;
        Item05_equipped = Player.Item05_equipped;
        Item06_equipped = Player.Item06_equipped;
        Item07_equipped = Player.Item07_equipped;
        Item08_equipped = Player.Item08_equipped;
        Item09_equipped = Player.Item09_equipped;
        Item10_equipped = Player.Item10_equipped;
        Item11_equipped = Player.Item11_equipped;
        Item12_equipped = Player.Item12_equipped;

        ColorNumber = Player.ColorNumber;

        Landscape_01_isPurchased = Player.Landscape_01_Purchased;
        Landscape_02_isPurchased = Player.Landscape_02_Purchased;
        Landscape_03_isPurchased = Player.Landscape_03_Purchased;

        Landscape_01_equipped = Player.Landscape_01_equipped;
        Landscape_02_equipped = Player.Landscape_02_equipped;
        Landscape_03_equipped = Player.Landscape_03_equipped;

        Effect_01_isPurchased = Player.Effect_01_Purchased;
        Effect_02_isPurchased = Player.Effect_02_Purchased;
        Effect_03_isPurchased = Player.Effect_03_Purchased;
        Effect_04_isPurchased = Player.Effect_04_Purchased;
        Effect_05_isPurchased = Player.Effect_05_Purchased;

        Effect_01_equipped = Player.Effect_01_equipped;
        Effect_02_equipped = Player.Effect_02_equipped;
        Effect_03_equipped = Player.Effect_03_equipped;
        Effect_04_equipped = Player.Effect_04_equipped;
        Effect_05_equipped = Player.Effect_05_equipped;

        TutorielSeen = Player.TutorielSeen;
    }
}

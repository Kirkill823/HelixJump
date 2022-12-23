using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using Random = System.Random;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] PlatformPrefabs;
    public GameObject FirstPlatformPrefab;
    public int MinPlatforms;
    public int MaxPlatforms;
    public float DistanceBetweenPlatform;
    public Transform FinishPlatform;
    public Transform CylinderRoot;
    float CylinderPlus = 1f;
    public Game Game;
    private void Awake()
    {
        int LevelIndex = Game.LevelIndex;
        Random random = new Random(LevelIndex);
        int platformsCount = RandomRange(random, MinPlatforms, MaxPlatforms + 1);

        for (int i= 0; i < platformsCount; i++)
        {
            int prefabIndex = RandomRange(random, 0, PlatformPrefabs.Length);
            GameObject PlatformPrefab = i == 0 ? FirstPlatformPrefab : PlatformPrefabs[prefabIndex];
            GameObject platform = Instantiate(PlatformPrefab, transform);
            platform.transform.localPosition = CalculatePlatformPosition(i);
            if(i > 0)
            platform.transform.localRotation = Quaternion.Euler(0, RandomRangeFloat(random, 0, 360f), 0);
        }
        FinishPlatform.localPosition = CalculatePlatformPosition(platformsCount);

        CylinderRoot.localScale = new Vector3(0.25f, (platformsCount * DistanceBetweenPlatform + +CylinderPlus) / 7, 0.25f);
    }
    private int RandomRange(Random random, int min, int maxExclusive)
    {
        int number = random.Next();
        int length = maxExclusive - min;
        number %= length;
        return min + number; 
    }
    private float RandomRangeFloat(Random random, float min, float max)
    {
        float t = (float) random.NextDouble();
        return Mathf.Lerp(min, max, t); 
    }
    private Vector3 CalculatePlatformPosition(int platfomindex)
    {
        return new Vector3(0, -DistanceBetweenPlatform * platfomindex, 0);
    }
}

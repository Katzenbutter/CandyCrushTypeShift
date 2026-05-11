using System.Collections;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    public GameObject candyPrefab;
    public int candyAmount; // varies per round
    public bool isRoundActive = true; // true-> candies fall, false-> no candies fall :)
    public bool isFalling = false; // true-> candy is currently falling, false-> no candy is falling
    public Vector2 spawnArea;
    public float spawnInterval = 0.001f; // seconds between candy spawns

    private void Start()
    {
        // x is fixed; randomize the y per spawn
        spawnArea = new Vector2(0f, 9);
    }

    private void Update()
    {
        if (isRoundActive && !isFalling)
        {
            StartCoroutine(SpawnCandy());
        }
    }

    private IEnumerator SpawnCandy()
    {
        if (candyPrefab == null || candyAmount <= 0)
        {
            yield break;
        }

        isFalling = true;
        int counter = 0;

        while (counter < candyAmount)
        {
            // randomize x each spawn
            float spawnX = Random.Range(-9f, 9f);
            Vector3 spawnPos = new Vector3(spawnX, spawnArea.y, 0f);

            Instantiate(candyPrefab, spawnPos, Quaternion.identity);

            counter++;
            yield return new WaitForSeconds(spawnInterval);
        }

        isFalling = false;
    }
}
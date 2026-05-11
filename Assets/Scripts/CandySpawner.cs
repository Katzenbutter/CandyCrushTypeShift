using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    public GameObject candyPrefab;
    public int candyAmount;//varies per round
    public bool isRoundActive = false;//true-> candies fall, false-> no candies fall :)
    public bool isFalling = false;//true-> candy is currently falling, false-> no candy is falling
    public Vector2 spawnArea;
    private void Start()
    {
       spawnArea = new Vector2(5, Random.Range(-1, 2));//x and y coordinates for the spawn area, x is fixed, y is random between -1 and 1 //fix latr
    }

    private void Update()
    {
        if (isRoundActive && !isFalling)
        {
            SpawnCandy();
        }
    }

    public void SpawnCandy()
    {
        int counter = 0;//counts fallen candies

        while(counter < candyAmount)
        {   
            if (!isFalling)
            {
                Instantiate(candyPrefab, spawnArea, Quaternion.identity);
                isFalling = true;
            }
            else 
            { 
                new WaitForSeconds(1f);
                Instantiate(candyPrefab, spawnArea, Quaternion.identity);
                isFalling = true;
            }
                counter++;
        }
    }

}

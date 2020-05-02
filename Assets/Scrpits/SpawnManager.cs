using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefs;
    private float spawnRangeX = 13;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnınterval = 1.0f;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnınterval);
    }

    // Update is called once per frame
    private void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefs[animalIndex], spawnPos, animalPrefs[animalIndex].transform.rotation);
    }
}
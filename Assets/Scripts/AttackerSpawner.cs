using System.Collections;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] private float minSpawnDelay = 1f;
    [SerializeField] private float maxSpawnDelay = 5f;

    [SerializeField] private Attacker attackerPrefab;

    private bool spawn = true;

    // Start is called before the first frame update
    // By making this an IEnumerator return, this works as a coroutine.
    IEnumerator Start()
    {
        while (spawn)
        {
            // keep spawning
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Instantiate(attackerPrefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

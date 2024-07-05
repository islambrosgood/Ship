using UnityEngine;

public class BossEnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _bossPrefabs;

    [SerializeField] private float _bossSpawnDuration;
    public float _timer;

    private void Start()
    {
        _bossSpawnDuration = Random.Range(10f, 15f);
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _bossSpawnDuration)
            SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        _timer = 0f;

        Instantiate(_bossPrefabs[Random.Range(0, _bossPrefabs.Length)], transform.position, Quaternion.Euler(new Vector3(0, 0, Random.Range(85, 95))));
    }
}
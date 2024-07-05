using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy[] _enemyPrefabs;
    [SerializeField] private float[] _spawnRotationDegrees;

    public float _enemySpawnDuration;
    private float _playingTime;
    private float _enemySpeedMultiplier = 0;
    

    private void Start()
    {
        _enemySpawnDuration = Random.Range(3f, 4f);
    }

    private void Update()
    {
        _playingTime += Time.deltaTime;

        if(_playingTime >= _enemySpawnDuration)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        _playingTime = 0f;

        if (_enemySpawnDuration > 0.9f)
            _enemySpawnDuration -= 0.05f;

        var spawnedEnemy = Instantiate(_enemyPrefabs[Random.Range(0, _enemyPrefabs.Length)], transform.position, 
            Quaternion.Euler(new Vector3(0, 0, Random.Range(_spawnRotationDegrees[0], _spawnRotationDegrees[1]))));

        if (spawnedEnemy.GetComponent<Wave>() != null) { spawnedEnemy.GetComponent<Wave>()._speed += _enemySpeedMultiplier; }
        else if (spawnedEnemy.GetComponent<SharkScript>() != null) { spawnedEnemy.GetComponent<SharkScript>()._speed += _enemySpeedMultiplier; }

        _enemySpeedMultiplier += 0.05f;
    }
}
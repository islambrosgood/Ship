using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _itemPrefabs;

    private float _itemSpawnDuration;
    private float _playingTime;

    private void Start()
    {
        _itemSpawnDuration = Random.Range(1.5f, 2f);
    }

    private void Update()
    {
        _playingTime += Time.deltaTime;

        if (_playingTime >= _itemSpawnDuration)
        {
            SpawnItem();
        }
    }

    private void SpawnItem()
    {
        _playingTime = 0f;

        Instantiate(_itemPrefabs[Random.Range(0, _itemPrefabs.Length)], new Vector2(Random.Range(-17f, 17f), Random.Range(-9f, 9f)), Quaternion.identity);
    }
}

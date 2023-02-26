using UnityEngine;

public class SpawnNodes : MonoBehaviour
{
    [SerializeField] private int _numXToSpawn = 26;
    [SerializeField] private int _numYToSpawn = 29;
    [SerializeField] private float _spawnXOffset = 0.3f;
    [SerializeField] private float _spawnYOffset = 0.3f;

    void Start()
    {
        if (gameObject.name != "Node")
            return;

        var spawnPosition = transform.position;
        for (int x = 0; x < _numXToSpawn; x++)
        {
            for (int y = 0; y < _numYToSpawn; y++)
            {
                var clone = Instantiate(gameObject,
                    spawnPosition + new Vector3(_spawnXOffset * x, _spawnYOffset * y, 0f),
                    Quaternion.identity);
            }
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _spherePrefab;
    [SerializeField] private int numSpheres = 5;
    [SerializeField] private Toggle togglePrefab;
    [SerializeField] private Transform toggleContainer;

    private GameObject[] _spheres;
    private Toggle[] _toggles;

    private int _spread = 10;
    public GameObject[] Spheres
    {
        get {
            return _spheres;
        }
        set {
            _spheres = value;
        }
    }

    public Toggle[] Toggles
    {
        get { return _toggles; }
        set { _toggles = value; }
    }

    private void Start()
    {
        _spheres = new GameObject[numSpheres];
        _toggles = new Toggle[numSpheres];

        for (int i = 0; i < numSpheres; i++)
        {
            GameObject sphere = Instantiate(_spherePrefab, transform.position + new Vector3(Random.Range(-_spread, _spread), Random.Range(0, 0), Random.Range(-_spread, _spread)),  Quaternion.identity);
            _spheres[i] = sphere;

            Toggle toggle = Instantiate(togglePrefab, toggleContainer);
            toggle.isOn = false;
            _toggles[i] = toggle;
        }
    }
}

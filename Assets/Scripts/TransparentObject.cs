using UnityEngine;
using UnityEngine.UI;

public class TransparentObject : MonoBehaviour
{
    private GameObject[] _toggleOn;
    private ObjectSpawner _objectSpawner;

    private void Start()
    {
        _objectSpawner = FindObjectOfType<ObjectSpawner>();
    }

    public void SetTransparencyTy25()
    {
        var i = 0;
        foreach (var sphere in _objectSpawner.Toggles)
        {
            if (sphere.GetComponent<Toggle>().isOn)
            {
                _objectSpawner.Spheres[i].GetComponent<Renderer>().material.color = new Color(0.11366f, 0.0718671f, 0.8018868f, 0.25f);
                i++;
            }
        }
    }

    public void SetTransparencyTy50()
    {
        var i = 0;
        foreach (var sphere in _objectSpawner.Toggles)
        {
            if (sphere.GetComponent<Toggle>().isOn)
            {
                _objectSpawner.Spheres[i].GetComponent<Renderer>().material.color = new Color(0.11366f, 0.0718671f, 0.8018868f, 0.5f);
                i++;
            }
        }
    }    
    
    public void SetTransparencyTy75()
    {
        var i = 0;
        foreach (var sphere in _objectSpawner.Toggles)
        {
            if (sphere.GetComponent<Toggle>().isOn)
            {
                _objectSpawner.Spheres[i].GetComponent<Renderer>().material.color = new Color(0.11366f, 0.0718671f, 0.8018868f, 0.75f);
                i++;
            }
        }
    }    
    
    public void SetTransparencyTy100()
    {
        var i = 0;
        foreach (var sphere in _objectSpawner.Toggles)
        {
            if (sphere.GetComponent<Toggle>().isOn)
            {
                _objectSpawner.Spheres[i].GetComponent<Renderer>().material.color = new Color(0.11366f, 0.0718671f, 0.8018868f, 1f);
                i++;
            }
        }
    }

    public void SetActiveObjects()
    {
        var i = 0;
        foreach (var sphere in _objectSpawner.Toggles)
        {
            if (sphere.GetComponent<Toggle>().isOn)
            {
                _objectSpawner.Spheres[i].GetComponent<Renderer>().enabled = true;
                i++;
            }
        }
    }
    
    public void SetDisableObjects()
    {
        var i = 0;
        foreach (var sphere in _objectSpawner.Toggles)
        {
            if (sphere.GetComponent<Toggle>().isOn)
            {
                _objectSpawner.Spheres[i].GetComponent<Renderer>().enabled = false;
                i++;
            }
        }
    }

}
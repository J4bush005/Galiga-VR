using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ShootGun : MonoBehaviour
{
    [SerializeField]
    private ActionBasedController m_Controller = null;
    [SerializeField]
    private float m_speed = 8.0f;
    public GameObject projectilePrefab;

    private const string ANIMATOR_TRIGGER_PARAM = "Trigger";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

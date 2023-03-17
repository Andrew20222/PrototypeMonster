using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Laser _laser;
    [SerializeField] private RaycastDetoucher _raycastDetoucher;
    
    public void LaserMode()
    {
        _laser.enabled = true;
        _raycastDetoucher.enabled = false;
    }

    public void RaycastDetoucherMode()
    {
        _raycastDetoucher.enabled = true;
        _laser.enabled = false;
    }
}

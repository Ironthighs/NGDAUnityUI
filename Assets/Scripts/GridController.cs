using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    [SerializeField]
    private int _maxCellHeight;
    [SerializeField]
    private int _maxCellWidth;
    [SerializeField]
    private bool _rightToLeft;
    [SerializeField]
    private bool _bottomToTop;
    [SerializeField]
    private int _maxRows;
    [SerializeField]
    private int _maxColumns;

    private int _gridIndex = 0;

    private List<GameObject> _gridObjects = new List<GameObject>();

    public void InitializeGrid(int maxCellHeight, int maxCellWidth, int maxRows, int maxColumns, bool rightToLeft = false, bool bottomToTop = false)
    {
        _maxCellHeight = maxCellHeight;
        _maxCellWidth = maxCellWidth;
        _maxRows = maxRows;
        _maxColumns = maxColumns;
        _rightToLeft = rightToLeft;
        _bottomToTop = bottomToTop;
    }


    public void AddObject(GameObject gridObject)
    {
        var leftOrRight = _rightToLeft ? -1 : 1;
        var upOrDown = _bottomToTop ? 1 : -1;
        var xGridPos = _gridIndex % _maxColumns;
        int yGridPos = _gridIndex / _maxColumns;
        var xPos = transform.position.x + xGridPos * (_maxCellWidth / 2) * leftOrRight;
        var yPos = transform.position.y + yGridPos * (_maxCellHeight / 2) * upOrDown;
        gridObject.transform.position = new Vector3(xPos, yPos, transform.position.z);
        _gridObjects.Add(gridObject);
        _gridIndex++;

    }
}

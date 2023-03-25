using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _damping;
    [SerializeField] private SpriteRenderer _boundsMap;
    [SerializeField] private PlayerResources _playerResources;

    private bool _playerSeeRight;
    private Vector3 _min, _max;
    private Camera _cam;

    private void Start()
    {
        _cam = GetComponent<Camera>();
        CalculateBounds();
    }

    private void Update()
    {
        Follow();
    }

    void CalculateBounds()
    {
        Bounds bounds = CameraBounds();
        _min = bounds.max + _boundsMap.bounds.min;
        _max = bounds.min + _boundsMap.bounds.max;
    }

    Bounds CameraBounds()
    {
        float height = _cam.orthographicSize * 2;
        return new Bounds(Vector3.zero, new Vector3(height * _cam.aspect, height, 0));
    }

    Vector3 MoveInside(Vector3 current, Vector3 pMin, Vector3 pMax)
    {
        current = Vector3.Max(current, pMin);
        current = Vector3.Min(current, pMax);
        return current;
    }

    void Follow()
    {
        _playerSeeRight = _playerResources.IsSeeRight;
        Vector3 position;
        
        if (_playerSeeRight)
        {
            position = new Vector3(_player.transform.position.x + _offset.x, _player.transform.position.y + _offset.y, transform.position.z);
        }
        else
        {
            position = new Vector3(_player.transform.position.x - _offset.x, _player.transform.position.y + _offset.y, transform.position.z);
        }
        
        position = MoveInside(position, new Vector3(_min.x, _min.y, position.z), new Vector3(_max.x, _max.y, position.z));
        transform.position = Vector3.Lerp(transform.position, position, _damping * Time.deltaTime);
    }
}

using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource _munch1;
    [SerializeField] private AudioSource _munch2;

    private int _currentMunch = 0;

    public void PlayCollectPelletSound(MovementPointer pointer)
    {
        if(_currentMunch == 0)
        {
            _munch1.Play();
            _currentMunch = 1;
        }
        else if(_currentMunch == 1)
        {
            _munch2.Play();
            _currentMunch = 0;
        }
    }
}

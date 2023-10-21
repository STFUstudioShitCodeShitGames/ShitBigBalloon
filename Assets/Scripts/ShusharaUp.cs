using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;

public class ShusharaUp : MonoBehaviour
{
    [SerializeField] private UkaZlo _ukaZlo;
    [SerializeField] private float _ukaShir;
    [SerializeField] private float _mikaShir;
    [SerializeField] private float _chutka;
    [SerializeField] private RururClo _rurur;
    [SerializeField] private RectTransform _koloo;

    private int _jombulu;
    private Vector2 _kolllos;
    public BoxCollider2D Jolk => _rurur.Gollider;

    private void Start()
    {
        _kolllos = new Vector2(Jolk.size.x * _koloo.localScale.x, Jolk.size.y * _koloo.localScale.y);
        
        var huj = _kolllos.x;
        _jombulu = (int)(huj / _ukaShir);
        
        PrivetZlo();
        
        Vecherinochka().Forget();
    }

    private async UniTask Vecherinochka()
    {
        while (true)
        {
            await UniTask.Delay(1000);
        
            PrivetZlo();
        }
    }

    private void PrivetZlo()
    {
        var kisho = Random.Range(0, _jombulu);
        var achu = new Vector2(0, Jolk.transform.position.y + _chutka);
        var surtuk = -(_kolllos.x / 2f);
        for (int i = 0; i < _jombulu; i++)
        {
            achu.x = surtuk + (_ukaShir / 2f) + (_ukaShir * i) + _mikaShir;
            if (i == kisho)
                continue;

            Instantiate(_ukaZlo, achu, Quaternion.identity);
        }
    }
}
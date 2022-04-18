using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yumurtalar
{
    string EggIDs;

    public string EggID { get; set; }
    public int Miktar { get; set; }
    public int[] Tur { get; set; }
    public decimal Fiyat { get; protected set; }
    public string Aciklama { get; set; }
    public GameObject[] EggSprite { get; set; }


    public void EggCreate(string _eggId, int _miktar, int[] tur, decimal _fiyat)
    {
        EggID = _eggId;
        Miktar = _miktar;
        Tur = tur;
        Fiyat = _fiyat;
    }

    public void EggCreate(string _eggId, int _miktar, int[] tur, decimal _fiyat, string aciklama)
    {
        EggID = _eggId;
        Miktar = _miktar;
        Tur = tur;
        Fiyat = _fiyat;
        Aciklama = aciklama;
    }

    public void EggCreate(string _eggId, int _miktar, int[] tur, decimal _fiyat, GameObject[] _spriteEgg)
    {
        EggID = _eggId;
        Miktar = _miktar;
        Tur = tur;
        Fiyat = _fiyat;
        EggSprite = _spriteEgg;
    }

    public virtual void EggPrice()
    {
        Efsanevi _a = new Efsanevi();
        
    }

}

using UnityEngine;
using TMPro;
using System;

public class Anliqsaat : MonoBehaviour
{
    public TextMeshProUGUI yerliSaatText;
    public TextMeshProUGUI londonSaatText;
    public TextMeshProUGUI moskvaSaatText;
    public TextMeshProUGUI parisSaatText;
    public TextMeshProUGUI tbilisiSaatText;
    public TextMeshProUGUI ankaraSaatText;

    void Update()
    {
        DateTime yerliSaat = DateTime.Now;
        yerliSaatText.text =  yerliSaat.ToString("HH:mm:ss");

        // London
        TimeZoneInfo londonZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        DateTime londonSaat = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, londonZone);
        londonSaatText.text = londonSaat.ToString("HH:mm:ss");

        // Moskva
        TimeZoneInfo moskvaZone = TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time");
        DateTime moskvaSaat = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, moskvaZone);
        moskvaSaatText.text = moskvaSaat.ToString("HH:mm:ss");

        // Paris
        TimeZoneInfo parisZone = TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time");
        DateTime parisSaat = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, parisZone);
        parisSaatText.text = parisSaat.ToString("HH:mm:ss");

        // Tbilisi
        TimeZoneInfo tbilisiZone = TimeZoneInfo.FindSystemTimeZoneById("Georgian Standard Time");
        DateTime tbilisiSaat = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, tbilisiZone);
        tbilisiSaatText.text = tbilisiSaat.ToString("HH:mm:ss");

        // Ankara (Istanbul saatı ilə eyni)
        TimeZoneInfo ankaraZone = TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time");
        DateTime ankaraSaat = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, ankaraZone);
        ankaraSaatText.text = ankaraSaat.ToString("HH:mm:ss");
    }
}

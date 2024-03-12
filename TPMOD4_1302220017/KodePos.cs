using System;
namespace tpmod4_1302220017;

using System.Collections.Generic;

public class KodePos
{
    private Dictionary<string, string> kodePosDictionary;

    public enum Kelurahan
    {
        Antapani_Kidul,
        Antapani_Kulon,
        Antapani_Tengah,
        Antapani_Wetan,
        Cibaduyut_Kidul,
        Cibaduyut_Wetan,
        Cibaduyut,
        Kebon_lega,
        Mekarwangi,
        Situsaeur,
        Kopo
    }

    public string GetKodePos(Kelurahan kelurahan)
    {
        String[] kodePos =
            {
            "40291", // Antapani_Kidul
            "40291", // Antapani_Kulon
            "40291", // Antapani_Tengah
            "40291", // Antapani_Wetan
            "40239", // Cibaduyut_Kidul
            "40238", // Cibaduyut_Wetan
            "40236", // Cibaduyut
            "40235", // Kebon_lega
            "40237", // Mekarwangi
            "40234", // Situsaeur
            "40233"  // Kopo
            };
        int index = (int)kelurahan;
        if (index >= 0 && index < kodePos.Length)
        {
            return kodePos[index];
        }
        return "Kode Pos Tidak Ditemukan";
    }
}

using System.Collections.Generic;

public class Team
{
    public string ImeNaEkip { get; set; }

    public string Syzdatel { get; set; }

    public List<string> Uchastnici { get; set; }

    public Team()
    {
        this.Uchastnici = new List<string>();
    }
}

﻿namespace WineCellar.Domain.Entities;

public class GrapeWine
{
    public int GrapesId { get; set; }
    public Grape Grape { get; set; }

    public int WinesId { get; set; }
    public Wine Wine { get; set; }
}
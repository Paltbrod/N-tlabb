using System;
using System.Collections.Generic;
public class Pokemon
{
    public string name { get; set; }

    public int id { get; set; }
    public bool is_default { get; set; }
    public List<ItemWrapper> held_items { get; set; }
}
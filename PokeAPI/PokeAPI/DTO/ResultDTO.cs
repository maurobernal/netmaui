namespace PokeAPI.DTO
{
    public class ItemDTO
    {
        public string name { get; set; }
        public string url { get; set; }  
    }
    public class CollectionDTO : List<ItemDTO>
    {
        public string Name { get; set; }
        public List<ItemDTO> Items { get; set; }

        public CollectionDTO(string name, List<ItemDTO> items) : base(items)
        {
            Name = name;
            Items = items;
        }
        public override string ToString()
        => Name; 
        
    }

}

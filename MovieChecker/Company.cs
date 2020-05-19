namespace MovieChecker
{
    class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Company(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public Company() { }
    }
}

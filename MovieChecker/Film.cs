namespace MovieChecker
{
    class Film
    {
        public int ID { get; set; }
        public string FilmName { get; set; }
        public Film(int ID, string FilmName)
        {
            this.ID = ID;
            this.FilmName = FilmName;
        }
        public Film() { }
    }
}

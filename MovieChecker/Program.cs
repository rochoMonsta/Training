using System;
using System.Collections.Generic;

namespace MovieChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Film> films = new List<Film>()
            {
                new Film(){ID = 1, FilmName = "The Godfather"},
                new Film(){ID = 1, FilmName = "The Godfather: Part II"},
                new Film(){ID = 1, FilmName = "Propala hramota"},
                new Film(){ID = 2, FilmName = "Pulp Fiction"},
                new Film(){ID = 3, FilmName = "The Shawshank Redemption"}
            };
            List<Company> companies = new List<Company>()
            {
                new Company(){ID = 1, Name = "Thunderstorm Pictures"},
                new Company(){ID = 2, Name = "Paramount Pictures"},
                new Company(){ID = 3, Name = "Warner Bros. Pictures"}
            };
            if (GetPercentOfCompanyGreed(companies, films) > 50)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadLine();
        }
        public static int GetPercentOfCompanyGreed(List<Company> companies, List<Film> films)
        {
            int total_percent = 0;
            int[] count_of_greed_fims = new int[companies.Count];

            int[] count_of_films_by_company = new int[companies.Count];

            ArrayInput(count_of_greed_fims);
            ArrayInput(count_of_films_by_company);

            GetCountOfFilmsByCompany(films, count_of_films_by_company);
            GetCountOfFilmsByNames(films, companies, count_of_greed_fims);

            for (int i = 0; i < companies.Count; ++i)
            {
                total_percent += (count_of_films_by_company[i] / count_of_greed_fims[i]) * 100; 
            }
            return total_percent / companies.Count;
        }
        public static void GetCountOfFilmsByCompany(List<Film> films, int[] array)
        {
            foreach (var element in films)
                array[element.ID - 1]++;
        }
        public static void GetCountOfFilmsByNames(List<Film> films, List<Company> companies, int[] array)
        {
            foreach (var element in films)
            {
                if (element.FilmName[0] == companies[element.ID - 1].Name[0])
                    array[element.ID - 1]++;
            }
        }
        public static void ArrayInput(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
                array[i] = 1;
        }
    }
}

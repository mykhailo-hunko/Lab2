using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Logics
    {
      public List<University> universities { get; set; }

        public void inizialaze()
        {
            universities = new List<University>();
            universities.Add(new University("NURE", 10, 120, 112, new List<string> {"Афанасьева Анна Николаевна", "Бондарь Олег Владимирович", "Гречмак Дмитрий Викторович", "Григоров Артем Андреевич" }, new List<string> { "Ткачев Виталий Николаевич", "Кораблев Николай Михайлович", "Фомичев Александр Александрович" }));
            universities.Add(new University("NURE2", 10, 120, 112, new List<string> { "Афанасьева Анна Николаевна", "Бондарь Олег Владимирович", "Гречмак Дмитрий Викторович", "Григоров Артем Андреевич" }, new List<string> { "Ткачев Виталий Николаевич", "Кораблев Николай Михайлович", "Фомичев Александр Александрович" }));
            universities.Add(new University("NURE3", 10, 120, 112, new List<string> { "Афанасьева Анна Николаевна", "Бондарь Олег Владимирович", "Гречмак Дмитрий Викторович", "Григоров Артем Андреевич" }, new List<string> { "Ткачев Виталий Николаевич", "Кораблев Николай Михайлович", "Фомичев Александр Александрович" }));
        }

    }
}

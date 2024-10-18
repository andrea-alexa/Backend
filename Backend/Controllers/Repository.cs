namespace Backend.Controllers
{
    public class Repository
    {
        public static List<PersonaDatos> persona = new List<PersonaDatos>
        {
            new PersonaDatos()
            {
                id = 1,
                age = new DateTime(2005,06,28),
                name = "Andrea Alexandra Nuñez"
            },

            new PersonaDatos()
            {
                id = 2,
                age = new DateTime(2005,06, 29),
                name = "Andrea Alexandra"
            },

            new PersonaDatos()
            {
                id = 3,
                age = new DateTime(2005,06, 30),
                name = "Andrea"
            }
        };
    }
}

public class PersonaDatos
{
    public int id { get; set; }
    public string name { get; set; }
    public DateTime age { get; set; }
}

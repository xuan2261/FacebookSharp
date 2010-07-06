using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FacebookSharp.Schemas.Graph
{
    [DataContract]
    public class User : GraphObject
    {
        [DataMember(Name = "first_name")]
        public string FirstName { get; set; }

        [DataMember(Name = "last_name")]
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string About { get; set; }
        public string Birthday { get; set; }
        public HomeTownLocation HomeTown { get; set; }
        public Location Location { get; set; }
        public List<Work> Work { get; set; }

        // todo: education

        public string Gender { get; set; }
        public string Relationship_Status { get; set; }
        public string Significant_Other { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int Timezone { get; set; }
        public string Updated_Time { get; set; }
        public string Hometown { get; set; }

        public List<string> Interested_In { get; set; }
        public List<string> Meeting_For { get; set; }

        public string Religion { get; set; }
        public string Political { get; set; }

        // todo: posts, home,tagged,friends,family

    }

    public class UserCollection : Connection<User> { }
}